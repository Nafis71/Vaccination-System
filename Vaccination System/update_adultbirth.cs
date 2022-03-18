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
    public partial class update_adultbirth : Form
    {
        public update_adultbirth()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (newnid.Text == String.Empty)
            {

                MessageBox.Show("Please Enter Birth Certificate Number", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                int indicator = 2;
                String connection = "datasource =127.0.0.1; username =root; password=; database=vaccination_system";
                MySqlConnection connect = new MySqlConnection(connection);
                String query = "update registration set nid = '" + newnid.Text + "' Where reg_no ='" + regno.Text + "' And indicator = '" + indicator + "'";
                MySqlCommand command = new MySqlCommand(query, connect);
                String query2 = "select nid from registration where nid ='" + newnid.Text + "'";
                MySqlCommand command2 = new MySqlCommand(query2, connect);
                try
                {
                    connect.Open();
                    MySqlDataReader duplicate_row = command2.ExecuteReader();
                    if (duplicate_row.HasRows)
                    {
                        MessageBox.Show("Duplicate National ID Number", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        newnid.Text = String.Empty;
                    }
                    else
                    {
                        connect.Close();
                        connect.Open();
                        command.ExecuteNonQuery();
                        newnid.Text = String.Empty;
                        MessageBox.Show("NID Updated Successfully", "Updation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        String query3 = "select nid from registration where reg_no ='" + regno.Text + "'And indicator ='" + indicator + "'";
                        MySqlCommand commmand4 = new MySqlCommand(query3, connect);
                        MySqlDataReader reader3 = commmand4.ExecuteReader();
                        reader3.Read();
                        nid.Text = reader3["nid"].ToString();
                        reader3.Close();
                        connect.Close();
                        newnid.ReadOnly = true;
                        update.Enabled = false;
                        success.Visible = true;
                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
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
            Registration2 reg = new Registration2();
            this.Close();
            reg.Show();
        }
    }
}
