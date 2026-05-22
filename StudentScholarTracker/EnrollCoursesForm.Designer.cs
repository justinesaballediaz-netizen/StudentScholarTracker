namespace StudentScholarTracker
{
    partial class EnrollCoursesForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvAvailableCourses = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            txtSearch = new TextBox();
            btnRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableCourses).BeginInit();
            SuspendLayout();
            // 
            // dgvAvailableCourses
            // 
            dgvAvailableCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAvailableCourses.BackgroundColor = Color.White;
            dgvAvailableCourses.BorderStyle = BorderStyle.None;
            dgvAvailableCourses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvAvailableCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAvailableCourses.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAvailableCourses.Dock = DockStyle.Bottom;
            dgvAvailableCourses.EnableHeadersVisualStyles = false;
            dgvAvailableCourses.GridColor = Color.Gainsboro;
            dgvAvailableCourses.Location = new Point(0, 233);
            dgvAvailableCourses.Name = "dgvAvailableCourses";
            dgvAvailableCourses.RowHeadersVisible = false;
            dgvAvailableCourses.RowHeadersWidth = 51;
            dgvAvailableCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailableCourses.Size = new Size(1021, 242);
            dgvAvailableCourses.TabIndex = 3;
            // 
            // label2
            // 
            label2.BackColor = Color.DimGray;
            label2.Location = new Point(269, 118);
            label2.Name = "label2";
            label2.Size = new Size(446, 8);
            label2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans MT", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(283, 35);
            label1.Name = "label1";
            label1.Size = new Size(415, 83);
            label1.TabIndex = 9;
            label1.Text = "Enroll Courses";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(695, 200);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(326, 27);
            txtSearch.TabIndex = 11;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.GreenYellow;
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(12, 187);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(139, 40);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // EnrollCoursesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1021, 475);
            Controls.Add(btnRegister);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvAvailableCourses);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EnrollCoursesForm";
            Text = "Form1";
            Load += EnrollCoursesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAvailableCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAvailableCourses;
        private Label label2;
        private Label label1;
        private TextBox txtSearch;
        private Button btnRegister;
    }
}