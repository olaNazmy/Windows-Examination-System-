using exam_app.Models;
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
	public partial class InstructorMainForm : Form
	{
		int currInsId;
		ItidbContext itiContext;
		public InstructorMainForm(int insId)
		{
			InitializeComponent();
			currInsId = insId;
			itiContext = new ItidbContext();
		}

		private void InstructorMainForm_Load(object sender, EventArgs e)
		{
			var currIns = itiContext.Instructors.FirstOrDefault(i => i.InsId == currInsId);
			if (currIns != null)
			{
				label_name.Text = "Name : " + currIns.InsFname.TrimStart().TrimEnd() + " " + currIns.InsLname.TrimStart().TrimEnd();
			}
		}

		private void btn_questions_Click(object sender, EventArgs e)
		{
			CreateQuestionsForm qForm = new CreateQuestionsForm(currInsId);
			Hide();
			qForm.ShowDialog();
			Close();
		}

		private void btn_exams_Click(object sender, EventArgs e)
		{
			CreateExamForm eForm = new CreateExamForm(currInsId);
			Hide();
			eForm.ShowDialog();
			Close();
		}

		private void btn_showGrades_Click(object sender, EventArgs e)
		{
			StudentsCoursesGradesForm gForm = new StudentsCoursesGradesForm(currInsId);
			Hide();
			gForm.ShowDialog();
			Close();
		}

		private void btn_reports_Click(object sender, EventArgs e)
		{
			this.Hide();
			var newForm = new ReportsMainForm();
			newForm.ShowDialog();
			Close();
		}
	}
}
