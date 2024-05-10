namespace exam_app
{
	partial class AdminMainForm
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
			label1 = new Label();
			label2 = new Label();
			btn_student_management = new Button();
			btn_ins_Management = new Button();
			btn_assign_courses_ins = new Button();
			btn_reports = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(31, 34);
			label1.Name = "label1";
			label1.Size = new Size(337, 50);
			label1.TabIndex = 0;
			label1.Text = "Admin Dashboard";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(31, 97);
			label2.Name = "label2";
			label2.Size = new Size(1180, 28);
			label2.TabIndex = 0;
			label2.Text = "--------------------------------------------------------------------------------------------------------------------------------------------------";
			// 
			// btn_student_management
			// 
			btn_student_management.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			btn_student_management.Location = new Point(119, 263);
			btn_student_management.Name = "btn_student_management";
			btn_student_management.Size = new Size(394, 130);
			btn_student_management.TabIndex = 1;
			btn_student_management.Text = "Student Management";
			btn_student_management.UseVisualStyleBackColor = true;
			btn_student_management.Click += btn_student_management_Click;
			// 
			// btn_ins_Management
			// 
			btn_ins_Management.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			btn_ins_Management.Location = new Point(703, 263);
			btn_ins_Management.Name = "btn_ins_Management";
			btn_ins_Management.Size = new Size(394, 130);
			btn_ins_Management.TabIndex = 1;
			btn_ins_Management.Text = "Instructor Management";
			btn_ins_Management.UseVisualStyleBackColor = true;
			btn_ins_Management.Click += btn_ins_Management_Click;
			// 
			// btn_assign_courses_ins
			// 
			btn_assign_courses_ins.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			btn_assign_courses_ins.Location = new Point(119, 525);
			btn_assign_courses_ins.Name = "btn_assign_courses_ins";
			btn_assign_courses_ins.Size = new Size(394, 130);
			btn_assign_courses_ins.TabIndex = 1;
			btn_assign_courses_ins.Text = "Instrucors Courses";
			btn_assign_courses_ins.UseVisualStyleBackColor = true;
			btn_assign_courses_ins.Click += btn_assign_courses_ins_Click;
			// 
			// btn_reports
			// 
			btn_reports.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			btn_reports.Location = new Point(703, 525);
			btn_reports.Name = "btn_reports";
			btn_reports.Size = new Size(394, 130);
			btn_reports.TabIndex = 1;
			btn_reports.Text = "Reports Dashboard";
			btn_reports.UseVisualStyleBackColor = true;
			btn_reports.Click += btn_reports_Click;
			// 
			// AdminMainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1358, 767);
			Controls.Add(btn_reports);
			Controls.Add(btn_assign_courses_ins);
			Controls.Add(btn_ins_Management);
			Controls.Add(btn_student_management);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "AdminMainForm";
			Text = "AdminMainForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private Label label2;
        private Button btn_student_management;
        private Button btn_ins_Management;
        private Button btn_assign_courses_ins;
		private Button btn_reports;
	}
}