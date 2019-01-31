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
using System.Reflection;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;
using System.Net.Mail;

namespace DSD
{
    public partial class RankInStudent : Form
    {

        string DataBase;
        string host;
        string password;
        string userName;
        
        public RankInStudent()
        {
            InitializeComponent();
        }


        private void RankAndSend_Load(object sender, EventArgs e)
        {
            
            try
            {
                textBox2.Text = Application.StartupPath.ToString() + "\\";
                host = Form1.Host;
                password = Form1.Password;
                userName = Form1.UserName;

                DataBase = Form1.DataBase;
                ///////////////////////////
                textBox1.Text = DateTime.Now.ToString("yyyy-MM") + "|";

                MySqlConnection c1 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                string s1 = " SELECT  * FROM  class GROUP BY year ";
                MySqlCommand cd1 = new MySqlCommand(s1, c1);
                c1.Open();
                MySqlDataReader r1 = cd1.ExecuteReader();
                while (r1.Read())
                {
                    comboBox1.Items.Add(r1["year"].ToString());
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
                    comboBox2.Items.Add(r2["subject"].ToString());
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
                    comboBox3.Items.Add(r3["teacher"].ToString());
                }
                c33.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }




            ///////////////////////////////////////////

        }

        private void btnrank_Click(object sender, EventArgs e)
        {
            

            try
            {
                MySqlConnection con = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                MySqlCommand cmd;
                MySqlDataAdapter adptr;
                DataTable table;
                string quary = "SELECT b.studentNumber,k.name, 1 + (SELECT count(*) from `" + comboBox1.Text + comboBox2.Text + comboBox3.Text + "`  a WHERE a.`" + textBox1.Text + "` > b.`" + textBox1.Text + "`) as Rank,   `" + textBox1.Text + "` as Marks FROM " + comboBox1.Text + comboBox2.Text + comboBox3.Text + " as b , dsdstudentdetails as k WHERE k.studentNumber=b.studentNumber";

                cmd = new MySqlCommand(quary, con);
                adptr = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adptr.Fill(table);
                dataGridView1.DataSource = table;
                con.Close();
                btnsend.Enabled = true;
                btnExcel.Enabled = true;
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            try
            {
                PdfPTable pdftable = new PdfPTable(dataGridView1.ColumnCount);
                pdftable.DefaultCell.Padding = 3;
                pdftable.WidthPercentage = 60;
                pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdftable.DefaultCell.BorderWidth = 1;

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));

                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdftable.AddCell(cell);


                }




                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            pdftable.AddCell(cell.Value.ToString());
                        }
                    }


                }
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result==DialogResult.OK) {
                    textBox2.Text = folderBrowserDialog1.SelectedPath;
                string fileName = DateTime.Now.ToString("yyyy-MM-dd") + comboBox3.Text.ToString() + ".pdf";
                string Folderpath = textBox2.Text;
                if (!Directory.Exists(Folderpath))
                {
                    Directory.CreateDirectory(Folderpath);
                }
                using (FileStream stream = new FileStream(Folderpath + fileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    Paragraph p = new Paragraph("----------------" + "" + comboBox1.Text + "" + "--" + "" + comboBox2.Text + "" + "---" + "" + textBox1.Text + "" + "--------------");
                    p.Alignment = Element.ALIGN_CENTER;
                    Paragraph k = new Paragraph("  ");
                    pdfDoc.Add(p);
                    pdfDoc.Add(k);
                    pdfDoc.Add(pdftable);
                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show(fileName + " create....location is " + Folderpath);


                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
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
                    for (int i = 1; i < dataGridView1.Columns.Count+1; i++)
                    {
                        ExcelApp.Cells[1, i] = dataGridView1.Columns[i-1].HeaderText;

                    }
                   for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
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
    }
}
