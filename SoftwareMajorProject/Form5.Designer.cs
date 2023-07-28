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
            this.picBackPlate = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblEntryContents = new System.Windows.Forms.Label();
            this.TxtEntryContents = new System.Windows.Forms.TextBox();
            this.BtnDeleteEntry = new System.Windows.Forms.Button();
            this.BtnSaveEntry = new System.Windows.Forms.Button();
            this.TxtEntryTitle = new System.Windows.Forms.TextBox();
            this.lblEntryTitle = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblEntryDate = new System.Windows.Forms.Label();
            this.CalEntryDate = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.picBackPlate)).BeginInit();
            this.SuspendLayout();
            // 
            // picBackPlate
            // 
            this.picBackPlate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBackPlate.Location = new System.Drawing.Point(111, 10);
            this.picBackPlate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBackPlate.Name = "picBackPlate";
            this.picBackPlate.Size = new System.Drawing.Size(1667, 985);
            this.picBackPlate.TabIndex = 8;
            this.picBackPlate.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(1784, 955);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(107, 39);
            this.btnHome.TabIndex = 25;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // lblEntryContents
            // 
            this.lblEntryContents.AutoSize = true;
            this.lblEntryContents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEntryContents.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryContents.Location = new System.Drawing.Point(169, 294);
            this.lblEntryContents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntryContents.Name = "lblEntryContents";
            this.lblEntryContents.Size = new System.Drawing.Size(145, 26);
            this.lblEntryContents.TabIndex = 26;
            this.lblEntryContents.Text = "Todays Entry:";
            // 
            // TxtEntryContents
            // 
            this.TxtEntryContents.Location = new System.Drawing.Point(176, 337);
            this.TxtEntryContents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtEntryContents.Multiline = true;
            this.TxtEntryContents.Name = "TxtEntryContents";
            this.TxtEntryContents.Size = new System.Drawing.Size(736, 629);
            this.TxtEntryContents.TabIndex = 27;
            // 
            // BtnDeleteEntry
            // 
            this.BtnDeleteEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteEntry.Location = new System.Drawing.Point(1355, 436);
            this.BtnDeleteEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnDeleteEntry.Name = "BtnDeleteEntry";
            this.BtnDeleteEntry.Size = new System.Drawing.Size(364, 91);
            this.BtnDeleteEntry.TabIndex = 33;
            this.BtnDeleteEntry.Text = "Delete";
            this.BtnDeleteEntry.UseVisualStyleBackColor = true;
            // 
            // BtnSaveEntry
            // 
            this.BtnSaveEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveEntry.Location = new System.Drawing.Point(971, 436);
            this.BtnSaveEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSaveEntry.Name = "BtnSaveEntry";
            this.BtnSaveEntry.Size = new System.Drawing.Size(364, 91);
            this.BtnSaveEntry.TabIndex = 32;
            this.BtnSaveEntry.Text = "Save";
            this.BtnSaveEntry.UseVisualStyleBackColor = true;
            this.BtnSaveEntry.Click += new System.EventHandler(this.BtnSaveEntry_Click);
            // 
            // TxtEntryTitle
            // 
            this.TxtEntryTitle.Location = new System.Drawing.Point(176, 214);
            this.TxtEntryTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtEntryTitle.Multiline = true;
            this.TxtEntryTitle.Name = "TxtEntryTitle";
            this.TxtEntryTitle.Size = new System.Drawing.Size(736, 50);
            this.TxtEntryTitle.TabIndex = 35;
            // 
            // lblEntryTitle
            // 
            this.lblEntryTitle.AutoSize = true;
            this.lblEntryTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEntryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryTitle.Location = new System.Drawing.Point(169, 178);
            this.lblEntryTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntryTitle.Name = "lblEntryTitle";
            this.lblEntryTitle.Size = new System.Drawing.Size(215, 26);
            this.lblEntryTitle.TabIndex = 34;
            this.lblEntryTitle.Text = "Title of Todays Entry:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(271, 66);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(152, 22);
            this.txtUserName.TabIndex = 36;
            // 
            // lblEntryDate
            // 
            this.lblEntryDate.AutoSize = true;
            this.lblEntryDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEntryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryDate.Location = new System.Drawing.Point(964, 178);
            this.lblEntryDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntryDate.Name = "lblEntryDate";
            this.lblEntryDate.Size = new System.Drawing.Size(139, 26);
            this.lblEntryDate.TabIndex = 41;
            this.lblEntryDate.Text = "Date of Entry";
            // 
            // CalEntryDate
            // 
            this.CalEntryDate.Location = new System.Drawing.Point(971, 222);
            this.CalEntryDate.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.CalEntryDate.MaxSelectionCount = 1;
            this.CalEntryDate.Name = "CalEntryDate";
            this.CalEntryDate.ShowTodayCircle = false;
            this.CalEntryDate.TabIndex = 37;
            this.CalEntryDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CalDiaryEntryDate_DateSelected);
            // 
            // DiaryEditorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1899, 1001);
            this.Controls.Add(this.lblEntryDate);
            this.Controls.Add(this.CalEntryDate);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.TxtEntryTitle);
            this.Controls.Add(this.lblEntryTitle);
            this.Controls.Add(this.BtnDeleteEntry);
            this.Controls.Add(this.BtnSaveEntry);
            this.Controls.Add(this.TxtEntryContents);
            this.Controls.Add(this.lblEntryContents);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.picBackPlate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1915, 1048);
            this.MinimumSize = new System.Drawing.Size(1915, 1017);
            this.Name = "DiaryEditorPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Noter - Diary Entry";
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
        private System.Windows.Forms.Button BtnDeleteEntry;
        private System.Windows.Forms.Button BtnSaveEntry;
        private System.Windows.Forms.TextBox TxtEntryTitle;
        private System.Windows.Forms.Label lblEntryTitle;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblEntryDate;
        private System.Windows.Forms.MonthCalendar CalEntryDate;
    }
}