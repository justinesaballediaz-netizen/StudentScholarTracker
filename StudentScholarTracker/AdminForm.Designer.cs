namespace StudentScholarTracker
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            sidebarPanel = new Panel();
            BtnEnrollments = new FontAwesome.Sharp.IconButton();
            BtnAnalytics = new FontAwesome.Sharp.IconButton();
            BtnCourseInfo = new FontAwesome.Sharp.IconButton();
            BtnTeacherInfo = new FontAwesome.Sharp.IconButton();
            BtnStudentInfo = new FontAwesome.Sharp.IconButton();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            pnlContent = new Panel();
            panel4 = new Panel();
            btnMenu = new Button();
            label1 = new Label();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.BlanchedAlmond;
            sidebarPanel.Controls.Add(BtnEnrollments);
            sidebarPanel.Controls.Add(BtnAnalytics);
            sidebarPanel.Controls.Add(BtnCourseInfo);
            sidebarPanel.Controls.Add(BtnTeacherInfo);
            sidebarPanel.Controls.Add(BtnStudentInfo);
            sidebarPanel.Controls.Add(button4);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 97);
            sidebarPanel.MaximumSize = new Size(150, 0);
            sidebarPanel.MinimumSize = new Size(55, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(150, 514);
            sidebarPanel.TabIndex = 0;
            // 
            // BtnEnrollments
            // 
            BtnEnrollments.Dock = DockStyle.Top;
            BtnEnrollments.FlatStyle = FlatStyle.Flat;
            BtnEnrollments.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEnrollments.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            BtnEnrollments.IconColor = Color.Gold;
            BtnEnrollments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEnrollments.IconSize = 37;
            BtnEnrollments.Location = new Point(0, 244);
            BtnEnrollments.Name = "BtnEnrollments";
            BtnEnrollments.Padding = new Padding(7, 0, 0, 0);
            BtnEnrollments.Size = new Size(150, 61);
            BtnEnrollments.TabIndex = 9;
            BtnEnrollments.Text = "Enrollment View";
            BtnEnrollments.TextAlign = ContentAlignment.MiddleLeft;
            BtnEnrollments.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnEnrollments.UseVisualStyleBackColor = true;
            BtnEnrollments.Click += BtnEnrollments_Click;
            // 
            // BtnAnalytics
            // 
            BtnAnalytics.Dock = DockStyle.Top;
            BtnAnalytics.FlatStyle = FlatStyle.Flat;
            BtnAnalytics.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAnalytics.IconChar = FontAwesome.Sharp.IconChar.Globe;
            BtnAnalytics.IconColor = Color.Gold;
            BtnAnalytics.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAnalytics.IconSize = 37;
            BtnAnalytics.Location = new Point(0, 183);
            BtnAnalytics.Name = "BtnAnalytics";
            BtnAnalytics.Padding = new Padding(6, 0, 0, 0);
            BtnAnalytics.Size = new Size(150, 61);
            BtnAnalytics.TabIndex = 8;
            BtnAnalytics.Text = "Analytics View";
            BtnAnalytics.TextAlign = ContentAlignment.MiddleLeft;
            BtnAnalytics.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnAnalytics.UseVisualStyleBackColor = true;
            BtnAnalytics.Click += BtnAnalytics_Click;
            // 
            // BtnCourseInfo
            // 
            BtnCourseInfo.Dock = DockStyle.Top;
            BtnCourseInfo.FlatStyle = FlatStyle.Flat;
            BtnCourseInfo.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCourseInfo.IconChar = FontAwesome.Sharp.IconChar.Book;
            BtnCourseInfo.IconColor = Color.Gold;
            BtnCourseInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCourseInfo.IconSize = 37;
            BtnCourseInfo.Location = new Point(0, 122);
            BtnCourseInfo.Name = "BtnCourseInfo";
            BtnCourseInfo.Padding = new Padding(6, 0, 0, 0);
            BtnCourseInfo.Size = new Size(150, 61);
            BtnCourseInfo.TabIndex = 7;
            BtnCourseInfo.Text = "Course Information";
            BtnCourseInfo.TextAlign = ContentAlignment.MiddleLeft;
            BtnCourseInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCourseInfo.UseVisualStyleBackColor = true;
            BtnCourseInfo.Click += BtnCourseInfo_Click;
            // 
            // BtnTeacherInfo
            // 
            BtnTeacherInfo.Dock = DockStyle.Top;
            BtnTeacherInfo.FlatStyle = FlatStyle.Flat;
            BtnTeacherInfo.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnTeacherInfo.IconChar = FontAwesome.Sharp.IconChar.ChessQueen;
            BtnTeacherInfo.IconColor = Color.Gold;
            BtnTeacherInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnTeacherInfo.IconSize = 37;
            BtnTeacherInfo.Location = new Point(0, 61);
            BtnTeacherInfo.Name = "BtnTeacherInfo";
            BtnTeacherInfo.Padding = new Padding(6, 0, 0, 0);
            BtnTeacherInfo.Size = new Size(150, 61);
            BtnTeacherInfo.TabIndex = 6;
            BtnTeacherInfo.Text = "Teacher Information";
            BtnTeacherInfo.TextAlign = ContentAlignment.MiddleLeft;
            BtnTeacherInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnTeacherInfo.UseVisualStyleBackColor = true;
            BtnTeacherInfo.Click += BtnTeacherInfo_Click;
            // 
            // BtnStudentInfo
            // 
            BtnStudentInfo.Dock = DockStyle.Top;
            BtnStudentInfo.FlatStyle = FlatStyle.Flat;
            BtnStudentInfo.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnStudentInfo.IconChar = FontAwesome.Sharp.IconChar.Users;
            BtnStudentInfo.IconColor = Color.Gold;
            BtnStudentInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnStudentInfo.IconSize = 37;
            BtnStudentInfo.Location = new Point(0, 0);
            BtnStudentInfo.Name = "BtnStudentInfo";
            BtnStudentInfo.Padding = new Padding(6, 0, 0, 0);
            BtnStudentInfo.Size = new Size(150, 61);
            BtnStudentInfo.TabIndex = 0;
            BtnStudentInfo.Text = "Student Information";
            BtnStudentInfo.TextAlign = ContentAlignment.MiddleLeft;
            BtnStudentInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnStudentInfo.UseVisualStyleBackColor = true;
            BtnStudentInfo.Click += BtnStudentInfo_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Bottom;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(0, 475);
            button4.Name = "button4";
            button4.Size = new Size(150, 39);
            button4.TabIndex = 4;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(251, 9);
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
            pnlContent.Location = new Point(150, 97);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1057, 514);
            pnlContent.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.BlanchedAlmond;
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(btnMenu);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1207, 97);
            panel4.TabIndex = 2;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.PeachPuff;
            btnMenu.FlatStyle = FlatStyle.Popup;
            btnMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.Location = new Point(29, 34);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(98, 41);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "☰";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Stencil", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(338, 19);
            label1.Name = "label1";
            label1.Size = new Size(609, 56);
            label1.TabIndex = 0;
            label1.Text = "ADMIN INFORMATION HUB";
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 7;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1207, 611);
            Controls.Add(pnlContent);
            Controls.Add(sidebarPanel);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            Load += Form1_Load;
            sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebarPanel;
        private Panel pnlContent;
        private Panel panel4;
        private Button btnCourseInfo;
        private Button asdsa;
        private PictureBox pictureBox1;
        private Button button4;
        private Label label1;
        private Button btnMenu;
        private System.Windows.Forms.Timer sidebarTimer;
        private FontAwesome.Sharp.IconButton BtnStudentInfo;
        private FontAwesome.Sharp.IconButton BtnTeacherInfo;
        private FontAwesome.Sharp.IconButton BtnCourseInfo;
        private FontAwesome.Sharp.IconButton BtnAnalytics;
        private FontAwesome.Sharp.IconButton BtnEnrollments;
    }
}