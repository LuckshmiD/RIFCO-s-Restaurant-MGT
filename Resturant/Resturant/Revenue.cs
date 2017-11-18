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
    public partial class Revenue : Form
    {
        public Revenue()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport11.SetParameterValue("startdate", dateTimePicker1.Value);
            CrystalReport11.SetParameterValue("enddate", dateTimePicker2.Value);
            crystalReportViewer1.ReportSource = CrystalReport11;
            crystalReportViewer1.Refresh();
            
        }

        private void CrystalReport12_InitReport(object sender, EventArgs e)
        {

        }
    }
}
