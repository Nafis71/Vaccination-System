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
    public partial class update_childbirth : Form
    {
        public update_childbirth()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void update_childbirth_Load(object sender, EventArgs e)
        {

        }

        private void reg_Click(object sender, EventArgs e)
        {
            child child = new child();
            this.Hide();
            child.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            child_option update = new child_option();
            update.Show();
        }

        private void proceed_Click(object sender, EventArgs e)
        {
            int indicator = 0;
            String connection = "datasource = 127.0.0.1; username =root; password =; database =vaccination_system";
            MySqlConnection connect = new MySqlConnection(connection);
            String query = "select *from registration where reg_no ='"+regno.Text+"' AND indicator = '"+indicator+"'";
            MySqlCommand Command = new MySqlCommand(query,connect);
            try
            { 
                connect.Open();
                MySqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        int birthnum_check = int.Parse(reader["birth_certificate_num"].ToString());
                        if (birthnum_check == 0)
                        {
                            int birthnumber = int.Parse(reader["birth_certificate_num"].ToString());
                            String check = reader["reg_no"].ToString();
                            if (check == regno.Text)
                            {
                                update_child2 update = new update_child2();
                                update.regno.Text = reader["reg_no"].ToString();
                                update.name.Text = reader["name"].ToString();
                                update.fname.Text = reader["father_name"].ToString();
                                update.mname.Text = reader["mother_name"].ToString();
                                update.fnid.Text = reader["father_nid"].ToString();
                                update.mnid.Text = reader["mother_nid"].ToString();
                                update.pnum.Text = reader["parent_num"].ToString();
                                update.gender.Text = reader["gender"].ToString();
                                if (birthnumber== 0)
                                {
                                    update.bnum.Text = "No Data";
                                }
                                this.Close();
                                update.Show();
                                
                            }
                        }
                        else
                        {
                            MessageBox.Show("NO NEED TO UPDATE!", "Birth Certificate Number Found", MessageBoxButtons.OK,MessageBoxIcon.Information);
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

        private void regno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
