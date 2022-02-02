using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp; //custom button plugin
using System.Runtime.InteropServices; //for system runtime dll use

namespace Vaccination_System
{
    public partial class Registration2 : Form
    {
        public Registration2()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void back_Click(object sender, EventArgs e)
        {
            home login = new home();
            this.Hide();
            login.Show();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //using System.Runtime.InteropServices;
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Registration2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void registration_Click(object sender, EventArgs e)
        {
            child_option child = new child_option();
            child.Show();
            this.Hide();
        }

        private void Teenager_Click(object sender, EventArgs e)
        {
            teenager_option teen =new teenager_option();
                   teen.Show();
                      this.Hide();
                }
    }
}
