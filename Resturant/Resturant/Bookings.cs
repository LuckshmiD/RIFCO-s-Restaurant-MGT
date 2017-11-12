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
    public partial class Bookings : Form
    {
        public Bookings()
        {
            InitializeComponent();

        }

        private void rectangleShape11_Click(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void readOnlyTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        //SEARCH TABLE ACCORDING TO NO OF OCCUPANTS
        private void button2_Click(object sender, EventArgs e)


        {
            if (textocc.Text == "")
            {
                MessageBox.Show("Please choose the number of occupants");
                //added
                return;
            }
            if ((starttext.Text == "10AM") && (endtext.Text != "12PM"))
            {
                MessageBox.Show("Each Reservation can only be made for a time limit of 2 hours! Please chose the end time as 12PM! ");

            }
            if ((starttext.Text == "12PM") && (endtext.Text != "2PM"))
            {
                MessageBox.Show("Each Reservation can only be made for a time limit of 2 hours! Please chose the end time as 2PM! ");

            }
            if ((starttext.Text == "2PM") && (endtext.Text != "4PM"))
            {
                MessageBox.Show("Each Reservation can only be made for a time limit of 2 hours! Please chose the end time as 4PM! ");

            }
            if ((starttext.Text == "4PM") && (endtext.Text != "6PM"))
            {
                MessageBox.Show("Each Reservation can only be made for a time limit of 2 hours! Please chose the end time as 6PM! ");

            }
            if ((starttext.Text == "6PM") && (endtext.Text != "8PM"))
            {
                MessageBox.Show("Each Reservation can only be made for a time limit of 2 hours! Please chose the end time as 8PM! ");

            }
            if ((starttext.Text == "8PM") && (endtext.Text != "10PM"))
            {
                MessageBox.Show("Each Reservation can only be made for a time limit of 2 hours! Please chose the end time as 10PM! ");

            }

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            string strSQL = "select * from tab where NoofSeats= '" + textocc.Text.ToString() + "'";


            try
            {


                databaseConnection.Open();
                MySqlDataAdapter mydata = new MySqlDataAdapter(strSQL, databaseConnection);
                MySqlCommandBuilder cBuilder = new MySqlCommandBuilder(mydata);
                DataSet ds = new DataSet();
                mydata.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];

                databaseConnection.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                { }


            }

            //VIEW ALL
            // string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=customermanagement;";
            //MySqlConnection databaseConnection = new MySqlConnection(connectionString);




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                //texttable.Text = row.Cells[0].Value.ToString();
                textmobile.Text = row.Cells[3].Value.ToString();
                textname.Text = row.Cells[2].Value.ToString();

            }
        }
        //DELETE RESERVATION
        private void button5_Click(object sender, EventArgs e)
        {
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";

                string query = "DELETE FROM bookings WHERE TableId=  '" + tablenolabel.Text.ToString() + "'  and ResDate = '" + datetext.Value.Date.ToString("yyyy-MM-dd") + "' and StartTime= '" + starttext.Text.ToString() + "' and EndTime = '" + endtext.Text.ToString() + "'";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;

                MessageBox.Show("Confirm delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();

                    // Succesfully deleted
                    MessageBox.Show("Reservation has been successfully deleted", "Reserved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    // Ops, maybe the id doesn't exists ?
                    MessageBox.Show(ex.Message);
                }
                //string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=customermanagement;";
                // MySqlConnection databaseConnection = new MySqlConnection(connectionString);

                string strSQL = "select * from bookings";
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
        }
        //CHECK FOR RESERVATIONS
        private void button3_Click(object sender, EventArgs e)
        {

            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);

                string strSQL = "select * from bookings where TableID= '" + tablenolabel.Text.ToString() + "' and ResDate= '" + datetext.Value.Date.ToString("yyyy-MM-dd") + "' and StartTime='" + starttext.Text.ToString() + "' and EndTime= '" + endtext.Text.ToString() + "'";
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



                }




            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if ((textmobile.Text == "") || (textname.Text == "") || (textocc.Text == "") || (starttext.Text == "") || (endtext.Text == "") || (tablenolabel.Text == ""))
            {
                MessageBox.Show("Please Fill in all required fields!.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.None);



            }
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            try
            {
                databaseConnection.Open();
                //string strSQL = "select * from customer where MobileNumber= '" + textmobile.Text.ToString() + "'";
                string strSQL2 = "select count(*) from bookings where TableID= '" + tablenolabel.Text.ToString() + "' and ResDate= '" + datetext.Value.Date.ToString("yyyy-MM-dd") + "' and StartTime='" + starttext.Text.ToString() + "' and EndTime= '" + endtext.Text.ToString() + "'";
                MySqlCommand cmd = new MySqlCommand(strSQL2, databaseConnection);
                Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                   // if (((textmobile.Text != "") || (textname.Text != "") || (textocc.Text != "") || (starttext.Text != "") || (endtext.Text != "") || (tablenolabel.Text != "")))

                        MessageBox.Show("Reservation cannot be made!!", "Registered Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (((textmobile.Text != "") || (textname.Text != "") || (textocc.Text != "") || (starttext.Text != "") || (endtext.Text != "") || (tablenolabel.Text != "")))
                    {
                        string query2 = "INSERT INTO bookings (TableID,MobileNumber,ResDate,StartTime,EndTime) VALUES ('" + this.tablenolabel.Text + "','" + this.textmobile.Text + "','" + this.datetext.Value.Date.ToString("yyyy-MM-dd") + "','" + this.starttext.Text + "','" + this.endtext.Text + "')";
                        MySqlCommand cmd1 = new MySqlCommand(query2, databaseConnection);
                        MySqlDataReader myReader = cmd1.ExecuteReader();

                        // }


                         databaseConnection.Close();
                        // }
                        // catch (Exception ex)
                        // {
                        // MessageBox.Show(ex.Message);
                        // }

                        // finally
                        // {
                        //  databaseConnection.Close();
                        // }

                        ///ALTERNATIVE

                        string strSQL = "select * from bookings";



                        databaseConnection.Open();
                        MySqlDataAdapter mydata = new MySqlDataAdapter(strSQL, databaseConnection);
                        MySqlCommandBuilder cBuilder = new MySqlCommandBuilder(mydata);
                        DataSet ds = new DataSet();
                        mydata.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                        databaseConnection.Close();
                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                {
                }
            }
            finally
            {
                databaseConnection.Close();
            }
        }
            
        private void Bookings_Load(object sender, EventArgs e)
        {
            starttext.SelectedIndex = 0;
            endtext.SelectedIndex = 0;
            textocc.SelectedIndex = 0;
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void datatable(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                tablenolabel.Text = row.Cells[0].Value.ToString();

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";

            string query = "INSERT INTO CUSTOMER (MobileNumber,Name) VALUES ('" + this.textmobile.Text + "','" + this.textname.Text + "');";
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
            finally
            {
                databaseConnection.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=customermanagement;";
            // Update the properties of the row with ID 1

            string query = "UPDATE bookings SET ='" + textname.Text.ToString() + "',Address='" + textaddress.Text.ToString() + "',Email='" + textemail.Text.ToString() + "' WHERE CID ='" + label8.Text.ToString() + "'";

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
            }*/
        }

        private void cellclick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                label8.Text = row.Cells[1].Value.ToString();
                label9.Text = row.Cells[3].Value.ToString();
                textname.Text = row.Cells[2].Value.ToString();
                //textaddress.Text = row.Cells[4].Value.ToString();
                //textemail.Text = row.Cells[5].Value.ToString();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tablenolabel.Text = " ";
            starttext.SelectedIndex = 0;
            endtext.SelectedIndex = 0;
            textocc.SelectedIndex = 0;
            textmobile.Text = "";
            textname.Text = "";
            dataGridView1.ClearSelection();

}

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void starttext_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            string strSQL = "select * from bookings";
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

        private void rectangleShape4_Click_1(object sender, EventArgs e)
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

        private void textmobile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}