using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Resturant.Properties;
using MySql.Data.MySqlClient;

namespace Cashier
{
    public partial class ConfirmPayment : Form
    {
        Table tbl;

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

        public ConfirmPayment(int tableNumber)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            tbl = new Table(tableNumber);
            dataGridView1.DataSource = tbl.get_OrderlistTable();

            priceLabel.Text = priceLabel.Text + tbl.get_orderlist_price();
        }

        

        private void ConfirmPayment_Load(object sender, EventArgs e)
        {
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static DateTime Get_UTCNow()
        {
            DateTime UTCNow = DateTime.UtcNow;
            int year = UTCNow.Year;
            int month = UTCNow.Month;
            int day = UTCNow.Day;
            int hour = UTCNow.Hour;
            int min = UTCNow.Minute;
            int sec = UTCNow.Second;
            DateTime datetime = new DateTime(year, month, day, hour, min, sec);
            return datetime;
        }


        private string Connection;
        private MySqlConnection DBConnect;
        private DateTime orderid;

        private void confirmPay_Click(object sender, EventArgs e)
        {
            Connection = " datasource =localhost ; username= root; password= ; database = RMSDatabase ";
            DBConnect = new MySqlConnection(Connection);

            //orderlist.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            try
            {
                DBConnect.Open();

                //MySqlCommand com2 = new MySqlCommand("DELETE FROM table1", DBConnect);

                //com2.ExecuteNonQuery();

                orderid = ConfirmPayment.Get_UTCNow();

                //string ordtype;
                //if (tbl.get_table_no()>=1  && tbl.get_table_no() <=10) {
                //    ordtype = "dinein";
                //}
                //else if (tbl.get_table_no() == 11) {
                //    ordtype = "takeaway";
                //}
                //else if (tbl.get_table_no() == 12) {
                //    ordtype = "delivery";
                //}
                //Customer c1 = new Customer();
                //string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";
                //int cusid = c1.GetNewCusId(connectionString);

                MySqlCommand comup2 = new MySqlCommand("UPDATE `orderlist" + tbl.get_table_no() + "` set orderid = '"+ orderid + "' ", DBConnect);


                comup2.ExecuteNonQuery();
                //Insert custid
                MySqlCommand com = new MySqlCommand("INSERT INTO `orders` (`orderid`,`custid`,`itemid`,`portionsize`,`ordertype`,`quantity`,`price`) SELECT `orderid`,`custid`,`itemcode`,`portionsize`,`ordertype`,`quantity`,`price` FROM `orderlist" + tbl.get_table_no()+"` ", DBConnect);


                com.ExecuteNonQuery();

                databaseConnector db1 = new databaseConnector();
                db1.executeStatement("INSERT INTO `table"+ tbl.get_table_no() + "`(`item_id`,`custid`,`item_name`,`potionsize`,`quantity`,`price`) SELECT `itemcode`,`custid`,`itemname`,`portionsize`,`quantity`,`price` FROM `orderlist" + tbl.get_table_no() + "` ");


                //com.Parameters.Add("@itemcode", MySqlDbType.Int32).Value = itemcode.Text;
                //com.Parameters.Add("@itemname", MySqlDbType.VarChar).Value = itemname.Text;
                //com.Parameters.Add("@portionsize", MySqlDbType.VarChar).Value = psize.Text;
                //com.Parameters.Add("@quantity", MySqlDbType.Int32).Value = qty.Value;

                MessageBox.Show("Order dispatched");



                DBConnect.Close();


                //this.Hide();

            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
            finally
            {
                DBConnect.Close();
            }

            databaseConnector db = new databaseConnector();
            

            db.executeStatement("DELETE FROM `orderlist" + tbl.get_table_no() + "`");
            
            db.closeConnection();

            this.Close();
        }

        private void confirmPay_MouseDown(object sender, MouseEventArgs e)
        {
            confirmPay.BackgroundImage = Resources.success;
            confirmPay.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void confirmPay_MouseUp(object sender, MouseEventArgs e)
        {
            confirmPay.BackgroundImage = Resources.success__1_;
            confirmPay.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void confirmPay_MouseHover(object sender, EventArgs e)
        {
            confirmPay.BackgroundImage = Resources.success;
            confirmPay.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void confirmPay_MouseLeave(object sender, EventArgs e)
        {
            confirmPay.BackgroundImage = Resources.success__1_;
            confirmPay.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void back_MouseDown(object sender, MouseEventArgs e)
        {
            back.BackgroundImage = Resources.error;
            back.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void back_MouseUp(object sender, MouseEventArgs e)
        {
            back.BackgroundImage = Resources.error__1_;
            back.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void back_MouseHover(object sender, EventArgs e)
        {
            back.BackgroundImage = Resources.error;
            back.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void back_MouseLeave(object sender, EventArgs e)
        {
            back.BackgroundImage = Resources.error__1_;
            back.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
