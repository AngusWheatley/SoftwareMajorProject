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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.picBackPlate = new System.Windows.Forms.PictureBox();
            this.btnNotificationsPage = new System.Windows.Forms.Button();
            this.BtnDiaryPage = new System.Windows.Forms.Button();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.BtnOtherInformation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBackPlate)).BeginInit();
            this.SuspendLayout();
            // 
            // picBackPlate
            // 
            this.picBackPlate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBackPlate.Location = new System.Drawing.Point(320, 4);
            this.picBackPlate.Margin = new System.Windows.Forms.Padding(2);
            this.picBackPlate.Name = "picBackPlate";
            this.picBackPlate.Size = new System.Drawing.Size(800, 800);
            this.picBackPlate.TabIndex = 6;
            this.picBackPlate.TabStop = false;
            // 
            // btnNotificationsPage
            // 
            this.btnNotificationsPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificationsPage.Location = new System.Drawing.Point(447, 390);
            this.btnNotificationsPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnNotificationsPage.Name = "btnNotificationsPage";
            this.btnNotificationsPage.Size = new System.Drawing.Size(262, 203);
            this.btnNotificationsPage.TabIndex = 7;
            this.btnNotificationsPage.Text = "Notifications";
            this.btnNotificationsPage.UseVisualStyleBackColor = true;
            this.btnNotificationsPage.Click += new System.EventHandler(this.BtnReminderPage_Click);
            // 
            // BtnDiaryPage
            // 
            this.BtnDiaryPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiaryPage.Location = new System.Drawing.Point(740, 390);
            this.BtnDiaryPage.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDiaryPage.Name = "BtnDiaryPage";
            this.BtnDiaryPage.Size = new System.Drawing.Size(262, 203);
            this.BtnDiaryPage.TabIndex = 8;
            this.BtnDiaryPage.Text = "Diary";
            this.BtnDiaryPage.UseVisualStyleBackColor = true;
            this.BtnDiaryPage.Click += new System.EventHandler(this.BtnDiaryPage_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.Location = new System.Drawing.Point(480, 724);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(140, 70);
            this.BtnLogOut.TabIndex = 26;
            this.BtnLogOut.Text = "Log Out";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.Location = new System.Drawing.Point(650, 725);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(140, 70);
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
            this.lblTitle.Location = new System.Drawing.Point(625, 72);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.lblWelcome.Location = new System.Drawing.Point(537, 269);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(193, 42);
            this.lblWelcome.TabIndex = 32;
            this.lblWelcome.Text = "Welcome: ";
            // 
            // BtnOtherInformation
            // 
            this.BtnOtherInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOtherInformation.Location = new System.Drawing.Point(820, 725);
            this.BtnOtherInformation.Name = "BtnOtherInformation";
            this.BtnOtherInformation.Size = new System.Drawing.Size(140, 70);
            this.BtnOtherInformation.TabIndex = 33;
            this.BtnOtherInformation.Text = "Other Information";
            this.BtnOtherInformation.UseVisualStyleBackColor = true;
            this.BtnOtherInformation.Click += new System.EventHandler(this.BtnOtherInformation_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1424, 821);
            this.Controls.Add(this.BtnOtherInformation);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.BtnDiaryPage);
            this.Controls.Add(this.btnNotificationsPage);
            this.Controls.Add(this.picBackPlate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.MinimumSize = new System.Drawing.Size(1440, 860);
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
        private System.Windows.Forms.Button btnNotificationsPage;
        private System.Windows.Forms.Button BtnDiaryPage;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button BtnOtherInformation;
    }
}