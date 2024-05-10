using exam_app.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace exam_app
{

    public partial class CreateExamForm : Form
    {

        int instructor_id ; // this is from prevoius form

        ItidbContext appContext = new ItidbContext();
        List<object> examDataList = new List<object>();
        List<createdExam> createdExams = new List<createdExam>();
        int selectedExamId;
        public CreateExamForm(int _insId)
        {
            InitializeComponent();
            instructor_id = _insId;
        }

        private void CreateExamForm_Load(object sender, EventArgs e)
        {
            DTP_examDate.Format = DateTimePickerFormat.Custom;
            DTP_examDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";

            getAllInsCourses();
            lst_createdExam.View = View.List;
        }

        void getAllInsCourses()
        {
            var inst_crses = appContext.InsCourses.Where((ins_crs) => ins_crs.InsId == instructor_id).Select(x => new { x.CrsId, x.Crs.CrsName }).ToList();
            cmb_ins_courses.DataSource = inst_crses;
            cmb_ins_courses.DisplayMember = "CrsName";
            cmb_ins_courses.ValueMember = "CrsId";
            cmb_ins_courses.SelectedIndex = -1;
        }

        private void btn_generate_exam_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Fill All input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((int.Parse(cmb_noOfTFQ.Text) + (int.Parse(cmb_noChooseQ.Text))) == 10)
                {
                    if (isQuestionsAvailable())
                    {
                        DialogResult dialog = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog.Equals(DialogResult.Yes))
                        {

                            // generate the exam with using stored proc
                            var out_param = new SqlParameter("@param", SqlDbType.Int);
                            out_param.Direction = ParameterDirection.Output;
                            var result = appContext.Database.ExecuteSqlRaw(
                                "EXEC generateExam @courseId, @examName, @numOfTF, @numOfChoose, @examDuration, @examDate, @param OUTPUT",
                                new SqlParameter("@courseId", (int)cmb_ins_courses.SelectedValue),
                                new SqlParameter("@examName", txt_exam_name.Text),
                                new SqlParameter("@numOfChoose", cmb_noChooseQ.Text),
                                new SqlParameter("@numOfTF", cmb_noOfTFQ.Text),
                                new SqlParameter("@examDuration", txt_exam_duration.Text),
                                new SqlParameter("@examDate", DTP_examDate.Value),
                                out_param);
                            int exam_id = (int)out_param.Value;

                            // display exam questions
                            getExamQuestions(exam_id);


                            // add the exam name to lstView and created exam into createdExams list to navigate between
                            ListViewItem item = new ListViewItem(txt_exam_name.Text);
                            lst_createdExam.Items.Add(item);
                            createdExams.Add(new createdExam()
                            {
                                Exam = new Exam
                                {
                                    ExId = exam_id,
                                    ExamName = txt_exam_name.Text,
                                    ExDate = DTP_examDate.Value,
                                    ExDuration = int.Parse(txt_exam_duration.Text),
                                    CourseId = (int)cmb_ins_courses.SelectedValue,
                                },
                                Choose_num = int.Parse(cmb_noChooseQ.Text),
                                TF_num = int.Parse(cmb_noOfTFQ.Text),
                            });
                            selectedExamId = exam_id;

                            MessageBox.Show("generated successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();
                        }
                    }
                    else
                        MessageBox.Show("there is not enough questions \n exam is not created", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {
                    MessageBox.Show("total num of quesetions should be 10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void lst_createdExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_createdExam.SelectedIndices.Count > 0)
            {
                createdExam Element = createdExams[lst_createdExam.SelectedIndices[0]];
                txt_exam_name.Text = Element.Exam.ExamName;
                txt_exam_duration.Text = Element.Exam.ExDuration.ToString();
                DTP_examDate.Text = Element.Exam.ExDate.ToString();
                cmb_ins_courses.SelectedValue = Element.Exam.CourseId;
                cmb_noOfTFQ.Text = Element.TF_num.ToString();
                cmb_noChooseQ.Text = Element.Choose_num.ToString();

                selectedExamId = Element.Exam.ExId;
                getExamQuestions(selectedExamId);

            }
        }


        bool isEmpty()
        {
            if (cmb_ins_courses.SelectedIndex == -1 || cmb_noChooseQ.SelectedIndex == -1 || cmb_noChooseQ.SelectedIndex == -1
                 || txt_exam_duration.Text == "" || txt_exam_name.Text == "")
                return true;
            return false;
        }

        private void btn_update_exam_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Fill All input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult dialog = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog.Equals(DialogResult.Yes))
                {
                    //MessageBox.Show("selected exam is: " + selectedExamId.ToString());

                    // update exam data
                    appContext.Database.ExecuteSqlRaw("EXEC updateExam @examId, @examName, @examDate, @examDuration, @crsId",
                        new SqlParameter("@examId", selectedExamId),
                        new SqlParameter("@examName", txt_exam_name.Text),
                        new SqlParameter("@examDate", DTP_examDate.Value),
                        new SqlParameter("@examDuration", txt_exam_duration.Text),
                        new SqlParameter("@crsId", (int)cmb_ins_courses.SelectedValue)
                        );

                    // update created Exam list
                    if (lst_createdExam.SelectedIndices.Count > 0)
                    {

                        int index = lst_createdExam.SelectedIndices[0];
                        createdExam Element = createdExams[lst_createdExam.SelectedIndices[0]];

                        Element.Exam.ExamName = txt_exam_name.Text;
                        Element.Exam.ExDuration = int.Parse(txt_exam_duration.Text);
                        Element.Exam.ExDate = DTP_examDate.Value;
                        Element.Exam.CourseId = (int)cmb_ins_courses.SelectedValue;

                        lst_createdExam.SelectedItems[0].Text = txt_exam_name.Text;

                        lst_createdExam.Refresh();

                    }
                    MessageBox.Show("updated successfully \n exam question the same", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
        }

        void clear()
        {
            txt_exam_name.Text = "";
            txt_exam_duration.Text = "";
            DTP_examDate.Text = "";
            cmb_ins_courses.SelectedIndex = -1;
            cmb_noOfTFQ.SelectedIndex = -1;
            cmb_noChooseQ.SelectedIndex = -1;
        }
        void fillData()
        {
            txt_exam_name.Text = "sss";
            txt_exam_duration.Text = "60";
            DTP_examDate.Text = "2022-5-5 10:2:2 AM";
            cmb_ins_courses.SelectedIndex = 0;
            cmb_noOfTFQ.SelectedIndex = 4;
            cmb_noChooseQ.SelectedIndex = 4;
        }
        void getExamQuestions(int examId)
        {
            DGV_exam_question.DataSource = appContext.Exams
                         .Where(exam => exam.ExId == examId)
                         .SelectMany(e => e.QIds) // Flatten the results
                         .Select(x => new { type = x.QType, question = x.QContent, model_answer = x.ModelAnswer })
                         .ToList();
        }

        private void btn_regenerate_Q_Click(object sender, EventArgs e)
        {
            if (cmb_noChooseQ.SelectedIndex == -1 || cmb_noOfTFQ.SelectedIndex == -1 || cmb_ins_courses.SelectedIndex == -1 || lst_createdExam.Items.Count == 0)
            {
                MessageBox.Show("select  exam first");
            }
            else
            {
                if (int.Parse(cmb_noChooseQ.Text) + int.Parse(cmb_noOfTFQ.Text) == 10)
                {
                    if (isQuestionsAvailable())
                    {
                        DialogResult dialog = MessageBox.Show("exam questions are giong to be regenerated \n are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            appContext.Database.ExecuteSqlRaw("EXEC regenerateExamQuestions @examId, @numOfTF, @numOfChoose, @crsId",
                               new SqlParameter("@examId", selectedExamId),
                               new SqlParameter("@numOfTF", cmb_noOfTFQ.Text),
                               new SqlParameter("@numOfChoose", cmb_noChooseQ.Text),
                               new SqlParameter("@crsId", (int)cmb_ins_courses.SelectedValue)
                               );

                            getExamQuestions(selectedExamId);

                            if (lst_createdExam.SelectedIndices.Count > 0)
                            {
                                createdExam exam = createdExams[lst_createdExam.SelectedIndices[0]];
                                exam.Exam.CourseId = (int)cmb_ins_courses.SelectedValue;
                                exam.Choose_num = int.Parse(cmb_noChooseQ.Text);
                                exam.TF_num = int.Parse(cmb_noOfTFQ.Text);
                            }
                            clear();

                        }
                    }
                    else
                        MessageBox.Show("there is not enough questions \n questions are not regenerated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("number of exam questions should be 10", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }


            }

        }

        private void btn_del_exam_Click(object sender, EventArgs e)
        {

            if (createdExams.Count() > 0 && txt_exam_name.Text != "" && lst_createdExam.SelectedItems.Count > 0)
            {

                DialogResult dialog = MessageBox.Show($"exam {txt_exam_name.Text} will be deleted \n are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    Exam s = appContext.Exams.Include(e => e.QIds).FirstOrDefault(n => n.ExId == selectedExamId);
                    if (s != null)
                    {
                        // Remove related records from the Exam_Question table
                        foreach (var question in s.QIds.ToList())
                        {
                            s.QIds.Remove(question);
                        }

                        // Now you can safely remove the Exam record
                        appContext.Exams.Remove(s);
                        appContext.SaveChanges();
                    }
                    for (int i = lst_createdExam.Items.Count - 1; i >= 0; i--)
                    {
                        if (lst_createdExam.Items[i].Text == txt_exam_name.Text)
                        {
                            // Remove the item from the ListView
                            lst_createdExam.Items.RemoveAt(i);
                            createdExams.RemoveAt(i);
                            break;
                        }
                    }
                    DGV_exam_question.DataSource = null;
                    clear();

                }

            }
            else
            {
                MessageBox.Show("select exam first");
            }
        }

        private bool isQuestionsAvailable()
        {
            int numOfTFReqQues = int.Parse(cmb_noOfTFQ.Text);
            int numOfChooseqQues = int.Parse(cmb_noChooseQ.Text);
            int courseID = (int)cmb_ins_courses.SelectedValue;

            int numOfTFReqAvail = appContext.Questions.Where(q => q.CourseId == courseID && q.QType == "TorF").Count();
            int numOfChooseReqAvail = appContext.Questions.Where(q => q.CourseId == courseID && q.QType == "Choose").Count();

            if (numOfTFReqAvail >= numOfTFReqQues && numOfChooseReqAvail >= numOfChooseqQues)
                return true;

            return false;

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            InstructorMainForm insMainForm = new InstructorMainForm(instructor_id);
            Hide();
            insMainForm.ShowDialog();
            Close();
        }
    }

    class createdExam
    {
        public Exam Exam { get; set; }
        public int TF_num { get; set; }
        public int Choose_num { get; set; }
    }
}
