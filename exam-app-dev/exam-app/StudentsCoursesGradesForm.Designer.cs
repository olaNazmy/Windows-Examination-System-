namespace exam_app
{
    partial class StudentsCoursesGradesForm
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
            back_btn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_std_data).BeginInit();
            SuspendLayout();
            // 
            // title_lbl
            // 
            title_lbl.AutoSize = true;
            title_lbl.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_lbl.ForeColor = Color.MidnightBlue;
            title_lbl.Location = new Point(41, 22);
            title_lbl.MinimumSize = new Size(53, 48);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(279, 48);
            title_lbl.TabIndex = 0;
            title_lbl.Text = "Students Grades";
            // 
            // courses_lbl
            // 
            courses_lbl.AutoSize = true;
            courses_lbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courses_lbl.ForeColor = Color.MidnightBlue;
            courses_lbl.Location = new Point(54, 168);
            courses_lbl.MinimumSize = new Size(53, 38);
            courses_lbl.Name = "courses_lbl";
            courses_lbl.Size = new Size(95, 38);
            courses_lbl.TabIndex = 1;
            courses_lbl.Text = "Course :";
            // 
            // ins_crs_combo
            // 
            ins_crs_combo.ForeColor = Color.MidnightBlue;
            ins_crs_combo.FormattingEnabled = true;
            ins_crs_combo.Location = new Point(194, 174);
            ins_crs_combo.Name = "ins_crs_combo";
            ins_crs_combo.Size = new Size(197, 28);
            ins_crs_combo.TabIndex = 2;
            // 
            // std_grades_btn
            // 
            std_grades_btn.BackColor = Color.LightSteelBlue;
            std_grades_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            std_grades_btn.ForeColor = Color.White;
            std_grades_btn.Location = new Point(487, 161);
            std_grades_btn.MinimumSize = new Size(80, 48);
            std_grades_btn.Name = "std_grades_btn";
            std_grades_btn.Size = new Size(196, 48);
            std_grades_btn.TabIndex = 3;
            std_grades_btn.Text = "Show Student Grades";
            std_grades_btn.UseVisualStyleBackColor = false;
            std_grades_btn.Click += std_grades_btn_Click;
            // 
            // dgv_std_data
            // 
            dgv_std_data.BackgroundColor = Color.WhiteSmoke;
            dgv_std_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_std_data.GridColor = Color.WhiteSmoke;
            dgv_std_data.Location = new Point(54, 250);
            dgv_std_data.Name = "dgv_std_data";
            dgv_std_data.RowHeadersWidth = 51;
            dgv_std_data.Size = new Size(723, 361);
            dgv_std_data.TabIndex = 4;
            // 
            // back_btn
            // 
            back_btn.BackColor = Color.LightSteelBlue;
            back_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            back_btn.ForeColor = Color.White;
            back_btn.Location = new Point(657, 22);
            back_btn.MinimumSize = new Size(71, 57);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(107, 57);
            back_btn.TabIndex = 19;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(54, 96);
            label1.MinimumSize = new Size(53, 48);
            label1.Name = "label1";
            label1.Size = new Size(717, 48);
            label1.TabIndex = 0;
            label1.Text = "-----------------------------------------------------------------------------------------------------";
            // 
            // StudentsCoursesGradesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(823, 635);
            Controls.Add(back_btn);
            Controls.Add(dgv_std_data);
            Controls.Add(std_grades_btn);
            Controls.Add(ins_crs_combo);
            Controls.Add(courses_lbl);
            Controls.Add(label1);
            Controls.Add(title_lbl);
            Name = "StudentsCoursesGradesForm";
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
        private Button back_btn;
        private Label label1;
    }
}