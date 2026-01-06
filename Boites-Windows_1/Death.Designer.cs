namespace Boites_Windows_1
{
    partial class Death
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Death));
            DeathHeader = new Label();
            moduleImage = new PictureBox();
            finish = new Button();
            startLabel = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)moduleImage).BeginInit();
            SuspendLayout();
            // 
            // DeathHeader
            // 
            DeathHeader.AutoSize = true;
            DeathHeader.Font = new Font("Retro Gaming", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeathHeader.Location = new Point(40, 9);
            DeathHeader.Name = "DeathHeader";
            DeathHeader.Size = new Size(153, 46);
            DeathHeader.TabIndex = 57;
            DeathHeader.Text = "Death";
            // 
            // moduleImage
            // 
            moduleImage.Image = (Image)resources.GetObject("moduleImage.Image");
            moduleImage.Location = new Point(77, 74);
            moduleImage.Name = "moduleImage";
            moduleImage.Size = new Size(82, 84);
            moduleImage.TabIndex = 60;
            moduleImage.TabStop = false;
            // 
            // finish
            // 
            finish.BackColor = Color.DimGray;
            finish.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finish.ForeColor = Color.White;
            finish.Location = new Point(19, 385);
            finish.Name = "finish";
            finish.Size = new Size(191, 64);
            finish.TabIndex = 61;
            finish.Text = "Finish";
            finish.UseVisualStyleBackColor = false;
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startLabel.Location = new Point(89, 196);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(61, 29);
            startLabel.TabIndex = 62;
            startLabel.Text = "D.O.D:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(68, 237);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 63;
            // 
            // Death
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(222, 461);
            Controls.Add(textBox1);
            Controls.Add(startLabel);
            Controls.Add(finish);
            Controls.Add(moduleImage);
            Controls.Add(DeathHeader);
            Name = "Death";
            Text = "Death";
            ((System.ComponentModel.ISupportInitialize)moduleImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DeathHeader;
        private PictureBox moduleImage;
        private Button finish;
        private Label startLabel;
        private TextBox textBox1;
    }
}