using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using Resturant.Properties;

namespace Cashier
{
    public partial class DeliveryPayment : Form
    {

        databaseConnector db = new databaseConnector();

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

        public DeliveryPayment()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            DataTable tbl = new DataTable();
            MySqlDataReader reader = db.getData("select * from orderlist12");
            tbl.Load(reader);

            dataGridView1.DataSource = tbl;
        }

        private void cash_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader = db.getData("Select SUM(quantity * price) as price from orderlist12");
            reader.Read();
            float price = reader.GetFloat("price");
            reader.Close();

            Payment pay = new Payment();

            pay.cash(price);
        }

        private void credit_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader = db.getData("Select SUM(quantity * price) as price from orderlist12");
            reader.Read();
            float price = reader.GetFloat("price");
            reader.Close();

            Payment pay = new Payment();

            pay.card(price);
        }

        private void cash_MouseDown(object sender, MouseEventArgs e)
        {
            cash.BackgroundImage = Resources.cash_dark;
            cash.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void cash_MouseUp(object sender, MouseEventArgs e)
        {
            cash.BackgroundImage = Resources.cash;
            cash.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void cash_MouseHover(object sender, EventArgs e)
        {
            cash.BackgroundImage = Resources.cash_dark;
            cash.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void cash_MouseLeave(object sender, EventArgs e)
        {
            cash.BackgroundImage = Resources.cash;
            cash.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void credit_MouseDown(object sender, MouseEventArgs e)
        {
            credit.BackgroundImage = Resources.credit_dark;
            credit.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void credit_MouseUp(object sender, MouseEventArgs e)
        {
            credit.BackgroundImage = Resources.credit;
            credit.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void credit_MouseHover(object sender, EventArgs e)
        {
            credit.BackgroundImage = Resources.credit_dark;
            credit.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void credit_MouseLeave(object sender, EventArgs e)
        {
            credit.BackgroundImage = Resources.credit;
            credit.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_MouseDown(object sender, MouseEventArgs e)
        {
            close.BackgroundImage = Resources.error;
            close.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void close_MouseUp(object sender, MouseEventArgs e)
        {
            close.BackgroundImage = Resources.error__1_;
            close.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void close_MouseHover(object sender, EventArgs e)
        {
            close.BackgroundImage = Resources.error;
            close.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackgroundImage = Resources.error__1_;
            close.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
