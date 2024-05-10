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
    public partial class Assign_Track_StudentForm : Form
    {
        ItidbContext context;
        int Std_id;
        public Assign_Track_StudentForm(int std_id)
        {
            InitializeComponent();
            Std_id = std_id;
            context = new ItidbContext();
        }

        private void Assign_Track_StudentForm_Load(object sender, EventArgs e)
        {
            //load branches
            var branches = context.Branches.ToList();

            // Bind the data to the ComboBox
            branch_combo.DataSource = branches;
            branch_combo.DisplayMember = "Name";
            branch_combo.ValueMember = "BranchId";
            branch_combo.SelectedValue = -1;
            //

        }

        private void save_btn_Click(object sender, EventArgs e)
        {

            int chosenBranchId = (int)branch_combo.SelectedValue;

            // Load data
            var chosenBranch = context.Branches
                        .Include(b => b.Tracks)
                        .FirstOrDefault(b => b.BranchId == chosenBranchId);

            if (chosenBranch != null)
            {
                // Get the tracks associated with the chosen branch
                var availableTracks = chosenBranch.Tracks.ToList();

                // Populate the ComboBox with track data
                tracks_combo.DisplayMember = "TrName";
                tracks_combo.ValueMember = "TrId";
                tracks_combo.DataSource = availableTracks;
                tracks_combo.SelectedValue = -1;
            }
        }

        private void add_Std_Track_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(duration_txt.Text, out int duration))
            {
                MessageBox.Show("Please enter a valid duration (an integer).");
                return; 
            }
            if (duration <= 0)
            {
                MessageBox.Show("Duration must be a positive integer.");
                return; 
            }

            // Create a new instance of StudentsInTrack
            var newStudentInTrack = new StudentsInTrack
            {
                TrackId = (int)tracks_combo.SelectedValue, 
                StudentId = Std_id, 
                Durations = duration
            };

            context.StudentsInTracks.Add(newStudentInTrack);
            context.SaveChanges();
            MessageBox.Show("Student in track added successfully.");

            //reset
            branch_combo.SelectedValue = -1;
            tracks_combo.SelectedValue = -1;
            duration_txt.Text = "";
            
        }
    }
}
