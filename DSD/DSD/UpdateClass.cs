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
    public partial class UpdateClass : Form
    {
        string host;
        string password;
        string userName;
        string DataBase;
        public UpdateClass()
        {
            InitializeComponent();
        }
        private void searchdata()
        {
            try {
                MySqlConnection conee = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                MySqlCommand cmd;
                MySqlDataAdapter adptr;
                DataTable table;

                string sel;
                sel = "SELECT * FROM `class` WHERE `year`='" + txtyear.Text.ToString() + "' AND  `subject`='" + txtSubject.Text.ToString() + "' AND `teacher` = '" + txtTeacher.Text.ToString() + "' ";
                cmd = new MySqlCommand(sel, conee);
                conee.Open();
                adptr = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adptr.Fill(table);
                dataGridView1.DataSource = table;
                conee.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            searchdata();
             txtYearNew.Text= txtyear.Text;
             txtTeacherNew.Text= txtTeacher.Text;
             txtSubjecNew.Text= txtSubject.Text;
            txtSubject.Enabled = false;
            txtTeacher.Enabled = false;
            txtyear.Enabled = false;
            btnSearch.Enabled = false;
        }

        private void UpdateClass_Load(object sender, EventArgs e)
        {
            try {
                host = Form1.Host;
                password = Form1.Password;
                userName = Form1.UserName;
                DataBase = Form1.DataBase;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtyear_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 40;
            try
            {
                MySqlConnection conee = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                MySqlCommand cmd;
                MySqlDataAdapter adptr;
                DataTable table;
                string min = txtyear.Text.ToString() + txtSubject.Text.ToString() + txtTeacher.Text.ToString();
                string newmin = txtYearNew.Text.ToString() + txtSubjecNew.Text.ToString() + txtTeacherNew.Text.ToString();
                string sel;
                sel = "UPDATE class SET subject='"+txtSubjecNew.Text.ToString()+"' , year = '"+txtYearNew.Text.ToString()+"' , teacher='"+txtTeacherNew.Text.ToString()+ "' WHERE `year`='" + txtyear.Text.ToString() + "' AND  `subject`='" + txtSubject.Text.ToString() + "' AND `teacher` = '" + txtTeacher.Text.ToString() + "'";
                cmd = new MySqlCommand(sel, conee);
                conee.Open();
                adptr = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adptr.Fill(table);
                dataGridView1.DataSource = table;
                conee.Close();
                progressBar1.Value = 70;
                ////////////////////////////////////
                MySqlConnection conee2 = new MySqlConnection("server=" + host + ";user id=" + userName + ";password=" + password + ";database=" + DataBase + "");
                MySqlCommand cmd2;
               // MySqlDataAdapter adptr2;
                //DataTable table2;

                string sel2;
                sel2 = "RENAME TABLE `"+min+"` TO `"+newmin+ "`;RENAME TABLE `" + min+ "attendence` TO `" + newmin + "attendence`;RENAME TABLE `" + min + "card` TO `" + newmin + "card`;RENAME TABLE `" + min + "pay` TO `" + newmin + "pay`";
                cmd2 = new MySqlCommand(sel2, conee2);
                conee2.Open();
                MySqlDataReader reader2 = cmd2.ExecuteReader();

                reader2.Read();

                conee2.Close();

                
                ///////////////////////////////////////
                txtyear.Text = txtYearNew.Text;
                txtTeacher.Text = txtTeacherNew.Text;
                txtSubject.Text = txtSubjecNew.Text;
                btnSearch.Enabled = true;
               btnSearch.PerformClick();
                btnSearch.Enabled = false;
                progressBar1.Value = 100;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }

        private void txtTeacher_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtyear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                txtyear.Text =txtyear.Text.ToString() + "_";
                e.Handled = true;

            }
        }

        private void txtSubject_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                txtSubject.Text = txtSubject.Text.ToString() + "_";
                e.Handled = true;

            }
        }

        private void txtTeacher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                txtTeacher.Text = txtTeacher.Text.ToString() + "_";
                e.Handled = true;

            }
        }

        private void txtYearNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                txtYearNew.Text = txtYearNew.Text.ToString() + "_";
                e.Handled = true;

            }
        }

        private void txtSubjecNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                txtSubjecNew.Text = txtSubjecNew.Text.ToString() + "_";
                e.Handled = true;

            }
        }

        private void txtTeacherNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                txtTeacherNew.Text = txtTeacherNew.Text.ToString() + "_";
                e.Handled = true;

            }
        }
    }
}
