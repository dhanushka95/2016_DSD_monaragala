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
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;
using System.Media;
using System.Net.NetworkInformation;
using System.Net.Mail;

namespace DSD
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
            
        }
        string DataBase;
        string host;
        string password;
        string userName;
        
        string path = Application.StartupPath.ToString();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        string monthsCheck = DateTime.Now.ToString("MM");
        string YearsCheck = DateTime.Now.ToString("yyyy");
        string YearMonth = DateTime.Now.ToString("yyyy-MM");
        private void Audio(int x) {
            try { 
            WMPLib.WindowsMediaPlayer AudioSet = new WMPLib.WindowsMediaPlayer();


            switch (x)
            {
                case 1:
                    AudioSet.URL = path + @"\dhanushka\mesg_ting.mp3";
                    AudioSet.controls.play();
                    Thread.Sleep(500);
                    break;
                case 2:
                    AudioSet.URL = path + @"\dhanushka\alerto.mp3";
                    AudioSet.controls.play();
                    Thread.Sleep(500);
                    break;
                case 3:
                    AudioSet.URL = path + @"\dhanushka\alert.mp3";
                    AudioSet.controls.play();
                    Thread.Sleep(500);
                    break;

            }
        } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
}
        private void CheackAttendance(String Read) {
            lblWorning.Text = ".";
            if (rbCheck.Checked==true) {
                lblName.Visible = true;
                lblNa.Visible = true;
            int y = 0;
               // string[] array = Read.Split('-');
                try
                {

                    //  if (array[0]+"-"+array[1]==cmbYear.Text+"-"+ DateTime.Now.ToString("yyyy"))
                    if (txtRead.Text !="")
                    { 

                    string updtAttendance = "UPDATE dsddata." + cmbYear.Text.ToString() + cmbSubject.Text.ToString() + cmbTeacher.Text.ToString() + "attendence  SET `" + date + "`='1'   WHERE BarCodeValue=" +  txtRead.Text.ToString() + "";

                    string QuaryCheckAttendnsAlredyExist = "SELECT * FROM " + cmbYear.Text + cmbSubject.Text + cmbTeacher.Text + "attendence  WHERE `BarCodeValue`=" +txtRead.Text.ToString();

                    MySqlConnection connectionForkAttendnsAlredyExist = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                    MySqlCommand cmdForkAttendnsAlredyExist = new MySqlCommand(QuaryCheckAttendnsAlredyExist, connectionForkAttendnsAlredyExist);
                    connectionForkAttendnsAlredyExist.Open();

                    MySqlDataReader ReaderForkAttendnsAlredyExist = cmdForkAttendnsAlredyExist.ExecuteReader();


                    while (ReaderForkAttendnsAlredyExist.Read())
                    {
                        string x = ReaderForkAttendnsAlredyExist[date].ToString();
                        y = int.Parse(x);

                    }
                    if (y == 1)
                    {
                        

                        txtRead.Text = "";

                          
                            Audio(3);
                            // MessageBox.Show("alrady Exist");
                            lblWorning.Text = "Warning..already Exist Card";

                        }
                    else
                    {
                        MySqlConnection conectForUpdateAttendance = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                        conectForUpdateAttendance.Open();
                        MySqlCommand cmndAttendance = new MySqlCommand(updtAttendance, conectForUpdateAttendance);
                        if (cmndAttendance.ExecuteNonQuery() == 1)
                        {
                              //  if (int.Parse(monthsCheck)<=int.Parse(array[2])) {
                                   // MessageBox.Show("update sucssesfully");
                                    txtRead.Text = "";
                                   
                            //        Audio(1);

                              //  }
                               // else
                              //  {
                                  //  MessageBox.Show("update sucssesfully but not this munth card have");
                               //     txtRead.Text = "";
                                    
                                  //  Audio(2);

                              //  }

                        }
                        else
                        {
                                txtRead.Text = "";
                               
                                Audio(3);
                                // MessageBox.Show("not update data");
                                lblWorning.Text = "Barcode Not Exist";

                            }
                        conectForUpdateAttendance.Close();

                    }

                }
                    else
                    {
                        txtRead.Text = "";
                        Audio(3);
                        // MessageBox.Show("Card Is Not Valied");
                        lblWorning.Text = "Barcode Can't Read";
                    }
                    ///////
                    string quaryForDisplayName= "SELECT D.Name,D.studentNumber FROM dsdstudentdetails AS D ," + cmbYear.Text.ToString() + cmbSubject.Text.ToString() + cmbTeacher.Text.ToString() + "attendence  AS A WHERE D.studentNumber=A.studentNumber AND A.BarCodeValue='"+Read+"' ";
                    MySqlConnection connecForGetName = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                    
                    MySqlCommand commandForGetName= new MySqlCommand(quaryForDisplayName, connecForGetName);
                    connecForGetName.Open();

                    MySqlDataReader ReaderForGetName = commandForGetName.ExecuteReader();


                    while (ReaderForGetName.Read())
                    {
                    lblNa.Text = ReaderForGetName["Name"].ToString();
                    lblSN.Text = ReaderForGetName["studentNumber"].ToString();
                    lblS.Text = cmbSubject.Text;

                        if (lblSN.Text=="")
                        {
                            txtRead.Text = "";
                            Audio(3);
                            //  MessageBox.Show("Can't be desplay name");
                            lblWorning.Text = "Can't be desplay name";
                        }


                    }
                    connecForGetName.Close();
                    //////////////////
                    string QuaryDate = "";
                    string quaryForCheckMonth = "SELECT * FROM " + cmbYear.Text.ToString() + cmbSubject.Text.ToString() + cmbTeacher.Text.ToString() + "card WHERE `studentNumber`= '"+lblSN.Text+"' ";
                    MySqlConnection connecForCheckMonth = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");

                    MySqlCommand commandForCheckMonth = new MySqlCommand(quaryForCheckMonth, connecForCheckMonth);
                    connecForCheckMonth.Open();

                    MySqlDataReader ReaderForCheckMonth = commandForCheckMonth.ExecuteReader();
                    

                    while (ReaderForCheckMonth.Read())
                    {
                        QuaryDate = ReaderForCheckMonth["Month"].ToString();
                     

                    }
                    connecForCheckMonth.Close();
                    if (QuaryDate!="") {
                        string[] array = QuaryDate.Split('-');
                        if (int.Parse(monthsCheck) <= int.Parse(array[1]) && int.Parse(YearsCheck) <= int.Parse(array[0]))
                        {
                            Audio(1);
                        }
                        else
                        {
                            Audio(2);
                        }
                    }
                    else if(QuaryDate == "")
                    {
                        Audio(1);
                    }

                }
            catch (Exception ex)
            {

                    txtRead.Text = "";

            }
                
        }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            try { 
            txtRead.Focus();



            rbIssu.Checked = true;
            btnIssu.Visible = false;
            lblUpdate.Visible = false;
            txtCurrent.Visible = false;
            DataBase = Form1.DataBase;
            host = Form1.Host;
            password = Form1.Password;
            userName = Form1.UserName;

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
        } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
}

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtRead_TextChanged(object sender, EventArgs e)
        {
           
                  

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRead.Focus();
            btnSet.Visible = true;
            btnCheck.Visible = false;
        }

        private void rbIssu_CheckedChanged(object sender, EventArgs e)
        {
            lblWorning.Text = ".";
            txtCurrent.Visible =false;
            cmbYear.Visible = true;
            cmbSubject.Visible = true;
            cmbTeacher.Visible = true;
            lblYear.Visible = true;
            
            lblTeacher.Visible = true;
            lblIssuSN.Visible = true;
            lblIssuLM.Visible = true;
            txtStudentNo.Visible = true;
            txtLastMonth.Visible = true;
            btnIssu.Visible = false;
            btnCheck.Visible = true;
            lblBarcode.Visible = true;

            lblNa.Visible = false;
            lblName.Visible = false;
            
            


        }

        private void rbCheck_CheckedChanged(object sender, EventArgs e)
        {
            lblWorning.Text = ".";
            txtRead.Focus();
            txtRead.Text = "";
            txtCurrent.Visible = false;
            lblSubject.Visible = true;
            lblS.Visible = true;
            btnCheck.Visible = false;
            lblUpdate.Visible = false;
            btnSet.Visible = false;
            cmbYear.Visible = false;
            cmbSubject.Visible = false;
            cmbTeacher.Visible = false;
            lblYear.Visible = false;
            lblSubj.Visible = false;
            lblTeacher.Visible = false;
            lblIssuSN.Visible = false;
            lblIssuLM.Visible = false;
            txtStudentNo.Visible = false;
            txtLastMonth.Visible = false;
            btnIssu.Visible = false;
            lblBarcode.Visible = false;

            
        }

        private void txtStudentNo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRead.Focus();
            btnSet.Visible = true;
            btnCheck.Visible = false;
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRead.Focus();
            btnSet.Visible = true;
            btnCheck.Visible = false;
        }

        private void txtLastMonth_TextChanged(object sender, EventArgs e)
        {
            txtRead.Focus();
        }

        private void btnIssu_Click(object sender, EventArgs e)
        {
            txtRead.Focus();

            try
            {
                string TAB = "";
                if (txtCurrent.Text!="") {
                    string[] CheckThisOrAfterOrBeforMonth = txtCurrent.Text.Split('-');
                    if (int.Parse(CheckThisOrAfterOrBeforMonth[0] + CheckThisOrAfterOrBeforMonth[1]) == int.Parse(YearsCheck + monthsCheck))
                    {
                        TAB = "This";

                    } else if (int.Parse(CheckThisOrAfterOrBeforMonth[0] + CheckThisOrAfterOrBeforMonth[1]) < int.Parse(YearsCheck + monthsCheck))
                    {
                        TAB = "Before";
                    }
                    else
                    {
                        TAB = "After";
                    }
                }
                else
                {
                    TAB = "Free Card";
                }
                // string[] array = txtRead.Text.Split('-');
                string array = txtRead.Text.ToString();
                string upBarcode = "UPDATE dsddata." + cmbYear.Text.ToString() + cmbSubject.Text.ToString() + cmbTeacher.Text.ToString() + "attendence  SET `BarCodeValue`='"+array+ "'   WHERE studentNumber=" + int.Parse(txtStudentNo.Text) + "";
                string up = "UPDATE dsddata." + cmbYear.Text.ToString() + cmbSubject.Text.ToString() + cmbTeacher.Text.ToString() + "card  SET `Month`='" + txtCurrent.Text.ToString() + "'   WHERE studentNumber=" + int.Parse(txtStudentNo.Text) + "";
                string InsertPay = "INSERT INTO  `"+cmbYear.Text.ToString() + cmbSubject.Text.ToString() + cmbTeacher.Text.ToString()+ "pay`  (`studentNumber`,`"+YearMonth.ToString()+"`)  VALUES  ('"+txtStudentNo.Text.ToString()+"','"+TAB+txtCurrent.Text.ToString()+"')";
               
                MySqlConnection conectForInsertPay = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                MySqlConnection conectForUpdateCardDate = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                MySqlConnection conectForUpdateBarcode = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");

                conectForUpdateCardDate.Open();
                conectForUpdateBarcode.Open();
                conectForInsertPay.Open();

                 MySqlCommand cmndDate = new MySqlCommand(up, conectForUpdateCardDate);
                 MySqlCommand cmndBarCode = new MySqlCommand(upBarcode, conectForUpdateCardDate);
                MySqlCommand cmndInsertPay = new MySqlCommand(InsertPay, conectForInsertPay);
                MySqlDataReader readerInsertPay = cmndInsertPay.ExecuteReader();

                readerInsertPay.Read();
                conectForInsertPay.Close();
                if (cmndDate.ExecuteNonQuery() == 1&& cmndBarCode.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("update sucssesfully");

                }
                else
                {
                    MessageBox.Show("not update data");

                }
                conectForUpdateCardDate.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally { 

            ;
                txtStudentNo.Text = "";
                txtLastMonth.Text = "";
                txtCurrent.Text = "";
                lblUpdate.Visible = false;
                txtCurrent.Visible = false;
                btnIssu.Visible = false;
                
        }

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
           
            btnCheck.Visible = true;

            if (cmbYear.Text == "" || cmbSubject.Text == "" || cmbTeacher.Text == "")
            {
                MessageBox.Show("pleace fill the data");
            }
            else
            {
                try
                {

                    string AddColumn = "ALTER TABLE " + cmbYear.Text + cmbSubject.Text + cmbTeacher.Text + "attendence " + "  ADD `" + date + "` INT(10) NOT NULL";
                    string AddColumnPay = "ALTER TABLE " + cmbYear.Text + cmbSubject.Text + cmbTeacher.Text + "pay " + "  ADD `" + YearMonth + "` CHAR(20) NOT NULL";

                    MySqlConnection connec = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                    MySqlCommand cmd = new MySqlCommand(AddColumn, connec);
                    MySqlConnection connecPay = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                    MySqlCommand cmdPay = new MySqlCommand(AddColumnPay, connecPay);

                    connec.Open();
                    connecPay.Open();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("New Coumn Add attendance");

                    }
                    connec.Close();
                    if (cmdPay.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("New Coumn Add pay");

                    }

                    connecPay.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
                finally {
                    
                    btnSet.Visible = false;
                    txtRead.Focus();

                }

            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            
            txtRead.Focus();
            txtLastMonth.Text = "";
            lblUpdate.Visible = true;
            txtCurrent.Visible = true;
            txtCurrent.Text = DateTime.Now.ToString("yyyy-MM-dd");
            btnIssu.Visible = true;
            try
            {
                
                string QuaryReadMonth = "SELECT * FROM " + cmbYear.Text + cmbSubject.Text + cmbTeacher.Text +"card  WHERE `studentNumber`=" + txtStudentNo.Text;
                MySqlConnection connec = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                MySqlCommand cmd = new MySqlCommand(QuaryReadMonth, connec);
                connec.Open();

                MySqlDataReader ReaderForMonth = cmd.ExecuteReader();

             
                while (ReaderForMonth.Read())
                {
                   
                    txtLastMonth.Text= ReaderForMonth["Month"].ToString();
                    lblSN.Text=ReaderForMonth["studentNumber"].ToString();
                    
                  

                }
                connec.Close();
                lblS.Text = cmbSubject.Text;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCurrent_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void rbAuto_CheckedChanged(object sender, EventArgs e)
        {
            txtRead.Focus();
        }

        private void txtRead_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtRead.Focus();

            if (e.KeyChar == (char)Keys.Enter)
            {
                CheackAttendance(txtRead.Text);
                e.Handled = true;

            }

            

        }

        private void txtRead_DoubleClick(object sender, EventArgs e)
        {
            txtRead.Text = cmbYear.Text +  "-" + DateTime.Now.ToString("yyyy") + "-";
        }
    }
}
