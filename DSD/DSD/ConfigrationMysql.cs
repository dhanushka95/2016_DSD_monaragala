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
    public partial class ConfigrationMysql : Form
    {
        public ConfigrationMysql()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHost.Text!="" && txtDataBase.Text != "" && txtUserName.Text != "" )
                {
                    string path = Application.StartupPath.ToString();

                    FileInfo fileHost = new FileInfo(path + @"\dhanushka\host.txt");
                    File.WriteAllText(path + @"\dhanushka\host.txt", String.Empty);
                    using (StreamWriter swHost = fileHost.AppendText())
                    {

                        swHost.WriteLine(txtHost.Text);


                    }

                    FileInfo filePassword = new FileInfo(path + @"\dhanushka\Password.txt");
                    File.WriteAllText(path + @"\dhanushka\Password.txt", String.Empty);
                    using (StreamWriter swPassword = filePassword.AppendText())
                    {

                        swPassword.WriteLine(txtPassword.Text);


                    }
                    FileInfo filePort = new FileInfo(path + @"\dhanushka\DataBase.txt");
                    File.WriteAllText(path + @"\dhanushka\DataBase.txt", String.Empty);
                    using (StreamWriter swPort = filePort.AppendText())
                    {

                        swPort.WriteLine(txtDataBase.Text);


                    }
                    FileInfo fileUserName = new FileInfo(path + @"\dhanushka\UserName.txt");
                    File.WriteAllText(path + @"\dhanushka\UserName.txt", String.Empty);
                    using (StreamWriter swUserName = fileUserName.AppendText())
                    {

                        swUserName.WriteLine(txtUserName.Text);


                    }



                    MessageBox.Show("Update");
                }
                else
                {
                    MessageBox.Show("Fill date");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ConfigrationMysql_Load(object sender, EventArgs e)
        {

        }
    }
}
