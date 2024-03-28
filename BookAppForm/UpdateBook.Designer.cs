namespace BookAppForm
{
    partial class UpdateBook
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
            btnUpdate = new Button();
            txtBoxISBN = new TextBox();
            label4 = new Label();
            txtBoxDesc = new TextBox();
            label3 = new Label();
            txtBoxAuthor = new TextBox();
            label2 = new Label();
            txtBoxTitle = new TextBox();
            label1 = new Label();
            label5 = new Label();
            txtBoxLocation = new TextBox();
            label6 = new Label();
            txtBoxPageCount = new TextBox();
            lblPageCount = new Label();
            txtBoxPage = new TextBox();
            lblPage = new Label();
            txtBoxTur = new TextBox();
            lblTur = new Label();
            txtStatus = new TextBox();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdate.Font = new Font("Montserrat Black", 26.2499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnUpdate.Location = new Point(17, 274);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(269, 164);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtBoxISBN
            // 
            txtBoxISBN.Location = new Point(145, 200);
            txtBoxISBN.Name = "txtBoxISBN";
            txtBoxISBN.Size = new Size(195, 23);
            txtBoxISBN.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(145, 175);
            label4.Name = "label4";
            label4.Size = new Size(54, 22);
            label4.TabIndex = 19;
            label4.Text = "ISBN";
            // 
            // txtBoxDesc
            // 
            txtBoxDesc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtBoxDesc.Location = new Point(416, 274);
            txtBoxDesc.Multiline = true;
            txtBoxDesc.Name = "txtBoxDesc";
            txtBoxDesc.Size = new Size(323, 21);
            txtBoxDesc.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(416, 242);
            label3.Name = "label3";
            label3.Size = new Size(166, 22);
            label3.TabIndex = 17;
            label3.Text = "Book Description";
            // 
            // txtBoxAuthor
            // 
            txtBoxAuthor.Location = new Point(17, 129);
            txtBoxAuthor.Name = "txtBoxAuthor";
            txtBoxAuthor.Size = new Size(323, 23);
            txtBoxAuthor.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(17, 95);
            label2.Name = "label2";
            label2.Size = new Size(74, 22);
            label2.TabIndex = 14;
            label2.Text = "Author";
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.Location = new Point(17, 45);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(323, 23);
            txtBoxTitle.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(17, 11);
            label1.Name = "label1";
            label1.Size = new Size(49, 22);
            label1.TabIndex = 11;
            label1.Text = "Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(416, 95);
            label5.Name = "label5";
            label5.Size = new Size(69, 22);
            label5.TabIndex = 22;
            label5.Text = "Status";
            // 
            // txtBoxLocation
            // 
            txtBoxLocation.Location = new Point(416, 45);
            txtBoxLocation.Name = "txtBoxLocation";
            txtBoxLocation.Size = new Size(323, 23);
            txtBoxLocation.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(416, 11);
            label6.Name = "label6";
            label6.Size = new Size(89, 22);
            label6.TabIndex = 20;
            label6.Text = "Location";
            // 
            // txtBoxPageCount
            // 
            txtBoxPageCount.Location = new Point(542, 129);
            txtBoxPageCount.Name = "txtBoxPageCount";
            txtBoxPageCount.Size = new Size(197, 23);
            txtBoxPageCount.TabIndex = 25;
            // 
            // lblPageCount
            // 
            lblPageCount.AutoSize = true;
            lblPageCount.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPageCount.Location = new Point(542, 95);
            lblPageCount.Name = "lblPageCount";
            lblPageCount.Size = new Size(118, 22);
            lblPageCount.TabIndex = 24;
            lblPageCount.Text = "Page Count";
            // 
            // txtBoxPage
            // 
            txtBoxPage.Location = new Point(17, 200);
            txtBoxPage.Name = "txtBoxPage";
            txtBoxPage.Size = new Size(96, 23);
            txtBoxPage.TabIndex = 26;
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPage.Location = new Point(17, 175);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(118, 22);
            lblPage.TabIndex = 27;
            lblPage.Text = "Page Count";
            // 
            // txtBoxTur
            // 
            txtBoxTur.Location = new Point(292, 301);
            txtBoxTur.Name = "txtBoxTur";
            txtBoxTur.Size = new Size(156, 23);
            txtBoxTur.TabIndex = 28;
            // 
            // lblTur
            // 
            lblTur.AutoSize = true;
            lblTur.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTur.Location = new Point(292, 271);
            lblTur.Name = "lblTur";
            lblTur.Size = new Size(40, 22);
            lblTur.TabIndex = 29;
            lblTur.Text = "Tür";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(416, 129);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(120, 23);
            txtStatus.TabIndex = 30;
            // 
            // UpdateBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 450);
            Controls.Add(txtStatus);
            Controls.Add(txtBoxTur);
            Controls.Add(lblTur);
            Controls.Add(txtBoxPage);
            Controls.Add(lblPage);
            Controls.Add(txtBoxPageCount);
            Controls.Add(lblPageCount);
            Controls.Add(label5);
            Controls.Add(txtBoxLocation);
            Controls.Add(label6);
            Controls.Add(btnUpdate);
            Controls.Add(txtBoxISBN);
            Controls.Add(label4);
            Controls.Add(txtBoxDesc);
            Controls.Add(label3);
            Controls.Add(txtBoxAuthor);
            Controls.Add(label2);
            Controls.Add(txtBoxTitle);
            Controls.Add(label1);
            Name = "UpdateBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateBook";
            Load += UpdateBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnUpdate;
        private TextBox txtBoxISBN;
        private Label label4;
        private TextBox txtBoxDesc;
        private Label label3;
        private TextBox txtBoxAuthor;
        private Label label2;
        private TextBox txtBoxTitle;
        private Label label1;
        private Label label5;
        private TextBox txtBoxLocation;
        private Label label6;
        private TextBox txtBoxPageCount;
        private Label lblPageCount;
        private TextBox txtBoxPage;
        private Label lblPage;
        private TextBox txtBoxTur;
        private Label lblTur;
        private TextBox txtStatus;
    }
}