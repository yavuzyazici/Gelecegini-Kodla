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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 22);
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
            label2.Size = new Size(68, 22);
            label2.TabIndex = 2;
            label2.Text = "Author";
            // 
            // txtBoxDesc
            // 
            txtBoxDesc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtBoxDesc.Location = new Point(22, 310);
            txtBoxDesc.Multiline = true;
            txtBoxDesc.Name = "txtBoxDesc";
            txtBoxDesc.Size = new Size(323, 128);
            txtBoxDesc.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(22, 274);
            label3.Name = "label3";
            label3.Size = new Size(104, 22);
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
            label4.Size = new Size(50, 22);
            label4.TabIndex = 6;
            label4.Text = "ISBN";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.Font = new Font("Montserrat Black", 26.2499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnAdd.Location = new Point(368, 9);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(420, 429);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}