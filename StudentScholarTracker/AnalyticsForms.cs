using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.VisualElements;
using LiveChartsCore.SkiaSharpView.WinForms;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;


namespace StudentScholarTracker
{

    public partial class AnalyticsForms : Form
    {
        private readonly string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ScholarDatabase.accdb";
        private List<string> teacherNames = new List<string>();

        private PieChart? pcScholar;
        private PieChart? pcGender;
        private CartesianChart? ctTeacherWorkload;


        public AnalyticsForms()
        {
            InitializeComponent();
            this.Load += AnalyticsForms_Load;
        }

        public AdminForm AdminForm
        {
            get => default;
            set
            {
            }
        }

        private void AnalyticsForms_Load(object sender, EventArgs e)
        {
            SetupMyChart();
        }

        private void SetupMyChart()
        {
            this.Controls.Clear();

            pcScholar = new PieChart
            {
                Location = new Point(10, 10),
                Size = new Size(420, 220),
                Title = new LabelVisual { Text = "Enrollment by Course", TextSize = 14 },
                LegendPosition = LiveChartsCore.Measure.LegendPosition.Right,
                Series = GetCourseSeriesFromDatabase()
            };

            pcGender = new PieChart
            {
                Location = new Point(440, 10),
                Size = new Size(420, 220),
                Title = new LabelVisual { Text = "Gender Distribution", TextSize = 14 },
                LegendPosition = LiveChartsCore.Measure.LegendPosition.Right,
                Series = GetGenderSeriesFromDatabase()
            };

            ctTeacherWorkload = new CartesianChart
            {
                Location = new Point(10, 230),
                Size = new Size(770, 300), 
                Title = new LabelVisual { Text = "Teacher Workload", TextSize = 14 },
                Series = GetTeacherWorkloadSeries()
            };
           
            this.Controls.Add(pcScholar);
            this.Controls.Add(pcGender);
            this.Controls.Add(ctTeacherWorkload);
        }
       
        private List<ISeries> GetCourseSeriesFromDatabase()
        {
            var seriesList = new List<ISeries>();
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT [Title], [CountOfEnrollmentID] FROM [qryEnrollmentCounts]";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            seriesList.Add(new PieSeries<double>
                            {
                                Values = new double[] { Convert.ToDouble(reader["CountOfEnrollmentID"]) },
                                Name = reader["Title"]?.ToString() ?? "Unknown"
                            });
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Course Error: " + ex.Message); }
            }
            return seriesList;
        }
        private List<ISeries> GetGenderSeriesFromDatabase()
        {
            var seriesList = new List<ISeries>();
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    // Groups data from your 'Students' table
                    string query = "SELECT [Gender], COUNT([StudentID]) as GCount FROM [Students] GROUP BY [Gender]";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            seriesList.Add(new PieSeries<double>
                            {
                                Values = new double[] { Convert.ToDouble(reader["GCount"]) },
                                Name = reader["Gender"]?.ToString() ?? "Unknown"
                            });
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Gender Error: " + ex.Message); }
            }
            return seriesList;
        }
        private List<ISeries> GetTeacherWorkloadSeries()
        {
            var seriesList = new List<ISeries>();
            var counts = new List<double>();

            teacherNames.Clear();

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT [FirstName], [LastName], [CountOfCourseID] FROM [qryTeacherWorkload]";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                            teacherNames.Add(name);
                            counts.Add(Convert.ToDouble(reader["CountOfCourseID"]));
                        }
                    }

                    seriesList.Add(new ColumnSeries<double>
                    {
                        Values = counts,
                        Name = "Courses",
                        YToolTipLabelFormatter = (point) => $"{teacherNames[(int)point.Index]}: {point.Coordinate.PrimaryValue} Courses",
                        DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Top,
                        DataLabelsSize = 12,
                        DataLabelsPaint = new SolidColorPaint(SKColors.Black)
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Workload Error: " + ex.Message);
                }
            }
            return seriesList;
        }

    }
    
}
