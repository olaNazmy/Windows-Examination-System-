namespace exam_app
{
	partial class StudentMainForm
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
			btn_to_avail_exams_form = new Button();
			btn_ShowStdGrades = new Button();
			label_name = new Label();
			label_Track = new Label();
			label3 = new Label();
			label4 = new Label();
			SuspendLayout();
			// 
			// btn_to_avail_exams_form
			// 
			btn_to_avail_exams_form.Location = new Point(86, 257);
			btn_to_avail_exams_form.Name = "btn_to_avail_exams_form";
			btn_to_avail_exams_form.Size = new Size(274, 103);
			btn_to_avail_exams_form.TabIndex = 0;
			btn_to_avail_exams_form.Text = "Show Available Exams";
			btn_to_avail_exams_form.UseVisualStyleBackColor = true;
			btn_to_avail_exams_form.Click += btn_to_avail_exams_form_Click;
			// 
			// btn_ShowStdGrades
			// 
			btn_ShowStdGrades.Location = new Point(415, 257);
			btn_ShowStdGrades.Name = "btn_ShowStdGrades";
			btn_ShowStdGrades.Size = new Size(274, 103);
			btn_ShowStdGrades.TabIndex = 0;
			btn_ShowStdGrades.Text = "Show Courses Grades";
			btn_ShowStdGrades.UseVisualStyleBackColor = true;
			btn_ShowStdGrades.Click += btn_ShowStdGrades_Click;
			// 
			// label_name
			// 
			label_name.AutoSize = true;
			label_name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label_name.Location = new Point(61, 127);
			label_name.Name = "label_name";
			label_name.Size = new Size(117, 28);
			label_name.TabIndex = 1;
			label_name.Text = "label_Name";
			// 
			// label_Track
			// 
			label_Track.AutoSize = true;
			label_Track.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label_Track.Location = new Point(61, 171);
			label_Track.Name = "label_Track";
			label_Track.Size = new Size(109, 28);
			label_Track.TabIndex = 1;
			label_Track.Text = "label_Track";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(12, 35);
			label3.Name = "label3";
			label3.Size = new Size(260, 46);
			label3.TabIndex = 1;
			label3.Text = "Student Profile";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.Location = new Point(12, 81);
			label4.Name = "label4";
			label4.Size = new Size(743, 31);
			label4.TabIndex = 1;
			label4.Text = "---------------------------------------------------------------------------------";
			// 
			// StudentMainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label_Track);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label_name);
			Controls.Add(btn_ShowStdGrades);
			Controls.Add(btn_to_avail_exams_form);
			Name = "StudentMainForm";
			Text = "StudentMainForm";
			Load += StudentMainForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btn_to_avail_exams_form;
        private Button btn_ShowStdGrades;
        private Label label_name;
        private Label label_Track;
        private Label label3;
        private Label label4;
    }
}