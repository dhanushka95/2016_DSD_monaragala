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
    public partial class delet : Form
    {
        string host;
        string password;
        string userName;
        
        string DataBase;



        public delet()
        {
            InitializeComponent();
        }

        public void searchdata(string valueTosearch)
        {
            try { 
            MySqlConnection con = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
            MySqlCommand cmd;
            MySqlDataAdapter adptr;
            DataTable table;
            string sel;
            if (radioButton1.Checked == true)
            {
                sel = "SELECT * FROM `dsdstudentdetails` WHERE `id` LIKE '%" + valueTosearch + "%'";
                cmd = new MySqlCommand(sel, con);
                adptr = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adptr.Fill(table);
                dataGridView1.DataSource = table;
            }

            if (radioButton2.Checked == true)
            {
                sel = "SELECT * FROM `dsdstudentdetails` WHERE `name` LIKE '%" + valueTosearch + "%'";
                cmd = new MySqlCommand(sel, con);
                adptr = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adptr.Fill(table);
                dataGridView1.DataSource = table;
            }

            if (radioButton6.Checked == true)
            {
                sel = "SELECT * FROM `dsdstudentdetails` WHERE `addres` LIKE '%" + valueTosearch + "%'";
                cmd = new MySqlCommand(sel, con);
                adptr = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adptr.Fill(table);
                dataGridView1.DataSource = table;
            }

            if (radioButton3.Checked == true)
            {
                sel = "SELECT * FROM `dsdstudentdetails` WHERE `batch` LIKE '%" + valueTosearch + "%'";
                cmd = new MySqlCommand(sel, con);
                adptr = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adptr.Fill(table);
                dataGridView1.DataSource = table;
            }
            if (radioButton5.Checked == true)
            {
                sel = "SELECT * FROM `dsdstudentdetails` WHERE `phoneNumber` LIKE '%" + valueTosearch + "%'";
                cmd = new MySqlCommand(sel, con);
                adptr = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adptr.Fill(table);
                dataGridView1.DataSource = table;
            }
            if (radioButton4.Checked == true)
            {
                sel = "SELECT * FROM `dsdstudentdetails` WHERE `studentNumber` LIKE '%" + valueTosearch + "%'";
                cmd = new MySqlCommand(sel, con);
                adptr = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adptr.Fill(table);
                dataGridView1.DataSource = table;
            }
            if (radioButton7.Checked == true)
            {
                sel = "SELECT * FROM `dsdstudentdetails` WHERE `date` LIKE '%" + valueTosearch + "%'";
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

        private void delet_Load(object sender, EventArgs e)
        {
            try {
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

        private void button2_Click(object sender, EventArgs e)
        {
            string valueTosearch = textBox1.Text.ToString();
            searchdata(valueTosearch);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            searchdata("");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string valueTosearch = textBox1.Text.ToString();
                searchdata(valueTosearch);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            try { 
            MySqlConnection connection = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
            string s = "DELETE FROM  dsdstudentdetails WHERE id='" + textBox1.Text + "'";
            string s1 = "DELETE FROM  dsdstudentdetails WHERE name='" + textBox1.Text + "'";
            string s2 = "DELETE FROM  dsdstudentdetails WHERE batch='" + textBox1.Text + "'";
            string s3 = "DELETE FROM  dsdstudentdetails WHERE phoneNumber='" + textBox1.Text + "'";
            string s4 = "DELETE FROM  dsdstudentdetails WHERE studentNumber='" + textBox1.Text + "'";
            string s5 = "DELETE FROM  dsdstudentdetails WHERE date='" + textBox1.Text + "'";
            string s6 = "DELETE FROM  dsdstudentdetails WHERE addres='" + textBox1.Text + "'";
            connection.Open();

            if (radioButton1.Checked == true) {
                try
                {
                    MySqlCommand c = new MySqlCommand(s, connection);
                        if (c.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("delete sucses");
                        }
                        else
                        {
                            //   MessageBox.Show("not sucses");
                        }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
            }


            if (radioButton1.Checked == true)
            {
                try
                {
                    MySqlCommand c = new MySqlCommand(s, connection);
                        if (c.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("delete sucses");
                        }
                        else
                        {
                            //   MessageBox.Show("not sucses");
                        }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
            }

            if (radioButton2.Checked == true)
            {
                try
                {
                    MySqlCommand c = new MySqlCommand(s1, connection);
                        if (c.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("delete sucses");
                        }
                        else
                        {
                            //  MessageBox.Show("not sucses");
                        }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
            }

            if (radioButton3.Checked == true)
            {
                try
                {
                    MySqlCommand c = new MySqlCommand(s2, connection);
                        if (c.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("delete sucses");
                        }
                        else
                        {
                            // MessageBox.Show("not sucses");
                        }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
            }

            if (radioButton4.Checked == true)
            {
                try
                {
                    MySqlCommand c = new MySqlCommand(s4, connection);
                        if (c.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("delete sucses");
                        }
                        else
                        {
                            //  MessageBox.Show("not sucses");
                        }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
            }

            if (radioButton5.Checked == true)
            {
                try
                {
                    MySqlCommand c = new MySqlCommand(s3, connection);
                        if (c.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("delete sucses");
                        }
                        else
                        {
                            //  MessageBox.Show("not sucses");
                        }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
            }

            if (radioButton6.Checked == true)
            {
                try
                {
                    MySqlCommand c = new MySqlCommand(s6, connection);
                        if (c.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("delete sucses");
                        }
                        else
                        {
                          //  MessageBox.Show("not sucses");
                        }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
            }
            if (radioButton7.Checked == true)
            {
                try
                {
                    MySqlCommand c = new MySqlCommand(s5, connection);
                        if (c.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("delete sucses");
                        }
                        else
                        {
                           // MessageBox.Show("not sucses");
                        }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
            }

                progressBar1.Value = 100;
            button2.PerformClick();
        }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button2.PerformClick();
                e.Handled = true;

            }
        }
    }
}
