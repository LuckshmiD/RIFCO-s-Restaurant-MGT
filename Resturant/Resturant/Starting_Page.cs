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
using HRManagement;

namespace Resturant
{
    public partial class Starting_Page : Form
    {
        public Starting_Page()
        {
            InitializeComponent();
        }

        private void dinein_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(TableComboBox.Text) > 0)
                {
                    new RegUser(Convert.ToInt32(TableComboBox.Text)).Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Select a table number!!!");
            }
        }

        private void delivery_Click(object sender, EventArgs e)
        {
            new Registratio().Show();
        }

        private void takeaway_Click(object sender, EventArgs e)
        {
            new RegUser(11).Show();
        }

        private void Starting_Page_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            new Login().Show();
        }
    }
}
