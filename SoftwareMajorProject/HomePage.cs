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
    public partial class HomePage : Form
    {
        string userNameLoggedIn;

        public HomePage(string userName)
        {
            userNameLoggedIn = userName;
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {


            lblWelcome.Text = "Welcome: " + userNameLoggedIn;

            

            SetObjectFeatures(); //Initialises UI from user settings
        }

        private void BtnReminderPage_Click(object sender, EventArgs e)
        {

            ReminderEditorPage reminderEditorPage = new ReminderEditorPage(userNameLoggedIn);
            this.Hide();
            reminderEditorPage.Show();
        }

        private void BtnDiaryPage_Click(object sender, EventArgs e)
        {
            DiaryEditorPage DiaryEditorPage = new DiaryEditorPage(userNameLoggedIn);
            this.Hide();
            DiaryEditorPage.Show();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            LogOut();

        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            settingsPage settings = new settingsPage(userNameLoggedIn);
            this.Hide();
            settings.Show();
        }

        private void LogOut()
        {
            string logOutMessage = "Are You Sure You Want To Log Out?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult logOut = MessageBox.Show(logOutMessage, "", buttons);

            if (logOut == DialogResult.Yes)
            {
                MessageBox.Show("Successfully Logged Out");

                LoginPage LoginPage = new LoginPage();
                this.Hide();
                LoginPage.Show();
            }
            else
            {
                MessageBox.Show("Successfully Remained Logged In");
            }
        }
        
        private void SetObjectFeatures()
        {
            lblTitle.Left = (this.Width / 2) - (lblTitle.Size.Width / 2);
            lblWelcome.Left = (this.Width / 2) - (lblWelcome.Size.Width / 2);

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

                    //Foreground colour
                    picBackPlate.BackColor = Color.FromName(row[2].ToString());
                    lblTitle.BackColor = Color.FromName(row[2].ToString());
                    lblWelcome.BackColor = Color.FromName(row[2].ToString());

                    //Font type
                    Font userFontBig = new Font(row[3].ToString(), 48, FontStyle.Underline);
                    Font userFontMedium = new Font(row[3].ToString(), 24);
                    Font userFontSmall = new Font(row[3].ToString(), 16);
                    lblTitle.Font = userFontBig;
                    lblWelcome.Font = userFontMedium;
                    btnNotificationsPage.Font = userFontSmall;
                    BtnDiaryPage.Font = userFontSmall;
                    BtnLogOut.Font = userFontSmall;
                    BtnSettings.Font = userFontSmall;
                    BtnOtherInformation.Font = userFontSmall;
                }
            }
        }

        private void BtnOtherInformation_Click(object sender, EventArgs e)
        {
            OtherInformationPage otherInformationPage = new OtherInformationPage(userNameLoggedIn);
            this.Hide();
            otherInformationPage.Show();
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginPage LoginPage = new LoginPage();
            this.Hide();
            LoginPage.Show();
        }
    }
}
