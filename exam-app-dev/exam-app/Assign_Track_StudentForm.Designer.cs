namespace exam_app
{
    partial class Assign_Track_StudentForm
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
            title_Form_lbl = new Label();
            branch_lbl = new Label();
            branch_combo = new ComboBox();
            tracks_lbl = new Label();
            tracks_combo = new ComboBox();
            save_btn = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            duration_txt = new TextBox();
            duration_lbl = new Label();
            add_Std_Track_btn = new Button();
            SuspendLayout();
            // 
            // title_Form_lbl
            // 
            title_Form_lbl.AutoSize = true;
            title_Form_lbl.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_Form_lbl.ForeColor = Color.MidnightBlue;
            title_Form_lbl.Location = new Point(274, 9);
            title_Form_lbl.Name = "title_Form_lbl";
            title_Form_lbl.Size = new Size(221, 40);
            title_Form_lbl.TabIndex = 36;
            title_Form_lbl.Text = "Assign Track";
            // 
            // branch_lbl
            // 
            branch_lbl.AutoSize = true;
            branch_lbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            branch_lbl.Location = new Point(12, 83);
            branch_lbl.Name = "branch_lbl";
            branch_lbl.Size = new Size(208, 38);
            branch_lbl.TabIndex = 37;
            branch_lbl.Text = "Choose Branch:";
            // 
            // branch_combo
            // 
            branch_combo.BackColor = Color.GhostWhite;
            branch_combo.ForeColor = Color.MidnightBlue;
            branch_combo.FormattingEnabled = true;
            branch_combo.Location = new Point(292, 88);
            branch_combo.Name = "branch_combo";
            branch_combo.Size = new Size(212, 29);
            branch_combo.TabIndex = 38;
            // 
            // tracks_lbl
            // 
            tracks_lbl.AutoSize = true;
            tracks_lbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tracks_lbl.Location = new Point(12, 158);
            tracks_lbl.Name = "tracks_lbl";
            tracks_lbl.Size = new Size(217, 38);
            tracks_lbl.TabIndex = 39;
            tracks_lbl.Text = "Available Tracks:";
            // 
            // tracks_combo
            // 
            tracks_combo.BackColor = Color.GhostWhite;
            tracks_combo.ForeColor = Color.MidnightBlue;
            tracks_combo.FormattingEnabled = true;
            tracks_combo.Location = new Point(292, 163);
            tracks_combo.Name = "tracks_combo";
            tracks_combo.Size = new Size(212, 29);
            tracks_combo.TabIndex = 40;
            // 
            // save_btn
            // 
            save_btn.BackColor = Color.LightSteelBlue;
            save_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            save_btn.ForeColor = Color.White;
            save_btn.Location = new Point(562, 77);
            save_btn.MinimumSize = new Size(50, 50);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(75, 50);
            save_btn.TabIndex = 41;
            save_btn.Text = "Ok";
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // duration_txt
            // 
            duration_txt.BackColor = Color.GhostWhite;
            duration_txt.BorderStyle = BorderStyle.None;
            duration_txt.Font = new Font("Segoe UI", 12F);
            duration_txt.ForeColor = Color.MidnightBlue;
            duration_txt.Location = new Point(292, 238);
            duration_txt.MinimumSize = new Size(80, 35);
            duration_txt.Name = "duration_txt";
            duration_txt.Size = new Size(125, 35);
            duration_txt.TabIndex = 43;
            // 
            // duration_lbl
            // 
            duration_lbl.AutoSize = true;
            duration_lbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            duration_lbl.Location = new Point(12, 238);
            duration_lbl.Name = "duration_lbl";
            duration_lbl.Size = new Size(131, 38);
            duration_lbl.TabIndex = 42;
            duration_lbl.Text = "Duration:";
            // 
            // add_Std_Track_btn
            // 
            add_Std_Track_btn.BackColor = Color.LightSteelBlue;
            add_Std_Track_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            add_Std_Track_btn.ForeColor = Color.White;
            add_Std_Track_btn.Location = new Point(332, 315);
            add_Std_Track_btn.MinimumSize = new Size(80, 60);
            add_Std_Track_btn.Name = "add_Std_Track_btn";
            add_Std_Track_btn.Size = new Size(85, 60);
            add_Std_Track_btn.TabIndex = 44;
            add_Std_Track_btn.Text = "Add";
            add_Std_Track_btn.UseVisualStyleBackColor = false;
            add_Std_Track_btn.Click += add_Std_Track_btn_Click;
            // 
            // Assign_Track_StudentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(710, 397);
            Controls.Add(duration_txt);
            Controls.Add(duration_lbl);
            Controls.Add(save_btn);
            Controls.Add(tracks_combo);
            Controls.Add(tracks_lbl);
            Controls.Add(branch_combo);
            Controls.Add(branch_lbl);
            Controls.Add(title_Form_lbl);
            Controls.Add(add_Std_Track_btn);
            ForeColor = Color.MidnightBlue;
            Name = "Assign_Track_StudentForm";
            Text = "Assign_Track_StudentForm";
            Load += Assign_Track_StudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title_Form_lbl;
        private Label branch_lbl;
        private ComboBox branch_combo;
        private Label tracks_lbl;
        private ComboBox tracks_combo;
        private Button save_btn;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private TextBox duration_txt;
        private Label duration_lbl;
        private Button add_Std_Track_btn;
    }
}