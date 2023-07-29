using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Hosting;

namespace SoftwareMajorProject
{
    public partial class settingsPage : Form
    {
        string userName;
        string backgroundColourSelected;
        string foregroundColourSelected;
        string fontType;

        public settingsPage(string userNameGiven)
        {
            userName = userNameGiven;
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

            txtUserName.Text = userName;



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

                    CmbBackgroundColour.Text = row[1].ToString();

                    //Front colour
                    picBackPlate.BackColor = Color.FromName(row[2].ToString());
                    lblBackgroundColour.BackColor = Color.FromName(row[2].ToString());
                    lblForegroundColour.BackColor = Color.FromName(row[2].ToString());
                    lblFontType.BackColor = Color.FromName(row[2].ToString());

                    CmbForegroundColour.Text = row[2].ToString();


                    //Font type
                    var fontConverter = new FontConverter();
                    lblBackgroundColour.Font = new Font(fontConverter.ConvertFromString(row[3].ToString()) as Font, FontStyle.Underline);
                    CmbBackgroundColour.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                    lblForegroundColour.Font = new Font(fontConverter.ConvertFromString(row[3].ToString()) as Font, FontStyle.Underline);
                    CmbForegroundColour.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                    lblFontType.Font = new Font(fontConverter.ConvertFromString(row[3].ToString()) as Font, FontStyle.Underline);
                    cmbFontType.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                    BtnSaveSettings.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                    BtnHome.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;

                    cmbFontType.Text = row[3].ToString();







                    //Text Size
                    //var sizeConverter = new SizeConverter();
                    //lblBackgroundColour.Font = sizeConverter.ConvertFromInvariantString.row[4].ToString();

                }
            }




        }

        private void BtnSaveSettings_Click(object sender, EventArgs e)
        {
            backgroundColourSelected = CmbBackgroundColour.Text;
            foregroundColourSelected = CmbForegroundColour.Text;
            fontType = cmbFontType.Text;

            BackColor = Color.FromName(backgroundColourSelected);

            picBackPlate.BackColor = Color.FromName(foregroundColourSelected);
            lblBackgroundColour.BackColor = Color.FromName(foregroundColourSelected);
            lblForegroundColour.BackColor = Color.FromName(foregroundColourSelected);
            lblFontType.BackColor = Color.FromName(foregroundColourSelected);



            /*
            switch (backgroundColourSelected)
            {
                case "Red":
                    BackColor = Color.Red;
                break;

                case "Orange":
                    BackColor = Color.Orange;
                break;

                case "Yellow":
                    BackColor = Color.Yellow;
                break;

                case "Green":
                    BackColor = Color.Green;
                break;

                case "Blue":
                    BackColor = Color.Blue;
                break;

                case "Purple":
                    BackColor = Color.Purple;
                break;
            } //Colour selecter
            */

            /*
            switch (foregroundColourSelected)
            {
                case "Red":
                    picBackPlate.BackColor = Color.Red;
                    lblBackgroundColour.BackColor = Color.Red;
                    lblForegroundColour.BackColor = Color.Red;
                    lblFontType.BackColor = Color.Red;
                    break;

                case "Orange":
                    picBackPlate.BackColor= Color.Orange;
                    lblBackgroundColour.BackColor = Color.Orange;
                    lblForegroundColour.BackColor = Color.Orange;
                    lblFontType.BackColor= Color.Orange;
                    break;

                case "Yellow":
                    picBackPlate.BackColor = Color.Yellow;
                    lblBackgroundColour.BackColor = Color.Yellow;
                    lblForegroundColour.BackColor = Color.Yellow;
                    lblFontType.BackColor = Color.Yellow;
                    break;

                case "Green":
                    picBackPlate.BackColor = Color.Green;
                    lblBackgroundColour.BackColor = Color.Green;
                    lblForegroundColour.BackColor = Color.Green;
                    lblFontType.BackColor = Color.Green;
                    break;

                case "Blue":
                    picBackPlate.BackColor = Color.Blue;
                    lblBackgroundColour.BackColor = Color.Blue;
                    lblForegroundColour.BackColor = Color.Blue;
                    lblFontType.BackColor = Color.Blue;
                    break;

                case "Purple":
                    picBackPlate.BackColor = Color.Purple;
                    lblBackgroundColour.BackColor = Color.Purple;
                    lblForegroundColour.BackColor = Color.Purple;
                    lblFontType.BackColor = Color.Purple;
                    break;
            }*/



            var fontConverter = new FontConverter();
            /*
            switch (fontType)
            {
                case "Helvetica":
                    lblBackgroundColour.Font = fontConverter.ConvertFromString(fontType) as Font;

                    break;

                case "Calibri":
                    
                    break;

                case "Futura":

                    break;

                case "Times New Roman":

                    break;

                case "Arial":

                    break;

                case "Cambria":

                    break;

                case "Rockwell":

                    break;
            }*/

            lblBackgroundColour.Font = new Font(fontConverter.ConvertFromString(fontType) as Font, FontStyle.Underline);
            CmbBackgroundColour.Font = fontConverter.ConvertFromString(fontType) as Font;
            lblForegroundColour.Font = new Font(fontConverter.ConvertFromString(fontType) as Font, FontStyle.Underline);
            CmbForegroundColour.Font = fontConverter.ConvertFromString(fontType) as Font;
            lblFontType.Font = new Font(fontConverter.ConvertFromString(fontType) as Font, FontStyle.Underline);
            cmbFontType.Font = fontConverter.ConvertFromString(fontType) as Font;
            BtnSaveSettings.Font = fontConverter.ConvertFromString(fontType) as Font;
            BtnHome.Font = fontConverter.ConvertFromString(fontType) as Font;








            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";

            SQLiteCommand cmd = new SQLiteCommand("UPDATE NoterSettings SET userName=@userName, backgroundColour=@backgroundColour, foregroundColour=@foregroundColour, fontType=@fontType WHERE userName=@userName");



            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@backgroundColour", backgroundColourSelected);
            cmd.Parameters.AddWithValue("@foregroundColour", foregroundColourSelected);
            cmd.Parameters.AddWithValue("@fontType", fontType);

            cmd.Connection = sqlConnection;
            sqlConnection.Open();

            DataTable userInfoDataTable = new DataTable();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);


            dataAdapter.Fill(userInfoDataTable);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();









            



            /*Properties.Settings.Default["BackColor"] = BackColor;
            Properties.Settings.Default.BackgroundColour = BackColor;

            Properties.Settings.Default.Save();
            */
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            HomePage HomePage = new HomePage(userName);
            this.Hide();
            HomePage.Show();
        }

        private void lblFontType_Click(object sender, EventArgs e)
        {

        }

    }
}
