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
            Registration2 reg = new Registration2();
            this.Hide();
            reg.Show();
            

        }
        private void clear()
        {
            name.Text = String.Empty;
            fname.Text = String.Empty;
            fnid.Text = String.Empty;
            mnid.Text = String.Empty;
            mname.Text = String.Empty;
            birthnum.Text = String.Empty;
            pnum.Text = String.Empty;
            radiobuttonfemale.Checked = false;
            radiobuttonmale.Checked = false;
        }

        private void register_Click(object sender, EventArgs e)
        {
            if (name.Text ==String.Empty)
            {
                MessageBox.Show("Please fill up name field","Registration Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                String query = "insert into registration(name,father_name,mother_name,father_nid,mother_nid,parent_num,birth_certificate_num,gender,indicator)values('"+name.Text+"','"+fname.Text+"','"+mname.Text+"','"+fnid.Text+"','"+mnid.Text+"','"+pnum.Text+"','"+birthnum.Text+"','"+gender+"','"+indicator+"');";
                MySqlCommand command = new MySqlCommand(query, connect);
                String reg = "Select *from registration where father_nid = '"+fnid.Text+"' and indicator='"+indicator+"'";
                MySqlCommand command2 = new MySqlCommand(reg,connect);
                
                try
                {
                    if (MessageBox.Show("Please make sure you have entered information correctly & Press Yes", "Confirm Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        connect.Open();
                        command.ExecuteNonQuery();
                        MySqlDataReader reader = command2.ExecuteReader();
                        MessageBox.Show("Registration Done Please Collect your registration number", "Registration Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        child_final final = new child_final();
                        while(reader.Read())
                        {
                            final.regno.Text = reader["reg_no"].ToString();
                            final.name.Text = reader["name"].ToString();
                            final.fname.Text = reader["father_name"].ToString();
                            final.mname.Text = reader["mother_name"].ToString();
                            final.fnid.Text = reader["father_nid"].ToString();
                            final.mnid.Text = reader["mother_nid"].ToString();
                            final.pnum.Text = reader["parent_num"].ToString();
                            int birthnum = int.Parse(reader["birth_certificate_num"].ToString());
                            if(birthnum == 0)
                            {
                                final.birthnum.Text = "NO Data (Must be updated later on)";
                            }
                            else
                            {
                                final.birthnum.Text = reader["birth_certificate_num"].ToString();
                                
                            }
                            int doze1 = int.Parse(reader["doze_1"].ToString());
                            if (doze1 == 0)
                            {
                                final.doze1.Text = "Incomplete";
                            }
                            else
                            {
                                final.doze1.Text = "Complete";
                            }
                            int doze2 = int.Parse(reader["doze_2"].ToString());
                            if (doze2 == 0)
                            {
                                final.doze2.Text = "Incomplete";
                            }
                            else
                            {
                                final.doze2.Text = "Complete";
                            }
                        }
                        connect.Close();
                        clear();
                        final.ShowDialog();
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
