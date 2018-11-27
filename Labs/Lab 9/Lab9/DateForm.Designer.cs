namespace Lab9
{
    partial class DateForm
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
            this.datePromptLbl = new System.Windows.Forms.Label();
            this.dateOutputLbl = new System.Windows.Forms.Label();
            this.monthPromptLbl = new System.Windows.Forms.Label();
            this.dayPromptLbl = new System.Windows.Forms.Label();
            this.yearPromptLbl = new System.Windows.Forms.Label();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.updateMonthButton = new System.Windows.Forms.Button();
            this.updateDayButton = new System.Windows.Forms.Button();
            this.updateYearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datePromptLbl
            // 
            this.datePromptLbl.AutoSize = true;
            this.datePromptLbl.Location = new System.Drawing.Point(93, 36);
            this.datePromptLbl.Name = "datePromptLbl";
            this.datePromptLbl.Size = new System.Drawing.Size(48, 20);
            this.datePromptLbl.TabIndex = 0;
            this.datePromptLbl.Text = "Date:";
            // 
            // dateOutputLbl
            // 
            this.dateOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOutputLbl.Location = new System.Drawing.Point(147, 35);
            this.dateOutputLbl.Name = "dateOutputLbl";
            this.dateOutputLbl.Size = new System.Drawing.Size(120, 25);
            this.dateOutputLbl.TabIndex = 1;
            // 
            // monthPromptLbl
            // 
            this.monthPromptLbl.AutoSize = true;
            this.monthPromptLbl.Location = new System.Drawing.Point(33, 89);
            this.monthPromptLbl.Name = "monthPromptLbl";
            this.monthPromptLbl.Size = new System.Drawing.Size(58, 20);
            this.monthPromptLbl.TabIndex = 2;
            this.monthPromptLbl.Text = "Month:";
            // 
            // dayPromptLbl
            // 
            this.dayPromptLbl.AutoSize = true;
            this.dayPromptLbl.Location = new System.Drawing.Point(50, 137);
            this.dayPromptLbl.Name = "dayPromptLbl";
            this.dayPromptLbl.Size = new System.Drawing.Size(41, 20);
            this.dayPromptLbl.TabIndex = 3;
            this.dayPromptLbl.Text = "Day:";
            // 
            // yearPromptLbl
            // 
            this.yearPromptLbl.AutoSize = true;
            this.yearPromptLbl.Location = new System.Drawing.Point(44, 184);
            this.yearPromptLbl.Name = "yearPromptLbl";
            this.yearPromptLbl.Size = new System.Drawing.Size(47, 20);
            this.yearPromptLbl.TabIndex = 4;
            this.yearPromptLbl.Text = "Year:";
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(97, 86);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(100, 26);
            this.monthTextBox.TabIndex = 5;
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(97, 134);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(100, 26);
            this.dayTextBox.TabIndex = 6;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(97, 181);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 26);
            this.yearTextBox.TabIndex = 7;
            // 
            // updateMonthButton
            // 
            this.updateMonthButton.AutoSize = true;
            this.updateMonthButton.Location = new System.Drawing.Point(203, 84);
            this.updateMonthButton.Name = "updateMonthButton";
            this.updateMonthButton.Size = new System.Drawing.Size(125, 30);
            this.updateMonthButton.TabIndex = 8;
            this.updateMonthButton.Text = "Update Month";
            this.updateMonthButton.UseVisualStyleBackColor = true;
            this.updateMonthButton.Click += new System.EventHandler(this.updateMonthButton_Click);
            // 
            // updateDayButton
            // 
            this.updateDayButton.Location = new System.Drawing.Point(203, 132);
            this.updateDayButton.Name = "updateDayButton";
            this.updateDayButton.Size = new System.Drawing.Size(125, 35);
            this.updateDayButton.TabIndex = 9;
            this.updateDayButton.Text = "Update Day";
            this.updateDayButton.UseVisualStyleBackColor = true;
            this.updateDayButton.Click += new System.EventHandler(this.updateDayButton_Click);
            // 
            // updateYearButton
            // 
            this.updateYearButton.AutoSize = true;
            this.updateYearButton.Location = new System.Drawing.Point(203, 179);
            this.updateYearButton.Name = "updateYearButton";
            this.updateYearButton.Size = new System.Drawing.Size(125, 30);
            this.updateYearButton.TabIndex = 10;
            this.updateYearButton.Text = "Update Year";
            this.updateYearButton.UseVisualStyleBackColor = true;
            this.updateYearButton.Click += new System.EventHandler(this.updateYearButton_Click);
            // 
            // DateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 244);
            this.Controls.Add(this.updateYearButton);
            this.Controls.Add(this.updateDayButton);
            this.Controls.Add(this.updateMonthButton);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.yearPromptLbl);
            this.Controls.Add(this.dayPromptLbl);
            this.Controls.Add(this.monthPromptLbl);
            this.Controls.Add(this.dateOutputLbl);
            this.Controls.Add(this.datePromptLbl);
            this.Name = "DateForm";
            this.Text = "Lab 9";
            this.Load += new System.EventHandler(this.DateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label datePromptLbl;
        private System.Windows.Forms.Label dateOutputLbl;
        private System.Windows.Forms.Label monthPromptLbl;
        private System.Windows.Forms.Label dayPromptLbl;
        private System.Windows.Forms.Label yearPromptLbl;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Button updateMonthButton;
        private System.Windows.Forms.Button updateDayButton;
        private System.Windows.Forms.Button updateYearButton;
    }
}

