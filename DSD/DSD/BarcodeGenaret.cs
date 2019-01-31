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
using System.Drawing.Imaging;
using MessagingToolkit.Barcode;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Net.NetworkInformation;
using System.Net.Mail;
namespace DSD
{
    public partial class BarcodeGenaret : Form
    {
        string DataBase;
        string host;
        string password;
        string userName;
        
        public BarcodeGenaret()
        {
            InitializeComponent();
        }

        BarcodeEncoder Genarate;
        


        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BarcodeGenaret_Load(object sender, EventArgs e)
        {
            try { 
            DataBase = Form1.DataBase;
            host = Form1.Host;
            password = Form1.Password;
            userName = Form1.UserName;
                cmbYear.Text = DateTime.Now.ToString("yyyy"); ;

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

}

        private void btnGenarate_Click(object sender, EventArgs e)
        {
            string year = DateTime.Now.ToString("yyyy");
            string BarcodeName = cmbYear.Text+cmbMonth.Text+"";
            try
            {
                for (int i=1;i<=Convert.ToInt64(txtCount.Text);i++) {

                    Genarate = new BarcodeEncoder();
                    Genarate.IncludeLabel = true;
                    if (txtpath.Text != "")
                    {
                        PcBox.Image = new Bitmap(Genarate.Encode(BarcodeFormat.Code128,BarcodeName+i.ToString()));
                        PcBox.Image.Save(@""+txtpath.Text+i.ToString()+".jpg", ImageFormat.Jpeg);
                      
                    }
           
                } 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void brnSavePath_Click(object sender, EventArgs e)
        {
           
        }

        private void txtSavePath_Click(object sender, EventArgs e)
        {
            try { 
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtpath.Text = folderBrowserDialog1.SelectedPath + "\\";
            }
        } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
}
    }   
}
