namespace Lab2
{
    partial class lab2
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.format1Button = new System.Windows.Forms.Button();
            this.format2Button = new System.Windows.Forms.Button();
            this.format3Button = new System.Windows.Forms.Button();
            this.format4Button = new System.Windows.Forms.Button();
            this.format5Button = new System.Windows.Forms.Button();
            this.format6Button = new System.Windows.Forms.Button();
            this.clearTextBoxesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(175, 40);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(90, 20);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            this.firstNameLabel.Click += new System.EventHandler(this.firstNameLabel_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(175, 119);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(90, 20);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name:";
            this.lastNameLabel.Click += new System.EventHandler(this.lastNameLabel_Click);
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(160, 80);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(105, 20);
            this.middleNameLabel.TabIndex = 2;
            this.middleNameLabel.Text = "Middle Name:";
            this.middleNameLabel.Click += new System.EventHandler(this.middleNameLabel_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(20, 160);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(244, 20);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Preferred Title (Mr., Ms., Dr., etc.):";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(315, 34);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(150, 26);
            this.firstNameTextBox.TabIndex = 4;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(315, 74);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(150, 26);
            this.middleNameTextBox.TabIndex = 5;
            this.middleNameTextBox.TextChanged += new System.EventHandler(this.middleNameTextBox_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(315, 112);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(150, 26);
            this.lastNameTextBox.TabIndex = 6;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(315, 153);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(150, 26);
            this.titleTextBox.TabIndex = 7;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameLabel.Location = new System.Drawing.Point(35, 250);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(430, 26);
            this.fullNameLabel.TabIndex = 8;
            this.fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fullNameLabel.Click += new System.EventHandler(this.fullNameLabel_Click);
            // 
            // format1Button
            // 
            this.format1Button.Location = new System.Drawing.Point(35, 300);
            this.format1Button.Name = "format1Button";
            this.format1Button.Size = new System.Drawing.Size(85, 30);
            this.format1Button.TabIndex = 9;
            this.format1Button.Text = "Format 1";
            this.format1Button.UseVisualStyleBackColor = true;
            this.format1Button.Click += new System.EventHandler(this.format1Button_Click);
            // 
            // format2Button
            // 
            this.format2Button.Location = new System.Drawing.Point(140, 300);
            this.format2Button.Name = "format2Button";
            this.format2Button.Size = new System.Drawing.Size(85, 30);
            this.format2Button.TabIndex = 10;
            this.format2Button.Text = "Format 2";
            this.format2Button.UseVisualStyleBackColor = true;
            this.format2Button.Click += new System.EventHandler(this.format2Button_Click);
            // 
            // format3Button
            // 
            this.format3Button.Location = new System.Drawing.Point(245, 300);
            this.format3Button.Name = "format3Button";
            this.format3Button.Size = new System.Drawing.Size(85, 30);
            this.format3Button.TabIndex = 11;
            this.format3Button.Text = "Format 3";
            this.format3Button.UseVisualStyleBackColor = true;
            this.format3Button.Click += new System.EventHandler(this.format3Button_Click);
            // 
            // format4Button
            // 
            this.format4Button.Location = new System.Drawing.Point(35, 350);
            this.format4Button.Name = "format4Button";
            this.format4Button.Size = new System.Drawing.Size(85, 30);
            this.format4Button.TabIndex = 12;
            this.format4Button.Text = "Format 4";
            this.format4Button.UseVisualStyleBackColor = true;
            this.format4Button.Click += new System.EventHandler(this.format4Button_Click);
            // 
            // format5Button
            // 
            this.format5Button.Location = new System.Drawing.Point(140, 350);
            this.format5Button.Name = "format5Button";
            this.format5Button.Size = new System.Drawing.Size(85, 30);
            this.format5Button.TabIndex = 13;
            this.format5Button.Text = "Format 5";
            this.format5Button.UseVisualStyleBackColor = true;
            this.format5Button.Click += new System.EventHandler(this.format5Button_Click);
            // 
            // format6Button
            // 
            this.format6Button.Location = new System.Drawing.Point(245, 350);
            this.format6Button.Name = "format6Button";
            this.format6Button.Size = new System.Drawing.Size(85, 30);
            this.format6Button.TabIndex = 14;
            this.format6Button.Text = "Format 6";
            this.format6Button.UseVisualStyleBackColor = true;
            this.format6Button.Click += new System.EventHandler(this.format6Button_Click);
            // 
            // clearTextBoxesButton
            // 
            this.clearTextBoxesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearTextBoxesButton.Location = new System.Drawing.Point(350, 300);
            this.clearTextBoxesButton.Name = "clearTextBoxesButton";
            this.clearTextBoxesButton.Size = new System.Drawing.Size(85, 30);
            this.clearTextBoxesButton.TabIndex = 15;
            this.clearTextBoxesButton.Text = "Clear";
            this.clearTextBoxesButton.UseVisualStyleBackColor = true;
            this.clearTextBoxesButton.Click += new System.EventHandler(this.clearTextBoxesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(350, 350);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(85, 30);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // lab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 394);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearTextBoxesButton);
            this.Controls.Add(this.format6Button);
            this.Controls.Add(this.format5Button);
            this.Controls.Add(this.format4Button);
            this.Controls.Add(this.format3Button);
            this.Controls.Add(this.format2Button);
            this.Controls.Add(this.format1Button);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "lab2";
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Button format1Button;
        private System.Windows.Forms.Button format2Button;
        private System.Windows.Forms.Button format3Button;
        private System.Windows.Forms.Button format4Button;
        private System.Windows.Forms.Button format5Button;
        private System.Windows.Forms.Button format6Button;
        private System.Windows.Forms.Button clearTextBoxesButton;
        private System.Windows.Forms.Button exitButton;
    }
}

