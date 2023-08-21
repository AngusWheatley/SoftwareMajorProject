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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SoftwareMajorProject
{
    public partial class UserGuidePage : Form
    {
        string userNameLoggedIn;
        public UserGuidePage(string userName)
        {
            userNameLoggedIn = userName;
            InitializeComponent();
        }

        private void UserGuidePage_Load(object sender, EventArgs e)
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = noterDatabase.db";

            string cmd = "SELECT * FROM 'NoterSettings'";
            SQLiteDataAdapter settingsDataAdapter = new SQLiteDataAdapter(cmd, sqlConnection);

            var dataTableSettings = new DataTable();

            sqlConnection.Open();
            settingsDataAdapter.Fill(dataTableSettings);
            sqlConnection.Close();

            foreach (DataRow row in dataTableSettings.Rows)
            {
                if (row[0].ToString() == userNameLoggedIn)
                {
                    //Background colour
                    BackColor = Color.FromName(row[1].ToString());

                    //Font type
                    Font userFontTextBox = new Font(row[3].ToString(), 10);
                    Font userFontBackButton = new Font(row[3].ToString(), 12);
                    txtUserGuide.Font = userFontTextBox;
                    BtnBack.Font = userFontBackButton;
                }
            }

            txtUserGuide.Text = ("User Manual For Noter\r\n\r\nTable of Contents:\r\nCreating an Account\r\nLogging In\r\nMaking a Notification\r\nMaking and Viewing Diary Entries\r\n\tMaking a Diary Entry\r\n\tViewing Diary Entries\r\nChanging Settings\r\nViewing EULA and User Manual\r\nClosing Noter\r\n\r\nCreating an Account\r\nThis section of the user manual will guide you through making an account for Noter. \r\n\r\nPress the ‘Make One Here’ button on the bottom of the screen. \r\n\r\n\r\nEnter information into ‘Name’, ‘Password’ and ‘Email’ textboxes. Once you have entered your information press the ‘Sign Up’ button. \r\n\r\n\r\nYou will have a verification code sent to your email. Enter the code into the textbox and press ‘Submit’. \r\n\r\n\r\nYour account has now been created and you are redirected to the login page. \r\n\r\n\r\n\r\nLogging In\r\nThis section of the user manual will guide you through logging in to Noter. \r\n\r\nEnter your account details into the ‘Name or Email’ and ‘Password’ textboxes. Once you have entered your account details, press the ‘Login’ Button. \r\n\r\n\r\nYou have now logged in and you will be greeted with this screen. \r\n\r\n\r\nMaking a Notification\r\nThis section of the user manual will guide you through making a notification using Noter. \r\n\r\nPress the ‘Notifications’ button on the home page to open the notifications page. \r\n\r\n\r\nEnter information about the notification in the textboxes and select the date and time with the calendar and combo boxes. Press the ‘Save’ button once the information is entered. (The date and time must be after the current date and time). \r\n\r\nThe notification will show up in the list as shown in the red box below. To see the full length of the notification, hover over the box that contains the information you want to see and it will show a popup of the text inside that cell. \r\n\r\n\r\nTo delete a notification, select the notification by clicking where arrow 1 is pointing. Then clicking the ‘Delete’ button where arrow 2 is pointing. \r\n\r\n\r\nYou will be asked to confirm the deletion of the notification, select yes if you want to delete the notification. \r\n\r\n\r\n\r\nMaking and Viewing Diary Entries\r\nMaking a Diary Entry\r\nThis section of the user manual will guide you through making a diary entry using Noter. \r\n\r\nPress the ‘Diary’ button on the homepage to open the diary entry page. \r\n\r\n\r\nEnter information about the diary entry in the textboxes and the date of the entry in the calendar. Once your diary entry information has been entered, press the ‘Save’ button. \r\n\r\n\r\nViewing Diary Entries\r\nThis section of the user manual will guide you through viewing your diary entries in Noter. \r\n\r\nClick the ‘All Entries’ button. \r\n\r\n\r\nSelect the notification where arrow 1 is pointing to, and the diary entry will show up in the textboxes on the right as shown. \r\n\r\n\r\n\r\nChanging Settings\r\nThis section of the user manual will guide you through changing the settings in Noter. \r\n\r\nClick the ‘Settings’ button on the home page to go to the settings page. \r\n\r\n\r\nUse the combo boxes to change to the desired settings. Press the ‘Save Settings’ button to save settings, and use the ‘Home’ button to go back to the home page. \r\n\r\n\r\n\r\nViewing EULA and User Manual\r\nThis section of the user manual will guide you through how to view the EULA and User Manual for Noter. \r\n\r\nClick the ‘Other information’ button to get to the other information page. \r\n\r\n\r\nClick the ‘User Guide’ or ‘EULA’ buttons to view each document in a textbox. You can scroll up and down in the textboxes to continue reading more information. \r\n\r\nClosing Noter\r\nThis section of the user manual will guide you through closing Noter. \r\n\r\nReturn to the login page (This can be done by following the section ‘Logging Out’). \r\n\r\n\r\nPress the ‘X’ button in the top right corner. Follow the prompts to close the application. \r\n\r\n\r\nWARNING: If you decide to completely close the application, you will not receive notifications until the application is launched again. \r\n\r\nNOTE: If you choose to minimize the application, you can open it again by clocking the logo on the taskbar. \r\n\r\n\r\n");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            OtherInformationPage OtherInformationPage = new OtherInformationPage(userNameLoggedIn);
            this.Hide();
            OtherInformationPage.Show();
        }

        private void UserGuidePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage HomePage = new HomePage(userNameLoggedIn);
            this.Hide();
            HomePage.Show();
        }
    }
}
