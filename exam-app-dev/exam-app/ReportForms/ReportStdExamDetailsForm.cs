using exam_app.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using exam_app.HelperClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using exam_app.DataSets;

namespace exam_app
{
    public partial class ReportStdExamDetailsForm : Form
    {
        ItidbContext appContext;
        GetExamDetailsForSTD _dataSet;

        public ReportStdExamDetailsForm()
        {
            InitializeComponent();
            appContext = new ItidbContext();
            _dataSet = new GetExamDetailsForSTD();


        }

        private void ReportStdExamDetailsForm_Load(object sender, EventArgs e)
        {
            loadStdThatTakedExams();
        }

        void loadStdThatTakedExams()
        {
            var students = appContext.Students
            .Join(
                    appContext.ExamStdQuestions,
                    student => student.StId,
                    examStdQuestion => examStdQuestion.StId,
                    (student, examStdQuestion) => student
            )
            .Distinct() // To ensure unique students
            .ToList();
            var std = students.Select(x => new { id = x.StId, name = x.StFname + " " + x.StLname }).ToList();
            cmb_std_names.DataSource = std;
            cmb_std_names.ValueMember = "id";
            cmb_std_names.DisplayMember = "name";
            cmb_std_names.SelectedIndex = -1;

        }

        private void cmb_std_names_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_std_names.SelectedIndex != -1)
            {
                int stdId = (int)cmb_std_names.SelectedValue;
                var exams = appContext.Exams
                     .Where(exam => exam.StudentExams.Any(s => s.StudentId == stdId))
                     .Select(x => new { id = x.ExId, Name = x.ExamName });

                cmb_exams.DataSource = exams.ToList();
                cmb_exams.ValueMember = "id";
                cmb_exams.DisplayMember = "name";

                label2.Text = "exams of:  "+cmb_std_names.Text;
            }
            else
            {
                MessageBox.Show("select student at first");
            }
        }

        private void generate_report_Click(object sender, EventArgs e)
        {
            if (cmb_std_names.SelectedIndex != -1)
            {
                var result = appContext.Database.SqlQuery<GetExamStdDetails>($"exec GetExamDetailsForStudent {(int)cmb_std_names.SelectedValue}, {(int)cmb_exams.SelectedValue}")
                   .AsNoTracking()
               .ToList();

                _dataSet.GetExamDetailsForStudent.Clear();

                foreach (var item in result)
                {
                    var row = _dataSet.GetExamDetailsForStudent.NewGetExamDetailsForStudentRow();
                    row.Q_content = item.Q_content;
                    row.Model_answer = item.Model_answer;
                    row.Std_answer = item.Std_answer;
                    _dataSet.GetExamDetailsForStudent.AddGetExamDetailsForStudentRow(row);
                }

                try
                {
                    
                    string reportFilePath = FileClass.GetProjectFolderPath() + "\\Reports\\getStdExamDetails.rdlc";

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", _dataSet.Tables["GetExamDetailsForStudent"]));
                    reportViewer1.LocalReport.ReportPath = reportFilePath;
                   
                    reportViewer1.RefreshReport();
                   
                }
                catch (Exception ex)
                {
                    // Handle/report the exception
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }


    public class GetExamStdDetails
    {
        public string Q_content { get; set; }
        public string Model_answer { get; set; }
        public string Std_answer { get; set; }
    }
}
