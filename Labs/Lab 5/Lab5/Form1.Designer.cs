namespace Lab5
{
    partial class lab5
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
            System.Windows.Forms.Button clearListButton;
            this.fromPromptLbl = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toPromptLbl = new System.Windows.Forms.Label();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.loopOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.whileRadioBtn = new System.Windows.Forms.RadioButton();
            this.forRadioBtn = new System.Windows.Forms.RadioButton();
            this.doWhileRadioBtn = new System.Windows.Forms.RadioButton();
            this.runLoopBtn = new System.Windows.Forms.Button();
            this.outputListBox = new System.Windows.Forms.ListBox();
            clearListButton = new System.Windows.Forms.Button();
            this.loopOptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fromPromptLbl
            // 
            this.fromPromptLbl.AutoSize = true;
            this.fromPromptLbl.Location = new System.Drawing.Point(8, 22);
            this.fromPromptLbl.Name = "fromPromptLbl";
            this.fromPromptLbl.Size = new System.Drawing.Size(50, 20);
            this.fromPromptLbl.TabIndex = 0;
            this.fromPromptLbl.Text = "From:";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(12, 45);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(115, 26);
            this.fromTextBox.TabIndex = 1;
            // 
            // toPromptLbl
            // 
            this.toPromptLbl.AutoSize = true;
            this.toPromptLbl.Location = new System.Drawing.Point(8, 93);
            this.toPromptLbl.Name = "toPromptLbl";
            this.toPromptLbl.Size = new System.Drawing.Size(31, 20);
            this.toPromptLbl.TabIndex = 2;
            this.toPromptLbl.Text = "To:";
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(12, 116);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(115, 26);
            this.toTextBox.TabIndex = 3;
            // 
            // loopOptionsGroupBox
            // 
            this.loopOptionsGroupBox.Controls.Add(this.doWhileRadioBtn);
            this.loopOptionsGroupBox.Controls.Add(this.forRadioBtn);
            this.loopOptionsGroupBox.Controls.Add(this.whileRadioBtn);
            this.loopOptionsGroupBox.Location = new System.Drawing.Point(12, 177);
            this.loopOptionsGroupBox.Name = "loopOptionsGroupBox";
            this.loopOptionsGroupBox.Size = new System.Drawing.Size(115, 170);
            this.loopOptionsGroupBox.TabIndex = 4;
            this.loopOptionsGroupBox.TabStop = false;
            this.loopOptionsGroupBox.Text = "Loop Using:";
            // 
            // whileRadioBtn
            // 
            this.whileRadioBtn.AutoSize = true;
            this.whileRadioBtn.Checked = true;
            this.whileRadioBtn.Location = new System.Drawing.Point(6, 53);
            this.whileRadioBtn.Name = "whileRadioBtn";
            this.whileRadioBtn.Size = new System.Drawing.Size(69, 24);
            this.whileRadioBtn.TabIndex = 0;
            this.whileRadioBtn.TabStop = true;
            this.whileRadioBtn.Text = "while";
            this.whileRadioBtn.UseVisualStyleBackColor = true;
            // 
            // forRadioBtn
            // 
            this.forRadioBtn.AutoSize = true;
            this.forRadioBtn.Location = new System.Drawing.Point(6, 90);
            this.forRadioBtn.Name = "forRadioBtn";
            this.forRadioBtn.Size = new System.Drawing.Size(53, 24);
            this.forRadioBtn.TabIndex = 1;
            this.forRadioBtn.Text = "for";
            this.forRadioBtn.UseVisualStyleBackColor = true;
            // 
            // doWhileRadioBtn
            // 
            this.doWhileRadioBtn.AutoSize = true;
            this.doWhileRadioBtn.Location = new System.Drawing.Point(7, 127);
            this.doWhileRadioBtn.Name = "doWhileRadioBtn";
            this.doWhileRadioBtn.Size = new System.Drawing.Size(92, 24);
            this.doWhileRadioBtn.TabIndex = 2;
            this.doWhileRadioBtn.Text = "do-while";
            this.doWhileRadioBtn.UseVisualStyleBackColor = true;
            // 
            // runLoopBtn
            // 
            this.runLoopBtn.Location = new System.Drawing.Point(12, 379);
            this.runLoopBtn.Name = "runLoopBtn";
            this.runLoopBtn.Size = new System.Drawing.Size(115, 35);
            this.runLoopBtn.TabIndex = 5;
            this.runLoopBtn.Text = "Run Loop";
            this.runLoopBtn.UseVisualStyleBackColor = true;
            this.runLoopBtn.Click += new System.EventHandler(this.runLoopBtn_Click);
            // 
            // clearListButton
            // 
            clearListButton.Location = new System.Drawing.Point(12, 431);
            clearListButton.Name = "clearListButton";
            clearListButton.Size = new System.Drawing.Size(115, 35);
            clearListButton.TabIndex = 6;
            clearListButton.Text = "Clear List";
            clearListButton.UseVisualStyleBackColor = true;
            clearListButton.Click += new System.EventHandler(this.clearListButton_Click);
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 20;
            this.outputListBox.Location = new System.Drawing.Point(166, 22);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(150, 444);
            this.outputListBox.TabIndex = 7;
            // 
            // lab5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 497);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(clearListButton);
            this.Controls.Add(this.runLoopBtn);
            this.Controls.Add(this.loopOptionsGroupBox);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.toPromptLbl);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.fromPromptLbl);
            this.Name = "lab5";
            this.Text = "Lab 5";
            this.loopOptionsGroupBox.ResumeLayout(false);
            this.loopOptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fromPromptLbl;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.Label toPromptLbl;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.GroupBox loopOptionsGroupBox;
        private System.Windows.Forms.RadioButton doWhileRadioBtn;
        private System.Windows.Forms.RadioButton forRadioBtn;
        private System.Windows.Forms.RadioButton whileRadioBtn;
        private System.Windows.Forms.Button runLoopBtn;
        private System.Windows.Forms.ListBox outputListBox;
    }
}

