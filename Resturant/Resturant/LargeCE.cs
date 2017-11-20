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
using EventCaterMgt;


namespace supplier
{
    public partial class LargeCE : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=rmsdatabase;Uid=root;Pwd=;");
        MySqlCommand cmd;
        MySqlDataAdapter adp;
        DataTable dt;

        string mcode;

        public LargeCE()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyValue == 13)
                if (textBox1.Text == "")
                    MessageBox.Show("Menu Code  is not Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    mcode = textBox1.Text;
                    mcode = mcode.Trim();
                    if (mcode.Length != 5)
                    {
                        MessageBox.Show("Menu code should have 5 character length ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";
                    }
                    else
                    {
                        if (mcode.StartsWith("LM") == false)
                        {
                            MessageBox.Show("Menu code should start with the letter LM", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            /*if (e.KeyValue == 13)
                if (textBox1.Text == "")
                    MessageBox.Show("Menu Code is not Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    textBox2.Enabled = true;
                    textBox2.Focus();
                    //textBox2.Enabled = false;
                }*/

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {

            /*if (e.KeyValue == 13)
                if (textBox3.Text == "")
                    MessageBox.Show("Stock Name  is not Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    textBox4.Enabled = true;
                    textBox4.Focus();
                    textBox3.Enabled = false;
                }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();

                MySqlConnection con = new MySqlConnection("Server=localhost;Database=rmsdatabase;Uid=root;Pwd=;");
                //insert

                if ((mainMealCombo.Text == "") || (comboBox1.Text == "") || (comboBox1.Text == "") || (textBox1.Text == "") || (textBox4.Text == ""))
                {
                    MessageBox.Show("Field(s) cannnot be blank");

                }

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
                else
                {
                    con.Open();

                    //string option = comboBox4.SelectedItem.ToString();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO large (MenuName,StockName,StockSize,Total) VALUES ('" + mainMealCombo.Text + "','" + comboBox1.SelectedItem + "','" + Convert.ToDouble(textBox1.Text) + "','" + Convert.ToDouble(textBox4.Text) + "')", con);
                    cmd.ExecuteReader();
                    con.Close();

                    //reading database
                    //LoadData();

                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    con.Open();
                    MySqlDataAdapter adp = new MySqlDataAdapter("select * from Large", con);
                    adp.Fill(dt);
                    dataGridView1.DataSource = dt;
                    //this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    adp.Dispose();
                    con.Close();
                    MessageBox.Show(" Menu Details are Added");

                    mainMealCombo.SelectedIndex = -1;

                    comboBox1.SelectedIndex = -1;
                    textBox4.Text = "";
                    //   textBox1.Clear();
                }
            }
            catch (MySqlException ee)
            {
                MessageBox.Show("" + ee, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            createMenu main = new createMenu();
            main.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyValue == 13)
                if (comboBox1.SelectedItem=="")
                    MessageBox.Show("Stock Name is not Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    comboBox2.Enabled = true;
                    comboBox2.Focus();
                    //textBox2.Enabled = false;
                }*/
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyValue == 13)
                if (comboBox2.SelectedItem == "")
                    MessageBox.Show("Stock Size is not Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    textBox1.Enabled = true;
                    textBox1.Focus();
                    //textBox2.Enabled = false;
                }*/
        }

        public void retriveMeal()
        {
           

            string que = "select lunchdinner from lunchdinner;";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(que,con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                mainMealCombo.Items.Add(reader[0].ToString());
            }
            reader.Close();
            con.Close();
                     
            
        }
       /* public void retriveDessert()
        {


            string que = "select * from bevdessert;";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(que, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                beverageCombo.Items.Add(reader[0].ToString());
            }
            reader.Close();
            con.Close();


        }
        */
        private void Large_Load(object sender, EventArgs e)
        {
            try
            {
                retriveMeal();
                //retriveDessert();
                MySqlConnection con = new MySqlConnection("Server=localhost;Database=rmsdatabase;Uid=root;Pwd=;");
                string query = "select * from Stock";
                string que1 = "select distinct MenuName from large ";
                //string que2 = "select * from items";
                //string que3 = "select * from bevdessert";
                //string que4 = "select * from lunchdinner";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString("StockName"));
                }
                reader.Close();
                /*MySqlCommand cmd2= new MySqlCommand(que2, con);

                MySqlDataReader reader2 = cmd.ExecuteReader();
                while (reader2.Read())
                {
                    mainMealCombo.Items.Add(reader.GetString("itemname"));
                }
                reader.Close();*/

                MySqlCommand cmd1 = new MySqlCommand(que1, con);

                MySqlDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    comboBox3.Items.Add(reader1.GetString("MenuName"));
                }
                reader1.Close();

               /* MySqlCommand cmd3 = new MySqlCommand(que3, con);

                MySqlDataReader reader3 = cmd.ExecuteReader();
                while (reader3.Read())
                {
                    beverageCombo.Items.Add(reader.GetString("bevdessert"));
                }
                reader.Close();*/

                /*MySqlCommand cmd4= new MySqlCommand(que4, con);

                MySqlDataReader reader4 = cmd4.ExecuteReader();
                while (reader4.Read())
                {
                    mainMealCombo.Items.Add(reader4.GetString("lunchdinner"));
                }
                reader4.Close();
                */

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //string option = comboBox4.SelectedItem.ToString();
                double price=0;
                con.Open();
                string cmbo3 = comboBox3.SelectedItem.ToString();
                string que = "select sum(Total) as total from Large where MenuName='" + cmbo3 + "'";
               

                MySqlCommand cmd = new MySqlCommand(que, con);
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    price = read.GetDouble("total");
                }
                string que1 = "update lunchdinner set price = '" + price + "' where lunchdinner = '" + cmbo3 + "'";
                read.Close();
                MySqlCommand cmd1 = new MySqlCommand(que1, con);
                MySqlDataReader read1 = cmd1.ExecuteReader();
                


               /* if (read.Read())
                {
                    double price = read.GetDouble("");
                    double size = Convert.ToDouble(comboBox2.SelectedItem);
                    double tot = price * size;
                    textBox4.Text = Convert.ToString(tot);

                    read.Close();
                }*/
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Large where MenuName='" + mainMealCombo.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            display_data();
            MessageBox.Show("Record deleted successfully");
            label8.Text = "";
            mainMealCombo.SelectedIndex=-1;
            comboBox1.SelectedItem = "";
            textBox1.Text = "";
            textBox4.Text = "";


        }

        public void display_data()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Large";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  Large set MenuName='" + mainMealCombo.Text + "',StockName='" + comboBox1.SelectedItem + "',StockSize='" + Convert.ToDouble(textBox1.Text) +"',Total='"+Convert.ToDouble(textBox4.Text)+ "'where MenuCode='" + label8.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            display_data();
            MessageBox.Show("Record Updated successfully");
            label8.Text = "";
            mainMealCombo.SelectedIndex=-1;
            comboBox1.SelectedIndex=-1;
            textBox1.Text = "";
            textBox4.Text = "";


        }

        private void button7_Click(object sender, EventArgs e)
        {
            display_data();
            string valueOfData = textBox3.Text.ToString();
            searchData(valueOfData);
        }

        public void searchData(string valueOfData)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=rmsdatabase;Uid=root;Pwd=;");
            MySqlCommand cmd;

            string query = "select * from Large where CONCAT(MenuCode,MenuName,StockName,StockSize,Total) like '%" + valueOfData + "%'";
            cmd = new MySqlCommand(query, con);
            adp = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        { }
           
           
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                label8.Text = row.Cells[0].Value.ToString();
                mainMealCombo.Text = row.Cells[1].Value.ToString();
                comboBox1.SelectedItem = row.Cells[2].Value.ToString();
                textBox1.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();
                
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string cmbo1 = comboBox1.SelectedItem.ToString();
                string que = "select UnitPrice from Stock where StockName='" + cmbo1 + "'";

                MySqlCommand cmd = new MySqlCommand(que, con);
                MySqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    double price = read.GetDouble("UnitPrice");
                    double size = Convert.ToDouble(textBox1.Text);
                    double tot = price * size;
                    textBox4.Text = Convert.ToString(tot);

                    read.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                label8.Text = row.Cells[0].Value.ToString();
                mainMealCombo.Text = row.Cells[1].Value.ToString();
                comboBox1.SelectedItem = row.Cells[2].Value.ToString();
                textBox1.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();

            }
        }
    }

}

        /*public void LoadData()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=project;Uid=root;Pwd=;");

            MySqlDataAdapter sda = new MySqlDataAdapter("select *from Large", con);
            DataTable dt = new DataTable();
            //sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["MenuCode"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["MenuName"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["Ingredients"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Total"].ToString();

            }
        }
    }
}*/