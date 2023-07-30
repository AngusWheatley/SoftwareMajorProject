namespace SoftwareMajorProject
{
    partial class settingsPage
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
            this.CmbBackgroundColour = new System.Windows.Forms.ComboBox();
            this.lblBackgroundColour = new System.Windows.Forms.Label();
            this.BtnSaveSettings = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblForegroundColour = new System.Windows.Forms.Label();
            this.CmbForegroundColour = new System.Windows.Forms.ComboBox();
            this.cmbFontType = new System.Windows.Forms.ComboBox();
            this.lblFontType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBackPlate)).BeginInit();
            this.SuspendLayout();
            // 
            // picBackPlate
            // 
            this.picBackPlate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBackPlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBackPlate.Location = new System.Drawing.Point(260, 12);
            this.picBackPlate.Name = "picBackPlate";
            this.picBackPlate.Size = new System.Drawing.Size(920, 800);
            this.picBackPlate.TabIndex = 6;
            this.picBackPlate.TabStop = false;
            // 
            // CmbBackgroundColour
            // 
            this.CmbBackgroundColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBackgroundColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBackgroundColour.FormattingEnabled = true;
            this.CmbBackgroundColour.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple"});
            this.CmbBackgroundColour.Location = new System.Drawing.Point(328, 178);
            this.CmbBackgroundColour.Name = "CmbBackgroundColour";
            this.CmbBackgroundColour.Size = new System.Drawing.Size(171, 28);
            this.CmbBackgroundColour.TabIndex = 7;
            // 
            // lblBackgroundColour
            // 
            this.lblBackgroundColour.AutoSize = true;
            this.lblBackgroundColour.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBackgroundColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackgroundColour.Location = new System.Drawing.Point(324, 155);
            this.lblBackgroundColour.Name = "lblBackgroundColour";
            this.lblBackgroundColour.Size = new System.Drawing.Size(149, 20);
            this.lblBackgroundColour.TabIndex = 8;
            this.lblBackgroundColour.Text = "Background Colour:";
            // 
            // BtnSaveSettings
            // 
            this.BtnSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveSettings.Location = new System.Drawing.Point(365, 554);
            this.BtnSaveSettings.Name = "BtnSaveSettings";
            this.BtnSaveSettings.Size = new System.Drawing.Size(150, 61);
            this.BtnSaveSettings.TabIndex = 9;
            this.BtnSaveSettings.Text = "Save Settings";
            this.BtnSaveSettings.UseVisualStyleBackColor = true;
            this.BtnSaveSettings.Click += new System.EventHandler(this.BtnSaveSettings_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.Location = new System.Drawing.Point(540, 554);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(150, 61);
            this.BtnHome.TabIndex = 10;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(897, 280);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 11;
            // 
            // lblForegroundColour
            // 
            this.lblForegroundColour.AutoSize = true;
            this.lblForegroundColour.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblForegroundColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForegroundColour.Location = new System.Drawing.Point(324, 240);
            this.lblForegroundColour.Name = "lblForegroundColour";
            this.lblForegroundColour.Size = new System.Drawing.Size(146, 20);
            this.lblForegroundColour.TabIndex = 12;
            this.lblForegroundColour.Text = "Foreground Colour:";
            // 
            // CmbForegroundColour
            // 
            this.CmbForegroundColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbForegroundColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbForegroundColour.FormattingEnabled = true;
            this.CmbForegroundColour.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple"});
            this.CmbForegroundColour.Location = new System.Drawing.Point(328, 263);
            this.CmbForegroundColour.Name = "CmbForegroundColour";
            this.CmbForegroundColour.Size = new System.Drawing.Size(171, 28);
            this.CmbForegroundColour.TabIndex = 13;
            // 
            // cmbFontType
            // 
            this.cmbFontType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFontType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFontType.FormattingEnabled = true;
            this.cmbFontType.Items.AddRange(new object[] {
            "Microsoft Sans Serif",
            "Helvetica",
            "Calibri",
            "Futura",
            "Times New Roman",
            "Arial",
            "Cambria",
            "Rockwell"});
            this.cmbFontType.Location = new System.Drawing.Point(328, 341);
            this.cmbFontType.Name = "cmbFontType";
            this.cmbFontType.Size = new System.Drawing.Size(171, 28);
            this.cmbFontType.TabIndex = 15;
            // 
            // lblFontType
            // 
            this.lblFontType.AutoSize = true;
            this.lblFontType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFontType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontType.Location = new System.Drawing.Point(324, 318);
            this.lblFontType.Name = "lblFontType";
            this.lblFontType.Size = new System.Drawing.Size(84, 20);
            this.lblFontType.TabIndex = 14;
            this.lblFontType.Text = "Font Type:";
            this.lblFontType.Click += new System.EventHandler(this.lblFontType_Click);
            // 
            // settingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1424, 821);
            this.Controls.Add(this.cmbFontType);
            this.Controls.Add(this.lblFontType);
            this.Controls.Add(this.CmbForegroundColour);
            this.Controls.Add(this.lblForegroundColour);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.BtnSaveSettings);
            this.Controls.Add(this.lblBackgroundColour);
            this.Controls.Add(this.CmbBackgroundColour);
            this.Controls.Add(this.picBackPlate);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.MinimumSize = new System.Drawing.Size(1440, 844);
            this.Name = "settingsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Noter - Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackPlate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackPlate;
        private System.Windows.Forms.ComboBox CmbBackgroundColour;
        private System.Windows.Forms.Label lblBackgroundColour;
        private System.Windows.Forms.Button BtnSaveSettings;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblForegroundColour;
        private System.Windows.Forms.ComboBox CmbForegroundColour;
        private System.Windows.Forms.ComboBox cmbFontType;
        private System.Windows.Forms.Label lblFontType;
    }
}