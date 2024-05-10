using exam_app.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
	public partial class Crud_Students : Form
	{
		ItidbContext context;
		public Crud_Students()
		{
			context = new ItidbContext();
			InitializeComponent();
		}
		#region formm add student
		private void add_btn_Click(object sender, EventArgs e)
		{
			removeOk_btn.Visible = false;
			//add to login first
			if (string.IsNullOrWhiteSpace(fname_txt.Text) ||
			   string.IsNullOrWhiteSpace(lname_txt.Text) ||
			   //string.IsNullOrWhiteSpace(age_txt.Text) ||
			   string.IsNullOrWhiteSpace(city_txt.Text) ||
			   string.IsNullOrWhiteSpace(phoneNumber_txt.Text) ||
			   string.IsNullOrWhiteSpace(role_txt.Text) ||
			   string.IsNullOrWhiteSpace(street_txt.Text) ||
			   string.IsNullOrWhiteSpace(passw_txt.Text) ||
			   string.IsNullOrWhiteSpace(username_txt.Text) ||

			   gender_combo.SelectedItem == null)
			{
				MessageBox.Show("Please fill in all required fields.");
				return;
			}
			//if (!int.TryParse(age_txt.Text, out int age) || age <= 0)
			//{
			//    MessageBox.Show("Please enter a valid age.");
			//    return;
			//}
			if (!long.TryParse(phoneNumber_txt.Text, out long phoneNumber))
			{
				MessageBox.Show("Please enter a valid phone number.");
				return;
			}
			string selectedGender = gender_combo.SelectedItem.ToString();
			//here i need to insert in login account first

			var loginAccount = new LoginAccount
			{
				UserName = username_txt.Text,
				Password = passw_txt.Text,
				Role = role_txt.Text
			};
			context.LoginAccounts.Add(loginAccount);
			context.SaveChanges();
			int recentlyAddedId = loginAccount.UserId;
			//
			DateOnly selectedDate = DateOnly.Parse(birthdate_picker.Text);

			// Validate if the selected date is after 1990
			DateTime selectedDateTime = birthdate_picker.Value;
			if (selectedDateTime.Year <= 1990)
			{
				MessageBox.Show("Please select a date of birth after 1990.");
				return;
			}
			var newData = new Student
			{
				StFname = fname_txt.Text,
				StLname = lname_txt.Text,
				//StAge = int.Parse(age_txt.Text),
				City = city_txt.Text,
				Street = street_txt.Text,
				StPhone = int.Parse(phoneNumber_txt.Text),
				StGender = gender_combo.SelectedItem.ToString(),
				UserId = recentlyAddedId,
				//
				StBirthdate = selectedDate

			};
			//add to student 
			context.Students.Add(newData);
			context.SaveChanges();
			int recentlyAdded_StdID = newData.StId;
			//
			MessageBox.Show("Student added successfully.");
			// clear all txtboxes
			fname_txt.Text = lname_txt.Text = phoneNumber_txt.Text = street_txt.Text =
				city_txt.Text = passw_txt.Text = passw_txt.Text = username_txt.Text = passw_txt.Text = role_txt.Text = "";
			gender_combo.SelectedIndex = -1;
			//reset datePicker
			birthdate_picker.Value = DateTime.Today;
			//Switch to Assign Track
			//this.Hide();
			//Assign_Track_StudentForm assign_form = new Assign_Track_StudentForm(recentlyAdded_StdID);
			//assign_form.FormClosed += (s, args) => this.Close();
			//assign_form.Show();

			Assign_Track_StudentForm assign_form = new Assign_Track_StudentForm(recentlyAdded_StdID);
			assign_form.ShowDialog();

		}
		#endregion add student

		#region Form Load
		private void Crud_Students_Load(object sender, EventArgs e)
		{
			//1- get gender and put it in combo
			gender_combo.Items.Add("Male");
			gender_combo.Items.Add("Female");
			//hide lbl and stdid
			stdid_lbl.Visible = false;
			std_id_txt.Visible = false;
			ok_btn.Visible = false;
			title_Form_lbl.Visible = true;
			removeOk_btn.Visible = false;
		}
		#endregion

		private void update_btn_Click(object sender, EventArgs e)
		{
			removeOk_btn.Visible = false;
			stdid_lbl.Visible = true;
			std_id_txt.Visible = true;
			ok_btn.Visible = true;
			//
			title_Form_lbl.Visible = false;

		}

		private void ok_btn_Click(object sender, EventArgs e)
		{
			removeOk_btn.Visible = false;
			title_Form_lbl.Visible = false;
			//get std_id
			int std_id;
			if (!int.TryParse(std_id_txt.Text, out std_id))
			{
				MessageBox.Show("Please enter a valid student ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var student = context.Students.FirstOrDefault(u => u.StId == std_id);

			if (student == null)
			{
				MessageBox.Show("Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			int? userId = student.UserId;
			if (userId == null)
			{
				MessageBox.Show("User ID associated with the student is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var loginAccount = context.LoginAccounts.FirstOrDefault(l => l.UserId == userId);

			if (loginAccount == null)
			{
				MessageBox.Show("Login account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Populate fields with data from the login account
			username_txt.Text = loginAccount.UserName;
			passw_txt.Text = loginAccount.Password;
			role_txt.Text = loginAccount.Role;

			// Now populate fields with data from the student
			fname_txt.Text = student.StFname;
			lname_txt.Text = student.StLname;
			//age_txt.Text = student.StAge.ToString();
			city_txt.Text = student.City;
			street_txt.Text = student.Street;
			phoneNumber_txt.Text = student.StPhone.ToString();

			// Populate gender combo box
			foreach (var item in gender_combo.Items)
			{
				if (item.ToString() == student.StGender)
				{
					gender_combo.SelectedItem = item;
					break;
				}
			}

			// Select birthdate
			var birthdate = student.StBirthdate;
			var selectedDateTime = new DateTime(birthdate.Year, birthdate.Month, birthdate.Day);
			birthdate_picker.Value = selectedDateTime;
			MessageBox.Show("Data retrieved successfully.");
		}

		private void save_btn_Click(object sender, EventArgs e)
		{
			title_Form_lbl.Visible = false;
			removeOk_btn.Visible = false;
			//
			if (string.IsNullOrWhiteSpace(fname_txt.Text) ||
			   string.IsNullOrWhiteSpace(lname_txt.Text) ||
			   //string.IsNullOrWhiteSpace(age_txt.Text) ||
			   string.IsNullOrWhiteSpace(city_txt.Text) ||
			   string.IsNullOrWhiteSpace(phoneNumber_txt.Text) ||
			   string.IsNullOrWhiteSpace(role_txt.Text) ||
			   string.IsNullOrWhiteSpace(street_txt.Text) ||
			   string.IsNullOrWhiteSpace(passw_txt.Text) ||
			   string.IsNullOrWhiteSpace(username_txt.Text) ||

			   gender_combo.SelectedItem == null)
			{
				MessageBox.Show("Please fill in all required fields.");
				return;
			}
			//if (!int.TryParse(age_txt.Text, out int age) || age <= 0)
			//{
			//    MessageBox.Show("Please enter a valid age.");
			//    return;
			//}
			if (!long.TryParse(phoneNumber_txt.Text, out long phoneNumber))
			{
				MessageBox.Show("Please enter a valid phone number.");
				return;
			}
			DateOnly selectedDate = DateOnly.Parse(birthdate_picker.Text);

			// Validate if the selected date is after 1990
			DateTime selectedDateTime = birthdate_picker.Value;
			if (selectedDateTime.Year <= 1990)
			{
				MessageBox.Show("Please select a date of birth after 1990.");
				return;
			}
			//
			int std_id = int.Parse(std_id_txt.Text);

			using (context)
			{
				var student = context.Students.FirstOrDefault(s => s.StId == std_id);
				if (student != null)
				{
					// Update student data
					student.StFname = fname_txt.Text;
					student.StLname = lname_txt.Text;
					//student.StAge = int.Parse(age_txt.Text);
					student.City = city_txt.Text;
					student.Street = street_txt.Text;
					student.StPhone = int.Parse(phoneNumber_txt.Text);
					student.StGender = gender_combo.SelectedItem.ToString();
					//
					student.StBirthdate = selectedDate;

					// Update login account data
					var loginAccount = context.LoginAccounts.FirstOrDefault(l => l.UserId == student.UserId);
					if (loginAccount != null)
					{
						loginAccount.UserName = username_txt.Text;
						loginAccount.Role = role_txt.Text;
						loginAccount.Password = passw_txt.Text;
					}

					context.SaveChanges();

					MessageBox.Show("Data updated successfully.");
					// clear all txtboxes
					fname_txt.Text = lname_txt.Text = phoneNumber_txt.Text = street_txt.Text =
						city_txt.Text = passw_txt.Text = passw_txt.Text = username_txt.Text = passw_txt.Text = role_txt.Text = std_id_txt.Text = "";
					gender_combo.SelectedIndex = -1;
					//reset datePicker
					birthdate_picker.Value = DateTime.Today;
					//back title and hide id txtbox
					stdid_lbl.Visible = false;
					std_id_txt.Visible = false;
					title_Form_lbl.Visible = true;
					ok_btn.Visible = false;

				}
				else
				{
					MessageBox.Show("Student not found.");
				}
			}
		}

		private void remove_btn_Click(object sender, EventArgs e)
		{
			stdid_lbl.Visible = true;
			std_id_txt.Visible = true;
			ok_btn.Visible = true;
			title_Form_lbl.Visible = false;
			ok_btn.Visible = false;
			// Remove
			removeOk_btn.Visible = true;
		}

		private void removeOk_btn_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(std_id_txt.Text))
			{
				if (int.TryParse(std_id_txt.Text, out int studentId))
				{
					var student = context.Students.FirstOrDefault(s => s.StId == studentId);

					if (student != null)
					{
						if (student.UserId != null)
						{
							int userId = (int)student.UserId;
							var loginAccountToRemove = context.LoginAccounts.FirstOrDefault(l => l.UserId == userId);

							if (loginAccountToRemove != null)
							{
								// Confirm with the user before deleting
								DialogResult result = MessageBox.Show("Are you sure you want to delete the student along with their login account?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

								if (result == DialogResult.Yes)
								{
									// Remove from student_inTrack table
									var studentInTrackToRemove = context.StudentsInTracks.FirstOrDefault(st => st.StudentId == studentId);
									if (studentInTrackToRemove != null)
									{
										context.StudentsInTracks.Remove(studentInTrackToRemove);
									}

									// Remove login account
									context.LoginAccounts.Remove(loginAccountToRemove);
									context.SaveChanges();

									// Remove student
									context.Students.Remove(student);
									context.SaveChanges();

									MessageBox.Show("Student and associated login account removed successfully.");
									std_id_txt.Text = "";
									//
									stdid_lbl.Visible = false;
									std_id_txt.Visible = false;
									title_Form_lbl.Visible = true;
									ok_btn.Visible = false;
									removeOk_btn.Visible = false;
								}
								// If the user selects No, do nothing
							}
							else
							{
								MessageBox.Show("No login account found with the provided student ID.");
							}
						}
						else
						{
							MessageBox.Show("No user ID found for the student.");
						}
					}
					else
					{
						MessageBox.Show("No student found with the provided ID.");
					}
				}
				else
				{
					MessageBox.Show("Please enter a valid student ID.");
				}
			}
			else
			{
				MessageBox.Show("Please enter the student ID.");
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			AdminMainForm admin = new AdminMainForm();
			Hide();
			admin.ShowDialog();
			Close();
		}

		private void passw_txt_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
