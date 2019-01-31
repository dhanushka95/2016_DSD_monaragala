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
    public partial class DelectClassStudent : Form
    {
        string host;
        string password;
        string userName;
        string DataBase;
        public DelectClassStudent()
        {
            InitializeComponent();
        }
        private void searchclass(string valueTosearch)
        {
            try
            {
                MySqlConnection cn1 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                string sqll1 = " SELECT a.phoneNumber , b.Name,b.id,b.addres,b.batch FROM `" + cmbYear.Text.ToString() + cmbSubject.Text.ToString() + cmbTeacher.Text.ToString() + "` as `a` , `dsdstudentdetails` as `b` WHERE a.studentNumber LIKE '%" + valueTosearch + "%' AND b.studentNumber=a.studentNumber ";
                MySqlCommand cmd1 = new MySqlCommand(sqll1, cn1);
                cn1.Open();

                MySqlDataReader reader1 = cmd1.ExecuteReader();

                reader1.Read();

                txtn.Text = reader1["Name"].ToString();
                txtph.Text = reader1["phoneNumber"].ToString();
                txtaddress.Text = reader1["addres"].ToString();
                txtb.Text = reader1["batch"].ToString();
                txtid.Text = reader1["id"].ToString();
                btndelete.Enabled = true;
                progressBar1.Value = 1;
            }
            catch (Exception ex)
            {
                txtn.Clear();
                txtsn.Clear();
               txtaddress.Clear();
                txtid.Clear();
                txtb.Clear();
                txtph.Clear();
                btndelete.Enabled = false;
                MessageBox.Show("incorrect Student Number");

            }

        }

        
        private void DelectClassStudent_Load(object sender, EventArgs e)
        {
            try
            {
                btndelete.Enabled = false;
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
                   cmbYear.Items.Add(reader1["year"].ToString());


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
                    cmbSubject.Items.Add(reader2["subject"].ToString());


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
                   cmbTeacher.Items.Add(reader3["teacher"].ToString());


                }
                cn3.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtsn_TextChanged(object sender, EventArgs e)
        {
            if (txtsn.Text != "")
            {
                string valueTosearch = txtsn.Text.ToString();
               
                searchclass(valueTosearch);
               
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string min = cmbYear.Text.ToString() + cmbSubject.Text.ToString() + cmbTeacher.Text.ToString();
            try
            {
                MySqlConnection connection = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                string s = "DELETE FROM  "+min+ " WHERE studentNumber='"+txtsn.Text.ToString()+ "'; DELETE FROM  " + min + "attendence  WHERE studentNumber='" + txtsn.Text.ToString() + "'; DELETE FROM  " + min + "card  WHERE studentNumber='" + txtsn.Text.ToString() + "'";

                MySqlCommand c = new MySqlCommand(s, connection);
                connection.Open();
                if (c.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("delete sucses");
                }
                else
                {
                  //  MessageBox.Show("not sucses");
                }
                connection.Close();
                progressBar1.Value = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtph_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
