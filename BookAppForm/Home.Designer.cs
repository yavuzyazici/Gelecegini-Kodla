namespace BookAppForm
{
    partial class Home
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
            btnBookList = new Button();
            btnAddBook = new Button();
            SuspendLayout();
            // 
            // btnBookList
            // 
            btnBookList.Font = new Font("Montserrat", 14.25F);
            btnBookList.Location = new Point(147, 153);
            btnBookList.Name = "btnBookList";
            btnBookList.Size = new Size(187, 108);
            btnBookList.TabIndex = 0;
            btnBookList.Text = "Book List";
            btnBookList.UseVisualStyleBackColor = true;
            btnBookList.Click += btnBookList_Click_1;
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnAddBook.Location = new Point(467, 153);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(187, 108);
            btnAddBook.TabIndex = 1;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddBook);
            Controls.Add(btnBookList);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBookList;
        private Button btnAddBook;
    }
}
