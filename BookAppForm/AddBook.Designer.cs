namespace BookAppForm
{
    partial class AddBook
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
            label1 = new Label();
            txtBoxTitle = new TextBox();
            txtBoxAuthor = new TextBox();
            label2 = new Label();
            txtBoxDesc = new TextBox();
            label3 = new Label();
            txtBoxISBN = new TextBox();
            label4 = new Label();
            btnAdd = new Button();
            label5 = new Label();
            txtBoxLocation = new TextBox();
            label6 = new Label();
            checkBox = new CheckBox();
            txtBoxPageCount = new TextBox();
            lblPageCount = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 22);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.Location = new Point(22, 43);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(323, 23);
            txtBoxTitle.TabIndex = 1;
            // 
            // txtBoxAuthor
            // 
            txtBoxAuthor.Location = new Point(22, 127);
            txtBoxAuthor.Name = "txtBoxAuthor";
            txtBoxAuthor.Size = new Size(323, 23);
            txtBoxAuthor.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(22, 93);
            label2.Name = "label2";
            label2.Size = new Size(74, 22);
            label2.TabIndex = 2;
            label2.Text = "Author";
            // 
            // txtBoxDesc
            // 
            txtBoxDesc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtBoxDesc.Location = new Point(368, 211);
            txtBoxDesc.Multiline = true;
            txtBoxDesc.Name = "txtBoxDesc";
            txtBoxDesc.Size = new Size(323, 227);
            txtBoxDesc.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(368, 175);
            label3.Name = "label3";
            label3.Size = new Size(115, 22);
            label3.TabIndex = 4;
            label3.Text = "Description";
            // 
            // txtBoxISBN
            // 
            txtBoxISBN.Location = new Point(22, 211);
            txtBoxISBN.Name = "txtBoxISBN";
            txtBoxISBN.Size = new Size(317, 23);
            txtBoxISBN.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(22, 173);
            label4.Name = "label4";
            label4.Size = new Size(54, 22);
            label4.TabIndex = 6;
            label4.Text = "ISBN";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.Font = new Font("Montserrat Black", 26.2499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnAdd.Location = new Point(21, 256);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(318, 182);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(368, 93);
            label5.Name = "label5";
            label5.Size = new Size(69, 22);
            label5.TabIndex = 10;
            label5.Text = "Status";
            // 
            // txtBoxLocation
            // 
            txtBoxLocation.Location = new Point(368, 43);
            txtBoxLocation.Name = "txtBoxLocation";
            txtBoxLocation.Size = new Size(323, 23);
            txtBoxLocation.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(368, 9);
            label6.Name = "label6";
            label6.Size = new Size(89, 22);
            label6.TabIndex = 7;
            label6.Text = "Location";
            // 
            // checkBox
            // 
            checkBox.Anchor = AnchorStyles.Left;
            checkBox.AutoSize = true;
            checkBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            checkBox.Location = new Point(368, 127);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(72, 21);
            checkBox.TabIndex = 11;
            checkBox.Text = "Okundu";
            checkBox.UseVisualStyleBackColor = true;
            // 
            // txtBoxPageCount
            // 
            txtBoxPageCount.Location = new Point(494, 127);
            txtBoxPageCount.Name = "txtBoxPageCount";
            txtBoxPageCount.Size = new Size(197, 23);
            txtBoxPageCount.TabIndex = 27;
            // 
            // lblPageCount
            // 
            lblPageCount.AutoSize = true;
            lblPageCount.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPageCount.Location = new Point(494, 93);
            lblPageCount.Name = "lblPageCount";
            lblPageCount.Size = new Size(118, 22);
            lblPageCount.TabIndex = 26;
            lblPageCount.Text = "Page Count";
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 450);
            Controls.Add(txtBoxPageCount);
            Controls.Add(lblPageCount);
            Controls.Add(checkBox);
            Controls.Add(label5);
            Controls.Add(txtBoxLocation);
            Controls.Add(label6);
            Controls.Add(btnAdd);
            Controls.Add(txtBoxISBN);
            Controls.Add(label4);
            Controls.Add(txtBoxDesc);
            Controls.Add(label3);
            Controls.Add(txtBoxAuthor);
            Controls.Add(label2);
            Controls.Add(txtBoxTitle);
            Controls.Add(label1);
            Name = "AddBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBook";
            Load += AddBook_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxTitle;
        private TextBox txtBoxAuthor;
        private Label label2;
        private TextBox txtBoxDesc;
        private Label label3;
        private TextBox txtBoxISBN;
        private Label label4;
        private Button btnAdd;
        private TextBox textBox1;
        private Label label5;
        private TextBox txtBoxLocation;
        private Label label6;
        private CheckBox checkBox;
        private TextBox txtBoxPageCount;
        private Label lblPageCount;
    }
}