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
            this.btnReminder = new System.Windows.Forms.Button();
            this.btnDiary = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.TxtUserEmail = new System.Windows.Forms.TextBox();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.txtUserBackgroundColour = new System.Windows.Forms.TextBox();
            this.txtUserForegroundColour = new System.Windows.Forms.TextBox();
            this.txtUserFont = new System.Windows.Forms.TextBox();
            this.txtReplacedUserName = new System.Windows.Forms.TextBox();
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
            // btnReminder
            // 
            this.btnReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReminder.Location = new System.Drawing.Point(447, 390);
            this.btnReminder.Margin = new System.Windows.Forms.Padding(2);
            this.btnReminder.Name = "btnReminder";
            this.btnReminder.Size = new System.Drawing.Size(262, 203);
            this.btnReminder.TabIndex = 7;
            this.btnReminder.Text = "Reminders";
            this.btnReminder.UseVisualStyleBackColor = true;
            this.btnReminder.Click += new System.EventHandler(this.BtnReminder_Click);
            // 
            // btnDiary
            // 
            this.btnDiary.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiary.Location = new System.Drawing.Point(740, 390);
            this.btnDiary.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiary.Name = "btnDiary";
            this.btnDiary.Size = new System.Drawing.Size(262, 203);
            this.btnDiary.TabIndex = 8;
            this.btnDiary.Text = "Diary";
            this.btnDiary.UseVisualStyleBackColor = true;
            this.btnDiary.Click += new System.EventHandler(this.btnDiary_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(675, 762);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(90, 32);
            this.btnHome.TabIndex = 26;
            this.btnHome.Text = "Log Out";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(61, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 20);
            this.txtName.TabIndex = 27;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(61, 111);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(142, 20);
            this.txtPassword.TabIndex = 28;
            // 
            // TxtUserEmail
            // 
            this.TxtUserEmail.Location = new System.Drawing.Point(61, 163);
            this.TxtUserEmail.Name = "TxtUserEmail";
            this.TxtUserEmail.Size = new System.Drawing.Size(142, 20);
            this.TxtUserEmail.TabIndex = 29;
            // 
            // BtnSettings
            // 
            this.BtnSettings.Location = new System.Drawing.Point(839, 725);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(133, 69);
            this.BtnSettings.TabIndex = 30;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // txtUserBackgroundColour
            // 
            this.txtUserBackgroundColour.Location = new System.Drawing.Point(1165, 195);
            this.txtUserBackgroundColour.Name = "txtUserBackgroundColour";
            this.txtUserBackgroundColour.Size = new System.Drawing.Size(110, 20);
            this.txtUserBackgroundColour.TabIndex = 31;
            // 
            // txtUserForegroundColour
            // 
            this.txtUserForegroundColour.Location = new System.Drawing.Point(1165, 232);
            this.txtUserForegroundColour.Name = "txtUserForegroundColour";
            this.txtUserForegroundColour.Size = new System.Drawing.Size(110, 20);
            this.txtUserForegroundColour.TabIndex = 32;
            // 
            // txtUserFont
            // 
            this.txtUserFont.Location = new System.Drawing.Point(1165, 268);
            this.txtUserFont.Name = "txtUserFont";
            this.txtUserFont.Size = new System.Drawing.Size(110, 20);
            this.txtUserFont.TabIndex = 33;
            // 
            // txtReplacedUserName
            // 
            this.txtReplacedUserName.Location = new System.Drawing.Point(1165, 163);
            this.txtReplacedUserName.Name = "txtReplacedUserName";
            this.txtReplacedUserName.Size = new System.Drawing.Size(110, 20);
            this.txtReplacedUserName.TabIndex = 34;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1424, 821);
            this.Controls.Add(this.txtReplacedUserName);
            this.Controls.Add(this.txtUserFont);
            this.Controls.Add(this.txtUserForegroundColour);
            this.Controls.Add(this.txtUserBackgroundColour);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.TxtUserEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnDiary);
            this.Controls.Add(this.btnReminder);
            this.Controls.Add(this.picBackPlate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.MinimumSize = new System.Drawing.Size(1440, 860);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Noter - Home Page";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackPlate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackPlate;
        private System.Windows.Forms.Button btnReminder;
        private System.Windows.Forms.Button btnDiary;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox TxtUserEmail;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.TextBox txtUserBackgroundColour;
        private System.Windows.Forms.TextBox txtUserForegroundColour;
        private System.Windows.Forms.TextBox txtUserFont;
        private System.Windows.Forms.TextBox txtReplacedUserName;
    }
}