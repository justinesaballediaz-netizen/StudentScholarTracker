using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;

namespace StudentScholarTracker
{
    public partial class TeacherInfoForm : Form
    {
        private readonly string connectionString =
                   @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Justine\Downloads\SABALLE OOP2\StudentScholarTracker\StudentScholarTracker\ScholarDatabase.accdb;";


        public TeacherInfoForm()
        {
            InitializeComponent();
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
        }
        private void TeacherInfoForm_Load(object sender, EventArgs e)
        {
            LoadTeachers();
        }
        private DataTable teachersTable;
        private void LoadTeachers()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    string query = "SELECT TeacherID, FirstName, LastName, Department, Email, Username, [Password] FROM Teachers";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading teacher data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtTeacherID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtDepartment.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtSearch.Clear();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTeacherID.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Teacher ID, First Name, and Last Name are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Teachers 
                                    (TeacherID, FirstName, LastName, Department, Email, Username, [Password]) 
                                    VALUES (@tid, @fname, @lname, @dept, @email, @uname, @pass)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tid", txtTeacherID.Text.Trim());
                        cmd.Parameters.AddWithValue("@fname", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@lname", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@dept", txtDepartment.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@uname", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Teacher record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTeachers();
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTeacherID.Text))
            {
                MessageBox.Show("Please select a teacher to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Teachers SET 
                                    FirstName = @fname, 
                                    LastName = @lname, 
                                    Department = @dept, 
                                    Email = @email, 
                                    Username = @uname, 
                                    [Password] = @pass
                                    WHERE TeacherID = @tid";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fname", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@lname", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@dept", txtDepartment.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@uname", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@tid", txtTeacherID.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Teacher record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadTeachers();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("No record found with that Teacher ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
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
            if (string.IsNullOrWhiteSpace(txtTeacherID.Text))
            {
                MessageBox.Show("Please select a teacher to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this teacher?",
                                                  "Confirm Delete",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (OleDbConnection conn = new OleDbConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Teachers WHERE TeacherID = @tid";

                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@tid", txtTeacherID.Text.Trim());
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Teacher record deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadTeachers();
                                ClearFields();
                            }
                            else
                            {
                                MessageBox.Show("No record found with that Teacher ID.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadTeachers();
            txtTeacherID.Focus();
            dataGridView1.ClearSelection();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtTeacherID.Text = row.Cells["TeacherID"].Value?.ToString() ?? "";
                txtFirstName.Text = row.Cells["FirstName"].Value?.ToString() ?? "";
                txtLastName.Text = row.Cells["LastName"].Value?.ToString() ?? "";
                txtDepartment.Text = row.Cells["Department"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtUsername.Text = row.Cells["Username"].Value?.ToString() ?? "";
                txtPassword.Text = row.Cells["Password"].Value?.ToString() ?? "";
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT TeacherID, FirstName, LastName, Department, Email, Username, [Password] 
                             FROM Teachers 
                             WHERE TeacherID LIKE @search 
                                OR FirstName LIKE @search 
                                OR LastName LIKE @search 
                                OR Department LIKE @search 
                                OR Email LIKE @search
                             ORDER BY TeacherID";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF (*.pdf)|*.pdf", FileName = "Teacher_List_Master.pdf" };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4.Rotate(), 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));
                    pdfDoc.Open();

                    iTextSharp.text.Font titleFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font headFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD);

                    pdfDoc.Add(new Paragraph("OFFICIAL MASTER TEACHER LIST", titleFont));
                    pdfDoc.Add(new Paragraph("Generated on: " + DateTime.Now.ToString()) { SpacingAfter = 20 });

                    PdfPTable table = new PdfPTable(7);
                    table.WidthPercentage = 100;

                    string[] headers = { "Teacher ID", "First Name", "Last Name", "Department", "Email", "Username", "Password" };
                    foreach (string header in headers)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(header, headFont));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        table.AddCell(cell);
                    }

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            table.AddCell(row.Cells["TeacherID"].Value?.ToString() ?? "");
                            table.AddCell(row.Cells["FirstName"].Value?.ToString() ?? "");
                            table.AddCell(row.Cells["LastName"].Value?.ToString() ?? "");
                            table.AddCell(row.Cells["Department"].Value?.ToString() ?? "");
                            table.AddCell(row.Cells["Email"].Value?.ToString() ?? "");
                            table.AddCell(row.Cells["Username"].Value?.ToString() ?? "");
                            table.AddCell(row.Cells["Password"].Value?.ToString() ?? "");
                        }
                    }

                    pdfDoc.Add(table);
                    pdfDoc.Close();
                    MessageBox.Show("Teacher list exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Export Error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

                        int imported = 0;
                        int skipped = 0;

                        foreach (var row in rows)
                        {
                            string tid = row.Cell(1).GetValue<string>();

                            if (DoesTeacherExist(tid))
                            {
                                skipped++;
                                continue;
                            }

                            SaveTeacherToDatabase(
                                tid,
                                row.Cell(2).GetValue<string>(),
                                row.Cell(3).GetValue<string>(),
                                row.Cell(4).GetValue<string>(),
                                row.Cell(5).GetValue<string>(),
                                row.Cell(6).GetValue<string>(),
                                row.Cell(7).GetValue<string>()
                            );
                            imported++;
                        }

                        MessageBox.Show($"Import Finished!\nAdded: {imported}\nDuplicates Skipped: {skipped}", "Import Status");
                        LoadTeachers();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Import Error: " + ex.Message); }
            }
        }

        private bool DoesTeacherExist(string teacherID)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Teachers WHERE TeacherID = @id";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(teacherID));
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        private void SaveTeacherToDatabase(string tid, string fname, string lname, string dept, string email, string uname, string pass)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Teachers (TeacherID, FirstName, LastName, Department, Email, Username, [Password]) VALUES (?, ?, ?, ?, ?, ?, ?)";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", Convert.ToInt32(tid));
                    cmd.Parameters.AddWithValue("?", fname);
                    cmd.Parameters.AddWithValue("?", lname);
                    cmd.Parameters.AddWithValue("?", dept);
                    cmd.Parameters.AddWithValue("?", email);
                    cmd.Parameters.AddWithValue("?", uname);
                    cmd.Parameters.AddWithValue("?", pass);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
