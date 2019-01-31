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
    public partial class SentMessageForOther : Form
    {
        string FromPhone;
        string MyPssword;
        public SentMessageForOther()
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
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SentMessageForOther_Load(object sender, EventArgs e)
        {/////

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
            ///////////////
            btnSent.Enabled = false;
            chkbAllow.Checked = false;
            txtPhoneNo.Focus();
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
            foreach (string line in txtPhoneNo.Lines)
            {
                txtSelectNo.Clear();
                txtSelectNo.Text = line;
                try {
                    SendMessage(txtSelectNo.Text, txtText.Text);
                    Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    
                    lbError.Items.Add(line);
                }
            }
            progressBar1.Value = 100;
        }
    }
}
