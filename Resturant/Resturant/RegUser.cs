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
using System.Net.Mail;
using OrderManagement;
using Cashier;


namespace Customer_Management
{
    public partial class RegUser : Form
    {
        int table;

        public RegUser()
        {
            InitializeComponent();
        }

        public RegUser(int Tno)
        {
            InitializeComponent();

            table = Tno;
        }
        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {

                return false;
            }
        }
        public static string mobile;

        public static string Mobile { get => mobile; set => mobile = value; }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {





        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            if ((textmobile.Text.Trim() == string.Empty || (textmobile.Text.Length != 10) || (!int.TryParse(textmobile.Text, out i))))
            {
                MessageBox.Show("Please enter a valid mobile number of 10 digits only");
                return; // return because we don't want to run normal code of buton click
            }
            else if (textemail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter a valid email,to continue");
                return; // return because we don't want to run normal code of buton click
            }
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";

            string query = "INSERT INTO CUSTOMER (MobileNumber) VALUES ('" + this.textmobile.Text + "');";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("You have been been successfully Registered");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape4_Click(object sender, EventArgs e)
        {


        }

        /*private void button4_Click(object sender, DataGridViewCellEventArgs e)
        {

            try {


                int index = e.RowIndex;

                //gets a collection that contains all the rows
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                label3.Text = row.Cells[3].Value.ToString();
                //label9.Text = row.Cells[3].Value.ToString();
                //textname.Text = row.Cells[2].Value.ToString();
                //textaddress.Text = row.Cells[4].Value.ToString();
                //textemail.Text = row.Cells[5].Value.ToString();

                // databaseConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                {
                }
            }




        }*/
        private void button4_Click(object sender, EventArgs e)
        {
            
            Int64 i;
            if ((textmobile.Text.Trim() != string.Empty))
            {
                if ((textmobile.Text.Length != 10) || (!Int64.TryParse(textmobile.Text, out i)))
                {
                    MessageBox.Show("Please enter a valid mobile number of 10 digits only");
                    return; // return because we don't want to run normal code of buton click
                }
            }
            if ((textmobile.Text.Trim() == string.Empty) && (textemail.Text.Trim() == string.Empty))
            {
                MessageBox.Show("Please enter a valid Mobile Number or sign in as a Guest! Thank You! !!", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }            
            else
            {
                //db
                try
                {
                    
                    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);


                    databaseConnection.Open();

                    Int32 count = 0;
                    Int32 count2 = 0;

                    string val = "select count(*)  from customer where MobileNumber= '" + textmobile.Text.ToString() + "'";
                    string val2 = "select count(*)  from customer where Email= '" + textemail.Text.ToString() + "'";
                    MySqlCommand cmd = new MySqlCommand(val, databaseConnection);
                    MySqlCommand cmd2 = new MySqlCommand(val2, databaseConnection);
                    count = count + Convert.ToInt32(cmd.ExecuteScalar());


                    if ((textmobile.Text.Trim() != string.Empty))
                    {
                        if (count == 1)
                        {
                            
                            MessageBox.Show("You have been already registerered !!", "Registered Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Methods m1 = new Methods();

                            //next page
                            new MakeOrder(table, m1.getCID(textmobile.Text)).Show();
                        }


                        else if (count == 0)
                        {


                            string type = "RegisteredM";
                            string query = "INSERT INTO CUSTOMER (MobileNumber,Email,Type) VALUES ('" + this.textmobile.Text + "','" + this.textemail.Text + "','" + type + "');";

                            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                            commandDatabase.CommandTimeout = 60;



                            MySqlDataReader myReader = commandDatabase.ExecuteReader();
                            myReader.Close();


                            databaseConnection.Close();
                            MessageBox.Show("You have been registered  through your Mobile!Thank you for registering with us!!", "Registered Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Methods m1 = new Methods();

                            //next page
                             new MakeOrder(table, m1.getCID(textmobile.Text)).Show();
                        }



                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }







        }
        private void RegUser_Load(object sender, EventArgs e)
            {


            }
         
        private void button2_Click_1(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            try
            {
                databaseConnection.Open();
                string type = "Registered";
                string query = "INSERT INTO CUSTOMER (MobileNumber,Email,Type) VALUES ('" + this.textmobile.Text + "','" + this.textemail.Text + "','" + type + "');";
                //MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;


                //databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("You have been been successfully Registererd");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Cashier.Table tbl = new Cashier.Table(table);



            if (tbl.get_number_of_items() == 0)
            {

                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";

                string query = "INSERT INTO CUSTOMER(Type) values ('NonRegistered');";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();

                    //MessageBox.Show("Customer has been successfully Registererd");
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                new MakeOrder(table, 0).Show();
            }
            else {
                MessageBox.Show("Table is already occupied");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Int64 i;
            if ((textmobile.Text.Trim() != string.Empty))
            {
                if ((textmobile.Text.Length != 10) || (!Int64.TryParse(textmobile.Text, out i)))
                {
                    MessageBox.Show("Please enter a valid mobile number of 10 digits only");
                    return; // return because we don't want to run normal code of buton click
                }

            }
            if ((textmobile.Text.Trim() == string.Empty) && (textemail.Text.Trim() == string.Empty))


            {
                MessageBox.Show("Please enter a valid Mobile Number or sign in as a Guest! Thank You! !!", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //db
                try
                {
                    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);


                    databaseConnection.Open();

                    Int32 count = 0;
                    Int32 count2 = 0;

                    string val = "select count(*)  from customer where MobileNumber= '" + textmobile.Text.ToString() + "'";
                    string val2 = "select count(*)  from customer where Email= '" + textemail.Text.ToString() + "'";
                    MySqlCommand cmd = new MySqlCommand(val, databaseConnection);
                    MySqlCommand cmd2 = new MySqlCommand(val2, databaseConnection);
                    count = count + Convert.ToInt32(cmd.ExecuteScalar());


                    if ((textemail.Text.Trim() != string.Empty))
                    {
                        bool result = IsValid(textemail.Text);
                        if (result == true)
                        {
                            if (count2 == 1)
                            {
                                MessageBox.Show("You have been already registerered !!", "Registered Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Methods m1 = new Methods();

                                //next page
                                //new MakeOrder(2, m1.getCID(textmobile.Text)).Show();
                            }


                            else if (count2 == 0)
                            {


                                string type = "RegisteredE";
                                string query = "INSERT INTO CUSTOMER (MobileNumber,Email,Type) VALUES ('" + this.textmobile.Text + "','" + this.textemail.Text + "','" + type + "');";

                                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                                commandDatabase.CommandTimeout = 60;



                                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                                myReader.Close();


                                databaseConnection.Close();
                                MessageBox.Show("You have been registered  through your Email!Thank you for registering with us!!", "Registered Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Methods m1 = new Methods();

                                //next page
                                new MakeOrder(table, m1.getCID(textemail.Text)).Show();
                            }

                        }
                        else if (result == false)
                        {
                            MessageBox.Show("Please enter a valid email address");
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

    }
    }
    

