namespace Program3
{
    partial class prog3Form
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
            this.dateTimeLbl = new System.Windows.Forms.Label();
            this.RegLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.creditHrLbl = new System.Windows.Forms.Label();
            this.findRegTimeBtn = new System.Windows.Forms.Button();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.creditHrTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimeLbl
            // 
            this.dateTimeLbl.AutoSize = true;
            this.dateTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLbl.Location = new System.Drawing.Point(102, 266);
            this.dateTimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateTimeLbl.Name = "dateTimeLbl";
            this.dateTimeLbl.Size = new System.Drawing.Size(0, 20);
            this.dateTimeLbl.TabIndex = 13;
            // 
            // RegLbl
            // 
            this.RegLbl.AutoSize = true;
            this.RegLbl.Location = new System.Drawing.Point(98, 240);
            this.RegLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegLbl.Name = "RegLbl";
            this.RegLbl.Size = new System.Drawing.Size(229, 20);
            this.RegLbl.TabIndex = 12;
            this.RegLbl.Text = "The earliest you may register is:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(160, 97);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(88, 20);
            this.nameLbl.TabIndex = 11;
            this.nameLbl.Text = "Last name:";
            // 
            // creditHrLbl
            // 
            this.creditHrLbl.AutoSize = true;
            this.creditHrLbl.Location = new System.Drawing.Point(44, 56);
            this.creditHrLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.creditHrLbl.Name = "creditHrLbl";
            this.creditHrLbl.Size = new System.Drawing.Size(185, 20);
            this.creditHrLbl.TabIndex = 10;
            this.creditHrLbl.Text = "Credits prior to Fall 2016:";
            // 
            // findRegTimeBtn
            // 
            this.findRegTimeBtn.Location = new System.Drawing.Point(138, 165);
            this.findRegTimeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.findRegTimeBtn.Name = "findRegTimeBtn";
            this.findRegTimeBtn.Size = new System.Drawing.Size(148, 35);
            this.findRegTimeBtn.TabIndex = 9;
            this.findRegTimeBtn.Text = "Find Reg. Time";
            this.findRegTimeBtn.UseVisualStyleBackColor = true;
            this.findRegTimeBtn.Click += new System.EventHandler(this.findRegTimeBtn_Click);
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(258, 93);
            this.lastNameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(148, 26);
            this.lastNameTxt.TabIndex = 8;
            // 
            // creditHrTxt
            // 
            this.creditHrTxt.Location = new System.Drawing.Point(258, 51);
            this.creditHrTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.creditHrTxt.Name = "creditHrTxt";
            this.creditHrTxt.Size = new System.Drawing.Size(148, 26);
            this.creditHrTxt.TabIndex = 7;
            // 
            // prog3Form
            // 
            this.AcceptButton = this.findRegTimeBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 337);
            this.Controls.Add(this.dateTimeLbl);
            this.Controls.Add(this.RegLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.creditHrLbl);
            this.Controls.Add(this.findRegTimeBtn);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.creditHrTxt);
            this.Name = "prog3Form";
            this.Text = "Program 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateTimeLbl;
        private System.Windows.Forms.Label RegLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label creditHrLbl;
        private System.Windows.Forms.Button findRegTimeBtn;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.TextBox creditHrTxt;
    }
}

