namespace SoftwareMajorProject
{
    partial class ReminderEditorPage
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
            this.CalNotificationDate = new System.Windows.Forms.MonthCalendar();
            this.picBackPlate = new System.Windows.Forms.PictureBox();
            this.lblNotificationTitle = new System.Windows.Forms.Label();
            this.txtNotificationTitle = new System.Windows.Forms.TextBox();
            this.txtNotificationDescription = new System.Windows.Forms.TextBox();
            this.lblNotificationDescription = new System.Windows.Forms.Label();
            this.txtNotificationLocation = new System.Windows.Forms.TextBox();
            this.lblNotificationLocation = new System.Windows.Forms.Label();
            this.BtnSaveNotification = new System.Windows.Forms.Button();
            this.BtnDeleteNotification = new System.Windows.Forms.Button();
            this.DgvCurrentNotifications = new System.Windows.Forms.DataGridView();
            this.BtnHome = new System.Windows.Forms.Button();
            this.CmbNotificationHour = new System.Windows.Forms.ComboBox();
            this.CmbNotificationMinute = new System.Windows.Forms.ComboBox();
            this.CmbNotificationPeriod = new System.Windows.Forms.ComboBox();
            this.lblNotificationOccurrence = new System.Windows.Forms.Label();
            this.lblNotificationHour = new System.Windows.Forms.Label();
            this.lblNotificationMinute = new System.Windows.Forms.Label();
            this.lblNotificationPeriod = new System.Windows.Forms.Label();
            this.lblCurrentNotifications = new System.Windows.Forms.Label();
            this.BtnNotificationCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBackPlate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCurrentNotifications)).BeginInit();
            this.SuspendLayout();
            // 
            // CalNotificationDate
            // 
            this.CalNotificationDate.Location = new System.Drawing.Point(973, 222);
            this.CalNotificationDate.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.CalNotificationDate.MaxSelectionCount = 1;
            this.CalNotificationDate.Name = "CalNotificationDate";
            this.CalNotificationDate.ShowTodayCircle = false;
            this.CalNotificationDate.TabIndex = 0;
            this.CalNotificationDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalNotificationDate_DateChanged);
            // 
            // picBackPlate
            // 
            this.picBackPlate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBackPlate.Location = new System.Drawing.Point(111, 10);
            this.picBackPlate.Margin = new System.Windows.Forms.Padding(4);
            this.picBackPlate.Name = "picBackPlate";
            this.picBackPlate.Size = new System.Drawing.Size(1667, 985);
            this.picBackPlate.TabIndex = 7;
            this.picBackPlate.TabStop = false;
            // 
            // lblNotificationTitle
            // 
            this.lblNotificationTitle.AutoSize = true;
            this.lblNotificationTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNotificationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationTitle.Location = new System.Drawing.Point(171, 178);
            this.lblNotificationTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotificationTitle.Name = "lblNotificationTitle";
            this.lblNotificationTitle.Size = new System.Drawing.Size(196, 26);
            this.lblNotificationTitle.TabIndex = 8;
            this.lblNotificationTitle.Text = "Title of Notification:";
            // 
            // txtNotificationTitle
            // 
            this.txtNotificationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotificationTitle.Location = new System.Drawing.Point(177, 222);
            this.txtNotificationTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotificationTitle.Multiline = true;
            this.txtNotificationTitle.Name = "txtNotificationTitle";
            this.txtNotificationTitle.Size = new System.Drawing.Size(736, 67);
            this.txtNotificationTitle.TabIndex = 9;
            // 
            // txtNotificationDescription
            // 
            this.txtNotificationDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotificationDescription.Location = new System.Drawing.Point(177, 336);
            this.txtNotificationDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotificationDescription.Multiline = true;
            this.txtNotificationDescription.Name = "txtNotificationDescription";
            this.txtNotificationDescription.Size = new System.Drawing.Size(736, 479);
            this.txtNotificationDescription.TabIndex = 11;
            // 
            // lblNotificationDescription
            // 
            this.lblNotificationDescription.AutoSize = true;
            this.lblNotificationDescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNotificationDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationDescription.Location = new System.Drawing.Point(171, 293);
            this.lblNotificationDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotificationDescription.Name = "lblNotificationDescription";
            this.lblNotificationDescription.Size = new System.Drawing.Size(265, 26);
            this.lblNotificationDescription.TabIndex = 10;
            this.lblNotificationDescription.Text = "Description of Notification:";
            // 
            // txtNotificationLocation
            // 
            this.txtNotificationLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotificationLocation.Location = new System.Drawing.Point(177, 863);
            this.txtNotificationLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotificationLocation.Multiline = true;
            this.txtNotificationLocation.Name = "txtNotificationLocation";
            this.txtNotificationLocation.Size = new System.Drawing.Size(736, 61);
            this.txtNotificationLocation.TabIndex = 13;
            // 
            // lblNotificationLocation
            // 
            this.lblNotificationLocation.AutoSize = true;
            this.lblNotificationLocation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNotificationLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationLocation.Location = new System.Drawing.Point(171, 820);
            this.lblNotificationLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotificationLocation.Name = "lblNotificationLocation";
            this.lblNotificationLocation.Size = new System.Drawing.Size(238, 26);
            this.lblNotificationLocation.TabIndex = 12;
            this.lblNotificationLocation.Text = "Location of Notification:";
            // 
            // BtnSaveNotification
            // 
            this.BtnSaveNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveNotification.Location = new System.Drawing.Point(973, 436);
            this.BtnSaveNotification.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSaveNotification.Name = "BtnSaveNotification";
            this.BtnSaveNotification.Size = new System.Drawing.Size(363, 74);
            this.BtnSaveNotification.TabIndex = 21;
            this.BtnSaveNotification.Text = "Save";
            this.BtnSaveNotification.UseVisualStyleBackColor = true;
            this.BtnSaveNotification.Click += new System.EventHandler(this.BtnSaveNotification_Click);
            // 
            // BtnDeleteNotification
            // 
            this.BtnDeleteNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteNotification.Location = new System.Drawing.Point(1357, 436);
            this.BtnDeleteNotification.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDeleteNotification.Name = "BtnDeleteNotification";
            this.BtnDeleteNotification.Size = new System.Drawing.Size(363, 74);
            this.BtnDeleteNotification.TabIndex = 22;
            this.BtnDeleteNotification.Text = "Delete";
            this.BtnDeleteNotification.UseVisualStyleBackColor = true;
            this.BtnDeleteNotification.Click += new System.EventHandler(this.BtnDeleteNotification_Click);
            // 
            // DgvCurrentNotifications
            // 
            this.DgvCurrentNotifications.AllowUserToResizeColumns = false;
            this.DgvCurrentNotifications.AllowUserToResizeRows = false;
            this.DgvCurrentNotifications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvCurrentNotifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCurrentNotifications.Location = new System.Drawing.Point(973, 587);
            this.DgvCurrentNotifications.Margin = new System.Windows.Forms.Padding(4);
            this.DgvCurrentNotifications.MultiSelect = false;
            this.DgvCurrentNotifications.Name = "DgvCurrentNotifications";
            this.DgvCurrentNotifications.RowHeadersWidth = 51;
            this.DgvCurrentNotifications.Size = new System.Drawing.Size(747, 265);
            this.DgvCurrentNotifications.TabIndex = 23;
            this.DgvCurrentNotifications.SelectionChanged += new System.EventHandler(this.DgvCurrentNotifications_SelectionChanged);
            // 
            // BtnHome
            // 
            this.BtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.Location = new System.Drawing.Point(1784, 955);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(4);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(107, 39);
            this.BtnHome.TabIndex = 24;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // CmbNotificationHour
            // 
            this.CmbNotificationHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbNotificationHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbNotificationHour.FormattingEnabled = true;
            this.CmbNotificationHour.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.CmbNotificationHour.Location = new System.Drawing.Point(1421, 222);
            this.CmbNotificationHour.Margin = new System.Windows.Forms.Padding(4);
            this.CmbNotificationHour.Name = "CmbNotificationHour";
            this.CmbNotificationHour.Size = new System.Drawing.Size(135, 28);
            this.CmbNotificationHour.TabIndex = 26;
            // 
            // CmbNotificationMinute
            // 
            this.CmbNotificationMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbNotificationMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbNotificationMinute.FormattingEnabled = true;
            this.CmbNotificationMinute.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.CmbNotificationMinute.Location = new System.Drawing.Point(1421, 277);
            this.CmbNotificationMinute.Margin = new System.Windows.Forms.Padding(4);
            this.CmbNotificationMinute.Name = "CmbNotificationMinute";
            this.CmbNotificationMinute.Size = new System.Drawing.Size(135, 28);
            this.CmbNotificationMinute.TabIndex = 27;
            // 
            // CmbNotificationPeriod
            // 
            this.CmbNotificationPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbNotificationPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbNotificationPeriod.FormattingEnabled = true;
            this.CmbNotificationPeriod.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.CmbNotificationPeriod.Location = new System.Drawing.Point(1421, 332);
            this.CmbNotificationPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.CmbNotificationPeriod.Name = "CmbNotificationPeriod";
            this.CmbNotificationPeriod.Size = new System.Drawing.Size(135, 28);
            this.CmbNotificationPeriod.TabIndex = 28;
            // 
            // lblNotificationOccurrence
            // 
            this.lblNotificationOccurrence.AutoSize = true;
            this.lblNotificationOccurrence.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNotificationOccurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationOccurrence.Location = new System.Drawing.Point(967, 178);
            this.lblNotificationOccurrence.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotificationOccurrence.Name = "lblNotificationOccurrence";
            this.lblNotificationOccurrence.Size = new System.Drawing.Size(268, 26);
            this.lblNotificationOccurrence.TabIndex = 29;
            this.lblNotificationOccurrence.Text = "Occurrence of Notification:";
            // 
            // lblNotificationHour
            // 
            this.lblNotificationHour.AutoSize = true;
            this.lblNotificationHour.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNotificationHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationHour.Location = new System.Drawing.Point(1292, 225);
            this.lblNotificationHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotificationHour.Name = "lblNotificationHour";
            this.lblNotificationHour.Size = new System.Drawing.Size(48, 20);
            this.lblNotificationHour.TabIndex = 30;
            this.lblNotificationHour.Text = "Hour:";
            // 
            // lblNotificationMinute
            // 
            this.lblNotificationMinute.AutoSize = true;
            this.lblNotificationMinute.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNotificationMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationMinute.Location = new System.Drawing.Point(1292, 281);
            this.lblNotificationMinute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotificationMinute.Name = "lblNotificationMinute";
            this.lblNotificationMinute.Size = new System.Drawing.Size(61, 20);
            this.lblNotificationMinute.TabIndex = 31;
            this.lblNotificationMinute.Text = "Minute:";
            // 
            // lblNotificationPeriod
            // 
            this.lblNotificationPeriod.AutoSize = true;
            this.lblNotificationPeriod.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNotificationPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationPeriod.Location = new System.Drawing.Point(1292, 336);
            this.lblNotificationPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotificationPeriod.Name = "lblNotificationPeriod";
            this.lblNotificationPeriod.Size = new System.Drawing.Size(58, 20);
            this.lblNotificationPeriod.TabIndex = 32;
            this.lblNotificationPeriod.Text = "Period:";
            // 
            // lblCurrentNotifications
            // 
            this.lblCurrentNotifications.AutoSize = true;
            this.lblCurrentNotifications.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCurrentNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentNotifications.Location = new System.Drawing.Point(967, 551);
            this.lblCurrentNotifications.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentNotifications.Name = "lblCurrentNotifications";
            this.lblCurrentNotifications.Size = new System.Drawing.Size(215, 26);
            this.lblCurrentNotifications.TabIndex = 33;
            this.lblCurrentNotifications.Text = "Current Notifications:";
            // 
            // BtnNotificationCheck
            // 
            this.BtnNotificationCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNotificationCheck.Location = new System.Drawing.Point(973, 862);
            this.BtnNotificationCheck.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNotificationCheck.Name = "BtnNotificationCheck";
            this.BtnNotificationCheck.Size = new System.Drawing.Size(747, 63);
            this.BtnNotificationCheck.TabIndex = 34;
            this.BtnNotificationCheck.Text = "Check is any notifications are overdue";
            this.BtnNotificationCheck.UseVisualStyleBackColor = true;
            this.BtnNotificationCheck.Click += new System.EventHandler(this.BtnNotificationCheck_Click);
            // 
            // ReminderEditorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1899, 1010);
            this.Controls.Add(this.BtnNotificationCheck);
            this.Controls.Add(this.lblCurrentNotifications);
            this.Controls.Add(this.lblNotificationPeriod);
            this.Controls.Add(this.lblNotificationMinute);
            this.Controls.Add(this.lblNotificationHour);
            this.Controls.Add(this.lblNotificationOccurrence);
            this.Controls.Add(this.CmbNotificationPeriod);
            this.Controls.Add(this.CmbNotificationMinute);
            this.Controls.Add(this.CmbNotificationHour);
            this.Controls.Add(this.CalNotificationDate);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.DgvCurrentNotifications);
            this.Controls.Add(this.BtnDeleteNotification);
            this.Controls.Add(this.BtnSaveNotification);
            this.Controls.Add(this.txtNotificationLocation);
            this.Controls.Add(this.lblNotificationLocation);
            this.Controls.Add(this.txtNotificationDescription);
            this.Controls.Add(this.lblNotificationDescription);
            this.Controls.Add(this.txtNotificationTitle);
            this.Controls.Add(this.lblNotificationTitle);
            this.Controls.Add(this.picBackPlate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ReminderEditorPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Noter - Notification Editor";
            this.Load += new System.EventHandler(this.ReminderEditorPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackPlate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCurrentNotifications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackPlate;
        private System.Windows.Forms.Label lblNotificationTitle;
        private System.Windows.Forms.TextBox txtNotificationTitle;
        private System.Windows.Forms.TextBox txtNotificationDescription;
        private System.Windows.Forms.Label lblNotificationDescription;
        private System.Windows.Forms.TextBox txtNotificationLocation;
        private System.Windows.Forms.Label lblNotificationLocation;
        private System.Windows.Forms.Button BtnSaveNotification;
        private System.Windows.Forms.Button BtnDeleteNotification;
        private System.Windows.Forms.DataGridView DgvCurrentNotifications;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.MonthCalendar CalNotificationDate;
        private System.Windows.Forms.ComboBox CmbNotificationHour;
        private System.Windows.Forms.ComboBox CmbNotificationMinute;
        private System.Windows.Forms.ComboBox CmbNotificationPeriod;
        private System.Windows.Forms.Label lblNotificationOccurrence;
        private System.Windows.Forms.Label lblNotificationHour;
        private System.Windows.Forms.Label lblNotificationMinute;
        private System.Windows.Forms.Label lblNotificationPeriod;
        private System.Windows.Forms.Label lblCurrentNotifications;
        private System.Windows.Forms.Button BtnNotificationCheck;
    }
}