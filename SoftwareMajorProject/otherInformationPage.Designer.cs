namespace SoftwareMajorProject
{
    partial class OtherInformationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherInformationPage));
            this.picBackPlate = new System.Windows.Forms.PictureBox();
            this.BtnHome = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.BtnUserGuide = new System.Windows.Forms.Button();
            this.BtnEndUserLicenceAgreement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBackPlate)).BeginInit();
            this.SuspendLayout();
            // 
            // picBackPlate
            // 
            this.picBackPlate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBackPlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBackPlate.Location = new System.Drawing.Point(12, 12);
            this.picBackPlate.Name = "picBackPlate";
            this.picBackPlate.Size = new System.Drawing.Size(460, 290);
            this.picBackPlate.TabIndex = 7;
            this.picBackPlate.TabStop = false;
            // 
            // BtnHome
            // 
            this.BtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.Location = new System.Drawing.Point(202, 252);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(80, 34);
            this.BtnHome.TabIndex = 25;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(62, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(377, 31);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "Other Information About Noter";
            // 
            // BtnUserGuide
            // 
            this.BtnUserGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUserGuide.Location = new System.Drawing.Point(56, 84);
            this.BtnUserGuide.Name = "BtnUserGuide";
            this.BtnUserGuide.Size = new System.Drawing.Size(151, 142);
            this.BtnUserGuide.TabIndex = 27;
            this.BtnUserGuide.Text = "User Guide";
            this.BtnUserGuide.UseVisualStyleBackColor = true;
            this.BtnUserGuide.Click += new System.EventHandler(this.BtnUserGuide_Click);
            // 
            // BtnEndUserLicenceAgreement
            // 
            this.BtnEndUserLicenceAgreement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEndUserLicenceAgreement.Location = new System.Drawing.Point(276, 84);
            this.BtnEndUserLicenceAgreement.Name = "BtnEndUserLicenceAgreement";
            this.BtnEndUserLicenceAgreement.Size = new System.Drawing.Size(151, 142);
            this.BtnEndUserLicenceAgreement.TabIndex = 28;
            this.BtnEndUserLicenceAgreement.Text = "EULA";
            this.BtnEndUserLicenceAgreement.UseVisualStyleBackColor = true;
            this.BtnEndUserLicenceAgreement.Click += new System.EventHandler(this.BtnEndUserLicenceAgreement_Click);
            // 
            // OtherInformationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.BtnEndUserLicenceAgreement);
            this.Controls.Add(this.BtnUserGuide);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.picBackPlate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 350);
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "OtherInformationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Other Information - Noter";
            this.Load += new System.EventHandler(this.OtherInformationPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackPlate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackPlate;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button BtnUserGuide;
        private System.Windows.Forms.Button BtnEndUserLicenceAgreement;
    }
}