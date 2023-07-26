using System;
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
    public partial class NoterSettings : Form
    {
        public static string backgroundColourSelected;

        public NoterSettings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void BtnSaveSettings_Click(object sender, EventArgs e)
        {
            backgroundColourSelected = CmbBackgroundColour.Text;


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






            /*Properties.Settings.Default["BackColor"] = BackColor;
            Properties.Settings.Default.BackgroundColour = BackColor;

            Properties.Settings.Default.Save();
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage LoginPage = new LoginPage();
            this.Hide();
            LoginPage.Show();
        }
    }
}
