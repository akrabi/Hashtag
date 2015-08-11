namespace HashTag
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
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.calculatedHashBox = new System.Windows.Forms.TextBox();
            this.compareHashBox = new System.Windows.Forms.TextBox();
            this.calculatedHashLabel = new System.Windows.Forms.Label();
            this.compareHashLabel = new System.Windows.Forms.Label();
            this.algorithmCombo = new System.Windows.Forms.ComboBox();
            this.algorithmLabel = new System.Windows.Forms.Label();
            this.compareFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(38, 220);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(284, 103);
            this.chooseFileButton.TabIndex = 3;
            this.chooseFileButton.Text = "Choose a file";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // calculatedHashBox
            // 
            this.calculatedHashBox.Location = new System.Drawing.Point(533, 220);
            this.calculatedHashBox.Name = "calculatedHashBox";
            this.calculatedHashBox.Size = new System.Drawing.Size(430, 20);
            this.calculatedHashBox.TabIndex = 4;
            this.calculatedHashBox.TextChanged += new System.EventHandler(this.calculatedHashBox_TextChanged);
            // 
            // compareHashBox
            // 
            this.compareHashBox.Location = new System.Drawing.Point(533, 303);
            this.compareHashBox.Name = "compareHashBox";
            this.compareHashBox.Size = new System.Drawing.Size(430, 20);
            this.compareHashBox.TabIndex = 5;
            this.compareHashBox.TextChanged += new System.EventHandler(this.compareHashBox_TextChanged);
            // 
            // calculatedHashLabel
            // 
            this.calculatedHashLabel.AutoSize = true;
            this.calculatedHashLabel.Location = new System.Drawing.Point(438, 223);
            this.calculatedHashLabel.Name = "calculatedHashLabel";
            this.calculatedHashLabel.Size = new System.Drawing.Size(89, 13);
            this.calculatedHashLabel.TabIndex = 6;
            this.calculatedHashLabel.Text = "Calculated value:";
            // 
            // compareHashLabel
            // 
            this.compareHashLabel.AutoSize = true;
            this.compareHashLabel.Location = new System.Drawing.Point(463, 306);
            this.compareHashLabel.Name = "compareHashLabel";
            this.compareHashLabel.Size = new System.Drawing.Size(64, 13);
            this.compareHashLabel.TabIndex = 7;
            this.compareHashLabel.Text = "Compare to:";
            // 
            // algorithmCombo
            // 
            this.algorithmCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algorithmCombo.FormattingEnabled = true;
            this.algorithmCombo.Items.AddRange(new object[] {
            "MD5",
            "SHA1",
            "SHA256",
            "SHA512"});
            this.algorithmCombo.Location = new System.Drawing.Point(441, 59);
            this.algorithmCombo.Name = "algorithmCombo";
            this.algorithmCombo.Size = new System.Drawing.Size(201, 21);
            this.algorithmCombo.TabIndex = 8;
            this.algorithmCombo.SelectedIndexChanged += new System.EventHandler(this.algorithmCombo_SelectedIndexChanged);
            // 
            // algorithmLabel
            // 
            this.algorithmLabel.AutoSize = true;
            this.algorithmLabel.Location = new System.Drawing.Point(382, 62);
            this.algorithmLabel.Name = "algorithmLabel";
            this.algorithmLabel.Size = new System.Drawing.Size(53, 13);
            this.algorithmLabel.TabIndex = 9;
            this.algorithmLabel.Text = "Algorithm:";
            // 
            // compareFileButton
            // 
            this.compareFileButton.AutoEllipsis = true;
            this.compareFileButton.Location = new System.Drawing.Point(973, 303);
            this.compareFileButton.Name = "compareFileButton";
            this.compareFileButton.Size = new System.Drawing.Size(23, 19);
            this.compareFileButton.TabIndex = 10;
            this.compareFileButton.UseVisualStyleBackColor = true;
            this.compareFileButton.Click += new System.EventHandler(this.compareFileButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 578);
            this.Controls.Add(this.compareFileButton);
            this.Controls.Add(this.algorithmLabel);
            this.Controls.Add(this.algorithmCombo);
            this.Controls.Add(this.compareHashLabel);
            this.Controls.Add(this.calculatedHashLabel);
            this.Controls.Add(this.compareHashBox);
            this.Controls.Add(this.calculatedHashBox);
            this.Controls.Add(this.chooseFileButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.TextBox calculatedHashBox;
        private System.Windows.Forms.TextBox compareHashBox;
        private System.Windows.Forms.Label calculatedHashLabel;
        private System.Windows.Forms.Label compareHashLabel;
        private System.Windows.Forms.ComboBox algorithmCombo;
        private System.Windows.Forms.Label algorithmLabel;
        private System.Windows.Forms.Button compareFileButton;

    }
}

