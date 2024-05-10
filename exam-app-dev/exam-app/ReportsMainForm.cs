using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_app
{
	public partial class ReportsMainForm : Form
	{
		public ReportsMainForm()
		{
			InitializeComponent();
		}

		private void btn_crsTopic_Click(object sender, EventArgs e)
		{
			var reportForm = new ReportGetCrsTopics();
			reportForm.ShowDialog();
		}

		private void btn_stdGrades_Click(object sender, EventArgs e)
		{
			var reportForm = new GetStudentExamsAndGradesReportForm();
			reportForm.ShowDialog();
		}

		private void btn_examDetails_Click(object sender, EventArgs e)
		{
			var reportForm = new GetExamDetailsReportForm();
			reportForm.ShowDialog();
		}

		private void insCrsWIthStdNum_Click(object sender, EventArgs e)
		{
			var reportForm = new ReportGetInsCrsWithStdNumForm();
			reportForm.ShowDialog();
		}

		private void btn_stdInfo_Click(object sender, EventArgs e)
		{
			var reportForm = new StudentInfoPerTrackReportForm();
			reportForm.ShowDialog();
		}

		private void btn_stdExams_Click(object sender, EventArgs e)
		{
			var reportForm = new ReportStdExamDetailsForm();
			reportForm.ShowDialog();
		}
	}
}
