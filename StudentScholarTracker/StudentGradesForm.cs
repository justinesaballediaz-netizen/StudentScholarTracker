using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentScholarTracker
{
    public partial class StudentGradesForm : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Justine\Downloads\SABALLE OOP2\StudentScholarTracker\StudentScholarTracker\ScholarDatabase.accdb;";
        private string currentStudentID;
        public StudentGradesForm(string studentID)
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(studentID))
            {
                MessageBox.Show("Student ID was not received. Please re-login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.currentStudentID = studentID;

            this.Load += StudentGradesForm_Load;
            ApplyWebStyle();
            LoadMyGrades();

        }

     
        

        private void ApplyWebStyle()
        {
            // Form Background
            this.BackColor = Color.OldLace;

            // Grid Basics
            dgvMyGrades.BackgroundColor = Color.White;
            dgvMyGrades.BorderStyle = BorderStyle.None;
            dgvMyGrades.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMyGrades.EnableHeadersVisualStyles = false; // Required for custom header colors
            dgvMyGrades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMyGrades.RowHeadersVisible = false; // Makes it look cleaner

            // Header Styling (Light Blue Background, Dark Blue Text)
            dgvMyGrades.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(217, 237, 247);
            dgvMyGrades.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(49, 112, 143);
            dgvMyGrades.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvMyGrades.ColumnHeadersHeight = 40;

            // Rows Styling
            dgvMyGrades.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvMyGrades.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 245, 245);
            dgvMyGrades.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvMyGrades.RowTemplate.Height = 35;

            // Alternating row color for better readability
            dgvMyGrades.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
        }
        private void StudentGradesForm_Load(object sender, EventArgs e)
        {
            StyleDataGridView();
        }
        private void LoadMyGrades()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT [Course].[CourseCode], [Course].[Title], " +
                                   "[Enrollments].[Midterm Grades], [Enrollments].[Finals Grades] " +
                                   "FROM [Course] INNER JOIN [Enrollments] ON [Course].[CourseID] = [Enrollments].[CourseID] " +
                                   "WHERE [Enrollments].[StudentID] = @sid";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@sid", currentStudentID);

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvMyGrades.DataSource = dt;

                            CalculateGPA();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading grades: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void StyleDataGridView()
        {
            dgvMyGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMyGrades.BackgroundColor = System.Drawing.Color.OldLace; 
            dgvMyGrades.BorderStyle = BorderStyle.None;
            dgvMyGrades.ReadOnly = true;
            dgvMyGrades.RowHeadersVisible = false;
            dgvMyGrades.AllowUserToAddRows = false;
        }
        private void CalculateGPA()
        {
            double totalGrades = 0;
            int subjectCount = 0;

            foreach (DataGridViewRow row in dgvMyGrades.Rows)
            {
                if (row.Cells["Finals Grades"].Value != null && row.Cells["Finals Grades"].Value != DBNull.Value)
                {
                    totalGrades += Convert.ToDouble(row.Cells["Finals Grades"].Value);
                    subjectCount++;
                }
            }

            if (subjectCount > 0)
            {
                double gwa = totalGrades / subjectCount;
                lblGWA.Text = "GWA: " + gwa.ToString("0.00");

                // Color logic for GWA (1.0 - 5.0 scale)
                if (gwa <= 1.75)
                    lblGWA.ForeColor = Color.ForestGreen; 
                    lblGWA.ForeColor = Color.Red;         
                    lblGWA.ForeColor = Color.Black;       
            }
            else
            {
                lblGWA.Text = "GWA: N/A";
            }
        }
    }
}
