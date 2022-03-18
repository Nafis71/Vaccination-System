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
    public partial class regcard : Form
    {
        public regcard()
        {
            InitializeComponent();
            
        }

        private void login_Click(object sender, EventArgs e)
        {
            string connection = "datasource =127.0.0.1; username =root;password=; database = vaccination_system";
            MySqlConnection connect = new MySqlConnection(connection);
            string query = "select *from registration where reg_no ='"+id.Text+"'";
            MySqlCommand command = new MySqlCommand(query,connect);
            try
            {
                connect.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                { 
                    reader.Read();
                int indicator = int.Parse(reader["indicator"].ToString());
                if (indicator == 0)
                {
                    child_regcard child = new child_regcard();
                        child.regno.Text = reader["reg_no"].ToString();
                        child.name.Text = reader["name"].ToString();
                        child.fname.Text = reader["father_name"].ToString();
                        child.mname.Text = reader["mother_name"].ToString();
                        child.pnum.Text = reader["parent_num"].ToString();
                        child.gender.Text = reader["gender"].ToString();
                        int birth =int.Parse( reader["birth_certificate_num"].ToString());
                        if(birth == 0)
                        {
                            child.birthno.Text = "N/A";
                        }
                        else
                        {
                            child.birthno.Text = birth.ToString();
                        }
                        child.center.Text = reader["center_name"].ToString();
                        child.regdate.Text = reader["reg_date"].ToString();
                        reader.Close();
                        connect.Close();
                        child.Show();
                }
                else if (indicator == 1)
                {
                    Teenager_regcard teen = new Teenager_regcard();
                        teen.regno.Text = reader["reg_no"].ToString();
                        teen.name.Text = reader["name"].ToString();
                        teen.fname.Text = reader["father_name"].ToString();
                        teen.mname.Text = reader["mother_name"].ToString();
                        teen.pnum.Text = reader["parent_num"].ToString();
                        teen.gender.Text = reader["gender"].ToString();
                        int birth = int.Parse(reader["birth_certificate_num"].ToString());
                        if (birth == 0)
                        {
                            teen.birthno.Text = "N/A";
                        }
                        else
                        {
                            teen.birthno.Text = birth.ToString();
                        }
                        teen.center.Text = reader["center_name"].ToString();
                        teen.regdate.Text = reader["reg_date"].ToString();
                    reader.Close();
                    connect.Close();
                    teen.Show();
                }
                    else
                    {
                        adult_regcard adult = new adult_regcard();
                        adult.regno.Text = reader["reg_no"].ToString();
                        adult.name.Text = reader["name"].ToString();
                        adult.birthno.Text = reader["birth_certificate_num"].ToString();
                        adult.phoneno.Text = reader["phone_num"].ToString();
                        adult.birthdate.Text = reader["birth_date"].ToString();
                        adult.gender.Text = reader["gender"].ToString();
                        int nid1 = int.Parse(reader["nid"].ToString());
                        if (nid1 == 0)
                        {
                            adult.nid.Text = "N/A";
                        }
                        else
                        {
                            adult.nid.Text = nid1.ToString();
                        }
                        adult.center.Text = reader["center_name"].ToString();
                        adult.regdate.Text = reader["reg_date"].ToString();
                        reader.Close();
                        connect.Close();
                        adult.Show();
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
    }
}
