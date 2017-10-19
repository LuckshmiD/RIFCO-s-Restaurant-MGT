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

namespace OrderManagement
{
    public partial class StockDetails : Form
    {
        

        MySqlCommand cmd;
        MySqlDataAdapter adp;
        DataTable dt;

        public StockDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();
            try
            {
                DataTable dt = new DataTable();

                //MySqlConnection con = new MySqlConnection("Server=localhost;Database=project;Uid=root;Pwd=;");
                //insert 

                String type = comboBox1.Text;
                /*if (comboBox1.SelectedIndex == 0)
                {
                    type ="Active";

                }
                else
                {
                    type = "Deactive";
                }*/

                /*var sqlQuery = "";
                if (IfSupplierExists(con , textBox1.Text))
                {
                    sqlQuery = @"UPDATE [dbo].[Stock] SET [StockName] ='" + textBox2.Text + "',[Size] = '" + textBox3.Text + "',[Status] ='" + comboBox1.SelectedIndex + "',[Cost] = '" + textBox5.Text + "',[ExpiryDate] = '" + textBox6.Text + "'  WHERE <[StockCode] ='" + textBox1.Text + "')";
                }
                else
                {
                    sqlQuery = @"INSERT INTO [dbo].[Stock]
                                  ([StockCode],[StockName],[Size],[Status],[Cost],[ExpiryDate])
                              VALUES
                                   ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.SelectedIndex + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                }
                */

                conn.Open();

                MySqlCommand cmd = new MySqlCommand(@"INSERT INTO Stock
                                  (StockCode,StockName,StockSize,Status,UnitPrice,Date)
                              VALUES
                                   ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", conn);
                cmd.ExecuteReader();
                conn.Close();
                //remove the all the rows of the table
                while (dataGridView1.Rows.Count > 1)
                {
                    dataGridView1.Rows.RemoveAt(0);
                }

                //reading database
                //LoadData();

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                conn.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter("select * from Stock", conn);
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                adp.Dispose();
                conn.Close();
                MessageBox.Show("Stock Details are Added");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            catch (MySqlException ee)
            {
                MessageBox.Show("" + ee, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from stock where StockName='" + textBox2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            display_data();
            MessageBox.Show("Record deleted successfully");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        public void display_data()
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Stock";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string valueOfData = textBox4.Text.ToString();
            searchData(valueOfData);
        }

        public void searchData(string valueOfData)
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            string query = "select * from supplier where CONCAT(SupplierCode,SupplierName,Address,Status,District,PhoneNumber,EmailAddress) like '%" + valueOfData + "%'";
            cmd = new MySqlCommand(query, conn);
            adp = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  Stock set StockName='" + textBox2.Text + "',StockSize='" + textBox3.Text + "',Status='" + comboBox1.SelectedItem + "',UnitPrice='" + textBox5.Text + "',Date='" + textBox6.Text + "'where StockCode='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            display_data();
            MessageBox.Show("Record Updated successfully");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
                if (textBox2.Text == "")
                    MessageBox.Show("Stock Name  is not Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    textBox3.Enabled = true;
                    textBox3.Focus();
                    //textBox2.Enabled = false;
                }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                if (textBox3.Text == "")
                    MessageBox.Show("Stock size is not Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    comboBox1.Enabled = true;
                    comboBox1.Focus();
                    //textBox3.Enabled = false;
                }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox5.Enabled = true;
            textBox5.Focus();
            //comboBox1.Enabled = false;

        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                if (textBox5.Text == "")
                    MessageBox.Show("Stock Cost is not Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    textBox6.Enabled = true;
                    textBox6.Focus();
                    // textBox5.Enabled = false;
                }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                if (textBox6.Text == "")
                    MessageBox.Show("Date is not Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    textBox4.Enabled = true;
                    textBox4.Focus();
                    // textBox6.Enabled = false;
                }
        }

        private void StockDetails_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentRow.Cells["StockCode"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["StockName"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["StockSize"].Value.ToString();
            comboBox1.SelectedItem = dataGridView1.CurrentRow.Cells["Status"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["UnitPrice"].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells["Date"].Value.ToString();


        }

        private void StockDetails_Load(object sender, EventArgs e)
        {

        }
        //uncomment
        //public MySqlDataReader AutoUpdateStock(MySqlDataReader reader)
        //{
        //    DatabaseConnection dc = new DatabaseConnection();
        //    MySqlConnection conn = dc.getConnection();
        //    String ItemName, StockName;
        //    int qty;
        //    double size, stocksize;

        //    while (reader.Read())
        //    {
        //        ItemName = reader[3];
        //        qty = reader[5];

        //        for (int x = 0;, x <= qty; x++)
        //        {
        //            string q1 = "select StockName,StockSize from mealprice where MenuName='" + ItemName + "'";
        //            MySqlCommand cmd = new MySqlCommand(q1, conn);
        //            MySqlDataReader r1 = cmd.ExecuteReader();
        //            while (r1.Read())
        //            {
        //                StockName = r1[4];
        //                size = r1[5];
        //            }

        //            string q2 = "select StockSize from Stock where StockName='" + StockName + "'";
        //            MySqlCommand cmd1 = new MySqlCommand(q2, conn);
        //            MySqlDataReader r2 = cmd1.ExecuteReader();
        //            while (r2.Read())
        //            {
        //                stocksize = r2[3];

        //            }

        //            stocksize = stocksize - size;

        //            conn.Open();
        //            MySqlCommand cmd3 = conn.CreateCommand();
        //            cmd3.CommandType = CommandType.Text;
        //            cmd3.CommandText = "update  Stock set StockName='" + textBox2.Text + "',StockSize='" + stocksize + "',Status='" + comboBox1.SelectedItem + "',UnitPrice='" + textBox5.Text + "',Date='" + textBox6.Text + "'where StockCode='" + textBox1.Text + "'";
        //            cmd.ExecuteNonQuery();

        //        }
        //    }




        //    MySqlDataReader r1 = cmd.ExecuteReader();
        //    while (r1.Read())
        //    {
        //        itemname = r1.GetString("MenuName");
        //    }

        //    string query = "select StockName from mealprice where MenuName='" + itemname + "'";
        //    conn.Open();
        //    MySqlCommand cmd1 = new MySqlCommand(query, conn);

        //    MySqlDataReader reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        itemname = reader.GetString("StockName");
        //    }
        //    reader.Close();

        //    conn.Close();
        //}
                                                            //uncomment
    }
}
