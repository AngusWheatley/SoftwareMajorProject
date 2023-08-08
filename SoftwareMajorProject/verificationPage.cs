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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SoftwareMajorProject
{
    public partial class VerificationCodeForm : Form
    {
        int givenVerificationCode;
        string givenUserName;
        string givenUserEmail;
        bool givenUserExists;
        string givenTrimmedUserName;
        string givenTrimmedUserPassword;
        string givenTrimmedUserEmail;

        bool verificationCodeCorrect = false;

        public VerificationCodeForm(int verificationCode, string userName, string userEmail, bool userExists, string trimmedUserName, string trimmedUserPassword, string trimmedUserEmail)
        {
            givenVerificationCode = verificationCode;
            givenUserName = userName;
            givenUserEmail = userEmail;
            givenUserExists = userExists;
            givenTrimmedUserName = trimmedUserName;
            givenTrimmedUserPassword = trimmedUserPassword;
            givenTrimmedUserEmail = trimmedUserEmail;

            InitializeComponent();
        }

        private void BtnSubmitCode_Click(object sender, EventArgs e)
        {
            string codeEntered = txtCodeEntered.Text;
            int trimmedCodeEntered = Convert.ToInt32(String.Concat(codeEntered.Where(c => !Char.IsWhiteSpace(c))));


            //Checks Input box for verification code entered
            if (trimmedCodeEntered == givenVerificationCode)
            {
                verificationCodeCorrect = true;
            }
            else
            {
                verificationCodeCorrect = false;
                MessageBox.Show("Code entered is not correct.");
            }
            //---------------------------------------------


            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";

            if (givenTrimmedUserName != null && givenTrimmedUserPassword != null && givenTrimmedUserEmail != null && givenUserExists == false && verificationCodeCorrect == true)
            {
                //Places user in user database
                SQLiteCommand sqlCommandNewUser = new SQLiteCommand();
                sqlCommandNewUser.Connection = sqlConnection;
                sqlCommandNewUser.CommandType = CommandType.Text;
                sqlCommandNewUser.CommandText = "INSERT into UserInfo (userEmail, userName, userPassword) values (@userEmail, @userName, @userPassword)";

                sqlCommandNewUser.Parameters.AddWithValue("@userName", givenTrimmedUserName);
                sqlCommandNewUser.Parameters.AddWithValue("@userPassword", givenTrimmedUserPassword);
                sqlCommandNewUser.Parameters.AddWithValue("@userEmail", givenTrimmedUserEmail);

                sqlConnection.Open();
                sqlCommandNewUser.ExecuteNonQuery();
                sqlConnection.Close();
                //---------------------------------------------



                //Places user into settings database
                SQLiteCommand sqlCommandNewUserSettings = new SQLiteCommand();
                sqlCommandNewUserSettings.Connection = sqlConnection;
                sqlCommandNewUserSettings.CommandType = CommandType.Text;
                sqlCommandNewUserSettings.CommandText = "INSERT into NoterSettings (userName, backgroundColour, foregroundColour, fontType) values (@userName, @backgroundColour, @foregroundColour, @fontType)";

                sqlCommandNewUserSettings.Parameters.AddWithValue("@userName", givenTrimmedUserName);
                sqlCommandNewUserSettings.Parameters.AddWithValue("@backgroundColour", "DodgerBlue");
                sqlCommandNewUserSettings.Parameters.AddWithValue("@foregroundColour", "LightSteelBlue");
                sqlCommandNewUserSettings.Parameters.AddWithValue("@fontType", "Microsoft Sans Serif");

                sqlConnection.Open();
                sqlCommandNewUserSettings.ExecuteNonQuery();
                sqlConnection.Close();
                //---------------------------------------------


                //Checks if database for user already exists
                sqlConnection.Open();
                var commandCheckForTable = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type='table' AND name='" + givenTrimmedUserName + "_Diary';", sqlConnection);
                var reader = commandCheckForTable.ExecuteReader();

                bool tableExists = reader.HasRows;

                reader.Close();
                sqlConnection.Close();
                //---------------------------------------------


                if (tableExists == false)
                {
                    //Creates diary table for user
                    sqlConnection.Open();

                    string sqlCreateDiary = "CREATE TABLE " + givenTrimmedUserName + "_Diary (date TEXT, title TEXT, contents TEXT)";
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

                    NewAccountPage newAccountPage = new NewAccountPage();
                    this.Hide();
                    newAccountPage.Show();
                }

            }
            else if (givenUserExists == true)
            {
                MessageBox.Show("User already exists");

                NewAccountPage newAccountPage = new NewAccountPage();
                this.Hide();
                newAccountPage.Show();
            }
            else
            {
                MessageBox.Show("Please enter valid cridentials");

                NewAccountPage newAccountPage = new NewAccountPage();
                this.Hide();
                newAccountPage.Show();
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
                txtCodeEntered.Text = txtCodeEntered.Text.Replace(System.Environment.NewLine, "");
            }
        }
    }
}
