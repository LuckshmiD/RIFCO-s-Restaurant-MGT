using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transport
{
    public partial class Transport_management : Form
    {
        public Transport_management()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Driver_UI adui = new Add_Driver_UI();
            adui.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Add_Vehicle_details adui = new Add_Vehicle_details();
            //adui.Show();
        }

        private void deleteDriver_Click(object sender, EventArgs e)
        {
            //Form2 adui = new Form2();
            //adui.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
