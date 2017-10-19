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
    public partial class SupplierDetailsSu : Form
    {
        MySqlCommand cmd;
        MySqlDataAdapter adp;
        DataTable dt;
        string pno,code;

        public SupplierDetailsSu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnection dc = new DatabaseConnection();
                MySqlConnection conn = dc.getConnection();

                DataTable dt = new DataTable();

                
                //insert 

                String type = comboBox1.Text;
                /*if (type =="")
                {
                    type = "Active";

                }
                else
                {
                    type ="Deactive";
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

                MySqlCommand cmd = new MySqlCommand(@"INSERT INTO supplier
                                  (SupplierCode,SupplierName,Address,Status,District,PhoneNumber,EmailAddress)
                              VALUES
                                   ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + comboBox1.Text + "','" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "')", conn);
                cmd.ExecuteReader();
                conn.Close();
                //remove the all the rows of the table
                /*while(dataGridView1.Rows.Count>1)
                {
                    dataGridView1.Rows.RemoveAt(0);
                }*/

                //reading database
                //LoadData();

                dataGridView1.DataSource = null;
                //dataGridView1.Rows.Clear();
                // dataGridView1.Refresh();
                conn.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter("select * from supplier", conn);
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                adp.Dispose();
                conn.Close();
                MessageBox.Show("Supplier Details are Added successfully");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
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
            cmd.CommandText = "delete from supplier where SupplierName='" + textBox2.Text + "'";
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
            string valueOfData = textBox7.Text.ToString();
            searchData(valueOfData);

        }

        public void searchData(string valueOfData)
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            MySqlCommand cmd;

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
            cmd.CommandText = "update  Supplier set SupplierName='" + textBox2.Text + "',Address='" + textBox3.Text + "',Status='" + comboBox1.SelectedItem + "',District='" + textBox4.Text + "',PhoneNumber='" + textBox5.Text + "',EmailAddress='" + textBox6.Text + "'where SupplierCode='" + textBox1.Text + "'";
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
                    MessageBox.Show("Supplier Name  is not Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    textBox3.Enabled = true;
                    textBox3.Focus();
                    // textBox2.Enabled = false;
                }
        
    }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                if (textBox3.Text == "")
                    MessageBox.Show("Address is not Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    textBox4.Enabled = true;
                    textBox4.Focus();
                    //textBox3.Enabled = false;
                }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                if (textBox4.Text == "")
                    MessageBox.Show("District  is not Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    textBox5.Enabled = true;
                    textBox5.Focus();
                    // textBox4.Enabled = false;
                }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
                if (textBox5.Text == "")
                    MessageBox.Show("Phone Number is not Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    pno = textBox5.Text;
                    pno = pno.Trim();
                    if (pno.Length != 10)
                    {
                        MessageBox.Show("Phone Number should have 10 character length ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox5.Text = "";
                    }
                    else
                    {
                        if (code.StartsWith("0") == false)
                        {
                            MessageBox.Show("Phone Number should start with the letter 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox5.Text = "";
                        }
                        else
                        {
                            textBox6.Enabled = true;
                            textBox6.Focus();
                            textBox5.Enabled = false;
                        }
                    }
                }
                }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
                if (textBox6.Text == "")
                    MessageBox.Show("Email Address   is not Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    textBox1.Enabled = true;
                    textBox1.Focus();
                    textBox6.Enabled = false;
                }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["SupplierCode"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["SupplierName"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["Address"].Value.ToString();
            comboBox1.SelectedItem = dataGridView1.CurrentRow.Cells["Status"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["District"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["Phonenumber"].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells["EmailAddress"].Value.ToString();

        }
    }
}
