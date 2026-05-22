using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace StudentScholarTracker
{
    public partial class TeacherClassList : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Justine\Downloads\SABALLE OOP2\StudentScholarTracker\StudentScholarTracker\ScholarDatabase.accdb;";
        private string tid;
        public TeacherClassList(string teacherID)
        {
            InitializeComponent();
            this.tid = teacherID;
            LoadClassList();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadClassList()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    // Added Section, ScheduleTime, and Day to the SELECT statement
                    string query = "SELECT c.CourseCode, c.Title, c.Section, c.ScheduleTime, c.Day, s.FirstName, s.LastName " +
                                   "FROM (Course AS c " +
                                   "INNER JOIN Enrollments AS e ON c.CourseID = e.CourseID) " +
                                   "INNER JOIN Students AS s ON e.StudentID = s.StudentID " +
                                   "WHERE c.TeacherID = ? " +
                                   "ORDER BY c.CourseCode, c.Section, s.LastName";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", tid);

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dgvClassList.DataSource = dt;

                            if (dgvClassList.Columns.Contains("CourseCode")) dgvClassList.Columns["CourseCode"].HeaderText = "Code";
                            if (dgvClassList.Columns.Contains("ScheduleTime")) dgvClassList.Columns["ScheduleTime"].HeaderText = "Time";
                            if (dgvClassList.Columns.Contains("FirstName")) dgvClassList.Columns["FirstName"].HeaderText = "First Name";
                            if (dgvClassList.Columns.Contains("LastName")) dgvClassList.Columns["LastName"].HeaderText = "Last Name";
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT CourseCode, Title, Section, ScheduleTime, Day, FirstName, LastName " +
                                   "FROM (Course INNER JOIN Enrollments ON Course.CourseID = Enrollments.CourseID) " +
                                   "INNER JOIN Students ON Enrollments.StudentID = Students.StudentID " +
                                   "WHERE TeacherID = ? AND (FirstName LIKE ? OR LastName LIKE ? OR CourseCode LIKE ? OR Section LIKE ?)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        string searchVal = "%" + txtSearch.Text.Trim() + "%";

                        cmd.Parameters.AddWithValue("?", tid);
                        cmd.Parameters.AddWithValue("?", searchVal);
                        cmd.Parameters.AddWithValue("?", searchVal);
                        cmd.Parameters.AddWithValue("?", searchVal);
                        cmd.Parameters.AddWithValue("?", searchVal);

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvClassList.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Search Error: " + ex.Message);
            }
        }

       
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvClassList.Rows.Count == 0)
            {
                MessageBox.Show("No data available to export.", "ScholarTracker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Official_Class_List_" + DateTime.Now.ToString("yyyyMMdd") + ".pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 10f, 10f, 20f, 20f);
                    PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));

                    pdfDoc.Open();

                    BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 18, iTextSharp.text.Font.BOLD);

                    Paragraph title = new Paragraph("OFFICIAL CLASS LIST\n\n", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(title);

                    // Create the Table
                    PdfPTable pdfTable = new PdfPTable(dgvClassList.Columns.Count);
                    pdfTable.WidthPercentage = 100;

                    // Headers
                    foreach (DataGridViewColumn column in dgvClassList.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        cell.BackgroundColor = new BaseColor(240, 240, 240);
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable.AddCell(cell);
                    }

                    // Data Rows
                    foreach (DataGridViewRow row in dgvClassList.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value?.ToString() ?? "");
                        }
                    }

                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();

                    MessageBox.Show("Class List exported successfully to PDF!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
