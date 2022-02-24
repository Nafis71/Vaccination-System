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
    public partial class vac_center_adminlogin : Form
    {
        public vac_center_adminlogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked)
            {
                pass.PasswordChar = '\0';
                
            }
            else
            {
                pass.PasswordChar = '*';
                pass.PasswordChar = '*';
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
               login login = new login();
               this.Close();
               login.Show();
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

        private void login_Click(object sender, EventArgs e)
        {
            if (id.Text == string.Empty)
            {
                MessageBox.Show("Please fill up center id field", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (pass.Text == string.Empty)
            {
                MessageBox.Show("Please fill up password field", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                String password = pass.Text;
                String encryptedpass = EasyEncryption.MD5.ComputeMD5Hash(password);
                string connection = "datasource =127.0.0.1; username =root;password=;database =vaccination_system";
                MySqlConnection connect = new MySqlConnection(connection);
                string query = "Select *from vac_adminlogin where center_id ='" + id.Text + "'AND password ='" + encryptedpass + "'";
                MySqlCommand command = new MySqlCommand(query, connect);
                try
                {
                    connect.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if(reader.HasRows)
                    {
                        
                        MessageBox.Show("Login Successfull","Logged IN",MessageBoxButtons.OK, MessageBoxIcon.Information);  
                        vac_center_admin admin = new vac_center_admin();
                        admin.hid.Text = id.Text;
                        this.Hide();
                        admin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login failed : Invalid Password Or Username", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
