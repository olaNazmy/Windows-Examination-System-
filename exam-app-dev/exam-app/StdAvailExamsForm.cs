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
	public partial class StdAvailExamsForm : Form
	{
		int currStdId;
		int selectedCourse;
		int selectedExam;
		ItidbContext ItidbContext { get; set; }
		public StdAvailExamsForm()
		{
			InitializeComponent();
			ItidbContext = new ItidbContext();
			currStdId = 1;
		}
		public StdAvailExamsForm(int stdId)
		{
			InitializeComponent();
			ItidbContext = new ItidbContext();
			currStdId = stdId;
		}

		private void StdAvailExamsForm_Load(object sender, EventArgs e)
		{
			var stdCourses = ItidbContext.StudentCourses
				.Where(c => c.StdId == currStdId)
				.Select(c => new { name = c.Crs.CrsName, id = c.CrsId }).ToList();
			cb_courses.ValueMember = "id";
			cb_courses.DisplayMember = "name";
			cb_courses.DataSource = stdCourses;

			btn_start_exam.Enabled = false;
		}

		private void cb_courses_SelectedIndexChanged(object sender, EventArgs e)
		{


			if (cb_courses.SelectedIndex != null)
			{
				selectedCourse = (int)cb_courses.SelectedValue;

			}
		}



		private void btn_start_exam_Click(object sender, EventArgs e)
		{
			var stExam = ItidbContext.StudentExams.FirstOrDefault(c => c.StudentId == currStdId && c.ExamId==selectedExam);
			var stExQ = ItidbContext.ExamStdQuestions.FirstOrDefault(e => e.ExId == selectedExam && e.StId == currStdId);
			if(stExam != null || stExQ!=null)
			{
				MessageBox.Show("you already answered this exam before");
			}
			else
			{
                Hide();
                StartExamForm form = new StartExamForm(currStdId, selectedExam);
                form.ShowDialog();
                this.Close();
            }
        }

		private void dgv_exams_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (dgv_exams.SelectedRows.Count > 0 && dgv_exams.SelectedRows[0].Cells[0].Value != null)
			{
				if (int.TryParse(dgv_exams.SelectedRows[0].Cells[0].Value.ToString(), out selectedExam))
				{
					btn_start_exam.Enabled = true;
				}
			}

		}

		private void btn_show_exams_Click(object sender, EventArgs e)
		{
			dgv_exams.DataSource = ItidbContext.Exams.Where(e => e.CourseId == selectedCourse).Select(e => new { id = e.ExId, e.ExamName, e.ExDate, Duration = e.ExDuration + " min" }).ToList();
			btn_start_exam.Enabled = false;
		}

		private void dgv_exams_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (dgv_exams.SelectedRows.Count > 0 && dgv_exams.SelectedRows[0].Cells[0].Value != null)
			{
				if (int.TryParse(dgv_exams.SelectedRows[0].Cells[0].Value.ToString(), out selectedExam))
				{
					btn_start_exam.Enabled = true;
				}
			}
		}

		private void btn_back_Click(object sender, EventArgs e)
		{
			var stdMain = new StudentMainForm(currStdId);
			this.Hide();
			stdMain.ShowDialog();
			Close();
		}
	}
}
