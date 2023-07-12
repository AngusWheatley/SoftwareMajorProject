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

namespace SoftwareMajorProject
{
    public partial class VerificationCodeForm : Form
    {


        public VerificationCodeForm()
        {
            InitializeComponent();
        }

        private void BtnSubmitCode_Click(object sender, EventArgs e)
        {
            string codeEntered = txtCodeEntered.Text;
            int trimmedCodeEntered = Convert.ToInt32(String.Concat(codeEntered.Where(c => !Char.IsWhiteSpace(c))));


            int verificationCode = NewAccountPage.verificationCode;
            string userName = NewAccountPage.userName;
            string userPassword = NewAccountPage.userPassword;
            string userEmail = NewAccountPage.userEmail;
            bool userExists = NewAccountPage.userExists;
            string trimmedUserName = NewAccountPage.trimmedUserName;
            string trimmedUserPassword = NewAccountPage.trimmedUserPassword;
            string trimmedUserEmail = NewAccountPage.trimmedUserEmail;
            bool verificationCodeCorrect = false;

            //Checks Input box for verification code entered
            if (trimmedCodeEntered == verificationCode)
            {
                verificationCodeCorrect = true;
            }
            else
            {
                MessageBox.Show("Code entered is not correct.");
            }
            //---------------------------------------------



            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";

            if (trimmedUserName != null && trimmedUserPassword != null && trimmedUserEmail != null && userExists == false && verificationCodeCorrect == true)
            {
                //Places user in user database
                SQLiteCommand sqlCommandNewUser = new SQLiteCommand();
                sqlCommandNewUser.Connection = sqlConnection;
                sqlCommandNewUser.CommandType = CommandType.Text;
                sqlCommandNewUser.CommandText = "INSERT into UserInfo (userEmail, userName, userPassword) values (@userEmail, @userName, @userPassword)";

                sqlCommandNewUser.Parameters.AddWithValue("@userName", trimmedUserName);
                sqlCommandNewUser.Parameters.AddWithValue("@userPassword", trimmedUserPassword);
                sqlCommandNewUser.Parameters.AddWithValue("@userEmail", trimmedUserEmail);

                sqlConnection.Open();
                sqlCommandNewUser.ExecuteNonQuery();
                sqlConnection.Close();
                //---------------------------------------------



                //Checks if database for user already exists
                sqlConnection.Open();
                var commandCheckForTable = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type='table' AND name='" + trimmedUserName + "Diary';", sqlConnection);
                var reader = commandCheckForTable.ExecuteReader();

                bool tableExists = reader.HasRows;

                reader.Close();
                sqlConnection.Close();
                //---------------------------------------------





                if (tableExists == false)
                {
                    //Creates diary table for user
                    sqlConnection.Open();

                    string sqlCreateDiary = "CREATE TABLE " + trimmedUserName + "_Diary (date TEXT, title TEXT, contents TEXT)";
                    SQLiteCommand command = new SQLiteCommand(sqlCreateDiary, sqlConnection);

                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                    //---------------------------------------------



                    MessageBox.Show("You're All Set. You Can Now Log In.");



                    //Opens login page and closes new account page
                    LoginPage LoginPage = new LoginPage();
                    this.Hide();
                    LoginPage.Show();
                    //---------------------------------------------
                }
                else
                {
                    MessageBox.Show("Name taken. Please choose another one.");
                }

            }
            else if (userExists == true)
            {
                MessageBox.Show("User already exists");
            }
            else
            {
                MessageBox.Show("Please enter valid cridentials");
            }




            this.Close();
        }

        private void BtnCancelVerification_Click(object sender, EventArgs e)
        {
            NewAccountPage newAccountPage = new NewAccountPage();
            this.Hide();
            newAccountPage.Show();
        }

        private void txtCodeEntered_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSubmitCode_Click(sender, e);
            }
        }
    }
}
