namespace Boites_Windows_1
{
    partial class Music
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music));
            musicHeader = new Label();
            lengthText = new TextBox();
            durationLabel = new Label();
            dateText = new TextBox();
            finishText = new TextBox();
            startText = new TextBox();
            dateLabel = new Label();
            finishLabel = new Label();
            startLabel = new Label();
            artistText = new TextBox();
            artistLabel = new Label();
            genreText = new TextBox();
            genreLabel = new Label();
            recordText = new TextBox();
            recordLabel = new Label();
            musicLogo = new PictureBox();
            finish = new Button();
            start = new Button();
            ((System.ComponentModel.ISupportInitialize)musicLogo).BeginInit();
            SuspendLayout();
            // 
            // musicHeader
            // 
            musicHeader.AutoSize = true;
            musicHeader.Font = new Font("Retro Gaming", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            musicHeader.Location = new Point(12, 9);
            musicHeader.Name = "musicHeader";
            musicHeader.Size = new Size(143, 46);
            musicHeader.TabIndex = 41;
            musicHeader.Text = "Music";
            // 
            // lengthText
            // 
            lengthText.Location = new Point(77, 282);
            lengthText.Name = "lengthText";
            lengthText.Size = new Size(98, 23);
            lengthText.TabIndex = 59;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            durationLabel.Location = new Point(-2, 276);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(73, 29);
            durationLabel.TabIndex = 58;
            durationLabel.Text = "Length:";
            // 
            // dateText
            // 
            dateText.Location = new Point(75, 240);
            dateText.Name = "dateText";
            dateText.Size = new Size(100, 23);
            dateText.TabIndex = 57;
            // 
            // finishText
            // 
            finishText.Location = new Point(75, 198);
            finishText.Name = "finishText";
            finishText.Size = new Size(100, 23);
            finishText.TabIndex = 56;
            // 
            // startText
            // 
            startText.Location = new Point(75, 159);
            startText.Name = "startText";
            startText.Size = new Size(100, 23);
            startText.TabIndex = 55;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(14, 234);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(57, 29);
            dateLabel.TabIndex = 54;
            dateLabel.Text = "Date:";
            // 
            // finishLabel
            // 
            finishLabel.AutoSize = true;
            finishLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            finishLabel.Location = new Point(5, 192);
            finishLabel.Name = "finishLabel";
            finishLabel.Size = new Size(66, 29);
            finishLabel.TabIndex = 53;
            finishLabel.Text = "Finish:";
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startLabel.Location = new Point(9, 153);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(62, 29);
            startLabel.TabIndex = 52;
            startLabel.Text = "Start:";
            // 
            // artistText
            // 
            artistText.Location = new Point(274, 183);
            artistText.Name = "artistText";
            artistText.Size = new Size(95, 23);
            artistText.TabIndex = 61;
            // 
            // artistLabel
            // 
            artistLabel.AutoSize = true;
            artistLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            artistLabel.Location = new Point(200, 174);
            artistLabel.Name = "artistLabel";
            artistLabel.Size = new Size(67, 29);
            artistLabel.TabIndex = 60;
            artistLabel.Text = "Artist:";
            // 
            // genreText
            // 
            genreText.Location = new Point(274, 264);
            genreText.Name = "genreText";
            genreText.Size = new Size(95, 23);
            genreText.TabIndex = 63;
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            genreLabel.Location = new Point(201, 258);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(67, 29);
            genreLabel.TabIndex = 62;
            genreLabel.Text = "Genre:";
            // 
            // recordText
            // 
            recordText.Location = new Point(274, 222);
            recordText.Name = "recordText";
            recordText.Size = new Size(95, 23);
            recordText.TabIndex = 65;
            // 
            // recordLabel
            // 
            recordLabel.AutoSize = true;
            recordLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recordLabel.Location = new Point(190, 216);
            recordLabel.Name = "recordLabel";
            recordLabel.Size = new Size(77, 29);
            recordLabel.TabIndex = 64;
            recordLabel.Text = "Record:";
            // 
            // musicLogo
            // 
            musicLogo.Image = (Image)resources.GetObject("musicLogo.Image");
            musicLogo.InitialImage = null;
            musicLogo.Location = new Point(314, 12);
            musicLogo.Name = "musicLogo";
            musicLogo.Size = new Size(83, 86);
            musicLogo.TabIndex = 66;
            musicLogo.TabStop = false;
            // 
            // finish
            // 
            finish.BackColor = Color.RoyalBlue;
            finish.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finish.ForeColor = SystemColors.ControlLightLight;
            finish.Location = new Point(210, 374);
            finish.Name = "finish";
            finish.Size = new Size(191, 64);
            finish.TabIndex = 67;
            finish.Text = "Finish";
            finish.UseVisualStyleBackColor = false;
            // 
            // start
            // 
            start.BackColor = Color.Firebrick;
            start.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            start.ForeColor = SystemColors.ButtonFace;
            start.Location = new Point(5, 374);
            start.Name = "start";
            start.Size = new Size(191, 64);
            start.TabIndex = 68;
            start.Text = "Start";
            start.UseVisualStyleBackColor = false;
            // 
            // Music
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 450);
            Controls.Add(finish);
            Controls.Add(start);
            Controls.Add(musicLogo);
            Controls.Add(recordText);
            Controls.Add(recordLabel);
            Controls.Add(genreText);
            Controls.Add(genreLabel);
            Controls.Add(artistText);
            Controls.Add(artistLabel);
            Controls.Add(lengthText);
            Controls.Add(durationLabel);
            Controls.Add(dateText);
            Controls.Add(finishText);
            Controls.Add(startText);
            Controls.Add(dateLabel);
            Controls.Add(finishLabel);
            Controls.Add(startLabel);
            Controls.Add(musicHeader);
            Name = "Music";
            Text = "Music";
            ((System.ComponentModel.ISupportInitialize)musicLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label musicHeader;
        private TextBox lengthText;
        private Label durationLabel;
        private TextBox dateText;
        private TextBox finishText;
        private TextBox startText;
        private Label dateLabel;
        private Label finishLabel;
        private Label startLabel;
        private TextBox artistText;
        private Label artistLabel;
        private TextBox genreText;
        private Label genreLabel;
        private TextBox recordText;
        private Label recordLabel;
        private PictureBox musicLogo;
        private Button finish;
        private Button start;
    }
}