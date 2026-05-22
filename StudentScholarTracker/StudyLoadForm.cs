using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace StudentScholarTracker
{
    public partial class StudyLoadForm : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Justine\Downloads\SABALLE OOP2\StudentScholarTracker\StudentScholarTracker\ScholarDatabase.accdb;";
        private string currentStudentID;
        public StudyLoadForm(string studentID)
        {
            InitializeComponent();
            this.currentStudentID = studentID;

            ApplyStudyLoadStyle();

            LoadStudyLoad();
        }


        private void ApplyStudyLoadStyle()
        {
            this.BackColor = Color.OldLace;

            dgvStudyLoad.BackgroundColor = Color.OldLace;
            dgvStudyLoad.BorderStyle = BorderStyle.None;
            dgvStudyLoad.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvStudyLoad.EnableHeadersVisualStyles = false;
            dgvStudyLoad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudyLoad.RowHeadersVisible = false;
            dgvStudyLoad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvStudyLoad.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(217, 237, 247);
            dgvStudyLoad.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(49, 112, 143);
            dgvStudyLoad.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);
            dgvStudyLoad.ColumnHeadersHeight = 40;

            dgvStudyLoad.DefaultCellStyle.BackColor = Color.White;
            dgvStudyLoad.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            dgvStudyLoad.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 245, 245);
            dgvStudyLoad.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvStudyLoad.RowTemplate.Height = 35;

            dgvStudyLoad.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
        }
        private void LoadStudyLoad()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT Course.CourseID, Course.CourseCode, Course.Title, Course.Section, Course.Day, Course.ScheduleTime, Course.Units 
                             FROM Course 
                             INNER JOIN Enrollments ON Course.CourseID = Enrollments.CourseID 
                             WHERE Enrollments.StudentID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", currentStudentID);

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dgvStudyLoad.DataSource = dt;

                            if (dgvStudyLoad.Columns.Contains("CourseID"))
                                dgvStudyLoad.Columns["CourseID"].Visible = false;

                            CalculateTotalUnits(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error: " + ex.Message, "ScholarTracker", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CalculateTotalUnits(DataTable dt)
        {
            int totalUnits = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (row["Units"] != DBNull.Value)
                {
                    totalUnits += Convert.ToInt32(row["Units"]);
                }
            }
            lblTotalUnits.Text = "Total Units: " + totalUnits.ToString();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (dgvStudyLoad.Rows.Count > 0)
            {
                // Open a dialog to ask the user where to save the PDF
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "StudyLoad_" + currentStudentID + ".pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        PdfPTable pdfTable = new PdfPTable(dgvStudyLoad.Columns.Count);
                        pdfTable.DefaultCell.Padding = 5;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                        foreach (DataGridViewColumn column in dgvStudyLoad.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            cell.BackgroundColor = new iTextSharp.text.BaseColor(217, 237, 247);
                            pdfTable.AddCell(cell);
                        }

                        foreach (DataGridViewRow row in dgvStudyLoad.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.Value != null)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                                else
                                {
                                    pdfTable.AddCell("");
                                }
                            }
                        }

                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            // A4 Paper Size with margins
                            Document pdfDoc = new Document(PageSize.A4, 20f, 20f, 30f, 30f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();

                            iTextSharp.text.Font titleFont = FontFactory.GetFont("Arial", 18, iTextSharp.text.Font.BOLD);
                            Paragraph title = new Paragraph("OFFICIAL STUDY LOAD\n\n", titleFont);
                            title.Alignment = Element.ALIGN_CENTER;
                            pdfDoc.Add(title);

                            Paragraph studentInfo = new Paragraph("Student ID: " + currentStudentID + "\n\n");
                            pdfDoc.Add(studentInfo);

                            pdfDoc.Add(pdfTable);

                            Paragraph totalUnits = new Paragraph("\n" + lblTotalUnits.Text);
                            totalUnits.Alignment = Element.ALIGN_RIGHT;
                            pdfDoc.Add(totalUnits);

                            pdfDoc.Close();
                            stream.Close();
                        }

                        MessageBox.Show("Study Load exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error generating PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no study load data to export.", "Empty Schedule", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveSchedule_Click(object sender, EventArgs e)
        {
            if (dgvStudyLoad.CurrentRow == null)
            {
                MessageBox.Show("Please select a course to remove.", "ScholarTracker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string courseID = dgvStudyLoad.CurrentRow.Cells["CourseID"].Value.ToString();
            string courseCode = dgvStudyLoad.CurrentRow.Cells["CourseCode"].Value.ToString();

            DialogResult confirm = MessageBox.Show($"Are you sure you want to remove {courseCode} from your schedule?",
                "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (OleDbConnection conn = new OleDbConnection(connectionString))
                    {
                        conn.Open();

                        string deleteQuery = "DELETE FROM Enrollments WHERE StudentID = ? AND CourseID = ?";

                        using (OleDbCommand cmd = new OleDbCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("?", currentStudentID);
                            cmd.Parameters.AddWithValue("?", courseID);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Course removed successfully.", "ScholarTracker", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadStudyLoad();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error removing course: " + ex.Message, "ScholarTracker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
