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
    public partial class vac_manage : UserControl
    {
        private static vac_manage instance;
        public static vac_manage Instance
        {
            get
            {
                if (instance == null)

                    instance = new vac_manage();

                return instance;
            }
        }
        public vac_manage()
        {
            InitializeComponent();
            progressBar1.Visible = false;
            comboBox1.Enabled = false;
            quantity.Enabled = false;
            proceed.Enabled = false;   
            name.Visible = false;
            id.Visible = false;
            location.Visible = false;   
        }
        public void clear()
        {
            comboBox1.Items.Clear();
            comboBox1.Text = string.Empty;
            id.Text = string.Empty;
            location.Text = string.Empty;
            name.Text = string.Empty;
            quantity.Text = string.Empty;
            progressBar1.Visible = false;
            comboBox1.Enabled = false;
            quantity.Enabled = false;
            proceed.Enabled = false;
            name.Visible = false;
            id.Visible = false;
            location.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Visible =true;
            progressBar1.Increment(1);
            if(progressBar1.Value ==100)
            {
                timer1.Stop();
                string connection = "datasource= 127.0.0.1; username =root; password =; database =vaccination_system";
                MySqlConnection connect = new MySqlConnection(connection);
                string fetch_quantity = "select vaccine_quantity from vaccine_stock where vaccine_name ='"+comboBox1.Text+"' AND center_id ='"+id.Text+"'";
                MySqlCommand fetch_command = new MySqlCommand(fetch_quantity, connect);
                connect.Open();
                MySqlDataReader fetch = fetch_command.ExecuteReader();
                fetch.Read();
                int quan = int.Parse(fetch["vaccine_quantity"].ToString());
                int fetched = quan + int.Parse(quantity.Text);
                fetch.Close();
                connect.Close();
                string query = "update vaccine_stock set vaccine_quantity='" + fetched+"' where center_id ='" + id.Text + "' AND vaccine_name ='" + comboBox1.Text + "'";
                MySqlCommand command = new MySqlCommand(query, connect);
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                string query2 = "select vaccine_quantity from vaccine_stock_admin where vaccine_name ='"+comboBox1.Text+"'";
                MySqlCommand command2 = new MySqlCommand(query2, connect);
                connect.Open();
                MySqlDataReader reader = command2.ExecuteReader();
                reader.Read();
                int stock_quantity = int.Parse(reader["vaccine_quantity"].ToString());
                reader.Close(); 
                connect.Close();
                int new_quantity = stock_quantity - int.Parse(quantity.Text);
                string query3 = "update vaccine_stock_admin set vaccine_quantity='" + new_quantity + "' where vaccine_name ='" + comboBox1.Text + "'";
                MySqlCommand command3 = new MySqlCommand(query3, connect);
                connect.Open();
                command3.ExecuteNonQuery();
                connect.Close();
                clear();
                MessageBox.Show("Vaccine Delivery Process Started Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void vaccineload()
        {
            string connection = "datasource= 127.0.0.1; username =root; password =; database =vaccination_system";
            MySqlConnection connect = new MySqlConnection(connection);
            string query = "Select vaccine_name from vaccine_stock where vaccine_quantity<20 and center_id='"+id.Text+"'";
            MySqlCommand command = new MySqlCommand(query, connect);
            connect.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["vaccine_name"].ToString());
            }
            connect.Close();
        }
        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = "datasource= 127.0.0.1; username =root; password =; database =vaccination_system";
                MySqlConnection connect = new MySqlConnection(connection);
                string query = "select *from vaccine_stock where vaccine_quantity <20 and center_id ='" + centerid.Text+"'";
                MySqlCommand command = new MySqlCommand(query, connect);
                connect.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    connect.Close();
                    id.Text = centerid.Text;
                    centerid.Text=String.Empty;
                    string query2 = "select *from center where center_id ='" + id.Text + "'";
                    MySqlCommand command2 = new MySqlCommand(query2, connect);
                    connect.Open();
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    reader2.Read();
                    name.Text = reader2["center_name"].ToString();
                    location.Text = reader2["division"].ToString();
                    reader2.Close();
                    connect.Close();
                    name.Visible = true;
                    id.Visible = true;
                    location.Visible = true;
                    comboBox1.Enabled = true;
                    quantity.Enabled = true;
                    proceed.Enabled = true;
                    progressBar1.Enabled = true;
                    vaccineload();
                }
                else
                {
                    MessageBox.Show("This Center doesn't have any shortage of vaccine yet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void proceed_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
