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
    public partial class EnrollmentInfoForm : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Justine\Downloads\SABALLE OOP2\StudentScholarTracker\StudentScholarTracker\ScholarDatabase.accdb;";
        int selectedEnrollmentID = 0;
        public EnrollmentInfoForm()
        {
            InitializeComponent();
            LoadEnrollmentData();
        }

        public AdminForm AdminForm
        {
            get => default;
            set
            {
            }
        }

        private void LoadEnrollmentData()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT EnrollmentID, StudentID, CourseID, [Midterm Grades], [Finals Grades] FROM Enrollments";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvEnrollments.DataSource = dt;

                    dgvEnrollments.Columns["EnrollmentID"].Visible = false; 
                    dgvEnrollments.Columns["StudentID"].HeaderText = "Student ID";
                    dgvEnrollments.Columns["CourseID"].HeaderText = "Course ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private void ClearFields()
        {
            txtStudentID.Clear();
            txtCourseID.Clear();
          
            selectedEnrollmentID = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) || string.IsNullOrWhiteSpace(txtCourseID.Text))
            {
                MessageBox.Show("Please fill in Student ID and Course ID.");
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Enrollments (StudentID, CourseID) VALUES (?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", txtStudentID.Text.Trim());
                        cmd.Parameters.AddWithValue("?", txtCourseID.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Student Enrolled Successfully!", "Admin Action");
                        LoadEnrollmentData();
                        ClearFields();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Save Error: " + ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedEnrollmentID == 0)
            {
                MessageBox.Show("Select a record from the list first.");
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    // Only update the Student/Course link
                    string query = "UPDATE Enrollments SET StudentID = ?, CourseID = ? WHERE EnrollmentID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", txtStudentID.Text.Trim());
                        cmd.Parameters.AddWithValue("?", txtCourseID.Text.Trim());
                        cmd.Parameters.AddWithValue("?", selectedEnrollmentID);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Enrollment updated successfully!");
                        LoadEnrollmentData();
                        ClearFields();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Update Error: " + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedEnrollmentID == 0) return;

            var result = MessageBox.Show("Remove student from this course?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (OleDbConnection conn = new OleDbConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Enrollments WHERE EnrollmentID = ?";
                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("?", selectedEnrollmentID);
                            cmd.ExecuteNonQuery();
                            LoadEnrollmentData();
                            ClearFields();
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Delete Error: " + ex.Message); }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadEnrollmentData();
        }

        private void dgvEnrollments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEnrollments.Rows[e.RowIndex];
                selectedEnrollmentID = Convert.ToInt32(row.Cells["EnrollmentID"].Value);
                txtStudentID.Text = row.Cells["StudentID"].Value?.ToString();
                txtCourseID.Text = row.Cells["CourseID"].Value?.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Enrollments WHERE StudentID LIKE @search OR CourseID LIKE @search";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvEnrollments.DataSource = dt;
                    }
                }
            }
            catch { }
        }
    }
}
