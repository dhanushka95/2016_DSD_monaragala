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
     
    public partial class Form1 : Form
    {
        public static string Host;
        public static string Password;
        public static string UserName;
       
        public static string DataBase;
        public Form1()
        {
            InitializeComponent();
        }
        private void entr()
        {
            try
            {
                //MySqlConnection con = new MySqlConnection("host=" + Host + ";user=" + UserName + ";password=" + Password + ";database=dsddata;");
                //MySqlConnection con = new MySqlConnection("server=192.168.1.2;user id=root;password=;database=dsddata;persistsecurityinfo=True");
                MySqlConnection con = new MySqlConnection("server=" + Host + ";user id=" + UserName+ ";password=" +Password + ";database=" + DataBase + "");

                string sqll = " Select Count(*),Value From dsddata.login where USERname = '" + txtUserName.Text + "' and password = '" + txtPassword.Text + "'";
                 MySqlCommand cmd = new MySqlCommand(sqll, con);
                con.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                
               
                if (reader["Count(*)"].ToString()=="1")
                {
                    this.Hide();
                    Main form1 = new Main(reader["Value"].ToString());
                    form1.Show();
                }
                else
                {
                    MessageBox.Show("user name or password error");
                }
                con.Close();
            }
            catch(MySqlException ex)
            {
                ConfigrationMysql ccm = new ConfigrationMysql();
                MessageBox.Show(ex.Message);
                ccm.Show();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void serverDetails()
        {
            try { 
            string path = Application.StartupPath.ToString();

            ////////////////////////////////////////////////
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr = new StreamReader(path + @"\dhanushka\host.txt"))
            {
                string line;

                // Read and display lines from the file until 
                // the end of the file is reached. 
                while ((line = sr.ReadLine()) != null)
                {
                    sb.Append(line);
                }
            }
            Host = sb.ToString();
            //////////////////////////////////////////////////////
            StringBuilder sb1 = new StringBuilder();
            using (StreamReader sr1 = new StreamReader(path + @"\dhanushka\Password.txt"))
            {
                string line;

                // Read and display lines from the file until 
                // the end of the file is reached. 
                while ((line = sr1.ReadLine()) != null)
                {
                    sb1.Append(line);
                }
            }
            Password = sb1.ToString();

            ///////////////////////////////////////////////////////////
            StringBuilder sb2 = new StringBuilder();
            using (StreamReader sr2 = new StreamReader(path + @"\dhanushka\UserName.txt"))
            {
                string line;

                // Read and display lines from the file until 
                // the end of the file is reached. 
                while ((line = sr2.ReadLine()) != null)
                {
                    sb2.Append(line);
                }
            }
            UserName = sb2.ToString();
            ///////////////////////////////////////////////////////////
            StringBuilder sb3 = new StringBuilder();
            using (StreamReader sr3 = new StreamReader(path + @"\dhanushka\DataBase.txt"))
            {
                string line;

                // Read and display lines from the file until 
                // the end of the file is reached. 
                while ((line = sr3.ReadLine()) != null)
                {
                    sb3.Append(line);
                }
            }
            DataBase = sb3.ToString();
        }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        private void Form1_Load(object sender, EventArgs e)
        {
            lblPassword.Hide();
            serverDetails();
            lblHostName.Text = Host;
            lblUserName.Text = UserName;
            lblDataBase.Text = DataBase;
            lblPassword.Text = Password;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {   entr();
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                
                
                    entr();
                
               
                e.Handled = true;
                
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                Application.Exit();
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPassword.Focus();
                e.Handled = true;

            }
            if (e.KeyChar==(char)Keys.Escape)
            {
                Application.Exit();
                e.Handled = true;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                Application.Exit();
                e.Handled = true;
            }
        }
    }
}
