using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentScholarTracker
{
    public partial class TeacherForm : Form
    {
        bool sidebarExpand;
        private string currentTeacherID;
        private Form activeForm = null;
        public TeacherForm(string teacherID)
        {
            InitializeComponent();
            this.currentTeacherID = teacherID;
        }

       

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
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

                    btnClassList.Text = "Class List";
                    btnGradeEncode.Text = "Grade Encode";
                }
            }
            else
            {

                btnClassList.Text = "";
                btnGradeEncode.Text = "";

                sidebarPanel.Width -= 10;
                if (sidebarPanel.Width <= sidebarPanel.MinimumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btnClassList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TeacherClassList(currentTeacherID));
        }

        private void btnGradeEncode_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TeacherGradesEncodeForm(currentTeacherID));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Dispose();
        }
    }
}
