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
        public string notificationDate; 
        //----------------------------

        string userName;
        public ReminderEditorPage(string userNameLoggedIn)
        {
            userName = userNameLoggedIn;
            InitializeComponent();
        }

        private void ReminderEditorPage_Load(object sender, EventArgs e)
        {
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


            SQLiteConnection sqlConnectionNotifications = new SQLiteConnection();
            sqlConnectionNotifications.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";

            string insertNotificationsCommand = "SELECT * FROM 'Notifications' where UserName = '@" + userName + "'";
            SQLiteDataAdapter notificationsDataAdapter = new SQLiteDataAdapter(insertNotificationsCommand, sqlConnectionNotifications);
            var dataTableNotifications = new DataTable();

            sqlConnectionNotifications.Open();
            notificationsDataAdapter.Fill(dataTableNotifications);
            sqlConnectionNotifications.Close();


            var dataTableUserNotifications = new DataTable();
            foreach (DataRow row in dataTableNotifications.Rows)
            {
                if (row[0].ToString() == userName)
                {
                    dataTableUserNotifications.Rows.Add(row);
                    
                }

            }




            DgvCurrentNotifications.DataSource = dataTableUserNotifications;




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
            string notificationTitle = txtNotificationTitle.Text;
            string notificationDescription = txtNotificationDescription.Text;
            string notificationLocation = txtNotificationLocation.Text;
            string notificationTime = notificationDate + " " +CmbNotificationHour.Text + ":" + CmbNotificationMinute.Text + ":00 " + CmbNotificationPeriod.Text;

            MessageBox.Show(notificationTime);


            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";
            

            SQLiteCommand sqlCommandNewUser = new SQLiteCommand();
            sqlCommandNewUser.Connection = sqlConnection;
            sqlCommandNewUser.CommandType = CommandType.Text;
            sqlCommandNewUser.CommandText = "INSERT into Notifications (userName, Title, Description, Location, Time) values (@userName, @Title, @Description, @Location, @Time)";

            //sqlCommandNewUser.Parameters.AddWithValue("@userName", userName);
            sqlCommandNewUser.Parameters.AddWithValue("@Title", notificationTitle);
            sqlCommandNewUser.Parameters.AddWithValue("@Description", notificationDescription);
            sqlCommandNewUser.Parameters.AddWithValue("@Location", notificationLocation);
            sqlCommandNewUser.Parameters.AddWithValue("@Time", notificationTime);

            sqlConnection.Open();
            sqlCommandNewUser.ExecuteNonQuery();
            sqlConnection.Close();



        }

        private void CalNotificationDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            notificationDate = e.Start.ToShortDateString();
        }
    }
}
