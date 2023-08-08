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
                    CmbBackgroundColour.Text = row[1].ToString();
                    CmbForegroundColour.Text = row[2].ToString();

                    //Back colour
                    BackColor = Color.FromName(row[1].ToString());



                    //Front colour
                    picBackPlate.BackColor = Color.FromName(row[2].ToString());
                    lblBackgroundColour.BackColor = Color.FromName(row[2].ToString());
                    lblForegroundColour.BackColor = Color.FromName(row[2].ToString());
                    lblFontType.BackColor = Color.FromName(row[2].ToString());


                    //Font type
                    var fontConverter = new FontConverter();
                    Font userFontSubtitleUnderlined = new Font(row[3].ToString(), 12, FontStyle.Underline);
                    Font userFontComboBoxes = new Font(row[3].ToString(), 12);
                    Font userFontButtons = new Font(row[3].ToString(), 16);
                    lblBackgroundColour.Font = userFontSubtitleUnderlined;
                    CmbBackgroundColour.Font = userFontComboBoxes;
                    lblForegroundColour.Font = userFontSubtitleUnderlined;
                    CmbForegroundColour.Font = userFontComboBoxes;
                    lblFontType.Font = userFontSubtitleUnderlined;
                    cmbFontType.Font = userFontComboBoxes;
                    BtnSaveSettings.Font = userFontButtons;
                    BtnHome.Font = userFontButtons;

                    cmbFontType.Text = row[3].ToString();


                }
            }

        }

        private void BtnSaveSettings_Click(object sender, EventArgs e)
        {
            backgroundColourSelected = CmbBackgroundColour.Text;
            foregroundColourSelected = CmbForegroundColour.Text;
            fontType = cmbFontType.Text;

            //background colour
            BackColor = Color.FromName(backgroundColourSelected);

            //Foreground colour
            picBackPlate.BackColor = Color.FromName(foregroundColourSelected);
            lblBackgroundColour.BackColor = Color.FromName(foregroundColourSelected);
            lblForegroundColour.BackColor = Color.FromName(foregroundColourSelected);
            lblFontType.BackColor = Color.FromName(foregroundColourSelected);


            //Font type -- Done
            Font userFontSubtitleUnderlined = new Font(fontType, 12, FontStyle.Underline);
            Font userFontComboBoxes = new Font(fontType, 12);
            Font userFontButtons = new Font(fontType, 16);
            lblBackgroundColour.Font = userFontSubtitleUnderlined;
            CmbBackgroundColour.Font = userFontComboBoxes;
            lblForegroundColour.Font = userFontSubtitleUnderlined;
            CmbForegroundColour.Font = userFontComboBoxes;
            lblFontType.Font = userFontSubtitleUnderlined;
            cmbFontType.Font = userFontComboBoxes;
            BtnSaveSettings.Font = userFontButtons;
            BtnHome.Font = userFontButtons;


            //============================================================================================================


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

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            HomePage HomePage = new HomePage(userName);
            this.Hide();
            HomePage.Show();
        }
    }
}
