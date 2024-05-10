namespace exam_app
{
    partial class GetStudentExamsAndGradesReportForm
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
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            label1 = new Label();
            CB_StudentNames = new ComboBox();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Location = new Point(14, 100);
            reportViewer1.Margin = new Padding(3, 4, 3, 4);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(887, 483);
            reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(255, 43);
            label1.Name = "label1";
            label1.Size = new Size(148, 28);
            label1.TabIndex = 6;
            label1.Text = "Student Name";
            // 
            // CB_StudentNames
            // 
            CB_StudentNames.FormattingEnabled = true;
            CB_StudentNames.Location = new Point(466, 40);
            CB_StudentNames.Margin = new Padding(3, 4, 3, 4);
            CB_StudentNames.Name = "CB_StudentNames";
            CB_StudentNames.Size = new Size(262, 28);
            CB_StudentNames.TabIndex = 5;
            CB_StudentNames.SelectedIndexChanged += CB_StudentNames_SelectedIndexChanged;
            // 
            // GetStudentExamsAndGradesReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(CB_StudentNames);
            Controls.Add(reportViewer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GetStudentExamsAndGradesReportForm";
            Text = "GetStudentExamsAndGradesReportForm";
            Load += GetStudentExamsAndGradesReportForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Label label1;
        private ComboBox CB_StudentNames;
    }
}