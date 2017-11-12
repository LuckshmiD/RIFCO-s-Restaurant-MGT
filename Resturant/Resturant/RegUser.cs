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


namespace Customer_Management
{
    public partial class RegUser : Form
    {
        public RegUser()
        {
            InitializeComponent();
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
            int i;
            if ((textmobile.Text.Trim() != string.Empty))
            {
                if ((textmobile.Text.Length != 10) || (!int.TryParse(textmobile.Text, out i)))
                {
                    MessageBox.Show("Please enter a valid mobile number of 10 digits only");
                    return; // return because we don't want to run normal code of buton click
                }
            }
            if ((textmobile.Text.Trim() == string.Empty) && (textemail.Text.Trim() == string.Empty))
            {

                {
                    MessageBox.Show("Please enter a valid Mobile Number or Email or continue as a Guest! Thank You! !!", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
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
                    count2 = count2 + Convert.ToInt32(cmd2.ExecuteScalar());
                    if ((textmobile.Text.Trim() != string.Empty) && ((textemail.Text.Trim() != string.Empty)))
                    {
                        if ((count == 1) && (count2 > 0))
                        {
                            MessageBox.Show("You have been already registerered !!", "Registered Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Methods m1 = new Methods();
                            m1.getCID(textmobile.Text);
                            //next page
                        }
                    }
                    else if ((textmobile.Text.Trim() != string.Empty) && ((textemail.Text.Trim() == string.Empty)))
                    {
                        if (count == 1)
                        {
                            MessageBox.Show("You have been already registerered !!", "Registered Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Methods m1 = new Methods();
                            m1.getCID(textmobile.Text);
                            //next page
                        }
                    }
                    else if ((textmobile.Text.Trim() == string.Empty) && ((textemail.Text.Trim() != string.Empty)))
                        if (count2 >= 1)
                        {
                            MessageBox.Show("You have been already registerered !!", "Registered Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Methods m1 = new Methods();
                            m1.getCID2(textemail.Text);
                            //next page
                        }

                    //next page


                    //else if(((textmobile.Text.Trim() != string.Empty) && ((textemail.Text.Trim() != string.Empty))))
                    if ((count == 0) || (count2 == 0) && ((textemail.Text.Trim() == string.Empty)) && ((textmobile.Text.Trim() != string.Empty)))
                    {


                        string type = "RegisteredM";
                        string query = "INSERT INTO CUSTOMER (MobileNumber,Email,Type) VALUES ('" + this.textmobile.Text + "','" + this.textemail.Text + "','" + type + "');";
                        //MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                        MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                        commandDatabase.CommandTimeout = 60;



                        MySqlDataReader myReader = commandDatabase.ExecuteReader();


                      //  databaseConnection.Close();
                        MessageBox.Show("Thank you for registering with us!!", "Registered Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Methods m1 = new Methods();
                        m1.getCID(textmobile.Text);
                        //next page
                    }
                    if ((count == 0) || (count2 == 0) && ((textmobile.Text.Trim() == string.Empty)) && ((textemail.Text.Trim() != string.Empty)))
                    {


                        string type = "RegisteredE";
                        string query = "INSERT INTO CUSTOMER (MobileNumber,Email,Type) VALUES ('" + this.textmobile.Text + "','" + this.textemail.Text + "','" + type + "');";
                        //MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                        MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                        commandDatabase.CommandTimeout = 60;



                        MySqlDataReader myReader = commandDatabase.ExecuteReader();


                        databaseConnection.Close();
                        MessageBox.Show("Thank you for registering with us!!", "Registered Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Methods m1 = new Methods();
                        m1.getCID(textmobile.Text);
                        //next page
                    }



                         
/*
                         if (count3==0)
                            { 
                              string type = "Registered";
                             string query = "INSERT INTO CUSTOMER (MobileNumber,Email,Type) VALUES ('" + this.textmobile.Text + "','" + this.textemail.Text + "','" + type + "');";
                             //MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                             MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                             commandDatabase.CommandTimeout = 60;



                             MySqlDataReader myReader = commandDatabase.ExecuteReader();


                             databaseConnection.Close();
                             MessageBox.Show("Thank you for registering with us!!", "Registered Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             Methods m1 = new Methods();
                             m1.getCID(textmobile.Text);
                         }





                     }
                 //only mobile
                    else  if ((textmobile.Text.Trim() != string.Empty) && ((textemail.Text.Trim() != string.Empty)))
                     {



                          string val4 = "select count(*)  from customer where Mobile= '" + textmobile.Text.ToString() + "'";

                         MySqlCommand cmd4 = new MySqlCommand(val4, databaseConnection);

                         Int32 count4 = Convert.ToInt32(cmd.ExecuteScalar());
                         if (count4 == 1)
                         {
                             MessageBox.Show("You have been already registerered !!", "Registered Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             Methods m1 = new Methods();
                             m1.getCID(textmobile.Text);
                         }

                         if (count4 == 0)
                         {
                             string type = "Registered";
                             string query = "INSERT INTO CUSTOMER (MobileNumber,Email,Type) VALUES ('" + this.textmobile.Text + "','" + this.textemail.Text + "','" + type + "');";
                             //MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                             MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                             commandDatabase.CommandTimeout = 60;



                             MySqlDataReader myReader = commandDatabase.ExecuteReader();


                             databaseConnection.Close();
                             MessageBox.Show("Thank you for registering with us!!", "Registered Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             Methods m1 = new Methods();
                */
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

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
    }


