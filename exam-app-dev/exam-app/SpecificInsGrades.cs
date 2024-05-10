using exam_app.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class SpecificInsGrades : Form
    {

        ItidbContext context;
        int Ins_id;
        public SpecificInsGrades(int ins_id)
        {
            this.Ins_id = ins_id;
            context = new ItidbContext();
            InitializeComponent();
        }

        private void SpecificInsGrades_Load(object sender, EventArgs e)
        {
            var coursesForInstructor_data = context.InsCourses
                .Where(ic => ic.InsId == Ins_id)
                .Join(
                    context.Courses,
                    ic => ic.CrsId,
                    c => c.CrsId,
                    (ic, c) => new { CourseId = c.CrsId, CourseName = c.CrsName })
                .ToList();

            // Set the DisplayMember and ValueMember properties of the ComboBox
            ins_crs_combo.DisplayMember = "CourseName";
            ins_crs_combo.ValueMember = "CourseId";
            // Set the DataSource of the ComboBox
            ins_crs_combo.DataSource = coursesForInstructor_data;
            ins_crs_combo.SelectedIndex = -1;
        }

        private void std_grades_btn_Click(object sender, EventArgs e)
        {
            if (ins_crs_combo.SelectedItem != null)
            {
                int selectedCourseId = (int)ins_crs_combo.SelectedValue;
                //
                var data = (from se in context.StudentExams
                            join s in context.Students on se.StudentId equals s.StId
                            join ee in context.Exams on se.ExamId equals ee.ExId
                            where ee.CourseId == selectedCourseId
                            select new
                            {
                                StudentId = s.StId,
                                StudentName = s.StFname + " " + s.StLname,
                                ExamId = se.ExamId,
                                ExamDate = ee.ExDate,
                                Grade = se.Grade
                            }).ToList();
                //check if it null or not
                if (data.Any())
                {
                    dgv_std_data.DataSource = data;
                }
                else
                {
                    MessageBox.Show("No data found for the selected course.");
                }
            }
            else
            {
                MessageBox.Show("Please select a course.");
            }
        }
    }
}
