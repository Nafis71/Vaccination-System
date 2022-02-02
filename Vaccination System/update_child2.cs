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
    public partial class update_child2 : Form
    {
        public update_child2()
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

        private void back_Click(object sender, EventArgs e)
        {
            child_option option = new child_option();
            this.Close();
            option.Show();
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (newbnum.Text == String.Empty)
            {

                MessageBox.Show("Please Enter Birth Certificate Number", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                
                int indicator = 0;
            String connection = "datasource =127.0.0.1; username =root; password=; database=vaccination_system";
            MySqlConnection connect = new MySqlConnection(connection);
            String query = "update registration set birth_certificate_num = '"+newbnum.Text+"' Where reg_no ='"+regno.Text+"' And indicator = '"+indicator+"'";
            MySqlCommand command = new MySqlCommand(query, connect);
            String query2 = "select birth_certificate_num from registration where birth_certificate_num ='" + newbnum.Text + "'";
            MySqlCommand command2 = new MySqlCommand(query2, connect);
                try
                {
                    connect.Open();
                    MySqlDataReader reader = command2.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Duplicate Birth Certificate Number", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        newbnum.Text = String.Empty;
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                        newbnum.Text = String.Empty;
                        MessageBox.Show("Birth Certificate Number Updated Successfully", "Updation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connect.Close();
                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }
    }
}
