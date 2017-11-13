using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Customer_Management;
using EventCaterMgt;
using OrderManagement;
using Cashier;

namespace Resturant
{
    public partial class TestModule : Form
    {
        public TestModule()
        {
            InitializeComponent();
        }

        private void DineIn_Click(object sender, EventArgs e)
        {
            new RegUser().Show();
        }

        private void CustomerManagement_Click(object sender, EventArgs e)
        {
            new Customer_Management.Form1().Show();
        }

        private void Event_Click(object sender, EventArgs e)
        {
            new MainECM().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
        }
    }
}
