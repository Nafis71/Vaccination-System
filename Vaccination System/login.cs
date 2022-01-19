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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //The extern modifier is used to declare a method that is implemented externally
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //using System.Runtime.InteropServices;
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //minimizebutton
           
            
                WindowState = FormWindowState.Minimized;

            
        }

        

        private void close_Click(object sender, EventArgs e)
        { //close button
            Application.Exit();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                animate.Width += 3;
                if (animate.Width >= 796)
                {
                    timer1.Stop();
                    
                }
            
        }

        private void animate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registration_Click(object sender, EventArgs e)
        {
            Registration2 reg2 = new Registration2();
            reg2.Show();
            this.Hide();
        }
    }
   
}
