namespace exam_app
{
    partial class CrudInstructorForm
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
            txt_id = new TextBox();
            label1 = new Label();
            btn_searchByID = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            txt_fname = new TextBox();
            txt_lname = new TextBox();
            txt_phone = new TextBox();
            dgv_instructor = new DataGridView();
            cb_insDegree = new ComboBox();
            dtp_birthdate = new DateTimePicker();
            btn_add = new Button();
            btn_update = new Button();
            btn_remove = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_instructor).BeginInit();
            SuspendLayout();
            // 
            // txt_id
            // 
            txt_id.Location = new Point(417, 27);
            txt_id.Margin = new Padding(4);
            txt_id.Multiline = true;
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(159, 48);
            txt_id.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(231, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 1;
            label1.Text = "Enter Instructor ID";
            // 
            // btn_searchByID
            // 
            btn_searchByID.BackColor = SystemColors.GradientActiveCaption;
            btn_searchByID.ForeColor = Color.Black;
            btn_searchByID.Location = new Point(611, 27);
            btn_searchByID.Margin = new Padding(4);
            btn_searchByID.Name = "btn_searchByID";
            btn_searchByID.Size = new Size(142, 48);
            btn_searchByID.TabIndex = 2;
            btn_searchByID.Text = "Search";
            btn_searchByID.UseVisualStyleBackColor = false;
            btn_searchByID.Click += btn_showData_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(62, 128);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 3;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(578, 128);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(62, 220);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(143, 25);
            label4.TabIndex = 5;
            label4.Text = "Scientific Degree";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(578, 223);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 6;
            label5.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(62, 304);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(90, 25);
            label7.TabIndex = 8;
            label7.Text = "Birth Date";
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(212, 125);
            txt_fname.Margin = new Padding(4);
            txt_fname.Multiline = true;
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(266, 39);
            txt_fname.TabIndex = 12;
            // 
            // txt_lname
            // 
            txt_lname.Location = new Point(678, 128);
            txt_lname.Margin = new Padding(4);
            txt_lname.Multiline = true;
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(266, 39);
            txt_lname.TabIndex = 13;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(675, 218);
            txt_phone.Margin = new Padding(4);
            txt_phone.Multiline = true;
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(266, 39);
            txt_phone.TabIndex = 15;
            // 
            // dgv_instructor
            // 
            dgv_instructor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_instructor.Location = new Point(12, 443);
            dgv_instructor.Name = "dgv_instructor";
            dgv_instructor.RowHeadersWidth = 55;
            dgv_instructor.Size = new Size(975, 198);
            dgv_instructor.TabIndex = 22;
            // 
            // cb_insDegree
            // 
            cb_insDegree.FormattingEnabled = true;
            cb_insDegree.Location = new Point(212, 220);
            cb_insDegree.Name = "cb_insDegree";
            cb_insDegree.Size = new Size(266, 33);
            cb_insDegree.TabIndex = 23;
            // 
            // dtp_birthdate
            // 
            dtp_birthdate.Location = new Point(212, 298);
            dtp_birthdate.Name = "dtp_birthdate";
            dtp_birthdate.Size = new Size(266, 31);
            dtp_birthdate.TabIndex = 24;
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.GradientActiveCaption;
            btn_add.Font = new Font("Segoe UI Variable Display", 11.8125F);
            btn_add.Location = new Point(230, 369);
            btn_add.Margin = new Padding(4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(142, 54);
            btn_add.TabIndex = 18;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.GradientActiveCaption;
            btn_update.Font = new Font("Segoe UI Variable Display", 11.8125F);
            btn_update.Location = new Point(434, 369);
            btn_update.Margin = new Padding(4);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(142, 54);
            btn_update.TabIndex = 21;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_remove
            // 
            btn_remove.BackColor = Color.FromArgb(192, 0, 0);
            btn_remove.Font = new Font("Segoe UI Variable Display", 11.8125F);
            btn_remove.Location = new Point(629, 369);
            btn_remove.Margin = new Padding(4);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(142, 54);
            btn_remove.TabIndex = 20;
            btn_remove.Text = "Remove";
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Click += btn_remove_Click;
            // 
            // CrudInstructorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 682);
            Controls.Add(dtp_birthdate);
            Controls.Add(cb_insDegree);
            Controls.Add(dgv_instructor);
            Controls.Add(btn_update);
            Controls.Add(btn_remove);
            Controls.Add(btn_add);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_searchByID);
            Controls.Add(label1);
            Controls.Add(txt_id);
            Controls.Add(txt_phone);
            Controls.Add(txt_lname);
            Controls.Add(txt_fname);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(4);
            Name = "CrudInstructorForm";
            Text = "CRUD Instructor";
            Load += CrudInstructorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_instructor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_id;
        private Label label1;
        private Button btn_searchByID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox txt_fname;
        private TextBox txt_lname;
        private TextBox txt_phone;
        private DataGridView dgv_instructor;
        private ComboBox cb_insDegree;
        private DateTimePicker dtp_birthdate;
        private Button btn_add;
        private Button btn_update;
        private Button btn_remove;
    }
}