namespace SoftwareMajorProject
{
    partial class diaryViewerPage
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
            this.DgvDiaryViewer = new System.Windows.Forms.DataGridView();
            this.TxtEntryTitle = new System.Windows.Forms.TextBox();
            this.lblEntryTitle = new System.Windows.Forms.Label();
            this.TxtEntryContents = new System.Windows.Forms.TextBox();
            this.lblEntryContents = new System.Windows.Forms.Label();
            this.txtEntryDate = new System.Windows.Forms.TextBox();
            this.lblEntryDate = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBackPlate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDiaryViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // picBackPlate
            // 
            this.picBackPlate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBackPlate.Location = new System.Drawing.Point(87, 10);
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
            this.DgvDiaryViewer.Location = new System.Drawing.Point(128, 145);
            this.DgvDiaryViewer.MultiSelect = false;
            this.DgvDiaryViewer.Name = "DgvDiaryViewer";
            this.DgvDiaryViewer.Size = new System.Drawing.Size(570, 635);
            this.DgvDiaryViewer.TabIndex = 9;
            this.DgvDiaryViewer.SelectionChanged += new System.EventHandler(this.DgvDiaryViewer_SelectionChanged);
            // 
            // TxtEntryTitle
            // 
            this.TxtEntryTitle.Location = new System.Drawing.Point(745, 174);
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
            this.lblEntryTitle.Location = new System.Drawing.Point(740, 145);
            this.lblEntryTitle.Name = "lblEntryTitle";
            this.lblEntryTitle.Size = new System.Drawing.Size(139, 26);
            this.lblEntryTitle.TabIndex = 38;
            this.lblEntryTitle.Text = "Title of Entry:";
            // 
            // TxtEntryContents
            // 
            this.TxtEntryContents.Location = new System.Drawing.Point(745, 268);
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
            this.lblEntryContents.Location = new System.Drawing.Point(740, 239);
            this.lblEntryContents.Name = "lblEntryContents";
            this.lblEntryContents.Size = new System.Drawing.Size(69, 26);
            this.lblEntryContents.TabIndex = 36;
            this.lblEntryContents.Text = "Entry:";
            // 
            // txtEntryDate
            // 
            this.txtEntryDate.Location = new System.Drawing.Point(745, 738);
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
            this.lblEntryDate.Location = new System.Drawing.Point(740, 709);
            this.lblEntryDate.Name = "lblEntryDate";
            this.lblEntryDate.Size = new System.Drawing.Size(145, 26);
            this.lblEntryDate.TabIndex = 40;
            this.lblEntryDate.Text = "Date of Entry:";
            // 
            // btnHome
            // 
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(1338, 776);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(80, 32);
            this.btnHome.TabIndex = 42;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1338, 736);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 32);
            this.btnBack.TabIndex = 43;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // diaryViewerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1424, 821);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.txtEntryDate);
            this.Controls.Add(this.lblEntryDate);
            this.Controls.Add(this.TxtEntryTitle);
            this.Controls.Add(this.lblEntryTitle);
            this.Controls.Add(this.TxtEntryContents);
            this.Controls.Add(this.lblEntryContents);
            this.Controls.Add(this.DgvDiaryViewer);
            this.Controls.Add(this.picBackPlate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.MinimumSize = new System.Drawing.Size(1440, 860);
            this.Name = "diaryViewerPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Noter - Diary Viewer";
            this.Load += new System.EventHandler(this.diaryViewerPage_Load);
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
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBack;
    }
}