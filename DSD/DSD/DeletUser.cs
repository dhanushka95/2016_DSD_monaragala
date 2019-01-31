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
    public partial class DeletUser : Form
    {
        string host;
        string password;
        string userName;
        
        string DataBase;
        public DeletUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                string s = "DELETE FROM  login WHERE username='" +txtUserName.Text +"'  AND  password='" +txtPassword.Text + "' ";

                MySqlCommand c = new MySqlCommand(s, connection);
                connection.Open();
                if (c.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("delete sucses");
                }
                else
                {
                    MessageBox.Show("not sucses");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtPassword.Text = "";
            txtUserName.Text = "";
        }

        private void DeletUser_Load(object sender, EventArgs e)
        {
            try {
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
    }
}
