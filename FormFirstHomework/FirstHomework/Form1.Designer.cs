namespace FirstHomework
{
    partial class FirstForm
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
            button = new Button();
            lbl = new Label();
            SuspendLayout();
            // 
            // button
            // 
            button.Font = new Font("Poppins", 12F);
            button.Location = new Point(305, 267);
            button.Name = "button";
            button.Size = new Size(175, 70);
            button.TabIndex = 0;
            button.Text = "Click";
            button.UseVisualStyleBackColor = true;
            button.Click += button1_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Poppins Medium", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl.Location = new Point(232, 84);
            lbl.Name = "lbl";
            lbl.Size = new Size(0, 56);
            lbl.TabIndex = 1;
            // 
            // FirstForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl);
            Controls.Add(button);
            Name = "FirstForm";
            Text = "FirstForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button;
        private Label lbl;
    }
}
