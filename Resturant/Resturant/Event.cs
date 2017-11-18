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
using Customer_Management;
using System.Text.RegularExpressions;

namespace EventCaterMgt
{
    public partial class Event : Form
    {
        MySqlConnection con;
        public Event()
        {
            InitializeComponent();
            con = new MySqlConnection(@"server=localhost;userid=root;password=;database=rmsdatabase");
        }
        public Event(int cid, string number, string name)
        {
            InitializeComponent();
            con = new MySqlConnection(@"server=localhost;userid=root;password=;database=rmsdatabase");
            cusid.Text = Convert.ToString(cid);
            cusname.Text = name;
            cuscontact.Text = number;
        }

        public void LoadEventList()
        {
            string add = "select  Item, Quantity, Price from eventlisttemp where customer = '" + cusid.Text + "', Date='"+ date.Text +"'";

            MySqlCommand cmd1 = new MySqlCommand(add, con);

            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd1;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bsource = new BindingSource();

            bsource.DataSource = dbdataset;
            eventOrder.DataSource = bsource;
            sda.Update(dbdataset);
        }

        public void fillEventorderlist()
        {
            string add = "select Item,Quantity,Price from eventlisttemp";
            MySqlCommand cmd1 = new MySqlCommand(add, con);

            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd1;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bsource = new BindingSource();

            bsource.DataSource = dbdataset;
            eventOrder.DataSource = bsource;
            sda.Update(dbdataset);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cater cs = new Cater();
            cs.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Regex phoneNumpattern = new Regex(@"[0]{1}[0-9]{9}");
                Regex timepattern = new Regex(@"[0-1]{1}[0-9]{1}:[0-5]{1}[0-9]{1}\s*(AM|PM)");
                //Regex countpattern = new Regex(@"[0-3]{1}[0-9]{1}");
                Regex nonNupattern = new Regex(@"\D");

                if (cuscontact.Text == "" || count.Text == "" || duration.SelectedIndex < 0 || time.Text == "")
                {
                    MessageBox.Show("Please fill in all the fields.!!!");
                }

                else if (!phoneNumpattern.IsMatch(cuscontact.Text))
                {
                    MessageBox.Show("Invalid contact number \n It should be \n Eg : 0777565689 \n 0 followed with 9 digits");
                }
                else if (!timepattern.IsMatch(time.Text))
                {
                    MessageBox.Show("Not a valid time format..! \n should be entered in \n hh:mm AM|PM.");
                }
                else if (nonNupattern.IsMatch(count.Text))
                {
                    MessageBox.Show("Head Count Should be a valid whole number ..!");
                }
                else
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert into event(ename,datetime,count,duration,cusContact,time,package) values('" + ename.Text + "','" + date.Text + "','" + Convert.ToInt32(count.Text) + "','" + Convert.ToInt32(duration.SelectedItem) + "','" + cuscontact.Text + "','" + time.Text + "','" + packcombo.SelectedItem + "')";
                    cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("Successfully Saved");
                    //date.Text = "";
                    //count.Text = "";                   
                    //cuscontact.Text = "";
                    //time.Text = "";
                    //ename.Text = "";
                    //duration.Text = "Choose";
                    //duhead.Text = "..";
                    //hdamount.Text = "..";
                    //packcombo.Text = "Choose";

                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("" + ee, "ERRor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // con.Close();

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (count.Text == "")
                //{
                //    hdamount.Text = Convert.ToString("");
                //}
                //else
                //{
                //    int n = Convert.ToInt32(count.Text);
                //    hdamount.Text = Convert.ToString(n * 1);


                //    double hd, du, tot;
                //    hd = Convert.ToDouble(count.Text);//hd amount


                //    if (duration.SelectedIndex < 0)
                //    {
                //        tot = hd;
                //        duhead.Text = Convert.ToString(tot);
                //    }
                //    else
                //    {
                //        du = Convert.ToDouble(duamount.Text);
                //        tot = du + hd;
                //        duhead.Text = Convert.ToString(tot);
                //    }

                //}


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            createMenu cm = new createMenu();
            cm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainECM mv = new MainECM();
            mv.Show();

        }

        private void Event_Load(object sender, EventArgs e)
        {
            try
            {
                string selectquery = "Select * from package";
                string selectquery1 = "Select * from extras";
               


                con.Open();
                MySqlCommand command = new MySqlCommand(selectquery, con);
                MySqlCommand command1 = new MySqlCommand(selectquery1, con);
               


                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    packcombo.Items.Add(reader.GetString("pname"));


                }
                reader.Close();


                ////reader = command1.ExecuteReader();
                ////while (reader.Read())
                ////{
                ////    dsrtcombo.Items.Add(reader.GetString("Features"));

                ////}
                ////reader.Close();
                string add2 = "select Features,Price from extras";
                MySqlDataAdapter sda2 = new MySqlDataAdapter(add2, con);
                DataTable dbdataset2 = new DataTable();
                sda2.Fill(dbdataset2);
                dataGridView1.DataSource = dbdataset2;


                ////string add3 = "select Package,Items,Quantity,Price from eventorders";
                ////MySqlDataAdapter sda3 = new MySqlDataAdapter(add3, con);
                ////DataTable dbdataset3 = new DataTable();
                ////sda3.Fill(dbdataset3);
                ////eventOrder.DataSource = dbdataset3;

                //string add3 = "select Item,Quantity,Price from eventlisttemp";
                //MySqlDataAdapter sda3 = new MySqlDataAdapter(add3, con);
                //DataTable dbdataset3 = new DataTable();
                //sda3.Fill(dbdataset3);
                //eventOrder.DataSource = dbdataset3;

                string add4 = "select bevdessert as Menu,price as Price from bevdessert";
                MySqlDataAdapter sda4 = new MySqlDataAdapter(add4, con);
                DataTable dbdataset4 = new DataTable();
                sda4.Fill(dbdataset4);
                DessertGrid.DataSource = dbdataset4;


               // con.Open();
                string add1 = "truncate table eventlisttemp";
                MySqlCommand cmd = new MySqlCommand(add1, con);
                cmd.ExecuteReader();
                con.Close();

                con.Open();
                add1 = "insert into eventlisttemp values(0,'2017-01-01',0,'0',0,0)";
                cmd = new MySqlCommand(add1, con);
                cmd.ExecuteReader();
                con.Close();



                fillEventorderlist();






            }


            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void cuscontact_TextChanged(object sender, EventArgs e)
        {
            //try {
            //    con.Open();
            //    string quer = "select eid from event where cusContact= '"+cuscontact.Text+"'";
            //    MySqlCommand cmd = new MySqlCommand(quer, con);
            //    cusid.Text =cmd.ExecuteScalar().ToString();
            //    con.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show( "Customer is not registered");
            //}
        }

        private void cusid_Click(object sender, EventArgs e)
        {

        }

        private void cuscontact_CursorChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string quer = "select CID from customer where MobileNumber= '" + cuscontact.Text + "'";// customer table ,cid is cater id
                string quer1 = "select Name from customer where MobileNumber= '" + cuscontact.Text + "'";//customer table
                MySqlCommand cmd = new MySqlCommand(quer, con);
                MySqlCommand cmd1 = new MySqlCommand(quer1, con);
                if (cmd.ExecuteScalar() != null)
                {
                    if (cmd1.ExecuteScalar().ToString() != "")
                    {
                        cusid.Text = cmd.ExecuteScalar().ToString();
                        cusname.Text = cmd1.ExecuteScalar().ToString();
                    }
                    else
                    {
                        MessageBox.Show("Number not found Please Register");
                        //new Registratio().Show();

                    }
                }

                else
                {
                    MessageBox.Show("Number not found Please Register");
                    //new Registratio().Show();

                }

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Register..!", "Non Registered Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }


        }

