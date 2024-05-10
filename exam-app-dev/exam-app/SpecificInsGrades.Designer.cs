namespace exam_app
{
    partial class SpecificInsGrades
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
            title_lbl = new Label();
            courses_lbl = new Label();
            ins_crs_combo = new ComboBox();
            std_grades_btn = new Button();
            dgv_std_data = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_std_data).BeginInit();
            SuspendLayout();
            // 
            // title_lbl
            // 
            title_lbl.AutoSize = true;
            title_lbl.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title_lbl.ForeColor = Color.MidnightBlue;
            title_lbl.Location = new Point(242, 6);
            title_lbl.MinimumSize = new Size(60, 50);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(272, 50);
            title_lbl.TabIndex = 0;
            title_lbl.Text = "Instructor Courses";
            // 
            // courses_lbl
            // 
            courses_lbl.AutoSize = true;
            courses_lbl.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            courses_lbl.ForeColor = Color.MidnightBlue;
            courses_lbl.Location = new Point(12, 76);
            courses_lbl.MinimumSize = new Size(60, 40);
            courses_lbl.Name = "courses_lbl";
            courses_lbl.Size = new Size(215, 40);
            courses_lbl.TabIndex = 1;
            courses_lbl.Text = "Instructor Courses:";
            // 
            // ins_crs_combo
            // 
            ins_crs_combo.ForeColor = Color.MidnightBlue;
            ins_crs_combo.FormattingEnabled = true;
            ins_crs_combo.Location = new Point(259, 87);
            ins_crs_combo.Name = "ins_crs_combo";
            ins_crs_combo.Size = new Size(221, 29);
            ins_crs_combo.TabIndex = 2;
            // 
            // std_grades_btn
            // 
            std_grades_btn.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            std_grades_btn.ForeColor = Color.MidnightBlue;
            std_grades_btn.Location = new Point(512, 66);
            std_grades_btn.MinimumSize = new Size(90, 50);
            std_grades_btn.Name = "std_grades_btn";
            std_grades_btn.Size = new Size(221, 50);
            std_grades_btn.TabIndex = 3;
            std_grades_btn.Text = "Show Student Grades";
            std_grades_btn.UseVisualStyleBackColor = true;
            std_grades_btn.Click += std_grades_btn_Click;
            // 
            // dgv_std_data
            // 
            dgv_std_data.BackgroundColor = Color.WhiteSmoke;
            dgv_std_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_std_data.GridColor = Color.WhiteSmoke;
            dgv_std_data.Location = new Point(66, 191);
            dgv_std_data.Name = "dgv_std_data";
            dgv_std_data.RowHeadersWidth = 51;
            dgv_std_data.Size = new Size(681, 247);
            dgv_std_data.TabIndex = 4;
            // 
            // SpecificInsGrades
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_std_data);
            Controls.Add(std_grades_btn);
            Controls.Add(ins_crs_combo);
            Controls.Add(courses_lbl);
            Controls.Add(title_lbl);
            Name = "SpecificInsGrades";
            Text = "SpecificInsGrades";
            Load += SpecificInsGrades_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_std_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title_lbl;
        private Label courses_lbl;
        private ComboBox ins_crs_combo;
        private Button std_grades_btn;
        private DataGridView dgv_std_data;
    }
}