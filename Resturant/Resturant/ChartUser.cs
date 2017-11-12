using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Management
{
    public partial class ChartUser : Form
    {
        public ChartUser()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            label2.Show();
            label8.Show();

            label7.Show();

            label2.Text = "As at " + DateTime.Now.ToString();
            //Call Main Function Which Will Help To Draw a Pie ChartÃ¢â‚¬Â¦
            DrawPieChartOnForm();


            void DrawPieChartOnForm()
            {

                string RegisteredE = "RegisteredE";
                string RegisteredM = "RegisteredM";



                int count1, count2, count3, count4, count5;
                Methods m2 = new Methods();
                count1 = m2.getcountofcus();
                count2 = m2.getEcust(RegisteredE);
                count3 = m2.getMcust(RegisteredM);
                count4 = (count2 + count3);
                count5 = (count1 - count4);





                double cnew1 = Convert.ToDouble(count1);
                double cnew2 = Convert.ToDouble(count2);
                double cnew3 = Convert.ToDouble(count3);
                double cnew4 = Convert.ToDouble(count4);
                double cnew5 = Convert.ToDouble(count5);

                double Reg = Convert.ToDouble((cnew4 / cnew1) * 100);
                double UnReg = Convert.ToDouble((cnew5 / cnew1) * 100);



                label7.Text = Reg.ToString("N2") + "   %";
                label8.Text = UnReg.ToString("N2") + "   %"; ;


                //Take Total Five Values & Draw Chart Of These Values.
                double[] myPiePercent = { Reg, UnReg };

                //Take Colors To Display Pie In That Colors Of Taken Five Values.
                Color[] myPieColors = { Color.LightGreen,Color.Red };

                using (Graphics myPieGraphic = this.CreateGraphics())
                {
                    //Give Location Which Will Display Chart At That Location.
                    Point myPieLocation = new Point(1000, 500);

                    //Set Here Size Of The ChartÃ¢â‚¬Â¦
                    Size myPieSize = new Size(300, 300);

                    //Call Function Which Will Draw Pie of Values.
                    DrawPieChart(myPiePercent, myPieColors, myPieGraphic, myPieLocation, myPieSize);
                

            
        }
    }
}

        // Draws a pie chart.
        public void DrawPieChart(double[] myPiePerecents, Color[] myPieColors, Graphics myPieGraphic, Point
      myPieLocation, Size myPieSize)
        {
            //Check if sections add up to 100.
            int sum = 0;
            foreach (int percent_loopVariable in myPiePerecents)
            {
                sum += percent_loopVariable;
            }

            if (sum != 100)
            {
                //     MessageBox.Show("Sum Do Not Add Up To 100.");
            }

            //Check Here Number Of Values & Colors Are Same Or Not.They Must Be Same.
            if (myPiePerecents.Length != myPieColors.Length)
            {
                MessageBox.Show("There Must Be The Same Number Of Percents And Colors.");
            }

            double PiePercentTotal = 0;
            for (int PiePercents = 0; PiePercents < myPiePerecents.Length; PiePercents++)
            {
                using (SolidBrush brush = new SolidBrush(myPieColors[PiePercents]))
                {

                    //Here it Will Convert Each Value Into 360, So Total Into 360 & Then It Will Draw A Full Pie Chart.
                    myPieGraphic.FillPie(brush, new Rectangle(new Point(10, 10), myPieSize), Convert.ToSingle(PiePercentTotal * 360 / 100), Convert.ToSingle(myPiePerecents[PiePercents] * 360 / 100));
                }

                PiePercentTotal += myPiePerecents[PiePercents];
            }

            return;


        }

        private void ChartUser_Load(object sender, EventArgs e)
        {
            label2.Hide();
            label8.Hide();
            label7.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            chartinterface non = new chartinterface();
            non.ShowDialog();
        }
    }
}
