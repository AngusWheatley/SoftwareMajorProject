using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace SoftwareMajorProject
{
    public partial class LoginPage : Form
    {

        public static string userName;
        public static string userPassword;
        public static string trimmedUserName;
        public static string userEmail;

        public LoginPage()
        {
            InitializeComponent();

            {
                /*
                SQLiteConnection sqlConnection = new SQLiteConnection();
                sqlConnection.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";

                string commandTextUserInfo = "Select * From UserInfo";

                List<string> userFirstNameList = new List<string>();


                SQLiteDataAdapter myDataAdapterUserName = new SQLiteDataAdapter(commandTextUserInfo, sqlConnection);

                sqlConnection.Open();
                myDataAdapterUserName.Fill(userFirstNameList);
                */


                /*
                userInfo.Parameters.AddWithValue("@firstName", userFirstNameList);
                userInfo.Parameters.AddWithValue("@lastName", userLastNameList);



                string message = string.Join(",", userFirstNameList);
                MessageBox.Show(message);

                */
            }




        }

        private void LoginPage_Load(object sender, EventArgs e)
        {


        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            {
                /*
                SQLiteConnection sqlConnection = new SQLiteConnection();
                sqlConnection.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";

                SQLiteCommand userInfo = new SQLiteCommand("Select * from UserInfo where firstName=@firstName and password=@password", sqlConnection);

                userInfo.Parameters.AddWithValue("@firstName", txtUsername.Text);
                userInfo.Parameters.AddWithValue("@lastName", txtUsername.Text);

                sqlConnection.Open();

                SQLiteDataReader readData = userInfo.ExecuteReader();

                if (readData.Read())
                {
                    MessageBox.Show("Logged in");
                }
                else
                {
                    MessageBox.Show("Not avaliable");
                }
                */


                /*
                SQLiteConnection sqlConnection = new SQLiteConnection();
                sqlConnection.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";


                string username = "Select * FROM UserInfo WHERE firstName" + txtUsername.Text + "'";

                */


                /*
                List<string> items = new List<string>();

                SQLiteConnection sqlConnection = new SQLiteConnection(); 

                sqlConnection.Open();

                SQLiteCommand command = sqlConnection.CreateCommand();

                command.CommandText = "Select * from UserInfo where firstName=@firstName and password=@password\", sqlConnection";

                SQLiteDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    int userID = reader.GetInt32(0);
                    string userEmail = reader.GetString(1);
                    items newItem = new 
                }
                */


                /*
                SQLiteConnection sqlConnection = new SQLiteConnection();
                sqlConnection.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";


                List<string> userInfo = new List<string>();
                */
            }


            userName = txtUserName.Text;
            userPassword = txtUserPassword.Text;

            string trimmedUserName = String.Concat(userName.Where(c => !Char.IsWhiteSpace(c)));
            string trimmedUserPassword = String.Concat(userPassword.Where(c => !Char.IsWhiteSpace(c)));



            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";

            if (txtUserName.Text != null && txtUserPassword.Text != null && txtUserName.Text != "" && txtUserPassword.Text != "")
            {
                SQLiteCommand cmd = new SQLiteCommand("Select * From userInfo where userName = @userName and userPassword = @userPassword or userEmail = @userEmail and userPassword = @userPassword;");

                cmd.Parameters.AddWithValue("@userEmail", trimmedUserName);
                cmd.Parameters.AddWithValue("@userName", trimmedUserName);
                cmd.Parameters.AddWithValue("@userPassword", trimmedUserPassword);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();

                DataTable userInfoDataTable = new DataTable();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);



                /* Trying to get user email to take to other forms
                SQLiteCommand getEmailCommand = new SQLiteCommand("SELECT userEmail FROM userInfo where username = @userName or userEmail = @userEmail");
                userEmail = getEmailCommand.CommandText; 
                */

                dataAdapter.Fill(userInfoDataTable);
                sqlConnection.Close();




                bool loginSuccessful = (userInfoDataTable.Rows.Count > 0);

                if (loginSuccessful)
                {

                    /* Trying to get user email to take to other forms
                    DataRow[] userIndex = userInfoDataTable.Select("userName = " + userName + "AND userPassword = " + userPassword);
                    MessageBox.Show(Convert.ToString(userIndex));
                    foreach (DataRow row in userIndex)
                    {
                        MessageBox.Show(Convert.ToString(row["userEmail"]));
                    }

                    string userEmail = userInfoDataTable.Rows[].Field<string>("userEmail");
                    
                    */






                    MessageBox.Show("Successfuly Logged In");



                    userName = txtUserName.Text;
                    userPassword = txtUserPassword.Text;




                    HomePage HomePage = new HomePage();
                    this.Hide();
                    HomePage.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }

            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }

        }

        private void LinkNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewAccountPage NewAccountPage = new NewAccountPage();
            this.Hide();
            NewAccountPage.Show();
        }

        private void TxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(sender, e);
                txtUserName.Text = txtUserName.Text.Replace(System.Environment.NewLine, "");
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(sender, e);
                txtUserPassword.Text = txtUserPassword.Text.Replace(System.Environment.NewLine, "");
            }
        }

        
    }
}
