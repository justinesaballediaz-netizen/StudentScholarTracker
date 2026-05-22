namespace StudentScholarTracker
{
    partial class StudentInfoForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvStudents = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtGender = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            label2 = new Label();
            btnClear = new Button();
            txtDepartment = new TextBox();
            label1 = new Label();
            dtpDOB = new DateTimePicker();
            btnImport = new Button();
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = Color.Bisque;
            dgvStudents.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvStudents.DefaultCellStyle = dataGridViewCellStyle2;
            dgvStudents.Dock = DockStyle.Bottom;
            dgvStudents.GridColor = Color.NavajoWhite;
            dgvStudents.Location = new Point(0, 262);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(1057, 252);
            dgvStudents.TabIndex = 0;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 42);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 3;
            label3.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 75);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 4;
            label4.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(43, 109);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 5;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(352, 9);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 6;
            label6.Text = "Date Of Birth:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(390, 42);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 7;
            label7.Text = "Gender:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(372, 78);
            label8.Name = "label8";
            label8.Size = new Size(82, 20);
            label8.TabIndex = 8;
            label8.Text = "Username:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(377, 111);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 9;
            label9.Text = "Password:";
            // 
            // txtID
            // 
            txtID.Location = new Point(102, 6);
            txtID.Name = "txtID";
            txtID.Size = new Size(217, 27);
            txtID.TabIndex = 10;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(102, 39);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(217, 27);
            txtFirstName.TabIndex = 11;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(99, 75);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(217, 27);
            txtLastName.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(99, 108);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(217, 27);
            txtEmail.TabIndex = 13;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(460, 39);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(217, 27);
            txtGender.TabIndex = 15;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(460, 75);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(217, 27);
            txtUsername.TabIndex = 16;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(460, 108);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(217, 27);
            txtPassword.TabIndex = 17;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.GreenYellow;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(9, 222);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(84, 33);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LimeGreen;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(102, 222);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(84, 33);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Tomato;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(192, 222);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 33);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(720, 222);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(325, 29);
            txtSearch.TabIndex = 25;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 9);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 27;
            label2.Text = "Student ID:";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(282, 222);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(84, 33);
            btnClear.TabIndex = 28;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(99, 146);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(217, 27);
            txtDepartment.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, 149);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 29;
            label1.Text = "Department:";
            // 
            // dtpDOB
            // 
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(460, 6);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(217, 27);
            dtpDOB.TabIndex = 31;
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.DeepSkyBlue;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImport.Location = new Point(961, 183);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(84, 33);
            btnImport.TabIndex = 32;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.LightBlue;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.Location = new Point(871, 183);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(84, 33);
            btnExport.TabIndex = 33;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // StudentInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1057, 514);
            Controls.Add(btnExport);
            Controls.Add(btnImport);
            Controls.Add(dtpDOB);
            Controls.Add(txtDepartment);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtGender);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtID);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvStudents);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminStudentInfo";
            Load += StudentInfoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudents;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtGender;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtSearch;
        private Label label2;
        private Button btnClear;
        private TextBox txtDepartment;
        private Label label1;
        private DateTimePicker dtpDOB;
        private Button btnImport;
        private Button btnExport;
    }
}