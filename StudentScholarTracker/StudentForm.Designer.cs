namespace StudentScholarTracker
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            sidebarPanel = new Panel();
            BtnStudentInfo = new FontAwesome.Sharp.IconButton();
            BtnStudyLoad = new FontAwesome.Sharp.IconButton();
            BtnGrades = new FontAwesome.Sharp.IconButton();
            BtnExit = new Button();
            pictureBox1 = new PictureBox();
            pnlContent = new Panel();
            panel4 = new Panel();
            btnMenu = new Button();
            label1 = new Label();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            btnEnrollCourses = new FontAwesome.Sharp.IconButton();
            sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.BlanchedAlmond;
            sidebarPanel.Controls.Add(btnEnrollCourses);
            sidebarPanel.Controls.Add(BtnStudentInfo);
            sidebarPanel.Controls.Add(BtnStudyLoad);
            sidebarPanel.Controls.Add(BtnGrades);
            sidebarPanel.Controls.Add(BtnExit);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 94);
            sidebarPanel.MaximumSize = new Size(150, 0);
            sidebarPanel.MinimumSize = new Size(55, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(150, 475);
            sidebarPanel.TabIndex = 1;
            // 
            // BtnStudentInfo
            // 
            BtnStudentInfo.Dock = DockStyle.Top;
            BtnStudentInfo.FlatStyle = FlatStyle.Flat;
            BtnStudentInfo.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnStudentInfo.IconChar = FontAwesome.Sharp.IconChar.User;
            BtnStudentInfo.IconColor = Color.Gold;
            BtnStudentInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnStudentInfo.IconSize = 37;
            BtnStudentInfo.ImageAlign = ContentAlignment.MiddleLeft;
            BtnStudentInfo.Location = new Point(0, 122);
            BtnStudentInfo.Name = "BtnStudentInfo";
            BtnStudentInfo.Padding = new Padding(7, 0, 0, 0);
            BtnStudentInfo.Size = new Size(150, 61);
            BtnStudentInfo.TabIndex = 7;
            BtnStudentInfo.Text = "Student Information";
            BtnStudentInfo.TextAlign = ContentAlignment.MiddleLeft;
            BtnStudentInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnStudentInfo.UseVisualStyleBackColor = true;
            BtnStudentInfo.Click += BtnStudentInfo_Click;
            // 
            // BtnStudyLoad
            // 
            BtnStudyLoad.Dock = DockStyle.Top;
            BtnStudyLoad.FlatStyle = FlatStyle.Flat;
            BtnStudyLoad.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold);
            BtnStudyLoad.IconChar = FontAwesome.Sharp.IconChar.BookAtlas;
            BtnStudyLoad.IconColor = Color.Gold;
            BtnStudyLoad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnStudyLoad.IconSize = 37;
            BtnStudyLoad.ImageAlign = ContentAlignment.MiddleLeft;
            BtnStudyLoad.Location = new Point(0, 61);
            BtnStudyLoad.Name = "BtnStudyLoad";
            BtnStudyLoad.Padding = new Padding(7, 0, 0, 0);
            BtnStudyLoad.Size = new Size(150, 61);
            BtnStudyLoad.TabIndex = 6;
            BtnStudyLoad.Text = "StudyLoad";
            BtnStudyLoad.TextAlign = ContentAlignment.MiddleLeft;
            BtnStudyLoad.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnStudyLoad.UseVisualStyleBackColor = true;
            BtnStudyLoad.Click += BtnStudyLoad_Click;
            // 
            // BtnGrades
            // 
            BtnGrades.Dock = DockStyle.Top;
            BtnGrades.FlatStyle = FlatStyle.Flat;
            BtnGrades.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold);
            BtnGrades.IconChar = FontAwesome.Sharp.IconChar.Stamp;
            BtnGrades.IconColor = Color.Gold;
            BtnGrades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGrades.IconSize = 37;
            BtnGrades.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGrades.Location = new Point(0, 0);
            BtnGrades.Name = "BtnGrades";
            BtnGrades.Padding = new Padding(7, 0, 0, 0);
            BtnGrades.Size = new Size(150, 61);
            BtnGrades.TabIndex = 5;
            BtnGrades.Text = "Grades";
            BtnGrades.TextAlign = ContentAlignment.MiddleLeft;
            BtnGrades.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnGrades.UseVisualStyleBackColor = true;
            BtnGrades.Click += BtnGrades_Click;
            // 
            // BtnExit
            // 
            BtnExit.Dock = DockStyle.Bottom;
            BtnExit.FlatStyle = FlatStyle.Flat;
            BtnExit.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExit.Location = new Point(0, 436);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(150, 39);
            BtnExit.TabIndex = 4;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(197, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.OldLace;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(150, 94);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1039, 475);
            pnlContent.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.BlanchedAlmond;
            panel4.Controls.Add(btnMenu);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1189, 94);
            panel4.TabIndex = 3;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.PeachPuff;
            btnMenu.FlatStyle = FlatStyle.Popup;
            btnMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.Location = new Point(29, 35);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(98, 41);
            btnMenu.TabIndex = 5;
            btnMenu.Text = "☰";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(303, 21);
            label1.Name = "label1";
            label1.Size = new Size(666, 56);
            label1.TabIndex = 0;
            label1.Text = "STUDENT INFORMATION HUB";
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // btnEnrollCourses
            // 
            btnEnrollCourses.Dock = DockStyle.Top;
            btnEnrollCourses.FlatStyle = FlatStyle.Flat;
            btnEnrollCourses.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnrollCourses.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnEnrollCourses.IconColor = Color.Gold;
            btnEnrollCourses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEnrollCourses.IconSize = 37;
            btnEnrollCourses.ImageAlign = ContentAlignment.MiddleLeft;
            btnEnrollCourses.Location = new Point(0, 183);
            btnEnrollCourses.Name = "btnEnrollCourses";
            btnEnrollCourses.Padding = new Padding(7, 0, 0, 0);
            btnEnrollCourses.Size = new Size(150, 61);
            btnEnrollCourses.TabIndex = 8;
            btnEnrollCourses.Text = "Enroll Courses";
            btnEnrollCourses.TextAlign = ContentAlignment.MiddleLeft;
            btnEnrollCourses.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEnrollCourses.UseVisualStyleBackColor = true;
            btnEnrollCourses.Click += btnEnrollCourses_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 569);
            Controls.Add(pnlContent);
            Controls.Add(sidebarPanel);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebarPanel;
        private Button BtnExit;
        private PictureBox pictureBox1;
        private Panel pnlContent;
        private Panel panel4;
        private Label label1;
        private Button btnMenu;
        private FontAwesome.Sharp.IconButton BtnGrades;
        private FontAwesome.Sharp.IconButton BtnStudyLoad;
        private FontAwesome.Sharp.IconButton BtnStudentInfo;
        private System.Windows.Forms.Timer sidebarTimer;
        private FontAwesome.Sharp.IconButton btnEnrollCourses;
    }
}