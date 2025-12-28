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
            Header_Teeth = new Label();
            brush = new CheckBox();
            floss = new CheckBox();
            mouthwash = new CheckBox();
            TestBox = new TextBox();
            SuspendLayout();
            // 
            // Header_Teeth
            // 
            Header_Teeth.AutoSize = true;
            Header_Teeth.Font = new Font("Retro Gaming", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Header_Teeth.Location = new Point(24, 16);
            Header_Teeth.Name = "Header_Teeth";
            Header_Teeth.Size = new Size(158, 47);
            Header_Teeth.TabIndex = 0;
            Header_Teeth.Text = "Teeth";
            // 
            // brush
            // 
            brush.AutoSize = true;
            brush.Font = new Font("Orange Kid", 15.7499981F);
            brush.Location = new Point(24, 353);
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
            floss.Location = new Point(24, 378);
            floss.Name = "floss";
            floss.Size = new Size(66, 29);
            floss.TabIndex = 5;
            floss.Text = "Floss";
            floss.UseVisualStyleBackColor = true;
            // 
            // mouthwash
            // 
            mouthwash.AutoSize = true;
            mouthwash.Font = new Font("Orange Kid", 15.7499981F);
            mouthwash.Location = new Point(24, 403);
            mouthwash.Name = "mouthwash";
            mouthwash.Size = new Size(111, 29);
            mouthwash.TabIndex = 6;
            mouthwash.Text = "Mouthwash";
            mouthwash.UseVisualStyleBackColor = true;
            // 
            // TestBox
            // 
            TestBox.Location = new Point(295, 277);
            TestBox.Name = "TestBox";
            TestBox.ReadOnly = true;
            TestBox.Size = new Size(345, 23);
            TestBox.TabIndex = 7;
            // 
            // Teeth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TestBox);
            Controls.Add(mouthwash);
            Controls.Add(floss);
            Controls.Add(brush);
            Controls.Add(Header_Teeth);
            Name = "Teeth";
            Text = "Teeth";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Header_Teeth;
        private CheckBox brush;
        private CheckBox floss;
        private CheckBox mouthwash;
        private TextBox TestBox;
    }
}