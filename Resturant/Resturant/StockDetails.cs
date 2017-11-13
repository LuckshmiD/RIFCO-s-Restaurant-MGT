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



namespace supplier
{
    public partial class Stockdetails : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=rmsdatabase;Uid=root;Pwd=;");
        MySqlCommand cmd;
        MySqlDataAdapter adp;
        DataTable dt;


        string code;



        /*private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                if (textBox4.Text == "")
                    MessageBox.Show("Status  is not Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    textBox5.Enabled = true;
                    textBox5.Focus();
                    textBox4.Enabled = false;
                }
        }*/

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                if (textBox5.Text == "")
                    MessageBox.Show("Stock Cost is not Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    //textBox6.Enabled = true;
                    //textBox6.Focus();
                    // textBox5.Enabled = false;
                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
            textBox5.Focus();
            comboBox1.Enabled = false;

        }

        private void Stockdetails_Load(object sender, EventArgs e)
        {
            searchData("");
            display_data();

            comboBox1.SelectedIndex = 0;
            //LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();

                MySqlConnection con = new MySqlConnection("Server=localhost;Database=rmsdatabase;Uid=root;Pwd=;");
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

                con.Open();

                MySqlCommand cmd = new MySqlCommand(@"INSERT INTO Stock
                                  (StockName,StockSize,Status,UnitPrice,Date)
                              VALUES
                                   ('" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Text + "')", con);
                cmd.ExecuteReader();
                con.Close();
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
                con.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter("select * from Stock", con);
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                adp.Dispose();
                con.Close();
                MessageBox.Show("Stock Details are Added");
                textBox2.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
                //textBox6.Text = "";
            }
            catch (MySqlException ee)
            {
                MessageBox.Show("" + ee, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        /* private bool IfSupplierExists(MySqlConnection con, string code)
         {
             MySqlDataAdapter sda = new MySqlDataAdapter("select 1 from Stock where StockCode ='" + code + "'", con);
             DataTable dt = new DataTable();
             sda.Fill(dt);
             if (dt.Rows.Count > 0)
                 return true;
             else
                 return false;
         }

         public void LoadData()
         {
             MySqlConnection con = new MySqlConnection("Server=localhost;Database=project;Uid=root;Pwd=;");

             MySqlDataAdapter sda = new MySqlDataAdapter("select *from Stock", con);
             DataTable dt = new DataTable();
             //sda.Fill(dt);
             dataGridView1.Rows.Clear();

             foreach (DataRow item in dt.Rows)
             {
                 int n = dataGridView1.Rows.Add();
                 dataGridView1.Rows[n].Cells[0].Value = item["StockCode"].ToString();
                 dataGridView1.Rows[n].Cells[1].Value = item["StockName"].ToString();
                 dataGridView1.Rows[n].Cells[2].Value = item["StockSize"].ToString();
                
             if ((bool)item["Status"])
                 {
                     dataGridView1.Rows[n].Cells[3].Value = "Active";

                 }
                 else
                 {
                     dataGridView1.Rows[n].Cells[3].Value = "Deactive";
                 }

                 dataGridView1.Rows[n].Cells[4].Value = item["Cost"].ToString();
                 dataGridView1.Rows[n].Cells[5].Value = item["Date"].ToString();

             }
         }*/

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

        public Stockdetails()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyValue == 13)
                if (textBox1.Text == "")
                    MessageBox.Show("Stock code  is not Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    code = textBox1.Text;
                    code = code.Trim();
                    if (code.Length != 5)
                    {
                        MessageBox.Show("Stock code should have 5 character length ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";
                    }
                    else
                    {
                        if (code.StartsWith("S") == false)
                        {
                            MessageBox.Show("Stock code should start with the letter S", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox1.Text = "";
                        }
                        else
                        {
                            textBox2.Enabled = true;
                            textBox2.Focus();
                            textBox1.Enabled = false;
                        }
                    }
                }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                if (textBox4.Text == "")
                    MessageBox.Show("Stock Name  is not Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    textBox2.Enabled = true;
                    textBox2.Focus();
                    // textBox4.Enabled = false;
                }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                if (dateTimePicker1.Text == "")
                    MessageBox.Show("Date is not Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    textBox4.Enabled = true;
                    textBox4.Focus();
                    // textBox6.Enabled = false;
                }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  Stock set StockName='" + textBox2.Text + "',StockSize='" + textBox3.Text + "',Status='" + comboBox1.SelectedItem + "',UnitPrice='" +Convert.ToInt32(textBox5.Text) + "',Date='" + dateTimePicker1.Text + "'where StockCode='" + label9.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            display_data();
            MessageBox.Show("Record Updated successfully");
            label9.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            dateTimePicker1.Text = "";

        }

        public void display_data()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Stock";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from stock where StockName='" + textBox2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            display_data();
            MessageBox.Show("Record deleted successfully");
            label9.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            //textBox6.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string valueOfData = textBox4.Text.ToString();
            searchData(valueOfData);
        }

        public void searchData(string valueOfData)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=rmsdatabase;Uid=root;Pwd=;");
            MySqlCommand cmd;

            string query = "select * from stock where CONCAT(StockCode,StockName,StockSize,Status,UnitPrice,Date) like '%" + valueOfData + "%'";
            cmd = new MySqlCommand(query, con);
            adp = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                label9.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                comboBox1.SelectedItem = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
                dateTimePicker1.Text = row.Cells[5].Value.ToString();
            }
        }

    }
}