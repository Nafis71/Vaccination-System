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
    public partial class update_teenager : Form
    {
        public update_teenager()
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

        private void newbnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

            if (newbnum.Text == String.Empty)
            {

                MessageBox.Show("Please Enter Birth Certificate Number", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                int indicator = 1;
                String connection = "datasource =127.0.0.1; username =root; password=; database=vaccination_system";
                MySqlConnection connect = new MySqlConnection(connection);
                String query = "update registration set birth_certificate_num = '" + newbnum.Text + "' Where reg_no ='" + regno.Text + "' And indicator = '" + indicator + "'";
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
                        connect.Close();
                        connect.Open();
                        command.ExecuteNonQuery();
                        newbnum.Text = String.Empty;
                        MessageBox.Show("Birth Certificate Number Updated Successfully", "Updation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        String query3 = "select birth_certificate_num from registration where reg_no ='" + regno.Text + "'And indicator ='" + indicator + "'";
                        MySqlCommand commmand4 = new MySqlCommand(query3, connect);
                        MySqlDataReader reader3 = commmand4.ExecuteReader();
                        while (reader3.Read())
                        {
                            bnum.Text = reader3["birth_certificate_num"].ToString();
                        }
                        connect.Close();
                        newbnum.ReadOnly = true;
                        update.Enabled = false;
                        success.Visible = true;
                        connect.Close();
                    }

                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            teenager_option teen = new teenager_option();
            this.Close();
            teen.Show();
        }
        
    }
}
