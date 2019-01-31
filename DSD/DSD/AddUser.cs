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
    public partial class AddUser : Form
    {
        string DataBase;
        string host;
        string password;
        string userName;
        
        public AddUser(string y)
        {
            InitializeComponent();
            if (y=="0")
            {
                chkAdmin.Visible = false;
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            try {
                DataBase = Form1.DataBase;
                btnAdd.Enabled = false;
                label3.ForeColor = System.Drawing.Color.Red;
                chkAdmin.Checked = false;
                host = Form1.Host;
                password = Form1.Password;
                userName = Form1.UserName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string x = "0";
            try {
                if (chkAdmin.Checked ==true)
                {
                    x = "1";
                }
                MySqlConnection cn1 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                string Query = "INSERT INTO `login` (`username`, `password`, `Value`)  VALUES ('" + txtUserName.Text + "','" + txtComform.Text + "','" +x+ "')";
                MySqlCommand cmd = new MySqlCommand(Query, cn1);
                cn1.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();
                MessageBox.Show("Complete");
                cn1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void txtComform_TextChanged(object sender, EventArgs e)
        {
            try {
                if (txtComform.Text != "")
                {

                    if (txtPassword.Text == txtComform.Text)
                    {
                        label3.ForeColor = System.Drawing.Color.Black;
                        btnAdd.Enabled = true;

                    }
                    else
                    {
                        label3.ForeColor = System.Drawing.Color.Red;
                        btnAdd.Enabled = false;
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    }
}
