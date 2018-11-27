namespace Lab4
{
    partial class lab4Form
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
            this.promptLabel = new System.Windows.Forms.Label();
            this.gpaPromptLabel = new System.Windows.Forms.Label();
            this.testPromptLabel = new System.Windows.Forms.Label();
            this.gpaTextBox = new System.Windows.Forms.TextBox();
            this.testScoreTextBox = new System.Windows.Forms.TextBox();
            this.acceptedOutputLbl = new System.Windows.Forms.Label();
            this.rejectedOutputLbl = new System.Windows.Forms.Label();
            this.viewResultBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.Location = new System.Drawing.Point(8, 27);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(443, 51);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Enter in the following information to see whether you will be accepted into the u" +
    "niversity:";
            // 
            // gpaPromptLabel
            // 
            this.gpaPromptLabel.AutoSize = true;
            this.gpaPromptLabel.Location = new System.Drawing.Point(12, 113);
            this.gpaPromptLabel.Name = "gpaPromptLabel";
            this.gpaPromptLabel.Size = new System.Drawing.Size(137, 20);
            this.gpaPromptLabel.TabIndex = 1;
            this.gpaPromptLabel.Text = "High School GPA:";
            // 
            // testPromptLabel
            // 
            this.testPromptLabel.AutoSize = true;
            this.testPromptLabel.Location = new System.Drawing.Point(12, 168);
            this.testPromptLabel.Name = "testPromptLabel";
            this.testPromptLabel.Size = new System.Drawing.Size(167, 20);
            this.testPromptLabel.TabIndex = 2;
            this.testPromptLabel.Text = "Admission Test Score:";
            // 
            // gpaTextBox
            // 
            this.gpaTextBox.Location = new System.Drawing.Point(194, 107);
            this.gpaTextBox.Name = "gpaTextBox";
            this.gpaTextBox.Size = new System.Drawing.Size(100, 26);
            this.gpaTextBox.TabIndex = 3;
            // 
            // testScoreTextBox
            // 
            this.testScoreTextBox.Location = new System.Drawing.Point(194, 162);
            this.testScoreTextBox.Name = "testScoreTextBox";
            this.testScoreTextBox.Size = new System.Drawing.Size(100, 26);
            this.testScoreTextBox.TabIndex = 4;
            // 
            // acceptedOutputLbl
            // 
            this.acceptedOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.acceptedOutputLbl.Location = new System.Drawing.Point(12, 223);
            this.acceptedOutputLbl.Name = "acceptedOutputLbl";
            this.acceptedOutputLbl.Size = new System.Drawing.Size(282, 26);
            this.acceptedOutputLbl.TabIndex = 5;
            // 
            // rejectedOutputLbl
            // 
            this.rejectedOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rejectedOutputLbl.Location = new System.Drawing.Point(12, 284);
            this.rejectedOutputLbl.Name = "rejectedOutputLbl";
            this.rejectedOutputLbl.Size = new System.Drawing.Size(282, 26);
            this.rejectedOutputLbl.TabIndex = 6;
            // 
            // viewResultBtn
            // 
            this.viewResultBtn.AutoSize = true;
            this.viewResultBtn.Location = new System.Drawing.Point(51, 376);
            this.viewResultBtn.Name = "viewResultBtn";
            this.viewResultBtn.Size = new System.Drawing.Size(115, 40);
            this.viewResultBtn.TabIndex = 7;
            this.viewResultBtn.Text = "View Results";
            this.viewResultBtn.UseVisualStyleBackColor = true;
            this.viewResultBtn.Click += new System.EventHandler(this.viewResultBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(313, 376);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(115, 40);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(182, 376);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(115, 40);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // lab4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 444);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.viewResultBtn);
            this.Controls.Add(this.rejectedOutputLbl);
            this.Controls.Add(this.acceptedOutputLbl);
            this.Controls.Add(this.testScoreTextBox);
            this.Controls.Add(this.gpaTextBox);
            this.Controls.Add(this.testPromptLabel);
            this.Controls.Add(this.gpaPromptLabel);
            this.Controls.Add(this.promptLabel);
            this.Name = "lab4Form";
            this.Text = "Lab 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Label gpaPromptLabel;
        private System.Windows.Forms.Label testPromptLabel;
        private System.Windows.Forms.TextBox gpaTextBox;
        private System.Windows.Forms.TextBox testScoreTextBox;
        private System.Windows.Forms.Label acceptedOutputLbl;
        private System.Windows.Forms.Label rejectedOutputLbl;
        private System.Windows.Forms.Button viewResultBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}

