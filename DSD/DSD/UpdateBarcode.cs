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
    public partial class UpdateBarcode : Form
    {
        string host;
        string password;
        string userName;
        string DataBase;
        public UpdateBarcode()
        {
            InitializeComponent();
        }

        private void UpdateBarcode_Load(object sender, EventArgs e)
        {
            btnup.Enabled = false;
            txtnbv.Focus();
            try
            {
               
                DataBase = Form1.DataBase;
                host = Form1.Host;
                password = Form1.Password;
                userName = Form1.UserName;


                /////////////////////////////////////

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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {


                //////////////////////////////////////
                MySqlConnection cn1 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                string sqll1 = " SELECT  BarCodeValue  FROM  `"+cmbYear.Text.ToString()+cmbSubject.Text.ToString()+cmbTeacher.Text.ToString()+ "attendence"+ "`  WHERE `studentNumber`=" + txtsn.Text.ToString() + " ";
                MySqlCommand cmd1 = new MySqlCommand(sqll1, cn1);
                cn1.Open();

                MySqlDataReader reader1 = cmd1.ExecuteReader();


                while (reader1.Read())
                {
                    txtbv.Text = reader1["BarCodeValue"].ToString();
            

                }
                cn1.Close();
                btnup.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            txtnbv.Focus();
        }

        private void txtsn_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            if (txtsn.Text!=""&&txtnbv.Text!="")
            {
                try
                {
                    string up = "UPDATE  `" + cmbYear.Text.ToString() + cmbSubject.Text.ToString() + cmbTeacher.Text.ToString() + "attendence" + "` SET BarCodeValue='" + txtnbv.Text + "'  WHERE studentNumber=" +txtsn.Text+ "";
                    MySqlConnection co = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                    co.Open();

                    MySqlCommand cmnd = new MySqlCommand(up, co);
                    if (cmnd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("update successfully");
                        btnCheck.PerformClick();
                    }
                    else
                    {
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
                MessageBox.Show("Fill data or barcode value not exist");
            }
        }
    }
}
