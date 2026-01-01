namespace Boites_Windows_1
{
    partial class Beer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beer));
            beerHeader = new Label();
            finishText = new TextBox();
            startLabel = new Label();
            finishLabel = new Label();
            dateLabel = new Label();
            startText = new TextBox();
            dateText = new TextBox();
            durationLabel = new Label();
            durationText = new TextBox();
            amountText = new TextBox();
            brandLabel = new Label();
            amountLabel = new Label();
            brandText = new TextBox();
            finish = new Button();
            start = new Button();
            moduleLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)moduleLogo).BeginInit();
            SuspendLayout();
            // 
            // beerHeader
            // 
            beerHeader.AutoSize = true;
            beerHeader.Font = new Font("Retro Gaming", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            beerHeader.Location = new Point(12, 9);
            beerHeader.Name = "beerHeader";
            beerHeader.Size = new Size(129, 46);
            beerHeader.TabIndex = 60;
            beerHeader.Text = "Beer";
            // 
            // finishText
            // 
            finishText.Location = new Point(76, 195);
            finishText.Name = "finishText";
            finishText.Size = new Size(130, 23);
            finishText.TabIndex = 64;
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startLabel.Location = new Point(10, 150);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(62, 29);
            startLabel.TabIndex = 60;
            startLabel.Text = "Start:";
            // 
            // finishLabel
            // 
            finishLabel.AutoSize = true;
            finishLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            finishLabel.Location = new Point(6, 189);
            finishLabel.Name = "finishLabel";
            finishLabel.Size = new Size(66, 29);
            finishLabel.TabIndex = 61;
            finishLabel.Text = "Finish:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(15, 231);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(57, 29);
            dateLabel.TabIndex = 62;
            dateLabel.Text = "Date:";
            // 
            // startText
            // 
            startText.Location = new Point(76, 156);
            startText.Name = "startText";
            startText.Size = new Size(130, 23);
            startText.TabIndex = 63;
            // 
            // dateText
            // 
            dateText.Location = new Point(76, 237);
            dateText.Name = "dateText";
            dateText.Size = new Size(130, 23);
            dateText.TabIndex = 65;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            durationLabel.Location = new Point(10, 273);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(90, 29);
            durationLabel.TabIndex = 66;
            durationLabel.Text = "Duration:";
            // 
            // durationText
            // 
            durationText.Location = new Point(108, 279);
            durationText.Name = "durationText";
            durationText.Size = new Size(98, 23);
            durationText.TabIndex = 67;
            // 
            // amountText
            // 
            amountText.Location = new Point(324, 198);
            amountText.Name = "amountText";
            amountText.Size = new Size(95, 23);
            amountText.TabIndex = 62;
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brandLabel.Location = new Point(250, 228);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(68, 29);
            brandLabel.TabIndex = 60;
            brandLabel.Text = "Brand:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amountLabel.Location = new Point(236, 192);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(82, 29);
            amountLabel.TabIndex = 61;
            amountLabel.Text = "Amount:";
            // 
            // brandText
            // 
            brandText.Location = new Point(324, 234);
            brandText.Name = "brandText";
            brandText.Size = new Size(95, 23);
            brandText.TabIndex = 63;
            // 
            // finish
            // 
            finish.BackColor = Color.White;
            finish.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finish.ForeColor = Color.DarkOrange;
            finish.Location = new Point(228, 374);
            finish.Name = "finish";
            finish.Size = new Size(191, 64);
            finish.TabIndex = 68;
            finish.Text = "Finish";
            finish.UseVisualStyleBackColor = false;
            // 
            // start
            // 
            start.BackColor = Color.DarkOrange;
            start.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            start.ForeColor = SystemColors.ButtonFace;
            start.Location = new Point(15, 374);
            start.Name = "start";
            start.Size = new Size(191, 64);
            start.TabIndex = 69;
            start.Text = "Start";
            start.UseVisualStyleBackColor = false;
            // 
            // moduleLogo
            // 
            moduleLogo.Image = (Image)resources.GetObject("moduleLogo.Image");
            moduleLogo.InitialImage = null;
            moduleLogo.Location = new Point(337, 12);
            moduleLogo.Name = "moduleLogo";
            moduleLogo.Size = new Size(83, 86);
            moduleLogo.TabIndex = 60;
            moduleLogo.TabStop = false;
            // 
            // Beer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 450);
            Controls.Add(moduleLogo);
            Controls.Add(finish);
            Controls.Add(start);
            Controls.Add(brandText);
            Controls.Add(durationText);
            Controls.Add(amountText);
            Controls.Add(amountLabel);
            Controls.Add(beerHeader);
            Controls.Add(brandLabel);
            Controls.Add(durationLabel);
            Controls.Add(finishText);
            Controls.Add(dateText);
            Controls.Add(startLabel);
            Controls.Add(finishLabel);
            Controls.Add(startText);
            Controls.Add(dateLabel);
            Name = "Beer";
            Text = "Beer";
            ((System.ComponentModel.ISupportInitialize)moduleLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label beerHeader;
        private TextBox finishText;
        private Label startLabel;
        private Label finishLabel;
        private Label dateLabel;
        private TextBox startText;
        private TextBox dateText;
        private Label durationLabel;
        private TextBox durationText;
        private TextBox amountText;
        private Label brandLabel;
        private Label amountLabel;
        private TextBox brandText;
        private Button finish;
        private Button start;
        private PictureBox moduleLogo;
    }
}