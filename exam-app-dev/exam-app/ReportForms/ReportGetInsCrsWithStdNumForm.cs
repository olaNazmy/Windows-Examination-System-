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
    public partial class ReportGetInsCrsWithStdNumForm : Form
    {
        ItidbContext appContext;
        InsCrsStdNum _dataSet;

        public ReportGetInsCrsWithStdNumForm()
        {
            InitializeComponent();
            appContext = new ItidbContext();
            _dataSet = new InsCrsStdNum();
        }

        private void ReportGetInsCrsWithStdNumForm_Load(object sender, EventArgs e)
        {
            loadIns();
        }

        void loadIns()
        {
            cmb_ins_name.DataSource = appContext.Instructors.Select(x => new { id = x.InsId, name = x.InsFname + x.InsLname }).ToList();
            cmb_ins_name.DisplayMember = "name";
            cmb_ins_name.ValueMember = "id";
            cmb_ins_name.SelectedIndex = -1;
        }

        private void btn_getInsInfo_Click(object sender, EventArgs e)
        {
            if (cmb_ins_name.SelectedIndex != -1)
            {
                var result = appContext.Database.SqlQuery<CrsStdNum>($"exec GetInsCrsWithStdCount {(int)cmb_ins_name.SelectedValue}")
                   .AsNoTracking()
               .ToList();

                _dataSet.GetInsCrsWithStdCount.Clear();

                foreach (var item in result)
                {
                    var row = _dataSet.GetInsCrsWithStdCount.NewGetInsCrsWithStdCountRow();
                    row.Course_Name = item.Course_Name;
                    row.Number_Of_Students = item.Number_Of_Students;
                    _dataSet.GetInsCrsWithStdCount.AddGetInsCrsWithStdCountRow(row);
                }

                try
                {

                    string reportFilePath = FileClass.GetProjectFolderPath() + "\\Reports\\getInsCrsWithStdNum.rdlc";

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", _dataSet.Tables["GetInsCrsWithStdCount"]));
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

    public class CrsStdNum
    {
        public string Course_Name { get; set; }
        public  int Number_Of_Students { get; set; }
    }
}
