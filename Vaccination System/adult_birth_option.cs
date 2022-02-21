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
    public partial class adult_birth_option : Form
    {
        public adult_birth_option()
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

        private void registration_Click(object sender, EventArgs e)
        {
            adult_birth adult = new adult_birth();
            this.Close();
            adult.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            adult_birthupdate adult = new adult_birthupdate();
            this.Close();
            adult.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            adult_option adult = new adult_option();
            this.Close();
            adult.Show();
        }
    }
}
