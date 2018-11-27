namespace Lab1
{
    partial class Lab1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab1));
            this.pictureOfMe = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.viewHobbiesButton = new System.Windows.Forms.Button();
            this.viewBookButton = new System.Windows.Forms.Button();
            this.viewMovieButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOfMe)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureOfMe
            // 
            this.pictureOfMe.Enabled = false;
            this.pictureOfMe.Image = ((System.Drawing.Image)(resources.GetObject("pictureOfMe.Image")));
            this.pictureOfMe.ImageLocation = "";
            this.pictureOfMe.Location = new System.Drawing.Point(87, 12);
            this.pictureOfMe.Name = "pictureOfMe";
            this.pictureOfMe.Size = new System.Drawing.Size(395, 268);
            this.pictureOfMe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureOfMe.TabIndex = 0;
            this.pictureOfMe.TabStop = false;
            this.pictureOfMe.Click += new System.EventHandler(this.pictureOfMe_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(178, 283);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(191, 23);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Tommy (Quang) Tran";
            // 
            // viewHobbiesButton
            // 
            this.viewHobbiesButton.AutoSize = true;
            this.viewHobbiesButton.Location = new System.Drawing.Point(87, 361);
            this.viewHobbiesButton.Name = "viewHobbiesButton";
            this.viewHobbiesButton.Size = new System.Drawing.Size(80, 30);
            this.viewHobbiesButton.TabIndex = 2;
            this.viewHobbiesButton.Text = "Hobbies";
            this.viewHobbiesButton.UseVisualStyleBackColor = true;
            this.viewHobbiesButton.Click += new System.EventHandler(this.viewHobbiesButton_Click);
            // 
            // viewBookButton
            // 
            this.viewBookButton.AutoSize = true;
            this.viewBookButton.Location = new System.Drawing.Point(247, 361);
            this.viewBookButton.Name = "viewBookButton";
            this.viewBookButton.Size = new System.Drawing.Size(80, 30);
            this.viewBookButton.TabIndex = 3;
            this.viewBookButton.Text = "Book";
            this.viewBookButton.UseVisualStyleBackColor = true;
            this.viewBookButton.Click += new System.EventHandler(this.viewBookButton_Click);
            // 
            // viewMovieButton
            // 
            this.viewMovieButton.AutoSize = true;
            this.viewMovieButton.Location = new System.Drawing.Point(402, 361);
            this.viewMovieButton.Name = "viewMovieButton";
            this.viewMovieButton.Size = new System.Drawing.Size(80, 30);
            this.viewMovieButton.TabIndex = 4;
            this.viewMovieButton.Text = "Movie";
            this.viewMovieButton.UseVisualStyleBackColor = true;
            this.viewMovieButton.Click += new System.EventHandler(this.viewMovieButton_Click);
            // 
            // Lab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 469);
            this.Controls.Add(this.viewMovieButton);
            this.Controls.Add(this.viewBookButton);
            this.Controls.Add(this.viewHobbiesButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.pictureOfMe);
            this.Name = "Lab1";
            this.Text = "Lab 1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureOfMe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureOfMe;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button viewHobbiesButton;
        private System.Windows.Forms.Button viewBookButton;
        private System.Windows.Forms.Button viewMovieButton;
    }
}

