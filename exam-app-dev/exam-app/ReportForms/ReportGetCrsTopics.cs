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
    public partial class ReportGetCrsTopics : Form
    {
        ItidbContext dbContext;
        CrsTopic _dataSet;

        public ReportGetCrsTopics()
        {
            InitializeComponent();
            dbContext = new ItidbContext();
            _dataSet = new CrsTopic();

        }

        private void ReportGetCrsTopics_Load(object sender, EventArgs e)
        {
            loadCourseName();
        }

        void loadCourseName()
        {
            cmb_crs_name.DataSource = dbContext.Courses.Select(x => new { id = x.CrsId, name = x.CrsName }).ToList();
            cmb_crs_name.ValueMember = "id";
            cmb_crs_name.DisplayMember = "name";

            cmb_crs_name.SelectedIndex = -1;

        }

        private void btn_generate_report_Click(object sender, EventArgs e)
        {
            if (cmb_crs_name.SelectedIndex != -1)
            {
                var result = dbContext.Database.SqlQuery<GetCrsTopics>($"exec GetTopicsForCourse {(int)cmb_crs_name.SelectedValue}")
                  .AsNoTracking()
              .ToList();

                _dataSet.GetTopicsForCourse.Clear();

                foreach (var item in result)
                {
                    var row = _dataSet.GetTopicsForCourse.NewGetTopicsForCourseRow();
                    row.Topic_name = item.topicName;    
                    _dataSet.GetTopicsForCourse.AddGetTopicsForCourseRow(row);

                }
                try
                {
                    string reportFilePath =  FileClass.GetProjectFolderPath()+"\\Reports\\getCourseTopic.rdlc";

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", _dataSet.Tables["GetTopicsForCourse"]));
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

    class GetCrsTopics
    {
        public string topicName { get; set; }
    }
}
