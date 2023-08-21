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
            AddListsToComboBoxes();

            SetObjectFeatures();

        }

        //Puts all colours and fonts into combo boxes. 
        private void AddListsToComboBoxes()
        {
            CmbBackgroundColour.DataSource = typeof(Color).GetProperties().Where(x => x.PropertyType == typeof(Color)).Select(x => x.GetValue(null)).ToList();
            CmbForegroundColour.DataSource = typeof(Color).GetProperties().Where(x => x.PropertyType == typeof(Color)).Select(x => x.GetValue(null)).ToList();

            foreach (FontFamily font in FontFamily.Families)
            {
                cmbFontType.Items.Add(font.Name.ToString());
            }
        }

        //Sets up how user interface based on the user's settings.
        private void SetObjectFeatures()
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = noterDatabase.db";

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
                    lblSettings.BackColor = Color.FromName(row[2].ToString());
                    lblBackgroundColour.BackColor = Color.FromName(row[2].ToString());
                    lblForegroundColour.BackColor = Color.FromName(row[2].ToString());
                    lblFontType.BackColor = Color.FromName(row[2].ToString());


                    //Font type
                    Font userFontTitleUnderlined = new Font(row[3].ToString(), 20, FontStyle.Underline);
                    Font userFontSubtitleUnderlined = new Font(row[3].ToString(), 12, FontStyle.Underline);
                    Font userFontComboBoxes = new Font(row[3].ToString(), 12);
                    Font userFontButtons = new Font(row[3].ToString(), 14);
                    lblSettings.Font = userFontTitleUnderlined;
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

        //Saves the users new settings. 
        private void BtnSaveSettings_Click(object sender, EventArgs e)
        {
            backgroundColourSelected = CmbBackgroundColour.Text;
            foregroundColourSelected = CmbForegroundColour.Text;
            fontType = cmbFontType.Text;

            //background colour
            BackColor = Color.FromName(backgroundColourSelected);

            //Foreground colour
            picBackPlate.BackColor = Color.FromName(foregroundColourSelected);
            lblSettings.BackColor = Color.FromName(foregroundColourSelected);
            lblBackgroundColour.BackColor = Color.FromName(foregroundColourSelected);
            lblForegroundColour.BackColor = Color.FromName(foregroundColourSelected);
            lblFontType.BackColor = Color.FromName(foregroundColourSelected);


            //Font type
            Font userFontTitleUnderlined = new Font(fontType, 20, FontStyle.Underline);
            Font userFontSubtitleUnderlined = new Font(fontType, 12, FontStyle.Underline);
            Font userFontComboBoxes = new Font(fontType, 12);
            Font userFontButtons = new Font(fontType, 14);
            lblSettings.Font = userFontTitleUnderlined;
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
            sqlConnection.ConnectionString = "DataSource = noterDatabase.db";

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

        //Loads the HomePage. 
        private void BtnHome_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want these settings?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                HomePage HomePage = new HomePage(userName);
                this.Hide();
                HomePage.Show();
            }
        }

        //Loads the HomePage when the application is closed. 
        private void settingsPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage HomePage = new HomePage(userName);
            this.Hide();
            HomePage.Show();
        }
    }
}
