namespace exam_app
{
	partial class LoginForm
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
			bttn_login = new Button();
			txt_username = new TextBox();
			txt_password = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			SuspendLayout();
			// 
			// bttn_login
			// 
			bttn_login.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			bttn_login.ForeColor = Color.SteelBlue;
			bttn_login.Location = new Point(338, 320);
			bttn_login.Name = "bttn_login";
			bttn_login.Size = new Size(136, 38);
			bttn_login.TabIndex = 0;
			bttn_login.Text = "Log in";
			bttn_login.UseVisualStyleBackColor = true;
			bttn_login.Click += bttn_login_Click;
			// 
			// txt_username
			// 
			txt_username.Location = new Point(338, 179);
			txt_username.Name = "txt_username";
			txt_username.Size = new Size(205, 27);
			txt_username.TabIndex = 1;
			// 
			// txt_password
			// 
			txt_password.Location = new Point(338, 243);
			txt_password.Name = "txt_password";
			txt_password.PasswordChar = '*';
			txt_password.Size = new Size(205, 27);
			txt_password.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label1.ForeColor = SystemColors.Window;
			label1.Location = new Point(228, 178);
			label1.Name = "label1";
			label1.Size = new Size(106, 28);
			label1.TabIndex = 2;
			label1.Text = "Username";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label2.ForeColor = SystemColors.Window;
			label2.Location = new Point(228, 242);
			label2.Name = "label2";
			label2.Size = new Size(101, 28);
			label2.TabIndex = 2;
			label2.Text = "Password";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.SteelBlue;
			label3.Font = new Font("A Hayat", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = SystemColors.GradientInactiveCaption;
			label3.Location = new Point(219, 33);
			label3.Name = "label3";
			label3.Size = new Size(364, 60);
			label3.TabIndex = 2;
			label3.Text = "Examination System";
			// 
			// LoginForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.SteelBlue;
			ClientSize = new Size(800, 450);
			Controls.Add(label2);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(txt_password);
			Controls.Add(txt_username);
			Controls.Add(bttn_login);
			Name = "LoginForm";
			Text = "LoginForm";
			Load += LoginForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button bttn_login;
		private TextBox txt_username;
		private TextBox txt_password;
		private Label label1;
		private Label label2;
		private Label label3;
	}
}