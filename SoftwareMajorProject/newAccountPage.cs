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
using System.Web;
using System.Net;
using System.Net.Mail;

namespace SoftwareMajorProject
{
    public partial class NewAccountPage : Form
    {
        int verificationCode;
        
        string userName;
        string userPassword;
        string userEmail;
        bool userExists;
        string trimmedUserName;
        string trimmedUserPassword;
        string trimmedUserEmail;

        public NewAccountPage()
        {
            InitializeComponent();
        }

        private void NewAccountPage_Load(object sender, EventArgs e)
        {

        }

        private void LinkLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage LoginPage = new LoginPage();
            this.Hide();
            LoginPage.Show();


        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            userName = txtUserName.Text;
            userPassword = txtUserPassword.Text;
            userEmail = txtUserEmail.Text;



            bool isLetter = !string.IsNullOrEmpty(userName) && Char.IsLetter(userName[0]);


            if (userName != "" && userPassword != "" && userEmail != "" && isLetter == true) 
            {
                MessageBox.Show("True that");

                

                trimmedUserName = String.Concat(userName.Where(c => !Char.IsWhiteSpace(c)));
                trimmedUserPassword = String.Concat(userPassword.Where(c => !Char.IsWhiteSpace(c)));
                trimmedUserEmail = String.Concat(userEmail.Where(c => !Char.IsWhiteSpace(c)));


                SQLiteConnection sqlConnection = new SQLiteConnection();
                sqlConnection.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";


                //Check if user exists
                SQLiteCommand cmd = new SQLiteCommand("Select * From userInfo where userName = @userName and userPassword = @userPassword or userEmail = @userEmail and userPassword = @userPassword;");

                cmd.Parameters.AddWithValue("@userName", trimmedUserName);
                cmd.Parameters.AddWithValue("@userPassword", trimmedUserPassword);
                cmd.Parameters.AddWithValue("@userEmail", trimmedUserEmail);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();

                DataSet userInfoDataSet = new DataSet();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);

                dataAdapter.Fill(userInfoDataSet);
                sqlConnection.Close();

                userExists = ((userInfoDataSet.Tables.Count > 0) && (userInfoDataSet.Tables[0].Rows.Count > 0));
                //---------------------------------------------
                MessageBox.Show("User exists= " + Convert.ToString(userExists));



                if (userExists == false)
                {
                    //Creats and sends verification code to user
                    Random randomCode = new Random();
                    verificationCode = randomCode.Next(100000, 1000000);

                    MailMessage mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress("noterservices@gmail.com");
                    mailMessage.To.Add(trimmedUserEmail);
                    mailMessage.Subject = "New account creation";
                    mailMessage.Body = "Your account verification code is " + verificationCode + ". If you did not request for this code, please ignore this message.";

                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                    smtpClient.Credentials = new NetworkCredential("noterservices@gmail.com", "wxtleisaobiiluuu");
                    smtpClient.EnableSsl = true;

                    try
                    {
                        smtpClient.Send(mailMessage);
                        MessageBox.Show("email sent");

                        VerificationCodeForm verificationCodeForm = new VerificationCodeForm(verificationCode, userName, userEmail, userExists, trimmedUserName, trimmedUserPassword, trimmedUserEmail);
                        this.Hide();
                        verificationCodeForm.Show();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to send. Error: " + ex.Message);
                    }
                    //---------------------------------------------


                    
                }
                else
                {
                    MessageBox.Show("User already exists. Try another name.");
                }
            }
            else if (isLetter == false)
            {
                MessageBox.Show("Username is invalid and must start with a letter.");
            }
            else
            {
                MessageBox.Show("Nothing entered");
            }







            /*
            bool emailValid = IsUserEmailValid(userEmail);

            if (emailValid = true)
            {
                MessageBox.Show("Real email");
            }
            else
            {
                MessageBox.Show("Not real email");
            }*/

            /*
            MailAddress from = new MailAddress("anguswheatley44@gmail.com", "Angus Wheatley");
            MailAddress to = new MailAddress("anguswheatley43@gmail.com", "Angus W");
            List<MailAddress> cc = new List<MailAddress>();
            cc.Add(new MailAddress("angus.wheatley2@gmail.com", "A W"));

            string message = "Test message";

            SendEmail(message, from, to, cc);
            */

            /*
            var mailMessage = new MailMessage
            {
                From = new MailAddress("anguswheatley44@gmail.com");
                Subject = "hello";
                Body = "hello";
                IsBodyHtml = true;
            };
            */
        }

        private static bool IsUserEmailValid(string userEmail)
        {
            var trimmedEmail = userEmail.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var address = new MailAddress(userEmail);
                return address.Address == trimmedEmail;

            }
            catch
            {
                return false;
            }

        }


        private void BtnTestEmail_Click(object sender, EventArgs e)
        {
            try
            {
                /*string fromEmail = "anguswheatley44@gmail.com";
                string toEmail = "anguswheatley43@gmail.com";
                string emailBody = "Test message";



                MailMessage mailMessage = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                mailMessage.From = new MailAddress(fromEmail);
                mailMessage.To.Add(new MailAddress(toEmail));
                mailMessage.Subject = "Test";

                mailMessage.IsBodyHtml = true;
                mailMessage.Body = emailBody;

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(fromEmail, toEmail);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(mailMessage);

                MessageBox.Show("Sent Mail!");


                */



                /*

                smtp.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();

                ntcd.UserName = "(email)";
                ntcd.Password = "(password)";

                smtp.Credentials = ntcd;
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.Send(mailMessage);
                MessageBox.Show("Your Mail Has Sent");

                */


                /*
                MailMessage mailMessage = new MailMessage("anguswheatley44@gmail.com", "anguswheatley43@gmail.com", "Test", "Test message");

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.Cridentials = new System.Net.NetworkCredential();
                */

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");

                smtpClient.Port = 587;
                smtpClient.UseDefaultCredentials = true;
                smtpClient.EnableSsl = true;

                MailMessage mailMessage = new MailMessage();

                mailMessage.From = new MailAddress("anguswheatley44@gmail.com");
                mailMessage.To.Add("anguswheatley43@gmail.com");
                mailMessage.Subject = "Testing";
                mailMessage.Body = "Yes";

                smtpClient.Send(mailMessage);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSignUp_Click(sender, e);
                txtUserName.Text = txtUserName.Text.Replace(System.Environment.NewLine, "");
            }
        }

        private void txtUserPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSignUp_Click(sender, e);
                txtUserPassword.Text = txtUserPassword.Text.Replace(System.Environment.NewLine, "");
            }
        }

        private void txtUserEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSignUp_Click(sender, e);
                txtUserEmail.Text = txtUserEmail.Text.Replace(System.Environment.NewLine, "");
            }
        }

    }

}
