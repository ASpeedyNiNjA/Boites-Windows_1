namespace Boites_Windows_1
{
    partial class Chocolate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chocolate));
            ChocolateHeader = new Label();
            dateText = new TextBox();
            dateLabel = new Label();
            brandLabel = new Label();
            amountLabel = new Label();
            brandText = new TextBox();
            amountText = new TextBox();
            finish = new Button();
            start = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ChocolateHeader
            // 
            ChocolateHeader.AutoSize = true;
            ChocolateHeader.Font = new Font("Retro Gaming", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChocolateHeader.Location = new Point(12, 9);
            ChocolateHeader.Name = "ChocolateHeader";
            ChocolateHeader.Size = new Size(252, 46);
            ChocolateHeader.TabIndex = 41;
            ChocolateHeader.Text = "Chocolate";
            // 
            // dateText
            // 
            dateText.Location = new Point(75, 170);
            dateText.Name = "dateText";
            dateText.Size = new Size(130, 23);
            dateText.TabIndex = 47;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(12, 161);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(57, 29);
            dateLabel.TabIndex = 46;
            dateLabel.Text = "Date:";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brandLabel.Location = new Point(1, 200);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(68, 29);
            brandLabel.TabIndex = 48;
            brandLabel.Text = "Brand:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amountLabel.Location = new Point(1, 241);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(82, 29);
            amountLabel.TabIndex = 49;
            amountLabel.Text = "Amount:";
            // 
            // brandText
            // 
            brandText.Location = new Point(75, 209);
            brandText.Name = "brandText";
            brandText.Size = new Size(130, 23);
            brandText.TabIndex = 50;
            // 
            // amountText
            // 
            amountText.Location = new Point(80, 247);
            amountText.Name = "amountText";
            amountText.Size = new Size(130, 23);
            amountText.TabIndex = 51;
            // 
            // finish
            // 
            finish.BackColor = Color.White;
            finish.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finish.ForeColor = Color.SaddleBrown;
            finish.Location = new Point(50, 374);
            finish.Name = "finish";
            finish.Size = new Size(191, 64);
            finish.TabIndex = 52;
            finish.Text = "Finish";
            finish.UseVisualStyleBackColor = false;
            // 
            // start
            // 
            start.BackColor = Color.SaddleBrown;
            start.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            start.ForeColor = SystemColors.ButtonFace;
            start.Location = new Point(50, 295);
            start.Name = "start";
            start.Size = new Size(191, 64);
            start.TabIndex = 53;
            start.Text = "Start";
            start.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 91);
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // Chocolate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 450);
            Controls.Add(pictureBox1);
            Controls.Add(finish);
            Controls.Add(start);
            Controls.Add(amountText);
            Controls.Add(brandText);
            Controls.Add(amountLabel);
            Controls.Add(brandLabel);
            Controls.Add(dateText);
            Controls.Add(dateLabel);
            Controls.Add(ChocolateHeader);
            Name = "Chocolate";
            Text = "Chocolate";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ChocolateHeader;
        private TextBox dateText;
        private Label dateLabel;
        private Label brandLabel;
        private Label amountLabel;
        private TextBox brandText;
        private TextBox amountText;
        private Button finish;
        private Button start;
        private PictureBox pictureBox1;
    }
}