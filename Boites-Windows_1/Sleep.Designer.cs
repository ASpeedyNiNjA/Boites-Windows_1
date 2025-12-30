namespace Boites_Windows_1
{
    partial class Sleep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sleep));
            Header = new Label();
            finishLabel = new Label();
            dateLabel = new Label();
            startText = new TextBox();
            startLabel = new Label();
            dateText = new TextBox();
            finishText = new TextBox();
            durationLabel = new Label();
            durationText = new TextBox();
            start = new Button();
            finish = new Button();
            moduleImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)moduleImage).BeginInit();
            SuspendLayout();
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Retro Gaming", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Header.Location = new Point(12, 9);
            Header.Name = "Header";
            Header.Size = new Size(147, 46);
            Header.TabIndex = 49;
            Header.Text = "Sleep";
            // 
            // finishLabel
            // 
            finishLabel.AutoSize = true;
            finishLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            finishLabel.Location = new Point(12, 134);
            finishLabel.Name = "finishLabel";
            finishLabel.Size = new Size(66, 29);
            finishLabel.TabIndex = 50;
            finishLabel.Text = "Finish:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(21, 176);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(57, 29);
            dateLabel.TabIndex = 51;
            dateLabel.Text = "Date:";
            // 
            // startText
            // 
            startText.Location = new Point(82, 101);
            startText.Name = "startText";
            startText.Size = new Size(130, 23);
            startText.TabIndex = 52;
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startLabel.Location = new Point(16, 95);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(62, 29);
            startLabel.TabIndex = 49;
            startLabel.Text = "Start:";
            // 
            // dateText
            // 
            dateText.Location = new Point(82, 182);
            dateText.Name = "dateText";
            dateText.Size = new Size(130, 23);
            dateText.TabIndex = 54;
            // 
            // finishText
            // 
            finishText.Location = new Point(82, 140);
            finishText.Name = "finishText";
            finishText.Size = new Size(130, 23);
            finishText.TabIndex = 53;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            durationLabel.Location = new Point(16, 218);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(90, 29);
            durationLabel.TabIndex = 55;
            durationLabel.Text = "Duration:";
            // 
            // durationText
            // 
            durationText.Location = new Point(114, 224);
            durationText.Name = "durationText";
            durationText.Size = new Size(98, 23);
            durationText.TabIndex = 56;
            // 
            // start
            // 
            start.BackColor = Color.PowderBlue;
            start.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            start.ForeColor = SystemColors.ButtonFace;
            start.Location = new Point(21, 278);
            start.Name = "start";
            start.Size = new Size(191, 64);
            start.TabIndex = 50;
            start.Text = "Start";
            start.UseVisualStyleBackColor = false;
            // 
            // finish
            // 
            finish.BackColor = Color.LightGreen;
            finish.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finish.ForeColor = SystemColors.ControlLightLight;
            finish.Location = new Point(21, 374);
            finish.Name = "finish";
            finish.Size = new Size(191, 64);
            finish.TabIndex = 49;
            finish.Text = "Finish";
            finish.UseVisualStyleBackColor = false;
            // 
            // moduleImage
            // 
            moduleImage.Image = (Image)resources.GetObject("moduleImage.Image");
            moduleImage.Location = new Point(167, 9);
            moduleImage.Name = "moduleImage";
            moduleImage.Size = new Size(84, 84);
            moduleImage.TabIndex = 49;
            moduleImage.TabStop = false;
            // 
            // Sleep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 450);
            Controls.Add(moduleImage);
            Controls.Add(finish);
            Controls.Add(durationText);
            Controls.Add(start);
            Controls.Add(Header);
            Controls.Add(durationLabel);
            Controls.Add(finishLabel);
            Controls.Add(finishText);
            Controls.Add(dateLabel);
            Controls.Add(dateText);
            Controls.Add(startText);
            Controls.Add(startLabel);
            Name = "Sleep";
            Text = "Sleep";
            ((System.ComponentModel.ISupportInitialize)moduleImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Header;
        private Label finishLabel;
        private Label dateLabel;
        private TextBox startText;
        private Label startLabel;
        private TextBox dateText;
        private TextBox finishText;
        private Label durationLabel;
        private TextBox durationText;
        private Button start;
        private Button finish;
        private PictureBox moduleImage;
    }
}