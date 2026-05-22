namespace StudentScholarTracker
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            txtUname = new TextBox();
            txtPass = new TextBox();
            btnRegister = new Button();
            btnLogin = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Cornsilk;
            label1.Font = new Font("Book Antiqua", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(509, 85);
            label1.Name = "label1";
            label1.Size = new Size(98, 22);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.OldLace;
            label2.Font = new Font("Book Antiqua", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(513, 144);
            label2.Name = "label2";
            label2.Size = new Size(94, 22);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // txtUname
            // 
            txtUname.Location = new Point(613, 80);
            txtUname.Name = "txtUname";
            txtUname.Size = new Size(220, 27);
            txtUname.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(613, 139);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(220, 27);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(612, 183);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(92, 32);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(741, 183);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(92, 32);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(867, 516);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(92, 32);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(971, 560);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(txtPass);
            Controls.Add(txtUname);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUname;
        private TextBox txtPass;
        private Button btnRegister;
        private Button btnLogin;
        private Button btnExit;
    }
}
