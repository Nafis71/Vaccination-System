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
    public partial class center : UserControl
    {

        private static center instance;
        public static center Instance
        {
            get
            {
                if (instance == null)

                    instance = new center();

                return instance;
            }
        }
        public center()
        {
            InitializeComponent();
            progressBar2.Visible = false;
        }
        public void clear()
        {
            id.Text = String.Empty;
            pass.Text = String.Empty;
            name.Text = String.Empty;
            location.Text = String.Empty;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void proceed_Click(object sender, EventArgs e)
        {
            try
            {
                if (id.Text == String.Empty)
                {
                    MessageBox.Show("Please fill up the center id field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (name.Text == String.Empty)
                {
                    MessageBox.Show("Please fill up the center name field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (location.Text == String.Empty)
                {
                    MessageBox.Show("Please choose a center location", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (pass.Text == String.Empty)
                {
                    MessageBox.Show("Please fill up the center password field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {


                    string connection = "datasource =127.0.0.1;username =root; password =; database =vaccination_system";
                    MySqlConnection connect = new MySqlConnection(connection);
                    string query = "select *from center where center_id ='" + id.Text + "'";
                    MySqlCommand command = new MySqlCommand(query, connect);
                    connect.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Duplicate Center id, Please try again with different id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        connect.Close();
                        timer1.Start();
                    }
                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar2.Visible = true;
            progressBar2.Increment(1);
            if (progressBar2.Value == 100)
            {
                timer1.Stop();
                string connection = "datasource =127.0.0.1;username =root; password =; database =vaccination_system";
                MySqlConnection connect = new MySqlConnection(connection);
                string query2 = "insert into center(center_id,center_name,division) values ('" + id.Text + "','" + name.Text + "','" + location.Text + "')";
                MySqlCommand command2 = new MySqlCommand(query2, connect);
                connect.Open();
                command2.ExecuteNonQuery();
                connect.Close();
                String password = pass.Text;
                String encryptedpass = EasyEncryption.MD5.ComputeMD5Hash(password);
                string query3 = "insert into vac_adminlogin(center_id,password) values ('" + id.Text + "','" + encryptedpass + "')";
                MySqlCommand command3 = new MySqlCommand(query3, connect);
                connect.Open();
                command3.ExecuteNonQuery();
                connect.Close();
                progressBar2.Value = 0;
                progressBar2.Visible = false;
                clear();
                MessageBox.Show("Center Registration Done, Please Allocate Some vaccine for this center", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
