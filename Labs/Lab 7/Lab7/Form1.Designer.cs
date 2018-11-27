namespace Lab7
{
    partial class Lab7
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
            this.monthPromptLbl = new System.Windows.Forms.Label();
            this.monthNumberTxtBox = new System.Windows.Forms.TextBox();
            this.languageGroupBox = new System.Windows.Forms.GroupBox();
            this.englishRadioBtn = new System.Windows.Forms.RadioButton();
            this.spanishRadioBtn = new System.Windows.Forms.RadioButton();
            this.italianRadioBtn = new System.Windows.Forms.RadioButton();
            this.monthOutputLbl = new System.Windows.Forms.Label();
            this.outputBtn = new System.Windows.Forms.Button();
            this.languageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthPromptLbl
            // 
            this.monthPromptLbl.AutoSize = true;
            this.monthPromptLbl.Location = new System.Drawing.Point(37, 13);
            this.monthPromptLbl.Name = "monthPromptLbl";
            this.monthPromptLbl.Size = new System.Drawing.Size(67, 20);
            this.monthPromptLbl.TabIndex = 5;
            this.monthPromptLbl.Text = "Month #";
            // 
            // monthNumberTxtBox
            // 
            this.monthNumberTxtBox.Location = new System.Drawing.Point(116, 10);
            this.monthNumberTxtBox.Name = "monthNumberTxtBox";
            this.monthNumberTxtBox.Size = new System.Drawing.Size(125, 26);
            this.monthNumberTxtBox.TabIndex = 0;
            // 
            // languageGroupBox
            // 
            this.languageGroupBox.Controls.Add(this.italianRadioBtn);
            this.languageGroupBox.Controls.Add(this.spanishRadioBtn);
            this.languageGroupBox.Controls.Add(this.englishRadioBtn);
            this.languageGroupBox.Location = new System.Drawing.Point(41, 47);
            this.languageGroupBox.Name = "languageGroupBox";
            this.languageGroupBox.Size = new System.Drawing.Size(200, 160);
            this.languageGroupBox.TabIndex = 6;
            this.languageGroupBox.TabStop = false;
            this.languageGroupBox.Text = "Choose Language:";
            // 
            // englishRadioBtn
            // 
            this.englishRadioBtn.AutoSize = true;
            this.englishRadioBtn.Checked = true;
            this.englishRadioBtn.Location = new System.Drawing.Point(6, 34);
            this.englishRadioBtn.Name = "englishRadioBtn";
            this.englishRadioBtn.Size = new System.Drawing.Size(86, 24);
            this.englishRadioBtn.TabIndex = 1;
            this.englishRadioBtn.TabStop = true;
            this.englishRadioBtn.Text = "English";
            this.englishRadioBtn.UseVisualStyleBackColor = true;
            // 
            // spanishRadioBtn
            // 
            this.spanishRadioBtn.AutoSize = true;
            this.spanishRadioBtn.Location = new System.Drawing.Point(6, 73);
            this.spanishRadioBtn.Name = "spanishRadioBtn";
            this.spanishRadioBtn.Size = new System.Drawing.Size(92, 24);
            this.spanishRadioBtn.TabIndex = 2;
            this.spanishRadioBtn.Text = "Spanish";
            this.spanishRadioBtn.UseVisualStyleBackColor = true;
            // 
            // italianRadioBtn
            // 
            this.italianRadioBtn.AutoSize = true;
            this.italianRadioBtn.Location = new System.Drawing.Point(6, 112);
            this.italianRadioBtn.Name = "italianRadioBtn";
            this.italianRadioBtn.Size = new System.Drawing.Size(77, 24);
            this.italianRadioBtn.TabIndex = 3;
            this.italianRadioBtn.Text = "Italian";
            this.italianRadioBtn.UseVisualStyleBackColor = true;
            // 
            // monthOutputLbl
            // 
            this.monthOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthOutputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthOutputLbl.Location = new System.Drawing.Point(41, 232);
            this.monthOutputLbl.Name = "monthOutputLbl";
            this.monthOutputLbl.Size = new System.Drawing.Size(200, 30);
            this.monthOutputLbl.TabIndex = 7;
            this.monthOutputLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputBtn
            // 
            this.outputBtn.AutoSize = true;
            this.outputBtn.Location = new System.Drawing.Point(100, 278);
            this.outputBtn.Name = "outputBtn";
            this.outputBtn.Size = new System.Drawing.Size(79, 30);
            this.outputBtn.TabIndex = 4;
            this.outputBtn.Text = "Look Up";
            this.outputBtn.UseVisualStyleBackColor = true;
            this.outputBtn.Click += new System.EventHandler(this.outputBtn_Click);
            // 
            // Lab7
            // 
            this.AcceptButton = this.outputBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 344);
            this.Controls.Add(this.outputBtn);
            this.Controls.Add(this.monthOutputLbl);
            this.Controls.Add(this.languageGroupBox);
            this.Controls.Add(this.monthNumberTxtBox);
            this.Controls.Add(this.monthPromptLbl);
            this.Name = "Lab7";
            this.Text = "Lab 7";
            this.languageGroupBox.ResumeLayout(false);
            this.languageGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label monthPromptLbl;
        private System.Windows.Forms.TextBox monthNumberTxtBox;
        private System.Windows.Forms.GroupBox languageGroupBox;
        private System.Windows.Forms.RadioButton italianRadioBtn;
        private System.Windows.Forms.RadioButton spanishRadioBtn;
        private System.Windows.Forms.RadioButton englishRadioBtn;
        private System.Windows.Forms.Label monthOutputLbl;
        private System.Windows.Forms.Button outputBtn;
    }
}

