namespace exam_app
{
    partial class GetExamDetailsReportForm
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
            CB_ExamSubject = new ComboBox();
            label2 = new Label();
            CB_ExamId = new ComboBox();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Location = new Point(14, 88);
            reportViewer1.Margin = new Padding(3, 4, 3, 4);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(887, 495);
            reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(103, 29);
            label1.Name = "label1";
            label1.Size = new Size(156, 28);
            label1.TabIndex = 4;
            label1.Text = "Choose Subject";
            // 
            // CB_ExamSubject
            // 
            CB_ExamSubject.FormattingEnabled = true;
            CB_ExamSubject.Location = new Point(314, 27);
            CB_ExamSubject.Margin = new Padding(3, 4, 3, 4);
            CB_ExamSubject.Name = "CB_ExamSubject";
            CB_ExamSubject.Size = new Size(138, 28);
            CB_ExamSubject.TabIndex = 3;
            CB_ExamSubject.SelectedIndexChanged += CB_ExamSubject_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(494, 29);
            label2.Name = "label2";
            label2.Size = new Size(161, 28);
            label2.TabIndex = 6;
            label2.Text = "Choose Exam Id";
            // 
            // CB_ExamId
            // 
            CB_ExamId.FormattingEnabled = true;
            CB_ExamId.Location = new Point(661, 33);
            CB_ExamId.Margin = new Padding(3, 4, 3, 4);
            CB_ExamId.Name = "CB_ExamId";
            CB_ExamId.Size = new Size(241, 28);
            CB_ExamId.TabIndex = 5;
            CB_ExamId.SelectedIndexChanged += CB_ExamId_SelectedIndexChanged;
            // 
            // GetExamDetailsReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label2);
            Controls.Add(CB_ExamId);
            Controls.Add(label1);
            Controls.Add(CB_ExamSubject);
            Controls.Add(reportViewer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GetExamDetailsReportForm";
            Text = "GetExamDetailsReportForm";
            Load += GetExamDetailsReportForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Label label1;
        private ComboBox CB_ExamSubject;
        private Label label2;
        private ComboBox CB_ExamId;
    }
}