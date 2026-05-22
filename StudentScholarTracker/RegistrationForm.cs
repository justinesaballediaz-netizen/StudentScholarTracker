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
    public partial class RegistrationForm : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Justine\Downloads\SABALLE OOP2\StudentScholarTracker\StudentScholarTracker\ScholarDatabase.accdb;";
        public RegistrationForm()
        {
            InitializeComponent();
        }
     
      
        private int GetNextStudentID()
        {
            int nextID = 230051;
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT MAX(StudentID) FROM Students";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            nextID = Convert.ToInt32(result) + 1;
                        }
                    }
                }
            }
            catch { }
            return nextID;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                 cboDepartment.SelectedIndex == -1 ||
                 string.IsNullOrWhiteSpace(txtUsername.Text) ||
                 string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Input Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    int newID = GetNextStudentID();

                    string query = "INSERT INTO Students (StudentID, FirstName, LastName, Email, Department, DateOfBirth, Gender, Username, [Password]) " +
                                   "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", newID);
                        cmd.Parameters.AddWithValue("?", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("?", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("?", txtEmail.Text.Trim());

                        cmd.Parameters.AddWithValue("?", cboDepartment.SelectedItem?.ToString() ?? "");

                        cmd.Parameters.AddWithValue("?", dtpBirthDate.Value.ToShortDateString());
                        cmd.Parameters.AddWithValue("?", txtGender.Text.Trim());
                        cmd.Parameters.AddWithValue("?", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("?", txtPassword.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Registration Successful!\nYour Student ID is: {newID}", "Welcome to ScholarTrack");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox) ((TextBox)c).Clear();
            }
            cboDepartment.SelectedIndex = -1;
            dtpBirthDate.Value = DateTime.Now;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
