using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRManagement;
using EventCaterMgt;
using supplier;
using Transport;

namespace Resturant
{
    public partial class AdminModuleInterface : Form
    {
        public AdminModuleInterface()
        {
            InitializeComponent();
        }

        private void cashier_Click(object sender, EventArgs e)
        {
            new Cashier.Dashboard().Show();
        }

        private void hrman_Click(object sender, EventArgs e)
        {
            new Employee_Home().Show();
        }

        private void eventmgt_Click(object sender, EventArgs e)
        {
            new MainECM().Show();
        }

        private void supplier_Click(object sender, EventArgs e)
        {
            new Main().Show();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            new Customer_Management.Form1().Show();
        }

        private void finance_Click(object sender, EventArgs e)
        {
            new RCTRM.Dashboard().Show();
        }

        private void addDriver_Click(object sender, EventArgs e)
        {
            new Add_Driver_UI().Show();
        }

        private void driAvail_Click(object sender, EventArgs e)
        {
            new Change_Availability().Show();
        }
    }
}
