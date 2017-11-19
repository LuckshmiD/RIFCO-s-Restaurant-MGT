using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resturant;

namespace HRManagement
{
    public partial class Employee_Home : Form
    {
        public Employee_Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new DeleteEmployee().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new UpdateEmployee().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new leaveManagement().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Search_Employee().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new empSal().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new meeting().Show();
            this.Hide();
        }

        private void Employee_Home_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            new leavereport().Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SalaryReport cr = new SalaryReport();
            cr.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new meetingReport().Show();
            this.Hide();
        }
    }
}
