namespace SoftwareMajorProject
{
    partial class EndUserLicenceAgreementPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndUserLicenceAgreementPage));
            this.BtnBack = new System.Windows.Forms.Button();
            this.txtEndUserLicenceAgreement = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(260, 775);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(80, 34);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // txtEndUserLicenceAgreement
            // 
            this.txtEndUserLicenceAgreement.Location = new System.Drawing.Point(12, 12);
            this.txtEndUserLicenceAgreement.Multiline = true;
            this.txtEndUserLicenceAgreement.Name = "txtEndUserLicenceAgreement";
            this.txtEndUserLicenceAgreement.ReadOnly = true;
            this.txtEndUserLicenceAgreement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEndUserLicenceAgreement.Size = new System.Drawing.Size(560, 748);
            this.txtEndUserLicenceAgreement.TabIndex = 2;
            // 
            // EndUserLicenceAgreementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(584, 821);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.txtEndUserLicenceAgreement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EndUserLicenceAgreementPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "End User Licence Agreement - Noter";
            this.Load += new System.EventHandler(this.EndUserLicenceAgreementPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.TextBox txtEndUserLicenceAgreement;
    }
}