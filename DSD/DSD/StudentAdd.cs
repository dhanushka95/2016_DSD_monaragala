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
    public partial class StudentAdd : Form
    {


        string DataBase;
        string host;
        string password;
        string userName;
       
        public StudentAdd()
        {
            InitializeComponent();
        }


        public void searchdata(string valueTosearch)
        {
            try {
                MySqlConnection c = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                MySqlCommand cmd;
                MySqlDataAdapter adptr;
                DataTable table;

                string sel = "SELECT * FROM `dsdstudentdetails` WHERE `id` LIKE '%" + valueTosearch + "%'";
                cmd = new MySqlCommand(sel, c);
                adptr = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adptr.Fill(table);
                dataGridView1.DataSource = table;
                c.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtIdNo.Text == ""|| txtName.Text == "" || txtAddres.Text == "" || txtPhoneNo.Text == "" || txtBatch.Text == "" || txtDate.Text == "" || txtStudentNo.Text == "")
            {
                MessageBox.Show("pleace fill all text ");
                
            }
            else
            {
                try
                {

                   
                    MySqlConnection con = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                    string Query = "INSERT INTO dsdstudentdetails(id,name,studentNumber,addres,phoneNumber,date,batch)  VALUES ('" + txtIdNo.Text.ToString() + "','" + txtName.Text.ToString() + "','" +int.Parse(txtStudentNo.Text) + "','" + txtAddres.Text.ToString() + "','" + txtPhoneNo.Text.ToString() + "','" + txtDate.Text + "','" + txtBatch.Text.ToString() + "')";
                   
                    MySqlCommand cmd = new MySqlCommand(Query, con);
                   
                    con.Open();

                   
                    
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                     con.Close();
                      reader.Close();
                  
                    con.Close();


                    string valueTosearch = txtIdNo.Text.ToString();
                    searchdata(valueTosearch);
                    ///////////////////////////////////
                   
                    if (chkAutoIncriment.Checked==true)
                    {
                        txtStudentNo.Text = (int.Parse(txtStudentNo.Text.ToString()) + 1)+"";
                        txtIdNo.Text = "";
                        txtName.Text = "";
                        txtAddres.Text = "";
                        txtPhoneNo.Text = "";
                        txtBatch.Text = "";
                        txtIdNo.Focus();
                    }
                    else
                    {
                        txtIdNo.Text = "";
                        txtName.Text = "";
                        txtAddres.Text = "";
                        txtPhoneNo.Text = "";
                        txtBatch.Text = "";
                        txtStudentNo.Text = "";
                        txtIdNo.Focus();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }


            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void StudentAdd_Load(object sender, EventArgs e)
        {
            try {
                DataBase = Form1.DataBase;
                host = Form1.Host;
                password = Form1.Password;
                userName = Form1.UserName;

                txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            searchdata("");

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.PerformClick();
                e.Handled = true;
          
            }
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back))) {
                e.Handled = true; 
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter|| !(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) ||(e.KeyChar== 'v')))
            {      
                e.Handled = true;
                txtName.Focus();
            }
          
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtAddres.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtPhoneNo.Focus();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter|| !(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
                txtBatch.Focus();
            }
        }
    }
}
