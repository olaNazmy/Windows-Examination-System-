namespace exam_app
{
    partial class Crud_Students
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			fname_lbl = new Label();
			lname_lbl = new Label();
			city_lbl = new Label();
			street_lbl = new Label();
			fname_txt = new TextBox();
			lname_txt = new TextBox();
			gender_lbl = new Label();
			phone_lbl = new Label();
			city_txt = new TextBox();
			street_txt = new TextBox();
			phoneNumber_txt = new TextBox();
			add_btn = new Button();
			update_btn = new Button();
			remove_btn = new Button();
			gender_combo = new ComboBox();
			username_txt = new TextBox();
			username_lbl = new Label();
			passw_txt = new TextBox();
			role_lbl = new Label();
			save_btn = new Button();
			std_id_txt = new TextBox();
			stdid_lbl = new Label();
			ok_btn = new Button();
			role_txt = new TextBox();
			birth_datelbl = new Label();
			birthdate_picker = new DateTimePicker();
			title_Form_lbl = new Label();
			pass_lbl = new Label();
			removeOk_btn = new Button();
			button1 = new Button();
			SuspendLayout();
			// 
			// fname_lbl
			// 
			fname_lbl.AutoSize = true;
			fname_lbl.Font = new Font("Segoe UI", 13.8F);
			fname_lbl.Location = new Point(107, 184);
			fname_lbl.MinimumSize = new Size(53, 38);
			fname_lbl.Name = "fname_lbl";
			fname_lbl.Size = new Size(124, 38);
			fname_lbl.TabIndex = 0;
			fname_lbl.Text = "First Name";
			// 
			// lname_lbl
			// 
			lname_lbl.AutoSize = true;
			lname_lbl.Font = new Font("Segoe UI", 13.8F);
			lname_lbl.Location = new Point(107, 259);
			lname_lbl.MinimumSize = new Size(53, 38);
			lname_lbl.Name = "lname_lbl";
			lname_lbl.Size = new Size(122, 38);
			lname_lbl.TabIndex = 1;
			lname_lbl.Text = "Last Name";
			// 
			// city_lbl
			// 
			city_lbl.AutoSize = true;
			city_lbl.Font = new Font("Segoe UI", 13.8F);
			city_lbl.Location = new Point(115, 425);
			city_lbl.MinimumSize = new Size(53, 38);
			city_lbl.Name = "city_lbl";
			city_lbl.Size = new Size(53, 38);
			city_lbl.TabIndex = 4;
			city_lbl.Text = "City";
			//city_lbl.Click += this.city_lbl_Click;
			// 
			// street_lbl
			// 
			street_lbl.AutoSize = true;
			street_lbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			street_lbl.Location = new Point(646, 188);
			street_lbl.Name = "street_lbl";
			street_lbl.Size = new Size(73, 31);
			street_lbl.TabIndex = 5;
			street_lbl.Text = "Street";
			// 
			// fname_txt
			// 
			fname_txt.BackColor = Color.White;
			fname_txt.BorderStyle = BorderStyle.None;
			fname_txt.Font = new Font("Segoe UI", 12F);
			fname_txt.ForeColor = Color.MidnightBlue;
			fname_txt.Location = new Point(258, 186);
			fname_txt.MinimumSize = new Size(71, 35);
			fname_txt.Name = "fname_txt";
			fname_txt.Size = new Size(318, 35);
			fname_txt.TabIndex = 9;
			// 
			// lname_txt
			// 
			lname_txt.BackColor = Color.White;
			lname_txt.BorderStyle = BorderStyle.None;
			lname_txt.Font = new Font("Segoe UI", 12F);
			lname_txt.ForeColor = Color.MidnightBlue;
			lname_txt.Location = new Point(258, 261);
			lname_txt.MinimumSize = new Size(71, 35);
			lname_txt.Name = "lname_txt";
			lname_txt.Size = new Size(318, 35);
			lname_txt.TabIndex = 10;
			// 
			// gender_lbl
			// 
			gender_lbl.AutoSize = true;
			gender_lbl.Font = new Font("Segoe UI", 13.8F);
			gender_lbl.Location = new Point(107, 338);
			gender_lbl.MinimumSize = new Size(53, 38);
			gender_lbl.Name = "gender_lbl";
			gender_lbl.Size = new Size(89, 38);
			gender_lbl.TabIndex = 2;
			gender_lbl.Text = "Gender";
			// 
			// phone_lbl
			// 
			phone_lbl.AutoSize = true;
			phone_lbl.Font = new Font("Segoe UI", 13.8F);
			phone_lbl.Location = new Point(646, 512);
			phone_lbl.Name = "phone_lbl";
			phone_lbl.Size = new Size(168, 31);
			phone_lbl.TabIndex = 7;
			phone_lbl.Text = "Phone Number";
			// 
			// city_txt
			// 
			city_txt.BackColor = Color.White;
			city_txt.BorderStyle = BorderStyle.None;
			city_txt.Font = new Font("Segoe UI", 12F);
			city_txt.ForeColor = Color.MidnightBlue;
			city_txt.Location = new Point(258, 428);
			city_txt.MinimumSize = new Size(71, 35);
			city_txt.Name = "city_txt";
			city_txt.Size = new Size(318, 35);
			city_txt.TabIndex = 13;
			//city_txt.TextChanged += this.city_txt_TextChanged;
			// 
			// street_txt
			// 
			street_txt.BackColor = Color.White;
			street_txt.BorderStyle = BorderStyle.None;
			street_txt.Font = new Font("Segoe UI", 12F);
			street_txt.Location = new Point(858, 186);
			street_txt.MinimumSize = new Size(71, 35);
			street_txt.Name = "street_txt";
			street_txt.Size = new Size(363, 35);
			street_txt.TabIndex = 14;
			// 
			// phoneNumber_txt
			// 
			phoneNumber_txt.BackColor = Color.White;
			phoneNumber_txt.BorderStyle = BorderStyle.None;
			phoneNumber_txt.Font = new Font("Segoe UI", 12F);
			phoneNumber_txt.Location = new Point(858, 510);
			phoneNumber_txt.MinimumSize = new Size(71, 35);
			phoneNumber_txt.Name = "phoneNumber_txt";
			phoneNumber_txt.Size = new Size(371, 35);
			phoneNumber_txt.TabIndex = 16;
			// 
			// add_btn
			// 
			add_btn.BackColor = Color.LightSteelBlue;
			add_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			add_btn.ForeColor = Color.White;
			add_btn.Location = new Point(515, 594);
			add_btn.MinimumSize = new Size(71, 57);
			add_btn.Name = "add_btn";
			add_btn.Size = new Size(136, 57);
			add_btn.TabIndex = 18;
			add_btn.Text = "Add";
			add_btn.UseVisualStyleBackColor = false;
			add_btn.Click += add_btn_Click;
			// 
			// update_btn
			// 
			update_btn.BackColor = Color.LightSteelBlue;
			update_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			update_btn.ForeColor = Color.White;
			update_btn.Location = new Point(673, 594);
			update_btn.MinimumSize = new Size(71, 57);
			update_btn.Name = "update_btn";
			update_btn.Size = new Size(141, 57);
			update_btn.TabIndex = 19;
			update_btn.Text = "Update";
			update_btn.UseVisualStyleBackColor = false;
			update_btn.Click += update_btn_Click;
			// 
			// remove_btn
			// 
			remove_btn.BackColor = Color.LightSteelBlue;
			remove_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			remove_btn.ForeColor = Color.White;
			remove_btn.Location = new Point(821, 594);
			remove_btn.MinimumSize = new Size(71, 57);
			remove_btn.Name = "remove_btn";
			remove_btn.Size = new Size(150, 57);
			remove_btn.TabIndex = 20;
			remove_btn.Text = "Remove";
			remove_btn.UseVisualStyleBackColor = false;
			remove_btn.Click += remove_btn_Click;
			// 
			// gender_combo
			// 
			gender_combo.BackColor = Color.White;
			gender_combo.ForeColor = Color.MidnightBlue;
			gender_combo.FormattingEnabled = true;
			gender_combo.Location = new Point(258, 343);
			gender_combo.Name = "gender_combo";
			gender_combo.Size = new Size(318, 28);
			gender_combo.TabIndex = 21;
			// 
			// username_txt
			// 
			username_txt.BackColor = Color.White;
			username_txt.BorderStyle = BorderStyle.None;
			username_txt.Font = new Font("Segoe UI", 12F);
			username_txt.Location = new Point(861, 261);
			username_txt.MinimumSize = new Size(71, 35);
			username_txt.Name = "username_txt";
			username_txt.Size = new Size(360, 35);
			username_txt.TabIndex = 23;
			// 
			// username_lbl
			// 
			username_lbl.AutoSize = true;
			username_lbl.Font = new Font("Segoe UI", 13.8F);
			username_lbl.Location = new Point(646, 263);
			username_lbl.Name = "username_lbl";
			username_lbl.Size = new Size(127, 31);
			username_lbl.TabIndex = 22;
			username_lbl.Text = "User Name";
			// 
			// passw_txt
			// 
			passw_txt.BackColor = Color.White;
			passw_txt.BorderStyle = BorderStyle.None;
			passw_txt.Font = new Font("Segoe UI", 12F);
			passw_txt.Location = new Point(861, 422);
			passw_txt.MinimumSize = new Size(71, 35);
			passw_txt.Name = "passw_txt";
			passw_txt.Size = new Size(360, 35);
			passw_txt.TabIndex = 25;
			passw_txt.TextChanged += passw_txt_TextChanged;
			// 
			// role_lbl
			// 
			role_lbl.AutoSize = true;
			role_lbl.Font = new Font("Segoe UI", 13.8F);
			role_lbl.Location = new Point(646, 342);
			role_lbl.Name = "role_lbl";
			role_lbl.Size = new Size(58, 31);
			role_lbl.TabIndex = 26;
			role_lbl.Text = "Role";
			// 
			// save_btn
			// 
			save_btn.BackColor = Color.LightSteelBlue;
			save_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			save_btn.ForeColor = Color.White;
			save_btn.Location = new Point(515, 679);
			save_btn.MinimumSize = new Size(71, 57);
			save_btn.Name = "save_btn";
			save_btn.Size = new Size(456, 57);
			save_btn.TabIndex = 28;
			save_btn.Text = "Save Changes";
			save_btn.UseVisualStyleBackColor = false;
			save_btn.Click += save_btn_Click;
			// 
			// std_id_txt
			// 
			std_id_txt.BackColor = Color.White;
			std_id_txt.BorderStyle = BorderStyle.None;
			std_id_txt.Font = new Font("Segoe UI", 12F);
			std_id_txt.ForeColor = Color.MidnightBlue;
			std_id_txt.Location = new Point(673, 85);
			std_id_txt.MinimumSize = new Size(71, 35);
			std_id_txt.Name = "std_id_txt";
			std_id_txt.Size = new Size(111, 35);
			std_id_txt.TabIndex = 30;
			// 
			// stdid_lbl
			// 
			stdid_lbl.AutoSize = true;
			stdid_lbl.Font = new Font("Segoe UI", 13.8F);
			stdid_lbl.Location = new Point(485, 85);
			stdid_lbl.MinimumSize = new Size(53, 38);
			stdid_lbl.Name = "stdid_lbl";
			stdid_lbl.Size = new Size(178, 38);
			stdid_lbl.TabIndex = 29;
			stdid_lbl.Text = "Enter Student Id";
			// 
			// ok_btn
			// 
			ok_btn.BackColor = Color.LightSteelBlue;
			ok_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			ok_btn.ForeColor = Color.White;
			ok_btn.Location = new Point(843, 71);
			ok_btn.MinimumSize = new Size(71, 57);
			ok_btn.Name = "ok_btn";
			ok_btn.Size = new Size(86, 57);
			ok_btn.TabIndex = 31;
			ok_btn.Text = "Ok";
			ok_btn.UseVisualStyleBackColor = false;
			ok_btn.Click += ok_btn_Click;
			// 
			// role_txt
			// 
			role_txt.BackColor = Color.White;
			role_txt.BorderStyle = BorderStyle.None;
			role_txt.Font = new Font("Segoe UI", 12F);
			role_txt.Location = new Point(861, 340);
			role_txt.MinimumSize = new Size(71, 35);
			role_txt.Name = "role_txt";
			role_txt.Size = new Size(360, 35);
			role_txt.TabIndex = 32;
			// 
			// birth_datelbl
			// 
			birth_datelbl.AutoSize = true;
			birth_datelbl.Font = new Font("Segoe UI", 13.8F);
			birth_datelbl.Location = new Point(112, 508);
			birth_datelbl.MinimumSize = new Size(53, 38);
			birth_datelbl.Name = "birth_datelbl";
			birth_datelbl.Size = new Size(116, 38);
			birth_datelbl.TabIndex = 33;
			birth_datelbl.Text = "Birth Date";
			// 
			// birthdate_picker
			// 
			birthdate_picker.Location = new Point(255, 514);
			birthdate_picker.Name = "birthdate_picker";
			birthdate_picker.Size = new Size(318, 27);
			birthdate_picker.TabIndex = 34;
			// 
			// title_Form_lbl
			// 
			title_Form_lbl.AutoSize = true;
			title_Form_lbl.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			title_Form_lbl.ForeColor = Color.MidnightBlue;
			title_Form_lbl.Location = new Point(16, 15);
			title_Form_lbl.Name = "title_Form_lbl";
			title_Form_lbl.Size = new Size(272, 47);
			title_Form_lbl.TabIndex = 35;
			title_Form_lbl.Text = "Student Form";
			// 
			// pass_lbl
			// 
			pass_lbl.AutoSize = true;
			pass_lbl.Font = new Font("Segoe UI", 13.8F);
			pass_lbl.Location = new Point(648, 426);
			pass_lbl.Name = "pass_lbl";
			pass_lbl.Size = new Size(110, 31);
			pass_lbl.TabIndex = 36;
			pass_lbl.Text = "Password";
			//pass_lbl.Click += this.pass_lbl_Click;
			// 
			// removeOk_btn
			// 
			removeOk_btn.BackColor = Color.LightSteelBlue;
			removeOk_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			removeOk_btn.ForeColor = Color.White;
			removeOk_btn.Location = new Point(843, 71);
			removeOk_btn.MinimumSize = new Size(71, 57);
			removeOk_btn.Name = "removeOk_btn";
			removeOk_btn.Size = new Size(86, 57);
			removeOk_btn.TabIndex = 37;
			removeOk_btn.Text = "Ok";
			removeOk_btn.UseVisualStyleBackColor = false;
			removeOk_btn.Click += removeOk_btn_Click;
			// 
			// button1
			// 
			button1.BackColor = Color.LightSteelBlue;
			button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			button1.ForeColor = Color.White;
			button1.Location = new Point(1222, 16);
			button1.MinimumSize = new Size(71, 57);
			button1.Name = "button1";
			button1.Size = new Size(99, 57);
			button1.TabIndex = 18;
			button1.Text = "Back";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// Crud_Students
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.WhiteSmoke;
			ClientSize = new Size(1358, 767);
			Controls.Add(removeOk_btn);
			Controls.Add(pass_lbl);
			Controls.Add(title_Form_lbl);
			Controls.Add(birthdate_picker);
			Controls.Add(birth_datelbl);
			Controls.Add(role_txt);
			Controls.Add(ok_btn);
			Controls.Add(std_id_txt);
			Controls.Add(stdid_lbl);
			Controls.Add(save_btn);
			Controls.Add(role_lbl);
			Controls.Add(passw_txt);
			Controls.Add(username_txt);
			Controls.Add(username_lbl);
			Controls.Add(gender_combo);
			Controls.Add(remove_btn);
			Controls.Add(update_btn);
			Controls.Add(button1);
			Controls.Add(add_btn);
			Controls.Add(phoneNumber_txt);
			Controls.Add(street_txt);
			Controls.Add(city_txt);
			Controls.Add(lname_txt);
			Controls.Add(fname_txt);
			Controls.Add(phone_lbl);
			Controls.Add(street_lbl);
			Controls.Add(city_lbl);
			Controls.Add(gender_lbl);
			Controls.Add(lname_lbl);
			Controls.Add(fname_lbl);
			ForeColor = Color.MidnightBlue;
			Name = "Crud_Students";
			Text = "Crud_Students";
			Load += Crud_Students_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label fname_lbl;
        private Label lname_lbl;
        private Label city_lbl;
        private Label street_lbl;
        private TextBox fname_txt;
        private TextBox lname_txt;
        private Label gender_lbl;
        private Label phone_lbl;
        private TextBox city_txt;
        private TextBox street_txt;
        private TextBox phoneNumber_txt;
        private Button add_btn;
        private Button update_btn;
        private Button remove_btn;
        private ComboBox gender_combo;
        private TextBox username_txt;
        private Label username_lbl;
        private TextBox passw_txt;
        private Label role_lbl;
        private Button save_btn;
        private TextBox std_id_txt;
        private Label stdid_lbl;
        private Button ok_btn;
        private TextBox role_txt;
        private Label birth_datelbl;
        private DateTimePicker birthdate_picker;
        private Label title_Form_lbl;
        private Label pass_lbl;
        private Button removeOk_btn;
        private Button button1;
    }
}