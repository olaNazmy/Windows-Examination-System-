using exam_app.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_app
{
    public partial class CrudInstructorForm : Form
    {
        ItidbContext db = new ItidbContext();
        int insid;
        public CrudInstructorForm()
        {
            InitializeComponent();
        }
        private void CrudInstructorForm_Load(object sender, EventArgs e)
        {
            dgv_instructor.DataSource = db.Instructors.ToList();

            dtp_birthdate.Format = DateTimePickerFormat.Custom;
            dtp_birthdate.CustomFormat = "yyyy-MM-dd";
            cb_insDegree.Items.Add("Master");
            cb_insDegree.Items.Add("PHD");

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_fname.Text) ||
                string.IsNullOrWhiteSpace(txt_lname.Text) ||
                string.IsNullOrWhiteSpace(txt_phone.Text) ||

                cb_insDegree.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (!long.TryParse(txt_phone.Text, out long phone))
            {
                MessageBox.Show("Please enter a valid phone number.");
                return;
            }
                      
            DateTime selectedBirthDate = dtp_birthdate.Value;
            if (selectedBirthDate.Year <= 1990)
            {
                MessageBox.Show("Please select a date of birth after 1990.");
                return;
            }

            var newInstructor = new Instructor
            {
                InsFname = txt_fname.Text,
                InsLname = txt_lname.Text,
                InsBirthDate = DateOnly.Parse(dtp_birthdate.Text),
                InsPhone = txt_phone.Text,
                InsDegree = cb_insDegree.SelectedItem.ToString(),
            };

            db.Instructors.Add(newInstructor);
            db.SaveChanges();
            MessageBox.Show("Instructor added successfully.");

            dgv_instructor.DataSource = db.Instructors.ToList();
            ClearFormFields();

        }
        private void btn_showData_Click(object sender, EventArgs e)
        {
            insid = int.Parse(txt_id.Text);

            var instructor = db.Instructors.FirstOrDefault(i => i.InsId == insid);
            if (instructor != null)
            {
                txt_fname.Text = instructor.InsFname;
                txt_lname.Text = instructor.InsLname;
                dtp_birthdate.Text = instructor.InsBirthDate.ToString();
                txt_phone.Text = instructor.InsPhone.ToString();
                cb_insDegree.SelectedItem = instructor.InsDegree;
            }
            else
            {
                MessageBox.Show("Instructor not exists.");
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            var instructor = db.Instructors.FirstOrDefault(i => i.InsId == insid);
            if (instructor != null)
            {

                DateTime selectedBirthDate = dtp_birthdate.Value;
                if (selectedBirthDate.Year <= 1970)
                {
                    MessageBox.Show("Please select a date of birth after 1970.");
                    return;
                }
                instructor.InsFname = txt_fname.Text;
                instructor.InsLname = txt_lname.Text;
                instructor.InsPhone = txt_phone.Text;
                instructor.InsDegree = cb_insDegree.SelectedItem.ToString();
                instructor.InsBirthDate = DateOnly.Parse(dtp_birthdate.Text);

                db.SaveChanges();
                dgv_instructor.DataSource = db.Instructors.ToList();
                MessageBox.Show("Instructor Updated successfully.");
                ClearFormFields();
            }
            else
            {
                MessageBox.Show("Instructor not exists.");
            }
        }
        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            txt_id.Visible = true;
            btn_searchByID.Visible = true;
        }
        private void btn_remove_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            txt_id.Visible = true;
            btn_searchByID.Visible = true;

            var instructor = db.Instructors.FirstOrDefault(i => i.InsId == insid);

            if (instructor != null)
            {

                DialogResult result = MessageBox.Show("Are you sure you want to delete this instructor?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    db.Instructors.Remove(instructor);
                    db.SaveChanges();

                    dgv_instructor.DataSource = db.Instructors.ToList();
                    MessageBox.Show("Instructor deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ClearFormFields()
        {

            txt_id.Text = "";
            txt_fname.Text = "";
            txt_lname.Text = "";
            txt_phone.Text = "";
            dtp_birthdate.Value = DateTime.Now;
        }
    }
}
