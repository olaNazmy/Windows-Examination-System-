namespace exam_app
{
    partial class InstructorMainForm
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
			label_name = new Label();
			btn_questions = new Button();
			btn_exams = new Button();
			btn_showGrades = new Button();
			btn_reports = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(32, 32);
			label1.Name = "label1";
			label1.Size = new Size(294, 46);
			label1.TabIndex = 0;
			label1.Text = "Instructor Profile";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(32, 82);
			label2.Name = "label2";
			label2.Size = new Size(747, 20);
			label2.TabIndex = 1;
			label2.Text = "---------------------------------------------------------------------------------------------------------------------------";
			// 
			// label_name
			// 
			label_name.AutoSize = true;
			label_name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label_name.Location = new Point(32, 123);
			label_name.Name = "label_name";
			label_name.Size = new Size(66, 28);
			label_name.TabIndex = 2;
			label_name.Text = "Name";
			// 
			// btn_questions
			// 
			btn_questions.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btn_questions.Location = new Point(34, 200);
			btn_questions.Name = "btn_questions";
			btn_questions.Size = new Size(292, 58);
			btn_questions.TabIndex = 3;
			btn_questions.Text = "Questions Dashboard";
			btn_questions.UseVisualStyleBackColor = true;
			btn_questions.Click += btn_questions_Click;
			// 
			// btn_exams
			// 
			btn_exams.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btn_exams.Location = new Point(452, 200);
			btn_exams.Name = "btn_exams";
			btn_exams.Size = new Size(292, 58);
			btn_exams.TabIndex = 3;
			btn_exams.Text = "Generate Random Exam";
			btn_exams.UseVisualStyleBackColor = true;
			btn_exams.Click += btn_exams_Click;
			// 
			// btn_showGrades
			// 
			btn_showGrades.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btn_showGrades.Location = new Point(452, 297);
			btn_showGrades.Name = "btn_showGrades";
			btn_showGrades.Size = new Size(292, 58);
			btn_showGrades.TabIndex = 3;
			btn_showGrades.Text = "Show Students Grades ";
			btn_showGrades.UseVisualStyleBackColor = true;
			btn_showGrades.Click += btn_showGrades_Click;
			// 
			// btn_reports
			// 
			btn_reports.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btn_reports.Location = new Point(34, 297);
			btn_reports.Name = "btn_reports";
			btn_reports.Size = new Size(292, 58);
			btn_reports.TabIndex = 3;
			btn_reports.Text = "Reports Dashboard";
			btn_reports.UseVisualStyleBackColor = true;
			btn_reports.Click += btn_reports_Click;
			// 
			// InstructorMainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btn_reports);
			Controls.Add(btn_showGrades);
			Controls.Add(btn_exams);
			Controls.Add(btn_questions);
			Controls.Add(label_name);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "InstructorMainForm";
			Text = "InstructorMainForm";
			Load += InstructorMainForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private Label label2;
        private Label label_name;
        private Button btn_questions;
        private Button btn_exams;
        private Button btn_showGrades;
		private Button btn_reports;
	}
}