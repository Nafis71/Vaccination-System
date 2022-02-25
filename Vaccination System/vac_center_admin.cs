using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace Vaccination_System
{
    public partial class vac_center_admin : Form
    {

        
       
        public vac_center_admin()
        {
            InitializeComponent();
            label4.Visible = false;
            timer1.Start();
           
           
        }


        private void dashboard()
        {
            if (!panel4.Controls.Contains(vac_admin_dashboard.Instance))
            {
                panel4.Controls.Add(vac_admin_dashboard.Instance);
                vac_admin_dashboard.Instance.Dock = DockStyle.Fill;
                vac_admin_dashboard.Instance.BringToFront();
                vac_admin_dashboard.Instance.id.Text = hid.Text;

            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //using System.Runtime.InteropServices;
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
           
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label4.Visible = true;
            progressBar1.Increment(1);
            label4.Text = progressBar1.Value.ToString()+"%";
            if (progressBar1.Value == 100)
                {
                timer1.Stop();
                label4.Visible=false;
                progressBar1.Visible=false;
                label1.Visible=false;
                dashboard();
                }
            
           
        }
       
        private void dash_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(vac_admin_dashboard.Instance))
            {
                panel4.Controls.Add(vac_admin_dashboard.Instance);
                vac_admin_dashboard.Instance.Dock = DockStyle.Fill;
                vac_admin_dashboard.Instance.BringToFront();
                vac_admin_dashboard.Instance.id.Text = hid.Text;
                title.Text = "Dashboard";

            }
            else
            {
                vac_admin_dashboard.Instance.BringToFront();
                vac_admin_dashboard.Instance.vaccineinfo();
                vac_admin_dashboard.Instance.registrationinfo();
                title.Text = "Dashboard";
            }
        }

        private void childvac_Click(object sender, EventArgs e)
        {

        }

        private void childvac1_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(childvac.Instance))
            {
                panel4.Controls.Add(childvac.Instance);
                childvac.Instance.Dock = DockStyle.Fill;
                childvac.Instance.BringToFront();
                childvac.Instance.id.Text = hid.Text;
                title.Text = "Child Vaccination";

            }
            else
            {
                childvac.Instance.BringToFront();
                title.Text = "Child Vaccination";
            }
        }
    }
}
