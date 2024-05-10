namespace exam_app
{
    partial class ShowStudentGradesForm
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
            dgv_studentGrades = new DataGridView();
            lbl_name = new Label();
            label_Name = new Label();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_studentGrades).BeginInit();
            SuspendLayout();
            // 
            // dgv_studentGrades
            // 
            dgv_studentGrades.BackgroundColor = SystemColors.ControlLight;
            dgv_studentGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_studentGrades.Location = new Point(78, 94);
            dgv_studentGrades.Name = "dgv_studentGrades";
            dgv_studentGrades.RowHeadersWidth = 55;
            dgv_studentGrades.Size = new Size(598, 349);
            dgv_studentGrades.TabIndex = 6;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI Semibold", 14.0625F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_name.ForeColor = Color.RoyalBlue;
            lbl_name.Location = new Point(323, 125);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(0, 32);
            lbl_name.TabIndex = 7;
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Name.ForeColor = Color.Black;
            label_Name.Location = new Point(78, 34);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(76, 31);
            label_Name.TabIndex = 8;
            label_Name.Text = "Name";
            // 
            // btn_back
            // 
            btn_back.Location = new Point(582, 34);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 37);
            btn_back.TabIndex = 9;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // ShowStudentGradesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 469);
            Controls.Add(btn_back);
            Controls.Add(label_Name);
            Controls.Add(lbl_name);
            Controls.Add(dgv_studentGrades);
            Name = "ShowStudentGradesForm";
            Text = "ShowStudentGradesForm";
            Load += ShowStudentGradesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_studentGrades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgv_studentGrades;
        private Label lbl_name;
        private Label label_Name;
        private Button btn_back;
    }
}