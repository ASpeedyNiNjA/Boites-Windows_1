namespace Boites_Windows_1
{
    partial class Wine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wine));
            WineHeader = new Label();
            amountText = new TextBox();
            brandText = new TextBox();
            amountLabel = new Label();
            brandLabel = new Label();
            dateText = new TextBox();
            dateLabel = new Label();
            start = new Button();
            finish = new Button();
            moduleLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)moduleLogo).BeginInit();
            SuspendLayout();
            // 
            // WineHeader
            // 
            WineHeader.AutoSize = true;
            WineHeader.Font = new Font("Retro Gaming", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WineHeader.Location = new Point(82, 9);
            WineHeader.Name = "WineHeader";
            WineHeader.Size = new Size(118, 46);
            WineHeader.TabIndex = 42;
            WineHeader.Text = "Wine";
            // 
            // amountText
            // 
            amountText.Location = new Point(99, 250);
            amountText.Name = "amountText";
            amountText.Size = new Size(130, 23);
            amountText.TabIndex = 57;
            // 
            // brandText
            // 
            brandText.Location = new Point(94, 212);
            brandText.Name = "brandText";
            brandText.Size = new Size(130, 23);
            brandText.TabIndex = 56;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amountLabel.Location = new Point(20, 244);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(82, 29);
            amountLabel.TabIndex = 55;
            amountLabel.Text = "Amount:";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brandLabel.Location = new Point(20, 203);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(68, 29);
            brandLabel.TabIndex = 54;
            brandLabel.Text = "Brand:";
            // 
            // dateText
            // 
            dateText.Location = new Point(94, 173);
            dateText.Name = "dateText";
            dateText.Size = new Size(130, 23);
            dateText.TabIndex = 53;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(31, 164);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(57, 29);
            dateLabel.TabIndex = 52;
            dateLabel.Text = "Date:";
            // 
            // start
            // 
            start.BackColor = Color.Crimson;
            start.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            start.ForeColor = SystemColors.ButtonFace;
            start.Location = new Point(38, 296);
            start.Name = "start";
            start.Size = new Size(191, 64);
            start.TabIndex = 55;
            start.Text = "Start";
            start.UseVisualStyleBackColor = false;
            // 
            // finish
            // 
            finish.BackColor = Color.White;
            finish.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finish.ForeColor = Color.Crimson;
            finish.Location = new Point(38, 375);
            finish.Name = "finish";
            finish.Size = new Size(191, 64);
            finish.TabIndex = 54;
            finish.Text = "Finish";
            finish.UseVisualStyleBackColor = false;
            // 
            // moduleLogo
            // 
            moduleLogo.Image = (Image)resources.GetObject("moduleLogo.Image");
            moduleLogo.Location = new Point(99, 58);
            moduleLogo.Name = "moduleLogo";
            moduleLogo.Size = new Size(74, 91);
            moduleLogo.TabIndex = 58;
            moduleLogo.TabStop = false;
            // 
            // Wine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 450);
            Controls.Add(moduleLogo);
            Controls.Add(finish);
            Controls.Add(amountText);
            Controls.Add(start);
            Controls.Add(brandText);
            Controls.Add(amountLabel);
            Controls.Add(brandLabel);
            Controls.Add(dateText);
            Controls.Add(dateLabel);
            Controls.Add(WineHeader);
            Name = "Wine";
            Text = "Wine";
            ((System.ComponentModel.ISupportInitialize)moduleLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WineHeader;
        private TextBox amountText;
        private TextBox brandText;
        private Label amountLabel;
        private Label brandLabel;
        private TextBox dateText;
        private Label dateLabel;
        private Button start;
        private Button finish;
        private PictureBox moduleLogo;
    }
}