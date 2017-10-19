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
    public partial class Recipe : Form
    {
        MySqlCommand cmd;
        MySqlDataAdapter adp;
        DataTable dt;

        public Recipe()
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

                MySqlCommand cmd = new MySqlCommand(@"INSERT INTO Large
                                  (MenuCode,MenuName,StockName,StockSize)
                              VALUES
                                   ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.SelectedItem + "','" + textBox4.Text + "')'",conn);
                cmd.ExecuteReader();
                conn.Close();

                //reading database
                //LoadData();

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                conn.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter("select * from Large", conn);
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                //this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                adp.Dispose();
                conn.Close();
                MessageBox.Show("Large Menu Details are Added");
            }
            catch (MySqlException ee)
            {
                MessageBox.Show("" + ee, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Large where MenuName='" + textBox2.Text + "'";
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
            comboBox1.SelectedItem = "";
            textBox4.Text = "";
           
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

        private void button6_Click(object sender, EventArgs e)
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  Large set MenuName='" + textBox2.Text + "',StockName='" + comboBox1.SelectedItem + "',StockSize='" + textBox4.Text + "'where MenuCode='" + textBox1.Text + "'";
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
            comboBox1.SelectedItem = "";
            textBox4.Text = "";
         

        }

        private void button7_Click(object sender, EventArgs e)
        {

            string valueOfData = textBox5.Text.ToString();
            searchData(valueOfData);
        }

        public void searchData(string valueOfData)
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            MySqlCommand cmd;

            string query = "select * from Large where CONCAT(MenuCode,MenuName,StockName,StockSize,Total) like '%" + valueOfData + "%'";
            cmd = new MySqlCommand(query, conn);
            adp = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                if (textBox2.Text == "")
                    MessageBox.Show("Menu Name  is not Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    comboBox1.Enabled = true;
                    comboBox1.Focus();

                }
        }

        private void Recipe_Load(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnection dc = new DatabaseConnection();
                MySqlConnection conn = dc.getConnection();

                string query = "select * from Stock";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString("StockName"));
                }
                reader.Close();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
                if (textBox4.Text == "")
                    MessageBox.Show("Menu Name  is not Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    textBox2.Enabled = true;
                    textBox2.Focus();


                }
        }
    }
}
