using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SoftwareMajorProject
{
    public partial class ReminderEditorPage : Form
    {
        
        string notificationDate;
        string userName;
        string selectedNotificationIndex;
        string notificationDateTime;
        string userEmail;
        string overdueUserName;
        string overdueUserIndex;
        string notificationTitleToSendToUser;
        string notificationBodyToSendToUser;

        public ReminderEditorPage(string userNameLoggedIn)
        {
            userName = userNameLoggedIn;
            InitializeComponent();

        }

        private void ReminderEditorPage_Load(object sender, EventArgs e)
        {
            SetObjectFeatures(); //Initialises UI from user settings

            LoadUserNotifications(); //Loads user notifications into data grid view
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            HomePage HomePage = new HomePage(userName);
            this.Hide();
            HomePage.Show();
        }

        private void BtnSaveNotification_Click(object sender, EventArgs e)
        {

            string notificationDateSelected = CalNotificationDate.SelectionStart.ToShortDateString();

            string notificationTitle = txtNotificationTitle.Text;
            string notificationDescription = txtNotificationDescription.Text;
            string notificationLocation = txtNotificationLocation.Text;
            notificationDateTime = notificationDateSelected + " " +CmbNotificationHour.Text + ":" + CmbNotificationMinute.Text + ":00 " + CmbNotificationPeriod.Text;



            if (notificationDateSelected != "" && CmbNotificationHour.Text != "" && CmbNotificationMinute.Text != "" && CmbNotificationPeriod.Text != "")
            {
                DateTime dateTimeNow = DateTime.Now;
                DateTime fullNotificationDateTime = Convert.ToDateTime(notificationDateTime);

                int comparedDates = fullNotificationDateTime.CompareTo(dateTimeNow);
                if (comparedDates == 0)
                {
                    MessageBox.Show("Same date and time");
                }
                else if (comparedDates < 0)
                {
                    MessageBox.Show("Invalid date selected");
                }
                else
                {
                    MessageBox.Show("Notification added.");

                    AddNotificationToDatabase(notificationTitle, notificationDescription, notificationLocation);
                    ClearNewNotificationFields();

                }
                LoadUserNotifications(); //Loads user notifications into data grid view
            }
        }

        private void ClearNewNotificationFields()
        {
            txtNotificationTitle.Text = null;
            txtNotificationDescription.Text = null;
            txtNotificationLocation.Text = null;
            CmbNotificationHour.Text = "12";
            CmbNotificationMinute.Text = "00";
            CmbNotificationPeriod.Text = "AM";
            CalNotificationDate.SelectionStart = DateTime.Now;
        }

        private void AddNotificationToDatabase(string notificationTitle, string notificationDescription, string notificationLocation)
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = noterDatabase.db";


            SQLiteCommand sqlCommandNewUser = new SQLiteCommand();
            sqlCommandNewUser.Connection = sqlConnection;
            sqlCommandNewUser.CommandType = CommandType.Text;
            sqlCommandNewUser.CommandText = "INSERT into Notifications (UserName, Title, Description, Location, Time) values (@UserName, @Title, @Description, @Location, @Time)";

            sqlCommandNewUser.Parameters.AddWithValue("@UserName", userName);
            sqlCommandNewUser.Parameters.AddWithValue("@Title", notificationTitle);
            sqlCommandNewUser.Parameters.AddWithValue("@Description", notificationDescription);
            sqlCommandNewUser.Parameters.AddWithValue("@Location", notificationLocation);
            sqlCommandNewUser.Parameters.AddWithValue("@Time", notificationDateTime);

            sqlConnection.Open();
            sqlCommandNewUser.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void CalNotificationDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            notificationDate = e.Start.ToShortDateString();
        }

        private void BtnDeleteNotification_Click(object sender, EventArgs e)
        {
            if (selectedNotificationIndex != null)
            {
                DialogResult checkDeleteNotification = MessageBox.Show("Are you sure you want to delete notification?", "", MessageBoxButtons.YesNo);
                if (checkDeleteNotification == DialogResult.Yes)
                {
                    SQLiteConnection sqlConnectionDeleteNotification = new SQLiteConnection();
                    sqlConnectionDeleteNotification.ConnectionString = "DataSource = noterDatabase.db";

                    SQLiteCommand deleteNotificationCommand = new SQLiteCommand();

                    deleteNotificationCommand.Connection = sqlConnectionDeleteNotification;
                    deleteNotificationCommand.CommandType = CommandType.Text;
                    deleteNotificationCommand.CommandText = "DELETE FROM Notifications WHERE NotificationIndex=" + selectedNotificationIndex;

                    deleteNotificationCommand.Parameters.AddWithValue("@NotificationIndex", selectedNotificationIndex);

                    sqlConnectionDeleteNotification.Open();
                    deleteNotificationCommand.ExecuteNonQuery();
                    sqlConnectionDeleteNotification.Close();


                    LoadUserNotifications();


                    MessageBox.Show("Notification deleted.");
                }
                else
                {
                    MessageBox.Show("Notification not deleted");
                }
            }
            else
            {
                MessageBox.Show("Select a notification to be deleted.");
            }
        }

        private void DgvCurrentNotifications_SelectionChanged(object sender, EventArgs e)
        {
            SQLiteConnection sqlConnectionDeleteNotification = new SQLiteConnection();
            sqlConnectionDeleteNotification.ConnectionString = "DataSource = noterDatabase.db";

            if (DgvCurrentNotifications.SelectedRows.Count > 0)
            {
                selectedNotificationIndex = DgvCurrentNotifications.SelectedRows[0].Cells[0].Value.ToString();

                string selectNotificationIndexCommand = "SELECT * FROM Notifications WHERE NotificationIndex=" + selectedNotificationIndex;

                var dataTableNotifications = new DataTable();
                SQLiteDataAdapter selectNotificationDataAdapter = new SQLiteDataAdapter(selectNotificationIndexCommand, sqlConnectionDeleteNotification);

                sqlConnectionDeleteNotification.Open();
                selectNotificationDataAdapter.Fill(dataTableNotifications);

                sqlConnectionDeleteNotification.Close();
            }
        }

        private void BtnNotificationCheck_Click(object sender, EventArgs e)
        {
            DgvCurrentNotifications.ClearSelection();

            MessageBox.Show("Searching for overdue notifications, please wait.");


            SQLiteConnection sqlConnectionNotificationsCheck = new SQLiteConnection();
            sqlConnectionNotificationsCheck.ConnectionString = "DataSource = noterDatabase.db";

            string insertNotificationsCommand = "SELECT * FROM 'Notifications'";


            
            var dataTableNotifications = new DataTable();
            SQLiteDataAdapter notificationsDataAdapter = new SQLiteDataAdapter(insertNotificationsCommand, sqlConnectionNotificationsCheck);

            sqlConnectionNotificationsCheck.Open();
            notificationsDataAdapter.Fill(dataTableNotifications);
            sqlConnectionNotificationsCheck.Close();


            foreach (DataRow rowNotificationsCheck in dataTableNotifications.Rows) //Checks each row of the 'Notifications' table
            {
                DateTime dateTimeNow = DateTime.Now; //Gets current dateTime
                string fullNotificationDateTimeString = rowNotificationsCheck[5].ToString(); //Gets notification dateTime from row in 'Notifications' as a string
                DateTime fullNotificationDateTime = Convert.ToDateTime(fullNotificationDateTimeString); //Converts dateTime from row in 'Notificaitons'


                int comparedDates = fullNotificationDateTime.CompareTo(dateTimeNow); //Compared the dateTime of the notification to the current dateTime
                if (comparedDates < 0) //Occurs when the date is past current date
                {

                    int i = 1;

                    {
                        string checkIfNotificationOverdueCommand = "SELECT * FROM 'UserInfo'";
                        SQLiteDataAdapter notificationOverdueDataAdapter = new SQLiteDataAdapter(checkIfNotificationOverdueCommand, sqlConnectionNotificationsCheck);



                        var dataTableUserInfo = new DataTable();

                        sqlConnectionNotificationsCheck.Open();
                        notificationOverdueDataAdapter.Fill(dataTableUserInfo);
                        sqlConnectionNotificationsCheck.Close();


                        overdueUserName = rowNotificationsCheck[1].ToString(); //Gets overdueUserName from the row in 'Notifications'

                        

                        foreach (DataRow rowNotificationOverdue in dataTableUserInfo.Rows)//-------------------- Problem may be here as it is checking and getting all rows regardless if it 
                        {
                            if (rowNotificationOverdue[1].ToString() == overdueUserName && rowNotificationsCheck[1].ToString() == overdueUserName && i == 1)
                            {
                                userEmail = rowNotificationOverdue[3].ToString(); //Gets userEmail from the row in 'UserInfo'
                                overdueUserIndex = rowNotificationsCheck[0].ToString();



                                notificationTitleToSendToUser = "New Notification for " + overdueUserName + ": " + rowNotificationsCheck[2].ToString();
                                notificationBodyToSendToUser = "Title: " + rowNotificationsCheck[2].ToString() + "\nDescription: " + rowNotificationsCheck[3].ToString() + "\nLocation: " + rowNotificationsCheck[4].ToString() + "\nTime of Notification: " + rowNotificationsCheck[5].ToString();


                                MailMessage mailMessage = new MailMessage();
                                mailMessage.From = new MailAddress("noterservices@gmail.com");
                                mailMessage.To.Add(userEmail);
                                mailMessage.Subject = notificationTitleToSendToUser;
                                mailMessage.Body = notificationBodyToSendToUser;

                                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                                smtpClient.Credentials = new NetworkCredential("noterservices@gmail.com", "wxtleisaobiiluuu");
                                smtpClient.EnableSsl = true;

                                try
                                {
                                    smtpClient.Send(mailMessage);

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Failed to send. Error: " + ex.Message);
                                }



                                SQLiteConnection sqlConnectionDeleteNotification = new SQLiteConnection();
                                sqlConnectionDeleteNotification.ConnectionString = "DataSource = noterDatabase.db";

                                SQLiteCommand sqlCommandDeleteNotification = new SQLiteCommand();
                                sqlCommandDeleteNotification.Connection = sqlConnectionDeleteNotification;
                                sqlCommandDeleteNotification.CommandType = CommandType.Text;
                                sqlCommandDeleteNotification.CommandText = "DELETE FROM Notifications WHERE NotificationIndex=@NotificationIndex";
                                sqlCommandDeleteNotification.Parameters.AddWithValue("@NotificationIndex", overdueUserIndex);

                                sqlConnectionDeleteNotification.Open();
                                sqlCommandDeleteNotification.ExecuteNonQuery();
                                sqlConnectionDeleteNotification.Close();


                                LoadUserNotifications();

                                i = 0;
                            }
                            
                        }
                    }
                }
                else if (comparedDates >= 0)
                {

                }
            }

            
        }

        private void LoadUserNotifications()
        {
            SQLiteConnection sqlConnectionNotifications = new SQLiteConnection();
            sqlConnectionNotifications.ConnectionString = "DataSource = noterDatabase.db";

            string insertNotificationsCommand = "SELECT * FROM Notifications WHERE UserName='" + userName + "'";

            sqlConnectionNotifications.Open();
            var dataTableNotifications = new DataTable();
            SQLiteDataAdapter notificationsDataAdapter = new SQLiteDataAdapter(insertNotificationsCommand, sqlConnectionNotifications);


            notificationsDataAdapter.Fill(dataTableNotifications);
            sqlConnectionNotifications.Close();

            DgvCurrentNotifications.DataSource = dataTableNotifications;
            DgvCurrentNotifications.Columns["NotificationIndex"].Visible = false;
            DgvCurrentNotifications.Columns["UserName"].Visible = false;

            DgvCurrentNotifications.Columns[2].Width = 120;
            DgvCurrentNotifications.Columns[3].Width = 145;
            DgvCurrentNotifications.Columns[4].Width = 115;
            DgvCurrentNotifications.Columns[5].Width = 110;
        } //Loads user notifications into data grid view

        private void SetObjectFeatures()
        {
            txtNotificationTitle.Text = null;
            txtNotificationDescription.Text = null;
            txtNotificationLocation.Text = null;
            CmbNotificationHour.Text = "12";
            CmbNotificationMinute.Text = "00";
            CmbNotificationPeriod.Text = "AM";

            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = noterDatabase.db";

            string cmd = "SELECT * FROM 'NoterSettings'";
            SQLiteDataAdapter settingsDataAdapter = new SQLiteDataAdapter(cmd, sqlConnection);

            var dataGridViewSettings = new DataTable();

            sqlConnection.Open();
            settingsDataAdapter.Fill(dataGridViewSettings);
            sqlConnection.Close();


            foreach (DataRow row in dataGridViewSettings.Rows)
            {
                if (row[0].ToString() == userName)
                {
                    //Back colour
                    BackColor = Color.FromName(row[1].ToString());

                    //Front colour
                    picBackPlate.BackColor = Color.FromName(row[2].ToString());
                    lblNotifications.BackColor = Color.FromName(row[2].ToString());
                    lblNotificationTitle.BackColor = Color.FromName(row[2].ToString());
                    lblNotificationDescription.BackColor = Color.FromName(row[2].ToString());
                    lblNotificationLocation.BackColor = Color.FromName(row[2].ToString());
                    lblNotificationOccurrence.BackColor = Color.FromName(row[2].ToString());
                    lblNotificationHour.BackColor = Color.FromName(row[2].ToString());
                    lblNotificationMinute.BackColor = Color.FromName(row[2].ToString());
                    lblNotificationPeriod.BackColor = Color.FromName(row[2].ToString());
                    lblCurrentNotifications.BackColor = Color.FromName(row[2].ToString());
                    DgvCurrentNotifications.BackgroundColor = Color.FromName(row[2].ToString());
                    DgvCurrentNotifications.CellBorderStyle = DataGridViewCellBorderStyle.Single;


                    //Font type -- Done
                    Font userFontTitleUnderlined = new Font(row[3].ToString(), 42, FontStyle.Underline);
                    Font userFontBigSubtitleUnderlined = new Font(row[3].ToString(), 16, FontStyle.Underline);
                    Font userFontSmallSubtitleUnderlined = new Font(row[3].ToString(), 12, FontStyle.Underline);
                    Font userFontComboBoxes = new Font(row[3].ToString(), 12);
                    Font userFontButtons = new Font(row[3].ToString(), 14);
                    Font userFontTextBoxes = new Font(row[3].ToString(), 12);
                    Font userFontDataGridView = new Font(row[3].ToString(), 10);
                    lblNotifications.Font = userFontTitleUnderlined;
                    lblNotificationTitle.Font = userFontBigSubtitleUnderlined;
                    txtNotificationTitle.Font = userFontTextBoxes;
                    lblNotificationDescription.Font = userFontBigSubtitleUnderlined;
                    txtNotificationDescription.Font = userFontTextBoxes;
                    lblNotificationLocation.Font = userFontBigSubtitleUnderlined;
                    txtNotificationLocation.Font = userFontTextBoxes;
                    lblNotificationOccurrence.Font = userFontBigSubtitleUnderlined;
                    lblNotificationHour.Font = userFontSmallSubtitleUnderlined;
                    CmbNotificationHour.Font = userFontComboBoxes;
                    lblNotificationMinute.Font = userFontSmallSubtitleUnderlined;
                    CmbNotificationMinute.Font = userFontComboBoxes;
                    lblNotificationPeriod.Font = userFontSmallSubtitleUnderlined;
                    CmbNotificationPeriod.Font = userFontComboBoxes;
                    BtnSaveNotification.Font = userFontButtons;
                    BtnDeleteNotification.Font = userFontButtons;
                    lblCurrentNotifications.Font = userFontBigSubtitleUnderlined;
                    DgvCurrentNotifications.Font = userFontDataGridView;
                    BtnHome.Font = userFontButtons;
                }
            }
        }

        private void TimerCheckNotifications_Tick(object sender, EventArgs e)
        {
            DgvCurrentNotifications.ClearSelection();

            MessageBox.Show("Searching for overdue notifications, please wait.");


            SQLiteConnection sqlConnectionNotificationsCheck = new SQLiteConnection();
            sqlConnectionNotificationsCheck.ConnectionString = "DataSource = noterDatabase.db";

            string insertNotificationsCommand = "SELECT * FROM 'Notifications'";



            var dataTableNotifications = new DataTable();
            SQLiteDataAdapter notificationsDataAdapter = new SQLiteDataAdapter(insertNotificationsCommand, sqlConnectionNotificationsCheck);

            sqlConnectionNotificationsCheck.Open();
            notificationsDataAdapter.Fill(dataTableNotifications);
            sqlConnectionNotificationsCheck.Close();


            foreach (DataRow rowNotificationsCheck in dataTableNotifications.Rows) //Checks each row of the 'Notifications' table
            {
                DateTime dateTimeNow = DateTime.Now; //Gets current dateTime
                string fullNotificationDateTimeString = rowNotificationsCheck[5].ToString(); //Gets notification dateTime from row in 'Notifications' as a string
                DateTime fullNotificationDateTime = Convert.ToDateTime(fullNotificationDateTimeString); //Converts dateTime from row in 'Notificaitons'


                int comparedDates = fullNotificationDateTime.CompareTo(dateTimeNow); //Compared the dateTime of the notification to the current dateTime
                if (comparedDates < 0) //Occurs when the date is past current date
                {

                    int i = 1;

                    {
                        string checkIfNotificationOverdueCommand = "SELECT * FROM 'UserInfo'";
                        SQLiteDataAdapter notificationOverdueDataAdapter = new SQLiteDataAdapter(checkIfNotificationOverdueCommand, sqlConnectionNotificationsCheck);



                        var dataTableUserInfo = new DataTable();

                        sqlConnectionNotificationsCheck.Open();
                        notificationOverdueDataAdapter.Fill(dataTableUserInfo);
                        sqlConnectionNotificationsCheck.Close();


                        overdueUserName = rowNotificationsCheck[1].ToString(); //Gets overdueUserName from the row in 'Notifications'



                        foreach (DataRow rowNotificationOverdue in dataTableUserInfo.Rows)//-------------------- Problem may be here as it is checking and getting all rows regardless if it 
                        {
                            if (rowNotificationOverdue[1].ToString() == overdueUserName && rowNotificationsCheck[1].ToString() == overdueUserName && i == 1)
                            {
                                userEmail = rowNotificationOverdue[3].ToString(); //Gets userEmail from the row in 'UserInfo'
                                overdueUserIndex = rowNotificationsCheck[0].ToString();



                                notificationTitleToSendToUser = "New Notification for " + overdueUserName + ": " + rowNotificationsCheck[2].ToString();
                                notificationBodyToSendToUser = "Title: " + rowNotificationsCheck[2].ToString() + "\nDescription: " + rowNotificationsCheck[3].ToString() + "\nLocation: " + rowNotificationsCheck[4].ToString() + "\nTime of Notification: " + rowNotificationsCheck[5].ToString();


                                MailMessage mailMessage = new MailMessage();
                                mailMessage.From = new MailAddress("noterservices@gmail.com");
                                mailMessage.To.Add(userEmail);
                                mailMessage.Subject = notificationTitleToSendToUser;
                                mailMessage.Body = notificationBodyToSendToUser;

                                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                                smtpClient.Credentials = new NetworkCredential("noterservices@gmail.com", "wxtleisaobiiluuu");
                                smtpClient.EnableSsl = true;

                                try
                                {
                                    smtpClient.Send(mailMessage);

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Failed to send. Error: " + ex.Message);
                                }



                                SQLiteConnection sqlConnectionDeleteNotification = new SQLiteConnection();
                                sqlConnectionDeleteNotification.ConnectionString = "DataSource = noterDatabase.db";

                                SQLiteCommand sqlCommandDeleteNotification = new SQLiteCommand();
                                sqlCommandDeleteNotification.Connection = sqlConnectionDeleteNotification;
                                sqlCommandDeleteNotification.CommandType = CommandType.Text;
                                sqlCommandDeleteNotification.CommandText = "DELETE FROM Notifications WHERE NotificationIndex=@NotificationIndex";
                                sqlCommandDeleteNotification.Parameters.AddWithValue("@NotificationIndex", overdueUserIndex);

                                sqlConnectionDeleteNotification.Open();
                                sqlCommandDeleteNotification.ExecuteNonQuery();
                                sqlConnectionDeleteNotification.Close();


                                LoadUserNotifications();

                                i = 0;
                            }

                        }
                    }
                }
                else if (comparedDates >= 0)
                {

                }
            }


        }
    }
}
