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
using System.Threading;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Mail;

namespace DSD
{
    public partial class SentMsgForClass : Form
    {
        string host;
        string password;
        string userName;

        string DataBase;
        string FromPhone;
        string MyPssword;
        public SentMsgForClass()
        {
            InitializeComponent();
        }
        private void SendMessage(string Phone, string msg)
        {

            
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            client.QueryString.Add("id", FromPhone);
            client.QueryString.Add("pw", MyPssword);
            client.QueryString.Add("to", Phone);
            client.QueryString.Add("text", msg);
            string baseurl = "http://www.textit.biz/sendmsg";
            Stream data = client.OpenRead(baseurl);
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            data.Close();
            reader.Close();

        }
        private void SentMsgForClass_Load(object sender, EventArgs e)
        {
            try {
                btnSearch.Enabled = false;
               btnSent.Enabled = false;
                chkbAllow.Checked = false;
                chkbAllow.Checked = false;
                btnSent.Enabled = false;
                DataBase = Form1.DataBase;
                host = Form1.Host;
                password = Form1.Password;
                userName = Form1.UserName;
                ////////////////


                string path = Application.StartupPath.ToString();
                StringBuilder sb = new StringBuilder();
                using (StreamReader sr = new StreamReader(path + @"\dhanushka\FromPhone.txt"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        sb.Append(line);
                    }
                }
                FromPhone = sb.ToString();
                ///////////////////////////////////////
                StringBuilder sb1 = new StringBuilder();

                using (StreamReader sr1 = new StreamReader(path + @"\dhanushka\MyPssword.txt"))
                {
                    string line1;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line1 = sr1.ReadLine()) != null)
                    {
                        sb1.Append(line1);
                    }
                }
                MyPssword = sb1.ToString();

                /////////////////////////////////////////////

                //////////////////////////////////
                MySqlConnection connecInYear = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                string QuaryForGetYear = " SELECT  * FROM class GROUP BY year ";
                MySqlCommand commandForGetYear = new MySqlCommand(QuaryForGetYear, connecInYear);
                connecInYear.Open();

                MySqlDataReader ReaderForYear = commandForGetYear.ExecuteReader();


                while (ReaderForYear.Read())
                {
                    cmbYear.Items.Add(ReaderForYear["year"].ToString());


                }
                connecInYear.Close();
                //////////////////////////////////////
                MySqlConnection connecInSubject = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                string QuaryForGetSubject = " SELECT  * FROM class GROUP BY subject ";
                MySqlCommand commandForGetSubject = new MySqlCommand(QuaryForGetSubject, connecInSubject);
                connecInSubject.Open();

                MySqlDataReader ReaderForSubject = commandForGetSubject.ExecuteReader();


                while (ReaderForSubject.Read())
                {
                    cmbSubject.Items.Add(ReaderForSubject["subject"].ToString());


                }
                connecInSubject.Close();

                ////////////////////////////////////////

                MySqlConnection connecInTeacher = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                string QuaryForGetTeacher = " SELECT  * FROM class GROUP BY teacher ";
                MySqlCommand commandForGetTeacher = new MySqlCommand(QuaryForGetTeacher, connecInTeacher);
                connecInTeacher.Open();

                MySqlDataReader ReaderForTeacher = commandForGetTeacher.ExecuteReader();


                while (ReaderForTeacher.Read())
                {
                    cmbTeacher.Items.Add(ReaderForTeacher["teacher"].ToString());


                }
                connecInTeacher.Close();
                btnSearch.Enabled = true;

            }
            catch (Exception ex)
            {

            }
          
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {


                MySqlConnection con = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                MySqlCommand cmd;
                MySqlDataAdapter adptr;
                DataTable table;

                string sel = "SELECT  studentNumber,phoneNumber FROM `" + cmbYear.Text.ToString()+ cmbSubject.Text.ToString() + cmbTeacher.Text.ToString() + "`";
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

        private void chkbAllow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbAllow.Checked == true)
            {
               btnSent.Enabled = true;
            }
            else
            {
                btnSent.Enabled = false;
            }
        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 60;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                txtSelectNo.Clear();

                try
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() != "0")
                    {
                        txtSelectNo.AppendText(dataGridView1.Rows[i].Cells[1].Value + "");

                        SendMessage(txtSelectNo.Text, txtText.Text);
                        Thread.Sleep(1000);


                    }
                }
                catch (Exception ex)
                {

                    lbError.Items.Add(dataGridView1.Rows[i].Cells[1].Value);
                }

                /////////////
            }
            progressBar1.Value = 100;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbError_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
