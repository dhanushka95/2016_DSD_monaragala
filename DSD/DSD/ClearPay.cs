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
using System.Threading;
namespace DSD
{
    public partial class ClearPay : Form
    {
        string host;
        string password;
        string userName;

        string DataBase;
        public ClearPay()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try {
                progressBar1.Value = 40;

                MySqlConnection connection = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                string s = "DELETE FROM `center` WHERE  `chek`='1' ";

                MySqlCommand c = new MySqlCommand(s, connection);
                connection.Open();
                if (c.ExecuteNonQuery() == 1)
                {
                   // MessageBox.Show("delete sucses");
                }
                else
                {
                   // MessageBox.Show("not sucses");
                }
                connection.Close();
                progressBar1.Value = 100;
                Thread.Sleep(2000);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            
private void ClearPay_Load(object sender, EventArgs e)
        {
            try
            {
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
    

