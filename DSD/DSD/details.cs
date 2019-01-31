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
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Mail;
namespace DSD
{
    public partial class details : Form
    {
        string host;
        string password;
        string userName;
        
        string DataBase;




        public details()
        {
            InitializeComponent();
        }
        public void searchdata(string valueTosearch) {
            try { 
            MySqlConnection con = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
            MySqlCommand cmd;
            MySqlDataAdapter adptr;
            DataTable table;

            string sel;
            if (radioButton1.Checked == true) {
                sel = "SELECT * FROM `dsdstudentdetails` WHERE `id` LIKE '" + valueTosearch + "%'";
                cmd = new MySqlCommand(sel, con);
                adptr = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adptr.Fill(table);
                dataGridView1.DataSource = table;
            }

            if (radioButton2.Checked == true)
            {
                sel = "SELECT * FROM `dsdstudentdetails` WHERE `name` LIKE '" + valueTosearch + "%'";
                cmd = new MySqlCommand(sel, con);
                adptr = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adptr.Fill(table);
                dataGridView1.DataSource = table;
            }

            if (radioButton6.Checked == true)
            {
                sel = "SELECT * FROM `dsdstudentdetails` WHERE `addres` LIKE '" + valueTosearch + "%'";
                cmd = new MySqlCommand(sel, con);
                adptr = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adptr.Fill(table);
                dataGridView1.DataSource = table;
            }

            if (radioButton3.Checked == true)
            {
                sel = "SELECT * FROM `dsdstudentdetails` WHERE `phoneNumber` LIKE '" + valueTosearch + "%'";
                cmd = new MySqlCommand(sel, con);
                adptr = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adptr.Fill(table);
                dataGridView1.DataSource = table;
            }
            if (radioButton4.Checked == true)
            {
                sel = "SELECT * FROM `dsdstudentdetails` WHERE `studentNumber` LIKE '" + valueTosearch + "%'";
                cmd = new MySqlCommand(sel, con);
                adptr = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adptr.Fill(table);
                dataGridView1.DataSource = table;
            }
            if (radioButton5.Checked == true)
            {
                sel = "SELECT * FROM `dsdstudentdetails` WHERE `date` LIKE '" + valueTosearch + "%'";
                cmd = new MySqlCommand(sel, con);
                adptr = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adptr.Fill(table);
                dataGridView1.DataSource = table;
            }
            if (radioButton7.Checked == true)
            {
                sel = "SELECT * FROM `dsdstudentdetails` WHERE `batch` LIKE '" + valueTosearch + "%'";
                cmd = new MySqlCommand(sel, con);
                adptr = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adptr.Fill(table);
                dataGridView1.DataSource = table;
            }
            con.Close();
        }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void details_Load(object sender, EventArgs e)
        {
            try
            {
                radioButton1.Checked = true;
                DataBase = Form1.DataBase;
                host = Form1.Host;
                password = Form1.Password;
                userName = Form1.UserName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                string valueTosearch = txtSerchDetails.Text.ToString();
                searchdata(valueTosearch);
                for (int i = 1; i <= 215; i++)
                {
                    this.Size = new Size(662, 182 + i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            searchdata("");
            
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtSerchDetails.Text != "") {
                string valueTosearch = txtSerchDetails.Text.ToString();
                searchdata(valueTosearch);
                
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 &&txtSerchDetails.Text!="")
            {
               // for (int i = 1; i <= 215; i++)
                {
                    this.Size = new Size(662, 182 + 215);
                }
                e.Handled = true;

            }
            if (e.KeyChar ==27 && txtSerchDetails.Text != "")
            {
                txtSerchDetails.Text = "";
                for (int i = 1; i <= 215; i++)
                {
                    this.Size = new Size(662, 397-i);
                }
                e.Handled = true;

            }

        }
    }
}
