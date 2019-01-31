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
    public partial class Main :Form
    {
        string host;
        string password;
        string userName;
        
        string DataBase;
        string FileName;
        string values;
        string path = Application.StartupPath.ToString();
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        public Main(string value)
        {
           
            values = value;
            InitializeComponent();
           // progressBar1.Width = this.Width;

            if (value=="0")
            {

                ribbonButton2.Enabled = false;
                ribbonButton5.Enabled = false;
                ribbonButton33.Enabled = false;
                ribbonButton4.Enabled = false;
                ribbonButton9.Enabled = false;
                ribbonButton34.Enabled = false;
                ribbonButton16.Enabled = false;
                ribbonTab2.Visible = false;
                ribbonTab4.Visible = false;
                ribbonTab6.Visible = false;
                btnsnd.Visible = false;
                btnImport.Visible = false;

            }
            

        }

        private void Main_Load(object sender, EventArgs e)
        {
            try {
                FileName = DateTime.Now.ToString("yyyy-MM-dd"); ;
                host = Form1.Host;
                password = Form1.Password;
                userName = Form1.UserName;

                DataBase = Form1.DataBase;
                lblfilePath.Text = path + @"\dhanushka\backup\" + FileName + "";


                t.Interval = 30000;
                t.Tick += new EventHandler(timer1_Tick);
                t.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbnAddStudent_Click(object sender, EventArgs e)
        {
            StudentAdd studentadd = new StudentAdd();
            studentadd.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            btnBackup.PerformClick();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            t.Stop();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lblfilePath.Text = openFileDialog1.FileName;



                try
                {

                    MySqlConnection cnnection = new MySqlConnection("server=" + host + ";user id=" + userName+ ";password=" + password + ";database=" + DataBase +"");
                    MySqlCommand command = new MySqlCommand();
                    MySqlBackup bk = new MySqlBackup(command);
                    command.Connection = cnnection;

                    cnnection.Open();
                    bk.ImportFromFile(lblfilePath.Text);
                    cnnection.Close();
                    progressBar1.Value = 0;
                    progressBar1.Value = 100;

                    MessageBox.Show("Data Import Complite");
                    t.Start();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                t.Start();
                MessageBox.Show("Not Import Data");
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            t.Start();

            try
            {
                lblfilePath.Text = path+ @"\dhanushka\backup\" + FileName + "";
                MySqlConnection cnnection = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                MySqlCommand command = new MySqlCommand();
                MySqlBackup bk = new MySqlBackup(command);
                command.Connection = cnnection;
                progressBar1.Value = 0;
                progressBar1.Value = 40;
                cnnection.Open();
                progressBar1.Value = 70;
                bk.ExportToFile(lblfilePath.Text);
                progressBar1.Value = 90;
                cnnection.Close();
                progressBar1.Value = 100;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            t.Stop();
            Application.Exit();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void deletStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void inputMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void rankStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void marksGraphicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sendMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void deletClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void studentAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void updateStudensToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void updateClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void genarateBarcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cheackCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void teachersBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deletUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void attendanseToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void getCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void paidToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void classToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void teachersTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void configrationMSGToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void configrationMToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void workerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            StudentAdd studentAdd = new StudentAdd();
            studentAdd.Show();
        }

        private void ribbonButton4_Click(object sender, EventArgs e)
        {

            update UpdateStudent = new update();
            UpdateStudent.Show();
        }

        private void ribbonButton3_Click(object sender, EventArgs e)
        {
            details StudentDetails = new details();
            StudentDetails.Show();
        }

        private void ribbonButton5_Click(object sender, EventArgs e)
        {
            delet StudentDelet = new delet();
            StudentDelet.Show();
        }

        private void ribbonButton6_Click(object sender, EventArgs e)
        {

            inputMarks inputMarksStudents = new inputMarks();
            inputMarksStudents.Show();
        }

        private void ribbonButton7_Click(object sender, EventArgs e)
        {
            RankInStudent StudentRank = new RankInStudent();
            StudentRank.Show();
        }

        private void ribbonButton8_Click(object sender, EventArgs e)
        {
            graphic GraphMarks = new graphic();
            GraphMarks.Show();
        }

        private void ribbonButton9_Click(object sender, EventArgs e)
        {
            marks SendMarks = new marks();
            SendMarks.Show();
        }

        private void ribbonButton10_Click(object sender, EventArgs e)
        {
            AddClass ClassAdd = new AddClass();
            ClassAdd.Show();
        }

        private void ribbonButton12_Click(object sender, EventArgs e)
        {

            DeletClass classDelet = new DeletClass();
            classDelet.Show();
        }

        private void ribbonButton13_Click(object sender, EventArgs e)
        {
            AddClassStudent AddStudentIntoClass = new AddClassStudent();
            AddStudentIntoClass.Show();
        }

        private void ribbonButton14_Click(object sender, EventArgs e)
        {
            UpdateClassStudent UpdateClassstudent = new UpdateClassStudent();
            UpdateClassstudent.Show();
        }

        private void ribbonButton11_Click(object sender, EventArgs e)
        {

            UpdateClass ClassUpdate = new UpdateClass();
            ClassUpdate.Show();
        }

        private void ribbonButton16_Click(object sender, EventArgs e)
        {
            BarcodeGenaret barcode = new BarcodeGenaret();
            barcode.Show();
        }

        private void ribbonButton15_Click(object sender, EventArgs e)
        {
            Attendance atendnc = new Attendance();
            atendnc.Show();
        }

        private void ribbonButton17_Click(object sender, EventArgs e)
        {
            PaySheet pay = new PaySheet();
            pay.Show();
        }

        private void ribbonButton18_Click(object sender, EventArgs e)
        {
            PaySheetForCenter pfc = new PaySheetForCenter();
            pfc.Show();
        }

        private void ribbonButton19_Click(object sender, EventArgs e)
        {
            NotGetCard nc = new NotGetCard();
            nc.Show();
        }

        private void wToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ribbonButton20_Click(object sender, EventArgs e)
        {
            DBMain DBMain = new DBMain();
            DBMain.Show();
        }

        private void ribbonButton21_Click(object sender, EventArgs e)
        {
            DBSub dbs = new DBSub(2);
            dbs.Show();
        }

        private void ribbonButton22_Click(object sender, EventArgs e)
        {
            DBSub dbs = new DBSub(3);
            dbs.Show();
        }

        private void ribbonButton23_Click(object sender, EventArgs e)
        {
            DBSub dbs = new DBSub(4);
            dbs.Show();
        }

        private void ribbonButton24_Click(object sender, EventArgs e)
        {
            DBSub dbs = new DBSub(1);
            dbs.Show();
        }

        private void ribbonButton25_Click(object sender, EventArgs e)
        {

            DBSub dbs = new DBSub(5);
            dbs.Show();
        }

        private void ribbonButton26_Click(object sender, EventArgs e)
        {
            AddUser addusr = new AddUser(values);
            addusr.Show();
        }

        private void ribbonButton27_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.Show();
        }

        private void ribbonButton28_Click(object sender, EventArgs e)
        {
            DeletUser deletuser = new DeletUser();
            deletuser.Show();
        }

        private void ribbonButton29_Click(object sender, EventArgs e)
        {
            ConfigMsg msg = new ConfigMsg();
            msg.Show();
        }

        private void ribbonButton30_Click(object sender, EventArgs e)
        {
            ConfigrationMysql cm = new ConfigrationMysql();
            cm.Show();
        }

        private void ribbonButton31_Click(object sender, EventArgs e)
        {
            ClearPay cp = new ClearPay();
            cp.Show();
        }

        private void ribbonButton33_Click(object sender, EventArgs e)
        {
            SendMessageForCenter s = new SendMessageForCenter();
            s.Show();
        }

        private void ribbonButton32_Click(object sender, EventArgs e)
        {
            DelectClassStudent dcs = new DelectClassStudent();
            dcs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SentMessageForOther smfo = new SentMessageForOther();
            smfo.Show();
        }

        private void ribbonButton34_Click(object sender, EventArgs e)
        {
            UpdateBarcode ub = new UpdateBarcode();
            ub.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DelectClassStudent dcs = new DelectClassStudent();
            dcs.Show();
        }

        private void ribbonButton35_Click(object sender, EventArgs e)
        {
            SentMsgForClass sfc = new SentMsgForClass();
            sfc.Show();
        }
    }
}
