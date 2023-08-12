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
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            OtherInformationPage OtherInformationPage = new OtherInformationPage(userNameLoggedIn);
            this.Hide();
            OtherInformationPage.Show();
        }

    }
}
