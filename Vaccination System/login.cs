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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void vaccenteradmin_Click(object sender, EventArgs e)
        {
            vac_center_adminlogin vac_admin = new vac_center_adminlogin();
            this.Close();
            vac_admin.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            home home = new home(); 
            this.Close();
            home.Show();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            admin_login admin = new admin_login();
            this.Close();
            admin.Show();
        }

        private void mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconButtonclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
