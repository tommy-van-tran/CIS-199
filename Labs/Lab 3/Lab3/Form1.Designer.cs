namespace Lab3
{
    partial class Lab3
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
            this.pricePromptLabel = new System.Windows.Forms.Label();
            this.mealPriceTextBox = new System.Windows.Forms.TextBox();
            this.lowTipRateLabel = new System.Windows.Forms.Label();
            this.mediumTipRateLabel = new System.Windows.Forms.Label();
            this.highTipRateLabel = new System.Windows.Forms.Label();
            this.lowTipRateOutputLabel = new System.Windows.Forms.Label();
            this.mediumTipRateOutputLabel = new System.Windows.Forms.Label();
            this.highTipRateOutputLabel = new System.Windows.Forms.Label();
            this.calculateTipButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pricePromptLabel
            // 
            this.pricePromptLabel.AutoSize = true;
            this.pricePromptLabel.Location = new System.Drawing.Point(35, 18);
            this.pricePromptLabel.Name = "pricePromptLabel";
            this.pricePromptLabel.Size = new System.Drawing.Size(200, 20);
            this.pricePromptLabel.TabIndex = 0;
            this.pricePromptLabel.Text = "Enter the price of the meal:";
            this.pricePromptLabel.Click += new System.EventHandler(this.pricePromptLabel_Click);
            // 
            // mealPriceTextBox
            // 
            this.mealPriceTextBox.Location = new System.Drawing.Point(241, 15);
            this.mealPriceTextBox.Name = "mealPriceTextBox";
            this.mealPriceTextBox.Size = new System.Drawing.Size(125, 26);
            this.mealPriceTextBox.TabIndex = 1;
            this.mealPriceTextBox.TextChanged += new System.EventHandler(this.mealPriceTextBox_TextChanged);
            // 
            // lowTipRateLabel
            // 
            this.lowTipRateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lowTipRateLabel.Location = new System.Drawing.Point(160, 60);
            this.lowTipRateLabel.Name = "lowTipRateLabel";
            this.lowTipRateLabel.Size = new System.Drawing.Size(75, 26);
            this.lowTipRateLabel.TabIndex = 2;
            this.lowTipRateLabel.Click += new System.EventHandler(this.lowTipRateLabel_Click);
            // 
            // mediumTipRateLabel
            // 
            this.mediumTipRateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mediumTipRateLabel.Location = new System.Drawing.Point(160, 103);
            this.mediumTipRateLabel.Name = "mediumTipRateLabel";
            this.mediumTipRateLabel.Size = new System.Drawing.Size(75, 26);
            this.mediumTipRateLabel.TabIndex = 3;
            this.mediumTipRateLabel.Click += new System.EventHandler(this.mediumTipRateLabel_Click);
            // 
            // highTipRateLabel
            // 
            this.highTipRateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.highTipRateLabel.Location = new System.Drawing.Point(160, 146);
            this.highTipRateLabel.Name = "highTipRateLabel";
            this.highTipRateLabel.Size = new System.Drawing.Size(75, 26);
            this.highTipRateLabel.TabIndex = 4;
            this.highTipRateLabel.Click += new System.EventHandler(this.highTipRateLabel_Click);
            // 
            // lowTipRateOutputLabel
            // 
            this.lowTipRateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowTipRateOutputLabel.Location = new System.Drawing.Point(241, 60);
            this.lowTipRateOutputLabel.Name = "lowTipRateOutputLabel";
            this.lowTipRateOutputLabel.Size = new System.Drawing.Size(125, 26);
            this.lowTipRateOutputLabel.TabIndex = 5;
            this.lowTipRateOutputLabel.Click += new System.EventHandler(this.lowTipRateOutputLabel_Click);
            // 
            // mediumTipRateOutputLabel
            // 
            this.mediumTipRateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mediumTipRateOutputLabel.Location = new System.Drawing.Point(241, 103);
            this.mediumTipRateOutputLabel.Name = "mediumTipRateOutputLabel";
            this.mediumTipRateOutputLabel.Size = new System.Drawing.Size(125, 26);
            this.mediumTipRateOutputLabel.TabIndex = 6;
            this.mediumTipRateOutputLabel.Click += new System.EventHandler(this.mediumTipRateOutputLabel_Click);
            // 
            // highTipRateOutputLabel
            // 
            this.highTipRateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highTipRateOutputLabel.Location = new System.Drawing.Point(241, 146);
            this.highTipRateOutputLabel.Name = "highTipRateOutputLabel";
            this.highTipRateOutputLabel.Size = new System.Drawing.Size(125, 26);
            this.highTipRateOutputLabel.TabIndex = 7;
            this.highTipRateOutputLabel.Click += new System.EventHandler(this.highTipRateOutputLabel_Click);
            // 
            // calculateTipButton
            // 
            this.calculateTipButton.Location = new System.Drawing.Point(71, 215);
            this.calculateTipButton.Name = "calculateTipButton";
            this.calculateTipButton.Size = new System.Drawing.Size(115, 40);
            this.calculateTipButton.TabIndex = 8;
            this.calculateTipButton.Text = "Calculate Tip";
            this.calculateTipButton.UseVisualStyleBackColor = true;
            this.calculateTipButton.Click += new System.EventHandler(this.calculateTipButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(215, 215);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(115, 40);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Lab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateTipButton);
            this.Controls.Add(this.highTipRateOutputLabel);
            this.Controls.Add(this.mediumTipRateOutputLabel);
            this.Controls.Add(this.lowTipRateOutputLabel);
            this.Controls.Add(this.highTipRateLabel);
            this.Controls.Add(this.mediumTipRateLabel);
            this.Controls.Add(this.lowTipRateLabel);
            this.Controls.Add(this.mealPriceTextBox);
            this.Controls.Add(this.pricePromptLabel);
            this.Name = "Lab3";
            this.Text = "Lab 3";
            this.Load += new System.EventHandler(this.Lab3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pricePromptLabel;
        private System.Windows.Forms.TextBox mealPriceTextBox;
        private System.Windows.Forms.Label lowTipRateLabel;
        private System.Windows.Forms.Label mediumTipRateLabel;
        private System.Windows.Forms.Label highTipRateLabel;
        private System.Windows.Forms.Label lowTipRateOutputLabel;
        private System.Windows.Forms.Label mediumTipRateOutputLabel;
        private System.Windows.Forms.Label highTipRateOutputLabel;
        private System.Windows.Forms.Button calculateTipButton;
        private System.Windows.Forms.Button exitButton;
    }
}

