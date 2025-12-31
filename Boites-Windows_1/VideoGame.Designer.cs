namespace Boites_Windows_1
{
    partial class VideoGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoGame));
            videoGameHeader = new Label();
            moduleImage = new PictureBox();
            durationText = new TextBox();
            durationLabel = new Label();
            finishText = new TextBox();
            dateText = new TextBox();
            startLabel = new Label();
            finishLabel = new Label();
            startText = new TextBox();
            dateLabel = new Label();
            platformLabel = new Label();
            chapterText = new TextBox();
            bookText = new TextBox();
            genreLabel = new Label();
            videoGameLabel = new Label();
            finish = new Button();
            start = new Button();
            nintendoRadio = new RadioButton();
            xBoxButton = new RadioButton();
            playStationButton = new RadioButton();
            pcButton = new RadioButton();
            platformBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)moduleImage).BeginInit();
            platformBox.SuspendLayout();
            SuspendLayout();
            // 
            // videoGameHeader
            // 
            videoGameHeader.AutoSize = true;
            videoGameHeader.Font = new Font("Retro Gaming", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            videoGameHeader.Location = new Point(12, 9);
            videoGameHeader.Name = "videoGameHeader";
            videoGameHeader.Size = new Size(255, 46);
            videoGameHeader.TabIndex = 41;
            videoGameHeader.Text = "Videogame";
            // 
            // moduleImage
            // 
            moduleImage.Image = (Image)resources.GetObject("moduleImage.Image");
            moduleImage.Location = new Point(358, 12);
            moduleImage.Name = "moduleImage";
            moduleImage.Size = new Size(82, 73);
            moduleImage.TabIndex = 49;
            moduleImage.TabStop = false;
            // 
            // durationText
            // 
            durationText.Location = new Point(121, 262);
            durationText.Name = "durationText";
            durationText.Size = new Size(98, 23);
            durationText.TabIndex = 57;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            durationLabel.Location = new Point(23, 256);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(90, 29);
            durationLabel.TabIndex = 56;
            durationLabel.Text = "Duration:";
            // 
            // finishText
            // 
            finishText.Location = new Point(89, 178);
            finishText.Name = "finishText";
            finishText.Size = new Size(130, 23);
            finishText.TabIndex = 54;
            // 
            // dateText
            // 
            dateText.Location = new Point(89, 220);
            dateText.Name = "dateText";
            dateText.Size = new Size(130, 23);
            dateText.TabIndex = 55;
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startLabel.Location = new Point(23, 133);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(62, 29);
            startLabel.TabIndex = 50;
            startLabel.Text = "Start:";
            // 
            // finishLabel
            // 
            finishLabel.AutoSize = true;
            finishLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            finishLabel.Location = new Point(19, 172);
            finishLabel.Name = "finishLabel";
            finishLabel.Size = new Size(66, 29);
            finishLabel.TabIndex = 51;
            finishLabel.Text = "Finish:";
            // 
            // startText
            // 
            startText.Location = new Point(89, 139);
            startText.Name = "startText";
            startText.Size = new Size(130, 23);
            startText.TabIndex = 53;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(28, 214);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(57, 29);
            dateLabel.TabIndex = 52;
            dateLabel.Text = "Date:";
            // 
            // platformLabel
            // 
            platformLabel.AutoSize = true;
            platformLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            platformLabel.Location = new Point(237, 247);
            platformLabel.Name = "platformLabel";
            platformLabel.Size = new Size(92, 29);
            platformLabel.TabIndex = 62;
            platformLabel.Text = "Platform:";
            // 
            // chapterText
            // 
            chapterText.Location = new Point(339, 214);
            chapterText.Name = "chapterText";
            chapterText.Size = new Size(95, 23);
            chapterText.TabIndex = 61;
            // 
            // bookText
            // 
            bookText.Location = new Point(339, 178);
            bookText.Name = "bookText";
            bookText.Size = new Size(95, 23);
            bookText.TabIndex = 60;
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            genreLabel.Location = new Point(262, 205);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(67, 29);
            genreLabel.TabIndex = 59;
            genreLabel.Text = "Genre:";
            // 
            // videoGameLabel
            // 
            videoGameLabel.AutoSize = true;
            videoGameLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            videoGameLabel.Location = new Point(222, 169);
            videoGameLabel.Name = "videoGameLabel";
            videoGameLabel.Size = new Size(111, 29);
            videoGameLabel.TabIndex = 58;
            videoGameLabel.Text = "Videogame:";
            // 
            // finish
            // 
            finish.BackColor = Color.White;
            finish.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finish.ForeColor = Color.Black;
            finish.Location = new Point(252, 374);
            finish.Name = "finish";
            finish.Size = new Size(191, 64);
            finish.TabIndex = 64;
            finish.Text = "Finish";
            finish.UseVisualStyleBackColor = false;
            // 
            // start
            // 
            start.BackColor = Color.Black;
            start.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            start.ForeColor = SystemColors.ButtonFace;
            start.Location = new Point(28, 374);
            start.Name = "start";
            start.Size = new Size(191, 64);
            start.TabIndex = 65;
            start.Text = "Start";
            start.UseVisualStyleBackColor = false;
            // 
            // nintendoRadio
            // 
            nintendoRadio.AutoSize = true;
            nintendoRadio.Location = new Point(7, 12);
            nintendoRadio.Name = "nintendoRadio";
            nintendoRadio.Size = new Size(75, 19);
            nintendoRadio.TabIndex = 66;
            nintendoRadio.TabStop = true;
            nintendoRadio.Text = "Nintendo";
            nintendoRadio.UseVisualStyleBackColor = true;
            // 
            // xBoxButton
            // 
            xBoxButton.AutoSize = true;
            xBoxButton.Location = new Point(7, 37);
            xBoxButton.Name = "xBoxButton";
            xBoxButton.Size = new Size(52, 19);
            xBoxButton.TabIndex = 67;
            xBoxButton.TabStop = true;
            xBoxButton.Text = "Xbox";
            xBoxButton.UseVisualStyleBackColor = true;
            // 
            // playStationButton
            // 
            playStationButton.AutoSize = true;
            playStationButton.Location = new Point(7, 62);
            playStationButton.Name = "playStationButton";
            playStationButton.Size = new Size(83, 19);
            playStationButton.TabIndex = 68;
            playStationButton.TabStop = true;
            playStationButton.Text = "Playstation";
            playStationButton.UseVisualStyleBackColor = true;
            // 
            // pcButton
            // 
            pcButton.AutoSize = true;
            pcButton.Location = new Point(7, 87);
            pcButton.Name = "pcButton";
            pcButton.Size = new Size(40, 19);
            pcButton.TabIndex = 69;
            pcButton.TabStop = true;
            pcButton.Text = "PC";
            pcButton.UseVisualStyleBackColor = true;
            // 
            // platformBox
            // 
            platformBox.Controls.Add(pcButton);
            platformBox.Controls.Add(playStationButton);
            platformBox.Controls.Add(xBoxButton);
            platformBox.Controls.Add(nintendoRadio);
            platformBox.Location = new Point(328, 244);
            platformBox.Name = "platformBox";
            platformBox.Size = new Size(104, 115);
            platformBox.TabIndex = 70;
            platformBox.TabStop = false;
            // 
            // VideoGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 450);
            Controls.Add(platformBox);
            Controls.Add(finish);
            Controls.Add(start);
            Controls.Add(platformLabel);
            Controls.Add(chapterText);
            Controls.Add(bookText);
            Controls.Add(genreLabel);
            Controls.Add(videoGameLabel);
            Controls.Add(durationText);
            Controls.Add(durationLabel);
            Controls.Add(finishText);
            Controls.Add(dateText);
            Controls.Add(startLabel);
            Controls.Add(finishLabel);
            Controls.Add(startText);
            Controls.Add(dateLabel);
            Controls.Add(moduleImage);
            Controls.Add(videoGameHeader);
            Name = "VideoGame";
            Text = "VideoGame";
            ((System.ComponentModel.ISupportInitialize)moduleImage).EndInit();
            platformBox.ResumeLayout(false);
            platformBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label videoGameHeader;
        private PictureBox moduleImage;
        private TextBox durationText;
        private Label durationLabel;
        private TextBox finishText;
        private TextBox dateText;
        private Label startLabel;
        private Label finishLabel;
        private TextBox startText;
        private Label dateLabel;
        private Label platformLabel;
        private TextBox chapterText;
        private TextBox bookText;
        private Label genreLabel;
        private Label videoGameLabel;
        private Button finish;
        private Button start;
        private RadioButton nintendoRadio;
        private RadioButton xBoxButton;
        private RadioButton playStationButton;
        private RadioButton pcButton;
        private GroupBox platformBox;
    }
}