using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentScholarTracker
{
    public partial class StudentForm : Form
    {
        private Form activeForm = null;

        private string studentID;
        bool sidebarExpand = true;

        public StudentForm(string id)
        {
            InitializeComponent();
            this.studentID = id;
        }
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

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarPanel.Width += 10;
                if (sidebarPanel.Width >= sidebarPanel.MaximumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();

                    BtnGrades.Text = "   Grades";
                    BtnStudyLoad.Text = "   Study Load";
                    BtnStudentInfo.Text = "   Student Information";
                }
            }
            else
            {
                sidebarPanel.Width -= 10;
                if (sidebarPanel.Width <= sidebarPanel.MinimumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();

                    BtnGrades.Text = "";
                    BtnStudyLoad.Text = "";
                    BtnStudentInfo.Text = "";
                }
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Dispose();
        }

        private void BtnGrades_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentGradesForm(this.studentID));
        }

        private void BtnStudyLoad_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudyLoadForm(this.studentID));
        }

        private void BtnStudentInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InfoStudentForm(this.studentID));
        }

        private void btnEnrollCourses_Click(object sender, EventArgs e)
        {

            OpenChildForm(new EnrollCoursesForm(this.studentID));
        }
    }
}
