using exam_app.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace exam_app
{
    public partial class ShowStudentGradesForm : Form
    {
        int stId;
        ItidbContext db = new ItidbContext();

        public ShowStudentGradesForm(int _stId)
        {
            InitializeComponent();
            stId = _stId;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {


        }

        private void ShowStudentGradesForm_Load(object sender, EventArgs e)
        {
            var student = db.Students.FirstOrDefault(s => s.StId == stId);

            if (student != null)
            {
                label_Name.Text = $"{student.StFname} {student.StLname}";

                var examGrades = (from se in db.StudentExams
                                  join ex in db.Exams on se.ExamId equals ex.ExId
                                  join c in db.Courses on ex.CourseId equals c.CrsId
                                  where se.StudentId == stId
                                  select new
                                  {
                                      ExamId = ex.ExId,
                                      CourseName = c.CrsName,
                                      ExamDate = ex.ExDate,
                                      Grade = se.Grade,
                                  }).ToList();

                dgv_studentGrades.DataSource = examGrades;
            }
            else
            {
                MessageBox.Show("Student not exists.");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            var mainStdForm = new StudentMainForm(stId);
            Hide();
            mainStdForm.ShowDialog();
            Close();
        }
    }
}





