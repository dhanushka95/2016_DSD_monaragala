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
    public partial class update : Form
    {

        string host;
        string password;
        string userName;
        string DataBase;

        public void searchdata(string valueTosearch)
        {
            try {
                MySqlConnection conee = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                MySqlCommand cmd;
                MySqlDataAdapter adptr;
                DataTable table;

                string sel;
                sel = "SELECT * FROM `dsdstudentdetails` WHERE `studentNumber` LIKE '%" + valueTosearch + "%'";
                cmd = new MySqlCommand(sel, conee);
                conee.Open();
                adptr = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adptr.Fill(table);
                dataGridView1.DataSource = table;
                conee.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        public update()
        {
            InitializeComponent();
        }

        private void update_Load(object sender, EventArgs e)
        {
            try {
                host = Form1.Host;
                password = Form1.Password;
                userName = Form1.UserName;
                DataBase = Form1.DataBase;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            

            //////////////////////////////////////
            MySqlConnection cn1 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
            string sqll1 = " SELECT  * FROM `dsdstudentdetails` WHERE `studentNumber`=" + txtStudentNo.Text + " ";
            MySqlCommand cmd1 = new MySqlCommand(sqll1, cn1);
            cn1.Open();

            MySqlDataReader reader1 = cmd1.ExecuteReader();


            while (reader1.Read())
            {
                txtId.Text = reader1["id"].ToString();
                txtName.Text = reader1["name"].ToString();
                txtAddres.Text = reader1["addres"].ToString();
                txtPhoneNo.Text = reader1["phoneNumber"].ToString();
                txtBatch.Text = reader1["batch"].ToString();

            }
            cn1.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show("error");
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtStudentNo.Text!=""&& txtId.Text != "" && txtName.Text != "" && txtAddres.Text != "" && txtPhoneNo.Text != "" && txtBatch.Text != "") {

                try
                {
                    string up = "UPDATE dsdstudentdetails SET id='" + txtId.Text + "',name='" + txtName.Text + "',addres='" + txtAddres.Text + "',batch='" + txtBatch.Text + "',phoneNumber='" + txtPhoneNo.Text + "' WHERE studentNumber=" + int.Parse(txtStudentNo.Text) + "";
                    MySqlConnection co = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                    co.Open();

                    MySqlCommand cmnd = new MySqlCommand(up, co);
                    if (cmnd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("update sucssesfully");
                        btnCheck.PerformClick();
                    }
                    else {
                        MessageBox.Show("not update data");

                    }
                    co.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
               
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            searchdata("");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            searchdata("");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCheck.PerformClick();
                e.Handled = true;

            }
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtStudentNo.Text!="")
            {
                string valueTosearch = txtStudentNo.Text.ToString();
                searchdata(valueTosearch);
                this.Size = new Size(625, 466);
            }
            if (txtStudentNo.Text == "")
            {
                searchdata("");
                txtId.Text = "";
                txtName.Text = "";
                txtAddres.Text = "";
                txtPhoneNo.Text = "";
                txtBatch.Text = "";

                for (int i = 1; i <= 146; i++)
                {
                    this.Size = new Size(625,466 - i);
                }
            }
        }
    }
}
