namespace Boites_Windows_1
{
    partial class PCBuild
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
            PCHeader = new Label();
            durationText = new TextBox();
            durationLabel = new Label();
            finishText = new TextBox();
            dateText = new TextBox();
            startLabel = new Label();
            finishLabel = new Label();
            startText = new TextBox();
            dateLabel = new Label();
            taskLabel = new Label();
            completedLabel = new Label();
            notesLabel = new Label();
            finish = new Button();
            start = new Button();
            SuspendLayout();
            // 
            // PCHeader
            // 
            PCHeader.AutoSize = true;
            PCHeader.Font = new Font("Retro Gaming", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PCHeader.Location = new Point(12, 9);
            PCHeader.Name = "PCHeader";
            PCHeader.Size = new Size(266, 46);
            PCHeader.TabIndex = 41;
            PCHeader.Text = "PC Building";
            // 
            // durationText
            // 
            durationText.Location = new Point(116, 252);
            durationText.Name = "durationText";
            durationText.Size = new Size(98, 23);
            durationText.TabIndex = 55;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            durationLabel.Location = new Point(18, 246);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(90, 29);
            durationLabel.TabIndex = 54;
            durationLabel.Text = "Duration:";
            // 
            // finishText
            // 
            finishText.Location = new Point(84, 168);
            finishText.Name = "finishText";
            finishText.Size = new Size(130, 23);
            finishText.TabIndex = 52;
            // 
            // dateText
            // 
            dateText.Location = new Point(84, 210);
            dateText.Name = "dateText";
            dateText.Size = new Size(130, 23);
            dateText.TabIndex = 53;
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startLabel.Location = new Point(18, 123);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(62, 29);
            startLabel.TabIndex = 48;
            startLabel.Text = "Start:";
            // 
            // finishLabel
            // 
            finishLabel.AutoSize = true;
            finishLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            finishLabel.Location = new Point(14, 162);
            finishLabel.Name = "finishLabel";
            finishLabel.Size = new Size(66, 29);
            finishLabel.TabIndex = 49;
            finishLabel.Text = "Finish:";
            // 
            // startText
            // 
            startText.Location = new Point(84, 129);
            startText.Name = "startText";
            startText.Size = new Size(130, 23);
            startText.TabIndex = 51;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(23, 204);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(57, 29);
            dateLabel.TabIndex = 50;
            dateLabel.Text = "Date:";
            // 
            // taskLabel
            // 
            taskLabel.AutoSize = true;
            taskLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            taskLabel.Location = new Point(256, 123);
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new Size(58, 29);
            taskLabel.TabIndex = 56;
            taskLabel.Text = "Task:";
            // 
            // completedLabel
            // 
            completedLabel.AutoSize = true;
            completedLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            completedLabel.Location = new Point(256, 162);
            completedLabel.Name = "completedLabel";
            completedLabel.Size = new Size(105, 29);
            completedLabel.TabIndex = 57;
            completedLabel.Text = "Completed:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Font = new Font("Orange Kid", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            notesLabel.Location = new Point(256, 204);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new Size(66, 29);
            notesLabel.TabIndex = 58;
            notesLabel.Text = "Notes:";
            // 
            // finish
            // 
            finish.BackColor = Color.Silver;
            finish.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finish.ForeColor = SystemColors.ControlLightLight;
            finish.Location = new Point(247, 374);
            finish.Name = "finish";
            finish.Size = new Size(191, 64);
            finish.TabIndex = 59;
            finish.Text = "Finish";
            finish.UseVisualStyleBackColor = false;
            // 
            // start
            // 
            start.BackColor = Color.FromArgb(64, 64, 64);
            start.Font = new Font("Retro Gaming", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            start.ForeColor = Color.Black;
            start.Location = new Point(23, 374);
            start.Name = "start";
            start.Size = new Size(191, 64);
            start.TabIndex = 60;
            start.Text = "Start";
            start.UseVisualStyleBackColor = false;
            // 
            // PCBuild
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 450);
            Controls.Add(finish);
            Controls.Add(start);
            Controls.Add(notesLabel);
            Controls.Add(completedLabel);
            Controls.Add(taskLabel);
            Controls.Add(durationText);
            Controls.Add(durationLabel);
            Controls.Add(finishText);
            Controls.Add(dateText);
            Controls.Add(startLabel);
            Controls.Add(finishLabel);
            Controls.Add(startText);
            Controls.Add(dateLabel);
            Controls.Add(PCHeader);
            Name = "PCBuild";
            Text = "PCBuild";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PCHeader;
        private TextBox durationText;
        private Label durationLabel;
        private TextBox finishText;
        private TextBox dateText;
        private Label startLabel;
        private Label finishLabel;
        private TextBox startText;
        private Label dateLabel;
        private Label taskLabel;
        private Label completedLabel;
        private Label notesLabel;
        private Button finish;
        private Button start;
    }
}