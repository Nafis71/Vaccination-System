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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
            dashboard();
        }

        private void childvac1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dashboard()
        {
            if (!panel4.Controls.Contains(admin_dashboard.Instance))
            {
                panel4.Controls.Add(admin_dashboard.Instance);
                admin_dashboard.Instance.Dock = DockStyle.Fill;
                admin_dashboard.Instance.BringToFront();
                admin_dashboard.Instance.t1();
                admin_dashboard.Instance.t2();
                admin_dashboard.Instance.t3();
                admin_dashboard.Instance.vaccineinfo();
                admin_dashboard.Instance.registrationinfo();
                admin_dashboard.Instance.centerinfo();
                title.Text = "Dashboard";

            }
            else
            {
                admin_dashboard.Instance.BringToFront();
                admin_dashboard.Instance.t1();
                admin_dashboard.Instance.t2();
                admin_dashboard.Instance.vaccineinfo();
                admin_dashboard.Instance.registrationinfo();
                admin_dashboard.Instance.centerinfo();
                title.Text = "Dashboard";
            }
        }

        private void dash_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(admin_dashboard.Instance))
            {
                panel4.Controls.Add(admin_dashboard.Instance);
                admin_dashboard.Instance.Dock = DockStyle.Fill;
                admin_dashboard.Instance.BringToFront();
                admin_dashboard.Instance.t1();
                admin_dashboard.Instance.t2();
                admin_dashboard.Instance.t3();
                admin_dashboard.Instance.vaccineinfo();
                admin_dashboard.Instance.registrationinfo();
                admin_dashboard.Instance.centerinfo();


                title.Text = "Dashboard";

            }
            else
            {
                admin_dashboard.Instance.BringToFront();
                admin_dashboard.Instance.t1();
                admin_dashboard.Instance.t2();
                admin_dashboard.Instance.vaccineinfo();
                admin_dashboard.Instance.registrationinfo();
                admin_dashboard.Instance.centerinfo();
                title.Text = "Dashboard";
            }
        }

        private void centermanage_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(center.Instance))
            {
                panel4.Controls.Add(center.Instance);
                center.Instance.Dock = DockStyle.Fill;
                center.Instance.BringToFront();
                center.Instance.clear();
                title.Text = "Center Management";
            }
            else
            {
                center.Instance.BringToFront();
                title.Text = "Center Management";
            }
        }

        private void signout_Click(object sender, EventArgs e)
        {
            admin_login admin = new admin_login();
            this.Hide();
            admin.Show();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vacmanage_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(vac_manage.Instance))
            {
                panel4.Controls.Add(vac_manage.Instance);
                vac_manage.Instance.Dock = DockStyle.Fill;
                vac_manage.Instance.BringToFront();
                vac_manage.Instance.clear();
                title.Text = "Vaccine Management";
            }
            else
            {
                vac_manage.Instance.BringToFront();
                title.Text = "Vaccine Management";
            }
        }
    }
}
