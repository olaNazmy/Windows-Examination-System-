using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace exam_app
{
    public partial class CreateQuestionsForm : Form
    {
        ItidbContext context;
        int Ins_id { get; set; }
        public CreateQuestionsForm(int Ins_id)
        {
            this.Ins_id = Ins_id;
            context = new ItidbContext();
            InitializeComponent();
        }

        private void CreateQuestionsForm_Load(object sender, EventArgs e)
        {
            DefaultStart();
            getInstructorCourses();
            cb_QuestionType.SelectedIndex = 0;
            cb_TorF_ans.SelectedIndex = -1;
            Cb_CorrectAnswer.SelectedIndex = -1;
        }

        void getInstructorCourses()
        {
            var instructorCourses = context.InsCourses.Where((ins_crs) => ins_crs.InsId == Ins_id)
                .Select(x => new { x.CrsId, x.Crs.CrsName });

            cb_Courses.DisplayMember = "CrsName";
            cb_Courses.ValueMember = "CrsId";
            cb_Courses.DataSource = instructorCourses.ToList();
            cb_Courses.SelectedIndex = 0;
        }

        void DefaultStart()
        {
            btn_UpdateQuestion.Visible = false;
            btn_DeleteQuestion.Visible = false;

            cb_TorF_ans.Visible = true;
            Answer.Visible = true;

            Choice1.Visible = false;
            Choice2.Visible = false;
            Choice3.Visible = false;
            Choice4.Visible = false;

            Correct_Answer.Visible = false;
            Cb_CorrectAnswer.Visible = false;

            txt_Choice1.Visible = false;
            txt_Choice2.Visible = false;
            txt_Choice3.Visible = false;
            txt_Choice4.Visible = false;
        }

        void MultiplChoicesScreen()
        {
            cb_TorF_ans.Visible = false;
            Answer.Visible = false;

            Choice1.Visible = true;
            Choice2.Visible = true;
            Choice3.Visible = true;
            Choice4.Visible = true;

            Correct_Answer.Visible = true;
            Cb_CorrectAnswer.Visible = true;

            txt_Choice1.Visible = true;
            txt_Choice2.Visible = true;
            txt_Choice3.Visible = true;
            txt_Choice4.Visible = true;
        }

        void UpdateDGV()
        {
            DGV_Crs_Questions.DataSource = context.Questions
               .Where(Question => Question.CourseId == (int)cb_Courses.SelectedValue)
               .Select(Question => new
               {
                   Question.QId,
                   Question.Course.CrsName,
                   Question.QType,
                   Question.QContent,
                   Question.ModelAnswer,

               })
               .ToList();

            DGV_Crs_Questions.Columns["QId"].Visible = false;

            DVG_Question_Choices.DataSource = context.Questions
                .SelectMany(Question => Question.QuestionChoices,
                        (Question, QuestionChoices) => new { Question, QuestionChoices.QChoice })
           .Where(Question => Question.Question.CourseId == (int)cb_Courses.SelectedValue && Question.Question.QType == "Choose")
           .Select(q => new { q.Question.QContent, q.QChoice })
           .ToList();
        }

        private void cb_Courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Courses.SelectedIndex !=0 )
            {
                UpdateDGV();
            }
        }

        private void cb_QuestionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_QuestionType.SelectedIndex == 0)
            {
                DefaultStart();
            }
            else
            {
                MultiplChoicesScreen();

            }
        }

        private void btn_AddQuestion_Click(object sender, EventArgs e)
        {
            if (cb_QuestionType.SelectedIndex == 0)
            {
                if (txt_QuesContent.Text == "" || cb_TorF_ans.SelectedIndex == -1)
                {
                    MessageBox.Show("Fill All input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                var questionIdParameter = new SqlParameter("@questionId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                context.Database.ExecuteSqlRaw("EXEC addQuestion @quest_content, @quest_type, @modelAns, @Course_id, @questionId",
                        new SqlParameter("@quest_content", txt_QuesContent.Text),
                        new SqlParameter("@quest_type", "TorF"),
                        new SqlParameter("@modelAns", cb_TorF_ans.Text),
                        new SqlParameter("@Course_id", (int)cb_Courses.SelectedValue),
                        questionIdParameter
                        );

                MessageBox.Show("Question Added");
                UpdateDGV();
            }
            else
            {
                if (txt_QuesContent.Text == "" || txt_Choice1.Text == "" || txt_Choice2.Text == "" ||
                    txt_Choice3.Text == "" || txt_Choice4.Text == "" || Cb_CorrectAnswer.SelectedIndex == -1)
                {
                    MessageBox.Show("Fill All input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string correctanswer = "";
                if (Cb_CorrectAnswer.SelectedIndex == 0) { correctanswer = txt_Choice1.Text; }
                else if (Cb_CorrectAnswer.SelectedIndex == 1) { correctanswer = txt_Choice2.Text; }
                else if (Cb_CorrectAnswer.SelectedIndex == 2) { correctanswer = txt_Choice3.Text; }
                else correctanswer = txt_Choice4.Text;

                var questionIdParameter = new SqlParameter("@questionId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                context.Database.ExecuteSqlRaw("EXEC addQuestion @quest_content, @quest_type, @modelAns, @Course_id, @questionId OUTPUT",
                        new SqlParameter("@quest_content", txt_QuesContent.Text),
                        new SqlParameter("@quest_type", "Choose"),
                        new SqlParameter("@modelAns", correctanswer),
                        new SqlParameter("@Course_id", (int)cb_Courses.SelectedValue),
                         questionIdParameter
                        );

                int questionId = (int)questionIdParameter.Value;

                context.Database.ExecuteSqlRaw("EXEC addQuestionChoices @question_id, @choice1, @choice2, @choice3, @choice4",
                       new SqlParameter("@question_id", questionId),
                       new SqlParameter("@choice1", txt_Choice1.Text),
                       new SqlParameter("@choice2", txt_Choice2.Text),
                       new SqlParameter("@choice3", txt_Choice3.Text),
                       new SqlParameter("@choice4", txt_Choice4.Text)

                       );
                MessageBox.Show("Question Added");
                UpdateDGV();
            }
        }

        private void btn_UpdateQuestion_Click(object sender, EventArgs e)
        {
            if (selectedQuestionType == "Choose")
            {
                string correctanswer = "";
                if (Cb_CorrectAnswer.SelectedIndex == 0) { correctanswer = txt_Choice1.Text; }
                else if (Cb_CorrectAnswer.SelectedIndex == 1) { correctanswer = txt_Choice2.Text; }
                else if (Cb_CorrectAnswer.SelectedIndex == 2) { correctanswer = txt_Choice3.Text; }
                else correctanswer = txt_Choice4.Text;

                context.Database.ExecuteSqlRaw("EXEC updateQuestion @questionId, @quest_content, @quest_type, @modelAns, @Course_id",
                          new SqlParameter("@questionId", selectedQuestionId),
                          new SqlParameter("@quest_content", txt_QuesContent.Text),
                          new SqlParameter("@quest_type", "Choose"),
                          new SqlParameter("@modelAns", correctanswer),
                            new SqlParameter("@Course_id", (int)cb_Courses.SelectedValue)
                          );

                context.Database.ExecuteSqlRaw("EXEC UpdateQuestionChoices @question_id, @choice1, @choice2, @choice3, @choice4",
                        new SqlParameter("@question_id", selectedQuestionId),
                        new SqlParameter("@choice1", txt_Choice1.Text),
                        new SqlParameter("@choice2", txt_Choice2.Text),
                        new SqlParameter("@choice3", txt_Choice3.Text),
                        new SqlParameter("@choice4", txt_Choice4.Text)

                        );
            }
            else
            {
                context.Database.ExecuteSqlRaw("EXEC updateQuestion @questionId, @quest_content, @quest_type, @modelAns, @Course_id",
                         new SqlParameter("@questionId", selectedQuestionId),
                         new SqlParameter("@quest_content", txt_QuesContent.Text),
                         new SqlParameter("@quest_type", "TorF"),
                         new SqlParameter("@modelAns", cb_TorF_ans.Text),
                         new SqlParameter("@Course_id", (int)cb_Courses.SelectedValue)
                         );
            }


            MessageBox.Show("Question Updated");
            UpdateDGV();
        }

        private void btn_DeleteQuestion_Click(object sender, EventArgs e)
        {
            context.Database.ExecuteSqlRaw("EXEC deleteQuestion @questionId",
               new SqlParameter("@questionId", selectedQuestionId));

            if (selectedQuestionType == "Choose")
            {
                context.Database.ExecuteSqlRaw("EXEC deleteQuestionChoices @questionId",
                   new SqlParameter("@questionId", selectedQuestionId));
            }

            MessageBox.Show("Question Deleted");

            UpdateDGV();
        }

        int selectedQuestionId = 0;
        string selectedQuestionType = "";
        private void DGV_Crs_Questions_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_UpdateQuestion.Visible = true;
            btn_DeleteQuestion.Visible = true;

            if (e.RowIndex >= 0) // Check if a valid row header is double-clicked
            {
                DataGridViewRow row = DGV_Crs_Questions.Rows[e.RowIndex];

                // Assuming that the SelectedQuestionId is in a specific column, for example, column with index 0
                if (row.Cells[0].Value != null)
                {
                    selectedQuestionId = Convert.ToInt32(row.Cells[0].Value);

                    selectedQuestionType = (string)row.Cells["QType"].Value;

                    if (selectedQuestionType == "Choose")
                    {
                        cb_QuestionType.SelectedIndex = 1;

                        txt_QuesContent.Text = (string)row.Cells["QContent"].Value;

                        var questionChoices = context.QuestionChoices
                            .Where(choice => choice.QId == selectedQuestionId)
                            .Select(choice => choice.QChoice).ToList();

                        txt_Choice1.Text = (string)questionChoices[0];
                        txt_Choice2.Text = (string)questionChoices[1];
                        txt_Choice3.Text = (string)questionChoices[2];
                        txt_Choice4.Text = (string)questionChoices[3];

                        if ((string)questionChoices[0] == (string)row.Cells["ModelAnswer"].Value)
                            Cb_CorrectAnswer.SelectedIndex = 0;
                        else if ((string)questionChoices[1] == (string)row.Cells["ModelAnswer"].Value)
                            Cb_CorrectAnswer.SelectedIndex = 1;
                        else if ((string)questionChoices[2] == (string)row.Cells["ModelAnswer"].Value)
                            Cb_CorrectAnswer.SelectedIndex = 2;
                        else
                            Cb_CorrectAnswer.SelectedIndex = 3;


                    }
                    else
                    {
                        cb_QuestionType.SelectedIndex = 0;
                        DefaultStart();
                        btn_UpdateQuestion.Visible = true;
                        btn_DeleteQuestion.Visible = true;

                        txt_QuesContent.Text = (string)row.Cells["QContent"].Value;

                        if ((string)row.Cells["ModelAnswer"].Value == "True")
                            cb_TorF_ans.SelectedIndex = 0;
                        else
                        {
                            cb_TorF_ans.SelectedIndex = 1;
                        }
                    }
                }
            }


        }

        private void DVG_Question_Choices_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_UpdateQuestion.Visible = true;
            btn_DeleteQuestion.Visible = true;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            InstructorMainForm insMainForm = new InstructorMainForm(Ins_id);
            Hide();
            insMainForm.ShowDialog();
            Close();
        }
    }
}
