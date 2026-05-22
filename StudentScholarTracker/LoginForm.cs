using System;
using System.Data.OleDb; 
using System.Windows.Forms;
namespace StudentScholarTracker
{
    public partial class LoginForm : Form
    {

        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Justine\Downloads\SABALLE OOP2\StudentScholarTracker\StudentScholarTracker\ScholarDatabase.accdb;";
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUname.Text.Trim();
            string password = txtPass.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    string adminQuery = "SELECT COUNT(*) FROM Admins WHERE Username = @uname AND [Password] = @pass";
                    using (OleDbCommand adminCmd = new OleDbCommand(adminQuery, conn))
                    {
                        adminCmd.Parameters.AddWithValue("@uname", username);
                        adminCmd.Parameters.AddWithValue("@pass", password);

                        int isAdmin = (int)adminCmd.ExecuteScalar();

                        if (isAdmin > 0)
                        {
                            MessageBox.Show("Welcome, Admin!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AdminForm adminDashboard = new AdminForm();
                            adminDashboard.Show();
                            this.Hide();
                            return;
                        }
                    }

                    string teacherQuery = "SELECT TeacherID FROM Teachers WHERE [Username] = @uname AND [Password] = @pass";
                    using (OleDbCommand teacherCmd = new OleDbCommand(teacherQuery, conn))
                    {
                        teacherCmd.Parameters.AddWithValue("@uname", username);
                        teacherCmd.Parameters.AddWithValue("@pass", password);

                        object result = teacherCmd.ExecuteScalar();

                        if (result != null)
                        {
                            string teacherID = result.ToString();

                            MessageBox.Show($"Welcome, Teacher {username}!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            TeacherForm teacherDash = new TeacherForm(teacherID);
                            teacherDash.Show();
                            this.Hide();
                            return;
                        }
                    }

                    string studentQuery = "SELECT StudentID FROM Students WHERE [Username] = @uname AND [Password] = @pass";
                    using (OleDbCommand studentCmd = new OleDbCommand(studentQuery, conn))
                    {
                        studentCmd.Parameters.AddWithValue("@uname", username);
                        studentCmd.Parameters.AddWithValue("@pass", password);

                        object result = studentCmd.ExecuteScalar();

                        if (result != null)
                        {
                            string studentID = result.ToString();

                            MessageBox.Show($"Welcome, Student {username}!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            StudentForm studentDash = new StudentForm(studentID);

                            studentDash.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPass.Clear();
                            txtUname.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();

            regForm.FormClosed += (s, args) => this.Show();

            regForm.Show();
            this.Hide();
        }
    }
}
