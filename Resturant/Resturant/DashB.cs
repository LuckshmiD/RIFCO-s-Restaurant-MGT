using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RCTRM
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            ExpensesUI f1 = new ExpensesUI();
            
            this.Hide();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IncomeUI f2 = new IncomeUI();
            f2.Show();
            
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProfitMargin p2 = new ProfitMargin();
            p2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TrackRevExp e1 = new TrackRevExp();
            e1.Show();
            this.Hide();
        }
    }
}
