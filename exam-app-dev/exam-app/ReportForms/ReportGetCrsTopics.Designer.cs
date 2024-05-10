namespace exam_app
{
    partial class ReportGetCrsTopics
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
            cmb_crs_name = new ComboBox();
            label1 = new Label();
            btn_generate_report = new Button();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // cmb_crs_name
            // 
            cmb_crs_name.Font = new Font("Tahoma", 13.8F);
            cmb_crs_name.FormattingEnabled = true;
            cmb_crs_name.Location = new Point(162, 47);
            cmb_crs_name.Name = "cmb_crs_name";
            cmb_crs_name.Size = new Size(249, 36);
            cmb_crs_name.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F);
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 1;
            label1.Text = "Course name";
            // 
            // btn_generate_report
            // 
            btn_generate_report.Font = new Font("Tahoma", 13.8F);
            btn_generate_report.Location = new Point(162, 113);
            btn_generate_report.Name = "btn_generate_report";
            btn_generate_report.Size = new Size(249, 42);
            btn_generate_report.TabIndex = 2;
            btn_generate_report.Text = "generate report";
            btn_generate_report.UseVisualStyleBackColor = true;
            btn_generate_report.Click += btn_generate_report_Click;
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Right;
            reportViewer1.Location = new Point(426, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(696, 516);
            reportViewer1.TabIndex = 0;
            // 
            // ReportGetCrsTopics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 516);
            Controls.Add(btn_generate_report);
            Controls.Add(label1);
            Controls.Add(cmb_crs_name);
            Controls.Add(reportViewer1);
            Name = "ReportGetCrsTopics";
            Text = "ReportGetCrsTopics";
            Load += ReportGetCrsTopics_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_crs_name;
        private Label label1;
        private Button btn_generate_report;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}