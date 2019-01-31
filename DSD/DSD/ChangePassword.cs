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
    public partial class ChangePassword : Form
    {
        string DataBase;
        string host;
        string password;
        string userName;
        
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            try {
                DataBase = Form1.DataBase;
                btnUpdate.Enabled = false;
                label4.ForeColor = System.Drawing.Color.Red;
                host = Form1.Host;
                password = Form1.Password;
                userName = Form1.UserName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            if (txtComform.Text != "")
            {

                if (txtNewPasword.Text == txtComform.Text)
                {
                    label4.ForeColor = System.Drawing.Color.Black;
                    btnUpdate.Enabled = true;

                }
                else
                {
                    label4.ForeColor = System.Drawing.Color.Red;
                    btnUpdate.Enabled = false;
                }


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
            string up = "UPDATE dsddata.login  SET `password`='" + txtComform.Text.ToString() + "'   WHERE `username`= '" + txtUserName.Text.ToString() + "' AND  `password`= '" + txtPassword.Text.ToString() + "' ";
            MySqlConnection co = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
            co.Open();
            
                MySqlCommand cmnd = new MySqlCommand(up, co);
                if (cmnd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("update sucssesfully");

                }
                else
                {
                    MessageBox.Show("not Change Password");

                }
                co.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
           
        }
    }
}
