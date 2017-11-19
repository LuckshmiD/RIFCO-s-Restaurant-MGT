using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supplier
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stockdetails main = new Stockdetails();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupplierDetails main = new SupplierDetails();
            main.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegularCE reg = new RegularCE();
            reg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LargeCE lar = new LargeCE();
            lar.Show();
        }
    }
}
