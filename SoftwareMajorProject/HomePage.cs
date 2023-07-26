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

namespace SoftwareMajorProject
{
    public partial class HomePage : Form
    {
        public static string userName = LoginPage.userName;
        public static string userPassword = LoginPage.userPassword;
        public static string userEmail = LoginPage.userEmail;
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            this.Width = 1440;
            this.Height = 860; 


            txtName.Text = userName;
            txtPassword.Text = userPassword;
            TxtUserEmail.Text = userEmail;



            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";

            string cmd = "SELECT * FROM NoterSettings WHERE userName=" + userName;
            SQLiteDataAdapter userSettingsDataAdapter = new SQLiteDataAdapter(cmd, sqlConnection);
            var datatableUserSettings = new DataTable();

            sqlConnection.Open();
            userSettingsDataAdapter.Fill(datatableUserSettings);

            txtReplacedUserName.Text = datatableUserSettings.Rows[0]["userName"].ToString();
            txtUserBackgroundColour.Text = datatableUserSettings.Rows[0]["backgroundColour"].ToString();
            txtUserForegroundColour.Text = datatableUserSettings.Rows[0]["foregroundColour"].ToString();
            txtUserFont.Text = datatableUserSettings.Rows[0]["fontType"].ToString();

            sqlConnection.Close();

            BackColor = Color.FromName(txtUserBackgroundColour.Text);





        }

        private void BtnReminder_Click(object sender, EventArgs e)
        {

            ReminderEditorPage reminderEditorPage = new ReminderEditorPage();
            this.Hide();
            reminderEditorPage.Show();
        }

        private void btnDiary_Click(object sender, EventArgs e)
        {

            DiaryEditorPage DiaryEditorPage = new DiaryEditorPage();
            this.Hide();
            DiaryEditorPage.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
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
                MessageBox.Show("Successfully Remined Logged In");
            }

            
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            NoterSettings settings = new NoterSettings();
            this.Hide();
            settings.Show();
            
        }
    }
}
