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
	public partial class AdminMainForm : Form
	{
		public AdminMainForm()
		{
			InitializeComponent();
		}

		private void btn_student_management_Click(object sender, EventArgs e)
		{
			Crud_Students students = new Crud_Students();
			students.ShowDialog();
		}

		private void btn_assignTrack_Click(object sender, EventArgs e)
		{
			var assign = new Assign_Track_StudentForm(2);
			assign.ShowDialog();
		}

		private void btn_ins_Management_Click(object sender, EventArgs e)
		{
			var ins = new CrudInstructorForm();
			ins.ShowDialog();
		}

		private void btn_assign_courses_ins_Click(object sender, EventArgs e)
		{
			var crs = new AssignCoursesToInstructor();
			crs.ShowDialog();
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
