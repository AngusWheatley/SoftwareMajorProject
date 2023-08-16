namespace SoftwareMajorProject
{
    partial class DiaryViewerPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiaryViewerPage));
            this.picBackPlate = new System.Windows.Forms.PictureBox();
            this.DgvDiaryViewer = new System.Windows.Forms.DataGridView();
            this.TxtEntryTitle = new System.Windows.Forms.TextBox();
            this.lblEntryTitle = new System.Windows.Forms.Label();
            this.TxtEntryContents = new System.Windows.Forms.TextBox();
            this.lblEntryContents = new System.Windows.Forms.Label();
            this.txtEntryDate = new System.Windows.Forms.TextBox();
            this.lblEntryDate = new System.Windows.Forms.Label();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.lblDiaryEntries = new System.Windows.Forms.Label();
            this.lblSearchEntryDate = new System.Windows.Forms.Label();
            this.CalEntryDate = new System.Windows.Forms.MonthCalendar();
            this.BtnSearchDiaryEntries = new System.Windows.Forms.Button();
            this.BtnResetSearchDiaryEntries = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBackPlate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDiaryViewer)).BeginInit();
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
            // DgvDiaryViewer
            // 
            this.DgvDiaryViewer.AllowUserToResizeColumns = false;
            this.DgvDiaryViewer.AllowUserToResizeRows = false;
            this.DgvDiaryViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDiaryViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDiaryViewer.Location = new System.Drawing.Point(127, 145);
            this.DgvDiaryViewer.MultiSelect = false;
            this.DgvDiaryViewer.Name = "DgvDiaryViewer";
            this.DgvDiaryViewer.Size = new System.Drawing.Size(570, 435);
            this.DgvDiaryViewer.TabIndex = 9;
            this.DgvDiaryViewer.SelectionChanged += new System.EventHandler(this.DgvDiaryViewer_SelectionChanged);
            // 
            // TxtEntryTitle
            // 
            this.TxtEntryTitle.Location = new System.Drawing.Point(744, 174);
            this.TxtEntryTitle.Multiline = true;
            this.TxtEntryTitle.Name = "TxtEntryTitle";
            this.TxtEntryTitle.ReadOnly = true;
            this.TxtEntryTitle.Size = new System.Drawing.Size(553, 41);
            this.TxtEntryTitle.TabIndex = 39;
            // 
            // lblEntryTitle
            // 
            this.lblEntryTitle.AutoSize = true;
            this.lblEntryTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEntryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryTitle.Location = new System.Drawing.Point(739, 142);
            this.lblEntryTitle.Name = "lblEntryTitle";
            this.lblEntryTitle.Size = new System.Drawing.Size(139, 26);
            this.lblEntryTitle.TabIndex = 38;
            this.lblEntryTitle.Text = "Title of Entry:";
            // 
            // TxtEntryContents
            // 
            this.TxtEntryContents.Location = new System.Drawing.Point(744, 268);
            this.TxtEntryContents.Multiline = true;
            this.TxtEntryContents.Name = "TxtEntryContents";
            this.TxtEntryContents.ReadOnly = true;
            this.TxtEntryContents.Size = new System.Drawing.Size(553, 418);
            this.TxtEntryContents.TabIndex = 37;
            // 
            // lblEntryContents
            // 
            this.lblEntryContents.AutoSize = true;
            this.lblEntryContents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEntryContents.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryContents.Location = new System.Drawing.Point(739, 236);
            this.lblEntryContents.Name = "lblEntryContents";
            this.lblEntryContents.Size = new System.Drawing.Size(69, 26);
            this.lblEntryContents.TabIndex = 36;
            this.lblEntryContents.Text = "Entry:";
            // 
            // txtEntryDate
            // 
            this.txtEntryDate.Location = new System.Drawing.Point(744, 738);
            this.txtEntryDate.Multiline = true;
            this.txtEntryDate.Name = "txtEntryDate";
            this.txtEntryDate.ReadOnly = true;
            this.txtEntryDate.Size = new System.Drawing.Size(553, 42);
            this.txtEntryDate.TabIndex = 41;
            // 
            // lblEntryDate
            // 
            this.lblEntryDate.AutoSize = true;
            this.lblEntryDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEntryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryDate.Location = new System.Drawing.Point(739, 706);
            this.lblEntryDate.Name = "lblEntryDate";
            this.lblEntryDate.Size = new System.Drawing.Size(145, 26);
            this.lblEntryDate.TabIndex = 40;
            this.lblEntryDate.Text = "Date of Entry:";
            // 
            // BtnHome
            // 
            this.BtnHome.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.Location = new System.Drawing.Point(1338, 776);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(80, 32);
            this.BtnHome.TabIndex = 42;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(1338, 736);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(80, 32);
            this.BtnBack.TabIndex = 43;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblDiaryEntries
            // 
            this.lblDiaryEntries.AutoSize = true;
            this.lblDiaryEntries.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDiaryEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaryEntries.Location = new System.Drawing.Point(578, 32);
            this.lblDiaryEntries.Name = "lblDiaryEntries";
            this.lblDiaryEntries.Size = new System.Drawing.Size(298, 55);
            this.lblDiaryEntries.TabIndex = 44;
            this.lblDiaryEntries.Text = "Diary Entries";
            // 
            // lblSearchEntryDate
            // 
            this.lblSearchEntryDate.AutoSize = true;
            this.lblSearchEntryDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSearchEntryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchEntryDate.Location = new System.Drawing.Point(123, 588);
            this.lblSearchEntryDate.Name = "lblSearchEntryDate";
            this.lblSearchEntryDate.Size = new System.Drawing.Size(186, 24);
            this.lblSearchEntryDate.TabIndex = 45;
            this.lblSearchEntryDate.Text = "Search Date of Entry:";
            // 
            // CalEntryDate
            // 
            this.CalEntryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalEntryDate.Location = new System.Drawing.Point(127, 618);
            this.CalEntryDate.MaxSelectionCount = 1;
            this.CalEntryDate.Name = "CalEntryDate";
            this.CalEntryDate.ShowTodayCircle = false;
            this.CalEntryDate.TabIndex = 46;
            this.CalEntryDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CalEntryDate_DateSelected);
            // 
            // BtnSearchDiaryEntries
            // 
            this.BtnSearchDiaryEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchDiaryEntries.Location = new System.Drawing.Point(366, 697);
            this.BtnSearchDiaryEntries.Name = "BtnSearchDiaryEntries";
            this.BtnSearchDiaryEntries.Size = new System.Drawing.Size(113, 38);
            this.BtnSearchDiaryEntries.TabIndex = 47;
            this.BtnSearchDiaryEntries.Text = "Search";
            this.BtnSearchDiaryEntries.UseVisualStyleBackColor = true;
            this.BtnSearchDiaryEntries.Click += new System.EventHandler(this.BtnSearchDiaryEntries_Click);
            // 
            // BtnResetSearchDiaryEntries
            // 
            this.BtnResetSearchDiaryEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResetSearchDiaryEntries.Location = new System.Drawing.Point(366, 742);
            this.BtnResetSearchDiaryEntries.Name = "BtnResetSearchDiaryEntries";
            this.BtnResetSearchDiaryEntries.Size = new System.Drawing.Size(113, 38);
            this.BtnResetSearchDiaryEntries.TabIndex = 48;
            this.BtnResetSearchDiaryEntries.Text = "Reset Search";
            this.BtnResetSearchDiaryEntries.UseVisualStyleBackColor = true;
            this.BtnResetSearchDiaryEntries.Click += new System.EventHandler(this.BtnResetSearchDiaryEntries_Click);
            // 
            // DiaryViewerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1424, 821);
            this.Controls.Add(this.BtnResetSearchDiaryEntries);
            this.Controls.Add(this.BtnSearchDiaryEntries);
            this.Controls.Add(this.CalEntryDate);
            this.Controls.Add(this.lblSearchEntryDate);
            this.Controls.Add(this.lblDiaryEntries);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.txtEntryDate);
            this.Controls.Add(this.lblEntryDate);
            this.Controls.Add(this.TxtEntryTitle);
            this.Controls.Add(this.lblEntryTitle);
            this.Controls.Add(this.TxtEntryContents);
            this.Controls.Add(this.lblEntryContents);
            this.Controls.Add(this.DgvDiaryViewer);
            this.Controls.Add(this.picBackPlate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.MinimumSize = new System.Drawing.Size(1440, 860);
            this.Name = "DiaryViewerPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Noter - Diary Viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DiaryViewerPage_FormClosed);
            this.Load += new System.EventHandler(this.DiaryViewerPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackPlate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDiaryViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackPlate;
        private System.Windows.Forms.DataGridView DgvDiaryViewer;
        private System.Windows.Forms.TextBox TxtEntryTitle;
        private System.Windows.Forms.Label lblEntryTitle;
        private System.Windows.Forms.TextBox TxtEntryContents;
        private System.Windows.Forms.Label lblEntryContents;
        private System.Windows.Forms.TextBox txtEntryDate;
        private System.Windows.Forms.Label lblEntryDate;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label lblDiaryEntries;
        private System.Windows.Forms.Label lblSearchEntryDate;
        private System.Windows.Forms.MonthCalendar CalEntryDate;
        private System.Windows.Forms.Button BtnSearchDiaryEntries;
        private System.Windows.Forms.Button BtnResetSearchDiaryEntries;
    }
}