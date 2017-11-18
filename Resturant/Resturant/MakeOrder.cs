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
using System.Runtime.InteropServices;
using Resturant.Properties;
using Customer_Management;

namespace OrderManagement
{
    public partial class MakeOrder : Form
    {
        private int tableno;

        int custid;

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public MakeOrder(int no, int id)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            tableno = no;
            tablelabel.Text = tablelabel.Text + tableno;
            custid = id;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MakeOrder_Load(object sender, EventArgs e)
        {
            fillDataGridViewMenu();
            //fillDataGridViewStarters();
            //fillDataGridViewChicken();
            //fillDataGridViewBeef();
            //fillDataGridViewMainCourse();
            //fillDataGridViewSeafood();
            //fillDataGridViewMutton();
            //fillDataGridViewBun();
            //fillDataGridViewVegetarian();
            //fillDataGridViewBeverages();
            //fillDataGridViewDessert();
        }

        public void fillDataGridViewMenu()
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            conn.Open();

            try
            {
                MySqlCommand com = new MySqlCommand("SELECT itemcode,itemname,Description,portionsize,price,itemimage FROM items WHERE status = 'Active' ORDER BY itemname", conn);

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
                //MessageBox.Show(itemtagcombo.Text);
                MySqlCommand com = new MySqlCommand("SELECT itemcode,itemname,Description,portionsize,price,itemimage FROM items WHERE itemtag = '" + itemtagcombo.Text+ "' AND status = 'Active' ORDER BY itemname", conn);

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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    MySqlCommand com = new MySqlCommand("INSERT INTO orderlist"+tableno+ " (custid,itemcode,itemname,portionsize,quantity,price) VALUES (@custid,@itemcode,@itemname,@portionsize,@quantity,@price)", conn);

                    com.Parameters.Add("@itemcode", MySqlDbType.Int32).Value = itemcode.Text;
                    com.Parameters.Add("@custid", MySqlDbType.Int32).Value = custid;
                    com.Parameters.Add("@itemname", MySqlDbType.VarChar).Value = itemname.Text;
                    com.Parameters.Add("@portionsize", MySqlDbType.VarChar).Value = psize.Text;
                    com.Parameters.Add("@quantity", MySqlDbType.Int32).Value = qty.Value;
                    com.Parameters.Add("@price", MySqlDbType.Float).Value = rate.Text;

                    com.ExecuteNonQuery();

                    
                        MySqlCommand comretrieve = new MySqlCommand("SELECT id,itemcode,itemname,portionsize,quantity,price FROM orderlist" + tableno + " ORDER BY itemname", conn);

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
            catch (Exception ie) {
                MessageBox.Show(ie.Message);
            }

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {

                itemcode.Text = menu.CurrentRow.Cells["itemcode"].Value.ToString();

                itemname.Text = menu.CurrentRow.Cells["itemname"].Value.ToString();

                psize.Text = menu.CurrentRow.Cells["portionsize"].Value.ToString();

                rate.Text = menu.CurrentRow.Cells["price"].Value.ToString();
            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        private void button5_Click(object sender, EventArgs e)
        {
            if (itemtagcombo.Text == "") {
                MessageBox.Show("Please select a value to search");
            }
            else if (itemtagcombo.Text == "All")
            {
                fillDataGridViewMenu();
            }
            else {
                fillDataGridViewSelect();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DatabaseConnection DC = new DatabaseConnection();
            MySqlConnection con = DC.getConnection(); 
            try
            {
                

                con.Open();

                MySqlCommand com = new MySqlCommand("Select * from orderlist"+tableno , con);
                MySqlDataReader read = com.ExecuteReader();


                if (read.Read())
                {
                    ConfirmPayment cp = new ConfirmPayment(tableno);

                    cp.Show();
                }
                else{
                    MessageBox.Show("Please select an item before finalizing order");
                }
            }
            catch (Exception te) {
                MessageBox.Show(te.Message);
                con.Close();
            }

        }

        private void orderlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        //private int rowIndex=0;

        private void orderlist_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            //if (this.dataGridView1.Rows[this.rowIndex].IsNewRow)
            //{
            //    this.dataGridView1.Rows.RemoveAt(this.rowIndex);
            //}

        }

        private void menu_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
        int itemcodedelete=-1;

        private void remove_Click(object sender, EventArgs e)
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            //orderlist.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            try
            {
                //MessageBox.Show(itemcodedelete.ToString());

                tableorder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                tableorder.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                if (itemcodedelete != -1){
                    conn.Open();
                    //MySqlCommand com = new MySqlCommand("INSERT INTO orderlist(itemcode,itemname,portionsize,quantity) VALUES ('" + itemcode.Text + "','" + itemname.Text + "','" + psize.Text + "','" + qty.Value + "')", conn);
                    MySqlCommand com = new MySqlCommand("DELETE FROM orderlist" + tableno + " WHERE id = '" + itemcodedelete  + "'", conn);

                    com.ExecuteNonQuery();


                    MySqlCommand comretrieve = new MySqlCommand("SELECT id,itemcode,itemname,portionsize,quantity,price FROM orderlist" + tableno + " ORDER BY itemname", conn);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(comretrieve);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    tableorder.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


                    tableorder.AllowUserToAddRows = false;
                    tableorder.DataSource = dt;

                    //dataGridView1.Width = dataGridView1.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) + (dataGridView1.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0) + 3;


                    tableorder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }


                    //dataGridView1.Rows.Add(itemcode.Text, itemname.Text, psize.Text, qty.Value);
            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
        }

        private void orderlist_CellMouseUp_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //try
                //{

                //}
                //catch (Exception ie)
                //{
                //    MessageBox.Show("Please right click a row in the table");
                //}

            }
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    this.dataGridView1.Rows[e.RowIndex].Selected = true;
            //    this.rowIndex = e.RowIndex;
            //    this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[0];
            //    this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
            //    contextMenuStrip1.Show(Cursor.Position);
            //}
        }

