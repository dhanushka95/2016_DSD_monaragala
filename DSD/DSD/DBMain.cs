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
    public partial class DBMain : Form
    {
        string DataBase;
        string host;
        string password;
        string userName;
        
        public DBMain()
        {
            InitializeComponent();
        }

        private void DBMain_Load(object sender, EventArgs e)
        {
            try {
                DataBase = Form1.DataBase;
                host = Form1.Host;
                password = Form1.Password;
                userName = Form1.UserName;


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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
    }
}
