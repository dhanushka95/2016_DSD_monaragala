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
using System.Net.NetworkInformation;
using System.Net.Mail;
namespace DSD
{
    public partial class PaySheetForCenter : Form
    {
        string DataBase;
        string host;
        string password;
        string userName;
       
        public PaySheetForCenter()
        {
            InitializeComponent();
        }

        private void PaySheetForCenter_Load(object sender, EventArgs e)
        {
            try {
                DataBase = Form1.DataBase;
                host = Form1.Host;
                password = Form1.Password;
                userName = Form1.UserName;

               // cmbMonth.Text = DateTime.Now.ToString("MM");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            double amount = 0.0;
            if (cmbMonth.Text != "")
            {
                MySqlConnection connecInCenter = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                string QuaryForCenter = " SELECT  * FROM center WHERE Month='" + cmbMonth.Text.ToString() + "' AND chek='0' ";
                MySqlCommand commandForCenter = new MySqlCommand(QuaryForCenter, connecInCenter);
                connecInCenter.Open();

                MySqlDataReader ReaderForYear = commandForCenter.ExecuteReader();


                while (ReaderForYear.Read())
                {

                    txtv.AppendText("\r\n" + ReaderForYear["teacher"].ToString());
                    txtv.AppendText("  Rs:" + ReaderForYear["amount"].ToString() + "\r\n");
                    amount = double.Parse(ReaderForYear["amount"].ToString()) + amount;
                }
                connecInCenter.Close();

                txtv.AppendText("\r\n----------------------");
                txtv.AppendText("\r\n Total Amount = Rs " + amount);
                txtv.AppendText("\r\n=============");
                }
        }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void btnIssu_Click(object sender, EventArgs e)
        {
            try {
                

                    string up = "UPDATE  dsddata.center SET `chek`='1'  WHERE  `Month`='"+cmbMonth.Text.ToString()+ "' AND `chek`='0'";


                    MySqlConnection conectForCenter = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                    conectForCenter.Open();
                    MySqlCommand cmndAttendance = new MySqlCommand(up, conectForCenter);
                cmndAttendance.ExecuteNonQuery();
                    

                        Print p = new Print(txtv.Text.ToString());
                        p.Show();
                  
                    conectForCenter.Close();
                    

                
             
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
