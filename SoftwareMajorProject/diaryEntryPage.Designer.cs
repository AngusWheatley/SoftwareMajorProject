namespace SoftwareMajorProject
{
    partial class DiaryEditorPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiaryEditorPage));
            this.picBackPlate = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblEntryContents = new System.Windows.Forms.Label();
            this.TxtEntryContents = new System.Windows.Forms.TextBox();
            this.BtnSaveEntry = new System.Windows.Forms.Button();
            this.TxtEntryTitle = new System.Windows.Forms.TextBox();
            this.lblEntryTitle = new System.Windows.Forms.Label();
            this.lblEntryDate = new System.Windows.Forms.Label();
            this.CalEntryDate = new System.Windows.Forms.MonthCalendar();
            this.BtnAllEntries = new System.Windows.Forms.Button();
            this.lblDiaryEntries = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBackPlate)).BeginInit();
            this.SuspendLayout();
            // 
            // picBackPlate
            // 
            this.picBackPlate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBackPlate.Location = new System.Drawing.Point(83, 8);
            this.picBackPlate.Name = "picBackPlate";
            this.picBackPlate.Size = new System.Drawing.Size(1250, 800);
            this.picBackPlate.TabIndex = 8;
            this.picBackPlate.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(1338, 776);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(80, 32);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // lblEntryContents
            // 
            this.lblEntryContents.AutoSize = true;
            this.lblEntryContents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEntryContents.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryContents.Location = new System.Drawing.Point(127, 239);
            this.lblEntryContents.Name = "lblEntryContents";
            this.lblEntryContents.Size = new System.Drawing.Size(145, 26);
            this.lblEntryContents.TabIndex = 26;
            this.lblEntryContents.Text = "Todays Entry:";
            // 
            // TxtEntryContents
            // 
            this.TxtEntryContents.Location = new System.Drawing.Point(132, 274);
            this.TxtEntryContents.Multiline = true;
            this.TxtEntryContents.Name = "TxtEntryContents";
            this.TxtEntryContents.Size = new System.Drawing.Size(553, 512);
            this.TxtEntryContents.TabIndex = 3;
            // 
            // BtnSaveEntry
            // 
            this.BtnSaveEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveEntry.Location = new System.Drawing.Point(728, 354);
            this.BtnSaveEntry.Name = "BtnSaveEntry";
            this.BtnSaveEntry.Size = new System.Drawing.Size(273, 74);
            this.BtnSaveEntry.TabIndex = 4;
            this.BtnSaveEntry.Text = "Save";
            this.BtnSaveEntry.UseVisualStyleBackColor = true;
            this.BtnSaveEntry.Click += new System.EventHandler(this.BtnSaveEntry_Click);
            // 
            // TxtEntryTitle
            // 
            this.TxtEntryTitle.Location = new System.Drawing.Point(132, 174);
            this.TxtEntryTitle.Multiline = true;
            this.TxtEntryTitle.Name = "TxtEntryTitle";
            this.TxtEntryTitle.Size = new System.Drawing.Size(553, 41);
            this.TxtEntryTitle.TabIndex = 2;
            // 
            // lblEntryTitle
            // 
            this.lblEntryTitle.AutoSize = true;
            this.lblEntryTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEntryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryTitle.Location = new System.Drawing.Point(127, 145);
            this.lblEntryTitle.Name = "lblEntryTitle";
            this.lblEntryTitle.Size = new System.Drawing.Size(215, 26);
            this.lblEntryTitle.TabIndex = 34;
            this.lblEntryTitle.Text = "Title of Todays Entry:";
            // 
            // lblEntryDate
            // 
            this.lblEntryDate.AutoSize = true;
            this.lblEntryDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEntryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryDate.Location = new System.Drawing.Point(723, 145);
            this.lblEntryDate.Name = "lblEntryDate";
            this.lblEntryDate.Size = new System.Drawing.Size(139, 26);
            this.lblEntryDate.TabIndex = 41;
            this.lblEntryDate.Text = "Date of Entry";
            // 
            // CalEntryDate
            // 
            this.CalEntryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalEntryDate.Location = new System.Drawing.Point(728, 180);
            this.CalEntryDate.MaxSelectionCount = 1;
            this.CalEntryDate.Name = "CalEntryDate";
            this.CalEntryDate.ShowTodayCircle = false;
            this.CalEntryDate.TabIndex = 1;
            this.CalEntryDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CalDiaryEntryDate_DateSelected);
            // 
            // BtnAllEntries
            // 
            this.BtnAllEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAllEntries.Location = new System.Drawing.Point(1016, 354);
            this.BtnAllEntries.Name = "BtnAllEntries";
            this.BtnAllEntries.Size = new System.Drawing.Size(273, 74);
            this.BtnAllEntries.TabIndex = 5;
            this.BtnAllEntries.Text = "All Entries";
            this.BtnAllEntries.UseVisualStyleBackColor = true;
            this.BtnAllEntries.Click += new System.EventHandler(this.BtnAllEntries_Click);
            // 
            // lblDiaryEntries
            // 
            this.lblDiaryEntries.AutoSize = true;
            this.lblDiaryEntries.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDiaryEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaryEntries.Location = new System.Drawing.Point(578, 32);
            this.lblDiaryEntries.Name = "lblDiaryEntries";
            this.lblDiaryEntries.Size = new System.Drawing.Size(298, 55);
            this.lblDiaryEntries.TabIndex = 45;
            this.lblDiaryEntries.Text = "Diary Entries";
            // 
            // DiaryEditorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1424, 821);
            this.Controls.Add(this.lblDiaryEntries);
            this.Controls.Add(this.BtnAllEntries);
            this.Controls.Add(this.lblEntryDate);
            this.Controls.Add(this.CalEntryDate);
            this.Controls.Add(this.TxtEntryTitle);
            this.Controls.Add(this.lblEntryTitle);
            this.Controls.Add(this.BtnSaveEntry);
            this.Controls.Add(this.TxtEntryContents);
            this.Controls.Add(this.lblEntryContents);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.picBackPlate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.MinimumSize = new System.Drawing.Size(1440, 860);
            this.Name = "DiaryEditorPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Noter - Diary Entry";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DiaryEditorPage_FormClosed);
            this.Load += new System.EventHandler(this.DiaryEditorPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackPlate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackPlate;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblEntryContents;
        private System.Windows.Forms.TextBox TxtEntryContents;
        private System.Windows.Forms.Button BtnSaveEntry;
        private System.Windows.Forms.TextBox TxtEntryTitle;
        private System.Windows.Forms.Label lblEntryTitle;
        private System.Windows.Forms.Label lblEntryDate;
        private System.Windows.Forms.MonthCalendar CalEntryDate;
        private System.Windows.Forms.Button BtnAllEntries;
        private System.Windows.Forms.Label lblDiaryEntries;
    }
}