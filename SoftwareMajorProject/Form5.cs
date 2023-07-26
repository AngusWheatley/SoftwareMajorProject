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
        public static string diaryDate;
        public static string userName = HomePage.userName;
        public DiaryEditorPage()
        {
            InitializeComponent();
        }

        private void DiaryEditorPage_Load(object sender, EventArgs e)
        {
            txtUserName.Text = userName;
            


        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            HomePage HomePage = new HomePage();
            this.Hide();
            HomePage.Show();


        }

        private void BtnSaveDiaryEntry_Click(object sender, EventArgs e)
        {
            string diaryTitle = TxtDiaryTitle.Text;
            string diaryEntry = TxtDiaryEntry.Text;
            

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
