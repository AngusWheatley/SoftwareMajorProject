namespace SoftwareMajorProject
{
    partial class NoterSettings
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
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
            "Blue",
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1017, 631);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 97);
            this.button1.TabIndex = 10;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(1196, 345);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(132, 22);
            this.txtUserName.TabIndex = 11;
            // 
            // NoterSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1899, 1010);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnSaveSettings);
            this.Controls.Add(this.lblBackgroundColour);
            this.Controls.Add(this.CmbBackgroundColour);
            this.Controls.Add(this.picBackPlate);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1915, 1049);
            this.MinimumSize = new System.Drawing.Size(1915, 1030);
            this.Name = "NoterSettings";
            this.Text = "Settings";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUserName;
    }
}