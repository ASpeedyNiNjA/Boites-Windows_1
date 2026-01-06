namespace Boites_Windows_1
{
    partial class Shower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shower));
            durationText = new TextBox();
            durationLabel = new Label();
            finishText = new TextBox();
            dateText = new TextBox();
            startLabel = new Label();
            finishLabel = new Label();
            startText = new TextBox();
            dateLabel = new Label();
            ShowerHeader = new Label();
            finish = new Button();
            start = new Button();
            moduleImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)moduleImage).BeginInit();
            SuspendLayout();
            // 
            // durationText
            // 
            durationText.Location = new Point(117, 268);
            durationText.Name = "durationText";
            durationText.Size = new Size(98, 23);
            durationText.TabIndex = 55;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            durationLabel.Location = new Point(19, 262);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(90, 29);
            durationLabel.TabIndex = 54;
            durationLabel.Text = "Duration:";
            // 
            // finishText
            // 
            finishText.Location = new Point(85, 184);
            finishText.Name = "finishText";
            finishText.Size = new Size(130, 23);
            finishText.TabIndex = 52;
            // 
            // dateText
            // 
            dateText.Location = new Point(85, 226);
            dateText.Name = "dateText";
            dateText.Size = new Size(130, 23);
            dateText.TabIndex = 53;
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startLabel.Location = new Point(19, 139);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(62, 29);
            startLabel.TabIndex = 48;
            startLabel.Text = "Start:";
            // 
            // finishLabel
            // 
            finishLabel.AutoSize = true;
            finishLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            finishLabel.Location = new Point(15, 178);
            finishLabel.Name = "finishLabel";
            finishLabel.Size = new Size(66, 29);
            finishLabel.TabIndex = 49;
            finishLabel.Text = "Finish:";
            // 
            // startText
            // 
            startText.Location = new Point(85, 145);
            startText.Name = "startText";
            startText.Size = new Size(130, 23);
            startText.TabIndex = 51;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(24, 220);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(57, 29);
            dateLabel.TabIndex = 50;
            dateLabel.Text = "Date:";
            // 
            // ShowerHeader
            // 
            ShowerHeader.AutoSize = true;
            ShowerHeader.Font = new Font("Retro Gaming", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowerHeader.Location = new Point(30, 9);
            ShowerHeader.Name = "ShowerHeader";
            ShowerHeader.Size = new Size(185, 46);
            ShowerHeader.TabIndex = 56;
            ShowerHeader.Text = "Shower";
            // 
            // finish
            // 
            finish.BackColor = Color.White;
            finish.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finish.ForeColor = Color.Blue;
            finish.Location = new Point(24, 385);
            finish.Name = "finish";
            finish.Size = new Size(191, 64);
            finish.TabIndex = 57;
            finish.Text = "Finish";
            finish.UseVisualStyleBackColor = false;
            // 
            // start
            // 
            start.BackColor = Color.Blue;
            start.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            start.ForeColor = SystemColors.ButtonFace;
            start.Location = new Point(24, 306);
            start.Name = "start";
            start.Size = new Size(191, 64);
            start.TabIndex = 58;
            start.Text = "Start";
            start.UseVisualStyleBackColor = false;
            // 
            // moduleImage
            // 
            moduleImage.Image = (Image)resources.GetObject("moduleImage.Image");
            moduleImage.Location = new Point(85, 58);
            moduleImage.Name = "moduleImage";
            moduleImage.Size = new Size(82, 84);
            moduleImage.TabIndex = 59;
            moduleImage.TabStop = false;
            // 
            // Shower
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(233, 459);
            Controls.Add(moduleImage);
            Controls.Add(finish);
            Controls.Add(start);
            Controls.Add(ShowerHeader);
            Controls.Add(durationText);
            Controls.Add(durationLabel);
            Controls.Add(finishText);
            Controls.Add(dateText);
            Controls.Add(startLabel);
            Controls.Add(finishLabel);
            Controls.Add(startText);
            Controls.Add(dateLabel);
            Name = "Shower";
            Text = "Shower";
            ((System.ComponentModel.ISupportInitialize)moduleImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox durationText;
        private Label durationLabel;
        private TextBox finishText;
        private TextBox dateText;
        private Label startLabel;
        private Label finishLabel;
        private TextBox startText;
        private Label dateLabel;
        private Label ShowerHeader;
        private Button finish;
        private Button start;
        private PictureBox moduleImage;
    }
}