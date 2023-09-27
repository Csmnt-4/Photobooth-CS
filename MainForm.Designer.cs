namespace Photo_booth
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
            this.saveButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.oneByThreeRadioButton = new System.Windows.Forms.RadioButton();
            this.oneByFourRadioButton = new System.Windows.Forms.RadioButton();
            this.twoByThreeRadioButton = new System.Windows.Forms.RadioButton();
            this.picturesCountLabel = new System.Windows.Forms.Label();
            this.cameraOutput = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cameraOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(357, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(83, 32);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "&Save image";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.savePicture_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(450, 12);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(105, 32);
            this.copyButton.TabIndex = 2;
            this.copyButton.Text = "&Copy to clipboard";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // oneByThreeRadioButton
            // 
            this.oneByThreeRadioButton.AutoSize = true;
            this.oneByThreeRadioButton.Location = new System.Drawing.Point(117, 20);
            this.oneByThreeRadioButton.Name = "oneByThreeRadioButton";
            this.oneByThreeRadioButton.Size = new System.Drawing.Size(42, 17);
            this.oneByThreeRadioButton.TabIndex = 3;
            this.oneByThreeRadioButton.Tag = "1";
            this.oneByThreeRadioButton.Text = "1x3";
            this.oneByThreeRadioButton.UseVisualStyleBackColor = true;
            this.oneByThreeRadioButton.Enter += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // oneByFourRadioButton
            // 
            this.oneByFourRadioButton.AutoSize = true;
            this.oneByFourRadioButton.Location = new System.Drawing.Point(165, 20);
            this.oneByFourRadioButton.Name = "oneByFourRadioButton";
            this.oneByFourRadioButton.Size = new System.Drawing.Size(42, 17);
            this.oneByFourRadioButton.TabIndex = 4;
            this.oneByFourRadioButton.Tag = "2";
            this.oneByFourRadioButton.Text = "1x4";
            this.oneByFourRadioButton.UseVisualStyleBackColor = true;
            this.oneByFourRadioButton.Enter += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // twoByThreeRadioButton
            // 
            this.twoByThreeRadioButton.AutoSize = true;
            this.twoByThreeRadioButton.Location = new System.Drawing.Point(213, 20);
            this.twoByThreeRadioButton.Name = "twoByThreeRadioButton";
            this.twoByThreeRadioButton.Size = new System.Drawing.Size(42, 17);
            this.twoByThreeRadioButton.TabIndex = 5;
            this.twoByThreeRadioButton.Tag = "3";
            this.twoByThreeRadioButton.Text = "2x3";
            this.twoByThreeRadioButton.UseVisualStyleBackColor = true;
            this.twoByThreeRadioButton.Enter += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // picturesCountLabel
            // 
            this.picturesCountLabel.AutoSize = true;
            this.picturesCountLabel.Location = new System.Drawing.Point(12, 22);
            this.picturesCountLabel.Name = "picturesCountLabel";
            this.picturesCountLabel.Size = new System.Drawing.Size(99, 13);
            this.picturesCountLabel.TabIndex = 6;
            this.picturesCountLabel.Text = "Number of pictures:";
            this.picturesCountLabel.Click += new System.EventHandler(this.savePicture_Click);
            // 
            // cameraOutput
            // 
            this.cameraOutput.Location = new System.Drawing.Point(12, 53);
            this.cameraOutput.Name = "cameraOutput";
            this.cameraOutput.Size = new System.Drawing.Size(542, 304);
            this.cameraOutput.TabIndex = 7;
            this.cameraOutput.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 370);
            this.Controls.Add(this.cameraOutput);
            this.Controls.Add(this.picturesCountLabel);
            this.Controls.Add(this.twoByThreeRadioButton);
            this.Controls.Add(this.oneByFourRadioButton);
            this.Controls.Add(this.oneByThreeRadioButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.saveButton);
            this.Name = "MainForm";
            this.Text = "Photo-booth";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cameraOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.RadioButton oneByThreeRadioButton;
        private System.Windows.Forms.RadioButton oneByFourRadioButton;
        private System.Windows.Forms.RadioButton twoByThreeRadioButton;
        private System.Windows.Forms.Label picturesCountLabel;
        private System.Windows.Forms.PictureBox cameraOutput;
    }
}

