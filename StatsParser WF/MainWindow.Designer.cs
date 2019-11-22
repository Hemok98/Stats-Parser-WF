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
            this.directoryTextbox = new System.Windows.Forms.TextBox();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.statsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(6, 12);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputTextBox.Size = new System.Drawing.Size(566, 545);
            this.OutputTextBox.TabIndex = 0;
            // 
            // getInfoButton
            // 
            this.getInfoButton.Location = new System.Drawing.Point(590, 72);
            this.getInfoButton.Name = "getInfoButton";
            this.getInfoButton.Size = new System.Drawing.Size(199, 28);
            this.getInfoButton.TabIndex = 1;
            this.getInfoButton.Text = "Get Info";
            this.getInfoButton.UseVisualStyleBackColor = true;
            this.getInfoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // statsTextbox
            // 
            this.statsTextbox.Location = new System.Drawing.Point(590, 137);
            this.statsTextbox.Multiline = true;
            this.statsTextbox.Name = "statsTextbox";
            this.statsTextbox.Size = new System.Drawing.Size(199, 420);
            this.statsTextbox.TabIndex = 2;
            this.statsTextbox.Text = global::StatsParser_WF.Properties.Settings.Default.statsSaves;
            // 
            // directoryTextbox
            // 
            this.directoryTextbox.Location = new System.Drawing.Point(590, 46);
            this.directoryTextbox.Name = "directoryTextbox";
            this.directoryTextbox.Size = new System.Drawing.Size(199, 20);
            this.directoryTextbox.TabIndex = 3;
            this.directoryTextbox.Text = "D:\\stats";
            // 
            // directoryLabel
            // 
            this.directoryLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directoryLabel.Location = new System.Drawing.Point(590, 12);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(199, 31);
            this.directoryLabel.TabIndex = 4;
            this.directoryLabel.Text = "Direction";
            this.directoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statsLabel
            // 
            this.statsLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statsLabel.Location = new System.Drawing.Point(590, 103);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(199, 31);
            this.statsLabel.TabIndex = 5;
            this.statsLabel.Text = "Stats";
            this.statsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 609);
            this.Controls.Add(this.statsLabel);
            this.Controls.Add(this.directoryLabel);
            this.Controls.Add(this.directoryTextbox);
            this.Controls.Add(this.statsTextbox);
            this.Controls.Add(this.getInfoButton);
            this.Controls.Add(this.OutputTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Minecraft Stats Parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button getInfoButton;
        private System.Windows.Forms.TextBox statsTextbox;
        private System.Windows.Forms.TextBox directoryTextbox;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.Label statsLabel;
    }
}

