namespace exam_app
{
	partial class FinalGradeForm
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
			label1 = new Label();
			label_grade = new Label();
			btn_continue = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(315, 86);
			label1.Name = "label1";
			label1.Size = new Size(155, 31);
			label1.TabIndex = 0;
			label1.Text = "Your Grade Is";
			// 
			// label_grade
			// 
			label_grade.AutoSize = true;
			label_grade.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label_grade.Location = new Point(340, 157);
			label_grade.Name = "label_grade";
			label_grade.Size = new Size(105, 81);
			label_grade.TabIndex = 1;
			label_grade.Text = "00";
			// 
			// btn_continue
			// 
			btn_continue.Location = new Point(340, 305);
			btn_continue.Name = "btn_continue";
			btn_continue.Size = new Size(105, 29);
			btn_continue.TabIndex = 2;
			btn_continue.Text = "Continue";
			btn_continue.UseVisualStyleBackColor = true;
			btn_continue.Click += btn_continue_Click;
			// 
			// FinalGradeForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btn_continue);
			Controls.Add(label_grade);
			Controls.Add(label1);
			Name = "FinalGradeForm";
			Text = "FinalGradeForm";
			Load += FinalGradeForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label_grade;
		private Button btn_continue;
	}
}