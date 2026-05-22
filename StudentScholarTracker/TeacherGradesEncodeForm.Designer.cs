namespace StudentScholarTracker
{
    partial class TeacherGradesEncodeForm
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
            dgvStudents = new DataGridView();
            txtSearch = new TextBox();
            label2 = new Label();
            txtCourse = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtStudentID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtMidterm = new TextBox();
            label1 = new Label();
            txtFinals = new TextBox();
            label6 = new Label();
            btnUpdate = new Button();
            btnClear = new Button();
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.BorderStyle = BorderStyle.None;
            dgvStudents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvStudents.DefaultCellStyle = dataGridViewCellStyle2;
            dgvStudents.Dock = DockStyle.Bottom;
            dgvStudents.EnableHeadersVisualStyles = false;
            dgvStudents.GridColor = Color.Gainsboro;
            dgvStudents.Location = new Point(0, 233);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(1039, 242);
            dgvStudents.TabIndex = 2;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(683, 200);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(344, 27);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(109, 42);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 35;
            label2.Text = "Student ID:";
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(556, 39);
            txtCourse.Name = "txtCourse";
            txtCourse.ReadOnly = true;
            txtCourse.Size = new Size(217, 27);
            txtCourse.TabIndex = 34;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(200, 108);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(217, 27);
            txtLastName.TabIndex = 33;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(203, 72);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(217, 27);
            txtFirstName.TabIndex = 32;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(203, 39);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.ReadOnly = true;
            txtStudentID.Size = new Size(217, 27);
            txtStudentID.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(482, 42);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 30;
            label5.Text = "Course:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(113, 108);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 29;
            label4.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(110, 75);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 28;
            label3.Text = "First Name:";
            // 
            // txtMidterm
            // 
            txtMidterm.Location = new Point(556, 75);
            txtMidterm.Name = "txtMidterm";
            txtMidterm.Size = new Size(217, 27);
            txtMidterm.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(434, 75);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 36;
            label1.Text = "Midterm grade:";
            // 
            // txtFinals
            // 
            txtFinals.Location = new Point(556, 111);
            txtFinals.Name = "txtFinals";
            txtFinals.Size = new Size(217, 27);
            txtFinals.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(454, 111);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 38;
            label6.Text = "Final grades:";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.GreenYellow;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(12, 186);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 41);
            btnUpdate.TabIndex = 39;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(113, 186);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 41);
            btnClear.TabIndex = 40;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.GreenYellow;
            btnExport.FlatStyle = FlatStyle.Popup;
            btnExport.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.Location = new Point(213, 186);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(94, 41);
            btnExport.TabIndex = 41;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // TeacherGradesEncodeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1039, 475);
            Controls.Add(btnExport);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(txtFinals);
            Controls.Add(label6);
            Controls.Add(txtMidterm);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtCourse);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtStudentID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSearch);
            Controls.Add(dgvStudents);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TeacherGradesEncodeForm";
            Text = "Form1";
            Load += TeacherGradesEncodeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudents;
        private TextBox txtSearch;
        private Label label2;
        private TextBox txtCourse;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtStudentID;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtMidterm;
        private Label label1;
        private TextBox txtFinals;
        private Label label6;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnExport;
    }
}