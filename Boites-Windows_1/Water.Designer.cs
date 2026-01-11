namespace Boites_Windows_1
{
    partial class Water
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Water));
            Header = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            dateText = new TextBox();
            cupsLabel = new Label();
            logLabel = new Label();
            logBox = new ListBox();
            record = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Retro Gaming", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Header.Location = new Point(12, 9);
            Header.Name = "Header";
            Header.Size = new Size(153, 46);
            Header.TabIndex = 41;
            Header.Text = "Water";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(171, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 82);
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(71, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 23);
            textBox1.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 119);
            label1.Name = "label1";
            label1.Size = new Size(57, 29);
            label1.TabIndex = 49;
            label1.Text = "Date:";
            // 
            // dateText
            // 
            dateText.Location = new Point(71, 154);
            dateText.Name = "dateText";
            dateText.Size = new Size(130, 23);
            dateText.TabIndex = 52;
            // 
            // cupsLabel
            // 
            cupsLabel.AutoSize = true;
            cupsLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cupsLabel.Location = new Point(10, 148);
            cupsLabel.Name = "cupsLabel";
            cupsLabel.Size = new Size(59, 29);
            cupsLabel.TabIndex = 51;
            cupsLabel.Text = "Cups:";
            // 
            // logLabel
            // 
            logLabel.AutoSize = true;
            logLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logLabel.Location = new Point(8, 177);
            logLabel.Name = "logLabel";
            logLabel.Size = new Size(46, 29);
            logLabel.TabIndex = 53;
            logLabel.Text = "Log:";
            // 
            // logBox
            // 
            logBox.FormattingEnabled = true;
            logBox.ItemHeight = 15;
            logBox.Location = new Point(71, 183);
            logBox.Name = "logBox";
            logBox.Size = new Size(120, 94);
            logBox.TabIndex = 54;
            // 
            // record
            // 
            record.BackColor = Color.CornflowerBlue;
            record.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            record.ForeColor = SystemColors.ButtonFace;
            record.Location = new Point(27, 374);
            record.Name = "record";
            record.Size = new Size(191, 64);
            record.TabIndex = 56;
            record.Text = "Record";
            record.UseVisualStyleBackColor = false;
            // 
            // Water
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 450);
            Controls.Add(record);
            Controls.Add(logBox);
            Controls.Add(logLabel);
            Controls.Add(dateText);
            Controls.Add(cupsLabel);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(Header);
            Name = "Water";
            Text = "Water";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Header;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private TextBox dateText;
        private Label cupsLabel;
        private Label logLabel;
        private ListBox logBox;
        private Button record;
    }
}