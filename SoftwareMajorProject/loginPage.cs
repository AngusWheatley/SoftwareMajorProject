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

        string userName;
        public static string userPassword;
        public static string trimmedUserName;
        public static string userEmail;

        public LoginPage()
        {
            InitializeComponent();

            userName = "";
                
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            userName = "";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            userName = txtUserName.Text;
            userPassword = txtUserPassword.Text;

            trimmedUserName = String.Concat(txtUserName.Text.Where(c => !Char.IsWhiteSpace(c)));
            string trimmedUserPassword = String.Concat(userPassword.Where(c => !Char.IsWhiteSpace(c)));


            //MessageBox.Show(trimmedUserName);****************************


            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";

            if (txtUserName.Text != "" && txtUserPassword.Text != "" && txtUserName.Text != "" && txtUserPassword.Text != "")
            {
                SQLiteCommand cmd = new SQLiteCommand("Select * From userInfo where userName = @userName and userPassword = @userPassword or userEmail = @userEmail and userPassword = @userPassword;");

                cmd.Parameters.AddWithValue("@userEmail", trimmedUserName);
                cmd.Parameters.AddWithValue("@userName", trimmedUserName);
                cmd.Parameters.AddWithValue("@userPassword", trimmedUserPassword);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();

                DataTable userInfoDataTable = new DataTable();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);


                dataAdapter.Fill(userInfoDataTable);
                sqlConnection.Close();




                bool loginSuccessful = (userInfoDataTable.Rows.Count > 0);

                if (loginSuccessful)
                {
                    MessageBox.Show("Successfuly Logged In");

                    userName = txtUserName.Text;
                    userPassword = txtUserPassword.Text;

                    HomePage HomePage = new HomePage(userName);
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
