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
    public partial class StudentMainForm : Form
    {
        int currStdId;
        ItidbContext ITIContext;
        public StudentMainForm(int id)
        {
            InitializeComponent();
            currStdId = id;
            ITIContext = new ItidbContext();
        }

        private void btn_to_avail_exams_form_Click(object sender, EventArgs e)
        {
            Hide();
            StdAvailExamsForm stdAvailExamsForm = new StdAvailExamsForm(currStdId);
            stdAvailExamsForm.ShowDialog();
            Close();
        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {
            var st = ITIContext.Students.FirstOrDefault(s => s.StId == currStdId);
            if (st != null)
            {
                label_name.Text = "Name : " + st.StFname.TrimStart().TrimEnd() + " " + st.StLname.TrimStart().TrimEnd();
            }
            var track = ITIContext.StudentsInTracks.Include(t => t.Track).FirstOrDefault(s => s.StudentId == currStdId);
            if (track != null)
            {
                label_Track.Text = "Track : " + track.Track.TrName;
            }
        }

        private void btn_ShowStdGrades_Click(object sender, EventArgs e)
        {
            var stdGradesForm = new ShowStudentGradesForm(currStdId);
            Hide();
            stdGradesForm.ShowDialog();
            Close();
        }
    }
}
