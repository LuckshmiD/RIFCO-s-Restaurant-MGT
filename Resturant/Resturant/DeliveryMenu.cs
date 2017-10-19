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
using System.IO;
using System.Drawing.Imaging;
using Cashier;
//using Cashier;

namespace OrderManagement
{
    public partial class DeliveryMenu : Form
    {
        public DeliveryMenu()
        {
            InitializeComponent();
        }

        int itemcodedelete = -1;

        public void fillDataGridViewMenu()
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            conn.Open();

            try
            {
                MySqlCommand com = new MySqlCommand("SELECT itemcode,itemname,Description,portionsize,itemimage FROM items WHERE status = 'Active' ORDER BY itemname", conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                menu.RowTemplate.Height = 80;

                menu.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


                menu.AllowUserToAddRows = false;
                menu.DataSource = dt;

                //dataGridView1.Width = dataGridView1.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) + (dataGridView1.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0) + 3;

                DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
                imgcol = (DataGridViewImageColumn)menu.Columns["itemimage"];



                imgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;

                menu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void fillDataGridViewSelect()
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            conn.Open();

            try
            {
                MessageBox.Show(itemtagcombo.Text);
                MySqlCommand com = new MySqlCommand("SELECT itemcode,itemname,Description,portionsize,itemimage FROM items WHERE itemtag = '" + itemtagcombo.Text + "' AND status = 'Active' ORDER BY itemname", conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);

                DataTable dt = new DataTable();


                adapter.Fill(dt);

                menu.RowTemplate.Height = 80;

                menu.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


                menu.AllowUserToAddRows = false;
                menu.DataSource = dt;

                DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
                imgcol = (DataGridViewImageColumn)menu.Columns["itemimage"];



                imgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;

                menu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (itemtagcombo.Text == "")
            {
                MessageBox.Show("Please select a value to search");
            }
            else if (itemtagcombo.Text == "All")
            {
                fillDataGridViewMenu();
            }
            else
            {
                fillDataGridViewSelect();
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            try
            {

                itemcode.Text = menu.CurrentRow.Cells["itemcode"].Value.ToString();

                itemname.Text = menu.CurrentRow.Cells["itemname"].Value.ToString();

                psize.Text = menu.CurrentRow.Cells["portionsize"].Value.ToString();

            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
        }

        private void DeliveryMenu_Load(object sender, EventArgs e)
        {
            fillDataGridViewMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            //orderlist.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            try
            {


                tableorder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                tableorder.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                if (itemcode.Text != "" && itemname.Text != "" && psize.Text != "" && qty.Value != 0)
                {
                    conn.Open();
                    //MySqlCommand com = new MySqlCommand("INSERT INTO orderlist(itemcode,itemname,portionsize,quantity) VALUES ('" + itemcode.Text + "','" + itemname.Text + "','" + psize.Text + "','" + qty.Value + "')", conn);
                    MySqlCommand com = new MySqlCommand("INSERT INTO orderlistdel (itemcode,itemname,portionsize,quantity) VALUES (@itemcode,@itemname,@portionsize,@quantity)", conn);

                    com.Parameters.Add("@itemcode", MySqlDbType.Int32).Value = itemcode.Text;
                    com.Parameters.Add("@itemname", MySqlDbType.VarChar).Value = itemname.Text;
                    com.Parameters.Add("@portionsize", MySqlDbType.VarChar).Value = psize.Text;
                    com.Parameters.Add("@quantity", MySqlDbType.Int32).Value = qty.Value;

                    com.ExecuteNonQuery();


                    MySqlCommand comretrieve = new MySqlCommand("SELECT * FROM orderlistdel ORDER BY itemname", conn);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(comretrieve);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    tableorder.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


                    tableorder.AllowUserToAddRows = false;
                    tableorder.DataSource = dt;

                    //dataGridView1.Width = dataGridView1.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) + (dataGridView1.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0) + 3;


                    tableorder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;




                    //dataGridView1.Rows.Add(itemcode.Text, itemname.Text, psize.Text, qty.Value);
                }
                else if (itemcode.Text == "" || itemname.Text == "" || psize.Text == "")
                {
                    MessageBox.Show("Please select and item to add");
                }
                else if (qty.Value == 0)
                {
                    MessageBox.Show("Please input quantity for the product");
                }
            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
        }

        

        private void remove_Click(object sender, EventArgs e)
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            //orderlist.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            try
            {
                MessageBox.Show(itemcodedelete.ToString());

                tableorder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                tableorder.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                if (itemcodedelete != -1)
                {
                    conn.Open();
                    //MySqlCommand com = new MySqlCommand("INSERT INTO orderlist(itemcode,itemname,portionsize,quantity) VALUES ('" + itemcode.Text + "','" + itemname.Text + "','" + psize.Text + "','" + qty.Value + "')", conn);
                    MySqlCommand com = new MySqlCommand("DELETE FROM orderlistdel WHERE id = '" + itemcodedelete + "'", conn);

                    com.ExecuteNonQuery();


                    MySqlCommand comretrieve = new MySqlCommand("SELECT * FROM orderlistdel ORDER BY itemname", conn);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(comretrieve);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    tableorder.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


                    tableorder.AllowUserToAddRows = false;
                    tableorder.DataSource = dt;

                    


                    tableorder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }


                //dataGridView1.Rows.Add(itemcode.Text, itemname.Text, psize.Text, qty.Value);
            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            //orderlist.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            try
            {
                conn.Open();

                MySqlCommand com2 = new MySqlCommand("DELETE FROM table1", conn);

                com2.ExecuteNonQuery();

                MySqlCommand com = new MySqlCommand("INSERT INTO `orders`(`custid`,`itemid`,`ordertype`,`quantity`,`date`) SELECT `itemcode`,`itemname`,`portionsize`,`quantity`,`price` FROM `orderlistdel` ", conn);

                com.ExecuteNonQuery();

                //db.executeStatement("INSERT INTO `table2`(`item_id`,`item_name`,`potionsize`,`quantity`,`price`) SELECT `itemcode`,`itemname`,`portionsize`,`quantity`,`price` FROM `orderlist2` ");


                //com.Parameters.Add("@itemcode", MySqlDbType.Int32).Value = itemcode.Text;
                //com.Parameters.Add("@itemname", MySqlDbType.VarChar).Value = itemname.Text;
                //com.Parameters.Add("@portionsize", MySqlDbType.VarChar).Value = psize.Text;
                //com.Parameters.Add("@quantity", MySqlDbType.Int32).Value = qty.Value;

                ConfirmPayment cp = new ConfirmPayment(1);
                MessageBox.Show("Order dispatched");
                cp.Show();

                conn.Close();


                //this.Hide();

            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void tableorder_Click(object sender, EventArgs e)
        {
            itemcodedelete = Convert.ToInt32(tableorder.CurrentRow.Cells["id"].Value);
            string itemnamedelete = tableorder.CurrentRow.Cells["itemname"].Value.ToString();
            //textBox1.Text = itemnamedelete;
        }
    }
}
