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
    public partial class AddClassStudent : Form
    {

        string DataBase;
        string host;
        string password;
        string userName;
        
        public AddClassStudent()
        {
            InitializeComponent();
        }
        public void searchdata(string valueTosearch)
        {
            try {
                MySqlConnection cn = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                string sqll = " SELECT  * FROM `dsdstudentdetails`  WHERE studentNumber = " + valueTosearch + " ";
                MySqlCommand cmd = new MySqlCommand(sqll, cn);
                cn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();



                while (reader.Read())
                {
                    txtName.Text = reader["name"].ToString();
                    txtAddres.Text = reader["addres"].ToString();
                    txtPhoneNo.Text = reader["phoneNumber"].ToString();
                }
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddClassStudent_Load(object sender, EventArgs e)
        {
         
            try {

                DataBase = Form1.DataBase;
                host = Form1.Host;
                password = Form1.Password;
                userName = Form1.UserName;

                MySqlConnection cc1 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
            string cs1 = " SELECT  * FROM  class GROUP BY year ";
            MySqlCommand ccd1 = new MySqlCommand(cs1, cc1);
            cc1.Open();
            MySqlDataReader cr1 = ccd1.ExecuteReader();
            while (cr1.Read())
            {
                lbYear.Items.Add(cr1["year"].ToString());
            }
            cc1.Close();
               
               


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                lbTeacher.Items.Clear();
                MySqlConnection cc2 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                string cs2 = " SELECT  * FROM  class  WHERE `year`='" + lbYear.Text.ToString() + "' GROUP BY subject ";
                MySqlCommand cccd2 = new MySqlCommand(cs2, cc2);
                cc2.Open();
                MySqlDataReader cr2 = cccd2.ExecuteReader();
                while (cr2.Read())
                {

                    lbTeacher.Items.Add(cr2["subject"].ToString());

                }
                cc2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                lbSubject.Items.Clear();
                MySqlConnection cc33 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                string cs3 = " SELECT  * FROM  class WHERE `subject`='" + lbTeacher.Text.ToString() + "'  GROUP BY teacher ";
                MySqlCommand ccd3 = new MySqlCommand(cs3, cc33);
                cc33.Open();
                MySqlDataReader cr3 = ccd3.ExecuteReader();
                while (cr3.Read())
                {
                    lbSubject.Items.Add(cr3["teacher"].ToString());
                }
                cc33.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtStudentNo.Text != "")
            {
                string valueTosearch = txtStudentNo.Text.ToString();
                searchdata(valueTosearch);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            try {
                string valueTosearch = txtStudentNo.Text.ToString();
                searchdata(valueTosearch);

                if (txtStudentNo.Text == "")
                {
                    MessageBox.Show("pleace enter student number ");
                    this.Close();
                }


                string Query = "INSERT INTO `" + lbYear.Text.ToString() + lbTeacher.Text.ToString() + lbSubject.Text.ToString() + "` (phoneNumber,studentNumber) VALUES ('" + txtPhoneNo.Text + "','" + txtStudentNo.Text + "')";
                string quaryforinsertattendnce = "INSERT INTO `" + lbYear.Text.ToString() + lbTeacher.Text.ToString() + lbSubject.Text.ToString() + "attendence` (studentNumber)  VALUES ('" + txtStudentNo.Text + "')";
                string quaryforinsertcard = "INSERT INTO `" + lbYear.Text.ToString() + lbTeacher.Text.ToString() + lbSubject.Text.ToString() + "card` (studentNumber)  VALUES ('" + txtStudentNo.Text + "')";
              //  string quaryforinsertpay = "INSERT INTO `" + lbYear.Text.ToString() + lbTeacher.Text.ToString() + lbSubject.Text.ToString() + "pay` (studentNumber)  VALUES ('" + txtStudentNo.Text + "')";

            MySqlConnection con = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
            MySqlCommand cmd = new MySqlCommand(Query, con);
            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            con.Close();

                MySqlConnection conattendnce = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                MySqlCommand cmdattendnce = new MySqlCommand(quaryforinsertattendnce, conattendnce);
                conattendnce.Open();

                MySqlDataReader readerattendnce = cmdattendnce.ExecuteReader();

                readerattendnce.Read();
                conattendnce.Close();

                MySqlConnection concard = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                MySqlCommand cmdcard = new MySqlCommand(quaryforinsertcard, concard);
                concard.Open();

                MySqlDataReader readercard = cmdcard.ExecuteReader();

                readercard.Read();
                concard.Close();

              /*  MySqlConnection conpay = new MySqlConnection("host=" + host + ";port=" + port + ";user=" + userName + ";password=" + password + ";database=dsddata;");
                MySqlCommand cmdpay = new MySqlCommand(quaryforinsertpay, conpay);
                conpay.Open();

                MySqlDataReader readerpay = cmdpay.ExecuteReader();

                readerpay.Read();
                conpay.Close();*/
                /////////////////////////
                MySqlConnection con4 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                MySqlCommand cmd4;
                MySqlDataAdapter adptr4;
                DataTable table4;
                string sel;
                sel = "SELECT * FROM `" + lbYear.Text.ToString() + lbTeacher.Text.ToString() + lbSubject.Text.ToString() + "`  WHERE `studentNumber` LIKE '%" + valueTosearch + "%'";
                cmd4 = new MySqlCommand(sel, con4);
                con4.Open();
                adptr4 = new MySqlDataAdapter(cmd4);
                table4 = new DataTable();
                adptr4.Fill(table4);
                dataGridView1.DataSource = table4;
                con4.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
