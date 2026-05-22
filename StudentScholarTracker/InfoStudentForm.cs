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
    public partial class InfoStudentForm : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Justine\Downloads\SABALLE OOP2\StudentScholarTracker\StudentScholarTracker\ScholarDatabase.accdb;";
        private string currentStudentID;
        public InfoStudentForm(string studentID)
        {
            InitializeComponent();
            this.currentStudentID = studentID;

            this.BackColor = Color.OldLace;

            LoadStudentProfile();
        }

        public StudentForm StudentForm
        {
            get => default;
            set
            {
            }
        }

        private void LoadStudentProfile()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Students WHERE StudentID = @sid";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@sid", currentStudentID);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblID.Text = reader["StudentID"].ToString();
                                lblFirstName.Text = reader["FirstName"].ToString();
                                lblLastName.Text = reader["LastName"].ToString();
                                lblDepartment.Text = reader["Department"].ToString();
                                lblGender.Text = reader["Gender"].ToString();

                                if (reader["DateOfBirth"] != DBNull.Value)
                                {
                                    DateTime dob = Convert.ToDateTime(reader["DateOfBirth"]);
                                    lblDOB.Text = dob.ToString("MMMM dd, yyyy");
                                }
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
