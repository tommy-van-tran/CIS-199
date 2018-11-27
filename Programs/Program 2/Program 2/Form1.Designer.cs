namespace prog2
{
    partial class Prog4
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.enterHoursLbl = new System.Windows.Forms.Label();
            this.enterLastLbl = new System.Windows.Forms.Label();
            this.resultPromptLbl = new System.Windows.Forms.Label();
            this.viewResultsBtn = new System.Windows.Forms.Button();
            this.creditHoursTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.clearFormBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.registrationOutputLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(12, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(581, 29);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "UofL Undergraduate Spring 2017 Priority Registration";
            // 
            // enterHoursLbl
            // 
            this.enterHoursLbl.AutoSize = true;
            this.enterHoursLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterHoursLbl.Location = new System.Drawing.Point(12, 92);
            this.enterHoursLbl.Name = "enterHoursLbl";
            this.enterHoursLbl.Size = new System.Drawing.Size(444, 22);
            this.enterHoursLbl.TabIndex = 0;
            this.enterHoursLbl.Text = "Enter your completed credit hours PRIOR to Fall 2016:";
            // 
            // enterLastLbl
            // 
            this.enterLastLbl.AutoSize = true;
            this.enterLastLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterLastLbl.Location = new System.Drawing.Point(248, 135);
            this.enterLastLbl.Name = "enterLastLbl";
            this.enterLastLbl.Size = new System.Drawing.Size(208, 22);
            this.enterLastLbl.TabIndex = 0;
            this.enterLastLbl.Text = "Enter your full last name:";
            // 
            // resultPromptLbl
            // 
            this.resultPromptLbl.AutoSize = true;
            this.resultPromptLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultPromptLbl.Location = new System.Drawing.Point(132, 239);
            this.resultPromptLbl.Name = "resultPromptLbl";
            this.resultPromptLbl.Size = new System.Drawing.Size(341, 22);
            this.resultPromptLbl.TabIndex = 0;
            this.resultPromptLbl.Text = "Your earliest registration time and date is:";
            // 
            // viewResultsBtn
            // 
            this.viewResultsBtn.Location = new System.Drawing.Point(12, 382);
            this.viewResultsBtn.Name = "viewResultsBtn";
            this.viewResultsBtn.Size = new System.Drawing.Size(181, 40);
            this.viewResultsBtn.TabIndex = 3;
            this.viewResultsBtn.Text = "View Results";
            this.viewResultsBtn.UseVisualStyleBackColor = true;
            this.viewResultsBtn.Click += new System.EventHandler(this.viewResultsBtn_Click);
            // 
            // creditHoursTextBox
            // 
            this.creditHoursTextBox.Location = new System.Drawing.Point(462, 88);
            this.creditHoursTextBox.Name = "creditHoursTextBox";
            this.creditHoursTextBox.Size = new System.Drawing.Size(125, 26);
            this.creditHoursTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(462, 131);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(125, 26);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // clearFormBtn
            // 
            this.clearFormBtn.Location = new System.Drawing.Point(211, 382);
            this.clearFormBtn.Name = "clearFormBtn";
            this.clearFormBtn.Size = new System.Drawing.Size(181, 40);
            this.clearFormBtn.TabIndex = 4;
            this.clearFormBtn.Text = "Clear Form";
            this.clearFormBtn.UseVisualStyleBackColor = true;
            this.clearFormBtn.Click += new System.EventHandler(this.clearFormBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(410, 382);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(181, 40);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // registrationOutputLbl
            // 
            this.registrationOutputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationOutputLbl.Location = new System.Drawing.Point(95, 272);
            this.registrationOutputLbl.Name = "registrationOutputLbl";
            this.registrationOutputLbl.Size = new System.Drawing.Size(415, 23);
            this.registrationOutputLbl.TabIndex = 0;
            this.registrationOutputLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Prog4
            // 
            this.AcceptButton = this.viewResultsBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 444);
            this.Controls.Add(this.registrationOutputLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearFormBtn);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.creditHoursTextBox);
            this.Controls.Add(this.viewResultsBtn);
            this.Controls.Add(this.resultPromptLbl);
            this.Controls.Add(this.enterLastLbl);
            this.Controls.Add(this.enterHoursLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "Prog4";
            this.Text = "Program 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label enterHoursLbl;
        private System.Windows.Forms.Label enterLastLbl;
        private System.Windows.Forms.Label resultPromptLbl;
        private System.Windows.Forms.Button viewResultsBtn;
        private System.Windows.Forms.TextBox creditHoursTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button clearFormBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label registrationOutputLbl;
    }
}

