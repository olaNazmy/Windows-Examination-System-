namespace exam_app
{
    partial class StartExamForm
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
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>

		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			timer1 = new System.Windows.Forms.Timer(components);
			btn_prev = new Button();
			btn_next = new Button();
			button1 = new Button();
			lbl_examDuration = new Label();
			SuspendLayout();
			// 
			// timer1
			// 
			timer1.Interval = 1000;
			timer1.Tick += timer1_Tick;
			// 
			// btn_prev
			// 
			btn_prev.BackColor = Color.ForestGreen;
			btn_prev.Font = new Font("Tahoma", 16.2F, FontStyle.Bold);
			btn_prev.ForeColor = SystemColors.ButtonHighlight;
			btn_prev.Location = new Point(437, 557);
			btn_prev.Name = "btn_prev";
			btn_prev.Size = new Size(216, 66);
			btn_prev.TabIndex = 0;
			btn_prev.Text = "PREVIOUS";
			btn_prev.UseVisualStyleBackColor = false;
			btn_prev.Click += btn_prev_Click;
			// 
			// btn_next
			// 
			btn_next.BackColor = SystemColors.MenuHighlight;
			btn_next.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btn_next.ForeColor = SystemColors.ButtonHighlight;
			btn_next.Location = new Point(702, 556);
			btn_next.Name = "btn_next";
			btn_next.Size = new Size(210, 69);
			btn_next.TabIndex = 1;
			btn_next.Text = "NEXT";
			btn_next.UseVisualStyleBackColor = false;
			btn_next.Click += btn_next_Click;
			// 
			// button1
			// 
			button1.BackColor = Color.Black;
			button1.Font = new Font("Tahoma", 16.2F, FontStyle.Bold);
			button1.ForeColor = SystemColors.ButtonHighlight;
			button1.Location = new Point(1040, 557);
			button1.Name = "button1";
			button1.Size = new Size(293, 66);
			button1.TabIndex = 2;
			button1.Text = "Submit Answers";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// lbl_examDuration
			// 
			lbl_examDuration.AutoSize = true;
			lbl_examDuration.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lbl_examDuration.Location = new Point(2, 574);
			lbl_examDuration.Name = "lbl_examDuration";
			lbl_examDuration.Size = new Size(160, 36);
			lbl_examDuration.TabIndex = 3;
			lbl_examDuration.Text = "start_timer";
			// 
			// StartExamForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1358, 767);
			Controls.Add(lbl_examDuration);
			Controls.Add(button1);
			Controls.Add(btn_next);
			Controls.Add(btn_prev);
			Name = "StartExamForm";
			Text = "StartExamForm";
			Load += StartExamForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Timer timer1;
        private Button btn_prev;
        private Button btn_next;
        private Button button1;
        private Label lbl_examDuration;
    }
}