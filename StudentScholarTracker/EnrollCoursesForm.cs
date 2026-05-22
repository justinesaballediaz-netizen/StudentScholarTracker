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
    public partial class EnrollCoursesForm : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Justine\Downloads\SABALLE OOP2\StudentScholarTracker\StudentScholarTracker\ScholarDatabase.accdb;";
        private string sid;
        public EnrollCoursesForm(string studentID)
        {
            InitializeComponent();
            this.sid = studentID;
        }
        private void EnrollCoursesForm_Load(object sender, EventArgs e)
        {
            LoadDepartmentCourses();
        }

        private void LoadDepartmentCourses()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    string deptQuery = "SELECT Department FROM Students WHERE StudentID = ?";
                    string deptName = "";
                    using (OleDbCommand deptCmd = new OleDbCommand(deptQuery, conn))
                    {
                        deptCmd.Parameters.AddWithValue("?", sid);
                        object result = deptCmd.ExecuteScalar();
                        deptName = result != null ? result.ToString() : "";
                    }

                    string prefix = "";
                    if (deptName.Contains("Computer")) prefix = "CPE";
                    else if (deptName.Contains("Civil")) prefix = "CE";
                    else if (deptName.Contains("Chemical")) prefix = "CHE";
                    else if (deptName.Contains("Electrical")) prefix = "EE";
                    else if (deptName.Contains("Mechanical")) prefix = "ME";
                    else prefix = "GEN";

                    string courseQuery = "SELECT CourseID, CourseCode, Title, Section, Day, ScheduleTime, Units FROM Course " +
                                         "WHERE CourseCode LIKE ? " +
                                         "OR CourseCode LIKE 'MAT%' " +
                                         "OR CourseCode LIKE 'PHY%'";

                    using (OleDbCommand cmd = new OleDbCommand(courseQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("?", prefix + "%");

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvAvailableCourses.DataSource = dt;

                        if (dgvAvailableCourses.Columns.Contains("CourseID"))
                            dgvAvailableCourses.Columns["CourseID"].Visible = false;

                        // Optional: Make headers look nicer
                        dgvAvailableCourses.Columns["CourseCode"].HeaderText = "Code";
                        dgvAvailableCourses.Columns["ScheduleTime"].HeaderText = "Time";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (dgvAvailableCourses.CurrentRow == null)
            {
                MessageBox.Show("Please select a course from the list.");
                return;
            }

            string selectedCourseID = dgvAvailableCourses.CurrentRow.Cells["CourseID"].Value.ToString();
            string selectedCourseCode = dgvAvailableCourses.CurrentRow.Cells["CourseCode"].Value.ToString();

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                   
                    string checkQuery = @"SELECT COUNT(*) FROM Enrollments 
                                 INNER JOIN Course ON Enrollments.CourseID = Course.CourseID 
                                 WHERE Enrollments.StudentID = ? AND Course.CourseCode = ?";

                    using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("?", sid);
                        checkCmd.Parameters.AddWithValue("?", selectedCourseCode);

                        int subjectExists = (int)checkCmd.ExecuteScalar();

                        if (subjectExists > 0)
                        {
                            MessageBox.Show($"You are already enrolled in a section of {selectedCourseCode}!",
                                "Duplicate Subject", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string enrollQuery = "INSERT INTO Enrollments (StudentID, CourseID, [Midterm Grades], [Finals Grades]) " +
                                         "VALUES (?, ?, 0, 0)";

                    using (OleDbCommand enrollCmd = new OleDbCommand(enrollQuery, conn))
                    {
                        enrollCmd.Parameters.AddWithValue("?", sid);
                        enrollCmd.Parameters.AddWithValue("?", selectedCourseID);
                        enrollCmd.ExecuteNonQuery();

                        MessageBox.Show($"Successfully enrolled in {selectedCourseCode}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enrollment Error: " + ex.Message);
            }
        }
    }
}
