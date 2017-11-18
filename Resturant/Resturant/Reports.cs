using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EpenditureReport1.SetParameterValue("startdate", dateTimePicker1.Value);
            EpenditureReport1.SetParameterValue("enddate", dateTimePicker2.Value);
            crystalReportViewer1.ReportSource = EpenditureReport1;
            crystalReportViewer1.Refresh();
            
            
        }
    }
}
