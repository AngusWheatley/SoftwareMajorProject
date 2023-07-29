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
using System.Xml.Linq;

namespace SoftwareMajorProject
{
    public partial class DiaryEditorPage : Form
    {
        string diaryDate;
        string userName;
        public DiaryEditorPage(string userNameLoggedIn)
        {
            userName = userNameLoggedIn;
            InitializeComponent();
        }

        private void DiaryEditorPage_Load(object sender, EventArgs e)
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
                    //Back colour
                    BackColor = Color.FromName(row[1].ToString());

                    //Front colour
                    picBackPlate.BackColor = Color.FromName(row[2].ToString());
                    lblEntryTitle.BackColor = Color.FromName(row[2].ToString());
                    lblEntryContents.BackColor = Color.FromName(row[2].ToString());
                    lblEntryDate.BackColor = Color.FromName(row[2].ToString());


                    //Font type
                    var fontConverter = new FontConverter();
                    var sizeConverter = new SizeConverter();
                    //lblBackgroundColour.Font = new Font(fontConverter.ConvertFromString(row[3].ToString()) as Font, (FontStyle)sizeConverter.ConvertFromString("12"));
                    lblEntryTitle.Font = new Font(fontConverter.ConvertFromString(row[3].ToString()) as Font, FontStyle.Underline);
                    TxtEntryTitle.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                    lblEntryContents.Font = new Font(fontConverter.ConvertFromString(row[3].ToString()) as Font, FontStyle.Underline);
                    TxtEntryContents.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                    lblEntryDate.Font = new Font(fontConverter.ConvertFromString(row[3].ToString()) as Font, FontStyle.Underline);
                    txtUserName.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                    CalEntryDate.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                    BtnSaveEntry.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                    BtnDeleteEntry.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                    btnHome.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;

                }
            }




        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            HomePage HomePage = new HomePage(userName);
            this.Hide();
            HomePage.Show();


        }

        private void BtnSaveEntry_Click(object sender, EventArgs e)
        {
            string diaryTitle = TxtEntryTitle.Text;
            string diaryEntry = TxtEntryContents.Text;
            

            if (diaryDate != null && diaryTitle != "" && diaryEntry != "")
            {
                string userNameDiary = userName + "_Diary";


                SQLiteConnection sqlConnection = new SQLiteConnection();
                sqlConnection.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";


                SQLiteCommand sqlCommandNewUser = new SQLiteCommand();
                sqlCommandNewUser.Connection = sqlConnection;
                sqlCommandNewUser.CommandType = CommandType.Text;
                sqlCommandNewUser.CommandText = "INSERT into " + userNameDiary + " (date, title, contents) values (@date, @title, @contents)";

                sqlCommandNewUser.Parameters.AddWithValue("@date", diaryDate);
                sqlCommandNewUser.Parameters.AddWithValue("@title", diaryTitle);
                sqlCommandNewUser.Parameters.AddWithValue("@contents", diaryEntry);

                sqlConnection.Open();
                sqlCommandNewUser.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Your diary entry has been saved.");
            }
            else
            {
                MessageBox.Show("Please make sure you have entered all information for this diary entry.");
            }

        }


        private void CalDiaryEntryDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            diaryDate = e.Start.ToShortDateString();
            MessageBox.Show(diaryDate);
        }
    }
}
