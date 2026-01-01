namespace Boites_Windows_1
{
    partial class Movie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movie));
            finish = new Button();
            start = new Button();
            moduleImage = new PictureBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            genreLabel = new Label();
            movieLabel = new Label();
            textBox10 = new TextBox();
            durationLabel = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dateLabel = new Label();
            finishLabel = new Label();
            startLabel = new Label();
            movieHeader = new Label();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            venueBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)moduleImage).BeginInit();
            venueBox.SuspendLayout();
            SuspendLayout();
            // 
            // finish
            // 
            finish.BackColor = Color.DodgerBlue;
            finish.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finish.ForeColor = SystemColors.ControlLightLight;
            finish.Location = new Point(212, 374);
            finish.Name = "finish";
            finish.Size = new Size(191, 64);
            finish.TabIndex = 42;
            finish.Text = "Finish";
            finish.UseVisualStyleBackColor = false;
            // 
            // start
            // 
            start.BackColor = Color.Orange;
            start.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            start.ForeColor = SystemColors.ButtonFace;
            start.Location = new Point(7, 374);
            start.Name = "start";
            start.Size = new Size(191, 64);
            start.TabIndex = 43;
            start.Text = "Start";
            start.UseVisualStyleBackColor = false;
            // 
            // moduleImage
            // 
            moduleImage.Image = (Image)resources.GetObject("moduleImage.Image");
            moduleImage.InitialImage = null;
            moduleImage.Location = new Point(320, 9);
            moduleImage.Name = "moduleImage";
            moduleImage.Size = new Size(83, 86);
            moduleImage.TabIndex = 44;
            moduleImage.TabStop = false;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(297, 201);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(95, 23);
            textBox9.TabIndex = 55;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(297, 165);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(95, 23);
            textBox8.TabIndex = 54;
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            genreLabel.Location = new Point(224, 195);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(67, 29);
            genreLabel.TabIndex = 53;
            genreLabel.Text = "Genre:";
            // 
            // movieLabel
            // 
            movieLabel.AutoSize = true;
            movieLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            movieLabel.Location = new Point(223, 156);
            movieLabel.Name = "movieLabel";
            movieLabel.Size = new Size(68, 29);
            movieLabel.TabIndex = 52;
            movieLabel.Text = "Movie:";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(109, 282);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(98, 23);
            textBox10.TabIndex = 51;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            durationLabel.Location = new Point(11, 276);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(90, 29);
            durationLabel.TabIndex = 50;
            durationLabel.Text = "Duration:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(77, 240);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(130, 23);
            textBox3.TabIndex = 49;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(77, 198);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(130, 23);
            textBox2.TabIndex = 48;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 23);
            textBox1.TabIndex = 47;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(16, 234);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(57, 29);
            dateLabel.TabIndex = 46;
            dateLabel.Text = "Date:";
            // 
            // finishLabel
            // 
            finishLabel.AutoSize = true;
            finishLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            finishLabel.Location = new Point(7, 192);
            finishLabel.Name = "finishLabel";
            finishLabel.Size = new Size(66, 29);
            finishLabel.TabIndex = 45;
            finishLabel.Text = "Finish:";
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startLabel.Location = new Point(11, 153);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(62, 29);
            startLabel.TabIndex = 41;
            startLabel.Text = "Start:";
            // 
            // movieHeader
            // 
            movieHeader.AutoSize = true;
            movieHeader.Font = new Font("Retro Gaming", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieHeader.Location = new Point(12, 9);
            movieHeader.Name = "movieHeader";
            movieHeader.Size = new Size(143, 46);
            movieHeader.TabIndex = 40;
            movieHeader.Text = "Movie";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(224, 240);
            label1.Name = "label1";
            label1.Size = new Size(70, 29);
            label1.TabIndex = 56;
            label1.Text = "Venue:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(14, 11);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(58, 19);
            radioButton1.TabIndex = 57;
            radioButton1.TabStop = true;
            radioButton1.Text = "Home";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(14, 38);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(64, 19);
            radioButton2.TabIndex = 58;
            radioButton2.TabStop = true;
            radioButton2.Text = "Theatre";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // venueBox
            // 
            venueBox.Controls.Add(radioButton2);
            venueBox.Controls.Add(radioButton1);
            venueBox.Location = new Point(297, 229);
            venueBox.Name = "venueBox";
            venueBox.Size = new Size(97, 64);
            venueBox.TabIndex = 59;
            venueBox.TabStop = false;
            // 
            // Movie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 450);
            Controls.Add(venueBox);
            Controls.Add(label1);
            Controls.Add(finish);
            Controls.Add(start);
            Controls.Add(moduleImage);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(genreLabel);
            Controls.Add(movieLabel);
            Controls.Add(textBox10);
            Controls.Add(durationLabel);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dateLabel);
            Controls.Add(finishLabel);
            Controls.Add(startLabel);
            Controls.Add(movieHeader);
            Name = "Movie";
            Text = "Movie";
            ((System.ComponentModel.ISupportInitialize)moduleImage).EndInit();
            venueBox.ResumeLayout(false);
            venueBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button finish;
        private Button start;
        private PictureBox moduleImage;
        private TextBox textBox9;
        private TextBox textBox8;
        private Label genreLabel;
        private Label movieLabel;
        private TextBox textBox10;
        private Label durationLabel;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label dateLabel;
        private Label finishLabel;
        private Label startLabel;
        private Label movieHeader;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox venueBox;
    }
}