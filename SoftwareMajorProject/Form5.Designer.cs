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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDiaryEntry = new System.Windows.Forms.TextBox();
            this.btnDeleteNotification = new System.Windows.Forms.Button();
            this.BtnSaveDiaryEntry = new System.Windows.Forms.Button();
            this.TxtDiaryTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CalDiaryEntryDate = new System.Windows.Forms.MonthCalendar();
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
            this.btnHome.TabIndex = 25;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Todays Entry:";
            // 
            // TxtDiaryEntry
            // 
            this.TxtDiaryEntry.Location = new System.Drawing.Point(132, 274);
            this.TxtDiaryEntry.Multiline = true;
            this.TxtDiaryEntry.Name = "TxtDiaryEntry";
            this.TxtDiaryEntry.Size = new System.Drawing.Size(553, 512);
            this.TxtDiaryEntry.TabIndex = 27;
            // 
            // btnDeleteNotification
            // 
            this.btnDeleteNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNotification.Location = new System.Drawing.Point(1016, 354);
            this.btnDeleteNotification.Name = "btnDeleteNotification";
            this.btnDeleteNotification.Size = new System.Drawing.Size(273, 74);
            this.btnDeleteNotification.TabIndex = 33;
            this.btnDeleteNotification.Text = "Delete";
            this.btnDeleteNotification.UseVisualStyleBackColor = true;
            // 
            // BtnSaveDiaryEntry
            // 
            this.BtnSaveDiaryEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveDiaryEntry.Location = new System.Drawing.Point(728, 354);
            this.BtnSaveDiaryEntry.Name = "BtnSaveDiaryEntry";
            this.BtnSaveDiaryEntry.Size = new System.Drawing.Size(273, 74);
            this.BtnSaveDiaryEntry.TabIndex = 32;
            this.BtnSaveDiaryEntry.Text = "Save";
            this.BtnSaveDiaryEntry.UseVisualStyleBackColor = true;
            this.BtnSaveDiaryEntry.Click += new System.EventHandler(this.BtnSaveDiaryEntry_Click);
            // 
            // TxtDiaryTitle
            // 
            this.TxtDiaryTitle.Location = new System.Drawing.Point(132, 174);
            this.TxtDiaryTitle.Multiline = true;
            this.TxtDiaryTitle.Name = "TxtDiaryTitle";
            this.TxtDiaryTitle.Size = new System.Drawing.Size(553, 41);
            this.TxtDiaryTitle.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 26);
            this.label2.TabIndex = 34;
            this.label2.Text = "Title of Todays Entry:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(203, 54);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(115, 20);
            this.txtUserName.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(723, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 26);
            this.label3.TabIndex = 41;
            this.label3.Text = "Date of Entry";
            // 
            // CalDiaryEntryDate
            // 
            this.CalDiaryEntryDate.Location = new System.Drawing.Point(728, 180);
            this.CalDiaryEntryDate.MaxSelectionCount = 1;
            this.CalDiaryEntryDate.Name = "CalDiaryEntryDate";
            this.CalDiaryEntryDate.ShowTodayCircle = false;
            this.CalDiaryEntryDate.TabIndex = 37;
            this.CalDiaryEntryDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CalDiaryEntryDate_DateSelected);
            // 
            // DiaryEditorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1424, 813);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CalDiaryEntryDate);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.TxtDiaryTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteNotification);
            this.Controls.Add(this.BtnSaveDiaryEntry);
            this.Controls.Add(this.TxtDiaryEntry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.picBackPlate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 859);
            this.MinimumSize = new System.Drawing.Size(1440, 834);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDiaryEntry;
        private System.Windows.Forms.Button btnDeleteNotification;
        private System.Windows.Forms.Button BtnSaveDiaryEntry;
        private System.Windows.Forms.TextBox TxtDiaryTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar CalDiaryEntryDate;
    }
}