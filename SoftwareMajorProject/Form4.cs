using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SoftwareMajorProject
{
    public partial class ReminderEditorPage : Form
    {
        public string notificationDate; 
        public string userName = LoginPage.userName;
        public ReminderEditorPage()
        {
            InitializeComponent();
        }

        private void ReminderEditorPage_Load(object sender, EventArgs e)
        {


        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage HomePage = new HomePage();
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

            sqlCommandNewUser.Parameters.AddWithValue("@userName", userName);
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
