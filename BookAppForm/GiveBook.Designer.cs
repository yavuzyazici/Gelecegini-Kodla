namespace BookAppForm
{
    partial class GiveBook
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
            txtSearch = new TextBox();
            dG = new DataGridView();
            btnEmanet = new Button();
            txtEmanetTo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dG).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(12, 12);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(280, 23);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
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
            dG.Location = new Point(12, 41);
            dG.MultiSelect = false;
            dG.Name = "dG";
            dG.ReadOnly = true;
            dG.Size = new Size(776, 339);
            dG.TabIndex = 6;
            // 
            // btnEmanet
            // 
            btnEmanet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEmanet.Font = new Font("Montserrat Black", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnEmanet.Location = new Point(519, 386);
            btnEmanet.Name = "btnEmanet";
            btnEmanet.Size = new Size(269, 52);
            btnEmanet.TabIndex = 19;
            btnEmanet.Text = "Emanet";
            btnEmanet.UseVisualStyleBackColor = true;
            btnEmanet.Click += btnEmanet_Click;
            // 
            // txtEmanetTo
            // 
            txtEmanetTo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEmanetTo.Location = new Point(508, 12);
            txtEmanetTo.Multiline = true;
            txtEmanetTo.Name = "txtEmanetTo";
            txtEmanetTo.PlaceholderText = "Emanet Edilecek Kişi";
            txtEmanetTo.Size = new Size(280, 23);
            txtEmanetTo.TabIndex = 20;
            // 
            // GiveBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEmanetTo);
            Controls.Add(btnEmanet);
            Controls.Add(dG);
            Controls.Add(txtSearch);
            Name = "GiveBook";
            Text = "GiveBook";
            Load += GiveBook_Load;
            ((System.ComponentModel.ISupportInitialize)dG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private DataGridView dG;
        private Button btnEmanet;
        private TextBox txtEmanetTo;
    }
}