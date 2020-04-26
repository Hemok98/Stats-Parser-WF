namespace StatsParser_WF
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.getInfoButton = new System.Windows.Forms.Button();
            this.statsTextbox = new System.Windows.Forms.TextBox();
            this.embedTextbox = new System.Windows.Forms.TextBox();
            this.directoryTextbox = new System.Windows.Forms.TextBox();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.statsLabel = new System.Windows.Forms.Label();
            this.CalculateChoiseRadiobutton = new System.Windows.Forms.RadioButton();
            this.ChangeTextboxTrackbar = new System.Windows.Forms.TrackBar();
            this.EmbedLabel = new System.Windows.Forms.Label();
            this.getEmbedButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeTextboxTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(6, 12);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputTextBox.Size = new System.Drawing.Size(566, 579);
            this.OutputTextBox.TabIndex = 0;
            // 
            // getInfoButton
            // 
            this.getInfoButton.Location = new System.Drawing.Point(590, 99);
            this.getInfoButton.Name = "getInfoButton";
            this.getInfoButton.Size = new System.Drawing.Size(93, 28);
            this.getInfoButton.TabIndex = 1;
            this.getInfoButton.Text = "Load stats";
            this.getInfoButton.UseVisualStyleBackColor = true;
            this.getInfoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // statsTextbox
            // 
            this.statsTextbox.Location = new System.Drawing.Point(590, 203);
            this.statsTextbox.Multiline = true;
            this.statsTextbox.Name = "statsTextbox";
            this.statsTextbox.Size = new System.Drawing.Size(200, 388);
            this.statsTextbox.TabIndex = 2;
            this.statsTextbox.Text = global::StatsParser_WF.Properties.Settings.Default.statsSaves;
            // 
            // embedTextbox
            // 
            this.embedTextbox.Location = new System.Drawing.Point(590, 203);
            this.embedTextbox.Multiline = true;
            this.embedTextbox.Name = "embedTextbox";
            this.embedTextbox.Size = new System.Drawing.Size(200, 388);
            this.embedTextbox.TabIndex = 2;
            this.embedTextbox.Text = global::StatsParser_WF.Properties.Settings.Default.embedAssociations;
            this.embedTextbox.Visible = false;
            // 
            // directoryTextbox
            // 
            this.directoryTextbox.Location = new System.Drawing.Point(590, 73);
            this.directoryTextbox.Name = "directoryTextbox";
            this.directoryTextbox.Size = new System.Drawing.Size(200, 20);
            this.directoryTextbox.TabIndex = 3;
            this.directoryTextbox.Text = "D:\\stats";
            // 
            // directoryLabel
            // 
            this.directoryLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directoryLabel.Location = new System.Drawing.Point(590, 39);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(200, 31);
            this.directoryLabel.TabIndex = 4;
            this.directoryLabel.Text = "Direction";
            this.directoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statsLabel
            // 
            this.statsLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statsLabel.Location = new System.Drawing.Point(590, 152);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(60, 45);
            this.statsLabel.TabIndex = 5;
            this.statsLabel.Text = "Stats";
            this.statsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculateChoiseRadiobutton
            // 
            this.CalculateChoiseRadiobutton.Checked = true;
            this.CalculateChoiseRadiobutton.Location = new System.Drawing.Point(590, 19);
            this.CalculateChoiseRadiobutton.Name = "CalculateChoiseRadiobutton";
            this.CalculateChoiseRadiobutton.Size = new System.Drawing.Size(200, 17);
            this.CalculateChoiseRadiobutton.TabIndex = 6;
            this.CalculateChoiseRadiobutton.TabStop = true;
            this.CalculateChoiseRadiobutton.Text = "Calculate Best";
            this.CalculateChoiseRadiobutton.UseVisualStyleBackColor = true;
            this.CalculateChoiseRadiobutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RadioClick);
            // 
            // ChangeTextboxTrackbar
            // 
            this.ChangeTextboxTrackbar.AutoSize = false;
            this.ChangeTextboxTrackbar.Location = new System.Drawing.Point(667, 164);
            this.ChangeTextboxTrackbar.Maximum = 1;
            this.ChangeTextboxTrackbar.Name = "ChangeTextboxTrackbar";
            this.ChangeTextboxTrackbar.Size = new System.Drawing.Size(43, 33);
            this.ChangeTextboxTrackbar.TabIndex = 7;
            this.ChangeTextboxTrackbar.Scroll += new System.EventHandler(this.ChangeShownTextbox);
            // 
            // EmbedLabel
            // 
            this.EmbedLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmbedLabel.Location = new System.Drawing.Point(730, 152);
            this.EmbedLabel.Name = "EmbedLabel";
            this.EmbedLabel.Size = new System.Drawing.Size(60, 45);
            this.EmbedLabel.TabIndex = 8;
            this.EmbedLabel.Text = "Embed";
            this.EmbedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getEmbedButton
            // 
            this.getEmbedButton.Location = new System.Drawing.Point(697, 99);
            this.getEmbedButton.Name = "getEmbedButton";
            this.getEmbedButton.Size = new System.Drawing.Size(93, 28);
            this.getEmbedButton.TabIndex = 9;
            this.getEmbedButton.Text = "Get Embed";
            this.getEmbedButton.UseVisualStyleBackColor = true;
            this.getEmbedButton.Click += new System.EventHandler(this.GetEmbedButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Parse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 602);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.getEmbedButton);
            this.Controls.Add(this.EmbedLabel);
            this.Controls.Add(this.ChangeTextboxTrackbar);
            this.Controls.Add(this.CalculateChoiseRadiobutton);
            this.Controls.Add(this.statsLabel);
            this.Controls.Add(this.directoryLabel);
            this.Controls.Add(this.directoryTextbox);
            this.Controls.Add(this.statsTextbox);
            this.Controls.Add(this.embedTextbox);
            this.Controls.Add(this.getInfoButton);
            this.Controls.Add(this.OutputTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Minecraft Stats Parser";
            ((System.ComponentModel.ISupportInitialize)(this.ChangeTextboxTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button getInfoButton;
        private System.Windows.Forms.TextBox statsTextbox;
        private System.Windows.Forms.TextBox embedTextbox;
        private System.Windows.Forms.TextBox directoryTextbox;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.Label statsLabel;
        private System.Windows.Forms.RadioButton CalculateChoiseRadiobutton;
        private System.Windows.Forms.TrackBar ChangeTextboxTrackbar;
        private System.Windows.Forms.Label EmbedLabel;
        private System.Windows.Forms.Button getEmbedButton;
        private System.Windows.Forms.Button button1;
    }
}

