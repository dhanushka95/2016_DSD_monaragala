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
    public partial class DBSub : Form
    {
        string DataBase;
        string host;
        string password;
        string userName;
        
        int x;
        string sel1="";
        public DBSub(int y)
        {
            InitializeComponent();
            x = y;
        }

        private void DBSub_Load(object sender, EventArgs e)
        {
            try { 
            DataBase = Form1.DataBase;
            host = Form1.Host;
            password = Form1.Password;
            userName = Form1.UserName;


            MySqlConnection connecInYear = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
            string QuaryForGetYear = " SELECT  * FROM class GROUP BY year ";
            MySqlCommand commandForGetYear = new MySqlCommand(QuaryForGetYear, connecInYear);
            connecInYear.Open();

            MySqlDataReader ReaderForYear = commandForGetYear.ExecuteReader();


            while (ReaderForYear.Read())
            {
                cmbYear.Items.Add(ReaderForYear["year"].ToString());


            }
            connecInYear.Close();
            //////////////////////////////////////
            MySqlConnection connecInSubject = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
            string QuaryForGetSubject = " SELECT  * FROM class GROUP BY subject ";
            MySqlCommand commandForGetSubject = new MySqlCommand(QuaryForGetSubject, connecInSubject);
            connecInSubject.Open();

            MySqlDataReader ReaderForSubject = commandForGetSubject.ExecuteReader();


            while (ReaderForSubject.Read())
            {
                cmbSubject.Items.Add(ReaderForSubject["subject"].ToString());


            }
            connecInSubject.Close();

            ////////////////////////////////////////

            MySqlConnection connecInTeacher = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
            string QuaryForGetTeacher = " SELECT  * FROM class GROUP BY teacher ";
            MySqlCommand commandForGetTeacher = new MySqlCommand(QuaryForGetTeacher, connecInTeacher);
            connecInTeacher.Open();

            MySqlDataReader ReaderForTeacher = commandForGetTeacher.ExecuteReader();


            while (ReaderForTeacher.Read())
            {
                cmbTeacher.Items.Add(ReaderForTeacher["teacher"].ToString());


            }
            connecInTeacher.Close();


            //////////////////


            switch (x)
            {

                case 1:
                    sel1 = "";
                    break;
                case 2:
                    sel1 = "attendence";
                    break;
                case 3:
                    sel1 = "card";
                    break;
                case 4:
                    sel1 = "pay";
                    break;
                case 5:
                    cmbSubject.Visible = false;
                    cmbTeacher.Visible = false;
                    cmbYear.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    btnEnter.Visible = false;

                    sel1 = "class";
                    MySqlConnection con = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                    MySqlCommand cmd;
                    MySqlDataAdapter adptr;
                    DataTable table;

                    string sel = "SELECT * FROM `" + sel1 + "` ";
                    cmd = new MySqlCommand(sel, con);
                    adptr = new MySqlDataAdapter(cmd);
                    table = new DataTable();
                    adptr.Fill(table);
                    dataGridView1.DataSource = table;
                    break;
                default:
                    break;

            }
        }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                MySqlConnection con = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                MySqlCommand cmd;
                MySqlDataAdapter adptr;
                DataTable table;

                string sel = "SELECT * FROM `" + cmbYear.Text + cmbSubject.Text + cmbTeacher.Text + sel1 + "` ";
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
