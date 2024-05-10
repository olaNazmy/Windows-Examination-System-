namespace exam_app
{
    partial class AssignCoursesToInstructor
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
            cb_branch = new ComboBox();
            lbl_branch = new Label();
            lbl_course = new Label();
            cb_track = new ComboBox();
            lbl_insName = new Label();
            btn_Assign_Course = new Button();
            lbl_duration = new Label();
            txt_duration = new TextBox();
            cb_course = new ComboBox();
            label1 = new Label();
            dgv_Instructors = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_Instructors).BeginInit();
            SuspendLayout();
            // 
            // cb_branch
            // 
            cb_branch.Font = new Font("Segoe UI Semibold", 10.8125F, FontStyle.Bold);
            cb_branch.FormattingEnabled = true;
            cb_branch.Location = new Point(745, 152);
            cb_branch.Name = "cb_branch";
            cb_branch.Size = new Size(289, 33);
            cb_branch.TabIndex = 0;
            // 
            // lbl_branch
            // 
            lbl_branch.AutoSize = true;
            lbl_branch.Font = new Font("Segoe UI Semibold", 10.8125F, FontStyle.Bold);
            lbl_branch.Location = new Point(580, 152);
            lbl_branch.Name = "lbl_branch";
            lbl_branch.Size = new Size(74, 28);
            lbl_branch.TabIndex = 1;
            lbl_branch.Text = "Branch";
            // 
            // lbl_course
            // 
            lbl_course.AutoSize = true;
            lbl_course.Font = new Font("Segoe UI Semibold", 10.8125F, FontStyle.Bold);
            lbl_course.Location = new Point(580, 230);
            lbl_course.Name = "lbl_course";
            lbl_course.Size = new Size(135, 28);
            lbl_course.TabIndex = 8;
            lbl_course.Text = "Branch Tracks";
            // 
            // cb_track
            // 
            cb_track.Font = new Font("Segoe UI Semibold", 10.8125F, FontStyle.Bold);
            cb_track.FormattingEnabled = true;
            cb_track.Location = new Point(745, 230);
            cb_track.Name = "cb_track";
            cb_track.Size = new Size(289, 33);
            cb_track.TabIndex = 7;
            // 
            // lbl_insName
            // 
            lbl_insName.AutoSize = true;
            lbl_insName.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lbl_insName.ForeColor = Color.SteelBlue;
            lbl_insName.Location = new Point(344, 41);
            lbl_insName.Name = "lbl_insName";
            lbl_insName.Size = new Size(423, 40);
            lbl_insName.TabIndex = 10;
            lbl_insName.Text = "Instructor Name: Fatma Sorour";
            // 
            // btn_Assign_Course
            // 
            btn_Assign_Course.BackColor = SystemColors.ActiveCaption;
            btn_Assign_Course.Font = new Font("Segoe UI Semibold", 10.8125F, FontStyle.Bold);
            btn_Assign_Course.ForeColor = SystemColors.ButtonFace;
            btn_Assign_Course.Location = new Point(461, 495);
            btn_Assign_Course.Name = "btn_Assign_Course";
            btn_Assign_Course.Size = new Size(169, 62);
            btn_Assign_Course.TabIndex = 11;
            btn_Assign_Course.Text = "Assign Course";
            btn_Assign_Course.UseVisualStyleBackColor = false;
            btn_Assign_Course.Click += btn_Assign_Course_Click;
            // 
            // lbl_duration
            // 
            lbl_duration.AutoSize = true;
            lbl_duration.Font = new Font("Segoe UI Semibold", 10.8125F, FontStyle.Bold);
            lbl_duration.Location = new Point(580, 379);
            lbl_duration.Name = "lbl_duration";
            lbl_duration.Size = new Size(160, 28);
            lbl_duration.TabIndex = 12;
            lbl_duration.Text = "Course Duration";
            // 
            // txt_duration
            // 
            txt_duration.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_duration.Location = new Point(745, 379);
            txt_duration.Multiline = true;
            txt_duration.Name = "txt_duration";
            txt_duration.Size = new Size(289, 29);
            txt_duration.TabIndex = 13;
            // 
            // cb_course
            // 
            cb_course.Font = new Font("Segoe UI Semibold", 10.8125F, FontStyle.Bold);
            cb_course.FormattingEnabled = true;
            cb_course.Location = new Point(745, 308);
            cb_course.Name = "cb_course";
            cb_course.Size = new Size(289, 33);
            cb_course.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8125F, FontStyle.Bold);
            label1.Location = new Point(580, 308);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 6;
            label1.Text = "Branch Courses";
            // 
            // dgv_Instructors
            // 
            dgv_Instructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Instructors.Location = new Point(40, 152);
            dgv_Instructors.Name = "dgv_Instructors";
            dgv_Instructors.RowHeadersWidth = 55;
            dgv_Instructors.Size = new Size(493, 256);
            dgv_Instructors.TabIndex = 14;
            dgv_Instructors.CellDoubleClick += dgv_Instructors_CellDoubleClick;
            // 
            // AssignCoursesToInstructor
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 603);
            Controls.Add(dgv_Instructors);
            Controls.Add(txt_duration);
            Controls.Add(lbl_duration);
            Controls.Add(btn_Assign_Course);
            Controls.Add(lbl_insName);
            Controls.Add(lbl_course);
            Controls.Add(cb_track);
            Controls.Add(label1);
            Controls.Add(cb_course);
            Controls.Add(lbl_branch);
            Controls.Add(cb_branch);
            Name = "AssignCoursesToInstructor";
            Text = "AssignCoursesToInstructor";
            Load += AssignCoursesToInstructor_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Instructors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_branch;
        private Label lbl_branch;
        private Label lbl_course;
        private ComboBox cb_track;
        private Label lbl_insName;
        private Button btn_Assign_Course;
        private Label lbl_duration;
        private TextBox txt_duration;
        private ComboBox cb_course;
        private Label label1;
        private DataGridView dgv_Instructors;
    }
}