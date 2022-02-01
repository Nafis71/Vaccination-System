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
    public partial class child_option : Form
    {
        public child_option()
        {
            InitializeComponent();
        }

        private void registration_Click(object sender, EventArgs e)
        {
            child child = new child();
            this.Hide();
            child.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            update_childbirth update = new update_childbirth();
            this.Hide();
            update.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Registration2 reg = new Registration2();
            reg.Show();
           
        }
    }
}
