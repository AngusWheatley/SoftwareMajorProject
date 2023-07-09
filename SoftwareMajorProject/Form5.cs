using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

    }
}
