using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using ClosedXML.Excel; 
using iTextSharp.text; 
using iTextSharp.text.pdf;

namespace StudentScholarTracker
{
    public partial class StudentInfoForm : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Justine\Downloads\SABALLE OOP2\StudentScholarTracker\StudentScholarTracker\ScholarDatabase.accdb;";
        public StudentInfoForm()
        {
            InitializeComponent();
            LoadStudentData();

        }

        private void LoadStudentData()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Students";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvStudents.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student data: " + ex.Message);
            }
        }
        private void ClearFields()
        {
            txtID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtDepartment.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtGender.Clear();
            dtpDOB.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DoesStudentExist(txtID.Text))
            {
                MessageBox.Show("Student ID " + txtID.Text + " already exists! Please use a unique ID or use 'Update' instead.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveStudentToDatabase(txtID.Text, txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtDepartment.Text, txtUsername.Text, txtPassword.Text, txtGender.Text, dtpDOB.Value.ToShortDateString());
            LoadStudentData();
            ClearFields();
        }
        private bool DoesStudentExist(string studentID)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM Students WHERE StudentID = @id";
                using (OleDbCommand cmd = new OleDbCommand(checkQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(studentID));
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    // Added Department to the UPDATE query
                    string query = "UPDATE Students SET FirstName=@fname, LastName=@lname, Email=@email, " +
                                   "Department=@dept, [Username]=@uname, [Password]=@pass, Gender=@gender, DateOfBirth=@dob " +
                                   "WHERE StudentID=@id";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@dept", txtDepartment.Text);
                        cmd.Parameters.AddWithValue("@uname", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@gender", txtGender.Text);
                        cmd.Parameters.AddWithValue("@dob", dtpDOB.Value.ToShortDateString());
                        cmd.Parameters.AddWithValue("@id", txtID.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Student Record Updated Successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadStudentData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please select a record from the list to delete.", "Select Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (OleDbConnection conn = new OleDbConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Students WHERE StudentID = @id";

                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", txtID.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Student record deleted successfully.");
                            LoadStudentData();
                            ClearFields();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting record: " + ex.Message);
                }
            }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

                txtID.Text = row.Cells["StudentID"].Value?.ToString() ?? "";
                txtFirstName.Text = row.Cells["FirstName"].Value?.ToString() ?? "";
                txtLastName.Text = row.Cells["LastName"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtDepartment.Text = row.Cells["Department"].Value?.ToString() ?? "";
                txtUsername.Text = row.Cells["Username"].Value?.ToString() ?? "";
                txtPassword.Text = row.Cells["Password"].Value?.ToString() ?? "";
                txtGender.Text = row.Cells["Gender"].Value?.ToString() ?? "";
                string dobString = row.Cells["DateOfBirth"].Value?.ToString() ?? "";
                if (DateTime.TryParse(dobString, out DateTime parsedDate))
                {
                    dtpDOB.Value = parsedDate;
                }
                else
                {
                    dtpDOB.Value = DateTime.Now;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Students WHERE StudentID LIKE @search OR FirstName LIKE @search OR LastName LIKE @search OR Email LIKE @search OR Department LIKE @search";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvStudents.DataSource = dt;
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            txtSearch.Clear();

            LoadStudentData();

            txtID.Focus();
            dgvStudents.ClearSelection();
        }

        private void StudentInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveStudentToDatabase(string id, string fname, string lname, string email, string dept, string dob, string gender, string uname, string pass)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Students (StudentID, FirstName, LastName, Email, Department, DateOfBirth, Gender, [Username], [Password]) " +
                                   "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", Convert.ToInt32(id));      // 1. StudentID
                        cmd.Parameters.AddWithValue("?", fname);                  // 2. FirstName
                        cmd.Parameters.AddWithValue("?", lname);                  // 3. LastName
                        cmd.Parameters.AddWithValue("?", email);                  // 4. Email
                        cmd.Parameters.AddWithValue("?", dept);                   // 5. Department
                        cmd.Parameters.AddWithValue("?", DateTime.Parse(dob));     // 6. DateOfBirth
                        cmd.Parameters.AddWithValue("?", gender);                 // 7. Gender
                        cmd.Parameters.AddWithValue("?", uname);                  // 8. Username
                        cmd.Parameters.AddWithValue("?", pass);                   // 9. Password

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving record (" + id + "): " + ex.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvStudents.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF (*.pdf)|*.pdf", FileName = "Student_List_Master.pdf" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4.Rotate(), 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));
                    pdfDoc.Open();

                    iTextSharp.text.Font titleFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD);
                    pdfDoc.Add(new Paragraph("OFFICIAL MASTER STUDENT LIST", titleFont));
                    pdfDoc.Add(new Paragraph("Generated on: " + DateTime.Now.ToString()) { SpacingAfter = 20 });

                    PdfPTable table = new PdfPTable(dgvStudents.Columns.Count);
                    table.WidthPercentage = 100;

                    foreach (DataGridViewColumn col in dgvStudents.Columns)
                    {
                        table.AddCell(new Phrase(col.HeaderText));
                    }

                    foreach (DataGridViewRow row in dgvStudents.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            table.AddCell(new Phrase(cell.Value?.ToString() ?? ""));
                        }
                    }

                    pdfDoc.Add(table);
                    pdfDoc.Close();
                    MessageBox.Show("PDF exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) { MessageBox.Show("Export Error: " + ex.Message); }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Excel Workbook|*.xlsx" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(ofd.FileName))
                    {
                        var worksheet = workbook.Worksheet(1);
                        var rows = worksheet.RangeUsed().RowsUsed().Skip(1);

                        int importedCount = 0;
                        int skippedCount = 0;

                        foreach (var row in rows)
                        {
                            string currentID = row.Cell(1).GetValue<string>();

                            if (DoesStudentExist(currentID))
                            {
                                skippedCount++;
                                continue;
                            }

                            string fName = row.Cell(2).GetValue<string>();
                            string lName = row.Cell(3).GetValue<string>();
                            string email = row.Cell(4).GetValue<string>();
                            string dept = row.Cell(5).GetValue<string>();
                            string dobString = row.Cell(6).GetValue<string>(); 
                            string gender = row.Cell(7).GetValue<string>();
                            string uname = row.Cell(8).GetValue<string>();
                            string pass = row.Cell(9).GetValue<string>(); 

                            SaveStudentToDatabase(currentID, fName, lName, email, dept, dobString, gender, uname, pass);
                            importedCount++;
                        }
                        MessageBox.Show($"Import Complete!\nImported: {importedCount}\nSkipped (Duplicates): {skippedCount}",
                                        "Import Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStudentData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Import Error: " + ex.Message);
                }
            }
        }


    }
}

