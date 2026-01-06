namespace Boites_Windows_1
{
    partial class Candy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Candy));
            CandyHeader = new Label();
            moduleLogo = new PictureBox();
            finish = new Button();
            amountText = new TextBox();
            start = new Button();
            brandText = new TextBox();
            amountLabel = new Label();
            brandLabel = new Label();
            dateText = new TextBox();
            dateLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)moduleLogo).BeginInit();
            SuspendLayout();
            // 
            // CandyHeader
            // 
            CandyHeader.AutoSize = true;
            CandyHeader.Font = new Font("Retro Gaming", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CandyHeader.Location = new Point(49, 9);
            CandyHeader.Name = "CandyHeader";
            CandyHeader.Size = new Size(160, 46);
            CandyHeader.TabIndex = 43;
            CandyHeader.Text = "Candy";
            // 
            // moduleLogo
            // 
            moduleLogo.Image = (Image)resources.GetObject("moduleLogo.Image");
            moduleLogo.Location = new Point(95, 55);
            moduleLogo.Name = "moduleLogo";
            moduleLogo.Size = new Size(74, 91);
            moduleLogo.TabIndex = 67;
            moduleLogo.TabStop = false;
            // 
            // finish
            // 
            finish.BackColor = Color.Blue;
            finish.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finish.ForeColor = Color.White;
            finish.Location = new Point(34, 372);
            finish.Name = "finish";
            finish.Size = new Size(191, 64);
            finish.TabIndex = 61;
            finish.Text = "Finish";
            finish.UseVisualStyleBackColor = false;
            // 
            // amountText
            // 
            amountText.Location = new Point(95, 247);
            amountText.Name = "amountText";
            amountText.Size = new Size(130, 23);
            amountText.TabIndex = 66;
            // 
            // start
            // 
            start.BackColor = Color.Magenta;
            start.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            start.ForeColor = SystemColors.ButtonFace;
            start.Location = new Point(34, 293);
            start.Name = "start";
            start.Size = new Size(191, 64);
            start.TabIndex = 63;
            start.Text = "Start";
            start.UseVisualStyleBackColor = false;
            // 
            // brandText
            // 
            brandText.Location = new Point(90, 209);
            brandText.Name = "brandText";
            brandText.Size = new Size(130, 23);
            brandText.TabIndex = 65;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amountLabel.Location = new Point(16, 241);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(82, 29);
            amountLabel.TabIndex = 64;
            amountLabel.Text = "Amount:";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brandLabel.Location = new Point(16, 200);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(68, 29);
            brandLabel.TabIndex = 62;
            brandLabel.Text = "Brand:";
            // 
            // dateText
            // 
            dateText.Location = new Point(90, 170);
            dateText.Name = "dateText";
            dateText.Size = new Size(130, 23);
            dateText.TabIndex = 60;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(27, 161);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(57, 29);
            dateLabel.TabIndex = 59;
            dateLabel.Text = "Date:";
            // 
            // Candy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 450);
            Controls.Add(moduleLogo);
            Controls.Add(finish);
            Controls.Add(amountText);
            Controls.Add(start);
            Controls.Add(brandText);
            Controls.Add(amountLabel);
            Controls.Add(brandLabel);
            Controls.Add(dateText);
            Controls.Add(dateLabel);
            Controls.Add(CandyHeader);
            Name = "Candy";
            Text = "Candy";
            ((System.ComponentModel.ISupportInitialize)moduleLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CandyHeader;
        private PictureBox moduleLogo;
        private Button finish;
        private TextBox amountText;
        private Button start;
        private TextBox brandText;
        private Label amountLabel;
        private Label brandLabel;
        private TextBox dateText;
        private Label dateLabel;
    }
}