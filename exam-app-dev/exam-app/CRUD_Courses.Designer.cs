namespace exam_app
{
    partial class CRUD_Courses
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
			DGV_Courses = new DataGridView();
			btn_DeleteCourse = new Button();
			btn_UpdateCourse = new Button();
			btn_AddCourse = new Button();
			label1 = new Label();
			txt_CourseName = new TextBox();
			label2 = new Label();
			cb_CourseTopic = new ComboBox();
			txt_CourseDuration = new TextBox();
			label3 = new Label();
			cb_ExistingCourses = new ComboBox();
			label4 = new Label();
			((System.ComponentModel.ISupportInitialize)DGV_Courses).BeginInit();
			SuspendLayout();
			// 
			// DGV_Courses
			// 
			DGV_Courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DGV_Courses.Location = new Point(12, 405);
			DGV_Courses.Margin = new Padding(3, 4, 3, 4);
			DGV_Courses.Name = "DGV_Courses";
			DGV_Courses.RowHeadersWidth = 51;
			DGV_Courses.Size = new Size(1334, 349);
			DGV_Courses.TabIndex = 0;
			DGV_Courses.RowHeaderMouseDoubleClick += DGV_Courses_RowHeaderMouseDoubleClick;
			// 
			// btn_DeleteCourse
			// 
			btn_DeleteCourse.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btn_DeleteCourse.ForeColor = Color.Navy;
			btn_DeleteCourse.Location = new Point(796, 331);
			btn_DeleteCourse.Margin = new Padding(3, 4, 3, 4);
			btn_DeleteCourse.Name = "btn_DeleteCourse";
			btn_DeleteCourse.Size = new Size(139, 47);
			btn_DeleteCourse.TabIndex = 25;
			btn_DeleteCourse.Text = "Delete Question";
			btn_DeleteCourse.UseVisualStyleBackColor = true;
			btn_DeleteCourse.Click += btn_DeleteCourse_Click;
			// 
			// btn_UpdateCourse
			// 
			btn_UpdateCourse.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btn_UpdateCourse.ForeColor = Color.Navy;
			btn_UpdateCourse.Location = new Point(582, 331);
			btn_UpdateCourse.Margin = new Padding(3, 4, 3, 4);
			btn_UpdateCourse.Name = "btn_UpdateCourse";
			btn_UpdateCourse.Size = new Size(139, 47);
			btn_UpdateCourse.TabIndex = 26;
			btn_UpdateCourse.Text = "Update Course";
			btn_UpdateCourse.UseVisualStyleBackColor = true;
			btn_UpdateCourse.Click += btn_UpdateCourse_Click;
			// 
			// btn_AddCourse
			// 
			btn_AddCourse.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btn_AddCourse.ForeColor = Color.Navy;
			btn_AddCourse.Location = new Point(344, 331);
			btn_AddCourse.Margin = new Padding(3, 4, 3, 4);
			btn_AddCourse.Name = "btn_AddCourse";
			btn_AddCourse.Size = new Size(162, 47);
			btn_AddCourse.TabIndex = 27;
			btn_AddCourse.Text = "Add Course";
			btn_AddCourse.UseVisualStyleBackColor = true;
			btn_AddCourse.Click += btn_AddCourse_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.Navy;
			label1.Location = new Point(214, 155);
			label1.Name = "label1";
			label1.Size = new Size(116, 23);
			label1.TabIndex = 28;
			label1.Text = "Course Name";
			// 
			// txt_CourseName
			// 
			txt_CourseName.Location = new Point(357, 147);
			txt_CourseName.Margin = new Padding(3, 4, 3, 4);
			txt_CourseName.Name = "txt_CourseName";
			txt_CourseName.Size = new Size(139, 27);
			txt_CourseName.TabIndex = 29;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.Navy;
			label2.Location = new Point(730, 214);
			label2.Name = "label2";
			label2.Size = new Size(111, 23);
			label2.TabIndex = 30;
			label2.Text = "Course Topic";
			// 
			// cb_CourseTopic
			// 
			cb_CourseTopic.FormattingEnabled = true;
			cb_CourseTopic.Location = new Point(873, 213);
			cb_CourseTopic.Margin = new Padding(3, 4, 3, 4);
			cb_CourseTopic.Name = "cb_CourseTopic";
			cb_CourseTopic.Size = new Size(138, 28);
			cb_CourseTopic.TabIndex = 31;
			// 
			// txt_CourseDuration
			// 
			txt_CourseDuration.Location = new Point(357, 214);
			txt_CourseDuration.Margin = new Padding(3, 4, 3, 4);
			txt_CourseDuration.Name = "txt_CourseDuration";
			txt_CourseDuration.Size = new Size(139, 27);
			txt_CourseDuration.TabIndex = 33;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.Navy;
			label3.Location = new Point(214, 222);
			label3.Name = "label3";
			label3.Size = new Size(140, 23);
			label3.TabIndex = 32;
			label3.Text = "Course Duration";
			// 
			// cb_ExistingCourses
			// 
			cb_ExistingCourses.FormattingEnabled = true;
			cb_ExistingCourses.Location = new Point(873, 147);
			cb_ExistingCourses.Margin = new Padding(3, 4, 3, 4);
			cb_ExistingCourses.Name = "cb_ExistingCourses";
			cb_ExistingCourses.Size = new Size(138, 28);
			cb_ExistingCourses.TabIndex = 35;
			cb_ExistingCourses.SelectedIndexChanged += cb_ExistingCourses_SelectedIndexChanged_1;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.Navy;
			label4.Location = new Point(730, 149);
			label4.Name = "label4";
			label4.Size = new Size(146, 23);
			label4.TabIndex = 34;
			label4.Text = "Exitsting Courses";
			// 
			// CRUD_Courses
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1358, 767);
			Controls.Add(cb_ExistingCourses);
			Controls.Add(label4);
			Controls.Add(txt_CourseDuration);
			Controls.Add(label3);
			Controls.Add(cb_CourseTopic);
			Controls.Add(label2);
			Controls.Add(txt_CourseName);
			Controls.Add(label1);
			Controls.Add(btn_AddCourse);
			Controls.Add(btn_UpdateCourse);
			Controls.Add(btn_DeleteCourse);
			Controls.Add(DGV_Courses);
			Margin = new Padding(3, 4, 3, 4);
			Name = "CRUD_Courses";
			Text = "CURD_Courses";
			Load += CURD_Courses_Load;
			((System.ComponentModel.ISupportInitialize)DGV_Courses).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView DGV_Courses;
        private Button btn_DeleteCourse;
        private Button btn_UpdateCourse;
        private Button btn_AddCourse;
        private Label label1;
        private TextBox txt_CourseName;
        private Label label2;
        private ComboBox cb_CourseTopic;
        private TextBox txt_CourseDuration;
        private Label label3;
        private ComboBox cb_ExistingCourses;
        private Label label4;
    }
}