        private void duration_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                for (int n = 1; n < 6; n++)
                {
                    if (duration.SelectedIndex == n - 1)
                        duamount.Text = Convert.ToString(n * 2000);//hard coded


                }
                double du, hd, tot;
                du = Convert.ToDouble(duamount.Text);
                hd = Convert.ToDouble(count.Text);//hd amount
                tot = du;

                duhead.Text = Convert.ToString(tot);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void packcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string pack = packcombo.SelectedItem.ToString();
                double price;


                string que = "select price from package where pname = '" + pack + "'";
                MySqlCommand cmd = new MySqlCommand(que, con);
                MySqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    packprice.Text = read.GetDouble("price").ToString();
                    price = Convert.ToDouble(packprice.Text);

                    double du, hd, tot;
                    du = Convert.ToDouble(duamount.Text);
                    hd = Convert.ToDouble(count.Text);
                    tot = du + (hd* price);

                    duhead.Text = Convert.ToString(tot);
                    Advance.Text = (tot * 0.50).ToString();

                    read.Close();

                }





                string add = "select pname as MainMenu,mainmeal as MainMeal,dessert as Dessert,drink as Drink,price as Price from package where pname='" + pack + "'";
                MySqlCommand cmd1 = new MySqlCommand(add, con);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd1;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                dataGridView2.DataSource = bsource;
                sda.Update(dbdataset);


            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {

                Regex phoneNumpattern = new Regex(@"[0]{1}[0-9]{9}");
                Regex timepattern = new Regex(@"[0-1]{1}[0-9]{1}:[0-5]{1}[0-9]{1}\s*(AM|PM)");
                //Regex countpattern = new Regex(@"[0-3]{1}[0-9]{1}");
                Regex nonNupattern = new Regex(@"\D");

                if (cuscontact.Text == "" || count.Text == "" || duration.SelectedIndex < 0 || time.Text == "")
                {
                    MessageBox.Show("Please fill in all the fields.!!!");
                }

                else if (!phoneNumpattern.IsMatch(cuscontact.Text))
                {
                    MessageBox.Show("Invalid contact number \n It should be \n Eg : 0777565689 \n 0 followed with 9 digits");
                }
                else if (!timepattern.IsMatch(time.Text))
                {
                    MessageBox.Show("Not a valid time format..! \n should be entered in \n hh:mm AM|PM.");
                }
                else if (nonNupattern.IsMatch(count.Text))
                {
                    MessageBox.Show("Head Count Should be a valid whole number ..!");
                }
                else
                {
                    con.Open();
                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "Insert into event(ename,datetime,count,duration,cusContact,time,cusId,cusname) values('" + ename.Text + "','" + date.Text + "','" + Convert.ToInt32(count.Text) + "','" + Convert.ToInt32(duration.SelectedItem) + "','" + cuscontact.Text + "','" + time.Text + "','" + Convert.ToInt32(cusid.Text) + "','" + cusname.Text + "')";
                    cmd1.ExecuteReader();
                    con.Close();
                    // MessageBox.Show("Successfully Saved");


                    // string inc = "insert into income(Descri,Type,Date,Voucher_No,Amount) values('Cash','Sales','"+date.Text+"','V"+cusid.Text+"','"+Convert.ToDouble(duhead.Text)+"')";
                    string add = "insert into paymentecm (payprice,cusid,dateToBePaid) values('" + Convert.ToDouble(duhead.Text) + "','" + cusid.Text + "','" + date.Text + "')";

                        con.Open();
                        MySqlCommand cmd = new MySqlCommand(add, con);

                        cmd.ExecuteReader();
                        con.Close();
                        MessageBox.Show("Successfully Payment added");

                       // dsrtcombo.Text = "Choose From Here";
                        duration.SelectedIndex = -1;
                        packprice.Text = "0";
                        // packcombo.SelectedIndex = -1;
                        count.Text = "";
                        hdamount.Text = "";
                        duamount.Text = "0";
                        duhead.Text = "";
                       // dsrt.Text = "0";
                        price1.Text = "0";
                        cusid.Text = "";
                        cusname.Text = "";
                        Advance.Text = "";

                        date.Text = "";
                        //count.Text = "";
                        cuscontact.Text = "";
                        time.Text = "";
                        ename.Text = "";

                       

                        string add1 = "insert into eventlist select * from eventlisttemp";
                        // string inc = "insert into income(Descri,Type,Date,Voucher_No,Amount) values('Cash','Sales','"+date.Text+"','V"+cusid.Text+"','"+Convert.ToDouble(duhead.Text)+"')";

                        con.Open();
                        cmd = new MySqlCommand(add1, con);
                        cmd.ExecuteReader();
                        con.Close();

                        con.Open();
                        add1 = "truncate table eventlisttemp";
                        cmd = new MySqlCommand(add1, con);
                        cmd.ExecuteReader();
                        con.Close();

                        con.Open();
                        add1 = "insert into eventlisttemp values(0,'2017-01-01',0,'0',0,0)";
                        cmd = new MySqlCommand(add1, con);
                        cmd.ExecuteReader();
                        con.Close();

                        DataTable emptyDT1 = new DataTable();
                        dataGridView2.DataSource = emptyDT1;

                    fillEventorderlist();

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dsrtcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //////try
            //////{
            //////    con.Open();

            //////    string pack = dsrtcombo.SelectedItem.ToString();
            //////    //  double price;

            //////    string que = "select price from extras where Features = '" + pack + "'";
            //////    MySqlCommand cmd = new MySqlCommand(que, con);
            //////    MySqlDataReader read = cmd.ExecuteReader();
            //////    if (read.Read())
            //////    {
            //////        dsrt.Text = read.GetDouble("price").ToString();


            //////        double du, hd, tot, dsrt1, pack1;
            //////        du = Convert.ToDouble(duamount.Text);
            //////        // meal1 = Convert.ToDouble(meal.Text);
            //////        dsrt1 = Convert.ToDouble(dsrt.Text);
            //////        pack1 = Convert.ToDouble(packprice.Text);



            //////        hd = Convert.ToDouble(count.Text);
            //////        tot = du + (hd * (pack1) + dsrt1);

            //////        duhead.Text = Convert.ToString(tot);
            //////        Advance.Text = Convert.ToString(tot * .50);


            //////        read.Close();

            //////    }
            //////}

            //////catch (Exception ex)
            //////{
            //////    MessageBox.Show(ex.Message);
            //////}
            //////finally
            //////{
            //////    con.Close();
            //////}

        }

        private void dsrt_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {

        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                string pack = packcombo.Text;
                string items = Item1.Text;

                double c = Convert.ToInt32(count.Text);
               // double pp = Convert.ToDouble(packprice.Text);
                double ds = Convert.ToDouble(price1.Text);
               double Iprice = 1 *  ds;
                int feCount = 1;



                if (count.Text == "")
                {
                    MessageBox.Show("Please enter the head count");
                }
                else
                {
                

                    string add = "insert into eventlisttemp (Date,CusId,Item,Quantity,Price) values('" + date.Text + "','" + cusid.Text + "','" + items + "','" + feCount + "','"+ Iprice +"')";
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(add, con);

                    cmd.ExecuteReader();
                    con.Close();

                    con.Open();
                    add = "select sum(Price) from eventlisttemp where CusId='" + cusid.Text + "'and Date='" + date.Text + "'";
                    cmd = new MySqlCommand(add, con);
                    MySqlDataReader read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        double total = read.GetDouble("sum(Price)");
                        double durationamnt = Convert.ToDouble(duamount.Text);
                        duhead.Text = (total + durationamnt).ToString();
                        read.Close();
                    }

                    con.Close();

                    double final = Convert.ToDouble(duhead.Text);

                    Advance.Text = Convert.ToString(final * 0.50);
                    fillEventorderlist();

                }
    
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string add1 = "truncate table eventlisttemp";
                MySqlCommand cmd = new MySqlCommand(add1, con);
                cmd.ExecuteReader();
                con.Close();

                con.Open();
                add1 = "insert into eventlisttemp values(0,'2017-01-01',0,'0',0,0)";
                cmd = new MySqlCommand(add1, con);
                cmd.ExecuteReader();
                con.Close();

                fillEventorderlist();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void eventOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.eventOrder.Rows[e.RowIndex];
                Item1.Text = row.Cells[0].Value.ToString();//item
                count.Text = row.Cells[1].Value.ToString();//qty
                                                           //  price1.Text = row.Cells[2].Value.ToString();//price
                string x = row.Cells[2].Value.ToString();
                double y = (Convert.ToDouble(x)) / Convert.ToDouble(count.Text);
                price1.Text = Convert.ToString(y);
            }
        }

        private void AddPackage_Click(object sender, EventArgs e)
        {
            try
            {
                string pack = packcombo.Text;
               // string items = dsrtcombo.Text;

                double c = Convert.ToInt32(count.Text);
                double pp = Convert.ToDouble(packprice.Text);
               // double ds = Convert.ToDouble(dsrt.Text);
                double Iprice = c * pp;
                


                    string add = "insert into eventlisttemp (Date,CusId,Item,Quantity,Price) values('" + date.Text + "','" + cusid.Text + "','" + pack + "','" + c + "','" + Iprice + "')";
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(add, con);

                    cmd.ExecuteReader();
                    con.Close();

                //  MessageBox.Show("Successfully added");
                // count.Text = "";
                //  dsrt.Text = "";
                //  packprice.Text = "";
                con.Open();
                add = "select sum(Price) from eventlisttemp where CusId='" + cusid.Text + "'and Date='"+date.Text+"'";
                cmd = new MySqlCommand(add, con);
                MySqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    double total = read.GetDouble("sum(Price)");
                    double durationamnt = Convert.ToDouble(duamount.Text);
                    duhead.Text = (total+durationamnt).ToString();
                    read.Close();
                }

                con.Close();

                fillEventorderlist();

                double final = Convert.ToDouble(duhead.Text);
            
                Advance.Text = Convert.ToString(final * 0.50);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void DessertGrid_Click(object sender, EventArgs e)
        {
            try
            {
                price1.Text = DessertGrid.CurrentRow.Cells["Price"].Value.ToString();
                //bevName.Text = dataGridView2.CurrentRow.Cells["BeveragesDesserts"].Value.ToString();
                Item1.Text = DessertGrid.CurrentRow.Cells["Menu"].Value.ToString();


                double price = Convert.ToDouble(price1.Text);
                int cnt = Convert.ToInt32(count.Text);
                double advance = Convert.ToDouble(Advance.Text);

                con.Open();
              // string add = "select sum(Price) from eventlisttemp where CusId='" + cusid.Text + "'and Date='" + date.Text + "'";
                string add = "select sum(Price) from eventlisttemp ";
                MySqlCommand cmd = new MySqlCommand(add, con);
                MySqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    double total = read.GetDouble("sum(Price)");
                    double durationamnt = Convert.ToDouble(duamount.Text);
                    duhead.Text = (total + durationamnt+ cnt*price).ToString();
                    advance = Convert.ToDouble(duhead.Text) * 0.50;
                    Advance.Text = advance.ToString();
                    read.Close();
                }

                con.Close();
             

            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_Click_2(object sender, EventArgs e)
        {
            try
            {
                price1.Text = dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
                //bevName.Text = dataGridView2.CurrentRow.Cells["BeveragesDesserts"].Value.ToString();
                Item1.Text = dataGridView1.CurrentRow.Cells["Features"].Value.ToString();
                double price = Convert.ToDouble(price1.Text);
                //int cnt = Convert.ToInt32(count.Text);
                double advance = Convert.ToDouble(Advance.Text);

                con.Open();
              //  string add = "select sum(Price) from eventlisttemp where CusId='" + cusid.Text + "'and Date='" + date.Text + "'";
                string add = "select sum(Price) from eventlisttemp";
                MySqlCommand cmd = new MySqlCommand(add, con);
                MySqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    double total = read.GetDouble("sum(Price)");
                    double durationamnt = Convert.ToDouble(duamount.Text);
                    duhead.Text = (total + durationamnt + price).ToString();
                    advance = Convert.ToDouble(duhead.Text) * 0.50;
                    Advance.Text = advance.ToString();
                    read.Close();
                }

                con.Close();

            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            try
            {
                string pack = packcombo.Text;
                string items = Item1.Text;

                double c = Convert.ToInt32(count.Text);
              //  double pp = Convert.ToDouble(packprice.Text);
              //  double ds = Convert.ToDouble(dsrt.Text);                
               double dsrtprice = Convert.ToDouble(price1.Text);
                double Iprice = c*dsrtprice;



                if (count.Text == "")
                {
                    MessageBox.Show("Please enter the head count");
                }
                else
                {


                    string add = "insert into eventlisttemp (Date,CusId,Item,Quantity,Price) values('" + date.Text + "','" + cusid.Text + "','" + Item1.Text + "','" + c + "','" + Iprice + "')";
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(add, con);

                    cmd.ExecuteReader();
                    con.Close();

                    con.Open();
                    add = "select sum(Price) from eventlisttemp where CusId='" + cusid.Text + "'and Date='" + date.Text + "'";
                    cmd = new MySqlCommand(add, con);
                    MySqlDataReader read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        double total = read.GetDouble("sum(Price)");
                        double durationamnt = Convert.ToDouble(duamount.Text);
                        duhead.Text = (total + durationamnt).ToString();
                        read.Close();
                    }

                    con.Close();
                    double final = Convert.ToDouble(duhead.Text);

                    Advance.Text = Convert.ToString(final * 0.50);
                    fillEventorderlist();

                }
                //double final = Convert.ToDouble(duhead.Text);
                //// double itotal = Convert.ToDouble(Itot.Text);
                //double duration = Convert.ToDouble(duamount.Text);
                ////  final = itotal + duration;
                //duhead.Text = Convert.ToString(final);
                //Advance.Text = Convert.ToString(final * 0.50);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void DessertGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (count.Text != "")
            {
                try
                {
                    string upd = "delete from eventlisttemp  where Item ='" + Item1.Text + "'and CusId='" + cusid.Text + "'";

                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(upd, con);

                    cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("Removed");
                    Item1.Text = "";
                    price1.Text = "";
                    //  count.Text = "";
                    fillEventorderlist();

                    con.Open();
                    string add = "select sum(Price) from eventlisttemp where CusId='" + cusid.Text + "'and Date='" + date.Text + "'";
                    cmd = new MySqlCommand(add, con);
                    MySqlDataReader read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        double total = read.GetDouble("sum(Price)");
                        double durationamnt = Convert.ToDouble(duamount.Text);
                        duhead.Text = (total + durationamnt).ToString();
                        read.Close();
                    }

                    con.Close();




                    fillEventorderlist();


                    //
                    double final = Convert.ToDouble(duhead.Text);
                  
                    Advance.Text = Convert.ToString(final * 0.50);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select an Item to Delete");
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eventOrder_Click(object sender, EventArgs e)
        {

     
        }
    }
    }
    
    

