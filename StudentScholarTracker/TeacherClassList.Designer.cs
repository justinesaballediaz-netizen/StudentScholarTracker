namespace StudentScholarTracker
{
    partial class TeacherClassList
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvClassList = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            txtSearch = new TextBox();
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClassList).BeginInit();
            SuspendLayout();
            // 
            // dgvClassList
            // 
            dgvClassList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClassList.BackgroundColor = Color.White;
            dgvClassList.BorderStyle = BorderStyle.None;
            dgvClassList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvClassList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClassList.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClassList.Dock = DockStyle.Bottom;
            dgvClassList.EnableHeadersVisualStyles = false;
            dgvClassList.GridColor = Color.Gainsboro;
            dgvClassList.Location = new Point(0, 271);
            dgvClassList.Name = "dgvClassList";
            dgvClassList.RowHeadersVisible = false;
            dgvClassList.RowHeadersWidth = 51;
            dgvClassList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClassList.Size = new Size(973, 242);
            dgvClassList.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = Color.DimGray;
            label2.Location = new Point(233, 109);
            label2.Name = "label2";
            label2.Size = new Size(446, 8);
            label2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans MT", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 26);
            label1.Name = "label1";
            label1.Size = new Size(497, 83);
            label1.TabIndex = 7;
            label1.Text = "Official Class List";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(703, 182);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(258, 27);
            txtSearch.TabIndex = 10;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.Chartreuse;
            btnExport.FlatStyle = FlatStyle.Popup;
            btnExport.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.Location = new Point(7, 158);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(147, 51);
            btnExport.TabIndex = 9;
            btnExport.Text = "Export ClassList";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // TeacherClassList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(973, 513);
            Controls.Add(btnExport);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvClassList);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TeacherClassList";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClassList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClassList;
        private Label label2;
        private Label label1;
        private TextBox txtSearch;
        private Button btnExport;
    }
}