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
    public partial class ReminderEditorPage : Form
    {
        public ReminderEditorPage()
        {
            InitializeComponent();
        }

        private void ReminderEditorPage_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage HomePage = new HomePage();
            this.Hide();
            HomePage.Show();
        }
    }
}
