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
using System.Text.RegularExpressions;
namespace DSD
{
    public partial class PaySheet : Form
    {
        string DataBase;
        string host;
        string password;
        string userName;
        
        public PaySheet()
        {
            InitializeComponent();
        }
        // string YearMonth = DateTime.Now.ToString("yyyy-MM");
        
        private void DisplayDb()
        {
            try {
                MySqlConnection con = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                MySqlCommand cmd;
                MySqlDataAdapter adptr;
                DataTable table;

                string sel = "SELECT `studentNumber`,`" + txty.Text.ToString() +"`  FROM `" + cmbYear.Text + cmbSubject.Text + cmbTeacher.Text + "pay`  WHERE  `"+txty.Text+ "`  LIKE 'T%' OR `" + txty.Text + "`  LIKE 'B%' OR `" + txty.Text + "`  LIKE 'A%' OR `" + txty.Text + "`  LIKE 'F%'";
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
        private void PaySheet_Load(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            try { 
                txty.Text= DateTime.Now.ToString("yyyy-MM");
              //  string monthsCheck = DateTime.Now.ToString("MM");
                DataBase = Form1.DataBase;
                host = Form1.Host;
            password = Form1.Password;
            userName = Form1.UserName;
            

          //  cmbm.Text = monthsCheck;
            //////////////////////////////////
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
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnChek_Click(object sender, EventArgs e)
        {
            if (txtPreseentagCenter.Text!=""&&txtCardAmount.Text != "") {
                try
                {
                    MySqlConnection connecforFreeCard = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                    string QuaryforFreeCard = " SELECT  COUNT(*) AS FreeCard FROM `" + cmbYear.Text + cmbSubject.Text + cmbTeacher.Text + "pay`  WHERE  `" + txty.Text.ToString() + "`  LIKE  'Free Card%' ";
                    MySqlCommand commandforFreeCard = new MySqlCommand(QuaryforFreeCard, connecforFreeCard);
                    connecforFreeCard.Open();

                    MySqlDataReader ReaderforFreeCard = commandforFreeCard.ExecuteReader();


                    while (ReaderforFreeCard.Read())
                    {
                        txtfree.Text = ReaderforFreeCard["FreeCard"].ToString();


                    }
                    connecforFreeCard.Close();

                    ////////////////////////////////////
                    MySqlConnection connecforCountMoth = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                    string QuaryforCountMoth = " SELECT  COUNT(*) AS ThisMonth FROM `" + cmbYear.Text + cmbSubject.Text + cmbTeacher.Text + "pay`  WHERE  `" + txty.Text.ToString() + "`  LIKE  'This%' ";
                    MySqlCommand commandforCountMoth = new MySqlCommand(QuaryforCountMoth, connecforCountMoth);
                    connecforCountMoth.Open();

                    MySqlDataReader ReaderforCountMoth = commandforCountMoth.ExecuteReader();


                    while (ReaderforCountMoth.Read())
                    {
                        txttm.Text = ReaderforCountMoth["ThisMonth"].ToString();


                    }
                    connecforCountMoth.Close();
                    ////////////////////////////////
                    MySqlConnection connecforCountBeforeMoth = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                    string QuaryforCountBeforeMoth = " SELECT  COUNT(*) AS BeforeMonth FROM `" + cmbYear.Text + cmbSubject.Text + cmbTeacher.Text + "pay`  WHERE  `" + txty.Text.ToString() + "`  LIKE  'Before%' ";
                    MySqlCommand commandforCountBeforeMoth = new MySqlCommand(QuaryforCountBeforeMoth, connecforCountBeforeMoth);
                    connecforCountBeforeMoth.Open();

                    MySqlDataReader ReaderforCountBeforeMoth = commandforCountBeforeMoth.ExecuteReader();


                    while (ReaderforCountBeforeMoth.Read())
                    {
                        txtbm.Text = ReaderforCountBeforeMoth["BeforeMonth"].ToString();


                    }
                    connecforCountBeforeMoth.Close();
                    /////////////////////////////////
                    MySqlConnection connecforCountAfterMoth = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                    string QuaryforCountAfterMoth = " SELECT  COUNT(*) AS AfterMonth FROM `" + cmbYear.Text + cmbSubject.Text + cmbTeacher.Text + "pay`  WHERE  `" + txty.Text.ToString() + "`  LIKE  'After%' ";
                    MySqlCommand commandforCountAfterMoth = new MySqlCommand(QuaryforCountAfterMoth, connecforCountAfterMoth);
                    connecforCountAfterMoth.Open();

                    MySqlDataReader ReaderforCountAfterMoth = commandforCountAfterMoth.ExecuteReader();


                    while (ReaderforCountAfterMoth.Read())
                    {
                        txtfm.Text = ReaderforCountAfterMoth["AfterMonth"].ToString();


                    }
                    connecforCountAfterMoth.Close();
                    DisplayDb();
                    txtt.Text = int.Parse(txttm.Text) + int.Parse(txtbm.Text) + int.Parse(txtfm.Text) + "";
                    txtTotalAmount.Text = double.Parse(txtt.Text) * (100 - double.Parse(txtPreseentagCenter.Text)) * double.Parse(txtCardAmount.Text) / 100 + "";
                    btnPrint.Enabled = true;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("fill data");
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            double centerAmount = double.Parse(txtt.Text) * double.Parse(txtPreseentagCenter.Text) * double.Parse(txtCardAmount.Text) / 100;
            try {
                string[] array = txty.Text.Split('-');
                MySqlConnection connectionForCenter = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                string QueryForCenter = "INSERT INTO `center` (`chek`,`year`,`Month`, `subjec`, `teacher`, `NoOfStudent`, `amount`)  VALUES ('0','" + cmbYear.Text.ToString() + "','" + array[1]+ "','" + cmbSubject.Text.ToString() + "','" +cmbTeacher.Text.ToString() + "','" + txtt.Text.ToString() + "','" + centerAmount.ToString()+ "')";
                MySqlCommand cmdForCenter = new MySqlCommand(QueryForCenter, connectionForCenter);
                connectionForCenter.Open();
                MySqlDataReader readerForCenter = cmdForCenter.ExecuteReader();

                readerForCenter.Read();

                connectionForCenter.Close();

                ///////////////////////////
                

                using (Print frmp = new Print(cmbYear.Text.ToString(), cmbSubject.Text.ToString(), cmbTeacher.Text.ToString(), array[1], txttm.Text.ToString(), txtbm.Text.ToString(), txtfm.Text.ToString(), txtt.Text.ToString(), txtTotalAmount.Text.ToString()))
                {
                    frmp.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
