using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace StudentScholarTracker
{
    public partial class CourseInfoForm : Form
    {
        string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Justine\Downloads\SABALLE OOP2\StudentScholarTracker\StudentScholarTracker\ScholarDatabase.accdb;";
        public CourseInfoForm()
        {
            InitializeComponent();
        }

     

        void LoadData()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    string query = "SELECT * FROM Course";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvCourses.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading courses: " + ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    string query = "INSERT INTO Course ([CourseCode], [Title], [Units], [TeacherID]) VALUES (?, ?, ?, ?)";
                    OleDbCommand cmd = new OleDbCommand(query, conn);

                    cmd.Parameters.AddWithValue("?", txtCourseCode.Text);
                    cmd.Parameters.AddWithValue("?", txtTitle.Text);

                    cmd.Parameters.AddWithValue("?", int.Parse(txtUnits.Text));
                    cmd.Parameters.AddWithValue("?", int.Parse(txtTeacherID.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course Saved successfully!");
                    LoadData();
                    btnClear_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Save Error: " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCourseID.Clear();
            txtCourseCode.Clear();
            txtTitle.Clear();
            txtUnits.Clear();
            txtTeacherID.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCourseID.Text))
            {
                MessageBox.Show("Please select a course from the list first.");
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                string query = "UPDATE Course SET [CourseCode]=?, [Title]=?, [Units]=?, [TeacherID]=? WHERE [CourseID]=?";
                OleDbCommand cmd = new OleDbCommand(query, conn);

                try
                {
                    cmd.Parameters.AddWithValue("?", txtCourseCode.Text);
                    cmd.Parameters.AddWithValue("?", txtTitle.Text);

                    cmd.Parameters.AddWithValue("?", int.Parse(txtUnits.Text));
                    cmd.Parameters.AddWithValue("?", int.Parse(txtTeacherID.Text));
                    cmd.Parameters.AddWithValue("?", int.Parse(txtCourseID.Text));

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Course updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Update failed. No record found with that ID. Do not change the ID number manually.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update Error: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCourseID.Text))
            {
                MessageBox.Show("Please select a course to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this course?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    string query = "DELETE FROM Course WHERE [CourseID]=?";
                    OleDbCommand cmd = new OleDbCommand(query, conn);

                    try
                    {
                        cmd.Parameters.AddWithValue("?", int.Parse(txtCourseID.Text));

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Course deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadData(); 
                        btnClear_Click(null, null); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Delete Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                string query = "SELECT * FROM Course WHERE [Title] LIKE ? OR [CourseCode] LIKE ?";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);

                adapter.SelectCommand.Parameters.AddWithValue("?", "%" + txtSearch.Text + "%");
                adapter.SelectCommand.Parameters.AddWithValue("?", "%" + txtSearch.Text + "%");

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvCourses.DataSource = dt;
            }
        }

        private void dgvCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCourses.Rows[e.RowIndex];

                txtCourseID.Text = row.Cells["CourseID"].Value.ToString();
                txtCourseCode.Text = row.Cells["CourseCode"].Value.ToString();
                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtUnits.Text = row.Cells["Units"].Value.ToString();
                txtTeacherID.Text = row.Cells["TeacherID"].Value.ToString();
            }
        }

        private void CourseInfoForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}
