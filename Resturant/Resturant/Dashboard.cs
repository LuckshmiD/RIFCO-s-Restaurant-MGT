using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resturant.Properties;
using System.Runtime.InteropServices;
using RCTRM;
using Transport;

namespace Cashier
{
    public partial class Dashboard : Form
    {
        Table tbl1 = new Table(1);
        Table tbl2 = new Table(2);
        Table tbl3 = new Table(3);
        Table tbl4 = new Table(4);
        Table tbl5 = new Table(5);
        Table tbl6 = new Table(6);
        Table tbl7 = new Table(7);
        Table tbl8 = new Table(8);
        Table tbl9 = new Table(9);
        Table tbl10 = new Table(10);

        Timer t = new Timer();

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Dashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            
        }

        private void t_Tick(object sender, EventArgs e)
        {
            
            string hour = DateTime.Now.ToString("HH");
            string minutes = DateTime.Now.ToString("mm");
            string am_pm = DateTime.Now.ToString(" tt");

            int h = int.Parse(hour);

            if (h==13)
            {
                hour = "01";
            }
            else if (h == 14)
            {
                hour = "02";
            }
            else if(h == 15)
            {
                hour = "03";
            }
            else if(h == 16)
            {
                hour = "04";
            }
            else if(h == 17)
            {
                hour = "05";
            }
            else if(h == 18)
            {
                hour = "06";
            }
            else if(h == 19)
            {
                hour = "07";
            }
            else if(h == 20)
            {
                hour = "08";
            }
            else if(h == 21)
            {
                hour = "09";
            }
            else if(h == 22)
            {
                hour = "10";
            }
            else if(h == 23)
            {
                hour = "11";
            }
            if (h == 00)
            {
                hour = "12";
            }

            clock.Text = hour + ":" + minutes + " " + am_pm;

            if (tbl1.get_number_of_items() == 0)
            {
                button1.Enabled = false;
                button1.BackgroundImage = Resources.no_order_dark;
                button1.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                button1.Enabled = true;
                button1.BackgroundImage = Resources.order_dark;
                button1.BackgroundImageLayout = ImageLayout.Zoom;
            }

            if (tbl2.get_number_of_items() == 0)
            {
                button2.Enabled = false;
                button2.BackgroundImage = Resources.no_order_dark;
                button2.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                button2.Enabled = true;
                button2.BackgroundImage = Resources.order_dark;
                button2.BackgroundImageLayout = ImageLayout.Zoom;
            }

            if (tbl3.get_number_of_items() == 0)
            {
                button3.Enabled = false;
                button3.BackgroundImage = Resources.no_order_dark;
                button3.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                button3.Enabled = true;
                button3.BackgroundImage = Resources.order_dark;
                button3.BackgroundImageLayout = ImageLayout.Zoom;
            }

            if (tbl4.get_number_of_items() == 0)
            {
                button4.Enabled = false;
                button4.BackgroundImage = Resources.no_order_dark;
                button4.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                button4.Enabled = true;
                button4.BackgroundImage = Resources.order_dark;
                button4.BackgroundImageLayout = ImageLayout.Zoom;
            }

            if (tbl5.get_number_of_items() == 0)
            {
                button5.Enabled = false;
                button5.BackgroundImage = Resources.no_order_dark;
                button5.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                button5.Enabled = true;
                button5.BackgroundImage = Resources.order_dark;
                button5.BackgroundImageLayout = ImageLayout.Zoom;
            }

            if (tbl6.get_number_of_items() == 0)
            {
                button6.Enabled = false;
                button6.BackgroundImage = Resources.no_order_dark;
                button6.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                button6.Enabled = true;
                button6.BackgroundImage = Resources.order_dark;
                button6.BackgroundImageLayout = ImageLayout.Zoom;
            }

            if (tbl7.get_number_of_items() == 0)
            {
                button7.Enabled = false;
                button7.BackgroundImage = Resources.no_order_dark;
                button7.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                button7.Enabled = true;
                button7.BackgroundImage = Resources.order_dark;
                button7.BackgroundImageLayout = ImageLayout.Zoom;
            }

            if (tbl8.get_number_of_items() == 0)
            {
                button8.Enabled = false;
                button8.BackgroundImage = Resources.no_order_dark;
                button8.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                button8.Enabled = true;
                button8.BackgroundImage = Resources.order_dark;
                button8.BackgroundImageLayout = ImageLayout.Zoom;
            }

            if (tbl9.get_number_of_items() == 0)
            {
                button9.Enabled = false;
                button9.BackgroundImage = Resources.no_order_dark;
                button9.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                button9.Enabled = true;
                button9.BackgroundImage = Resources.order_dark;
                button9.BackgroundImageLayout = ImageLayout.Zoom;
            }

            if (tbl10.get_number_of_items() == 0)
            {
                button10.Enabled = false;
                button10.BackgroundImage = Resources.no_order_dark;
                button10.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                button10.Enabled = true;
                button10.BackgroundImage = Resources.order_dark;
                button10.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);

            t.Start();

            tenMinutes.Tick += new EventHandler(this.tenMinutes_Tick);
            tenMinutes.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = tbl1.get_table_no();
            TableView tv1 = new TableView(n);
            tv1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = tbl2.get_table_no();
            TableView tv1 = new TableView(n);
            tv1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = tbl3.get_table_no();
            TableView tv1 = new TableView(n);
            tv1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = tbl4.get_table_no();
            TableView tv1 = new TableView(n);
            tv1.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int n = tbl5.get_table_no();
            TableView tv1 = new TableView(n);
            tv1.Show();
        }
       
