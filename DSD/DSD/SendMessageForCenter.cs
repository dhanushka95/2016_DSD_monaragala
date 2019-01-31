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
    public partial class SendMessageForCenter : Form
    {
        string host;
        string password;
        string userName;

        string DataBase;
        string FromPhone;
        string MyPssword;
        public SendMessageForCenter()
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
        private void SendMessageForCenter_Load(object sender, EventArgs e)
        {
            try
            {

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

                //////////////////////

                MySqlConnection con = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                MySqlCommand cmd;
                MySqlDataAdapter adptr;
                DataTable table;

                string sel = "SELECT * FROM `dsdstudentdetails`";
                cmd = new MySqlCommand(sel, con);
                adptr = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adptr.Fill(table);
                dataGridView1.DataSource = table;
                btnSend.Enabled = false;
                chkbAllow.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbAllow.Checked == true)
            {
                btnSend.Enabled = true;
            }
            else
            {
                btnSend.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 60;
            ////////////
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                txtSelectNo.Clear();

                try
                {
                    if (dataGridView1.Rows[i].Cells[4].Value.ToString() != "0")
                    {
                        txtSelectNo.AppendText(dataGridView1.Rows[i].Cells[4].Value + "");

                        SendMessage(txtSelectNo.Text, txtMsg.Text);
                        Thread.Sleep(1000);
                        

                    }
                }
                catch (Exception ex)
                {
                   
                    lstError.Items.Add(dataGridView1.Rows[i].Cells[4].Value);
                }

                /////////////
            }
            progressBar1.Value = 100;
        }
    }
}
