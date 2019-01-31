using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Mail;

namespace DSD
{
    public partial class Print : Form
    {

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        public Print(string y,string s,string t,string m,string ttm,string tbm,string tam,string tt, string ttamount)
        {
            try {
                InitializeComponent();
                reportViewer2.Visible = false;

                Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
                     {

                new Microsoft.Reporting.WinForms.ReportParameter("Year",y),
                new Microsoft.Reporting.WinForms.ReportParameter("Subject",s),
                new Microsoft.Reporting.WinForms.ReportParameter("tcName",t),
                new Microsoft.Reporting.WinForms.ReportParameter("Month",m),
                new Microsoft.Reporting.WinForms.ReportParameter("ThisM",ttm),
                new Microsoft.Reporting.WinForms.ReportParameter("BeforeM",tbm),
                new Microsoft.Reporting.WinForms.ReportParameter("AfterM",tam),
                new Microsoft.Reporting.WinForms.ReportParameter("Total",tt),
                new Microsoft.Reporting.WinForms.ReportParameter("TotalAmount",ttamount)
                     };
                this.reportViewer1.LocalReport.SetParameters(para);
                this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public Print(string Amount)
        {
            try {
                InitializeComponent();
                reportViewer1.Visible = false;

                Microsoft.Reporting.WinForms.ReportParameter[] param = new Microsoft.Reporting.WinForms.ReportParameter[]
                     {

                new Microsoft.Reporting.WinForms.ReportParameter("amount",Amount),

                     };
                this.reportViewer2.LocalReport.SetParameters(param);
                this.reportViewer2.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }




        private void Print_Load(object sender, EventArgs e)
        {




            this.reportViewer2.RefreshReport();
        }
    }
}
