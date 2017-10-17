using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventCaterMgt
{
    public partial class MainECM : Form
    {
        public MainECM()
        {
            InitializeComponent();
        }

        private void MainECM_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cater cat = new Cater();
            cat.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Event ev = new Event();
            ev.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            LoginEcm login = new LoginEcm();
            login.Show();

            //createMenu main = new createMenu();

            //main.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //LargeCE lc = new LargeCE();
            //lc.show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //RegularCE lc1 = new RegularCE();
            //lc1.show();
        }
    }
}
