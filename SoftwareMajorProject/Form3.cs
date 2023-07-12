﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareMajorProject
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            this.Width = 1440;
            this.Height = 860; 


            txtName.Text = LoginPage.userName;
            txtPassword.Text = LoginPage.userPassword;








        }

        private void BtnReminder_Click(object sender, EventArgs e)
        {

            ReminderEditorPage reminderEditorPage = new ReminderEditorPage();
            this.Hide();
            reminderEditorPage.Show();
        }

        private void btnDiary_Click(object sender, EventArgs e)
        {

            DiaryEditorPage DiaryEditorPage = new DiaryEditorPage();
            this.Hide();
            DiaryEditorPage.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            string logOutMessage = "Are You Sure You Want To Log Out?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult logOut = MessageBox.Show(logOutMessage, "", buttons);

            if (logOut == DialogResult.Yes)
            {
                MessageBox.Show("Successfully Logged Out");

                LoginPage LoginPage = new LoginPage();
                this.Hide();
                LoginPage.Show();
            }
            else
            {
                MessageBox.Show("Successfully Remined Logged In");
            }

            
        }
    }
}