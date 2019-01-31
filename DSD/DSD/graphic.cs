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
    public partial class graphic : Form
    {
        string DataBase;
        string host;
        string password;
        string userName;
        

        public graphic()
        {
            InitializeComponent();
        }


    

        private void graphic_Load(object sender, EventArgs e)
        {
           
            

            try {
                DataBase = Form1.DataBase;
                host = Form1.Host;
                password = Form1.Password;
                userName = Form1.UserName;
                textBox1.Text = DateTime.Now.ToString("yyyy-MM") + "|";
                radioButton1.Checked = true;
                MySqlConnection c1 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                string s1 = " SELECT  * FROM  class GROUP BY year ";
                MySqlCommand cd1 = new MySqlCommand(s1, c1);
                c1.Open();
                MySqlDataReader r1 = cd1.ExecuteReader();
                while (r1.Read())
                {
                    txtYear.Items.Add(r1["year"].ToString());                   
                }
                c1.Close();
                /////////////////////////////
                MySqlConnection c2 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                string s2 = " SELECT  * FROM  class GROUP BY subject ";
                MySqlCommand cd2 = new MySqlCommand(s2, c2);
                c2.Open();
                MySqlDataReader r2 = cd2.ExecuteReader();
                while (r2.Read())
                {
                    txtSubject.Items.Add(r2["subject"].ToString());
                }
                c2.Close();
                ///////////////////////////////
                MySqlConnection c33 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                string s3 = " SELECT  * FROM  class GROUP BY teacher ";
                MySqlCommand cd3 = new MySqlCommand(s3, c33);
                c33.Open();
                MySqlDataReader r3 = cd3.ExecuteReader();
                while (r3.Read())
                {
                    txtTeacher.Items.Add(r3["teacher"].ToString());
                }
                c33.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtYear.Enabled = false;
            txtSubject.Enabled = false;
            txtTeacher.Enabled = false;




            try
                {
                if (radioButton1.Checked == true)
                {
                    txtStudentNumber.Enabled = false;
                    MySqlConnection cn = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                    string sqll = " SELECT a.*,b.name FROM `" + txtYear.Text + txtSubject.Text + txtTeacher.Text + "` as `a`, `dsdstudentdetails` as `b` WHERE a.studentNumber = " + txtStudentNumber.Text + " AND b.studentNumber=a.studentNumber";
                    MySqlCommand cmd = new MySqlCommand(sqll, cn);
                    cn.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //SELECT a.*,b.name from `2014physicsdinusha` as `a`, `dsdstudentdetails` as `b` WHERE a.studentNumber='1' AND b.studentNumber=a.studentNumber

                    while (reader.Read())
                    {
                        textBox3.Text = reader["name"].ToString();
                        this.chart1.Series["marks"].Points.AddXY("" + textBox1.Text + "", reader["" + textBox1.Text + ""]);
                    }
                    cn.Close();

                }
                //////////////////////////////////////////////////////////////////////////////////////////////////
                if (radioButton2.Checked==true)
                {
                    MySqlConnection cne = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                    string sqlle = "SELECT AVG(`"+textBox1.Text+"`) AS `" + textBox1.Text + "`  FROM  `" + txtYear.Text + txtSubject.Text + txtTeacher.Text +"` ";
                    MySqlCommand cmde = new MySqlCommand(sqlle, cne);
                    cne.Open();
                    MySqlDataReader readere = cmde.ExecuteReader();



                    while (readere.Read())
                    {
                        
                        this.chart1.Series["marks"].Points.AddXY("" + textBox1.Text +"AVG"+ "", readere["" + textBox1.Text + ""]);
                    }
                    cne.Close();



                }
                /////////////////////////////////////////////////////////////////////////////////////////////////////
                if (radioButton3.Checked == true)
                {
                    MySqlConnection cnee = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                    string sqllee = "SELECT AVG(`" + textBox1.Text + "`) AS `" + textBox1.Text + "`  FROM  `" + txtYear.Text + txtSubject.Text + txtTeacher.Text + "` ";
                    MySqlCommand cmdee = new MySqlCommand(sqllee, cnee);
                    cnee.Open();
                    MySqlDataReader readeree = cmdee.ExecuteReader();



                    while (readeree.Read())
                    {

                        this.chart1.Series["marks"].Points.AddXY("" + textBox1.Text +"AVG"+ "", readeree["" + textBox1.Text + ""]);
                    }
                    cnee.Close();



                }



                //////////////////////////////////////////////////////////////////////////////////////////////////////
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Visible=false;
            txtStudentNumber.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

           
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            txtStudentNumber.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            txtStudentNumber.Enabled = true;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtYear.Enabled = true;
            txtSubject.Enabled = true;
            txtTeacher.Enabled = true;
            txtStudentNumber.Visible = false;
            textBox3.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
