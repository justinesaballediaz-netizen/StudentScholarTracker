namespace StudentScholarTracker
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            sidebarPanel = new Panel();
            btnGradeEncode = new FontAwesome.Sharp.IconButton();
            btnClassList = new FontAwesome.Sharp.IconButton();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            btnMenu = new Button();
            label1 = new Label();
            pnlContent = new Panel();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.BlanchedAlmond;
            sidebarPanel.Controls.Add(btnGradeEncode);
            sidebarPanel.Controls.Add(btnClassList);
            sidebarPanel.Controls.Add(btnExit);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 94);
            sidebarPanel.MaximumSize = new Size(150, 0);
            sidebarPanel.MinimumSize = new Size(50, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(150, 475);
            sidebarPanel.TabIndex = 2;
            // 
            // btnGradeEncode
            // 
            btnGradeEncode.Dock = DockStyle.Top;
            btnGradeEncode.FlatStyle = FlatStyle.Flat;
            btnGradeEncode.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGradeEncode.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            btnGradeEncode.IconColor = Color.Gold;
            btnGradeEncode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGradeEncode.IconSize = 37;
            btnGradeEncode.Location = new Point(0, 60);
            btnGradeEncode.Name = "btnGradeEncode";
            btnGradeEncode.Padding = new Padding(7, 0, 0, 0);
            btnGradeEncode.Size = new Size(150, 60);
            btnGradeEncode.TabIndex = 6;
            btnGradeEncode.Text = "Grade Encode";
            btnGradeEncode.TextAlign = ContentAlignment.MiddleLeft;
            btnGradeEncode.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGradeEncode.UseVisualStyleBackColor = true;
            btnGradeEncode.Click += btnGradeEncode_Click;
            // 
            // btnClassList
            // 
            btnClassList.Dock = DockStyle.Top;
            btnClassList.FlatStyle = FlatStyle.Flat;
            btnClassList.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClassList.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnClassList.IconColor = Color.Gold;
            btnClassList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClassList.IconSize = 37;
            btnClassList.Location = new Point(0, 0);
            btnClassList.Name = "btnClassList";
            btnClassList.Padding = new Padding(7, 0, 0, 0);
            btnClassList.Size = new Size(150, 60);
            btnClassList.TabIndex = 5;
            btnClassList.Text = "Class List";
            btnClassList.TextAlign = ContentAlignment.MiddleLeft;
            btnClassList.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClassList.UseVisualStyleBackColor = true;
            btnClassList.Click += btnClassList_Click;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(0, 436);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 39);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(212, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            panel4.TabIndex = 4;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.PeachPuff;
            btnMenu.FlatStyle = FlatStyle.Popup;
            btnMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.Location = new Point(28, 33);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(98, 41);
            btnMenu.TabIndex = 6;
            btnMenu.Text = "☰";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(325, 18);
            label1.Name = "label1";
            label1.Size = new Size(670, 56);
            label1.TabIndex = 0;
            label1.Text = "TEACHER INFORMATION HUB";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.OldLace;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(150, 94);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1039, 475);
            pnlContent.TabIndex = 5;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 20;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1189, 569);
            Controls.Add(pnlContent);
            Controls.Add(sidebarPanel);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TeacherForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherForm";
            sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebarPanel;
        private Button btnExit;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Label label1;
        private Panel pnlContent;
        private Button btnMenu;
        private System.Windows.Forms.Timer sidebarTimer;
        private FontAwesome.Sharp.IconButton btnClassList;
        private FontAwesome.Sharp.IconButton btnGradeEncode;
    }
}