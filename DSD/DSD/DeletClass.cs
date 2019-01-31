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
    public partial class DeletClass : Form
    {
        string DataBase;
        string host;
        string password;
        string userName;
        
        public DeletClass()
        {
            InitializeComponent();
        }
        private void searchdata()
        {
            try
            {
                MySqlConnection conee = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                MySqlCommand cmd;
                MySqlDataAdapter adptr;
                DataTable table;

                string sel;
                sel = "SELECT * FROM `class` WHERE `year`='" + txtyear.Text.ToString() + "' AND  `subject`='" + txtsubjec.Text.ToString() + "' AND `teacher` = '" + txtteacher.Text.ToString() + "' ";
                cmd = new MySqlCommand(sel, conee);
                conee.Open();
                adptr = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adptr.Fill(table);
                dataGridView1.DataSource = table;
                conee.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            searchdata();
            btndelet.Enabled = true;
        }

        private void DeletClass_Load(object sender, EventArgs e)
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

        private void btndelet_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value = 40; 
                MySqlConnection conee1= new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                MySqlCommand cmd1;
                // MySqlDataAdapter adptr2;
                //DataTable table2;

                string sel1;
                sel1 = "DELETE FROM `class` WHERE year='"+txtyear.Text.ToString()+"' AND subject='"+txtsubjec.Text.ToString()+"' AND teacher='"+txtteacher.Text.ToString()+"' ";
                cmd1 = new MySqlCommand(sel1, conee1);
                conee1.Open();
                MySqlDataReader reader1 = cmd1.ExecuteReader();

                reader1.Read();

                conee1.Close();

                progressBar1.Value = 60;
                /////////////////////////////////////////////////

                MySqlConnection conee2 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                MySqlCommand cmd2;
                // MySqlDataAdapter adptr2;
                //DataTable table2;

                string sel2;
                sel2 = "DROP TABLE `"+txtyear.Text.ToString()+txtsubjec.Text.ToString()+txtteacher.Text.ToString()+"` ";
                cmd2 = new MySqlCommand(sel2, conee2);
                conee2.Open();
                MySqlDataReader reader2 = cmd2.ExecuteReader();

                reader2.Read();

                conee2.Close();
                progressBar1.Value = 70;
                ///////////////////////
                string sel3;
                sel3 = "DROP TABLE `" + txtyear.Text.ToString() + txtsubjec.Text.ToString() + txtteacher.Text.ToString() + "pay` ";
                cmd2 = new MySqlCommand(sel3, conee2);
                conee2.Open();
                MySqlDataReader reader3 = cmd2.ExecuteReader();

                reader3.Read();

                conee2.Close();
                progressBar1.Value = 75;
                //////////////////
                string sel4;
                sel4 = "DROP TABLE `" + txtyear.Text.ToString() + txtsubjec.Text.ToString() + txtteacher.Text.ToString() + "card` ";
                cmd2 = new MySqlCommand(sel4, conee2);
                conee2.Open();
                MySqlDataReader reader4 = cmd2.ExecuteReader();

                reader4.Read();

                conee2.Close();
                progressBar1.Value = 78;
                ///////////////////////
                string sel5;
                sel5 = "DROP TABLE `" + txtyear.Text.ToString() + txtsubjec.Text.ToString() + txtteacher.Text.ToString() + "attendence` ";
                cmd2 = new MySqlCommand(sel5, conee2);
                conee2.Open();
                MySqlDataReader reader5 = cmd2.ExecuteReader();

                reader5.Read();

                conee2.Close();
                progressBar1.Value = 79;
                ///////////////////////
                String QuaryForDeletRowInClass = "DELETE FROM  class WHERE year='"+ txtyear.Text + "'  AND subject='"+ txtsubjec.Text + "' And  teacher='"+ txtteacher.Text + "'";
                MySqlConnection ConectionForDeletRowsInClass = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                MySqlCommand CommandForDeletRowInClass = new MySqlCommand(QuaryForDeletRowInClass, ConectionForDeletRowsInClass);
                ConectionForDeletRowsInClass.Open();
                MySqlDataReader ReadCommand = CommandForDeletRowInClass.ExecuteReader();
                ReadCommand.Read();
                ConectionForDeletRowsInClass.Close();

                btndelet.Enabled = false;
                btncheck.PerformClick();
                progressBar1.Value = 80;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            progressBar1.Value = 100;
        }

        private void txtsubjec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                txtsubjec.Text = txtsubjec.Text.ToString() + "_";
                e.Handled = true;

            }
        }

        private void txtteacher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                txtteacher.Text = txtteacher.Text.ToString() + "_";
                e.Handled = true;

            }
        }
    }
}
