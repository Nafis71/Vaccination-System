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
    public partial class adult_option : Form
    {
        public adult_option()
        {
            InitializeComponent();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Registration2 reg = new Registration2();
            this.Close();
            reg.Show();
        }

        private void proceed_Click(object sender, EventArgs e)
        {
            if (radiobuttonnid.Checked)
            {
                adult_nid adult = new adult_nid();
                this.Close();
                adult.Show();
            }
            else
            {
                adult_birth_option adult = new adult_birth_option();
                this.Close();
                adult.Show();
            }
        }
    }
}
