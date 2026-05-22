using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentScholarTracker
{
    public partial class AdminForm : Form
    {
        bool sidebarExpand = true;
        public AdminForm()
        {
            InitializeComponent();
        }
        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.pnlContent.Controls.Add(childForm);
            this.pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Dispose();
        }


        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                // If the sidebar is expanding
                sidebarPanel.Width += 10;
                if (sidebarPanel.Width >= sidebarPanel.MaximumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();

                    // SHOW THE TEXT when fully expanded
                    BtnStudentInfo.Text = "Student Information";
                    BtnTeacherInfo.Text = "Teacher Information";
                    BtnCourseInfo.Text = "Course Information";
                    BtnAnalytics.Text = "Analytics";
                    BtnEnrollments.Text = "Enrollments";
                }
            }
            else
            {
                // If the sidebar is collapsing
                sidebarPanel.Width -= 10;
                if (sidebarPanel.Width <= sidebarPanel.MinimumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();

                    // HIDE THE TEXT when collapsed so only icons show
                    BtnStudentInfo.Text = "";
                    BtnTeacherInfo.Text = "";
                    BtnCourseInfo.Text = "";
                    BtnAnalytics.Text = "";
                    BtnEnrollments.Text = "";
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void BtnStudentInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentInfoForm());
        }

        private void BtnTeacherInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TeacherInfoForm());
        }

        private void BtnCourseInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CourseInfoForm());
        }

        private void BtnAnalytics_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AnalyticsForms());
        }

        private void BtnEnrollments_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EnrollmentInfoForm());
        }

       
    }
}
