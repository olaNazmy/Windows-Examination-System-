using exam_app.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_app
{
    public partial class LoginForm : Form
    {
        ItidbContext iticontext { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            iticontext = new ItidbContext();
        }

        private void bttn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.IsNullOrEmpty() || txt_password.Text.IsNullOrEmpty())
            {
                MessageBox.Show("please enter all data");
            }
            else
            {
                var user = iticontext.LoginAccounts.FirstOrDefault(u => u.UserName == txt_username.Text);

                if (user == null || user.Role == null)
                {
                    MessageBox.Show("wrong username");
                }
                else
                {
                    Debug.WriteLine(user.Role);
                    if (user.Password == txt_password.Text && user.Role != null)
                    {

                        if (user.Role.ToLower().Trim() == "student")
                        {
                            var currStd = iticontext.Students.FirstOrDefault(u => u.UserId == user.UserId);
                            if (currStd != null)
                            {
                                int currStdId = currStd.StId;
                                Hide();
                                StudentMainForm studentMainForm = new StudentMainForm(currStdId);
                                studentMainForm.ShowDialog();
                                Close();
                            }

                        }
                        else if (user.Role.Trim() == "instructor")
                        {
                            var currIns = iticontext.Instructors.FirstOrDefault(u => u.UserId == user.UserId);
                            if (currIns != null)
                            {
                                int currInsId = currIns.InsId;
                                Hide();
                                InstructorMainForm instructorMainForm = new InstructorMainForm(currInsId);
                                instructorMainForm.ShowDialog();
                                this.Close();
                            }

                        }
                        else if (user.Role.Trim() == "admin")
                        {
                            Hide();
                            AdminMainForm adminMainForm = new AdminMainForm();
                            adminMainForm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("sorry you don't have any roles");
                        }
                    }
                    else { MessageBox.Show("wrong password"); }
                }
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
