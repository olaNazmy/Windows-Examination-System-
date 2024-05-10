namespace exam_app
{
	partial class ReportsMainForm
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
			btn_examDetails = new Button();
			btn_stdGrades = new Button();
			btn_crsTopic = new Button();
			insCrsWIthStdNum = new Button();
			btn_stdExams = new Button();
			btn_stdInfo = new Button();
			label1 = new Label();
			label2 = new Label();
			SuspendLayout();
			// 
			// btn_examDetails
			// 
			btn_examDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btn_examDetails.Location = new Point(799, 229);
			btn_examDetails.Name = "btn_examDetails";
			btn_examDetails.Size = new Size(279, 122);
			btn_examDetails.TabIndex = 0;
			btn_examDetails.Text = "Get Exam Details";
			btn_examDetails.UseVisualStyleBackColor = true;
			btn_examDetails.Click += btn_examDetails_Click;
			// 
			// btn_stdGrades
			// 
			btn_stdGrades.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btn_stdGrades.Location = new Point(443, 229);
			btn_stdGrades.Name = "btn_stdGrades";
			btn_stdGrades.Size = new Size(279, 122);
			btn_stdGrades.TabIndex = 0;
			btn_stdGrades.Text = "Get Students Grades";
			btn_stdGrades.UseVisualStyleBackColor = true;
			btn_stdGrades.Click += btn_stdGrades_Click;
			// 
			// btn_crsTopic
			// 
			btn_crsTopic.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btn_crsTopic.Location = new Point(55, 229);
			btn_crsTopic.Name = "btn_crsTopic";
			btn_crsTopic.Size = new Size(279, 122);
			btn_crsTopic.TabIndex = 0;
			btn_crsTopic.Text = "Get Courses Topics";
			btn_crsTopic.UseVisualStyleBackColor = true;
			btn_crsTopic.Click += btn_crsTopic_Click;
			// 
			// insCrsWIthStdNum
			// 
			insCrsWIthStdNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			insCrsWIthStdNum.Location = new Point(55, 391);
			insCrsWIthStdNum.Name = "insCrsWIthStdNum";
			insCrsWIthStdNum.Size = new Size(279, 122);
			insCrsWIthStdNum.TabIndex = 0;
			insCrsWIthStdNum.Text = "Get Instructor Courses";
			insCrsWIthStdNum.UseVisualStyleBackColor = true;
			insCrsWIthStdNum.Click += insCrsWIthStdNum_Click;
			// 
			// btn_stdExams
			// 
			btn_stdExams.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btn_stdExams.Location = new Point(799, 391);
			btn_stdExams.Name = "btn_stdExams";
			btn_stdExams.Size = new Size(279, 122);
			btn_stdExams.TabIndex = 0;
			btn_stdExams.Text = "Get Student Exams";
			btn_stdExams.UseVisualStyleBackColor = true;
			btn_stdExams.Click += btn_stdExams_Click;
			// 
			// btn_stdInfo
			// 
			btn_stdInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btn_stdInfo.Location = new Point(443, 391);
			btn_stdInfo.Name = "btn_stdInfo";
			btn_stdInfo.Size = new Size(279, 122);
			btn_stdInfo.TabIndex = 0;
			btn_stdInfo.Text = "Get Student Info";
			btn_stdInfo.UseVisualStyleBackColor = true;
			btn_stdInfo.Click += btn_stdInfo_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(42, 55);
			label1.Name = "label1";
			label1.Size = new Size(356, 50);
			label1.TabIndex = 1;
			label1.Text = "Reports Dashboard";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(42, 133);
			label2.Name = "label2";
			label2.Size = new Size(1068, 28);
			label2.TabIndex = 1;
			label2.Text = "------------------------------------------------------------------------------------------------------------------------------------";
			// 
			// ReportsMainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1157, 624);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(insCrsWIthStdNum);
			Controls.Add(btn_crsTopic);
			Controls.Add(btn_stdGrades);
			Controls.Add(btn_stdInfo);
			Controls.Add(btn_stdExams);
			Controls.Add(btn_examDetails);
			Name = "ReportsMainForm";
			Text = "ReportsMainForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btn_examDetails;
		private Button btn_stdGrades;
		private Button btn_crsTopic;
		private Button insCrsWIthStdNum;
		private Button btn_stdExams;
		private Button btn_stdInfo;
		private Label label1;
		private Label label2;
	}
}