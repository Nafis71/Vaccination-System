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
    public partial class vac_center_admin : Form
    {
        int length = 0;
        string text;
        public vac_center_admin()
        {
            InitializeComponent();
            text =label3.Text;
            label3.Text = "";
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                if (length < text.Length)
                {
                    label3.Text = label3.Text + text.ElementAt(length);
                    length++;
                }
                else
                {

                    timer1.Stop();
                }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
