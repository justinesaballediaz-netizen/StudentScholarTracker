namespace StudentScholarTracker
{
    partial class CourseInfoForm
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
            dgvCourses = new DataGridView();
            btnClear = new Button();
            txtSearch = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            label2 = new Label();
            txtUnits = new TextBox();
            txtTitle = new TextBox();
            txtCourseID = new TextBox();
            label5 = new Label();
            label3 = new Label();
            txtTeacherID = new TextBox();
            label6 = new Label();
            txtCourseCode = new TextBox();
            label1 = new Label();
            btnExport = new Button();
            btnImport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // dgvCourses
            // 
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.BackgroundColor = Color.Bisque;
            dgvCourses.BorderStyle = BorderStyle.None;
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Dock = DockStyle.Bottom;
            dgvCourses.GridColor = Color.NavajoWhite;
            dgvCourses.Location = new Point(0, 267);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.RowHeadersVisible = false;
            dgvCourses.RowHeadersWidth = 51;
            dgvCourses.Size = new Size(877, 246);
            dgvCourses.TabIndex = 0;
            dgvCourses.CellContentClick += dgvCourses_CellContentClick;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(278, 228);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(84, 33);
            btnClear.TabIndex = 33;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(536, 228);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(325, 29);
            txtSearch.TabIndex = 32;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Tomato;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(188, 228);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 33);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LimeGreen;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(98, 228);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(84, 33);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.GreenYellow;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(5, 228);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(84, 33);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 41;
            label2.Text = "Course ID:";
            // 
            // txtUnits
            // 
            txtUnits.Location = new Point(117, 108);
            txtUnits.Name = "txtUnits";
            txtUnits.Size = new Size(217, 27);
            txtUnits.TabIndex = 40;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(117, 75);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(217, 27);
            txtTitle.TabIndex = 39;
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(117, 6);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(217, 27);
            txtCourseID.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 108);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 36;
            label5.Text = "Units:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 42);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 34;
            label3.Text = "Course Code:";
            // 
            // txtTeacherID
            // 
            txtTeacherID.Location = new Point(444, 10);
            txtTeacherID.Name = "txtTeacherID";
            txtTeacherID.Size = new Size(217, 27);
            txtTeacherID.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(353, 13);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 42;
            label6.Text = "Teacher ID:";
            // 
            // txtCourseCode
            // 
            txtCourseCode.Location = new Point(117, 42);
            txtCourseCode.Name = "txtCourseCode";
            txtCourseCode.Size = new Size(217, 27);
            txtCourseCode.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 75);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 45;
            label1.Text = "Title:";
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.LightBlue;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.Location = new Point(687, 189);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(84, 33);
            btnExport.TabIndex = 47;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.DeepSkyBlue;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImport.Location = new Point(777, 189);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(84, 33);
            btnImport.TabIndex = 46;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = false;
            // 
            // CourseInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(877, 513);
            Controls.Add(btnExport);
            Controls.Add(btnImport);
            Controls.Add(label1);
            Controls.Add(txtCourseCode);
            Controls.Add(txtTeacherID);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(txtUnits);
            Controls.Add(txtTitle);
            Controls.Add(txtCourseID);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btnClear);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(dgvCourses);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CourseInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CourseInfoForm";
            Load += CourseInfoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCourses;
        private Button btnClear;
        private TextBox txtSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private Label label2;
        private TextBox txtUnits;
        private TextBox txtTitle;
        private TextBox txtCourseID;
        private Label label5;
        private Label label3;
        private TextBox txtTeacherID;
        private Label label6;
        private TextBox txtCourseCode;
        private Label label1;
        private Button btnExport;
        private Button btnImport;
    }
}