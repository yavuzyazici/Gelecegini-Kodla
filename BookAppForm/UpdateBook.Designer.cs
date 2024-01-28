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
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdate.Font = new Font("Montserrat Black", 26.2499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnUpdate.Location = new Point(363, 11);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(425, 429);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtBoxISBN
            // 
            txtBoxISBN.Location = new Point(17, 225);
            txtBoxISBN.Name = "txtBoxISBN";
            txtBoxISBN.Size = new Size(317, 23);
            txtBoxISBN.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(17, 175);
            label4.Name = "label4";
            label4.Size = new Size(96, 22);
            label4.TabIndex = 19;
            label4.Text = "Book ISBN";
            // 
            // txtBoxDesc
            // 
            txtBoxDesc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtBoxDesc.Location = new Point(17, 312);
            txtBoxDesc.Multiline = true;
            txtBoxDesc.Name = "txtBoxDesc";
            txtBoxDesc.Size = new Size(323, 128);
            txtBoxDesc.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(17, 276);
            label3.Name = "label3";
            label3.Size = new Size(150, 22);
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
            label2.Size = new Size(114, 22);
            label2.TabIndex = 14;
            label2.Text = "Book Author";
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
            label1.Size = new Size(90, 22);
            label1.TabIndex = 11;
            label1.Text = "Book Title";
            // 
            // UpdateBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}