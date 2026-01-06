namespace Boites_Windows_1
{
    partial class FastFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FastFood));
            ModuleHeader = new Label();
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
            bookText = new TextBox();
            brandLabel = new Label();
            dineIN = new RadioButton();
            TakeOut = new RadioButton();
            Location = new GroupBox();
            orderLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Location.SuspendLayout();
            SuspendLayout();
            // 
            // ModuleHeader
            // 
            ModuleHeader.AutoSize = true;
            ModuleHeader.Font = new Font("Retro Gaming", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ModuleHeader.Location = new Point(12, 9);
            ModuleHeader.Name = "ModuleHeader";
            ModuleHeader.Size = new Size(250, 46);
            ModuleHeader.TabIndex = 41;
            ModuleHeader.Text = "Fast Food";
            // 
            // durationText
            // 
            durationText.Location = new Point(113, 251);
            durationText.Name = "durationText";
            durationText.Size = new Size(98, 23);
            durationText.TabIndex = 55;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            durationLabel.Location = new Point(15, 245);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(90, 29);
            durationLabel.TabIndex = 54;
            durationLabel.Text = "Duration:";
            // 
            // finishText
            // 
            finishText.Location = new Point(81, 167);
            finishText.Name = "finishText";
            finishText.Size = new Size(130, 23);
            finishText.TabIndex = 52;
            // 
            // dateText
            // 
            dateText.Location = new Point(81, 209);
            dateText.Name = "dateText";
            dateText.Size = new Size(130, 23);
            dateText.TabIndex = 53;
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startLabel.Location = new Point(15, 122);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(62, 29);
            startLabel.TabIndex = 48;
            startLabel.Text = "Start:";
            // 
            // finishLabel
            // 
            finishLabel.AutoSize = true;
            finishLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            finishLabel.Location = new Point(11, 161);
            finishLabel.Name = "finishLabel";
            finishLabel.Size = new Size(66, 29);
            finishLabel.TabIndex = 49;
            finishLabel.Text = "Finish:";
            // 
            // startText
            // 
            startText.Location = new Point(81, 128);
            startText.Name = "startText";
            startText.Size = new Size(130, 23);
            startText.TabIndex = 51;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(20, 203);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(57, 29);
            dateLabel.TabIndex = 50;
            dateLabel.Text = "Date:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(361, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 73);
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // finish
            // 
            finish.BackColor = Color.Yellow;
            finish.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finish.ForeColor = Color.Black;
            finish.Location = new Point(241, 374);
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
            start.Location = new Point(11, 374);
            start.Name = "start";
            start.Size = new Size(191, 64);
            start.TabIndex = 57;
            start.Text = "Start";
            start.UseVisualStyleBackColor = false;
            // 
            // bookText
            // 
            bookText.Location = new Point(327, 128);
            bookText.Name = "bookText";
            bookText.Size = new Size(95, 23);
            bookText.TabIndex = 59;
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brandLabel.Location = new Point(253, 122);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(68, 29);
            brandLabel.TabIndex = 58;
            brandLabel.Text = "Brand:";
            // 
            // dineIN
            // 
            dineIN.AutoSize = true;
            dineIN.Font = new Font("Orange Kid", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dineIN.Location = new Point(6, 22);
            dineIN.Name = "dineIN";
            dineIN.Size = new Size(62, 23);
            dineIN.TabIndex = 60;
            dineIN.TabStop = true;
            dineIN.Text = "Dine-In";
            dineIN.UseVisualStyleBackColor = true;
            // 
            // TakeOut
            // 
            TakeOut.AutoSize = true;
            TakeOut.Font = new Font("Orange Kid", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TakeOut.Location = new Point(99, 22);
            TakeOut.Name = "TakeOut";
            TakeOut.Size = new Size(74, 23);
            TakeOut.TabIndex = 61;
            TakeOut.TabStop = true;
            TakeOut.Text = "Take Out";
            TakeOut.UseVisualStyleBackColor = true;
            // 
            // Location
            // 
            Location.Controls.Add(dineIN);
            Location.Controls.Add(TakeOut);
            Location.Location = new Point(253, 167);
            Location.Name = "Location";
            Location.Size = new Size(179, 47);
            Location.TabIndex = 62;
            Location.TabStop = false;
            Location.Text = "Location";
            // 
            // orderLabel
            // 
            orderLabel.AutoSize = true;
            orderLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderLabel.Location = new Point(253, 242);
            orderLabel.Name = "orderLabel";
            orderLabel.Size = new Size(65, 29);
            orderLabel.TabIndex = 63;
            orderLabel.Text = "Order:";
            // 
            // FastFood
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 450);
            Controls.Add(orderLabel);
            Controls.Add(Location);
            Controls.Add(bookText);
            Controls.Add(brandLabel);
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
            Controls.Add(ModuleHeader);
            Name = "FastFood";
            Text = "FastFood";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Location.ResumeLayout(false);
            Location.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ModuleHeader;
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
        private TextBox bookText;
        private Label brandLabel;
        private RadioButton dineIN;
        private RadioButton TakeOut;
        private GroupBox Location;
        private Label orderLabel;
    }
}