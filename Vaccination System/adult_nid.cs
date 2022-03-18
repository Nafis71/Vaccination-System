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
    public partial class adult_nid : Form
    {
        public adult_nid()
        {
            InitializeComponent();
            
            progressbar.Visible= false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goback_Click(object sender, EventArgs e)
        {
            Registration2 reg = new Registration2();
            this.Close();
            reg.Show();
        }
        
        private void intcheck(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = false;
            }
        }
        private void register_Click(object sender, EventArgs e)
        {

            if (name.Text == String.Empty)
            {
                MessageBox.Show("Please fill up Name field ", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nid.Text == String.Empty)
            {
                MessageBox.Show("Please enter your NID ", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (phone.Text == String.Empty)
            {
                MessageBox.Show("Please fill up Phone number field ", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radiobuttonmale.Checked == false && radiobuttonfemale.Checked == false)
            {
                MessageBox.Show("Please Choose a gender ", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (center.Text == String.Empty)
            {
                MessageBox.Show("Please Choose a center ", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (birthno.Text == String.Empty)
            {
                MessageBox.Show("Please enter your Birth Certificate No ", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string gender;
                int indicator = 2;
                if (radiobuttonmale.Checked)
                {
                    gender = radiobuttonmale.Text;
                }
                else
                {
                    gender = radiobuttonfemale.Text;
                }

                string con = "datasource =127.0.0.1; username =root;password=; database= vaccination_system";
                MySqlConnection connect = new MySqlConnection(con);
                string cmd = "insert into registration(name,nid,phone_num,birth_certificate_num,birth_date,gender,indicator,center_name)values('" + name.Text + "','" + nid.Text + "','" + phone.Text + "','" + birthno.Text + "','" + datetimepicker.Text + "','" + gender + "','" + indicator + "','" + center.Text + "');";
                MySqlCommand command = new MySqlCommand(cmd, connect);
                string check = "select *from registration where nid ='" + nid.Text + "'";
                MySqlCommand check_command = new MySqlCommand(check, connect);
                connect.Open();
                MySqlDataReader reader = check_command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    MessageBox.Show("Please enter a valid NID ", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    reader.Close();
                    connect.Close();
                }
                else
                {
                    connect.Close();
                    string check_birthno = "select *from registration where birth_certificate_num ='" + birthno.Text + "'";
                    MySqlCommand command2 = new MySqlCommand(check_birthno, connect);
                    connect.Open();
                    MySqlDataReader birth_reader = command2.ExecuteReader();
                    birth_reader.Read();
                    if (birth_reader.HasRows)
                    {
                        MessageBox.Show("Please enter a valid Birth Certificate Number ", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        reader.Close();
                        connect.Close();
                    }
                    else
                    {
                        connect.Close();
                        try
                        {

                            if (MessageBox.Show("Please make sure you have entered information correctly & Press Yes to continue registration process", "Registration Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                connect.Open();
                                progressbar.Visible = true;
                                command.ExecuteNonQuery();
                                connect.Close();
                                timer.Start();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }


            }
        }
        private void clear()
        {
            name.Text=String.Empty;
            phone.Text=String.Empty;
            nid.Text=String.Empty;
            center.Text=String.Empty;
            birthno.Text=String.Empty;
            datetimepicker.Text=String.Empty;
            radiobuttonfemale.Checked=false;
            radiobuttonmale.Checked=false;
            comboboxdivision.Text=String.Empty;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressbar.Increment(1);
            if (progressbar.Value == 100)
            {
                timer.Stop();
                int indicator = 2;

                if (MessageBox.Show("Registration Done Please Collect your registration number", "Registration Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    string con = "datasource =127.0.0.1; username =root;password=; database= vaccination_system";
                    MySqlConnection connect = new MySqlConnection(con);
                    string reg = "Select *from registration where nid = '" + nid.Text + "'and indicator ='" + indicator + "'";
                    MySqlCommand command2 = new MySqlCommand(reg, connect);
                    adult_regcard adult = new adult_regcard();
                    connect.Open();
                    MySqlDataReader reader = command2.ExecuteReader();
                    while (reader.Read())
                    { 
                    adult.regno.Text = reader["reg_no"].ToString();
                    adult.name.Text = reader["name"].ToString();
                    adult.nid.Text = reader["nid"].ToString();
                    adult.birthdate.Text = reader["birth_date"].ToString();
                    adult.center.Text = reader["center_name"].ToString();
                    adult.regdate.Text = reader["reg_date"].ToString();
                    adult.gender.Text = reader["gender"].ToString();
                    adult.phoneno.Text = reader["phone_num"].ToString();
                    adult.birthno.Text = reader["birth_certificate_num"].ToString();
                    adult.ShowDialog();
                    }
                    connect.Close();
                    progressbar.Value = 0;
                    progressbar.Visible = false;
                    clear();
                }
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void comboboxdivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            center.Items.Clear();
            center.Text = String.Empty;
            string con = "datasource =127.0.0.1; username =root;password=; database= vaccination_system";
            MySqlConnection connect = new MySqlConnection(con);
            string query = "select DISTINCT center_name from center natural join vaccine_stock where vaccine_quantity>0 AND division ='" + comboboxdivision.Text + "'";
            MySqlCommand command = new MySqlCommand(query, connect);
            try
            {
                connect.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    center.Items.Add(reader["center_name"].ToString());
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
