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
        string userNameGiven;
        public static string userPassword = LoginPage.userPassword;
        public static string userEmail = LoginPage.userEmail;
        public static string trimmedUserName = LoginPage.trimmedUserName;

        public HomePage(string userName)
        {
            userNameGiven = userName;
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            this.Width = 1440;
            this.Height = 860; 


            txtName.Text = userNameGiven;
            txtPassword.Text = userPassword;
            TxtUserEmail.Text = userEmail;


            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";

            string cmd = "SELECT * FROM 'NoterSettings'";
            SQLiteDataAdapter settingsDataAdapter = new SQLiteDataAdapter(cmd, sqlConnection);

            var dataGridViewSettings = new DataTable();

            sqlConnection.Open();
            settingsDataAdapter.Fill(dataGridViewSettings);
            sqlConnection.Close();

            DgvSettings.DataSource = dataGridViewSettings;


            foreach (DataRow row in dataGridViewSettings.Rows)
            {
                if (row[0].ToString() == userNameGiven)
                {
                    txtReplacedUserName.Text = row[0].ToString();
                    txtUserBackgroundColour.Text = row[1].ToString();
                    txtUserForegroundColour.Text = row[2].ToString();
                    txtUserFont.Text = row[3].ToString();

                    BackColor = Color.FromName(row[1].ToString());
                    picBackPlate.BackColor = Color.FromName(row[2].ToString());
                }
            }




            //txtReplacedUserName.Text = dataGridViewSettings.Rows[0]["userName"].ToString();
            //txtUserBackgroundColour.Text = dataGridViewSettings.Rows[0]["backgroundColour"].ToString();
            //txtUserForegroundColour.Text = dataGridViewSettings.Rows[0]["foregroundColour"].ToString();
            //txtUserFont.Text = dataGridViewSettings.Rows[0]["fontType"].ToString();



            /*
            DataRow[] dr = dataGridViewSettings.Select("userName = '" + txtName.Text + "'");
            if (dr.Length != 0)
            {
                DgvSettings.DataSource = dr;
            }*/



            /*


            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";

            string commandSelectUserSettings = "SELECT * FROM 'NoterSettings' WHERE 'userName' LIKE'%" + txtName.Text + "%'";
            
            SQLiteDataAdapter userSettingsDataAdapter = new SQLiteDataAdapter(commandSelectUserSettings, sqlConnection);
            
            var datatableUserSettings = new DataTable();

            sqlConnection.Open();
            userSettingsDataAdapter.Fill(datatableUserSettings);
            



            txtReplacedUserName.Text = datatableUserSettings.Rows[0]["'userName'"].ToString();
            txtUserBackgroundColour.Text = datatableUserSettings.Rows[0]["backgroundColour"].ToString();
            txtUserForegroundColour.Text = datatableUserSettings.Rows[0]["foregroundColour"].ToString();
            txtUserFont.Text = datatableUserSettings.Rows[0]["fontType"].ToString();

            sqlConnection.Close();

            BackColor = Color.FromName(txtUserBackgroundColour.Text);


            */


            /*
            {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";

            string commandSelectUserSettings = "SELECT * FROM NoterSettings WHERE userName=" + userName;
            var datatableUserSettings = new DataTable();
            SQLiteDataAdapter userSettingsDataAdapter = new SQLiteDataAdapter(commandSelectUserSettings, sqlConnection);
            

            sqlConnection.Open();
            userSettingsDataAdapter.Fill(datatableUserSettings);

            txtReplacedUserName.Text = datatableUserSettings.Rows[0]["userName"].ToString();
            txtUserBackgroundColour.Text = datatableUserSettings.Rows[0]["backgroundColour"].ToString();
            txtUserForegroundColour.Text = datatableUserSettings.Rows[0]["foregroundColour"].ToString();
            txtUserFont.Text = datatableUserSettings.Rows[0]["fontType"].ToString();

            sqlConnection.Close();

            BackColor = Color.FromName(txtUserBackgroundColour.Text);
            }*/





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
                MessageBox.Show("Successfully Remained Logged In");
            }

            
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            NoterSettings settings = new NoterSettings(userNameGiven);
            this.Hide();
            settings.Show();
            
        }
    }
}
