using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace StudentScholarTracker
{
    public partial class TeacherGradesEncodeForm : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Justine\Downloads\SABALLE OOP2\StudentScholarTracker\StudentScholarTracker\ScholarDatabase.accdb;";
        private string tid;
        private int selectedEnrollmentID = 0;
        public TeacherGradesEncodeForm(string teacherID)
        {
            InitializeComponent();
            this.tid = teacherID;
        }



        private void TeacherGradesEncodeForm_Load(object sender, EventArgs e)
        {
            LoadStudentsForGrading();
        }
        private void LoadStudentsForGrading()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT e.EnrollmentID, s.StudentID, s.FirstName, s.LastName, c.CourseCode, e.[Midterm Grades], e.[Finals Grades] " +
                                   "FROM (Course AS c INNER JOIN Enrollments AS e ON c.CourseID = e.CourseID) " +
                                   "INNER JOIN Students AS s ON e.StudentID = s.StudentID " +
                                   "WHERE c.TeacherID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", tid);

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvStudents.DataSource = dt;

                        if (dgvStudents.Columns["EnrollmentID"] != null)
                        {
                            dgvStudents.Columns["EnrollmentID"].Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedEnrollmentID == 0)
            {
                MessageBox.Show("Please select a student from the list first.", "Select Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtMidterm.Text, out double midterm) || midterm < 1 || midterm > 5 ||
                !double.TryParse(txtFinals.Text, out double finals) || finals < 1 || finals > 5)
            {
                MessageBox.Show("Please enter valid grades between 1.0 and 5.0.", "Invalid Grade Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    string query = "UPDATE Enrollments SET [Midterm Grades] = ?, [Finals Grades] = ? WHERE EnrollmentID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", midterm);
                        cmd.Parameters.AddWithValue("?", finals);
                        cmd.Parameters.AddWithValue("?", selectedEnrollmentID);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Grades encoded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtMidterm.Clear();
                        txtFinals.Clear();
                        txtStudentID.Clear();
                        txtFirstName.Clear();
                        txtLastName.Clear();
                        txtCourse.Clear();
                        selectedEnrollmentID = 0;

                        LoadStudentsForGrading();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCourse.Clear();
            txtMidterm.Clear();
            txtFinals.Clear();
            txtSearch.Clear();
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

                if (row.Cells["EnrollmentID"].Value != DBNull.Value)
                {
                    selectedEnrollmentID = Convert.ToInt32(row.Cells["EnrollmentID"].Value);
                }

                txtStudentID.Text = row.Cells["StudentID"].Value?.ToString();
                txtFirstName.Text = row.Cells["FirstName"].Value?.ToString();
                txtLastName.Text = row.Cells["LastName"].Value?.ToString();
                txtCourse.Text = row.Cells["CourseCode"].Value?.ToString();
                txtMidterm.Text = row.Cells["Midterm Grades"].Value?.ToString();
                txtFinals.Text = row.Cells["Finals Grades"].Value?.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dgvStudents.DataSource is DataTable dt)
            {
                dt.DefaultView.RowFilter = string.Format("FirstName LIKE '%{0}%' OR LastName LIKE '%{0}%'", txtSearch.Text.Trim().Replace("'", "''"));
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvStudents.Rows.Count == 0)
            {
                MessageBox.Show("No student data available to export.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF (*.pdf)|*.pdf", FileName = "Class_Grades_Report.pdf" };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));
                    pdfDoc.Open();

                    iTextSharp.text.Font titleFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font headFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD);

                    pdfDoc.Add(new Paragraph("OFFICIAL CLASS GRADES REPORT", titleFont));
                    pdfDoc.Add(new Paragraph("Teacher ID: " + this.tid));
                    pdfDoc.Add(new Paragraph("Generated on: " + DateTime.Now.ToString()) { SpacingAfter = 20 });

                    PdfPTable table = new PdfPTable(6);
                    table.WidthPercentage = 100;

                    string[] headers = { "Student ID", "First Name", "Last Name", "Course Code", "Midterm", "Finals" };
                    foreach (string header in headers)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(header, headFont));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        table.AddCell(cell);
                    }

                    foreach (DataGridViewRow row in dgvStudents.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            table.AddCell(row.Cells["StudentID"].Value?.ToString() ?? "");
                            table.AddCell(row.Cells["FirstName"].Value?.ToString() ?? "");
                            table.AddCell(row.Cells["LastName"].Value?.ToString() ?? "");
                            table.AddCell(row.Cells["CourseCode"].Value?.ToString() ?? "");
                            table.AddCell(row.Cells["Midterm Grades"].Value?.ToString() ?? "N/A");
                            table.AddCell(row.Cells["Finals Grades"].Value?.ToString() ?? "N/A");
                        }
                    }

                    pdfDoc.Add(table);
                    pdfDoc.Close();
                    MessageBox.Show("Grades report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Export Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
