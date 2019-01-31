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
using System.Threading;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Mail;

namespace DSD
{
    public partial class marks : Form
    {
        string DataBase;
        string host;
        string password;
        string userName;
        string FromPhone;
        string MyPssword;
        MySqlDataAdapter adptr;
        DataTable table;
        
        public marks()
        {
            InitializeComponent();
        }



        private void btnclick_Click(object sender, EventArgs e)
        {
            try { 
            string quary;
            MySqlConnection con = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
            MySqlCommand cmd;


            if (rddaily.Checked == true)
            {

                // btnsend.Enabled = true;
                quary = "SELECT b.phoneNumber,b.studentNumber,k.name, 1 + (SELECT count(*) from `" + cmbYear.Text + cmbSubject.Text + cmbTeacher.Text + "`  a WHERE a.`" + txtPaperNo.Text + "` > b.`" + txtPaperNo.Text + "`) as Rank,   `" + txtPaperNo.Text + "` as Marks FROM " + cmbYear.Text + cmbSubject.Text + cmbTeacher.Text + " as b ,dsdstudentdetails as k WHERE k.studentNumber=b.studentNumber ORDER BY Rank ASC";
                // quary = "SELECT s.studentNumber,s.name,s.`"+ textBox1.Text +"`,d.phoneNumber FROM " + comboBox1.Text + comboBox2.Text + comboBox3.Text + " AS s ,dsdstudentdetails AS d WHERE s.studentNumber=d.studentNumber";

                // quary = "SELECT `studentNumber`,`name`,`"+textBox1.Text+"`  FROM " + comboBox1.Text + comboBox2.Text + comboBox3.Text + "";
                cmd = new MySqlCommand(quary, con);
                adptr = new MySqlDataAdapter(cmd);

            }

            else if (rdfinal.Checked == true)
            {
                btnsend.Enabled = false;
                quary = "CREATE TEMPORARY TABLE `temp` SELECT * FROM " + cmbYear.Text.ToString() + cmbSubject.Text.ToString() + cmbTeacher.Text.ToString() + " ;ALTER TABLE `temp` DROP `phoneNumber`; SELECT d.name,b.* FROM temp as b , dsdstudentdetails as d WHERE d.studentNumber=b.studentNumber ; DROP TABLE `temp`";

                //  quary = "SELECT b.studentNumber, d.name,`" + txtPaperNo.Text + "`  FROM " + cmbYear.Text + cmbSubject.Text + cmbTeacher.Text + " as b , dsdstudentdetails as d WHERE d.studentNumber=b.studentNumber ";
                cmd = new MySqlCommand(quary, con);
                adptr = new MySqlDataAdapter(cmd);

            }

            try
            {

                table = new DataTable();
                adptr.Fill(table);

                dataGridView1.DataSource = table;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void marks_Load(object sender, EventArgs e)
        {
            try { 
            rdfinal.Checked = true;
            txtPaperNo.Text = DateTime.Now.ToString("yyyy-MM") + "|";

            DataBase = Form1.DataBase;
            host = Form1.Host;
            password = Form1.Password;
            userName = Form1.UserName;
                ////////////////////////////////////


                string path = Application.StartupPath.ToString();
                StringBuilder sb = new StringBuilder();
                using (StreamReader sr = new StreamReader(path + @"\dhanushka\FromPhone.txt"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        sb.Append(line);
                    }
                }
                FromPhone = sb.ToString();
                ///////////////////////////////////////
                StringBuilder sb1 = new StringBuilder();

                using (StreamReader sr1 = new StreamReader(path + @"\dhanushka\MyPssword.txt"))
                {
                    string line1;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line1 = sr1.ReadLine()) != null)
                    {
                        sb1.Append(line1);
                    }
                }
                MyPssword = sb1.ToString();

                /////////////////////////////////////////////

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

        private void btnsend_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 60;
            try { 
            btnsend.Visible = false;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                txtmsg.Clear();
                txtPhoneNumber.Clear();
                txtmsgCount.Clear();
                try
                {
                    if (dataGridView1.Rows[i].Cells[4].Value.ToString() != "0")
                    {
                        txtmsg.AppendText("-------DSD-------");
                        txtmsg.AppendText("\r\nStudent No: " + dataGridView1.Rows[i].Cells[1].Value);
                        txtmsg.AppendText("\r\nName :" + dataGridView1.Rows[i].Cells[2].Value);
                        txtmsg.AppendText("\r\nSubject :" + cmbSubject.Text);
                        txtmsg.AppendText("\r\nPaper :" + txtPaperNo.Text);
                        txtmsg.AppendText("\r\nMark      : " + dataGridView1.Rows[i].Cells[4].Value);
                        txtmsg.AppendText("\r\nRank      : " + dataGridView1.Rows[i].Cells[3].Value);
                        txtPhoneNumber.AppendText(dataGridView1.Rows[i].Cells[0].Value + "");

                        SendMessage(txtPhoneNumber.Text, txtmsg.Text);

                        i = i + 1;
                        txtmsgCount.AppendText("" + i);
                        i = i - 1;
                    }
                }
                catch (Exception ex)
                {

                    lblError.Items.Add(dataGridView1.Rows[i].Cells[0].Value);
                }


            }
        }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            progressBar1.Value = 100;
}

        private void txterrorNo_TextChanged(object sender, EventArgs e)
        {

        }
        private void SendMessage(string Phone, string msg) {
           
           
            
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            client.QueryString.Add("id", FromPhone);
            client.QueryString.Add("pw", MyPssword);
            client.QueryString.Add("to", Phone);
            client.QueryString.Add("text", msg);
            string baseurl = "http://www.textit.biz/sendmsg";
            Stream data = client.OpenRead(baseurl);
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            data.Close();
            reader.Close();
        
        }

        private void chkMSGTrue_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMSGTrue.Checked==true)
            {
                
                btnsend.Enabled = true;
            }
            else
            {
                
                btnsend.Enabled = false;
            }
        }

        private void rddaily_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {

                saveFileDialog1.Title = "Save as Excel File";
                saveFileDialog1.FileName = "";
                saveFileDialog1.Filter = "Excel Files(2003)|*.xls|Excel Files(2007)|*.xls";
                if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                    ExcelApp.Application.Workbooks.Add(Type.Missing);
                    ExcelApp.Columns.ColumnWidth = 20;
                    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                    {
                        ExcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;

                    }
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }

                    }
                    ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                    ExcelApp.ActiveWorkbook.Saved = true;
                    ExcelApp.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rdfinal_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
