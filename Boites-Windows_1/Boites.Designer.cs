namespace Boites_Windows_1
{
    partial class Boites
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
            monthYear = new Label();
            SuspendLayout();
            // 
            // monthYear
            // 
            monthYear.AutoSize = true;
            monthYear.Font = new Font("p5hatty", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthYear.Location = new Point(31, 25);
            monthYear.Name = "monthYear";
            monthYear.Size = new Size(244, 37);
            monthYear.TabIndex = 0;
            monthYear.Text = "January 2026";
            // 
            // Boites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 893);
            Controls.Add(monthYear);
            Name = "Boites";
            Text = "Boites";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label monthYear;
    }
}
