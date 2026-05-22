namespace StudentScholarTracker
{
    partial class EnrollmentInfoForm
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
            dgvEnrollments = new DataGridView();
            label2 = new Label();
            txtCourseID = new TextBox();
            txtStudentID = new TextBox();
            label3 = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            txtSearch = new TextBox();
            btnExport = new Button();
            btnImport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEnrollments).BeginInit();
            SuspendLayout();
            // 
            // dgvEnrollments
            // 
            dgvEnrollments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEnrollments.BackgroundColor = Color.Bisque;
            dgvEnrollments.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEnrollments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEnrollments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEnrollments.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEnrollments.Dock = DockStyle.Bottom;
            dgvEnrollments.GridColor = Color.NavajoWhite;
            dgvEnrollments.Location = new Point(0, 261);
            dgvEnrollments.Name = "dgvEnrollments";
            dgvEnrollments.RowHeadersVisible = false;
            dgvEnrollments.RowHeadersWidth = 51;
            dgvEnrollments.Size = new Size(877, 252);
            dgvEnrollments.TabIndex = 1;
            dgvEnrollments.CellContentClick += dgvEnrollments_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 94);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 31;
            label2.Text = "Student ID:";
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(538, 94);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(217, 27);
            txtCourseID.TabIndex = 30;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(167, 91);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(217, 27);
            txtStudentID.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(445, 97);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 28;
            label3.Text = "Course ID:";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(282, 222);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(84, 33);
            btnClear.TabIndex = 39;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Tomato;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(192, 222);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 33);
            btnDelete.TabIndex = 38;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LimeGreen;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(102, 222);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(84, 33);
            btnUpdate.TabIndex = 37;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.GreenYellow;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(12, 222);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(84, 33);
            btnSave.TabIndex = 36;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(540, 222);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(325, 29);
            txtSearch.TabIndex = 40;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.LightBlue;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.Location = new Point(691, 183);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(84, 33);
            btnExport.TabIndex = 42;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.DeepSkyBlue;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImport.Location = new Point(781, 183);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(84, 33);
            btnImport.TabIndex = 41;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = false;
            // 
            // EnrollmentInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(877, 513);
            Controls.Add(btnExport);
            Controls.Add(btnImport);
            Controls.Add(txtSearch);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(txtCourseID);
            Controls.Add(txtStudentID);
            Controls.Add(label3);
            Controls.Add(dgvEnrollments);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EnrollmentInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEnrollments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEnrollments;
        private Label label2;
        private TextBox txtCourseID;
        private TextBox txtStudentID;
        private Label label3;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private TextBox txtSearch;
        private Button btnExport;
        private Button btnImport;
    }
}