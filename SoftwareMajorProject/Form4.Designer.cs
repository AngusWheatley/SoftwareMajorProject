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
            this.picBackPlate = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNotificationTitle = new System.Windows.Forms.TextBox();
            this.txtNotificationDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotificationLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSaveNotification = new System.Windows.Forms.Button();
            this.btnDeleteNotification = new System.Windows.Forms.Button();
            this.DgvCurrentNotifications = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            this.CalNotificationDate = new System.Windows.Forms.MonthCalendar();
            this.CmbNotificationHour = new System.Windows.Forms.ComboBox();
            this.CmbNotificationMinute = new System.Windows.Forms.ComboBox();
            this.CmbNotificationPeriod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBackPlate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCurrentNotifications)).BeginInit();
            this.SuspendLayout();
            // 
            // picBackPlate
            // 
            this.picBackPlate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBackPlate.Location = new System.Drawing.Point(83, 8);
            this.picBackPlate.Name = "picBackPlate";
            this.picBackPlate.Size = new System.Drawing.Size(1250, 800);
            this.picBackPlate.TabIndex = 7;
            this.picBackPlate.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Title of Notification:";
            // 
            // txtNotificationTitle
            // 
            this.txtNotificationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotificationTitle.Location = new System.Drawing.Point(133, 180);
            this.txtNotificationTitle.Multiline = true;
            this.txtNotificationTitle.Name = "txtNotificationTitle";
            this.txtNotificationTitle.Size = new System.Drawing.Size(553, 55);
            this.txtNotificationTitle.TabIndex = 9;
            // 
            // txtNotificationDescription
            // 
            this.txtNotificationDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotificationDescription.Location = new System.Drawing.Point(133, 273);
            this.txtNotificationDescription.Multiline = true;
            this.txtNotificationDescription.Name = "txtNotificationDescription";
            this.txtNotificationDescription.Size = new System.Drawing.Size(553, 390);
            this.txtNotificationDescription.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Description of Notification:";
            // 
            // txtNotificationLocation
            // 
            this.txtNotificationLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotificationLocation.Location = new System.Drawing.Point(133, 701);
            this.txtNotificationLocation.Multiline = true;
            this.txtNotificationLocation.Name = "txtNotificationLocation";
            this.txtNotificationLocation.Size = new System.Drawing.Size(553, 50);
            this.txtNotificationLocation.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 666);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Location of Notification:";
            // 
            // BtnSaveNotification
            // 
            this.BtnSaveNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveNotification.Location = new System.Drawing.Point(730, 354);
            this.BtnSaveNotification.Name = "BtnSaveNotification";
            this.BtnSaveNotification.Size = new System.Drawing.Size(273, 60);
            this.BtnSaveNotification.TabIndex = 21;
            this.BtnSaveNotification.Text = "Save";
            this.BtnSaveNotification.UseVisualStyleBackColor = true;
            this.BtnSaveNotification.Click += new System.EventHandler(this.BtnSaveNotification_Click);
            // 
            // btnDeleteNotification
            // 
            this.btnDeleteNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNotification.Location = new System.Drawing.Point(1018, 354);
            this.btnDeleteNotification.Name = "btnDeleteNotification";
            this.btnDeleteNotification.Size = new System.Drawing.Size(273, 60);
            this.btnDeleteNotification.TabIndex = 22;
            this.btnDeleteNotification.Text = "Delete";
            this.btnDeleteNotification.UseVisualStyleBackColor = true;
            // 
            // DgvCurrentNotifications
            // 
            this.DgvCurrentNotifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCurrentNotifications.Location = new System.Drawing.Point(730, 477);
            this.DgvCurrentNotifications.Name = "DgvCurrentNotifications";
            this.DgvCurrentNotifications.RowHeadersWidth = 51;
            this.DgvCurrentNotifications.Size = new System.Drawing.Size(561, 274);
            this.DgvCurrentNotifications.TabIndex = 23;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(1338, 776);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(80, 32);
            this.btnHome.TabIndex = 24;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // CalNotificationDate
            // 
            this.CalNotificationDate.Location = new System.Drawing.Point(730, 180);
            this.CalNotificationDate.MaxSelectionCount = 1;
            this.CalNotificationDate.Name = "CalNotificationDate";
            this.CalNotificationDate.ShowTodayCircle = false;
            this.CalNotificationDate.TabIndex = 25;
            this.CalNotificationDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalNotificationDate_DateChanged);
            // 
            // CmbNotificationHour
            // 
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
            this.CmbNotificationHour.Location = new System.Drawing.Point(1066, 180);
            this.CmbNotificationHour.Name = "CmbNotificationHour";
            this.CmbNotificationHour.Size = new System.Drawing.Size(102, 28);
            this.CmbNotificationHour.TabIndex = 26;
            this.CmbNotificationHour.Text = "12";
            // 
            // CmbNotificationMinute
            // 
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
            this.CmbNotificationMinute.Location = new System.Drawing.Point(1066, 225);
            this.CmbNotificationMinute.Name = "CmbNotificationMinute";
            this.CmbNotificationMinute.Size = new System.Drawing.Size(102, 28);
            this.CmbNotificationMinute.TabIndex = 27;
            this.CmbNotificationMinute.Text = "00";
            // 
            // CmbNotificationPeriod
            // 
            this.CmbNotificationPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbNotificationPeriod.FormattingEnabled = true;
            this.CmbNotificationPeriod.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.CmbNotificationPeriod.Location = new System.Drawing.Point(1066, 270);
            this.CmbNotificationPeriod.Name = "CmbNotificationPeriod";
            this.CmbNotificationPeriod.Size = new System.Drawing.Size(102, 28);
            this.CmbNotificationPeriod.TabIndex = 28;
            this.CmbNotificationPeriod.Text = "AM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(725, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 26);
            this.label5.TabIndex = 29;
            this.label5.Text = "Time of Notification:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(969, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Hour:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(969, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Minute:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(969, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Period:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(725, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 26);
            this.label8.TabIndex = 33;
            this.label8.Text = "Current Notifications:";
            // 
            // ReminderEditorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1424, 821);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbNotificationPeriod);
            this.Controls.Add(this.CmbNotificationMinute);
            this.Controls.Add(this.CmbNotificationHour);
            this.Controls.Add(this.CalNotificationDate);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.DgvCurrentNotifications);
            this.Controls.Add(this.btnDeleteNotification);
            this.Controls.Add(this.BtnSaveNotification);
            this.Controls.Add(this.txtNotificationLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNotificationDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNotificationTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBackPlate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNotificationTitle;
        private System.Windows.Forms.TextBox txtNotificationDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNotificationLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSaveNotification;
        private System.Windows.Forms.Button btnDeleteNotification;
        private System.Windows.Forms.DataGridView DgvCurrentNotifications;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.MonthCalendar CalNotificationDate;
        private System.Windows.Forms.ComboBox CmbNotificationHour;
        private System.Windows.Forms.ComboBox CmbNotificationMinute;
        private System.Windows.Forms.ComboBox CmbNotificationPeriod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}