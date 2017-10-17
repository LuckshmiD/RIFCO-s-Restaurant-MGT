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
using System.Text.RegularExpressions;
namespace EventCaterMgt
{
    public partial class Cater : Form
    {
        MySqlConnection con;
        public Cater()
        {
            InitializeComponent();
            con = new MySqlConnection(@"server=localhost;userid=root;password=;database=rmsdatabase");
        }


        public bool cusExist(string cus)
        {
            bool val = true;
           
            try
            {
                con.Open();
                string  que = "select sum(Price) from orders123 where customer='" + cus + "'";
                MySqlCommand cmd = new MySqlCommand(que, con);
                con.Close();
                if (cmd.ExecuteScalar().ToString() == "")
                {
                    return false;
                }
                else {
                    return true;
                }
            }
            catch (Exception ee)
            {
                val = false;
            }
            finally
            {
                con.Close();
            }
            return val;

        }
        private void Cater_Load(object sender, EventArgs e)
        {
            try
            {
                //  con.Open();
                //string  add = "select sum(Price) from orders123 where customer='" + cusid.Text + "'";
                //MySqlCommand  cmd = new MySqlCommand(add, con);
                //  MySqlDataReader read = cmd.ExecuteReader();
                //  if (read.Read())
                //  {
                //      Itot.Text = read.GetDouble("sum(Price)").ToString();
                //      read.Close();
                //      con.Close();
                //  }
                //  else
                //  {
                //      Itot.Text = "..";
                //  }
                while (orderGrid.Rows.Count > 1)
                {
                    orderGrid.Rows.RemoveAt(0);
                }

                con.Open();

                string add2 = "select bevdessert as BeveragesDesserts,price as Price from bevdessert";
                string add1 = "select lunchdinner as MainMenu,price as Price from lunchdinner";
                string add3 = "select Items,Quantity,Price from orders123";//recheck
               // string add3 = "select orders123.Items,orders123.Quantity,orders123.Price from(select 0 as adummy) customer left join(select Items,Quantity,Price from orders123)orders123 on 0=0";



                MySqlDataAdapter sda1 = new MySqlDataAdapter(add1, con);
                MySqlDataAdapter sda2 = new MySqlDataAdapter(add2, con);
                MySqlDataAdapter sda3 = new MySqlDataAdapter(add3, con);



                DataTable dbdataset1 = new DataTable();
                DataTable dbdataset2 = new DataTable();
                DataTable dbdataset3 = new DataTable();


                sda1.Fill(dbdataset1);
                sda2.Fill(dbdataset2);
                sda3.Fill(dbdataset3);



                dataGridView1.DataSource = dbdataset1;
                dataGridView2.DataSource = dbdataset2;
                orderGrid.DataSource = dbdataset3;


                con.Close();

                con.Open();
                string add = "select sum(Price) from orders123 where customer='" + cusid.Text + "'";
                MySqlCommand cmd = new MySqlCommand(add, con);
                MySqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    Itot.Text = read.GetDouble("sum(Price)").ToString();
                    read.Close();
                    con.Close();
                }
                else
                {
                    Itot.Text = "..";
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

    private void Cid_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Regex phoneNumpattern = new Regex(@"[0]{1}[0-9]{9}");
                Regex timepattern = new Regex(@"[0-1]{1}[0-9]{1}:[0-5]{1}[0-9]{1}\s*(AM|PM)");
                Regex nonNupattern = new Regex(@"\D");
                if (cuscontact.Text == "" || time.Text == "" || count.Text == "" || duration.Text == "" || address.Text == "")
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
                    MessageBox.Show("Head Count Should be a valid whole number.");
                }
                else
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert into cater(datetime,address,count,duration,cusContact,time) values('" + date.Text + "','" + address.Text + "','" + Convert.ToInt32(count.Text) + "','" + Convert.ToInt32(duration.SelectedItem) + "','" + cuscontact.Text + "','" + time.Text + "')";
                    cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("Successfully Saved");
                    //date.Text = "";
                    //address.Text = "";
                    //count.Text = "";                    
                    //cuscontact.Text = "";
                    //time.Text = "";
                    //duration.Text = "Choose";
                    //duhead.Text = "..";
                    //hdamount.Text = "..";                        
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("" + ee, "ERRor", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                con.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_TextChanged(object sender, EventArgs e)
        {

        }

        private void amnt_Click(object sender, EventArgs e)
        {
         

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                //amnt.Text = (Convert.ToDouble(count.Text) + Convert.ToDouble(duration.Text)).ToString();
                
                // amnt.ReadOnly = true;
                
                
            }
            catch(Exception ee)
            {
                MessageBox.Show("" + ee, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainECM mv = new MainECM();
            mv.Show();
        }

        private void button4_Click(object sender, EventArgs e)
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
                    cusid.Text = cmd.ExecuteScalar().ToString();
                    cusname.Text = cmd1.ExecuteScalar().ToString();
                }
                else {
                    MessageBox.Show("Number not found Please Register");
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void duration_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                for (int n = 1; n < 6; n++)
                {
                   if (duration.SelectedIndex == n-1)
                    duamount.Text = Convert.ToString(n * 2000);
                   
                        
                }
                double du, iamnt, tot;
                du = Convert.ToDouble(duamount.Text);
                iamnt = Convert.ToDouble(Itot.Text);
                tot = du + iamnt;

                duhead.Text = Convert.ToString(tot);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void count_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                    if (count.Text == "")
                    {
                        hdamount.Text = Convert.ToString("");
                    }
                    else
                    {
                        //int n = Convert.ToInt32(count.Text);
                        //hdamount.Text = Convert.ToString(n * 1);


                        double hd, du, tot;
                        hd = Convert.ToDouble(count.Text);


                        //if (duration.SelectedIndex < 0)
                        //{
                        //    tot = hd * 0;
                        //    duhead.Text = Convert.ToString(tot);
                        //}
                        //else
                        //{
                        //    du = Convert.ToDouble(duamount.Text);
                        //    tot = du * hd; //has to change to +
                        //    duhead.Text = Convert.ToString(tot);
                        //}

                     // price1.Text = "0";
                    if (cusExist(cusid.Text) == true)
                    {
                        con.Open();
                        string add = "select sum(Price) from orders123 where customer='" + cusid.Text + "'";
                        MySqlCommand cmd = new MySqlCommand(add, con);
                        MySqlDataReader read = cmd.ExecuteReader();
                        if (read.Read())
                        {
                            Itot.Text = (read.GetDouble("sum(Price)") + Convert.ToDouble(count.Text) * Convert.ToDouble(price1.Text)).ToString();
                            read.Close();
                        }

                        con.Close();
                    }
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

        private void duhead_Click(object sender, EventArgs e)
        {
            
        }

        private void hdamount_Click(object sender, EventArgs e)
        {

        }

        private void mealcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void dsrtcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {



                Regex phoneNumpattern = new Regex(@"[0]{1}[0-9]{9}");
                Regex timepattern = new Regex(@"[0-1]{1}[0-9]{1}:[0-5]{1}[0-9]{1}\s*(AM|PM)");
                Regex nonNupattern = new Regex(@"\D");
                if (cuscontact.Text == "" || time.Text == "" || count.Text == "" || duration.Text == "" || address.Text == "")
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
                    MessageBox.Show("Head Count Should be a valid whole number.");
                }
                else
                {
                    con.Open();
                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "Insert into cater(datetime,address,count,duration,cusContact,time) values('" + date.Text + "','" + address.Text + "','" + Convert.ToInt32(count.Text) + "','" + Convert.ToInt32(duration.SelectedItem) + "','" + cuscontact.Text + "','" + time.Text + "')";
                    cmd1.ExecuteReader();
                    con.Close();
                  //  MessageBox.Show("Successfully Saved");
                    //date.Text = "";
                    //address.Text = "";
                    //count.Text = "";                    
                    //cuscontact.Text = "";
                    //time.Text = "";
                    //duration.Text = "Choose";
                    //duhead.Text = "..";
                    //hdamount.Text = "..";                        
                }



                string add = "insert into paymentecm (payprice,cusid,dateToBePaid) values('" + Convert.ToDouble(duhead.Text) + "','" + cusid.Text+ "','"+date.Text+"')";
               // string inc = "insert into income(Descri,Type,Date,Voucher_No,Amount) values('Cash','Sales','"+date.Text+"','V"+cusid.Text+"','"+Convert.ToDouble(duhead.Text)+"')";
   
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(add, con);

                    cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("Successfully Payment  Added");
                  
                    Item1.Text = "";
                    duration.SelectedIndex =-1;
                    count.Text = "";
                    hdamount.Text = "";
                    duamount.Text = "";
                    duhead.Text = "";
                    price1.Text = "";
                    dsrt.Text = "";
                    Advance.Text = "";
                    date.Text = "";
                    address.Text = "";
                    //count.Text = "";                    
                    cuscontact.Text = "";
                    time.Text = "";
                    cusid.Text = "..";
                    cusname.Text = "..";

                DataTable emptyDT = new DataTable();
                orderGrid.DataSource = emptyDT;



                string add1 = "insert into ceorders select * from orders123";
                // string inc = "insert into income(Descri,Type,Date,Voucher_No,Amount) values('Cash','Sales','"+date.Text+"','V"+cusid.Text+"','"+Convert.ToDouble(duhead.Text)+"')";

                con.Open();
                cmd = new MySqlCommand(add1, con);
                cmd.ExecuteReader();
                con.Close();

                con.Open();
                add1 = "truncate table orders123";
                cmd = new MySqlCommand(add1,con);
                cmd.ExecuteReader();               
                con.Close();

                con.Open();
                add1 = "insert into orders123 values(0,'0',0,0)";
                cmd = new MySqlCommand(add1, con);
                cmd.ExecuteReader();
                con.Close();




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

        private void meal_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                price1.Text = dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
                //mainName.Text = dataGridView1.CurrentRow.Cells["MainMenu"].Value.ToString();
                Item1.Text = dataGridView1.CurrentRow.Cells["MainMenu"].Value.ToString();
            }
            catch (Exception ie) {
                MessageBox.Show(ie.Message);
            }
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            try
            {
                price1.Text = dataGridView2.CurrentRow.Cells["Price"].Value.ToString();
                //bevName.Text = dataGridView2.CurrentRow.Cells["BeveragesDesserts"].Value.ToString();
                Item1.Text = dataGridView2.CurrentRow.Cells["BeveragesDesserts"].Value.ToString();
            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
        }

        private void bdmenu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double du, hd, mm,  tot;
                du = Convert.ToDouble(duamount.Text);
                hd = Convert.ToDouble(hdamount.Text);
                mm = Convert.ToDouble(price1.Text);
                tot = Convert.ToDouble(duhead.Text);

                    tot = du + (hd * mm);

                     duhead.Text = Convert.ToString(tot);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mmenu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double du, hd, mm, tot;
                du = Convert.ToDouble(duamount.Text);
                hd = Convert.ToDouble(hdamount.Text);
                mm = Convert.ToDouble(price1.Text);
                tot = Convert.ToDouble(duhead.Text);


                    tot = du + (hd * mm);

                    duhead.Text = Convert.ToString(tot);
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void orderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.orderGrid.Rows[e.RowIndex];
                Item1.Text = row.Cells[0].Value.ToString();//item
                count.Text = row.Cells[1].Value.ToString();//qty
              //  price1.Text = row.Cells[2].Value.ToString();//price
                string x = row.Cells[2].Value.ToString();
                double y=(Convert.ToDouble(x))/Convert.ToDouble(count.Text);
                price1.Text = Convert.ToString(y);



            }
        }

        private void mainName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            try
            {
                double Iprice;

                if (count.Text == "")
                {
                    MessageBox.Show("Please enter the head count");
                }
                else
                {
                    Iprice = Convert.ToDouble(price1.Text) * Convert.ToDouble(count.Text);
                    string add = "insert into orders123 values('" + cusid.Text + "','" + Item1.Text + "','" + count.Text + "','" + Iprice + "')";
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(add, con);

                    cmd.ExecuteReader();
                    con.Close();
                    con.Open();
                    add = "select sum(Price) from orders123 where customer='" + cusid.Text + "'";
                    cmd = new MySqlCommand(add, con);
                    MySqlDataReader read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        Itot.Text = read.GetDouble("sum(Price)").ToString();
                        read.Close();
                    }

                    con.Close();
                    MessageBox.Show("Successfully added");
                   // count.Text = "";
                    Item1.Text = "";
                    price1.Text = "";


                    add = "select Items,Quantity,Price from orders123 where customer = '" + cusid.Text + "'";

                    MySqlCommand cmd1 = new MySqlCommand(add, con);

                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmd1;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    orderGrid.DataSource = bsource;
                    sda.Update(dbdataset);
                }
                double final = Convert.ToDouble(duhead.Text);
                double itotal = Convert.ToDouble(Itot.Text);
                double duration = Convert.ToDouble(duamount.Text);
                final = itotal + duration;
                duhead.Text = Convert.ToString(final);
                Advance.Text = Convert.ToString(final*0.50);
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

        private void Remove_Click(object sender, EventArgs e)
        {
            if (count.Text != "")
            {
                try
                {
                    string upd = "delete from orders123  where Items ='" + Item1.Text + "' and customer = '" + cusid.Text + "'";

                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(upd, con);

                    cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("Successfully deleted");
                    Item1.Text = "";
                    price1.Text = "";
                  //  count.Text = "";

                    con.Open();
                    string add = "select sum(Price) from orders123 where customer='" + cusid.Text + "'";
                    cmd = new MySqlCommand(add, con);
                    if (cmd.ExecuteScalar() != null)
                    {
                        MySqlDataReader read = cmd.ExecuteReader();
                        if (read.Read())
                        {
                            var ordinal = read.GetOrdinal("sum(Price)");
                            if (!read.IsDBNull(ordinal))
                            {
                                string totalAmount = read.GetDouble("sum(Price)").ToString();
                                Itot.Text = totalAmount;
                            }
                        }
                        read.Close();
                    }
                    con.Close();




                    upd = "select Items,Quantity,Price from orders123 where customer = '" + cusid.Text + "'";

                    MySqlCommand cmd1 = new MySqlCommand(upd, con);

                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmd1;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    orderGrid.DataSource = bsource;
                    sda.Update(dbdataset);


                    //
                    double final = Convert.ToDouble(duhead.Text);
                    double itotal = Convert.ToDouble(Itot.Text);
                    double duration = Convert.ToDouble(duamount.Text);
                    final = itotal + duration;
                    duhead.Text = Convert.ToString(final);
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
            else {
                MessageBox.Show("Please select an Item to Delete");
            }

        }

        private void Item1_Click(object sender, EventArgs e)
        {

        }

        private void Itot_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }


}
