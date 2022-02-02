using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaccination_System
{
    public partial class teenager_option : Form
    {
        public teenager_option()
        {
            InitializeComponent();
        }

        private void registration_Click(object sender, EventArgs e)
        {
            teenager teen = new teenager();
            this.Close();
            teen.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Registration2 reg = new Registration2();
            this.Close();
            reg.Show();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState  = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
