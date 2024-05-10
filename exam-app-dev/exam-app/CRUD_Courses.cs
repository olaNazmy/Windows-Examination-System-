using exam_app.Models;
using Microsoft.Data.SqlClient;
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
    public partial class CRUD_Courses : Form
    {
        ItidbContext context;
        public CRUD_Courses()
        {
            context = new ItidbContext();
            InitializeComponent();
        }

        private void CURD_Courses_Load(object sender, EventArgs e)
        {
            defaultStart();
            getAllCourses();
            getAllTopics();
            updateDGV();
        }
        void updateDGV()
        {
            DGV_Courses.DataSource = context.Courses
                .Select(Course => new
                {
                    Course.CrsId,
                    Course.CrsName,
                    Course.CrsDuration,
                    Course.TopicId,
                    Course.Topic.TopicName
                })
                .ToList();
            DGV_Courses.Columns["CrsId"].Visible = false;
            DGV_Courses.Columns["TopicId"].Visible = false;
        }
        void getAllCourses()
        {
            cb_ExistingCourses.DisplayMember = "CrsName";
            cb_ExistingCourses.ValueMember = "CrsId";

            cb_ExistingCourses.DataSource = context.Courses
                .Select(Course => new
                {
                    Course.CrsId,
                    Course.CrsName
                })
                .ToList();

            cb_ExistingCourses.SelectedIndex = -1;
        }

        void getAllTopics()
        {
            cb_CourseTopic.DisplayMember = "TopicName";
            cb_CourseTopic.ValueMember = "TopicId";

            cb_CourseTopic.DataSource = context.Topics
                .Select(Topic => new { Topic.TopicId, Topic.TopicName }).ToList();

            cb_CourseTopic.SelectedIndex = -1;

        }

        void defaultStart()
        {
            btn_DeleteCourse.Visible = false;
            btn_UpdateCourse.Visible = false;
        }
        private void btn_AddCourse_Click(object sender, EventArgs e)
        {
            context.Database.ExecuteSqlRaw("EXEC InsertCourse @Crs_name, @Crs_duration, @Topic_id",
                new SqlParameter("@Crs_name", txt_CourseName.Text),
                new SqlParameter("@Crs_duration", txt_CourseDuration.Text),
                new SqlParameter("@Topic_id", (int)cb_CourseTopic.SelectedValue)
                );
            MessageBox.Show("Course Added");
            cb_CourseTopic.SelectedIndex = -1;
            getAllCourses();
            updateDGV();

        }

        int selectedCourseId = 0;
        private void btn_UpdateCourse_Click(object sender, EventArgs e)
        {
            context.Database.ExecuteSqlRaw("EXEC UpdateCourseName @Crs_name, @Crs_id",
                new SqlParameter("@Crs_name", txt_CourseName.Text),
                new SqlParameter("@Crs_id", selectedCourseId)
                );

            context.Database.ExecuteSqlRaw("EXEC UpdateCourseTopic @Topic_id, @Crs_id",
                new SqlParameter("@Topic_id", (int)cb_CourseTopic.SelectedValue),
                new SqlParameter("@Crs_id", selectedCourseId)
                );

            context.Database.ExecuteSqlRaw("EXEC UpdateCourseDuration @Crs_duration, @Crs_id",
                new SqlParameter("@Crs_duration", txt_CourseDuration.Text),
                new SqlParameter("@Crs_id", selectedCourseId)
                );

            MessageBox.Show("Course Updated");
            cb_ExistingCourses.SelectedIndex = -1;
            cb_CourseTopic.SelectedIndex = -1;
            txt_CourseName.Text = "";
            txt_CourseDuration.Text = "";
            getAllCourses();
            updateDGV();
        }

        private void btn_DeleteCourse_Click(object sender, EventArgs e)
        {
            context.Database.ExecuteSqlRaw("EXEC DeleteCourse @Crs_id",
                new SqlParameter("@Crs_id", selectedCourseId)
                );

            MessageBox.Show("Course Deleted");
            cb_ExistingCourses.SelectedIndex = -1;
            cb_CourseTopic.SelectedIndex = -1;
            txt_CourseName.Text = "";
            txt_CourseDuration.Text = "";
            getAllCourses();
            updateDGV();
        }

        private void cb_ExistingCourses_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb_ExistingCourses.SelectedIndex >= 0)
            {
                var course = context.Courses.Where(course => course.CrsId == (int)cb_ExistingCourses.SelectedValue).First();
                txt_CourseName.Text = course.CrsName;
                txt_CourseDuration.Text = $"{course.CrsDuration}";
                cb_CourseTopic.SelectedValue = course.TopicId;
                btn_DeleteCourse.Visible = true;
                btn_UpdateCourse.Visible = true;
            }
            else
            {
                defaultStart();
                txt_CourseName.Text = "";
                txt_CourseDuration.Text = "";
            }
        }

        private void DGV_Courses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_DeleteCourse.Visible = true;
            btn_UpdateCourse.Visible = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV_Courses.Rows[e.RowIndex];

                if (row.Cells[0].Value != null)
                {
                    selectedCourseId = Convert.ToInt32(row.Cells[0].Value);
                }

                txt_CourseName.Text = (string)row.Cells["CrsName"].Value;
                txt_CourseDuration.Text = $"{row.Cells["CrsDuration"].Value}";
                cb_CourseTopic.SelectedValue = row.Cells["TopicId"].Value;
                cb_ExistingCourses.SelectedValue = row.Cells["CrsId"].Value;

            }
        }
    }
}
