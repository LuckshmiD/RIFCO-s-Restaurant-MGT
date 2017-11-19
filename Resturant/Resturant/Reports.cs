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

        private void button2_Click(object sender, EventArgs e)
        {
            CrystalReport13.SetParameterValue("startdate", dateTimePicker3.Value);
            CrystalReport13.SetParameterValue("enddate", dateTimePicker4.Value);
            crystalReportViewer2.ReportSource = CrystalReport13;
            crystalReportViewer2.Refresh();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Profittrend1.SetParameterValue("startdate", dateTimePicker5.Value);
            Profittrend1.SetParameterValue("enddate", dateTimePicker6.Value);
            crystalReportViewer3.ReportSource = Profittrend1;
            crystalReportViewer3.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
