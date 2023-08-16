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
    public partial class OtherInformationPage : Form
    {
        string userName;
        public OtherInformationPage(string userNameLoggedIn)
        {
            userName = userNameLoggedIn;
            InitializeComponent();
        }

        private void OtherInformationPage_Load(object sender, EventArgs e)
        {

            SetObjectFeaturers();

        }

        private void SetObjectFeaturers()
        {
            lblTitle.Left = (this.Width / 2) - (lblTitle.Size.Width / 2);


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
                if (row[0].ToString() == userName)
                {
                    //Background colour
                    BackColor = Color.FromName(row[1].ToString());

                    //Foreground colour
                    picBackPlate.BackColor = Color.FromName(row[2].ToString());
                    lblTitle.BackColor = Color.FromName(row[2].ToString());

                    //Font type
                    Font userFontTitle = new Font(row[3].ToString(), 20, FontStyle.Underline);
                    Font userFontBigButtons = new Font(row[3].ToString(), 24);
                    Font userFontHomeButton = new Font(row[3].ToString(), 16);
                    lblTitle.Font = userFontTitle;
                    BtnUserGuide.Font = userFontBigButtons;
                    BtnEndUserLicenceAgreement.Font = userFontBigButtons;
                    BtnHome.Font = userFontHomeButton;
                }
            }
        }

        private void BtnUserGuide_Click(object sender, EventArgs e)
        {
            UserGuidePage UserGuidePage = new UserGuidePage(userName);
            this.Hide();
            UserGuidePage.Show();
        }

        private void BtnEndUserLicenceAgreement_Click(object sender, EventArgs e)
        {
            EndUserLicenceAgreementPage EndUserLicenceAgreementPage = new EndUserLicenceAgreementPage(userName);
            this.Hide();
            EndUserLicenceAgreementPage.Show();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            HomePage HomePage = new HomePage(userName);
            this.Hide();
            HomePage.Show();
        }
    }
}
