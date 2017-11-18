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
    public partial class BillReportViewer : Form
    {
        public BillReportViewer()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            BillReport1.SetParameterValue("startdate", dateTimePicker1.Value);
            crystalReportViewer1.ReportSource = BillReport1;
            crystalReportViewer1.Refresh();
        }
    }
}
