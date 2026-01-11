namespace Boites_Windows_1
{
    partial class Food
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Food));
            Header = new Label();
            durationText = new TextBox();
            durationLabel = new Label();
            finishText = new TextBox();
            dateText = new TextBox();
            startLabel = new Label();
            finishLabel = new Label();
            startText = new TextBox();
            dateLabel = new Label();
            pictureBox1 = new PictureBox();
            finish = new Button();
            start = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Retro Gaming", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Header.Location = new Point(12, 9);
            Header.Name = "Header";
            Header.Size = new Size(132, 46);
            Header.TabIndex = 41;
            Header.Text = "Food";
            // 
            // durationText
            // 
            durationText.Location = new Point(126, 250);
            durationText.Name = "durationText";
            durationText.Size = new Size(98, 23);
            durationText.TabIndex = 55;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            durationLabel.Location = new Point(0, 241);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(90, 29);
            durationLabel.TabIndex = 54;
            durationLabel.Text = "Duration:";
            // 
            // finishText
            // 
            finishText.Location = new Point(94, 166);
            finishText.Name = "finishText";
            finishText.Size = new Size(130, 23);
            finishText.TabIndex = 52;
            // 
            // dateText
            // 
            dateText.Location = new Point(94, 208);
            dateText.Name = "dateText";
            dateText.Size = new Size(130, 23);
            dateText.TabIndex = 53;
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startLabel.Location = new Point(28, 121);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(62, 29);
            startLabel.TabIndex = 48;
            startLabel.Text = "Start:";
            // 
            // finishLabel
            // 
            finishLabel.AutoSize = true;
            finishLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            finishLabel.Location = new Point(24, 160);
            finishLabel.Name = "finishLabel";
            finishLabel.Size = new Size(66, 29);
            finishLabel.TabIndex = 49;
            finishLabel.Text = "Finish:";
            // 
            // startText
            // 
            startText.Location = new Point(94, 127);
            startText.Name = "startText";
            startText.Size = new Size(130, 23);
            startText.TabIndex = 51;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(33, 202);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(57, 29);
            dateLabel.TabIndex = 50;
            dateLabel.Text = "Date:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(381, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 86);
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // finish
            // 
            finish.BackColor = Color.FromArgb(255, 128, 0);
            finish.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finish.ForeColor = SystemColors.ControlLightLight;
            finish.Location = new Point(257, 374);
            finish.Name = "finish";
            finish.Size = new Size(191, 64);
            finish.TabIndex = 56;
            finish.Text = "Finish";
            finish.UseVisualStyleBackColor = false;
            // 
            // start
            // 
            start.BackColor = Color.Red;
            start.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            start.ForeColor = SystemColors.ButtonFace;
            start.Location = new Point(33, 374);
            start.Name = "start";
            start.Size = new Size(191, 64);
            start.TabIndex = 57;
            start.Text = "Start";
            start.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(225, 121);
            label1.Name = "label1";
            label1.Size = new Size(87, 29);
            label1.TabIndex = 58;
            label1.Text = "Calories:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(318, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 23);
            textBox1.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(255, 160);
            label2.Name = "label2";
            label2.Size = new Size(57, 29);
            label2.TabIndex = 60;
            label2.Text = "Meal:";
            // 
            // Food
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(finish);
            Controls.Add(start);
            Controls.Add(pictureBox1);
            Controls.Add(durationText);
            Controls.Add(durationLabel);
            Controls.Add(finishText);
            Controls.Add(dateText);
            Controls.Add(startLabel);
            Controls.Add(finishLabel);
            Controls.Add(startText);
            Controls.Add(dateLabel);
            Controls.Add(Header);
            Name = "Food";
            Text = "Food";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Header;
        private TextBox durationText;
        private Label durationLabel;
        private TextBox finishText;
        private TextBox dateText;
        private Label startLabel;
        private Label finishLabel;
        private TextBox startText;
        private Label dateLabel;
        private PictureBox pictureBox1;
        private Button finish;
        private Button start;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
    }
}