        private void contextMenuStrip1_Click_1(object sender, EventArgs e)
        {
            //if (this.dataGridView1.Rows[this.rowIndex].IsNewRow)
            //{
            //    this.dataGridView1.Rows.RemoveAt(this.rowIndex);
            //}
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }



        private void tableorder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            itemcodedelete = Convert.ToInt32(tableorder.CurrentRow.Cells["itemcode"].Value);
            string itemnamedelete = tableorder.CurrentRow.Cells["itemname"].Value.ToString();
            //textBox1.Text = itemnamedelete;
        }

        private void tableorder_Click(object sender, EventArgs e)
        {
            itemcodedelete = Convert.ToInt32(tableorder.CurrentRow.Cells["id"].Value);
            string itemnamedelete = tableorder.CurrentRow.Cells["itemname"].Value.ToString();
            //textBox1.Text = itemnamedelete;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void psize_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void qty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rate_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemname_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void itemtagcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseWindow_MouseMove(object sender, MouseEventArgs e)
        {
            CloseWindow.BackgroundImage = Resources.error;
        }

        private void CloseWindow_MouseLeave(object sender, EventArgs e)
        {
            CloseWindow.BackgroundImage = Resources.error__1_;
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.BackgroundImage = Resources.search;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackgroundImage = Resources.search__1_;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = Resources.plus__1_;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackgroundImage = Resources.plus;
        }

        private void remove_MouseLeave(object sender, EventArgs e)
        {
            remove.BackgroundImage = Resources.minus__1_;
        }

        private void remove_MouseMove(object sender, MouseEventArgs e)
        {
            remove.BackgroundImage = Resources.minus;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackgroundImage = Resources.success__1_;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.BackgroundImage = Resources.success;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Resources.backspace_dark;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Resources.left_arrow_thin_symbol_in_circular_button;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseConnection DC = new DatabaseConnection();
            MySqlConnection con = DC.getConnection();
            try
            {


                con.Open();

                MySqlCommand com = new MySqlCommand("Select * from table" + tableno, con);
                MySqlDataReader read = com.ExecuteReader();


                if (read.Read())
                {
                    button1.Visible = false;
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception te)
            {
                MessageBox.Show(te.Message);
                con.Close();
            }
        }
    }
}
