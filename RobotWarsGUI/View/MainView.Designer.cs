namespace RobotWarsGUI.View
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.LeftBottomPanel = new System.Windows.Forms.Panel();
            this.StartWarButton = new System.Windows.Forms.Button();
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.ChooseAFileLabel = new System.Windows.Forms.Label();
            this.Reset2Button = new System.Windows.Forms.Button();
            this.Commands2 = new System.Windows.Forms.RichTextBox();
            this.M2Button = new System.Windows.Forms.Button();
            this.R2Button = new System.Windows.Forms.Button();
            this.L2Button = new System.Windows.Forms.Button();
            this.Commands2Label = new System.Windows.Forms.Label();
            this.Direction2 = new System.Windows.Forms.ComboBox();
            this.Direction2Label = new System.Windows.Forms.Label();
            this.Y2 = new System.Windows.Forms.ComboBox();
            this.Y2Label = new System.Windows.Forms.Label();
            this.X2 = new System.Windows.Forms.ComboBox();
            this.X2Label = new System.Windows.Forms.Label();
            this.Robot2Label = new System.Windows.Forms.Label();
            this.Reset1Button = new System.Windows.Forms.Button();
            this.Commands1 = new System.Windows.Forms.RichTextBox();
            this.M1Button = new System.Windows.Forms.Button();
            this.R1Button = new System.Windows.Forms.Button();
            this.CommandLabel1 = new System.Windows.Forms.Label();
            this.L1Button = new System.Windows.Forms.Button();
            this.Direction1 = new System.Windows.Forms.ComboBox();
            this.Direction1Label = new System.Windows.Forms.Label();
            this.Y1 = new System.Windows.Forms.ComboBox();
            this.Y1Label = new System.Windows.Forms.Label();
            this.X1 = new System.Windows.Forms.ComboBox();
            this.X1Label = new System.Windows.Forms.Label();
            this.Robot1Label = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.ComboBox();
            this.Height = new System.Windows.Forms.ComboBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.MapSizeLabel = new System.Windows.Forms.Label();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.LeftPanel.SuspendLayout();
            this.LeftBottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.AutoScroll = true;
            this.LeftPanel.BackColor = System.Drawing.Color.DarkGray;
            this.LeftPanel.Controls.Add(this.LeftBottomPanel);
            this.LeftPanel.Controls.Add(this.FileTextBox);
            this.LeftPanel.Controls.Add(this.BrowseButton);
            this.LeftPanel.Controls.Add(this.ChooseAFileLabel);
            this.LeftPanel.Controls.Add(this.Reset2Button);
            this.LeftPanel.Controls.Add(this.Commands2);
            this.LeftPanel.Controls.Add(this.M2Button);
            this.LeftPanel.Controls.Add(this.R2Button);
            this.LeftPanel.Controls.Add(this.L2Button);
            this.LeftPanel.Controls.Add(this.Commands2Label);
            this.LeftPanel.Controls.Add(this.Direction2);
            this.LeftPanel.Controls.Add(this.Direction2Label);
            this.LeftPanel.Controls.Add(this.Y2);
            this.LeftPanel.Controls.Add(this.Y2Label);
            this.LeftPanel.Controls.Add(this.X2);
            this.LeftPanel.Controls.Add(this.X2Label);
            this.LeftPanel.Controls.Add(this.Robot2Label);
            this.LeftPanel.Controls.Add(this.Reset1Button);
            this.LeftPanel.Controls.Add(this.Commands1);
            this.LeftPanel.Controls.Add(this.M1Button);
            this.LeftPanel.Controls.Add(this.R1Button);
            this.LeftPanel.Controls.Add(this.CommandLabel1);
            this.LeftPanel.Controls.Add(this.L1Button);
            this.LeftPanel.Controls.Add(this.Direction1);
            this.LeftPanel.Controls.Add(this.Direction1Label);
            this.LeftPanel.Controls.Add(this.Y1);
            this.LeftPanel.Controls.Add(this.Y1Label);
            this.LeftPanel.Controls.Add(this.X1);
            this.LeftPanel.Controls.Add(this.X1Label);
            this.LeftPanel.Controls.Add(this.Robot1Label);
            this.LeftPanel.Controls.Add(this.Width);
            this.LeftPanel.Controls.Add(this.Height);
            this.LeftPanel.Controls.Add(this.WidthLabel);
            this.LeftPanel.Controls.Add(this.HeightLabel);
            this.LeftPanel.Controls.Add(this.MapSizeLabel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(299, 806);
            this.LeftPanel.TabIndex = 0;
            // 
            // LeftBottomPanel
            // 
            this.LeftBottomPanel.BackColor = System.Drawing.Color.DarkGray;
            this.LeftBottomPanel.Controls.Add(this.StartWarButton);
            this.LeftBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LeftBottomPanel.Location = new System.Drawing.Point(0, 749);
            this.LeftBottomPanel.Name = "LeftBottomPanel";
            this.LeftBottomPanel.Size = new System.Drawing.Size(299, 57);
            this.LeftBottomPanel.TabIndex = 34;
            // 
            // StartWarButton
            // 
            this.StartWarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.StartWarButton.ForeColor = System.Drawing.Color.Red;
            this.StartWarButton.Location = new System.Drawing.Point(19, 6);
            this.StartWarButton.Name = "StartWarButton";
            this.StartWarButton.Size = new System.Drawing.Size(265, 42);
            this.StartWarButton.TabIndex = 0;
            this.StartWarButton.Text = "Start War";
            this.StartWarButton.UseVisualStyleBackColor = true;
            this.StartWarButton.Click += new System.EventHandler(this.StartWarButton_Click);
            // 
            // FileTextBox
            // 
            this.FileTextBox.Location = new System.Drawing.Point(17, 710);
            this.FileTextBox.Multiline = true;
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.ReadOnly = true;
            this.FileTextBox.Size = new System.Drawing.Size(267, 25);
            this.FileTextBox.TabIndex = 33;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(17, 672);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(83, 32);
            this.BrowseButton.TabIndex = 1;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // ChooseAFileLabel
            // 
            this.ChooseAFileLabel.AutoSize = true;
            this.ChooseAFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseAFileLabel.Location = new System.Drawing.Point(14, 632);
            this.ChooseAFileLabel.Name = "ChooseAFileLabel";
            this.ChooseAFileLabel.Size = new System.Drawing.Size(126, 25);
            this.ChooseAFileLabel.TabIndex = 1;
            this.ChooseAFileLabel.Text = "Choose a file";
            // 
            // Reset2Button
            // 
            this.Reset2Button.Location = new System.Drawing.Point(104, 586);
            this.Reset2Button.Name = "Reset2Button";
            this.Reset2Button.Size = new System.Drawing.Size(67, 28);
            this.Reset2Button.TabIndex = 32;
            this.Reset2Button.Text = "Reset";
            this.Reset2Button.UseVisualStyleBackColor = true;
            this.Reset2Button.Click += new System.EventHandler(this.Reset2Button_Click);
            // 
            // Commands2
            // 
            this.Commands2.Location = new System.Drawing.Point(17, 527);
            this.Commands2.Name = "Commands2";
            this.Commands2.ReadOnly = true;
            this.Commands2.Size = new System.Drawing.Size(267, 53);
            this.Commands2.TabIndex = 30;
            this.Commands2.Text = "";
            // 
            // M2Button
            // 
            this.M2Button.Location = new System.Drawing.Point(190, 493);
            this.M2Button.Name = "M2Button";
            this.M2Button.Size = new System.Drawing.Size(57, 28);
            this.M2Button.TabIndex = 29;
            this.M2Button.Text = "Move";
            this.M2Button.UseVisualStyleBackColor = true;
            this.M2Button.Click += new System.EventHandler(this.CommandsButton_Click);
            // 
            // R2Button
            // 
            this.R2Button.Location = new System.Drawing.Point(104, 493);
            this.R2Button.Name = "R2Button";
            this.R2Button.Size = new System.Drawing.Size(57, 28);
            this.R2Button.TabIndex = 28;
            this.R2Button.Text = "Right";
            this.R2Button.UseVisualStyleBackColor = true;
            this.R2Button.Click += new System.EventHandler(this.CommandsButton_Click);
            // 
            // L2Button
            // 
            this.L2Button.Location = new System.Drawing.Point(17, 493);
            this.L2Button.Name = "L2Button";
            this.L2Button.Size = new System.Drawing.Size(55, 28);
            this.L2Button.TabIndex = 27;
            this.L2Button.Text = "Left";
            this.L2Button.UseVisualStyleBackColor = true;
            this.L2Button.Click += new System.EventHandler(this.CommandsButton_Click);
            // 
            // Commands2Label
            // 
            this.Commands2Label.AutoSize = true;
            this.Commands2Label.Location = new System.Drawing.Point(14, 463);
            this.Commands2Label.Name = "Commands2Label";
            this.Commands2Label.Size = new System.Drawing.Size(86, 17);
            this.Commands2Label.TabIndex = 26;
            this.Commands2Label.Text = "Commands :";
            // 
            // Direction2
            // 
            this.Direction2.FormattingEnabled = true;
            this.Direction2.Location = new System.Drawing.Point(211, 421);
            this.Direction2.Name = "Direction2";
            this.Direction2.Size = new System.Drawing.Size(73, 24);
            this.Direction2.TabIndex = 25;
            // 
            // Direction2Label
            // 
            this.Direction2Label.AutoSize = true;
            this.Direction2Label.Location = new System.Drawing.Point(187, 428);
            this.Direction2Label.Name = "Direction2Label";
            this.Direction2Label.Size = new System.Drawing.Size(18, 17);
            this.Direction2Label.TabIndex = 24;
            this.Direction2Label.Text = "D";
            // 
            // Y2
            // 
            this.Y2.FormattingEnabled = true;
            this.Y2.Location = new System.Drawing.Point(124, 421);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(57, 24);
            this.Y2.TabIndex = 23;
            // 
            // Y2Label
            // 
            this.Y2Label.AutoSize = true;
            this.Y2Label.Location = new System.Drawing.Point(101, 428);
            this.Y2Label.Name = "Y2Label";
            this.Y2Label.Size = new System.Drawing.Size(17, 17);
            this.Y2Label.TabIndex = 22;
            this.Y2Label.Text = "Y";
            // 
            // X2
            // 
            this.X2.FormattingEnabled = true;
            this.X2.Location = new System.Drawing.Point(37, 421);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(57, 24);
            this.X2.TabIndex = 21;
            // 
            // X2Label
            // 
            this.X2Label.AutoSize = true;
            this.X2Label.Location = new System.Drawing.Point(14, 428);
            this.X2Label.Name = "X2Label";
            this.X2Label.Size = new System.Drawing.Size(17, 17);
            this.X2Label.TabIndex = 20;
            this.X2Label.Text = "X";
            // 
            // Robot2Label
            // 
            this.Robot2Label.AutoSize = true;
            this.Robot2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Robot2Label.ForeColor = System.Drawing.Color.Green;
            this.Robot2Label.Location = new System.Drawing.Point(12, 390);
            this.Robot2Label.Name = "Robot2Label";
            this.Robot2Label.Size = new System.Drawing.Size(90, 25);
            this.Robot2Label.TabIndex = 19;
            this.Robot2Label.Text = "Robot 2 :";
            // 
            // Reset1Button
            // 
            this.Reset1Button.Location = new System.Drawing.Point(104, 343);
            this.Reset1Button.Name = "Reset1Button";
            this.Reset1Button.Size = new System.Drawing.Size(67, 28);
            this.Reset1Button.TabIndex = 18;
            this.Reset1Button.Text = "Reset";
            this.Reset1Button.UseVisualStyleBackColor = true;
            this.Reset1Button.Click += new System.EventHandler(this.Reset1Button_Click);
            // 
            // Commands1
            // 
            this.Commands1.Location = new System.Drawing.Point(17, 284);
            this.Commands1.Name = "Commands1";
            this.Commands1.ReadOnly = true;
            this.Commands1.Size = new System.Drawing.Size(267, 53);
            this.Commands1.TabIndex = 16;
            this.Commands1.Text = "";
            // 
            // M1Button
            // 
            this.M1Button.Location = new System.Drawing.Point(190, 250);
            this.M1Button.Name = "M1Button";
            this.M1Button.Size = new System.Drawing.Size(57, 28);
            this.M1Button.TabIndex = 15;
            this.M1Button.Text = "Move";
            this.M1Button.UseVisualStyleBackColor = true;
            this.M1Button.Click += new System.EventHandler(this.CommandsButton_Click);
            // 
            // R1Button
            // 
            this.R1Button.Location = new System.Drawing.Point(104, 250);
            this.R1Button.Name = "R1Button";
            this.R1Button.Size = new System.Drawing.Size(57, 28);
            this.R1Button.TabIndex = 14;
            this.R1Button.Text = "Right";
            this.R1Button.UseVisualStyleBackColor = true;
            this.R1Button.Click += new System.EventHandler(this.CommandsButton_Click);
            // 
            // CommandLabel1
            // 
            this.CommandLabel1.AutoSize = true;
            this.CommandLabel1.Location = new System.Drawing.Point(14, 221);
            this.CommandLabel1.Name = "CommandLabel1";
            this.CommandLabel1.Size = new System.Drawing.Size(86, 17);
            this.CommandLabel1.TabIndex = 13;
            this.CommandLabel1.Text = "Commands :";
            // 
            // L1Button
            // 
            this.L1Button.Location = new System.Drawing.Point(17, 250);
            this.L1Button.Name = "L1Button";
            this.L1Button.Size = new System.Drawing.Size(55, 28);
            this.L1Button.TabIndex = 12;
            this.L1Button.Text = "Left";
            this.L1Button.UseVisualStyleBackColor = true;
            this.L1Button.Click += new System.EventHandler(this.CommandsButton_Click);
            // 
            // Direction1
            // 
            this.Direction1.FormattingEnabled = true;
            this.Direction1.Location = new System.Drawing.Point(211, 181);
            this.Direction1.Name = "Direction1";
            this.Direction1.Size = new System.Drawing.Size(73, 24);
            this.Direction1.TabIndex = 10;
            // 
            // Direction1Label
            // 
            this.Direction1Label.AutoSize = true;
            this.Direction1Label.Location = new System.Drawing.Point(187, 188);
            this.Direction1Label.Name = "Direction1Label";
            this.Direction1Label.Size = new System.Drawing.Size(18, 17);
            this.Direction1Label.TabIndex = 9;
            this.Direction1Label.Text = "D";
            // 
            // Y1
            // 
            this.Y1.FormattingEnabled = true;
            this.Y1.Location = new System.Drawing.Point(124, 181);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(57, 24);
            this.Y1.TabIndex = 8;
            // 
            // Y1Label
            // 
            this.Y1Label.AutoSize = true;
            this.Y1Label.Location = new System.Drawing.Point(101, 188);
            this.Y1Label.Name = "Y1Label";
            this.Y1Label.Size = new System.Drawing.Size(17, 17);
            this.Y1Label.TabIndex = 8;
            this.Y1Label.Text = "Y";
            // 
            // X1
            // 
            this.X1.FormattingEnabled = true;
            this.X1.Location = new System.Drawing.Point(37, 181);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(57, 24);
            this.X1.TabIndex = 7;
            // 
            // X1Label
            // 
            this.X1Label.AutoSize = true;
            this.X1Label.Location = new System.Drawing.Point(14, 188);
            this.X1Label.Name = "X1Label";
            this.X1Label.Size = new System.Drawing.Size(17, 17);
            this.X1Label.TabIndex = 6;
            this.X1Label.Text = "X";
            // 
            // Robot1Label
            // 
            this.Robot1Label.AutoSize = true;
            this.Robot1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Robot1Label.ForeColor = System.Drawing.Color.Red;
            this.Robot1Label.Location = new System.Drawing.Point(12, 149);
            this.Robot1Label.Name = "Robot1Label";
            this.Robot1Label.Size = new System.Drawing.Size(90, 25);
            this.Robot1Label.TabIndex = 5;
            this.Robot1Label.Text = "Robot 1 :";
            // 
            // Width
            // 
            this.Width.FormattingEnabled = true;
            this.Width.Location = new System.Drawing.Point(92, 96);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(57, 24);
            this.Width.TabIndex = 4;
            this.Width.SelectedIndexChanged += new System.EventHandler(this.WidthComboBox_SelectedIndexChanged);
            // 
            // Height
            // 
            this.Height.FormattingEnabled = true;
            this.Height.Location = new System.Drawing.Point(92, 55);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(57, 24);
            this.Height.TabIndex = 3;
            this.Height.SelectedIndexChanged += new System.EventHandler(this.HeightComboBox_SelectedIndexChanged);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(14, 99);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(44, 17);
            this.WidthLabel.TabIndex = 2;
            this.WidthLabel.Text = "Width";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(14, 58);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(49, 17);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "Height";
            // 
            // MapSizeLabel
            // 
            this.MapSizeLabel.AutoSize = true;
            this.MapSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapSizeLabel.Location = new System.Drawing.Point(12, 22);
            this.MapSizeLabel.Name = "MapSizeLabel";
            this.MapSizeLabel.Size = new System.Drawing.Size(106, 25);
            this.MapSizeLabel.TabIndex = 0;
            this.MapSizeLabel.Text = "Map Size :";
            // 
            // RightPanel
            // 
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanel.Location = new System.Drawing.Point(299, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(688, 806);
            this.RightPanel.TabIndex = 1;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 806);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.Text = "Robot Wars";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.LeftBottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label MapSizeLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.ComboBox Width;
        private System.Windows.Forms.Label Robot1Label;
        private System.Windows.Forms.Label X1Label;
        private System.Windows.Forms.Label Y1Label;
        private System.Windows.Forms.ComboBox X1;
        private System.Windows.Forms.ComboBox Y1;
        private System.Windows.Forms.Label Direction1Label;
        private System.Windows.Forms.ComboBox Direction1;
        private System.Windows.Forms.Button L1Button;
        private System.Windows.Forms.Label CommandLabel1;
        private System.Windows.Forms.Button M1Button;
        private System.Windows.Forms.Button R1Button;
        private System.Windows.Forms.RichTextBox Commands1;
        private System.Windows.Forms.Button Reset1Button;
        private System.Windows.Forms.Label Robot2Label;
        private System.Windows.Forms.ComboBox X2;
        private System.Windows.Forms.Label X2Label;
        private System.Windows.Forms.Label Y2Label;
        private System.Windows.Forms.ComboBox Y2;
        private System.Windows.Forms.Label Direction2Label;
        private System.Windows.Forms.ComboBox Direction2;
        private System.Windows.Forms.Label Commands2Label;
        private System.Windows.Forms.Button L2Button;
        private System.Windows.Forms.Button R2Button;
        private System.Windows.Forms.Button M2Button;
        private System.Windows.Forms.RichTextBox Commands2;
        private System.Windows.Forms.Button Reset2Button;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label ChooseAFileLabel;
        private System.Windows.Forms.TextBox FileTextBox;
        private System.Windows.Forms.Panel LeftBottomPanel;
        private System.Windows.Forms.Button StartWarButton;
        private System.Windows.Forms.ComboBox Height;
        private System.Windows.Forms.Panel RightPanel;
    }
}