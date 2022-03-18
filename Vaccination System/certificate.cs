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
    public partial class certificate : Form
    {
        public certificate()
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
            home home = new home();
            this.Close();
            home.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string connection = "datasource =127.0.0.1; username =root;password=; database = vaccination_system";
            MySqlConnection connect = new MySqlConnection(connection);
            string query = "select *from registration where reg_no ='" + id.Text + "'";
            MySqlCommand command = new MySqlCommand(query, connect);
            try
            {
                connect.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    connect.Close();
                    string query2 = "select reg_no from vaccinated where reg_no ='" + id.Text + "'";
                    MySqlCommand command2 = new MySqlCommand(query2, connect);
                    connect.Open();
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    if(reader2.HasRows)
                    {
                        connect.Close();
                        string query3 = "select *from registration where reg_no ='" + id.Text + "'";
                        MySqlCommand command3 = new MySqlCommand(query3, connect);
                        connect.Open();
                        MySqlDataReader reader3 = command3.ExecuteReader();
                        reader3.Read();
                        int indicator = int.Parse(reader3["indicator"].ToString());
                        if (indicator == 0)
                        {
                            int birthno = int.Parse(reader3["birth_certificate_num"].ToString());
                            if (birthno != 0)
                            {
                                child_certificate child = new child_certificate();
                                child.regno.Text = reader3["reg_no"].ToString();
                                child.name.Text = reader3["name"].ToString();
                                child.fname.Text = reader3["father_name"].ToString();
                                child.mname.Text = reader3["mother_name"].ToString();
                                child.pnum.Text = reader3["parent_num"].ToString();
                                child.gender.Text = reader3["gender"].ToString();
                                child.birthno.Text = reader3["birth_certificate_num"].ToString();
                                child.center.Text = reader3["center_name"].ToString();
                                reader3.Close();
                                connect.Close();
                                child.Show();
                            }
                            else
                            {
                                reader.Close();
                                connect.Close();
                                MessageBox.Show("Please update your birth certificate number first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        else if (indicator == 1)
                        {
                            int birthno = int.Parse(reader3["birth_certificate_num"].ToString());
                            if (birthno != 0)
                            {
                                teenager_certificate teen = new teenager_certificate();
                                teen.regno.Text = reader3["reg_no"].ToString();
                                teen.name.Text = reader3["name"].ToString();
                                teen.fname.Text = reader3["father_name"].ToString();
                                teen.mname.Text = reader3["mother_name"].ToString();
                                teen.pnum.Text = reader3["parent_num"].ToString();
                                teen.gender.Text = reader3["gender"].ToString();
                                teen.birthno.Text = reader3["birth_certificate_num"].ToString();
                                teen.center.Text = reader3["center_name"].ToString();
                                reader3.Close();
                                connect.Close();
                                teen.Show();
                            }
                            else
                            {
                                reader2.Close();
                                connect.Close();
                                MessageBox.Show("Please update your birth certificate number first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        else
                        {
                            int nidno = int.Parse(reader3["nid"].ToString());
                            if (nidno != 0)
                            {
                                adult_certificate adult = new adult_certificate();
                                adult.regno.Text = reader3["reg_no"].ToString();
                                adult.name.Text = reader3["name"].ToString();
                                adult.birthno.Text = reader3["birth_certificate_num"].ToString();
                                adult.phoneno.Text = reader3["phone_num"].ToString();
                                adult.birthdate.Text = reader3["birth_date"].ToString();
                                adult.gender.Text = reader3["gender"].ToString();
                                adult.nid.Text = reader3["nid"].ToString();
                                adult.center.Text = reader3["center_name"].ToString();
                                reader3.Close();
                                connect.Close();
                                adult.Show();
                            }
                            else
                            {
                                reader2.Close();
                                connect.Close();
                                MessageBox.Show("Please update your NID first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not yet vaccinated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        connect.Close();
                    }
                   
                }
                else
                {
                    MessageBox.Show("Invalid Registration Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
