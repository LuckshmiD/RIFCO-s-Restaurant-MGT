using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Customer_Management
{
    public partial class Registratio : Form
    {


        public Registratio()
        {
            InitializeComponent();
            Customer c2 = new Customer();




        }
        private static int max;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";

        public static int Max { get => max; set => max = value; }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape7_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape5_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || textmobile.Text.Length != 10) //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid mobile number of 10 digits only");
                //Reject the input
            }
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {






        }

        private void Registration_Load(object sender, EventArgs e)
        {

            //VALIDATION

            /* foreach (char c in textmobile.Text)
             {
                 if (!Char.IsDigit(c) | textmobile.Text.Length != 10)

                     MessageBox.Show("Please enter a valid mobile number of 10 digits only");

             }

             foreach (char c in textname.Text)
             {
                 if (!Char.IsLetter(c))

                     MessageBox.Show("Please enter a valid name of alphabets only (a-z) or (A-Z)");

             }

             foreach (char c in textaddress.Text)
             {
                 if (!Char.IsLetterOrDigit(c))

                     MessageBox.Show("Please enter a valid address of alphabets and digits only");

             }
             foreach (char c in textemail.Text)
             {
                 if (!Char.IsLetterOrDigit(c) | c != '_' | c != '.' | c != '@')

                     MessageBox.Show("Please enter a valid ");

             }*/





            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            string strSQL = "select * from customer";
            try
            {


                databaseConnection.Open();
                MySqlDataAdapter mydata = new MySqlDataAdapter(strSQL, databaseConnection);
                MySqlCommandBuilder cBuilder = new MySqlCommandBuilder(mydata);
                DataSet ds = new DataSet();
                mydata.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                { }


            }


        }

        private void textemail_Leave(object sender, EventArgs e)
        {
        }

        private void rectangleShape4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }



        private void button1_Click(object sender, EventArgs e)


        {

            int i;
            if ((textmobile.Text.Trim() == string.Empty || (textmobile.Text.Length != 10) || (!int.TryParse(textmobile.Text, out i))))
            {
                MessageBox.Show("Please enter a valid mobile number of 10 digits only");
                return; // return because we don't want to run normal code of buton click
            }
            else if (textname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter a valid name");
                return; // return because we don't want to run normal code of buton click
            }
            else if (textaddress.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter a valid address");
                return; // return because we don't want to run normal code of buton click
            }
            //else if (textemail.Text.Trim() == string.Empty)
            // {
            //   MessageBox.Show("Please enter a valid address");
            //  return; // return because we don't want to run normal code of buton click
            // }




            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";

            string type = "Registered";
            string query = "INSERT INTO CUSTOMER (MobileNumber,Name,Address,Email,Type) VALUES ('" + this.textmobile.Text + "','" + this.textname.Text + "','" + this.textaddress.Text + "','" + this.textemail.Text + "','"+type+"');";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Customer has been successfully Registererd");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            // string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=customermanagement;";
            //MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            string strSQL = "select * from customer";
            try
            {


                databaseConnection.Open();
                MySqlDataAdapter mydata = new MySqlDataAdapter(strSQL, databaseConnection);
                MySqlCommandBuilder cBuilder = new MySqlCommandBuilder(mydata);
                DataSet ds = new DataSet();
                mydata.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                {
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";
            // Delete the item with ID 1
            string query = "DELETE FROM customer WHERE CID=  '" + label8.Text.ToString() + "'";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                // Succesfully deleted
                MessageBox.Show("Customer record has been successfully deleted");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }
            //string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=customermanagement;";
            // MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            string strSQL = "select * from customer";
            try
            {


                databaseConnection.Open();
                MySqlDataAdapter mydata = new MySqlDataAdapter(strSQL, databaseConnection);
                MySqlCommandBuilder cBuilder = new MySqlCommandBuilder(mydata);
                DataSet ds = new DataSet();
                mydata.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                { }


            }


        }




        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rating h1 = new Rating();
            h1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textname.Text = "";
            textmobile.Text = "";
            textaddress.Text = "";
            textemail.Text = "";
            label8.Text = "";
            label9.Text = "";
            label12.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i;
            
            if (textname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter a valid name");
                return; // return because we don't want to run normal code of buton click
            }
            else if (textaddress.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter a valid address");
                return; // return because we don't want to run normal code of buton click
            }
            
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";
            // Update the properties of the row with ID 1

            string query = "UPDATE customer SET Name='" + textname.Text.ToString() + "',Address='" + textaddress.Text.ToString() + "',Email='" + textemail.Text.ToString() + "' WHERE CID ='" + label8.Text.ToString() + "'";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                MessageBox.Show("Customer details has been successfully Updated");
                // Succesfully updated

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // id doesn't exist
                MessageBox.Show("Customer details cannot be updated");
            }
            string strSQL = "select * from customer";
            try
            {


                databaseConnection.Open();
                MySqlDataAdapter mydata = new MySqlDataAdapter(strSQL, databaseConnection);
                MySqlCommandBuilder cBuilder = new MySqlCommandBuilder(mydata);
                DataSet ds = new DataSet();
                mydata.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                {
                }
            }
        }

        private void cellclick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                label12.Text = row.Cells[1].Value.ToString();
                label9.Text = row.Cells[3].Value.ToString();
                textname.Text = row.Cells[2].Value.ToString();
                textaddress.Text = row.Cells[4].Value.ToString();
                textemail.Text = row.Cells[5].Value.ToString();
            }

        }
        //SEARCH
        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            string strSQL = "select * from customer where MobileNumber= '" + textmobile.Text.ToString() + "'";
            //int strSQLcount = "select count(MobileNumber) from customer where MobileNumber= '" + textmobile.Text.ToString() + "'";
            //if (strSQLcount != 0)

            try
            {


                databaseConnection.Open();
                MySqlDataAdapter mydata = new MySqlDataAdapter(strSQL, databaseConnection);
                MySqlCommandBuilder cBuilder = new MySqlCommandBuilder(mydata);
                DataSet ds = new DataSet();
                mydata.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                databaseConnection.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                { }


            }

        }
        //VIEW ALL
        private void button6_Click_1(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            string strSQL = "select * from customer";
            try
            {


                databaseConnection.Open();
                MySqlDataAdapter mydata = new MySqlDataAdapter(strSQL, databaseConnection);
                MySqlCommandBuilder cBuilder = new MySqlCommandBuilder(mydata);
                DataSet ds = new DataSet();
                mydata.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                { }


            }
        }

        private void textname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' ') )
            {
                e.Handled = true;
                MessageBox.Show("Please enter only alphabets");
            }
        }

        private void textaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textaddress_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void email(object sender, KeyPressEventArgs e)
        {
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != '@') && (e.KeyChar != '_') && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                    MessageBox.Show("Please enter only alphabets");
                }
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape2_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            //sample s1 = new sample();
            //s1.ShowDialog();
           
        }

        private void label10_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //sample s1 = new sample();
            //s1.ShowDialog();


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape4_Click_1(object sender, EventArgs e)
        {
           // this.Hide();
            //Event e1=new Event();
            //e1.ShowDialog();
            Methods m1 = new Methods();
            int max = m1.getmaxcid();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Cater c1 = new Cater();
            //c1.ShowDialog();
            Methods m1 = new Methods();
            int max=m1.getmaxcid();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            // this.Hide();
            //Event e1=new Event();
            //e1.ShowDialog();
            Methods m1 = new Methods();
            int max = m1.getmaxcid();
        }
    }
    }






        


    