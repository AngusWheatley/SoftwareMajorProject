using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Hosting;

namespace SoftwareMajorProject
{
    public partial class NoterSettings : Form
    {
        public static string userName;
        public static string backgroundColourSelected;
        public static string foregroundColourSelected;
        public static string fontType;

        public NoterSettings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

            userName = HomePage.userName;
            txtUserName.Text = userName;


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

            foregroundColourSelected = "Red";
            fontType = "Times New Roman";




            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";

            SQLiteCommand cmd = new SQLiteCommand("UPDATE NoterSettings SET userName=@userName, backgroundColour=@backgroundColour, foregroundColour=@foregroundColour, fontType=@fontType");

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
            HomePage HomePage = new HomePage();
            this.Hide();
            HomePage.Show();
        }
    }
}
