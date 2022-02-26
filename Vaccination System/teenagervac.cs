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
    public partial class teenagervac : UserControl
    {
        private static teenagervac instance;
        public static teenagervac Instance
        {
            get
            {
                if (instance == null)

                    instance = new teenagervac();

                return instance;
            }
        }
        public teenagervac()
        {
            InitializeComponent();
            proceed.Enabled = false;
            vacname.Enabled = false;
            checkboxdoze1.Enabled = false;
            checkboxdoze2.Enabled = false;
            vac_admin_name.Enabled = false;
            datetimepicker.Enabled = false;
            name.Visible = false;
            regno.Visible = false;
            fname.Visible = false;
            mname.Visible = false;
            pnum.Visible = false;
            bnum.Visible = false;
            gender.Visible = false;
            doze1.Visible = false;
            doze2.Visible = false;
            progressbar.Visible = false;
            progressBar1.Visible = false;
            label29.Visible = false;
            pvalue.Visible = false;
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
        public void checkboxcheck(object sender, MouseEventArgs e)
        {
            if (doze1.Text == "Not Completed")
            {
                if (checkboxdoze1.Enabled == true)
                {
                    if (checkboxdoze2.Checked == true)
                    {
                        MessageBox.Show("Can't Select Doze 2 option before completing Doze 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        checkboxdoze2.Checked = false;
                    }
                }
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (searchreg.Text == String.Empty)
            {
                MessageBox.Show("Please Enter A Registration Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                string connection = "datasource=127.0.0.1; username=root;password=; database =vaccination_system";
                MySqlConnection connect = new MySqlConnection(connection);
                string center = "select center_name from center where center_id = '" + id.Text + "'";
                MySqlCommand command = new MySqlCommand(center, connect);
                try
                {
                    connect.Open();
                    MySqlDataReader center_read = command.ExecuteReader();
                    center_read.Read();
                    string center_name = center_read["center_name"].ToString();
                    center_read.Close();
                    string query = "select *from registration where indicator=1 AND reg_no='" + searchreg.Text + "' AND center_name ='" + center_name + "'";
                    MySqlCommand command2 = new MySqlCommand(query, connect);
                    MySqlDataReader reader = command2.ExecuteReader();
                    if (reader.HasRows)
                    {
                        connect.Close();
                        timer1.Start();

                    }
                    else
                    {
                        MessageBox.Show("No Entry Found in the Teenager database", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void vaccinename()
        {
            vacname.Items.Clear();
            string connection = "datasource=127.0.0.1; username=root;password=; database =vaccination_system";
            MySqlConnection connect = new MySqlConnection(connection);
            string query3 = "select vaccine_name from vaccine_stock where center_id ='" + id.Text + "'";
            MySqlCommand command3 = new MySqlCommand(query3, connect);
            connect.Open();
            MySqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                vacname.Items.Add(reader3["vaccine_name"].ToString());
            }
            connect.Close();
        }
        private void checker()
        {
            string connection = "datasource=127.0.0.1; username=root;password=; database =vaccination_system";
            MySqlConnection connect = new MySqlConnection(connection);
            string query = "select vaccine_name from vaccinated where reg_no='" + regno.Text + "'";
            MySqlCommand command = new MySqlCommand(query, connect);
            connect.Open();
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            vacname.Items.Add(reader["vaccine_name"].ToString());
            reader.Close();
            connect.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                progressbar.Visible = true;
                progressbar.Increment(1);
                if (progressbar.Value == 100)
                {
                    timer1.Stop();
                    string connection = "datasource=127.0.0.1; username=root;password=; database =vaccination_system";
                    MySqlConnection connect = new MySqlConnection(connection);
                    string center = "select center_name from center where center_id = '" + id.Text + "'";
                    MySqlCommand command = new MySqlCommand(center, connect);
                    connect.Open();
                    MySqlDataReader center_read = command.ExecuteReader();
                    center_read.Read();
                    string center_name = center_read["center_name"].ToString();
                    center_read.Close();
                    string query = "select *from registration where indicator=1 AND reg_no='" + searchreg.Text + "' AND center_name ='" + center_name + "'";
                    MySqlCommand command2 = new MySqlCommand(query, connect);
                    MySqlDataReader reader = command2.ExecuteReader();
                    reader.Read();
                    regno.Text = reader["reg_no"].ToString();
                    name.Text = reader["name"].ToString();
                    fname.Text = reader["father_name"].ToString();
                    mname.Text = reader["mother_name"].ToString();
                    pnum.Text = reader["parent_num"].ToString();
                    gender.Text = reader["gender"].ToString();
                    int birthnum = int.Parse(reader["birth_certificate_num"].ToString());
                    if (birthnum != 0)
                    {
                        bnum.Text = reader["birth_certificate_num"].ToString();
                    }
                    else
                    {
                        bnum.Text = "N/A";
                    }
                    int doze_1 = int.Parse(reader["doze_1"].ToString());
                    if (doze_1 != 0)
                    {
                        doze1.Text = "Completed";
                        checkboxdoze1.Enabled = false;
                        proceed.Enabled = true;
                        vacname.Enabled = true;
                        vac_admin_name.Enabled = true;
                        datetimepicker.Enabled = true;
                    }

                    else
                    {

                        doze1.Text = "Not Completed";
                        checkboxdoze1.Enabled = true;
                        proceed.Enabled = true;
                        vacname.Enabled = true;
                        vac_admin_name.Enabled = true;
                        datetimepicker.Enabled = true;

                    }
                    int doze_2 = int.Parse(reader["doze_2"].ToString());
                    if (doze_2 != 0)
                    {
                        doze2.Text = "Completed";
                        checkboxdoze2.Enabled = false;
                        checkboxdoze1.Enabled = false;
                        proceed.Enabled = false;
                        vacname.Enabled = false;
                        vac_admin_name.Enabled = false;
                        datetimepicker.Enabled = false;
                    }
                    else
                    {

                        doze2.Text = "Not Completed";
                        checkboxdoze2.Enabled = true;
                        proceed.Enabled = true;
                        vacname.Enabled = true;
                        vac_admin_name.Enabled = true;
                        datetimepicker.Enabled = true;
                    }
                    connect.Close();
                    progressbar.Value = 0;
                    progressbar.Visible = false;
                    name.Visible = true;
                    regno.Visible = true;
                    fname.Visible = true;
                    mname.Visible = true;
                    pnum.Visible = true;
                    bnum.Visible = true;
                    gender.Visible = true;
                    doze1.Visible = true;
                    doze2.Visible = true;
                    searchreg.Text = String.Empty;
                    if (doze_1 == 1)
                    {
                        checker();
                    }
                    else
                    {
                        vaccinename();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int doze = 1;
            progressBar1.Visible = true;
            label29.Visible = true;
            pvalue.Visible = true;
            pvalue.Text = progressBar1.Value.ToString() + "%";
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer2.Stop();
                progressBar1.Value = 0;
                progressBar1.Visible = false;
                label29.Visible = false;
                pvalue.Visible = false;
                string connection = "datasource=127.0.0.1; username=root;password=; database =vaccination_system";
                MySqlConnection connect = new MySqlConnection(connection);
                string query3 = "select vaccine_quantity from vaccine_stock where center_id ='" + id.Text + "'And vaccine_name='" + vacname.Text + "'";
                MySqlCommand command3 = new MySqlCommand(query3, connect);
                connect.Open();
                MySqlDataReader reader = command3.ExecuteReader();
                reader.Read();
                int quantity = int.Parse(reader["vaccine_quantity"].ToString());
                reader.Close();
                connect.Close();
                if (quantity > 0)
                {
                    int newquantity = quantity - 1;
                    string query4 = "update vaccine_stock set vaccine_quantity='" + newquantity + "' where center_id ='" + id.Text + "' AND vaccine_name='" + vacname.Text + "'";
                    MySqlCommand command4 = new MySqlCommand(query4, connect);
                    connect.Open();
                    command4.ExecuteNonQuery();
                    connect.Close();
                    string query = "insert into vaccinated(reg_no,name,gender,vaccine_name,doze1,doze1_date,vaccinator_name_doze1) values('" + regno.Text + "','" + name.Text + "','" + gender.Text + "','" + vacname.Text + "','" + doze + "','" + datetimepicker.Text + "','" + vac_admin_name.Text + "')";
                    MySqlCommand command = new MySqlCommand(query, connect);
                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();
                    string query2 = "update registration set doze_1 ='" + doze + "'where reg_no='" + regno.Text + "'";
                    MySqlCommand command2 = new MySqlCommand(query2, connect);
                    connect.Open();
                    command2.ExecuteNonQuery();
                    connect.Close();
                    clear();
                    MessageBox.Show("Operation Successfull,Vaccination Data Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Vaccine " + vacname.Text + " Not available ,Please Contact to the health admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int doze = 1;
            progressBar1.Visible = true;
            label29.Visible = true;
            pvalue.Visible = true;
            pvalue.Text = progressBar1.Value.ToString() + "%";
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer3.Stop();
                progressBar1.Value = 0;
                progressBar1.Visible = false;
                label29.Visible = false;
                pvalue.Visible = false;
                string connection = "datasource=127.0.0.1; username=root;password=; database =vaccination_system";
                MySqlConnection connect = new MySqlConnection(connection);
                string query3 = "select vaccine_quantity from vaccine_stock where center_id ='" + id.Text + "'And vaccine_name='" + vacname.Text + "'";
                MySqlCommand command3 = new MySqlCommand(query3, connect);
                connect.Open();
                MySqlDataReader reader = command3.ExecuteReader();
                reader.Read();
                int quantity = int.Parse(reader["vaccine_quantity"].ToString());
                reader.Close();
                connect.Close();
                if (quantity > 0)
                {
                    int newquantity = quantity - 1;
                    string query4 = "update vaccine_stock set vaccine_quantity='" + newquantity + "' where center_id ='" + id.Text + "' AND vaccine_name='" + vacname.Text + "'";
                    MySqlCommand command4 = new MySqlCommand(query4, connect);
                    connect.Open();
                    command4.ExecuteNonQuery();
                    connect.Close();
                    string query = "insert into vaccinated(reg_no,name,gender,vaccine_name,doze2,doze2_date,vaccinator_name_doze2) values('" + regno.Text + "','" + name.Text + "','" + gender.Text + "','" + vacname.Text + "','" + doze + "','" + datetimepicker.Text + "','" + vac_admin_name.Text + "')";
                    MySqlCommand command = new MySqlCommand(query, connect);
                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();
                    string query2 = "update registration set doze_2 ='" + doze + "'where reg_no='" + regno.Text + "'";
                    MySqlCommand command2 = new MySqlCommand(query2, connect);
                    connect.Open();
                    command2.ExecuteNonQuery();
                    connect.Close();
                    clear();
                    MessageBox.Show("Operation Successfull,Vaccination Data Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Vaccine " + vacname.Text + " Not available ,Please Contact to the health admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int doze = 1;
            progressBar1.Visible = true;
            label29.Visible = true;
            pvalue.Visible = true;
            pvalue.Text = progressBar1.Value.ToString() + "%";
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer4.Stop();
                progressBar1.Value = 0;
                progressBar1.Visible = false;
                label29.Visible = false;
                pvalue.Visible = false;
                string connection = "datasource=127.0.0.1; username=root;password=; database =vaccination_system";
                MySqlConnection connect = new MySqlConnection(connection);
                string query3 = "select vaccine_quantity from vaccine_stock where center_id ='" + id.Text + "'And vaccine_name='" + vacname.Text + "'";
                MySqlCommand command3 = new MySqlCommand(query3, connect);
                connect.Open();
                MySqlDataReader reader = command3.ExecuteReader();
                reader.Read();
                int quantity = int.Parse(reader["vaccine_quantity"].ToString());
                reader.Close();
                connect.Close();
                if (quantity > 0)
                {
                    int newquantity = quantity - 1;
                    string query4 = "update vaccine_stock set vaccine_quantity='" + newquantity + "' where center_id ='" + id.Text + "' AND vaccine_name='" + vacname.Text + "'";
                    MySqlCommand command4 = new MySqlCommand(query4, connect);
                    connect.Open();
                    command4.ExecuteNonQuery();
                    connect.Close();
                    string query = "insert into vaccinated(reg_no,name,birth_certificate_num,gender,vaccine_name,doze1,doze1_date,vaccinator_name_doze1) values('" + regno.Text + "','" + name.Text + "','" + bnum.Text + "','" + gender.Text + "','" + vacname.Text + "','" + doze + "','" + datetimepicker.Text + "','" + vac_admin_name.Text + "')";
                    MySqlCommand command = new MySqlCommand(query, connect);
                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();
                    string query2 = "update registration set doze_1 ='" + doze + "'where reg_no='" + regno.Text + "'";
                    MySqlCommand command2 = new MySqlCommand(query2, connect);
                    connect.Open();
                    command2.ExecuteNonQuery();
                    connect.Close();
                    clear();
                    MessageBox.Show("Operation Successfull,Vaccination Data Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Vaccine " + vacname.Text + " Not available ,Please Contact to the health admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            int doze = 1;
            progressBar1.Visible = true;
            label29.Visible = true;
            pvalue.Visible = true;
            pvalue.Text = progressBar1.Value.ToString() + "%";
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer5.Stop();
                progressBar1.Value = 0;
                progressBar1.Visible = false;
                label29.Visible = false;
                pvalue.Visible = false;
                string connection = "datasource=127.0.0.1; username=root;password=; database =vaccination_system";
                MySqlConnection connect = new MySqlConnection(connection);
                string query3 = "select vaccine_quantity from vaccine_stock where center_id ='" + id.Text + "'And vaccine_name='" + vacname.Text + "'";
                MySqlCommand command3 = new MySqlCommand(query3, connect);
                connect.Open();
                MySqlDataReader reader = command3.ExecuteReader();
                reader.Read();
                int quantity = int.Parse(reader["vaccine_quantity"].ToString());
                reader.Close();
                connect.Close();
                if (quantity > 0)
                {
                    int newquantity = quantity - 1;
                    string query4 = "update vaccine_stock set vaccine_quantity='" + newquantity + "' where center_id ='" + id.Text + "' AND vaccine_name='" + vacname.Text + "'";
                    MySqlCommand command4 = new MySqlCommand(query4, connect);
                    connect.Open();
                    command4.ExecuteNonQuery();
                    connect.Close();
                    string query = "insert into vaccinated(reg_no,name,birth_certificate_num,gender,vaccine_name,doze2,doze2_date,vaccinator_name_doze2) values('" + regno.Text + "','" + name.Text + "','" + bnum.Text + "','" + gender.Text + "','" + vacname.Text + "','" + doze + "','" + datetimepicker.Text + "','" + vac_admin_name.Text + "')";
                    MySqlCommand command = new MySqlCommand(query, connect);
                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();
                    string query2 = "update registration set doze_2 ='" + doze + "'where reg_no='" + regno.Text + "'";
                    MySqlCommand command2 = new MySqlCommand(query2, connect);
                    connect.Open();
                    command2.ExecuteNonQuery();
                    connect.Close();
                    clear();
                    MessageBox.Show("Operation Successfull,Vaccination Data Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Vaccine " + vacname.Text + " Not available ,Please Contact to the health admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            label29.Visible = true;
            pvalue.Visible = true;
            pvalue.Text = progressBar1.Value.ToString() + "%";
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer6.Stop();
                progressBar1.Visible = false;
                progressBar1.Value = 0;
                label29.Visible = false;
                pvalue.Visible = false;
                int doze = 1;
                string connection = "datasource=127.0.0.1; username=root;password=; database =vaccination_system";
                MySqlConnection connect = new MySqlConnection(connection);
                string query3 = "select vaccine_quantity from vaccine_stock where center_id ='" + id.Text + "'And vaccine_name='" + vacname.Text + "'";
                MySqlCommand command3 = new MySqlCommand(query3, connect);
                connect.Open();
                MySqlDataReader reader = command3.ExecuteReader();
                reader.Read();
                int quantity = int.Parse(reader["vaccine_quantity"].ToString());
                reader.Close();
                connect.Close();
                if (quantity > 0)
                {
                    int newquantity = quantity - 1;
                    string query4 = "update vaccine_stock set vaccine_quantity='" + newquantity + "' where center_id ='" + id.Text + "' AND vaccine_name='" + vacname.Text + "'";
                    MySqlCommand command4 = new MySqlCommand(query4, connect);
                    connect.Open();
                    command4.ExecuteNonQuery();
                    connect.Close();
                    string query = "update vaccinated set doze2='" + doze + "' , doze2_date ='" + datetimepicker.Text + "', vaccinator_name_doze2='" + vac_admin_name.Text + "' where reg_no ='" + regno.Text + "'";
                    MySqlCommand command = new MySqlCommand(query, connect);
                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();
                    string query2 = "update registration set doze_2 ='" + doze + "'where reg_no='" + regno.Text + "'";
                    MySqlCommand command2 = new MySqlCommand(query2, connect);
                    connect.Open();
                    command2.ExecuteNonQuery();
                    connect.Close();
                    clear();
                    MessageBox.Show("Operation Successfull,Vaccination Data Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Vaccine " + vacname.Text + " Not available ,Please Contact to the health admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void proceed_Click(object sender, EventArgs e)
        {
            if (vacname.Text == String.Empty)
            {
                MessageBox.Show("Please choose a vaccine name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (checkboxdoze1.Checked == false && checkboxdoze2.Checked == false)
            {
                MessageBox.Show("Please choose a Doze", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (vac_admin_name.Text == String.Empty)
            {
                MessageBox.Show("Please enter a vac admin name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (doze1.Text == "Completed")
                    {
                        timer6.Start();

                    }
                    else
                    {

                        if (bnum.Text == "N/A")
                        {

                            if (checkboxdoze1.Checked == true)
                            {

                                timer2.Start();

                            }
                            else
                            {

                                timer3.Start();
                            }
                        }
                        else
                        {
                            if (checkboxdoze1.Checked == true)
                            {

                                timer4.Start();

                            }
                            else
                            {

                                timer5.Start();
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void clear()
        {
            vacname.Text = String.Empty;
            datetimepicker.Text = String.Empty;
            vac_admin_name.Text = String.Empty;
            checkboxdoze1.Checked = false;
            checkboxdoze2.Checked = false;
            name.Text = String.Empty;
            fname.Text = String.Empty;
            regno.Text = String.Empty;
            mname.Text = String.Empty;
            bnum.Text = String.Empty;
            pnum.Text = String.Empty;
            doze1.Text = String.Empty;
            doze2.Text = String.Empty;
            gender.Text = String.Empty;
            vacname.Items.Clear();
        }
    }
}
