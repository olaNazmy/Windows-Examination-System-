namespace exam_app
{
    partial class ReportStdExamDetailsForm
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
            cmb_std_names = new ComboBox();
            cmb_exams = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            generate_report = new Button();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Right;
            reportViewer1.Location = new Point(347, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(796, 533);
            reportViewer1.TabIndex = 0;
            // 
            // cmb_std_names
            // 
            cmb_std_names.FormattingEnabled = true;
            cmb_std_names.Location = new Point(123, 77);
            cmb_std_names.Name = "cmb_std_names";
            cmb_std_names.Size = new Size(183, 28);
            cmb_std_names.TabIndex = 0;
            cmb_std_names.SelectedIndexChanged += cmb_std_names_SelectedIndexChanged;
            // 
            // cmb_exams
            // 
            cmb_exams.FormattingEnabled = true;
            cmb_exams.Location = new Point(123, 257);
            cmb_exams.Name = "cmb_exams";
            cmb_exams.Size = new Size(183, 28);
            cmb_exams.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 80);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 1;
            label1.Text = "Student name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 229);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "exams of: ";
            // 
            // button1
            // 
            button1.Location = new Point(123, 121);
            button1.Name = "button1";
            button1.Size = new Size(183, 29);
            button1.TabIndex = 2;
            button1.Text = "getStudentExams";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // generate_report
            // 
            generate_report.Location = new Point(112, 341);
            generate_report.Name = "generate_report";
            generate_report.Size = new Size(185, 29);
            generate_report.TabIndex = 3;
            generate_report.Text = "generate_report";
            generate_report.UseVisualStyleBackColor = true;
            generate_report.Click += generate_report_Click;
            // 
            // ReportStdExamDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 533);
            Controls.Add(generate_report);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmb_exams);
            Controls.Add(cmb_std_names);
            Controls.Add(reportViewer1);
            Name = "ReportStdExamDetailsForm";
            Text = "ReportStdExamDetailsForm";
            Load += ReportStdExamDetailsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ComboBox cmb_std_names;
        private ComboBox cmb_exams;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button generate_report;
    }
}