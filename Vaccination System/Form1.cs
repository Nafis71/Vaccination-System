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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loading_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loading.Width += 2;
            if(loading.Width>=599)
            {
                timer1.Stop();
                login login = new login();
                login.Show();
                this.Hide();


            }
        }
    }
}
