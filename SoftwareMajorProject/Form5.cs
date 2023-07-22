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
        public DiaryEditorPage()
        {
            InitializeComponent();
        }

        private void DiaryEditorPage_Load(object sender, EventArgs e)
        {
            txtUserName.Text = LoginPage.userName;
            


        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            HomePage HomePage = new HomePage();
            this.Hide();
            HomePage.Show();


        }

        private void BtnSaveDiaryEntry_Click(object sender, EventArgs e)
        {

            /*
            string userName = LoginPage.trimmedUserName;
            string diaryTitle = TxtDiaryTitle.Text;
            string diaryEntry = TxtDiaryEntry.Text;


            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";


            SQLiteCommand sqlCommandNewUser = new SQLiteCommand();
            sqlCommandNewUser.Connection = sqlConnection;
            sqlCommandNewUser.CommandType = CommandType.Text;
            sqlCommandNewUser.CommandText = "INSERT into " + userName + "_Diary (date, title, contents) values (@date, @title, @contents)";

            sqlCommandNewUser.Parameters.AddWithValue("@date", );
            sqlCommandNewUser.Parameters.AddWithValue("@title", diaryTitle);
            sqlCommandNewUser.Parameters.AddWithValue("@contents", diaryEntry);

            sqlConnection.Open();
            sqlCommandNewUser.ExecuteNonQuery();
            sqlConnection.Close();
            */


        }

    }
}
