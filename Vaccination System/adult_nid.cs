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
namespace Vaccination_System
{
    public partial class adult_nid : Form
    {
        public adult_nid()
        {
            InitializeComponent();
            fillcombo();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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

        private void goback_Click(object sender, EventArgs e)
        {
            Registration2 reg = new Registration2();
            this.Close();
            reg.Show();
        }
        private void fillcombo()
        {
            string con = "datasource =127.0.0.1; username =root;password=; database= vaccination_system";
            MySqlConnection connect = new MySqlConnection(con);
            string query = "select DISTINCT center_name from center natural join vaccine_stock where vaccine_quantity>0";
            MySqlCommand command = new MySqlCommand(query, connect);
            try
            {
                connect.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    center.Items.Add(reader["center_name"].ToString());
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void intcheck(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = false;
            }
        }
        private void register_Click(object sender, EventArgs e)
        {
            
            if (name.Text == String.Empty)
            {
                MessageBox.Show("Please fill up Name field ", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (phone.Text == String.Empty)
            {
                MessageBox.Show("Please fill up Phone number field ", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radiobuttonmale.Checked == false && radiobuttonfemale.Checked == false)
            {
                MessageBox.Show("Please Choose a gender ", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (center.Text == String.Empty)
            {
                MessageBox.Show("Please Choose a center ", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string gender;
                int indicator = 2;
                if (radiobuttonmale.Checked)
                {
                    gender = radiobuttonmale.Text;
                }
                else
                {
                    gender = radiobuttonfemale.Text;
                }

                string con = "datasource =127.0.0.1; username =root;password=; database= vaccination_system";
                MySqlConnection connect = new MySqlConnection(con);
                string cmd = "insert into registration(name,nid,phone,gender,indicator,center_name) values('" + name.Text + "','"+nid.Text+"','"+phone.Text+"''" + gender + "','" + indicator + "','" + center.Text + "');";
                MySqlCommand command = new MySqlCommand(cmd, connect);


                try
                {

                    if (MessageBox.Show("Please make sure you have entered information correctly & Press Yes to continue registration process", "Registration Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        connect.Open();
                        progressbar.Visible = true;
                        command.ExecuteNonQuery();
                        connect.Close();
                        connect.Open();
                        timer.Start();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void clear()
        {
            name.Text=String.Empty;
            phone.Text=String.Empty;
            nid.Text=String.Empty;
            center.Text=String.Empty;
            radiobuttonfemale.Checked=false;
            radiobuttonmale.Checked=false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressbar.Increment(1);
            if (progressbar.Value == 100)
            {
                timer.Stop();
                int indicator = 2;
                MessageBox.Show("Registration Done Please Collect your registration number", "Registration Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string con = "datasource =127.0.0.1; username =root;password=; database= vaccination_system";
                MySqlConnection connect = new MySqlConnection(con);
                string reg = "Select *from registration where nid = '" + nid.Text + "'and indicator ='" + indicator + "'";
                MySqlCommand command2 = new MySqlCommand(reg, connect);
                try
                {
                    connect.Open();
                    child_final final = new child_final();
                    MySqlDataReader reader = command2.ExecuteReader();
                    while (reader.Read())
                    {
                       
                        final.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                progressbar.Value = 0;
                progressbar.Visible = false;
                clear();
            }
        }
    }
}
