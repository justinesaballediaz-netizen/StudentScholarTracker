namespace StudentScholarTracker
{
    partial class StudyLoadForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvStudyLoad = new DataGridView();
            label1 = new Label();
            lblTotalUnits = new Label();
            label2 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnRemoveSchedule = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudyLoad).BeginInit();
            SuspendLayout();
            // 
            // dgvStudyLoad
            // 
            dgvStudyLoad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudyLoad.BackgroundColor = Color.Bisque;
            dgvStudyLoad.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStudyLoad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStudyLoad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvStudyLoad.DefaultCellStyle = dataGridViewCellStyle2;
            dgvStudyLoad.Dock = DockStyle.Bottom;
            dgvStudyLoad.GridColor = Color.NavajoWhite;
            dgvStudyLoad.Location = new Point(0, 214);
            dgvStudyLoad.Name = "dgvStudyLoad";
            dgvStudyLoad.ReadOnly = true;
            dgvStudyLoad.RowHeadersVisible = false;
            dgvStudyLoad.RowHeadersWidth = 51;
            dgvStudyLoad.Size = new Size(859, 252);
            dgvStudyLoad.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans MT", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(138, 35);
            label1.Name = "label1";
            label1.Size = new Size(548, 83);
            label1.TabIndex = 4;
            label1.Text = "Official Study Load";
            // 
            // lblTotalUnits
            // 
            lblTotalUnits.AutoSize = true;
            lblTotalUnits.Font = new Font("Gill Sans MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalUnits.Location = new Point(728, 184);
            lblTotalUnits.Name = "lblTotalUnits";
            lblTotalUnits.Size = new Size(119, 27);
            lblTotalUnits.TabIndex = 5;
            lblTotalUnits.Text = "Total Units: ";
            // 
            // label2
            // 
            label2.BackColor = Color.DimGray;
            label2.Location = new Point(193, 118);
            label2.Name = "label2";
            label2.Size = new Size(446, 8);
            label2.TabIndex = 6;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Lime;
            iconButton1.FlatStyle = FlatStyle.Popup;
            iconButton1.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            iconButton1.IconColor = Color.ForestGreen;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 37;
            iconButton1.Location = new Point(12, 157);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(133, 51);
            iconButton1.TabIndex = 7;
            iconButton1.Text = "Export StudyLoad";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // btnRemoveSchedule
            // 
            btnRemoveSchedule.BackColor = Color.Yellow;
            btnRemoveSchedule.FlatStyle = FlatStyle.Popup;
            btnRemoveSchedule.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveSchedule.Location = new Point(164, 157);
            btnRemoveSchedule.Name = "btnRemoveSchedule";
            btnRemoveSchedule.Size = new Size(118, 51);
            btnRemoveSchedule.TabIndex = 8;
            btnRemoveSchedule.Text = "Remove Schedule";
            btnRemoveSchedule.UseVisualStyleBackColor = false;
            btnRemoveSchedule.Click += btnRemoveSchedule_Click;
            // 
            // StudyLoadForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(859, 466);
            Controls.Add(btnRemoveSchedule);
            Controls.Add(iconButton1);
            Controls.Add(label2);
            Controls.Add(lblTotalUnits);
            Controls.Add(label1);
            Controls.Add(dgvStudyLoad);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudyLoadForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvStudyLoad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudyLoad;
        private Label label1;
        private Label lblTotalUnits;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Button btnRemoveSchedule;
    }
}