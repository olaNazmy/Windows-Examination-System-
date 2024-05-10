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
    public partial class AssignCoursesToInstructor : Form
    {
        ItidbContext context=new ItidbContext();
        int Ins_id;

        public AssignCoursesToInstructor()
        {
            InitializeComponent();
            //Ins_id = instructorId;
        }

        private void AssignCoursesToInstructor_Load(object sender, EventArgs e)
        {
            //display instructors in dgv_Instructors
            var allInstructors = context.Instructors.ToList();
            dgv_Instructors.DataSource = allInstructors;


            var branches = context.Branches.ToList();

            cb_branch.DataSource = branches;
            cb_branch.DisplayMember = "Name";
            cb_branch.ValueMember = "BranchId";
            cb_branch.SelectedValue = -1;

            var instructor = context.Instructors.Find(Ins_id);

            if (instructor != null)
            {
                string firstName = instructor.InsFname.Trim();
                string lastName = instructor.InsLname.Trim();

                lbl_insName.Text = $"Instructor Name: {firstName} {lastName}";
            }

            cb_branch.SelectedIndexChanged += cb_branch_Selected_Branch;
        }

        private void cb_branch_Selected_Branch(object sender, EventArgs e)
        {
            int selectedBranchID = (int)cb_branch.SelectedValue;
            var selectedBranch = context.Branches
                .Include(b => b.Tracks)
                .FirstOrDefault(b => b.BranchId == selectedBranchID);

            if (selectedBranch != null)
            {
                var branchTracks = selectedBranch.Tracks?.ToList();

                cb_track.DisplayMember = "TrName";
                cb_track.ValueMember = "TrId";
                cb_track.DataSource = branchTracks;
                cb_track.SelectedValue = -1;
            }
            else
            {
                // Handle the case where selectedBranch is null
                MessageBox.Show("Invalid branch selection.");
                cb_track.DataSource = null;
            }

            cb_track.SelectedIndexChanged += cb_branch_Selected_Track;
        }

        private void cb_branch_Selected_Track(object sender, EventArgs e)
        {
            int selectedTrackID = (int)cb_track.SelectedValue;
            var selectedTrack = context.Tracks
                .Include(t => t.Crs)
                .FirstOrDefault(t => t.TrId == selectedTrackID);

            if (selectedTrack != null)
            {
                var trackCourses = selectedTrack.Crs?.ToList();

                cb_course.DisplayMember = "CrsName";
                cb_course.ValueMember = "CrsId";
                cb_course.DataSource = trackCourses;
                cb_course.SelectedValue = -1;
            }
            else
            {
                // Handle the case where selectedTrack is null
                MessageBox.Show("Invalid track selection.");
                cb_course.DataSource = null;
            }
        }
        private void btn_Assign_Course_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_duration.Text, out int duration))
            {
                MessageBox.Show("Please enter a valid duration (an integer).");
                return;
            }
            if (duration <= 0)
            {
                MessageBox.Show("Duration must be a positive integer.");
                return;
            }

            int courseId = (int)cb_course.SelectedValue;

            var existingAssignment = context.InsCourses
                .FirstOrDefault(ic => ic.InsId == Ins_id && ic.CrsId == courseId);

            if (existingAssignment != null)
            {
                existingAssignment.Evaluation = null;
                existingAssignment.Crs.CrsDuration = duration;
            }
            else
            {
                var instructorCourses = new InsCourse
                {
                    CrsId = courseId,
                    InsId = Ins_id,
                    Evaluation = null,
                };

                context.InsCourses.Add(instructorCourses);
                var selectedCourse = context.Courses.Find(courseId);
                if (selectedCourse != null)
                {
                    selectedCourse.CrsDuration = duration;
                }
            }

            try
            {
                context.SaveChanges();
                MessageBox.Show("Course assigned successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void dgv_Instructors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_Instructors.Rows.Count)
            {
                // Fetch instructor ID from the selected row
                Ins_id = (int)dgv_Instructors.Rows[e.RowIndex].Cells["InsId"].Value;

                // Display instructor name in the label
                var instructor = context.Instructors.Find(Ins_id);
                if (instructor != null)
                {
                    string firstName = instructor.InsFname.Trim();
                    string lastName = instructor.InsLname.Trim();

                    lbl_insName.Text = $"Instructor Name: {firstName} {lastName}";
                }
            }
        }
    }
}
