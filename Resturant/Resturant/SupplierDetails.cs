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
    public partial class SupplierDetails : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=rmsdatabase;Uid=root;Pwd=;");
        MySqlCommand cmd;
        MySqlDataAdapter adp;
        DataTable dt;

       
        string code,pno;

        private void SupplierDetails_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            searchData("");
            display_data();

            //LoadData();
        }

        public void display_data()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Supplier";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }


       /* private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("Server=localhost;Database=project;Uid=root;Pwd=;");
                //insert 

                bool status = false;
                if (comboBox1.SelectedIndex == 0)
                {
                    status = true;

                }
                else
                {
                    status = false;
                }

                /*var sqlQuery = "";
                if(IfSupplierExists(con,textBox1.Text))
                {
                    sqlQuery = @"UPDATE [dbo].[Supplier] SET [Name] ='" + textBox2.Text + "',[Address] = '" + textBox3.Text + "',[District] = '" + textBox4.Text + "',[PhoneNo] = '" + textBox5.Text + "',[Email] = '" + textBox6.Text + "',[Status] ='" + comboBox1.SelectedIndex + "'  WHERE <[SupplierCode] ='" + textBox1.Text + "')";
                }
                else
                {
                    sqlQuery = @"INSERT INTO [dbo].[Supplier]
                                      ([SupplierCode],[Name],[Address],[District],[PhoneNo],[Email],[Status])
                                  VALUES
                                       ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox1.SelectedIndex + "')";
                }*/

                /*con.Open();
                MySqlCommand cmd = new MySqlCommand(@"INSERT INTO Supplier
                                  (SupplierCode,SupplierName,Address,Status,District,PhoneNumber,EmailAddress)
                              VALUES
                                   ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + comboBox1.SelectedIndex +"','" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "')", con);
                cmd.ExecuteReader();
                con.Close();

                //reading database
                LoadData();
            }
            catch(MySqlException ee)
            {
                MessageBox.Show("" + ee, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }*/

        /*private bool IfSupplierExists(MySqlConnection con,string code)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter("select 1 from Supplier where SupplierCode ='"+code+ "'", con);
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

            MySqlDataAdapter sda = new MySqlDataAdapter("select *from Supplier", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["SupplierCode"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["SupplierName"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["Address"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["District"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["PhoneNumber"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["EmailAddress"].ToString();

                if ((bool)item["Status"])
                {
                    dataGridView1.Rows[n].Cells[6].Value = "Active";

                }
                else
                {
                    dataGridView1.Rows[n].Cells[6].Value = "Deactive";
                }

            }
        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        public SupplierDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyValue == 13)
                if (textBox1.Text == "")
                    MessageBox.Show("Supplier code  is not Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    code = textBox1.Text;
                    code = code.Trim();
                    if (code.Length != 5)
                    {
                        MessageBox.Show("Supplier code should have 5 character length ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";
                    }
                    else
                    {
                        if (code.StartsWith("P") == false)
                        {
                            MessageBox.Show("Stock code should start with the letter P", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label10.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox1.Text=dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

            /*if (dataGridView1.Rows[0].Cells[7].Value.ToString()== "Active")
            {
                comboBox1.SelectedIndex = 0;

            }
            else
            {
                comboBox1.SelectedIndex = 1;
            }*/
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataTable dt= new DataTable();

                MySqlConnection con = new MySqlConnection("Server=localhost;Database=rmsdatabase;Uid=root;Pwd=;");
                //insert 

                String type =comboBox1.Text;
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

                con.Open();

                MySqlCommand cmd = new MySqlCommand(@"INSERT INTO supplier
                                  (SupplierName,Address,Status,District,PhoneNumber,EmailAddress)
                              VALUES
                                   ( '" + textBox2.Text + "', '" + textBox3.Text + "', '" + comboBox1.Text + "','" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "')", con);
                cmd.ExecuteReader();
                con.Close();
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
                con.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter("select * from supplier", con);
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                adp.Dispose();
                con.Close();
                MessageBox.Show("Supplier Details are Added successfully");
                
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
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
                            //textBox5.Enabled = false;
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
                    textBox2.Enabled = true;
                    textBox2.Focus();
                    //textBox6.Enabled = false;
                }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            label10.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                if (textBox7.Text == "")
                    MessageBox.Show("Supplier Name  is not Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    textBox2.Enabled = true;
                    textBox2.Focus();
                    //textBox7.Enabled = false;
                }
        }

        private void textBox5_KeyDown_1(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox6_KeyDown_1(object sender, KeyEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from supplier where SupplierName='"+textBox2.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            display_data();
            MessageBox.Show("Record deleted successfully");
            label10.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";


        }

        public void searchData(string valueOfData)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=rmsdatabase;Uid=root;Pwd=;");
            MySqlCommand cmd;

            string query = "select * from supplier where CONCAT(SupplierCode,SupplierName,Address,Status,District,PhoneNumber,EmailAddress) like '%" + valueOfData + "%'";
            cmd = new  MySqlCommand(query, con);
            adp = new MySqlDataAdapter(cmd);
            dt= new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;






        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                label10.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                comboBox1.SelectedItem = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();
                textBox5.Text = row.Cells[5].Value.ToString();
                textBox6.Text = row.Cells[6].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string valueOfData = textBox7.Text.ToString();
            searchData(valueOfData);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  Supplier set SupplierName='" + textBox2.Text + "',Address='"+textBox3.Text+"',Status='"+comboBox1.SelectedItem+"',District='"+textBox4.Text+"',PhoneNumber='"+textBox5.Text+"',EmailAddress='"+textBox6.Text+"'where SupplierCode='"+label10.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            display_data();
            MessageBox.Show("Record Updated successfully");
            label10.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            

        }
    }
}
