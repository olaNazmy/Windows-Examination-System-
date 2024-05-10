using exam_app.Models;
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
using exam_app.DataSets;
using exam_app.HelperClass;
namespace exam_app
{
    public partial class GetStudentExamsAndGradesReportForm : Form
    {
        ItidbContext context;
        public GetStudentExamsAndGradesReportForm()
        {
            context = new ItidbContext();
            InitializeComponent();
        }

        private void GetStudentExamsAndGradesReportForm_Load(object sender, EventArgs e)
        {
            GetAllStudents();
        }
        private void CB_StudentNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Instantiate the TableAdapter
            exam_app.DataSets.GetStudentExamsAndGradesTableAdapters.GetStudentExamsAndGradesTableAdapter adapter =
                new ();

            // Instantiate the DataSet or DataTable
            exam_app.DataSets.GetStudentExamsAndGrades.GetStudentExamsAndGradesDataTable ExamDetails =
                new ();

            // Call the Fill method of the TableAdapter and pass the Id parameter
            adapter.Fill(ExamDetails, (int)CB_StudentNames.SelectedValue);

            var data = adapter.GetData((int)CB_StudentNames.SelectedValue);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("GetStudentExamsAndGrades", (DataTable)data));
            reportViewer1.LocalReport.ReportPath = FileClass.GetProjectFolderPath()+"\\Reports\\GetStudentExamsAndGrades.rdlc";
            reportViewer1.RefreshReport();
        }

        void GetAllStudents()
        {
            CB_StudentNames.DisplayMember = "Name";
            CB_StudentNames.ValueMember = "StId";
            CB_StudentNames.DataSource = context.Students.Select(s => new {Name = s.StFname + ' ' + s.StLname, s.StId}).ToList();
        }

    }
}
