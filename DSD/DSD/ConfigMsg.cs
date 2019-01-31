using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Mail;
namespace DSD
{
    public partial class ConfigMsg : Form
    {
        public ConfigMsg()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text!="" &&txtPassword.Text!="") {
                    string path = Application.StartupPath.ToString();
                    FileInfo filepss = new FileInfo(path + @"\dhanushka\MyPssword.txt");
                    File.WriteAllText(path + @"\dhanushka\MyPssword.txt", String.Empty);
                    using (StreamWriter sw = filepss.AppendText())
                    {

                        sw.WriteLine(txtPassword.Text);


                    }

                    FileInfo fileuser = new FileInfo(path + @"\dhanushka\FromPhone.txt");
                    File.WriteAllText(path + @"\dhanushka\FromPhone.txt", String.Empty);
                    using (StreamWriter swuser = fileuser.AppendText())
                    {

                        swuser.WriteLine(txtId.Text);


                    }
                    MessageBox.Show("Compleat");
                }
                else
                {
                    MessageBox.Show("please fill data");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConfigMsg_Load(object sender, EventArgs e)
        {

        }
    }
}
