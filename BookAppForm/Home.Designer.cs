namespace BookAppForm
{
    partial class Home
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
            dG = new DataGridView();
            btnRefresh = new Button();
            txtSearch = new TextBox();
            btnUpdate = new Button();
            btnAdd = new Button();
            pictureBox1 = new PictureBox();
            btnGive = new Button();
            ((System.ComponentModel.ISupportInitialize)dG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dG
            // 
            dG.AllowUserToAddRows = false;
            dG.AllowUserToDeleteRows = false;
            dG.AllowUserToResizeRows = false;
            dG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dG.DefaultCellStyle = dataGridViewCellStyle2;
            dG.Location = new Point(12, 57);
            dG.MultiSelect = false;
            dG.Name = "dG";
            dG.ReadOnly = true;
            dG.Size = new Size(776, 346);
            dG.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 9F);
            btnRefresh.Location = new Point(372, 409);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(57, 29);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(632, 21);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(156, 23);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(286, 15);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(62, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(206, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(74, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(13, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 45);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnGive
            // 
            btnGive.Location = new Point(354, 15);
            btnGive.Name = "btnGive";
            btnGive.Size = new Size(62, 29);
            btnGive.TabIndex = 6;
            btnGive.Text = "Give";
            btnGive.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGive);
            Controls.Add(pictureBox1);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(txtSearch);
            Controls.Add(btnRefresh);
            Controls.Add(dG);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)dG).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public static DataGridView dG;
        private Button btnRefresh;
        private TextBox txtSearch;
        private Button btnUpdate;
        private Button btnAdd;
        private PictureBox pictureBox1;
        private Button btnGive;
    }
}