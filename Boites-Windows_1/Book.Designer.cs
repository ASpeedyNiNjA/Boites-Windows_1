namespace Boites_Windows_1
{
    partial class Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            Header = new Label();
            finishText = new TextBox();
            startLabel = new Label();
            finishLabel = new Label();
            dateLabel = new Label();
            startText = new TextBox();
            dateText = new TextBox();
            durationLabel = new Label();
            durationText = new TextBox();
            chapterText = new TextBox();
            bookLabel = new Label();
            chapterLabel = new Label();
            bookText = new TextBox();
            pageLabel = new Label();
            pageText = new TextBox();
            start = new Button();
            finish = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Retro Gaming", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Header.Location = new Point(12, 9);
            Header.Name = "Header";
            Header.Size = new Size(129, 46);
            Header.TabIndex = 40;
            Header.Text = "Book";
            // 
            // finishText
            // 
            finishText.Location = new Point(86, 184);
            finishText.Name = "finishText";
            finishText.Size = new Size(130, 23);
            finishText.TabIndex = 44;
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startLabel.Location = new Point(20, 139);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(62, 29);
            startLabel.TabIndex = 40;
            startLabel.Text = "Start:";
            // 
            // finishLabel
            // 
            finishLabel.AutoSize = true;
            finishLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            finishLabel.Location = new Point(16, 178);
            finishLabel.Name = "finishLabel";
            finishLabel.Size = new Size(66, 29);
            finishLabel.TabIndex = 41;
            finishLabel.Text = "Finish:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(25, 220);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(57, 29);
            dateLabel.TabIndex = 42;
            dateLabel.Text = "Date:";
            // 
            // startText
            // 
            startText.Location = new Point(86, 145);
            startText.Name = "startText";
            startText.Size = new Size(130, 23);
            startText.TabIndex = 43;
            // 
            // dateText
            // 
            dateText.Location = new Point(86, 226);
            dateText.Name = "dateText";
            dateText.Size = new Size(130, 23);
            dateText.TabIndex = 45;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            durationLabel.Location = new Point(20, 262);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(90, 29);
            durationLabel.TabIndex = 46;
            durationLabel.Text = "Duration:";
            // 
            // durationText
            // 
            durationText.Location = new Point(118, 268);
            durationText.Name = "durationText";
            durationText.Size = new Size(98, 23);
            durationText.TabIndex = 47;
            // 
            // chapterText
            // 
            chapterText.Location = new Point(327, 203);
            chapterText.Name = "chapterText";
            chapterText.Size = new Size(95, 23);
            chapterText.TabIndex = 43;
            // 
            // bookLabel
            // 
            bookLabel.AutoSize = true;
            bookLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookLabel.Location = new Point(258, 158);
            bookLabel.Name = "bookLabel";
            bookLabel.Size = new Size(59, 29);
            bookLabel.TabIndex = 40;
            bookLabel.Text = "Book:";
            // 
            // chapterLabel
            // 
            chapterLabel.AutoSize = true;
            chapterLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chapterLabel.Location = new Point(222, 194);
            chapterLabel.Name = "chapterLabel";
            chapterLabel.Size = new Size(95, 29);
            chapterLabel.TabIndex = 41;
            chapterLabel.Text = "Chapters:";
            // 
            // bookText
            // 
            bookText.Location = new Point(327, 167);
            bookText.Name = "bookText";
            bookText.Size = new Size(95, 23);
            bookText.TabIndex = 42;
            // 
            // pageLabel
            // 
            pageLabel.AutoSize = true;
            pageLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pageLabel.Location = new Point(247, 236);
            pageLabel.Name = "pageLabel";
            pageLabel.Size = new Size(70, 29);
            pageLabel.TabIndex = 44;
            pageLabel.Text = "Pages:";
            // 
            // pageText
            // 
            pageText.Location = new Point(327, 242);
            pageText.Name = "pageText";
            pageText.Size = new Size(95, 23);
            pageText.TabIndex = 45;
            // 
            // start
            // 
            start.BackColor = Color.FromArgb(45, 62, 98);
            start.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            start.ForeColor = SystemColors.ButtonFace;
            start.Location = new Point(12, 374);
            start.Name = "start";
            start.Size = new Size(191, 64);
            start.TabIndex = 40;
            start.Text = "Start";
            start.UseVisualStyleBackColor = false;
            // 
            // finish
            // 
            finish.BackColor = Color.FromArgb(128, 32, 48);
            finish.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finish.ForeColor = SystemColors.ControlLightLight;
            finish.Location = new Point(236, 374);
            finish.Name = "finish";
            finish.Size = new Size(191, 64);
            finish.TabIndex = 40;
            finish.Text = "Finish";
            finish.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(361, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 73);
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // Book
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 450);
            Controls.Add(pictureBox1);
            Controls.Add(finish);
            Controls.Add(start);
            Controls.Add(durationText);
            Controls.Add(Header);
            Controls.Add(pageText);
            Controls.Add(durationLabel);
            Controls.Add(pageLabel);
            Controls.Add(finishText);
            Controls.Add(chapterText);
            Controls.Add(bookText);
            Controls.Add(dateText);
            Controls.Add(chapterLabel);
            Controls.Add(startLabel);
            Controls.Add(bookLabel);
            Controls.Add(finishLabel);
            Controls.Add(startText);
            Controls.Add(dateLabel);
            Name = "Book";
            Text = "Book";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Header;
        private TextBox finishText;
        private Label startLabel;
        private Label finishLabel;
        private Label dateLabel;
        private TextBox startText;
        private TextBox dateText;
        private Label durationLabel;
        private TextBox durationText;
        private TextBox chapterText;
        private Label bookLabel;
        private Label chapterLabel;
        private TextBox bookText;
        private Label pageLabel;
        private TextBox pageText;
        private Button start;
        private Button finish;
        private PictureBox pictureBox1;
    }
}