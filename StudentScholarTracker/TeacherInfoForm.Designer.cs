namespace StudentScholarTracker
{
    partial class TeacherInfoForm
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            txtTeacherID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtDepartment = new TextBox();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Bisque;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.GridColor = Color.NavajoWhite;
            dataGridView1.Location = new Point(0, 262);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1057, 252);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 13);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 2;
            label2.Text = "Teacher ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(2, 108);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 3;
            label3.Text = "Department:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 42);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 3;
            label4.Text = "First Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 76);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 4;
            label5.Text = "Last Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(371, 9);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 5;
            label6.Text = "Email:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(344, 75);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 7;
            label8.Text = "Password:";
            // 
            // txtTeacherID
            // 
            txtTeacherID.Location = new Point(103, 6);
            txtTeacherID.Name = "txtTeacherID";
            txtTeacherID.Size = new Size(217, 27);
            txtTeacherID.TabIndex = 8;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(103, 39);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(217, 27);
            txtFirstName.TabIndex = 9;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(103, 72);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(217, 27);
            txtLastName.TabIndex = 10;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(103, 105);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(217, 27);
            txtDepartment.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(427, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(217, 27);
            txtEmail.TabIndex = 12;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(427, 39);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(217, 27);
            txtUsername.TabIndex = 13;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(427, 72);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(217, 27);
            txtPassword.TabIndex = 14;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LimeGreen;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(97, 223);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(84, 32);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Tomato;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(187, 223);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 32);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(277, 222);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(84, 33);
            btnClear.TabIndex = 29;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(720, 222);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(325, 29);
            txtSearch.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(344, 42);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 31;
            label1.Text = "Username:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.GreenYellow;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(7, 222);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(84, 33);
            btnSave.TabIndex = 32;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(871, 183);
            button1.Name = "button1";
            button1.Size = new Size(84, 33);
            button1.TabIndex = 33;
            button1.Text = "Export";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(961, 183);
            button2.Name = "button2";
            button2.Size = new Size(84, 33);
            button2.TabIndex = 34;
            button2.Text = "Import";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // TeacherInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1057, 514);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Controls.Add(txtDepartment);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtTeacherID);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TeacherInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminTeacherInfo";
            Load += TeacherInfoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private TextBox txtTeacherID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtDepartment;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private TextBox txtSearch;
        private Label label1;
        private Button btnSave;
        private Button button1;
        private Button button2;
    }
}