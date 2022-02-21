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
    public partial class adult_birthupdate : Form
    {
        public adult_birthupdate()
        {
            InitializeComponent();
        }

        private void reg_Click(object sender, EventArgs e)
        {
            adult_birth adult = new adult_birth();
            this.Close();
            adult.Show();
        }

        private void proceed_Click(object sender, EventArgs e)
        {
            int indicator = 2;
            String connection = "datasource = 127.0.0.1; username =root; password =; database =vaccination_system";
            MySqlConnection connect = new MySqlConnection(connection);
            String query = "select *from registration where reg_no ='" + regno.Text + "' AND indicator = '" + indicator + "'";
            MySqlCommand Command = new MySqlCommand(query, connect);
            try
            {
                connect.Open();
                MySqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        int nid_check = int.Parse(reader["nid"].ToString());
                        if (nid_check == 0)
                        {
                            
                                update_adultbirth update = new update_adultbirth();
                                update.regno.Text = reader["reg_no"].ToString();
                                update.name.Text = reader["name"].ToString();
                                update.phoneno.Text = reader["phone_num"].ToString();
                                update.gender.Text = reader["gender"].ToString();
                                update.birthdate.Text = reader["birth_date"].ToString();
                                update.bnum.Text = reader["birth_certificate_num"].ToString();
                                update.nid.Text = "No Data";
                                this.Close();
                                update.Show();

                            
                        }
                        else
                        {
                            MessageBox.Show("NO NEED TO UPDATE!", "National ID Number Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }



                    }
                }
                else
                {
                    MessageBox.Show("Invalid Registration Number", "NO DATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            adult_option adult = new adult_option();
            this.Close();
            adult.Show();
        }
    }
}
