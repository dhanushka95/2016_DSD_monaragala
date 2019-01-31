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
    public partial class UpdateClassStudent : Form
    {
        string host;
        string password;
        string userName;
        string DataBase;
        public UpdateClassStudent()
        {
            InitializeComponent();
        }
        private void searchclass(string valueTosearch)
        {
            try {
                MySqlConnection cn1 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                string sqll1 = " SELECT a.phoneNumber , b.Name FROM `" + comboBox1.Text.ToString() + comboBox2.Text.ToString() + comboBox3.Text.ToString() + "` as `a` , `dsdstudentdetails` as `b` WHERE a.studentNumber LIKE '%" + valueTosearch + "%' AND b.studentNumber=a.studentNumber ";
                MySqlCommand cmd1 = new MySqlCommand(sqll1, cn1);
                cn1.Open();

                MySqlDataReader reader1 = cmd1.ExecuteReader();

                reader1.Read();

                textBox2.Text = reader1["Name"].ToString();
                textBox3.Text = reader1["phoneNumber"].ToString();
            }
            catch (Exception ex)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                
                MessageBox.Show("incorrect Student Number");
                
            }

        }

        private void searchdata(string valueTosearch)
        {
            try {
                MySqlConnection con = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                MySqlCommand cmd;
                MySqlDataAdapter adptr;
                DataTable table;
                string sel;

                sel = "SELECT `studentNumber`,`name`,`phoneNumber` FROM `dsdstudentdetails` WHERE `studentNumber` LIKE '%" + valueTosearch + "%'";
                cmd = new MySqlCommand(sel, con);
                adptr = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adptr.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
        private void UpdateClassStudent_Load(object sender, EventArgs e)
        {
            

            try {
                host = Form1.Host;
                password = Form1.Password;
                userName = Form1.UserName;
                DataBase = Form1.DataBase;
                MySqlConnection cn1 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
            string sqll1 = " SELECT  * FROM class GROUP BY year ";
            MySqlCommand cmd1 = new MySqlCommand(sqll1, cn1);
            cn1.Open();

            MySqlDataReader reader1 = cmd1.ExecuteReader();


            while (reader1.Read())
            {
                comboBox1.Items.Add(reader1["year"].ToString());


            }
            cn1.Close();


            //////////////////////////////////////
            MySqlConnection cn2 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
            string sqll2 = " SELECT  * FROM class GROUP BY subject ";
            MySqlCommand cmd2 = new MySqlCommand(sqll2, cn2);
            cn2.Open();

            MySqlDataReader reader2 = cmd2.ExecuteReader();


            while (reader2.Read())
            {
                comboBox2.Items.Add(reader2["subject"].ToString());


            }
            cn2.Close();

            ////////////////////////////////////////

            MySqlConnection cn3 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
            string sqll3 = " SELECT  * FROM class GROUP BY teacher ";
            MySqlCommand cmd3 = new MySqlCommand(sqll3, cn3);
            cn3.Open();

            MySqlDataReader reader3 = cmd3.ExecuteReader();


            while (reader3.Read())
            {
                comboBox3.Items.Add(reader3["teacher"].ToString());


            }
            cn3.Close();

        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                string valueTosearch = textBox1.Text.ToString();
                searchdata(valueTosearch);
                searchclass(valueTosearch);
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
            }
            if (textBox1.Text=="")
            {
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
            }
                
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try { 
            string up = "UPDATE dsddata." + comboBox1.Text.ToString() + comboBox2.Text.ToString() + comboBox3.Text.ToString() + " SET `phoneNumber`='" + textBox3.Text.ToString() + "'   WHERE studentNumber=" + int.Parse(textBox1.Text) + "";
            MySqlConnection co = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
            co.Open();

            try
            {

                MySqlCommand cmnd = new MySqlCommand(up, co);
                if (cmnd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("update sucssesfully");

                }
                else
                {
                    MessageBox.Show("not update data");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            co.Close();
        }
        catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
}

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
    }
}
