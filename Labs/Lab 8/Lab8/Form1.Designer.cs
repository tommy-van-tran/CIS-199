namespace Lab8
{
    partial class lab8Form
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
            this.distancePromptLbl = new System.Windows.Forms.Label();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.pricePromptLbl = new System.Windows.Forms.Label();
            this.priceOutputLbl = new System.Windows.Forms.Label();
            this.viewPriceBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(46, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(362, 25);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Whippet Bus Co. Ticket Price Finder";
            // 
            // distancePromptLbl
            // 
            this.distancePromptLbl.AutoSize = true;
            this.distancePromptLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distancePromptLbl.Location = new System.Drawing.Point(142, 69);
            this.distancePromptLbl.Name = "distancePromptLbl";
            this.distancePromptLbl.Size = new System.Drawing.Size(170, 22);
            this.distancePromptLbl.TabIndex = 1;
            this.distancePromptLbl.Text = "Enter Trip Distance:";
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceTextBox.Location = new System.Drawing.Point(170, 103);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(100, 28);
            this.distanceTextBox.TabIndex = 2;
            this.distanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pricePromptLbl
            // 
            this.pricePromptLbl.AutoSize = true;
            this.pricePromptLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePromptLbl.Location = new System.Drawing.Point(157, 143);
            this.pricePromptLbl.Name = "pricePromptLbl";
            this.pricePromptLbl.Size = new System.Drawing.Size(137, 22);
            this.pricePromptLbl.TabIndex = 3;
            this.pricePromptLbl.Text = "Ticket Price ($):";
            // 
            // priceOutputLbl
            // 
            this.priceOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceOutputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceOutputLbl.Location = new System.Drawing.Point(170, 177);
            this.priceOutputLbl.Name = "priceOutputLbl";
            this.priceOutputLbl.Size = new System.Drawing.Size(100, 28);
            this.priceOutputLbl.TabIndex = 4;
            this.priceOutputLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewPriceBtn
            // 
            this.viewPriceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPriceBtn.Location = new System.Drawing.Point(110, 246);
            this.viewPriceBtn.Name = "viewPriceBtn";
            this.viewPriceBtn.Size = new System.Drawing.Size(105, 32);
            this.viewPriceBtn.TabIndex = 5;
            this.viewPriceBtn.Text = "View Price";
            this.viewPriceBtn.UseVisualStyleBackColor = true;
            this.viewPriceBtn.Click += new System.EventHandler(this.viewPriceBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(239, 246);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(105, 32);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // lab8Form
            // 
            this.AcceptButton = this.viewPriceBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 296);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.viewPriceBtn);
            this.Controls.Add(this.priceOutputLbl);
            this.Controls.Add(this.pricePromptLbl);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.distancePromptLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "lab8Form";
            this.Text = "Lab 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label distancePromptLbl;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.Label pricePromptLbl;
        private System.Windows.Forms.Label priceOutputLbl;
        private System.Windows.Forms.Button viewPriceBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

