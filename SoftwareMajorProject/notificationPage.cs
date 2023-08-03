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
            CmbNotificationHour.Text = "12";
            CmbNotificationMinute.Text = "00";
            CmbNotificationPeriod.Text = "AM";




            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";

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


                    //Font type
                    var fontConverter = new FontConverter();
                    //var sizeConverter = new SizeConverter();
                    //lblBackgroundColour.Font = new Font(fontConverter.ConvertFromString(row[3].ToString()) as Font, (FontStyle)sizeConverter.ConvertFromString("12"));
                    lblNotificationTitle.Font = new Font(fontConverter.ConvertFromString(row[3].ToString()) as Font, FontStyle.Underline);
                    txtNotificationTitle.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                    lblNotificationDescription.Font = new Font(fontConverter.ConvertFromString(row[3].ToString()) as Font, FontStyle.Underline);
                    txtNotificationDescription.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                    lblNotificationLocation.Font = new Font(fontConverter.ConvertFromString(row[3].ToString()) as Font, FontStyle.Underline);
                    txtNotificationLocation.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                    lblNotificationOccurrence.Font = new Font(fontConverter.ConvertFromString(row[3].ToString()) as Font, FontStyle.Underline);
                    CalNotificationDate.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                    lblNotificationHour.Font = new Font(fontConverter.ConvertFromString(row[3].ToString()) as Font, FontStyle.Underline);
                    CmbNotificationHour.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                    lblNotificationMinute.Font = new Font(fontConverter.ConvertFromString(row[3].ToString()) as Font, FontStyle.Underline);
                    CmbNotificationMinute.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                    lblNotificationPeriod.Font = new Font(fontConverter.ConvertFromString(row[3].ToString()) as Font, FontStyle.Underline);
                    CmbNotificationPeriod.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                    BtnSaveNotification.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                    btnDeleteNotification.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                    lblCurrentNotifications.Font = new Font(fontConverter.ConvertFromString(row[3].ToString()) as Font, FontStyle.Underline);
                    DgvCurrentNotifications.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                    btnHome.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;

                }
            }


            //==================================================================================================================




            LoadUserNotifications();


            /*
            bool userNotificationExists = dataTableUserNotifications.Rows.Count > 0;
            MessageBox.Show(Convert.ToString(userNotificationExists));


            dataTableUserNotifications.AcceptChanges();

            for (int i = dataTableUserNotifications.Rows.Count - 1; i >= 0; i--)
            {
                DataRow row = dataTableUserNotifications.Rows[i];
                if (row["UserName"] != userName)
                {
                    row.Delete();
                }
            }
            dataTableUserNotifications.AcceptChanges();


            bool userNotificationExistsShort = dataTableUserNotifications.Rows.Count > 0;
            MessageBox.Show(Convert.ToString(userNotificationExistsShort));
            */


            /*
            var dataTableUserNotifications = new DataTable();
            foreach (DataRow row in dataTableNotifications.Rows)
            {
                if (row[0].ToString() == userName)
                {
                    dataTableUserNotifications.ImportRow(row);
                    
                }
            }*/




            //DgvCurrentNotifications.DataSource = dataTableNotifications;




            /*
            DataRow[] userNotifications = dataTableNotifications.Select("UserName = '" + userName + "'");
            foreach (DataRow row in userNotifications)
            {

            }*/


            //DgvCurrentNotifications.Columns["UserName"].Visible = false;








        }

        private void LoadUserNotifications()
        {
            SQLiteConnection sqlConnectionNotifications = new SQLiteConnection();
            sqlConnectionNotifications.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";

            //string insertNotificationsCommand = "SELECT * FROM Notifications WHERE UserName LIKE '%" + userName + "%'";
            string insertNotificationsCommand = "SELECT * FROM Notifications WHERE UserName='" + userName + "'";

            //insertNotificationsCommand.Parameters.AddWithValue("@userName", userName);
            //insertNotificationsCommand.Connection = sqlConnectionNotifications;

            sqlConnectionNotifications.Open();
            var dataTableNotifications = new DataTable();
            SQLiteDataAdapter notificationsDataAdapter = new SQLiteDataAdapter(insertNotificationsCommand, sqlConnectionNotifications);


            notificationsDataAdapter.Fill(dataTableNotifications);
            sqlConnectionNotifications.Close();


            //DataTable dataTableUserNotifications = new DataTable();
            //dataTableUserNotifications = dataTableNotifications.Copy();



            DgvCurrentNotifications.DataSource = dataTableNotifications;
            DgvCurrentNotifications.Columns["NotificationIndex"].Visible = false;
            DgvCurrentNotifications.Columns["UserName"].Visible = false;

            DgvCurrentNotifications.Columns[2].Width = 120;
            DgvCurrentNotifications.Columns[3].Width = 145;
            DgvCurrentNotifications.Columns[4].Width = 115;
            DgvCurrentNotifications.Columns[5].Width = 110;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage HomePage = new HomePage(userName);
            this.Hide();
            HomePage.Show();
        }

        private void BtnSaveNotification_Click(object sender, EventArgs e)
        {
            /*
            string time = DateTime.Now.Date.ToString();

            MessageBox.Show(time);



            if (notificationDate == "")
            {
                notificationDate = DateTime.Now.ToString("dd/MM/yyyy");
            }*/


            string notificationDateSelected = CalNotificationDate.SelectionStart.ToShortDateString();

            string notificationTitle = txtNotificationTitle.Text;
            string notificationDescription = txtNotificationDescription.Text;
            string notificationLocation = txtNotificationLocation.Text;
            notificationDateTime = notificationDateSelected + " " +CmbNotificationHour.Text + ":" + CmbNotificationMinute.Text + ":00 " + CmbNotificationPeriod.Text;

            MessageBox.Show(notificationDateTime);



            if (notificationDateSelected != "" && CmbNotificationHour.Text != "" && CmbNotificationMinute.Text != "" && CmbNotificationPeriod.Text != "")
            {
                MessageBox.Show("Comparing dates");

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
                    MessageBox.Show("Valid date!");
                    

                    SQLiteConnection sqlConnection = new SQLiteConnection();
                    sqlConnection.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";


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

                LoadUserNotifications();


            }

        }

        private void CalNotificationDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            notificationDate = e.Start.ToShortDateString();
        }

        private void btnDeleteNotification_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlConnectionDeleteNotification = new SQLiteConnection();
            sqlConnectionDeleteNotification.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";

            SQLiteCommand deleteNotificationCommand = new SQLiteCommand();

            deleteNotificationCommand.Connection = sqlConnectionDeleteNotification;
            deleteNotificationCommand.CommandType = CommandType.Text;
            deleteNotificationCommand.CommandText = "DELETE FROM Notifications WHERE NotificationIndex=" + selectedNotificationIndex;

            deleteNotificationCommand.Parameters.AddWithValue("@NotificationIndex", selectedNotificationIndex);

            sqlConnectionDeleteNotification.Open();
            deleteNotificationCommand.ExecuteNonQuery();
            sqlConnectionDeleteNotification.Close();


            //============================================================================================================================


            LoadUserNotifications();

        }

        private void DgvCurrentNotifications_SelectionChanged(object sender, EventArgs e)
        {
            SQLiteConnection sqlConnectionDeleteNotification = new SQLiteConnection();
            sqlConnectionDeleteNotification.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";

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


            SQLiteConnection sqlConnectionNotificationsCheck = new SQLiteConnection();
            sqlConnectionNotificationsCheck.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";

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
                    MessageBox.Show(fullNotificationDateTime + " Has already passed");

                    int i = 1;

                    foreach (DataRow rowUserNotification in dataTableNotifications.Rows)
                    {
                        string checkIfNotificationOverdueCommand = "SELECT * FROM 'UserInfo'";
                        SQLiteDataAdapter notificationOverdueDataAdapter = new SQLiteDataAdapter(checkIfNotificationOverdueCommand, sqlConnectionNotificationsCheck);



                        var dataTableUserInfo = new DataTable();

                        sqlConnectionNotificationsCheck.Open();
                        notificationOverdueDataAdapter.Fill(dataTableUserInfo);
                        sqlConnectionNotificationsCheck.Close();


                        overdueUserName = rowUserNotification[1].ToString(); //Gets overdueUserName from the row in 'Notifications'

                        

                        foreach (DataRow rowNotificationOverdue in dataTableUserInfo.Rows)//-------------------- Problem may be here as it is checking and getting all rows regardless if it 
                        {
                            if (rowNotificationOverdue[1].ToString() == overdueUserName && rowNotificationsCheck[1].ToString() == overdueUserName && i == 1)
                            {
                                userEmail = rowNotificationOverdue[3].ToString(); //Gets userEmail from the row in 'UserInfo'
                                overdueUserIndex = rowUserNotification[0].ToString();

                                /*foreach (DataRow row in dataTableNotificationsCheck.Rows)
                                {
                                    if (overdueUserName == rowNotificationOverdue.ToString())
                                    {
                                        MessageBox.Show(userEmail + "<==== Here is an email...");
                                    }

                                    MessageBox.Show(userEmail + "<==== Here is an email.");
                                }*/

                                MessageBox.Show(userEmail + "<==== Here is an email." + fullNotificationDateTimeString);


                                notificationTitleToSendToUser = "New Notification for " + overdueUserName + ": " + rowUserNotification[2].ToString();
                                notificationBodyToSendToUser = "Title: " + rowUserNotification[2].ToString() + "\nDescription: " + rowUserNotification[3].ToString() + "\n Location: " + rowUserNotification[4].ToString() + "\n Time of Notification: " + rowUserNotification[5].ToString();


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
                                    MessageBox.Show("email sent");

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Failed to send. Error: " + ex.Message);
                                }


                                SQLiteConnection sqlConnectionDeleteNotification = new SQLiteConnection();
                                sqlConnectionDeleteNotification.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";

                                SQLiteCommand sqlCommandDeleteNotification = new SQLiteCommand();
                                sqlCommandDeleteNotification.Connection = sqlConnectionDeleteNotification;
                                sqlCommandDeleteNotification.CommandType = CommandType.Text;
                                sqlCommandDeleteNotification.CommandText = "DELETE FROM Notifications WHERE NotificationIndex=@NotificationIndex";
                                sqlCommandDeleteNotification.Parameters.AddWithValue("@NotificationIndex", overdueUserIndex);

                                sqlConnectionDeleteNotification.Open();
                                sqlCommandDeleteNotification.ExecuteNonQuery();
                                sqlConnectionDeleteNotification.Close();




                                LoadUserNotifications();


                                //Prepare email to send to user about notification



                                i = 0;
                            }
                            
                        }
                    }
                }
                else if (comparedDates >= 0)
                {
                    MessageBox.Show(fullNotificationDateTime + " Date still to come");
                }
            }

            
        }
    }
}
