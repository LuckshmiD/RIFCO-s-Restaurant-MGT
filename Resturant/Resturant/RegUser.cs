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

// maathuten
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
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            try {
                //string strSQL = "select * from customer where MobileNumber= '" + textmobile.Text.ToString() + "'";
                int count = 0;
                string val = "select count * from customer where MobileNumber= '" + textmobile.Text.ToString() + "'";

                // Int32 count1 = Convert.ToInt32(cmd.ExecuteScalar);


                if (count == 0)

                {
                    MessageBox.Show("insert");
                }
                else
                {
                    MessageBox.Show("cannot insert");
                }





                databaseConnection.Open();
                MySqlDataAdapter mydata = new MySqlDataAdapter(val, databaseConnection);
                MySqlCommandBuilder cBuilder = new MySqlCommandBuilder(mydata);
                // DataSet ds = new DataSet();
                // mydata.Fill(ds);
                // dataGridView1.DataSource = ds.Tables[0];

                databaseConnection.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                { }


            }

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
            if ((textmobile.Text.Trim() == string.Empty || (textmobile.Text.Length != 10) || (!int.TryParse(textmobile.Text, out i))))
            {
                MessageBox.Show("Please enter a valid mobile number of 10 digits only");
                return; // return because we don't want to run normal code of buton click
            }
            var result=MessageBox.Show("Confirm mobile Number, '"+textmobile.Text+"'", "Confirm Number", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            //// else if (textemail.Text.Trim() == string.Empty)
            {
                //    MessageBox.Show("Please enter a valid address to continue!");
                //   return; // return because we don't want to run normal code of buton click
                // }



                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);

                try
                {
                    databaseConnection.Open();
                    //string strSQL = "select * from customer where MobileNumber= '" + textmobile.Text.ToString() + "'";
                    string val = "select count(*)  from customer where MobileNumber= '" + textmobile.Text.ToString() + "' and'" + this.textmobile.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(val, databaseConnection);
                    Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {


                        MessageBox.Show("You have been already registerered !!", "Registered Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mobile = textmobile.Text;

                        this.Hide();
                        //sample sc = new sample();
                        //sc.ShowDialog();
                    }//next page if registered
                    else
                    {
                        MessageBox.Show(" You are not recognized as a registered customer!Please fill in your email to proceed as a registered customer.Thank You!", "Non-Registered Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textemail.Show();
                        label2.Show();
                        button4.Hide();
                        button2.Show();

                    }
                }
                catch (Exception nn)
                { }
            } }
   
        private void RegUser_Load(object sender, EventArgs e)
        {
            textemail.Hide();
            label2.Hide();
            button2.Hide();
           
            //mobile

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

            //MessageBox.Show("Can insert");

            mobile = textmobile.Text;

            this.Hide();
            //sample cs = new sample();
            //cs.ShowDialog();
            }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }


    } 