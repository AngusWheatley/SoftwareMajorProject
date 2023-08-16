using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using System.Net.Mail;
using System.Net;

namespace SoftwareMajorProject
{
    public partial class LoginPage : Form
    {
        string userName;
        string userPassword;
        string trimmedUserName;

        string userEmail;
        string overdueUserName;
        string overdueUserIndex;
        string notificationTitleToSendToUser;
        string notificationBodyToSendToUser;

        bool isTimerRunning;

        public LoginPage()
        {
            

            InitializeComponent();
            /*TimerCheckNotifications.Stop();
            isTimerRunning = false;
            TimerCheckNotifications.Enabled = true;*/     //Make timer not be able to tick multiple times at once after logging in and out many times


            //TimerCheckNotifications.Enabled = true;

            if (!TimerCheckNotifications.Enabled)
            {
                TimerCheckNotifications.Start();
            }

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            userName = "";


        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            userName = txtUserName.Text;
            userPassword = txtUserPassword.Text;

            trimmedUserName = String.Concat(txtUserName.Text.Where(c => !Char.IsWhiteSpace(c)));
            string trimmedUserPassword = String.Concat(userPassword.Where(c => !Char.IsWhiteSpace(c)));


            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = noterDatabase.db";

            if (txtUserName.Text != "" && txtUserPassword.Text != "" && txtUserName.Text != "" && txtUserPassword.Text != "")
            {
                SQLiteCommand cmd = new SQLiteCommand("Select * From userInfo where userName = @userName and userPassword = @userPassword;");

                cmd.Parameters.AddWithValue("@userName", trimmedUserName);
                cmd.Parameters.AddWithValue("@userPassword", trimmedUserPassword);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();

                DataTable userInfoDataTable = new DataTable();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);


                dataAdapter.Fill(userInfoDataTable);
                sqlConnection.Close();


                bool loginSuccessful = (userInfoDataTable.Rows.Count > 0);
                if (loginSuccessful)
                {
                    MessageBox.Show("Successfuly Logged In");

                    userPassword = txtUserPassword.Text;

                    foreach (DataRow row in userInfoDataTable.Rows)
                    {
                        if (row[1].ToString() == trimmedUserName || row[3].ToString() == trimmedUserName)
                        {
                            userName = row[1].ToString();
                        }
                    }

                    HomePage HomePage = new HomePage(userName);
                    this.Hide();
                    HomePage.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password. ");
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void LinkNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewAccountPage NewAccountPage = new NewAccountPage();
            this.Hide();
            NewAccountPage.Show();
        }

        private void TxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUserName.Text = txtUserName.Text.Replace(System.Environment.NewLine, "");
                BtnLogin_Click(sender, e);
                txtUserName.Text = txtUserName.Text.Replace(System.Environment.NewLine, "");
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUserPassword.Text = txtUserPassword.Text.Replace(System.Environment.NewLine, "");
                BtnLogin_Click(sender, e);
                txtUserPassword.Text = txtUserPassword.Text.Replace(System.Environment.NewLine, "");
            }
        }

        private void TimerCheckNotifications_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("Searching for overdue notifications, please wait.");


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

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            DialogResult closingNoterResult = MessageBox.Show("Are you sure you want to close Noter?", "Noter", MessageBoxButtons.YesNo);
            if (closingNoterResult == DialogResult.Yes)
            {
                DialogResult closingNoterConfirmationResult = MessageBox.Show("This will mean you will not recieve your notificaions until you open Noter again. Do you wish to continue?", "Noter", MessageBoxButtons.YesNo);
                if (closingNoterConfirmationResult == DialogResult.Yes) 
                {
                    e.Cancel = false;
                    Application.ExitThread();
                }
                else if (closingNoterConfirmationResult == DialogResult.No)
                {
                    DialogResult minimizingNoterResult = MessageBox.Show("Would you like to minimize Noter?", "Noter", MessageBoxButtons.YesNo);
                    if (minimizingNoterResult == DialogResult.Yes)
                    {
                        e.Cancel = true;
                        this.WindowState = FormWindowState.Minimized;
                    }
                    else if (minimizingNoterResult == DialogResult.No)
                    {
                        e.Cancel = true;

                        this.WindowState = FormWindowState.Maximized;
                    }

                }

            }
            else if (closingNoterResult == DialogResult.No)
            {
                DialogResult minimizingNoterResult = MessageBox.Show("Would you like to minimize Noter?????", "Noter", MessageBoxButtons.YesNo);
                if (minimizingNoterResult == DialogResult.Yes)
                {
                    e.Cancel = true;
                    this.WindowState = FormWindowState.Minimized;
                }
                else if (minimizingNoterResult == DialogResult.No)
                {
                    //this.WindowState= FormWindowState.Normal;

                    e.Cancel = true;

                }
            }

        }
    }
}
