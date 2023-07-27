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
    public partial class NoterSettings : Form
    {
        string userName;
        public static string backgroundColourSelected;
        public static string foregroundColourSelected;
        public static string fontType;

        public NoterSettings(string userNameGiven)
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

                    //Front colour
                    lblBackgroundColour.BackColor = Color.FromName(row[2].ToString());
                    picBackPlate.BackColor = Color.FromName(row[2].ToString());

                    //Text font
                    var fontConverter = new FontConverter();
                    var sizeConverter = new SizeConverter();
                    lblBackgroundColour.Font = new Font(fontConverter.ConvertFromString(row[3].ToString()) as Font, (FontStyle)sizeConverter.ConvertFromString("12"));
                    CmbBackgroundColour.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;


                    //Text Size
                    //var sizeConverter = new SizeConverter();
                    //lblBackgroundColour.Font = sizeConverter.ConvertFromInvariantString.row[4].ToString();
                }
            }

        }

        private void BtnSaveSettings_Click(object sender, EventArgs e)
        {
            backgroundColourSelected = CmbBackgroundColour.Text;

            {
                if (backgroundColourSelected == "Red")
                {
                    BackColor = Color.Red;
                }
                else if (backgroundColourSelected == "Orange")
                {
                    BackColor = Color.Orange;
                }
                else if (backgroundColourSelected == "Yellow")
                {
                    BackColor = Color.Yellow;
                }
                else if (backgroundColourSelected == "Green")
                {
                    BackColor = Color.Green;
                }
                else if (backgroundColourSelected == "Blue")
                {
                    BackColor = Color.Blue;
                }
                else if (backgroundColourSelected == "Purple")
                {
                    BackColor = Color.Purple;
                }
            } //Colour selecter

            foregroundColourSelected = "Green";
            fontType = "Times New Roman";




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

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage HomePage = new HomePage(userName);
            this.Hide();
            HomePage.Show();
        }
    }
}
