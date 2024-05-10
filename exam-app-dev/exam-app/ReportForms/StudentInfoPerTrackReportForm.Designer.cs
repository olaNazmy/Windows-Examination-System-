namespace exam_app
{
    partial class StudentInfoPerTrackReportForm
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
            reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            CB_Track = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // reportViewer2
            // 
            reportViewer2.Location = new Point(214, 162);
            reportViewer2.Name = "reportViewer2";
            reportViewer2.ServerReport.BearerToken = null;
            reportViewer2.Size = new Size(396, 246);
            reportViewer2.TabIndex = 0;
            // 
            // reportViewer1
            // 
            reportViewer1.Location = new Point(0, 91);
            reportViewer1.Margin = new Padding(3, 4, 3, 4);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(916, 509);
            reportViewer1.TabIndex = 0;
            // 
            // CB_Track
            // 
            CB_Track.FormattingEnabled = true;
            CB_Track.Location = new Point(447, 28);
            CB_Track.Margin = new Padding(3, 4, 3, 4);
            CB_Track.Name = "CB_Track";
            CB_Track.Size = new Size(238, 28);
            CB_Track.TabIndex = 1;
            CB_Track.SelectedIndexChanged += CB_Track_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(263, 24);
            label1.Name = "label1";
            label1.Size = new Size(164, 32);
            label1.TabIndex = 2;
            label1.Text = "Choose Track";
            // 
            // button1
            // 
            button1.Location = new Point(700, 30);
            button1.Name = "button1";
            button1.Size = new Size(114, 29);
            button1.TabIndex = 3;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StudentInfoPerTrackReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(CB_Track);
            Controls.Add(reportViewer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StudentInfoPerTrackReportForm";
            Text = "StudentInfoPerTrackReportForm";
            Load += StudentInfoPerTrackReportForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ComboBox CB_Track;
        private Label label1;
        private Button button1;
    }
}