using exam_app.Models;
using exam_app.DataSets;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using exam_app.HelperClass;
namespace exam_app
{
    public partial class GetExamDetailsReportForm : Form
    {
        ItidbContext context;
        public GetExamDetailsReportForm()
        {
            context = new ItidbContext();
            InitializeComponent();
        }

        private void CB_ExamSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubjectExams();
        }

        private void CB_ExamId_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Instantiate the TableAdapter
            exam_app.DataSets.GetExamDetailsTableAdapters.GetExamDetailsTableAdapter adapter =
                new exam_app.DataSets.GetExamDetailsTableAdapters.GetExamDetailsTableAdapter();

            // Instantiate the DataSet or DataTable
            exam_app.DataSets.GetExamDetails.GetExamDetailsDataTable ExamDetails =
                new exam_app.DataSets.GetExamDetails.GetExamDetailsDataTable();

            // Call the Fill method of the TableAdapter and pass the Id parameter
            adapter.Fill(ExamDetails, (int) CB_ExamId.SelectedValue);

            var data = adapter.GetData((int)CB_ExamId.SelectedValue);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("GetExamDetails", (DataTable)data));
            reportViewer1.LocalReport.ReportPath = FileClass.GetProjectFolderPath()+"\\Reports\\ExamDetails.rdlc";
            reportViewer1.RefreshReport();
        }

        void GetAllSubjects()
        {
            CB_ExamSubject.DisplayMember = "CrsName";
            CB_ExamSubject.ValueMember = "CrsId";
            CB_ExamSubject.DataSource = context.Courses.ToList();
        }

        void SubjectExams()
        {
           
            CB_ExamId.DisplayMember = "ExId";
            CB_ExamId.ValueMember = "ExId";
            CB_ExamId.DataSource = context.Exams.Where(exam => exam.CourseId == (int)CB_ExamSubject.SelectedValue)
                .ToList();
        }

        private void GetExamDetailsReportForm_Load(object sender, EventArgs e)
        {
            GetAllSubjects();
            SubjectExams();
        }
    }
}
