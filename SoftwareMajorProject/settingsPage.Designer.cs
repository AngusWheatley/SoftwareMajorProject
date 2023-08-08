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
            this.picBackPlate.Location = new System.Drawing.Point(347, 15);
            this.picBackPlate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBackPlate.Name = "picBackPlate";
            this.picBackPlate.Size = new System.Drawing.Size(1226, 984);
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
            "DodgerBlue",
            "LightSteelBlue",
            "Purple"});
            this.CmbBackgroundColour.Location = new System.Drawing.Point(437, 219);
            this.CmbBackgroundColour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbBackgroundColour.Name = "CmbBackgroundColour";
            this.CmbBackgroundColour.Size = new System.Drawing.Size(227, 28);
            this.CmbBackgroundColour.TabIndex = 7;
            // 
            // lblBackgroundColour
            // 
            this.lblBackgroundColour.AutoSize = true;
            this.lblBackgroundColour.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBackgroundColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackgroundColour.Location = new System.Drawing.Point(432, 191);
            this.lblBackgroundColour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBackgroundColour.Name = "lblBackgroundColour";
            this.lblBackgroundColour.Size = new System.Drawing.Size(149, 20);
            this.lblBackgroundColour.TabIndex = 8;
            this.lblBackgroundColour.Text = "Background Colour:";
            // 
            // BtnSaveSettings
            // 
            this.BtnSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveSettings.Location = new System.Drawing.Point(487, 682);
            this.BtnSaveSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSaveSettings.Name = "BtnSaveSettings";
            this.BtnSaveSettings.Size = new System.Drawing.Size(200, 75);
            this.BtnSaveSettings.TabIndex = 9;
            this.BtnSaveSettings.Text = "Save Settings";
            this.BtnSaveSettings.UseVisualStyleBackColor = true;
            this.BtnSaveSettings.Click += new System.EventHandler(this.BtnSaveSettings_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.Location = new System.Drawing.Point(720, 682);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(200, 75);
            this.BtnHome.TabIndex = 10;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // lblForegroundColour
            // 
            this.lblForegroundColour.AutoSize = true;
            this.lblForegroundColour.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblForegroundColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForegroundColour.Location = new System.Drawing.Point(432, 295);
            this.lblForegroundColour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            "DodgerBlue",
            "LightSteelBlue",
            "Purple"});
            this.CmbForegroundColour.Location = new System.Drawing.Point(437, 324);
            this.CmbForegroundColour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbForegroundColour.Name = "CmbForegroundColour";
            this.CmbForegroundColour.Size = new System.Drawing.Size(227, 28);
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
            this.cmbFontType.Location = new System.Drawing.Point(437, 420);
            this.cmbFontType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFontType.Name = "cmbFontType";
            this.cmbFontType.Size = new System.Drawing.Size(227, 28);
            this.cmbFontType.TabIndex = 15;
            // 
            // lblFontType
            // 
            this.lblFontType.AutoSize = true;
            this.lblFontType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFontType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontType.Location = new System.Drawing.Point(432, 391);
            this.lblFontType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFontType.Name = "lblFontType";
            this.lblFontType.Size = new System.Drawing.Size(84, 20);
            this.lblFontType.TabIndex = 14;
            this.lblFontType.Text = "Font Type:";
            // 
            // settingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1899, 1010);
            this.Controls.Add(this.cmbFontType);
            this.Controls.Add(this.lblFontType);
            this.Controls.Add(this.CmbForegroundColour);
            this.Controls.Add(this.lblForegroundColour);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.BtnSaveSettings);
            this.Controls.Add(this.lblBackgroundColour);
            this.Controls.Add(this.CmbBackgroundColour);
            this.Controls.Add(this.picBackPlate);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1915, 1049);
            this.MinimumSize = new System.Drawing.Size(1915, 1030);
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
        private System.Windows.Forms.Label lblForegroundColour;
        private System.Windows.Forms.ComboBox CmbForegroundColour;
        private System.Windows.Forms.ComboBox cmbFontType;
        private System.Windows.Forms.Label lblFontType;
    }
}