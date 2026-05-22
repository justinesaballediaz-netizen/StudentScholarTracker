namespace StudentScholarTracker
{
    partial class StudentGradesForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvMyGrades = new DataGridView();
            label1 = new Label();
            lblGWA = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMyGrades).BeginInit();
            SuspendLayout();
            // 
            // dgvMyGrades
            // 
            dgvMyGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMyGrades.BackgroundColor = Color.Bisque;
            dgvMyGrades.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvMyGrades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvMyGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvMyGrades.DefaultCellStyle = dataGridViewCellStyle4;
            dgvMyGrades.Dock = DockStyle.Bottom;
            dgvMyGrades.GridColor = Color.NavajoWhite;
            dgvMyGrades.Location = new Point(0, 214);
            dgvMyGrades.Name = "dgvMyGrades";
            dgvMyGrades.ReadOnly = true;
            dgvMyGrades.RowHeadersVisible = false;
            dgvMyGrades.RowHeadersWidth = 51;
            dgvMyGrades.Size = new Size(859, 252);
            dgvMyGrades.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans MT", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(229, 52);
            label1.Name = "label1";
            label1.Size = new Size(443, 83);
            label1.TabIndex = 3;
            label1.Text = "Student Grades";
            // 
            // lblGWA
            // 
            lblGWA.AutoSize = true;
            lblGWA.Font = new Font("Gill Sans MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGWA.Location = new Point(749, 184);
            lblGWA.Name = "lblGWA";
            lblGWA.Size = new Size(107, 27);
            lblGWA.TabIndex = 4;
            lblGWA.Text = "GWA: 0.00";
            // 
            // label2
            // 
            label2.BackColor = Color.DimGray;
            label2.Location = new Point(229, 135);
            label2.Name = "label2";
            label2.Size = new Size(446, 8);
            label2.TabIndex = 5;
            // 
            // StudentGradesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(859, 466);
            Controls.Add(label2);
            Controls.Add(lblGWA);
            Controls.Add(label1);
            Controls.Add(dgvMyGrades);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentGradesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvMyGrades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMyGrades;
        private Label label1;
        private Label lblGWA;
        private Label label2;
    }
}