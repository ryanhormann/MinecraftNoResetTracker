namespace MinecraftNoResetTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.runTimeLabel = new System.Windows.Forms.Label();
            this.runTimeTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.modifyRunsGroupBox = new System.Windows.Forms.GroupBox();
            this.runsListBox = new System.Windows.Forms.ListBox();
            this.runsTotalLabel = new System.Windows.Forms.Label();
            this.runsTotalOutputLabel = new System.Windows.Forms.Label();
            this.averageTimeLabel = new System.Windows.Forms.Label();
            this.averageTimeOutputLabel = new System.Windows.Forms.Label();
            this.modifyRunsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // runTimeLabel
            // 
            this.runTimeLabel.AutoSize = true;
            this.runTimeLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.runTimeLabel.Location = new System.Drawing.Point(13, 64);
            this.runTimeLabel.Name = "runTimeLabel";
            this.runTimeLabel.Size = new System.Drawing.Size(109, 23);
            this.runTimeLabel.TabIndex = 0;
            this.runTimeLabel.Text = "Run Time:";
            // 
            // runTimeTextBox
            // 
            this.runTimeTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.runTimeTextBox.Location = new System.Drawing.Point(128, 61);
            this.runTimeTextBox.Name = "runTimeTextBox";
            this.runTimeTextBox.PlaceholderText = "hh:mm:ss";
            this.runTimeTextBox.Size = new System.Drawing.Size(109, 31);
            this.runTimeTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(13, 110);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(109, 36);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeButton.Location = new System.Drawing.Point(128, 110);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(109, 36);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // modifyRunsGroupBox
            // 
            this.modifyRunsGroupBox.Controls.Add(this.addButton);
            this.modifyRunsGroupBox.Controls.Add(this.runTimeLabel);
            this.modifyRunsGroupBox.Controls.Add(this.removeButton);
            this.modifyRunsGroupBox.Controls.Add(this.runTimeTextBox);
            this.modifyRunsGroupBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modifyRunsGroupBox.Location = new System.Drawing.Point(39, 19);
            this.modifyRunsGroupBox.Name = "modifyRunsGroupBox";
            this.modifyRunsGroupBox.Size = new System.Drawing.Size(250, 206);
            this.modifyRunsGroupBox.TabIndex = 0;
            this.modifyRunsGroupBox.TabStop = false;
            this.modifyRunsGroupBox.Text = "Modify Runs";
            // 
            // runsListBox
            // 
            this.runsListBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.runsListBox.FormattingEnabled = true;
            this.runsListBox.ItemHeight = 23;
            this.runsListBox.Location = new System.Drawing.Point(315, 28);
            this.runsListBox.Name = "runsListBox";
            this.runsListBox.Size = new System.Drawing.Size(122, 188);
            this.runsListBox.TabIndex = 1;
            // 
            // runsTotalLabel
            // 
            this.runsTotalLabel.AutoSize = true;
            this.runsTotalLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.runsTotalLabel.Location = new System.Drawing.Point(129, 244);
            this.runsTotalLabel.Name = "runsTotalLabel";
            this.runsTotalLabel.Size = new System.Drawing.Size(131, 23);
            this.runsTotalLabel.TabIndex = 2;
            this.runsTotalLabel.Text = "Total Runs:";
            // 
            // runsTotalOutputLabel
            // 
            this.runsTotalOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.runsTotalOutputLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.runsTotalOutputLabel.Location = new System.Drawing.Point(266, 243);
            this.runsTotalOutputLabel.Name = "runsTotalOutputLabel";
            this.runsTotalOutputLabel.Size = new System.Drawing.Size(107, 25);
            this.runsTotalOutputLabel.TabIndex = 3;
            this.runsTotalOutputLabel.Text = "0\r\n";
            this.runsTotalOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageTimeLabel
            // 
            this.averageTimeLabel.AutoSize = true;
            this.averageTimeLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.averageTimeLabel.Location = new System.Drawing.Point(107, 284);
            this.averageTimeLabel.Name = "averageTimeLabel";
            this.averageTimeLabel.Size = new System.Drawing.Size(153, 23);
            this.averageTimeLabel.TabIndex = 4;
            this.averageTimeLabel.Text = "Average Time:";
            // 
            // averageTimeOutputLabel
            // 
            this.averageTimeOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageTimeOutputLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.averageTimeOutputLabel.Location = new System.Drawing.Point(266, 283);
            this.averageTimeOutputLabel.Name = "averageTimeOutputLabel";
            this.averageTimeOutputLabel.Size = new System.Drawing.Size(107, 25);
            this.averageTimeOutputLabel.TabIndex = 5;
            this.averageTimeOutputLabel.Text = "00:00:00";
            this.averageTimeOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 326);
            this.Controls.Add(this.averageTimeOutputLabel);
            this.Controls.Add(this.averageTimeLabel);
            this.Controls.Add(this.runsTotalOutputLabel);
            this.Controls.Add(this.runsTotalLabel);
            this.Controls.Add(this.runsListBox);
            this.Controls.Add(this.modifyRunsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Minecraft No Reset Tracker";
            this.modifyRunsGroupBox.ResumeLayout(false);
            this.modifyRunsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label runTimeLabel;
        private TextBox runTimeTextBox;
        private Button addButton;
        private Button removeButton;
        private GroupBox modifyRunsGroupBox;
        private ListBox runsListBox;
        private Label runsTotalLabel;
        private Label runsTotalOutputLabel;
        private Label averageTimeLabel;
        private Label averageTimeOutputLabel;
    }
}