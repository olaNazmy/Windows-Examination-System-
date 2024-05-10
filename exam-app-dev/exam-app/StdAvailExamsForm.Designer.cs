namespace exam_app
{
	partial class StdAvailExamsForm
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
			cb_courses = new ComboBox();
			btn_start_exam = new Button();
			dgv_exams = new DataGridView();
			btn_show_exams = new Button();
			label1 = new Label();
			btn_back = new Button();
			((System.ComponentModel.ISupportInitialize)dgv_exams).BeginInit();
			SuspendLayout();
			// 
			// cb_courses
			// 
			cb_courses.FormattingEnabled = true;
			cb_courses.Location = new Point(245, 82);
			cb_courses.Name = "cb_courses";
			cb_courses.Size = new Size(151, 28);
			cb_courses.TabIndex = 0;
			cb_courses.SelectedIndexChanged += cb_courses_SelectedIndexChanged;
			// 
			// btn_start_exam
			// 
			btn_start_exam.Location = new Point(512, 355);
			btn_start_exam.Name = "btn_start_exam";
			btn_start_exam.Size = new Size(185, 29);
			btn_start_exam.TabIndex = 2;
			btn_start_exam.Text = "Start Exam";
			btn_start_exam.UseVisualStyleBackColor = true;
			btn_start_exam.Click += btn_start_exam_Click;
			// 
			// dgv_exams
			// 
			dgv_exams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_exams.Location = new Point(96, 136);
			dgv_exams.Name = "dgv_exams";
			dgv_exams.RowHeadersWidth = 51;
			dgv_exams.Size = new Size(601, 188);
			dgv_exams.TabIndex = 3;
			dgv_exams.RowHeaderMouseClick += dgv_exams_RowHeaderMouseClick;
			dgv_exams.RowHeaderMouseDoubleClick += dgv_exams_RowHeaderMouseDoubleClick;
			// 
			// btn_show_exams
			// 
			btn_show_exams.Location = new Point(457, 82);
			btn_show_exams.Name = "btn_show_exams";
			btn_show_exams.Size = new Size(151, 29);
			btn_show_exams.TabIndex = 4;
			btn_show_exams.Text = "Show Exams";
			btn_show_exams.UseVisualStyleBackColor = true;
			btn_show_exams.Click += btn_show_exams_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(154, 86);
			label1.Name = "label1";
			label1.Size = new Size(65, 20);
			label1.TabIndex = 5;
			label1.Text = "Course : ";
			// 
			// btn_back
			// 
			btn_back.Location = new Point(96, 355);
			btn_back.Name = "btn_back";
			btn_back.Size = new Size(159, 29);
			btn_back.TabIndex = 6;
			btn_back.Text = "Back";
			btn_back.UseVisualStyleBackColor = true;
			btn_back.Click += btn_back_Click;
			// 
			// StdAvailExamsForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btn_back);
			Controls.Add(label1);
			Controls.Add(btn_show_exams);
			Controls.Add(dgv_exams);
			Controls.Add(btn_start_exam);
			Controls.Add(cb_courses);
			Name = "StdAvailExamsForm";
			Text = "StdAvailExamsForm";
			Load += StdAvailExamsForm_Load;
			((System.ComponentModel.ISupportInitialize)dgv_exams).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cb_courses;
		private Button btn_start_exam;
		private DataGridView dgv_exams;
		private Button btn_show_exams;
		private Label label1;
		private Button btn_back;
	}
}