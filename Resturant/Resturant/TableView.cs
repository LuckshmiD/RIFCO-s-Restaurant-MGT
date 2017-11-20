using MySql.Data.MySqlClient;
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

namespace Cashier
{
    
    public partial class TableView : Form
    {

        Table table;
        private int custID = 0;

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

        public TableView( int t)
        {
            table = new Table(t);

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            dataGridView1.DataSource = table.get_table();
            label1.Text = "Table " + table.get_table_no().ToString();

            if (t == 11)
            {
                close.Visible = false;
            }
        }

        private void TableView_Load(object sender, EventArgs e)
        {

        }

        public void setCustomerID(int id)
        {
            custID = id;
        }

        private void Cash_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            if (pay.cash(table.get_total_price()))
            {
                string date = DateTime.Today.ToString("dd-MM-yyyy");
                string time = DateTime.Now.ToString("HH:mm:ss");

                MySqlDataReader tableData = table.get_table_data();
                string reciept = "Rifco's Chicken Tikka\nTel - 0770650095\n\n\nDate  : "+date+"\nTime : "+time+"\n\n";
                string name;
                int quantity;
                float price;

                while (tableData.Read())
                {
                    name = tableData.GetString("item_name");
                    quantity = tableData.GetInt32("quantity");
                    price = tableData.GetFloat("price");
                    custID = tableData.GetInt32("custid");

                    reciept = reciept + name + " (" + quantity.ToString() + " X " + price.ToString() + ") = " + (price * quantity).ToString() + "\n";
                }

                tableData.Close();

                reciept = reciept + "Total Sum = " + table.get_total_price().ToString() + "\n\nThank You!\nCome Again!\n";
                string nameOfTheFile = DateTime.Today.ToString("dd") + DateTime.Today.ToString("MM") + DateTime.Today.ToString("yyyy") + DateTime.Now.ToString("HH") + DateTime.Now.ToString("mm") + DateTime.Now.ToString("ss");

                pay.printReceipt(reciept, nameOfTheFile );

                if (custID != 0) {
                    databaseConnector db = new databaseConnector();
                    MySqlDataReader reader = db.getData("SELECT Email, MobileNumber FROM `customer` WHERE CID = "+custID);

                    reader.Read();
                    string email = reader.GetString("Email");
                    long mobileNumber = reader.GetInt64("MobileNumber");
                    reader.Close();
                    Send_Message sm = new Send_Message();

                    if (mobileNumber > 0)
                    {
                        
                        sm.sms(reciept, mobileNumber.ToString());
                    }
                    if ((email != "") || (email != null))
                    {
                        
                        sm.email(email, reciept);
                    }
                }
                
                
                pay.insertRecord(custID, 222, date, 100);
                table.clear_table();
                this.Close();
            }

        }

        private void CreditCard_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            if (pay.card(table.get_total_price()))
            {
                string date = DateTime.Today.ToString("dd-MM-yyyy");
                string time = DateTime.Now.ToString("HH:mm:ss");

                MySqlDataReader tableData = table.get_table_data();
                string reciept = "Rifco's Chicken Tikka\nTel - 0770650095\n\n\nDate  : " + date + "\nTime : " + time + "\n\n";
                string name;
                int quantity;
                float price;

                while (tableData.Read())
                {
                    name = tableData.GetString("item_name");
                    quantity = tableData.GetInt32("quantity");
                    price = tableData.GetFloat("price");
                    custID = tableData.GetInt32("custid");

                    reciept = reciept + name + " (" + quantity.ToString() + " X " + price.ToString() + ") = " + (price * quantity).ToString() + "\n";
                }

                tableData.Close();

                reciept = reciept + "Total Sum = " + table.get_total_price().ToString() + "\n\nThank You!\nCome Again!\n";
                string nameOfTheFile = DateTime.Today.ToString("dd") + DateTime.Today.ToString("MM") + DateTime.Today.ToString("yyyy") + DateTime.Now.ToString("HH") + DateTime.Now.ToString("mm") + DateTime.Now.ToString("ss");

                pay.printReceipt(reciept, nameOfTheFile);

                if (custID != 0)
                {
                    databaseConnector db = new databaseConnector();
                    MySqlDataReader reader = db.getData("SELECT Email, MobileNumber FROM `customer` WHERE CID = "+custID);

                    reader.Read();
                    string email = reader.GetString("Email");
                    long mobileNumber = reader.GetInt64("MobileNumber");
                    reader.Close();
                    Send_Message sm = new Send_Message();

                    if (mobileNumber > 0)
                    {
                        //
                        sm.sms(reciept, mobileNumber.ToString());
                    }
                    if ((email != "") || (email != null))
                    {
                        sm.email(email, reciept);
                    }
                }

                pay.insertRecord(custID, 222, date, 100);
                table.clear_table();
                this.Close();
            }

        }

        private void Cash_MouseDown(object sender, MouseEventArgs e)
        {
            Cash.BackgroundImage = Resources.cash_dark;
            Cash.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void CreditCard_MouseDown(object sender, MouseEventArgs e)
        {
            CreditCard.BackgroundImage = Resources.credit_dark;
            CreditCard.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Cash_MouseUp(object sender, MouseEventArgs e)
        {
            Cash.BackgroundImage = Resources.cash;
            Cash.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void CreditCard_MouseUp(object sender, MouseEventArgs e)
        {
            CreditCard.BackgroundImage = Resources.credit;
            CreditCard.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void CreditCard_MouseHover(object sender, EventArgs e)
        {}

        private void CreditCard_MouseLeave(object sender, EventArgs e)
        {
            CreditCard.BackgroundImage = Resources.credit;
            CreditCard.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Cash_MouseLeave(object sender, EventArgs e)
        {
            Cash.BackgroundImage = Resources.cash;
            Cash.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Cash_MouseHover(object sender, EventArgs e)
        {}

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_MouseHover(object sender, EventArgs e)
        {}

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackgroundImage = Resources.error__1_;
            close.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void close_MouseMove(object sender, MouseEventArgs e)
        {
            close.BackgroundImage = Resources.error;
            close.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Cash_MouseMove(object sender, MouseEventArgs e)
        {
            Cash.BackgroundImage = Resources.cash_dark;
            Cash.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void CreditCard_MouseMove(object sender, MouseEventArgs e)
        {
            CreditCard.BackgroundImage = Resources.credit_dark;
            CreditCard.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
