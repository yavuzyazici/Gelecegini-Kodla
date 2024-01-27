namespace BookAppForm
{
    partial class BookList
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
            dG = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dG).BeginInit();
            SuspendLayout();
            // 
            // dG
            // 
            dG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dG.Location = new Point(12, 12);
            dG.Name = "dG";
            dG.ReadOnly = true;
            dG.Size = new Size(776, 352);
            dG.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Montserrat Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(317, 382);
            button1.Name = "button1";
            button1.Size = new Size(187, 56);
            button1.TabIndex = 1;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BookList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dG);
            Name = "BookList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookList";
            Load += BookList_Load;
            ((System.ComponentModel.ISupportInitialize)dG).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dG;
        private Button button1;
    }
}