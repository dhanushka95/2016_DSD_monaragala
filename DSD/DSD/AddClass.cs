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
    public partial class AddClass : Form
    {
        string DataBase;
        string host;
        string password;
        string userName;
       
        public AddClass()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void searchdata(string valueTosearch)
        {
            try {
                MySqlConnection c = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                MySqlCommand cmd;
                MySqlDataAdapter adptr;
                DataTable table;

                string sel = "SELECT * FROM `class` WHERE `year` LIKE '%" + valueTosearch + "%'";
                cmd = new MySqlCommand(sel, c);
                adptr = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adptr.Fill(table);
                dataGridView1.DataSource = table;
                c.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddClass_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            prograsbarAdd1.Value =0;
            if (txtName.Text != "" && txtSubject.Text != "" && txtYear.Text != "")
            {
                try
                {
                    MySqlConnection cn1 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                    string Query = "INSERT INTO `class` (`year`, `subject`, `teacher`)  VALUES ('" + txtYear.Text + "','" + txtSubject.Text + "','" + txtName.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(Query, cn1);
                    cn1.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    reader.Read();
                    string valueTosearch = txtYear.Text.ToString();
                    searchdata(valueTosearch);
                    cn1.Close();


                searchdata("");
                string q = "CREATE TABLE `dsddata`.`" + txtYear.Text.ToString() + txtSubject.Text.ToString() + txtName.Text.ToString() + "` ( `phoneNumber` CHAR(10) NOT NULL ,`studentNumber` INT(100) NOT NULL ,PRIMARY KEY(`studentNumber`), FOREIGN KEY(`studentNumber`) REFERENCES dsdstudentdetails(`studentNumber`))";
                string createpay = "CREATE TABLE `dsddata`.`" + txtYear.Text.ToString() + txtSubject.Text.ToString() + txtName.Text.ToString() + "pay`  (`studentNumber` INT(10) NOT NULL )";
                string creatAtendance = "CREATE TABLE `dsddata`.`" + txtYear.Text.ToString() + txtSubject.Text.ToString() + txtName.Text.ToString() + "attendence`  (`BarCodeValue`  CHAR(50) NOT NULL,`studentNumber` CHAR(100) NOT NULL,PRIMARY KEY(`BarCodeValue`,`studentNumber`) )";
                string creatCard = "CREATE TABLE `dsddata`.`" + txtYear.Text.ToString() + txtSubject.Text.ToString() + txtName.Text.ToString() + "card` (`studentNumber` INT(10) NOT NULL ,`Month` CHAR(20) NOT NULL,PRIMARY KEY(`studentNumber`), FOREIGN KEY(`studentNumber`) REFERENCES dsdstudentdetails(`studentNumber`))";
                   
                try
                    {
                      //  Boolean cmB= true;
                      //  Boolean  cmpB= true;
                      //  Boolean cmaB= true;
                       // Boolean  cmcB = true;
                        MySqlConnection cn2 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                    MySqlCommand cmd2 = new MySqlCommand(q, cn2);

                    MySqlConnection cn2forpay = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                    MySqlCommand cmd2forpay = new MySqlCommand(createpay, cn2forpay);

                    MySqlConnection cn2forAtendance = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                    MySqlCommand cmd2forAtendance = new MySqlCommand(creatAtendance, cn2forAtendance);

                    MySqlConnection cn2forCard = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                    MySqlCommand cmd2forCard = new MySqlCommand(creatCard, cn2forCard);

                   
                   
                   
                    
                        cn2.Open();
                        if (cmd2.ExecuteNonQuery() == 1 )
                            {
                              //  MessageBox.Show("Add Table: 1");
                                cn2.Close();
                                //cmB = false;
                              //  prograsbarAdd1.Value = 25+ prograsbarAdd1.Value;
                            }
                        cn2forpay.Open();
                        if (cmd2forpay.ExecuteNonQuery() == 1 )
                            {
                             //   MessageBox.Show("Add Table: 2");
                                cn2forpay.Close();
                              //  cmpB = false;
                             //   prograsbarAdd1.Value = 25 + prograsbarAdd1.Value;
                            }
                        cn2forAtendance.Open();
                        if (cmd2forAtendance.ExecuteNonQuery() == 1 )
                            {
                           //     MessageBox.Show("Add Table: 3");
                                cn2forAtendance.Close();
                              //  cmaB = false;
                             //   prograsbarAdd1.Value = 25 + prograsbarAdd1.Value;
                            }
                        cn2forCard.Open();
                        if (cmd2forCard.ExecuteNonQuery() == 1 )
                            {
                             //   MessageBox.Show("Add Table:4 ");
                                cn2forCard.Close();
                               // cmcB = false;
                           //     prograsbarAdd1.Value = 25 + prograsbarAdd1.Value;
                            }

                        prograsbarAdd1.Value = 100;


                    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
                MessageBox.Show("pleace fill all text");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            searchdata("");
        }

        private void btnYear_TextChanged(object sender, EventArgs e)
        {
            string valueTosearch = txtYear.Text.ToString();
            searchdata(valueTosearch);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSubject_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                 txtSubject.Text = txtSubject.Text.ToString()+"_";
                 e.Handled = true;
                
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                txtName.Text = txtName.Text.ToString() + "_";
                e.Handled = true;

            }
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                txtYear.Text = txtYear.Text.ToString() + "_";
                e.Handled = true;

            }
        }
    }
}
