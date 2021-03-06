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
    public partial class admin_dashboard : UserControl
    {
        private static admin_dashboard instance;
        public static admin_dashboard Instance
        {
            get
            {
                if (instance == null)

                    instance = new admin_dashboard();

                return instance;
            }
        }
        int length = 0;
        int length1 = 0;
        string text;
        string text2;
        public admin_dashboard()
        {
            InitializeComponent();
        }
        public void centerinfo()
        {
            try
            {

                string connection = "datasource =127.0.0.1;username=root;password=; database = vaccination_system";
                MySqlConnection connect = new MySqlConnection(connection);
                string query = "select count(center_id) as total from center";
                MySqlCommand command = new MySqlCommand(query, connect);
                connect.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                id.Text = reader["total"].ToString();
                reader.Close();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void vaccineinfo()
        {
            try
            {
                string connection = "datasource =127.0.0.1;username=root;password=; database = vaccination_system";
                MySqlConnection connect = new MySqlConnection(connection);
                string query = "select sum(vaccine_quantity) as quantity from vaccine_stock_admin";
                MySqlCommand command = new MySqlCommand(query, connect);
                connect.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                int quantity = int.Parse(reader["quantity"].ToString());
                count.Text = quantity.ToString();
                if (quantity != 0)
                {
                    status.Text = "Available";
                    status.ForeColor = Color.Green;
                }
                else
                {
                    status.ForeColor = Color.Red;
                    status.Text = "Not Available";
                }
                reader.Close();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void registrationinfo()
        {
            try
            {
                string connection = "datasource =127.0.0.1;username=root;password=; database = vaccination_system";
                MySqlConnection connect = new MySqlConnection(connection);
                string query = "select count(reg_no) as total_reg from registration";
                MySqlCommand command = new MySqlCommand(query, connect);
                connect.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                total_registration.Text = reader["total_reg"].ToString();
                reader.Close();
                connect.Close();
                string query2 = "select count(reg_no) as total_adult_reg from registration where indicator=2";
                MySqlCommand command2 = new MySqlCommand(query2, connect);
                connect.Open();
                MySqlDataReader reader2 = command2.ExecuteReader();
                reader2.Read();
                adult.Text = reader2["total_adult_reg"].ToString();
                reader2.Close();
                connect.Close();
                string query3 = "select count(reg_no) as total_teen_reg from registration where indicator=1";
                MySqlCommand command3 = new MySqlCommand(query3, connect);
                connect.Open();
                MySqlDataReader reader3 = command3.ExecuteReader();
                reader3.Read();
                teenager.Text = reader3["total_teen_reg"].ToString();
                reader3.Close();
                connect.Close();
                string query4 = "select count(reg_no) as total_child_reg from registration where indicator=0";
                MySqlCommand command4 = new MySqlCommand(query4, connect);
                connect.Open();
                MySqlDataReader reader4 = command4.ExecuteReader();
                reader4.Read();
                child.Text = reader4["total_child_reg"].ToString();
                reader4.Close();
                connect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void vaccinationinfo()
        {
            string connection = "datasource =127.0.0.1;username=root;password=; database = vaccination_system";
            MySqlConnection connect = new MySqlConnection(connection);
            string query = "select count(reg_no) as total from vaccinated";
            MySqlCommand command = new MySqlCommand(query, connect);
            connect.Open();
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            vaccinated.Text =reader["total"].ToString();
            reader.Close();
            int vaccinated_people = int.Parse(vaccinated.Text);
            string query2 = "select count(reg_no) as total from registration";
            MySqlCommand command2 = new MySqlCommand(query2, connect);
            MySqlDataReader reader2 = command2.ExecuteReader();
            reader2.Read();
            int yet_to_be_vaccinated = int.Parse(reader2["total"].ToString());
            reader2.Close();
            connect.Close();
            int newamount = yet_to_be_vaccinated - vaccinated_people;
            tobevaccinated.Text = newamount.ToString();

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (length1 < text2.Length)
            {
                label10.Text = label10.Text + text2.ElementAt(length1);
                length1++;
            }
            else
            {
                timer2.Stop();
                length1 = 0;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressbar.Visible = true;
            label10.Visible = true;
            progressbar.Increment(1);
            if (progressbar.Value == 30)
            {

                centerinfo();

            }
            else if (progressbar.Value == 60)
            {
                vaccineinfo();
            }
            else if (progressbar.Value == 100)
            {
                timer3.Stop();
                registrationinfo();
                vaccinationinfo();
                progressbar.Value = 0;
                progressbar.Visible = false;
                label10.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (length < text.Length)
            {
                label3.Text = label3.Text + text.ElementAt(length);
                length++;

            }
            else
            {

                timer1.Stop();
                length = 0;
            }
        }
        public void t1()
        {
            text = label3.Text;
            label3.Text = String.Empty;
            timer1.Start();
        }
        public void t2()
        {

            text2 = label10.Text;
            label10.Text = String.Empty;
            timer2.Start();
        }
        public void t3()
        {
            timer3.Start();
        }
    }
}