        private void button6_Click_1(object sender, EventArgs e)
        {
            int n = tbl6.get_table_no();
            TableView tv1 = new TableView(n);
            tv1.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            int n = tbl7.get_table_no();
            TableView tv1 = new TableView(n);
            tv1.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            int n = tbl8.get_table_no();
            TableView tv1 = new TableView(n);
            tv1.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            int n = tbl9.get_table_no();
            TableView tv1 = new TableView(n);
            tv1.Show();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            int n = tbl10.get_table_no();
            TableView tv1 = new TableView(n);
            tv1.Show();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Resources.order;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.BackgroundImage = Resources.order;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            button3.BackgroundImage = Resources.order;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            button4.BackgroundImage = Resources.order;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            button5.BackgroundImage = Resources.order;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            button6.BackgroundImage = Resources.order;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            button7.BackgroundImage = Resources.order;
            button7.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            button8.BackgroundImage = Resources.order;
            button8.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            button9.BackgroundImage = Resources.order;
            button9.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button10_MouseDown(object sender, MouseEventArgs e)
        {
            button10.BackgroundImage = Resources.order;
            button10.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            //if (button1.Enabled)
            //{
            //    button1.BackgroundImage = Resources.order;
            //    button1.BackgroundImageLayout = ImageLayout.Zoom;
            //}
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            //if (button2.Enabled)
            //{
            //    button2.BackgroundImage = Resources.order;
            //    button2.BackgroundImageLayout = ImageLayout.Zoom;
            //}
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            //if (button3.Enabled)
            //{
            //    button3.BackgroundImage = Resources.order;
            //    button3.BackgroundImageLayout = ImageLayout.Zoom;
            //}
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            //if (button4.Enabled)
            //{
            //    button4.BackgroundImage = Resources.order;
            //    button4.BackgroundImageLayout = ImageLayout.Zoom;
            //}
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            //if (button5.Enabled)
            //{
            //    button5.BackgroundImage = Resources.order;
            //    button5.BackgroundImageLayout = ImageLayout.Zoom;
            //}
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            //if (button6.Enabled)
            //{
            //    button6.BackgroundImage = Resources.order;
            //    button6.BackgroundImageLayout = ImageLayout.Zoom;
            //}
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            //if (button7.Enabled)
            //{
            //    button7.BackgroundImage = Resources.order;
            //    button7.BackgroundImageLayout = ImageLayout.Zoom;
            //}
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            //if (button8.Enabled)
            //{
            //    button8.BackgroundImage = Resources.order;
            //    button8.BackgroundImageLayout = ImageLayout.Zoom;
            //}
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            //if (button9.Enabled)
            //{
            //    button9.BackgroundImage = Resources.order;
            //    button9.BackgroundImageLayout = ImageLayout.Zoom;
            //}
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            //if (button10.Enabled)
            //{
            //    button10.BackgroundImage = Resources.order;
            //    button10.BackgroundImageLayout = ImageLayout.Zoom;
            //}
        }














        //unwanted code
        private void Dashboard_MouseHover(object sender, EventArgs e)
        {

        }

        

        private void close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void close_MouseHover(object sender, EventArgs e)
        {}

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackgroundImage = Resources.error__1_;
            close.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void close_MouseMove(object sender, MouseEventArgs e)
        {
            close.BackgroundImage = Resources.error;
            close.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {

        }

        private void tenMinutes_Tick(object sender, EventArgs e)
        {
            Income i = new Income();
            i.GetSales();

            DeliveryOrders d = new DeliveryOrders();
            d.AssignDriver();
        }
    }
}
