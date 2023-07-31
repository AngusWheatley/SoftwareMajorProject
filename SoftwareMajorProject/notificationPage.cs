using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SoftwareMajorProject
{
    public partial class ReminderEditorPage : Form
    {
        //(Change when need to pass to other forms)
        string notificationDate; 
        //----------------------------

        string userName;
        string selectedNotificationIndex;
        string notificationDateTime;
        string userEmail;

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

            DgvCurrentNotifications.DataSource = dataTableNotifications;
            DgvCurrentNotifications.Columns["NotificationIndex"].Visible = false;
            DgvCurrentNotifications.Columns["UserName"].Visible = false;

            DgvCurrentNotifications.Columns[2].Width = 120;
            DgvCurrentNotifications.Columns[3].Width = 145;
            DgvCurrentNotifications.Columns[4].Width = 115;
            DgvCurrentNotifications.Columns[5].Width = 110;

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

                SQLiteConnection sqlConnectionNotifications = new SQLiteConnection();
                sqlConnectionNotifications.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";

                string insertNotificationsCommand = "SELECT * FROM Notifications WHERE UserName='" + userName + "'";

                sqlConnectionNotifications.Open();
                var dataTableNotifications = new DataTable();
                SQLiteDataAdapter notificationsDataAdapter = new SQLiteDataAdapter(insertNotificationsCommand, sqlConnectionNotifications);


                notificationsDataAdapter.Fill(dataTableNotifications);
                sqlConnectionNotifications.Close();

                //=========================================================================================================

                DgvCurrentNotifications.DataSource = dataTableNotifications;
                DgvCurrentNotifications.Columns["NotificationIndex"].Visible = false;
                DgvCurrentNotifications.Columns["UserName"].Visible = false;

                DgvCurrentNotifications.Columns[2].Width = 120;
                DgvCurrentNotifications.Columns[3].Width = 145;
                DgvCurrentNotifications.Columns[4].Width = 115;
                DgvCurrentNotifications.Columns[5].Width = 110;


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


            SQLiteConnection sqlConnectionNotifications = new SQLiteConnection();
            sqlConnectionNotifications.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";

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

            string insertNotificationsCommand = "SELECT * FROM Notifications";


            sqlConnectionNotificationsCheck.Open();
            var dataTableNotificationsCheck = new DataTable();
            SQLiteDataAdapter notificationsDataAdapter = new SQLiteDataAdapter(insertNotificationsCommand, sqlConnectionNotificationsCheck);


            notificationsDataAdapter.Fill(dataTableNotificationsCheck);
            sqlConnectionNotificationsCheck.Close();






            foreach (DataRow rowNotificationCheck in dataTableNotificationsCheck.Rows)
            {
                DateTime dateTimeNow = DateTime.Now;
                DateTime fullNotificationDateTime = Convert.ToDateTime(notificationDateTime);

                int comparedDates = fullNotificationDateTime.CompareTo(dateTimeNow);
                if (comparedDates < 0)
                {

                    //SQLiteCommand checkIfNotificationOverdueCommand = new SQLiteCommand("SELECT * FROM UserInfo WHERE userName='" + userName + "'");
                    //checkIfNotificationOverdueCommand.Parameters.AddWithValue("@userEmail", userEmail);

                    string checkIfNotificationOverdueCommand = "SELECT * FROM 'UserInfo'";
                    SQLiteDataAdapter notificationOverdueDataAdapter = new SQLiteDataAdapter(checkIfNotificationOverdueCommand, sqlConnectionNotificationsCheck);

                    //checkIfNotificationOverdueCommand.Parameters.AddWithValue("", );


                    var dataTableCheckIfNotificationOverdue = new DataTable();

                    sqlConnectionNotificationsCheck.Open();
                    notificationOverdueDataAdapter.Fill(dataTableCheckIfNotificationOverdue);
                    sqlConnectionNotificationsCheck.Close();

                    foreach (DataRow rowNotificationOverdue in dataTableCheckIfNotificationOverdue.Rows)
                    {
                        if (rowNotificationOverdue[1].ToString() == userName)
                        {
                            userEmail = rowNotificationOverdue[3].ToString();


                            //Prepare email to send to user about notification


                            MessageBox.Show(userEmail + "<==== Here is an email.");


                        }
                    }
                }
            }

            
        }
    }
}
