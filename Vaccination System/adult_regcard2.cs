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
    public partial class adult_regcard2 : Form
    {
        public adult_regcard2()
        {
            InitializeComponent();
            Doze();
            Info();
        }
        private void Info()
        {
            String connection = "datasource=127.0.0.1;username=root;password=;database=vaccination_system";
            MySqlConnection connect = new MySqlConnection(connection);
            string sql = "select *from registration where reg_no='" + regno.Text + "'";
            MySqlCommand command = new MySqlCommand(sql, connect);
            connect.Open();
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            name.Text = reader["name"].ToString();
            nid.Text = reader["nid"].ToString();
            phoneno.Text = reader["phone_num"].ToString();
            gender.Text = reader["gender"].ToString();
            birthdate.Text = reader["birth_date"].ToString();
            regdate.Text = reader["reg_date"].ToString();
            center.Text = reader["center_name"].ToString();
            birthno.Text = reader["birth_certificate_num"].ToString();
            reader.Close();
        }
        private void Doze()
        {

            String connection = "datasource=127.0.0.1;username=root;password=;database=vaccination_system";
            MySqlConnection connect = new MySqlConnection(connection);
            string sql = "select *from vaccinated where reg_no='" + regno.Text + "'";
            MySqlCommand command = new MySqlCommand(sql, connect);
            connect.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                vacname.Text = reader["vaccine_name"].ToString();
                doze1date.Text = reader["doze1_date"].ToString();
                doze2date.Text = reader["doze2_date"].ToString();
                int vac_doze1 = int.Parse(reader["doze1"].ToString());
                if (vac_doze1 == 1)
                {
                    doze1.Text = "Completed";
                }
                else
                {
                    doze1.Text = "N/A";
                }
                int vac_doze2 = int.Parse(reader["doze2"].ToString());
                if (vac_doze2 == 1)
                {
                    doze2.Text = "Completed";
                }
                else
                {
                    doze2.Text = "N/A";
                }
                reader.Close();
            }
            else
            {
                vacname.Text = "N/A";
                doze1.Text = "N/A";
                doze2.Text = "N/A";
                doze1date.Text = "N/A";
                doze2date.Text = "N/A";
            }

        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;
        private void print_Click(object sender, EventArgs e)
        {
            print.Visible = false;
            goback.Visible = false;
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            goback.Visible = true;
            print.Visible = true;
        }

        private void goback_Click(object sender, EventArgs e)
        {
            
            name.Text = "value";
            nid.Text = "value";
            birthdate.Text = "value";
            phoneno.Text = "value";
            regno.Text = "value";
            center.Text = "value";
            gender.Text = "value";
            regdate.Text = "value";
            home home = new home();
            this.Close();
            home.Show();
        }
    }
}
