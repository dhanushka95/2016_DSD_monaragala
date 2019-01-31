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
    public partial class NotGetCard : Form
    {
        string DataBase;
        string host;
        string password;
        string userName;
        
        public NotGetCard()
        {
            InitializeComponent();
        }

        private void NotGetCard_Load(object sender, EventArgs e)
        {
            try { 
            DataBase = Form1.DataBase;
            host = Form1.Host;
            password = Form1.Password;
            userName = Form1.UserName;


            /////////////////////////////////////

            MySqlConnection cn1 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
            string sqll1 = " SELECT  * FROM class GROUP BY year ";
            MySqlCommand cmd1 = new MySqlCommand(sqll1, cn1);
            cn1.Open();

            MySqlDataReader reader1 = cmd1.ExecuteReader();


            while (reader1.Read())
            {
                cmbYear.Items.Add(reader1["year"].ToString());


            }
            cn1.Close();


            //////////////////////////////////////
            MySqlConnection cn2 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
            string sqll2 = " SELECT  * FROM class GROUP BY subject ";
            MySqlCommand cmd2 = new MySqlCommand(sqll2, cn2);
            cn2.Open();

            MySqlDataReader reader2 = cmd2.ExecuteReader();


            while (reader2.Read())
            {
                cmbSubject.Items.Add(reader2["subject"].ToString());


            }
            cn2.Close();

            ////////////////////////////////////////

            MySqlConnection cn3 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
            string sqll3 = " SELECT  * FROM class GROUP BY teacher ";
            MySqlCommand cmd3 = new MySqlCommand(sqll3, cn3);
            cn3.Open();

            MySqlDataReader reader3 = cmd3.ExecuteReader();


            while (reader3.Read())
            {
                cmbTeacher.Items.Add(reader3["teacher"].ToString());


            }
            cn3.Close();
        }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                string quaryForGetStudent = "SELECT * FROM `dsdstudentdetails` WHERE `studentNumber` IN(SELECT A.studentNumber FROM `" + cmbYear.Text.ToString() + cmbSubject.Text.ToString() + cmbTeacher.Text.ToString() + "` A WHERE A.studentNumber NOT IN(SELECT B.studentNumber FROM `" + cmbYear.Text.ToString() + cmbSubject.Text.ToString() + cmbTeacher.Text.ToString() + "pay` B))";
                MySqlConnection con = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                MySqlCommand cmd = new MySqlCommand(quaryForGetStudent, con);
                MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adptr.Fill(table);
                dataGridView1.DataSource = table;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
