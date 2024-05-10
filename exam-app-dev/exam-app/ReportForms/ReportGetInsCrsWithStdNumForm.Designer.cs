namespace exam_app
{
    partial class ReportGetInsCrsWithStdNumForm
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
            cmb_ins_name = new ComboBox();
            btn_getInsInfo = new Button();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Left;
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(696, 398);
            reportViewer1.TabIndex = 0;
            // 
            // cmb_ins_name
            // 
            cmb_ins_name.FormattingEnabled = true;
            cmb_ins_name.Location = new Point(771, 77);
            cmb_ins_name.Name = "cmb_ins_name";
            cmb_ins_name.Size = new Size(151, 26);
            cmb_ins_name.TabIndex = 0;
            // 
            // btn_getInsInfo
            // 
            btn_getInsInfo.Location = new Point(771, 136);
            btn_getInsInfo.Name = "btn_getInsInfo";
            btn_getInsInfo.Size = new Size(94, 26);
            btn_getInsInfo.TabIndex = 1;
            btn_getInsInfo.Text = "OK";
            btn_getInsInfo.UseVisualStyleBackColor = true;
            btn_getInsInfo.Click += btn_getInsInfo_Click;
            // 
            // ReportGetInsCrsWithStdNumForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 398);
            Controls.Add(btn_getInsInfo);
            Controls.Add(cmb_ins_name);
            Controls.Add(reportViewer1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ReportGetInsCrsWithStdNumForm";
            Text = "ReportGetInsCrsWithStdNumForm";
            Load += ReportGetInsCrsWithStdNumForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ComboBox cmb_ins_name;
        private Button btn_getInsInfo;
    }
}