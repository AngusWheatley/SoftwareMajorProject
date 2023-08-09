namespace SoftwareMajorProject
{
    partial class HomePage
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
            this.picBackPlate = new System.Windows.Forms.PictureBox();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.BtnDiary = new System.Windows.Forms.Button();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBackPlate)).BeginInit();
            this.SuspendLayout();
            // 
            // picBackPlate
            // 
            this.picBackPlate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBackPlate.Location = new System.Drawing.Point(427, 5);
            this.picBackPlate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBackPlate.Name = "picBackPlate";
            this.picBackPlate.Size = new System.Drawing.Size(1067, 985);
            this.picBackPlate.TabIndex = 6;
            this.picBackPlate.TabStop = false;
            // 
            // btnNotifications
            // 
            this.btnNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifications.Location = new System.Drawing.Point(596, 480);
            this.btnNotifications.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(349, 250);
            this.btnNotifications.TabIndex = 7;
            this.btnNotifications.Text = "Notifications";
            this.btnNotifications.UseVisualStyleBackColor = true;
            this.btnNotifications.Click += new System.EventHandler(this.BtnReminder_Click);
            // 
            // BtnDiary
            // 
            this.BtnDiary.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiary.Location = new System.Drawing.Point(987, 480);
            this.BtnDiary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDiary.Name = "BtnDiary";
            this.BtnDiary.Size = new System.Drawing.Size(349, 250);
            this.BtnDiary.TabIndex = 8;
            this.BtnDiary.Text = "Diary";
            this.BtnDiary.UseVisualStyleBackColor = true;
            this.BtnDiary.Click += new System.EventHandler(this.BtnDiary_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.Location = new System.Drawing.Point(761, 890);
            this.BtnLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(184, 86);
            this.BtnLogOut.TabIndex = 26;
            this.BtnLogOut.Text = "Log Out";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.Location = new System.Drawing.Point(987, 890);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(177, 85);
            this.BtnSettings.TabIndex = 30;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(833, 89);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 73);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "Noter";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(716, 331);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(193, 42);
            this.lblWelcome.TabIndex = 32;
            this.lblWelcome.Text = "Welcome: ";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1899, 1010);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.BtnDiary);
            this.Controls.Add(this.btnNotifications);
            this.Controls.Add(this.picBackPlate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1915, 1049);
            this.MinimumSize = new System.Drawing.Size(1915, 1030);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Noter - Home";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackPlate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackPlate;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button BtnDiary;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
    }
}