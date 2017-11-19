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
using Resturant.Properties;

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

        private void button5_Click(object sender, EventArgs e)
        {
            Reports r1 = new Reports();
            r1.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackgroundImage = Resources.coin;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = Resources.incomes;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Resources.money__1_;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Resources.money;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackgroundImage = Resources.profits;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = Resources.profits__1_;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.BackgroundImage = Resources.vinyl_record;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackgroundImage = Resources.vinyl_record__1_;
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.BackgroundImage = Resources.analytics;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackgroundImage = Resources.analytics__1_;
        }
    }
}
