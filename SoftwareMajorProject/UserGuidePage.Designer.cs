namespace SoftwareMajorProject
{
    partial class UserGuidePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserGuidePage));
            this.txtUserGuide = new System.Windows.Forms.TextBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUserGuide
            // 
            this.txtUserGuide.Location = new System.Drawing.Point(12, 12);
            this.txtUserGuide.Multiline = true;
            this.txtUserGuide.Name = "txtUserGuide";
            this.txtUserGuide.ReadOnly = true;
            this.txtUserGuide.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUserGuide.Size = new System.Drawing.Size(560, 748);
            this.txtUserGuide.TabIndex = 0;
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(260, 775);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(80, 34);
            this.BtnBack.TabIndex = 27;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // UserGuidePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(584, 821);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.txtUserGuide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserGuidePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Guide - Noter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserGuidePage_FormClosed);
            this.Load += new System.EventHandler(this.UserGuidePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserGuide;
        private System.Windows.Forms.Button BtnBack;
    }
}