namespace Boites_Windows_1
{
    partial class Teeth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teeth));
            Header_Teeth = new Label();
            brush = new CheckBox();
            floss = new CheckBox();
            mouthwash = new CheckBox();
            TestBox = new TextBox();
            startLabel = new Label();
            endLabel = new Label();
            startTime = new TextBox();
            endTime = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Header_Teeth
            // 
            Header_Teeth.AutoSize = true;
            Header_Teeth.Font = new Font("Retro Gaming", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Header_Teeth.Location = new Point(12, 12);
            Header_Teeth.Name = "Header_Teeth";
            Header_Teeth.Size = new Size(158, 47);
            Header_Teeth.TabIndex = 0;
            Header_Teeth.Text = "Teeth";
            // 
            // brush
            // 
            brush.AutoSize = true;
            brush.Font = new Font("Orange Kid", 15.7499981F);
            brush.Location = new Point(24, 163);
            brush.Name = "brush";
            brush.Size = new Size(71, 29);
            brush.TabIndex = 4;
            brush.Text = "Brush";
            brush.UseVisualStyleBackColor = true;
            brush.CheckedChanged += brush_CheckedChanged;
            // 
            // floss
            // 
            floss.AutoSize = true;
            floss.Font = new Font("Orange Kid", 15.7499981F);
            floss.Location = new Point(24, 188);
            floss.Name = "floss";
            floss.Size = new Size(66, 29);
            floss.TabIndex = 5;
            floss.Text = "Floss";
            floss.UseVisualStyleBackColor = true;
            floss.CheckedChanged += floss_CheckedChanged;
            // 
            // mouthwash
            // 
            mouthwash.AutoSize = true;
            mouthwash.Font = new Font("Orange Kid", 15.7499981F);
            mouthwash.Location = new Point(24, 213);
            mouthwash.Name = "mouthwash";
            mouthwash.Size = new Size(111, 29);
            mouthwash.TabIndex = 6;
            mouthwash.Text = "Mouthwash";
            mouthwash.UseVisualStyleBackColor = true;
            mouthwash.CheckedChanged += mouthwash_CheckedChanged;
            // 
            // TestBox
            // 
            TestBox.Location = new Point(188, 188);
            TestBox.Name = "TestBox";
            TestBox.ReadOnly = true;
            TestBox.Size = new Size(345, 23);
            TestBox.TabIndex = 7;
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Font = new Font("Orange Kid", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startLabel.Location = new Point(11, 113);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(51, 24);
            startLabel.TabIndex = 8;
            startLabel.Text = "Start:";
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.Font = new Font("Orange Kid", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            endLabel.Location = new Point(24, 302);
            endLabel.Name = "endLabel";
            endLabel.Size = new Size(38, 24);
            endLabel.TabIndex = 9;
            endLabel.Text = "End:";
            // 
            // startTime
            // 
            startTime.Location = new Point(68, 113);
            startTime.Name = "startTime";
            startTime.Size = new Size(100, 23);
            startTime.TabIndex = 10;
            // 
            // endTime
            // 
            endTime.Location = new Point(68, 302);
            endTime.Name = "endTime";
            endTime.Size = new Size(100, 23);
            endTime.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(188, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 81);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Teeth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 362);
            Controls.Add(pictureBox1);
            Controls.Add(endTime);
            Controls.Add(startTime);
            Controls.Add(endLabel);
            Controls.Add(startLabel);
            Controls.Add(TestBox);
            Controls.Add(mouthwash);
            Controls.Add(floss);
            Controls.Add(brush);
            Controls.Add(Header_Teeth);
            Name = "Teeth";
            Text = "Teeth";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Header_Teeth;
        private CheckBox brush;
        private CheckBox floss;
        private CheckBox mouthwash;
        private TextBox TestBox;
        private Label startLabel;
        private Label endLabel;
        private TextBox startTime;
        private TextBox endTime;
        private PictureBox pictureBox1;
    }
}