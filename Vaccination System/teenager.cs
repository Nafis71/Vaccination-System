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
using System.Runtime.InteropServices;

namespace Vaccination_System
{
    public partial class teenager : Form
    {
        public teenager()
        {
            InitializeComponent();
            
            progressbar.Visible = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //using System.Runtime.InteropServices;
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void teenager_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        private void clear()
        {
            mnid.Text = String.Empty;
            fname.Text = String.Empty;
            fnid.Text = String.Empty;
            name.Text = String.Empty;
            mname.Text = String.Empty;
            birthnum.Text = String.Empty;
            center.Text = String.Empty;
            pnum.Text = String.Empty;
            radiobuttonfemale.Checked = false;
            radiobuttonmale.Checked = false;
        }
        private void fnid_TextChanged(object sender, EventArgs e)
        {
            
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

        private void fnid_TextChanged(object sender, KeyPressEventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressbar.Increment(1);
            if (progressbar.Value == 100)
            {
                timer.Stop();
                int indicator = 1;
                MessageBox.Show("Registration Done, Please Collect your registration number", "Registration Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string con = "datasource =127.0.0.1; username =root;password=; database= vaccination_system";
                MySqlConnection connect = new MySqlConnection(con);
                string reg = "Select *from registration where father_nid = '" + fnid.Text + "'and indicator ='" + indicator + "'";
                MySqlCommand command2 = new MySqlCommand(reg, connect);
                try
                {
                    connect.Open();
                    Teenager_regcard final = new Teenager_regcard();
                    MySqlDataReader reader = command2.ExecuteReader();
                    reader.Read();
                    final.regno.Text = reader["reg_no"].ToString();
                    final.name.Text = reader["name"].ToString();
                    final.fname.Text = reader["father_name"].ToString();
                    final.mname.Text = reader["mother_name"].ToString();
                    final.pnum.Text = reader["parent_num"].ToString();
                    final.center.Text = reader["center_name"].ToString();
                    final.gender.Text = reader["gender"].ToString();
                    final.regdate.Text = reader["reg_date"].ToString();
                    int birthnum = int.Parse(reader["birth_certificate_num"].ToString());
                    if (birthnum == 0)
                    {
                        final.birthno.Text = "N/A";
                    }
                    else
                    {
                        final.birthno.Text = birthnum.ToString();
                    }
                    reader.Close();
                    connect.Close();
                    final.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                progressbar.Value = 0;
                progressbar.Visible = false;
                clear();
            }
        }

        private void minimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            teenager_option teen = new teenager_option();
            this.Hide();
            teen.Show();
        }

        private void register_Click_1(object sender, EventArgs e)
        {
            if (name.Text == String.Empty)
            {
                MessageBox.Show("Please fill up name field", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (fname.Text == String.Empty)
            {
                MessageBox.Show("Please fill up Father's name field", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (mname.Text == String.Empty)
            {
                MessageBox.Show("Please fill up Mother's name field", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (fnid.Text == String.Empty)
            {
                MessageBox.Show("Please fill up Father's NID field", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (mnid.Text == String.Empty)
            {
                MessageBox.Show("Please fill up Mother's NID field", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pnum.Text == String.Empty)
            {
                MessageBox.Show("Please fill up Parent's Number field", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (radiobuttonmale.Checked == false && radiobuttonfemale.Checked == false)
            {
                MessageBox.Show("Please Choose the gender of your child", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int indicator = 1;
                String gender;
                if (radiobuttonfemale.Checked)
                {
                    gender = radiobuttonfemale.Text;
                }
                else
                {
                    gender = radiobuttonmale.Text;
                }

                String con = "datasource = 127.0.0.1; username=root; password=; database=vaccination_system";
                MySqlConnection connect = new MySqlConnection(con);
                String query = "insert into registration(name,father_name,mother_name,father_nid,mother_nid,parent_num,birth_certificate_num,gender,indicator,center_name)values('" + name.Text + "','" + fname.Text + "','" + mname.Text + "','" + fnid.Text + "','" + mnid.Text + "','" + pnum.Text + "','" + birthnum.Text + "','" + gender + "','" + indicator + "','" + center.Text + "');";
                MySqlCommand command = new MySqlCommand(query, connect);
                if (birthnum.Text != String.Empty)
                {
                    string check_birthno = "select *from registration where birth_certificate_num ='" + birthnum.Text + "'";
                    MySqlCommand command2 = new MySqlCommand(check_birthno, connect);
                    connect.Open();
                    MySqlDataReader reader = command2.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Please enter a valid Birth Certificate Number", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reader.Close();
                        connect.Close();

                    }
                    else
                    {
                        connect.Close();
                        try
                        {

                            if (MessageBox.Show("Please make sure you have entered information correctly & Press Yes", "Registration Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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
                else
                {
                    try
                    {

                        if (MessageBox.Show("Please make sure you have entered information correctly & Press Yes", "Registration Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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
