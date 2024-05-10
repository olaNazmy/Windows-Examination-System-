using System;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using exam_app.DataSets;
using static exam_app.DataSets.StudentsInfoPerTrack;
using exam_app.Models;
using exam_app.HelperClass;
namespace exam_app
{
    public partial class StudentInfoPerTrackReportForm : Form
    {
        ItidbContext context;
        public StudentInfoPerTrackReportForm()
        {
            context = new ItidbContext();
            InitializeComponent();
        }

        private void StudentInfoPerTrackReportForm_Load(object sender, EventArgs e)
        {
            getAllTracks();
        }

        void getAllTracks()
        {
            CB_Track.DisplayMember = "TrName";
            CB_Track.ValueMember = "TrId";
            CB_Track.DataSource = context.Tracks.ToList();
        }
        private void CB_Track_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Instantiate the TableAdapter

        }

        private void button1_Click(object sender, EventArgs e)
        {
            exam_app.DataSets.StudentsInfoPerTrackTableAdapters.get_Students_By_TrackIdTableAdapter adapter =
    new exam_app.DataSets.StudentsInfoPerTrackTableAdapters.get_Students_By_TrackIdTableAdapter();

            // Instantiate the DataSet or DataTable
            exam_app.DataSets.StudentsInfoPerTrack.get_Students_By_TrackIdDataTable StudentsInfoPerTrack =
                new exam_app.DataSets.StudentsInfoPerTrack.get_Students_By_TrackIdDataTable();

            // Call the Fill method of the TableAdapter and pass the trackId parameter
            adapter.Fill(StudentsInfoPerTrack, (int)CB_Track.SelectedValue);

            var data = adapter.GetData((int)CB_Track.SelectedValue);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("StudentsInfoPerTrack", (DataTable)data));
            reportViewer1.LocalReport.ReportPath = FileClass.GetProjectFolderPath() + "\\Reports\\StudentsInfoPerTrack.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}
