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
    public partial class inputMarks : Form
    {
        string DataBase;
        string host;
        string password;
        string userName;
        
        public inputMarks()
        {
            InitializeComponent();
           
        }

        bool t = true;
        public void searchdata(string valueTosearch)
        {
            try { 
            MySqlConnection con = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
            MySqlCommand cmd;
            MySqlDataAdapter adptr;
            DataTable table;

            string sel;
            sel = "SELECT * FROM `" + cmbYear.Text + cmbSubject.Text + cmbTeacher.Text + "` WHERE `studentNumber` LIKE '%" + valueTosearch + "%'";
            cmd = new MySqlCommand(sel, con);
            con.Open();
            adptr = new MySqlDataAdapter(cmd);
            table = new DataTable();
            adptr.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
        }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        private void getYearsubjectteacher()
        {

            try { 
            MySqlConnection cc1 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
            string cs1 = " SELECT  * FROM  class GROUP BY year ";
            MySqlCommand ccd1 = new MySqlCommand(cs1, cc1);
            cc1.Open();
            MySqlDataReader cr1 = ccd1.ExecuteReader();
            while (cr1.Read())
            {
                cmbYear.Items.Add(cr1["year"].ToString());
            }
            cc1.Close();
            /////////////////////////////
            MySqlConnection cc2 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
            string cs2 = " SELECT  * FROM  class GROUP BY subject ";
            MySqlCommand cccd2 = new MySqlCommand(cs2, cc2);
            cc2.Open();
            MySqlDataReader cr2 = cccd2.ExecuteReader();
            while (cr2.Read())
            {
                cmbSubject.Items.Add(cr2["subject"].ToString());
            }
            cc2.Close();
            ///////////////////////////////
            MySqlConnection cc33 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
            string cs3 = " SELECT  * FROM  class GROUP BY teacher ";
            MySqlCommand ccd3 = new MySqlCommand(cs3, cc33);
            cc33.Open();
            MySqlDataReader cr3 = ccd3.ExecuteReader();
            while (cr3.Read())
            {
                cmbTeacher.Items.Add(cr3["teacher"].ToString());
            }
            cc33.Close();



        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



}
        private void inputMarks_Load(object sender, EventArgs e)
        {
            try { 
            txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtPaperNo.Text = DateTime.Now.ToString("yyyy-MM") + "|";

            btnInsert.Enabled = false;
            txtStudentNo.Enabled = false;
            txtMarks.Enabled = false;
            txtDate.Enabled = false;
            DataBase = Form1.DataBase;
            host = Form1.Host;
            password = Form1.Password;
            userName = Form1.UserName;


            getYearsubjectteacher();
        }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtStudentNo.Text == ""||txtMarks.Text=="")
            {
                MessageBox.Show("pleace enter studentn number and marks ");

            }else
            {
                try {
                    MySqlConnection cp = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                          string up = "UPDATE `"+ cmbYear.Text + cmbSubject.Text + cmbTeacher.Text +"` SET `" + txtPaperNo.Text + "` = " + double.Parse(txtMarks.Text) +"  WHERE `studentNumber`="+ int.Parse(txtStudentNo.Text) +"";
                          MySqlCommand cmdm = new MySqlCommand(up,cp);
                          cp.Open();
                    if (cmdm.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("data entry succsesfully");
                        if (chkbAutoIncrement.Checked == true)
                        {
                            txtMarks.Text = "";
                            txtStudentNo.Text = (int.Parse(txtStudentNo.Text) + 1).ToString();
                            txtMarks.Focus();
                        }
                        else
                        {
                            txtStudentNo.Text = "";
                            txtMarks.Text = "";
                        }
                        searchdata("");
                    }
                    else
                    {
                        MessageBox.Show("data entry NOT succsesfully");

                    }
                         cp.Clone();
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (cmbYear.Text == "" || cmbSubject.Text == "" || cmbTeacher.Text == "")
            {
                MessageBox.Show("pleace fill the data");
            }
            else {
                try {
                    string d = "ALTER TABLE " + cmbYear.Text + cmbSubject.Text + cmbTeacher.Text + " ADD `" + txtPaperNo.Text + "` DOUBLE NOT NULL";
                    MySqlConnection connec = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                    MySqlCommand cmd = new MySqlCommand(d, connec);
                    MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);

                    DataTable table = new DataTable();
                    adptr.Fill(table);
                    dataGridView1.DataSource = table;
                    button2.Enabled = false;

                }
                catch (Exception ex)
                {
                      MessageBox.Show(ex.Message);
                  
                 
                }
                btnInsert.Enabled = true;
                txtStudentNo.Enabled = true;
                txtMarks.Enabled = true;
               
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            searchdata("");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string valueTosearch = txtStudentNo.Text.ToString();
            searchdata(valueTosearch);
        }

        private void txtMarks_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (chkbAutoIncrement.Checked == true)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btnInsert.PerformClick();
                    e.Handled = true;

                }
            }
        }
    }
}
