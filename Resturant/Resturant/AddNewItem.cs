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
using System.Runtime.InteropServices;
using Resturant.Properties;

namespace OrderManagement
{
    public partial class AddNewItem : Form
    {
        private Item updateitem,additem;

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

        public AddNewItem()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            updateItem.Visible = false;
        }

        //public AddNewItem(int phonenumber)
        //{

        //    InitializeComponent();
        //    updateItem.Visible = false;
        //}

        private void AddItem_Click(object sender, EventArgs e)
        {
            bool itmnexists;
            bool checkPSize = false, checkitemtag =false,checkstatus = false;
            string porsize = "";

            // An item object is created


            try
            {


                DatabaseConnection dc = new DatabaseConnection();
                MySqlConnection conn = dc.getConnection();

                conn.Open();
                //MessageBox.Show("Database connection established");

                // For convenience the string of Portion size is simplified by
                // taking the first letter of each size category
                //MessageBox.Show(psizef.Text);
                if (psizef.Text == "Small")
                {
                    porsize = "s";
                    checkPSize = true;
                }
                else if (psizef.Text == "Medium")
                {
                    porsize = "m";
                    checkPSize = true;
                }
                else if (psizef.Text == "Large")
                {
                    porsize = "l";
                    checkPSize = true;
                }
                // This makes sure that an incorrect input for the portion size isnt made
                else
                {
                    checkPSize = false;
                }

                //MessageBox.Show(status.Text);

                if (status.SelectedItem == null)
                {
                    checkstatus = false;
                }
                else
                {
                    checkstatus = true;
                }

                //MessageBox.Show(status.Text);

                if (itemtagf.SelectedItem == null)
                {
                    checkitemtag = false;
                }
                else {
                    checkitemtag = true;
                }

                //MessageBox.Show(itemtagf.SelectedItem.ToString());
                //if (itemnamef.Text=="")
                //{
                //    MessageBox.Show("Please enter an item name for the item");
                //}
                Item itemcheck = new Item(itemnamef.Text);

                // Validates the item name if it already exists in the database
                itmnexists = itemcheck.itemnamePreexistingInput();

                // If the itemname and code doesnt exist the insertion takes place
                if (itmnexists != true && checkPSize == true && desc.Text != "" && itemnamef.Text!="" && itemtagf.Text != "" && status.Text != "")
                {
                    additem = new Item(itemnamef.Text, itemtagf.Text, desc.Text, psizef.Text);

                    //MessageBox.Show("This : " + additem.getItemTag());

                    MemoryStream ms = new MemoryStream();
                    imagebox.Image.Save(ms, imagebox.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    //suganthy
                    
                    float price = 0;
                    //conn.Open();
                    string cmbo1 = itemnamef.Text;
                    string que = "select sum(Total) as total from recipe where ItemName='" + cmbo1 + "'";


                    MySqlCommand cmd = new MySqlCommand(que, conn);
                    MySqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        price = read.GetFloat("total");
                    }
                    read.Close();

                    //MessageBox.Show(Convert.ToString(price));
                    //suganthy
                    MySqlCommand com= new MySqlCommand("INSERT INTO items(itemname,Description,itemtag,status,portionsize,itemimage,price) VALUES (@itemname,@description,@itemtag,@status,@portionsize,@image,'"+price+"') ", conn);

                    com.Parameters.Add("@itemname",MySqlDbType.VarChar).Value = additem.getItemName();
                    com.Parameters.Add("@description", MySqlDbType.VarChar).Value = additem.getDescription();
                    com.Parameters.Add("@itemtag", MySqlDbType.VarChar).Value = additem.getItemTag();
                    com.Parameters.Add("@status", MySqlDbType.VarChar).Value = status.Text;
                    com.Parameters.Add("@portionsize", MySqlDbType.VarChar).Value = additem.getPSize();
                    com.Parameters.Add("@image", MySqlDbType.MediumBlob).Value = img;
                    //com.Parameters.Add(price, MySqlDbType.MediumBlob).Value = img;

                    com.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Item added to database successfully");
                }
                // Else the corresponding error will be displayed
                else if (itemnamef.Text == "")
                {
                    MessageBox.Show("Please enter an item name for the item");
                }
                else if (desc.Text == "")
                {
                    MessageBox.Show("Please enter a description for the item");
                }
                else if (checkPSize != true)
                {
                    MessageBox.Show("Invalid Selection, Please select a value for the Portion size");
                }
                else if (itemtagf.Text == "")
                {
                    MessageBox.Show("Invalid Selection, Please select a value for the Portion size");
                }
                else if (status.Text == "")
                {
                    MessageBox.Show("Invalid Selection, Please select a value for the status");
                }
                // Else the corresponding error will be displayed
                else if (itmnexists == true)
                {
                    MessageBox.Show("The Itemname Already exists");
                }

                /////////////////////////////////////////////////////Suganthy/////////\/////////////////////////////////////////////////

                /* try
                {
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

                /*conn.Open();

                //string option = comboBox4.SelectedItem.ToString();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO recipe (ItemName,StockName,StockSize,Total) VALUES ('" + itemnamef.Text + "','" + comboBox1.SelectedItem + "','" + quantity.Text + "','" + totalprice.Text + "')", conn);
                cmd.ExecuteReader();
                conn.Close();

                //reading database
                //LoadData();

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                conn.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter("select * from recipe", conn);
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                //this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                adp.Dispose();
                conn.Close();
                MessageBox.Show(" Menu Details are Added");
                comboBox1.SelectedItem = "";
                quantity.Text = "";
                totalprice.Text = "";

            }
            catch (MySqlException ee)
            {
                MessageBox.Show("" + ee, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

                
                
                try
                {
                    DatabaseConnection dc2 = new DatabaseConnection();
                    MySqlConnection conn2 = dc2.getConnection();
                    string que1 = "INSERT INTO `mealprice`(`MenuId`,`MenuName`,`StockName`,'StocSize',`Total`) SELECT `MenuId`,`ItemName`,`StockName`.'StockSize',`Total` FROM `recipe`)";
                    MySqlCommand cmd = new MySqlCommand(que1, conn2);

                    cmd.ExecuteNonQuery();

                    //MySqlDataReader read = cmd.ExecuteReader();
                    //read.Close();
                    
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                    conn.Close();
                }
                finally
                {
                    
                }


                //////////////////////////////////////////////////////Suganthy///////////////////////////////////////////////////////////

                fillDataGridView();
            }

            // The folowing code snippet validates of the itemcode(to be an integer) 
            // and rate(to be a float) will take place
            catch (FormatException )
            {
                MessageBox.Show("The input was not in a correct format");
            }
            // Any errors regarding the MySql connection will be handled here
            catch (MySqlException mse)
            {
                MessageBox.Show(mse.Message);
            }
            catch (Exception ie) {
                MessageBox.Show(ie.Message);
                MessageBox.Show("Please Select an image for the item");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void psizef_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void itemnamef_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemcodef_TextChanged(object sender, EventArgs e)
        {

        }

        public void fillDataGridView()
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            conn.Open();
            try {
                MySqlCommand com = new MySqlCommand("SELECT itemcode,itemname,Description,itemtag,status,portionsize,price,itemimage FROM items where itemname like '" + itemnamesearch.Text + "%'  ORDER BY itemtag,itemname", conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dataGridView1.RowTemplate.Height = 80;

                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.DataSource = dt;

                DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
                imgcol = (DataGridViewImageColumn)dataGridView1.Columns["itemimage"];

                imgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();

                opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

                if (opf.ShowDialog() == DialogResult.OK)
                {
                    imagebox.Image = Image.FromFile(opf.FileName);
                }
            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
        }

        private void AddNewItem_Load(object sender, EventArgs e)
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
            fillDataGridView();
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

            ////////////////////////////////suganthy/////////////////////////////////////////////////////////{
            DatabaseConnection dcitem = new DatabaseConnection();
            MySqlConnection connitem = dcitem.getConnection();
            connitem.Open();
            string que2 = "delete from recipe ";
            MySqlCommand cmd2 = new MySqlCommand(que2, connitem);
            cmd2.ExecuteNonQuery();
            connitem.Close();

            connitem.Open();
            DataTable dt = new DataTable();

            string itemname = dataGridView1.CurrentRow.Cells["itemname"].Value.ToString();

            string addrecipe = "Insert into `recipe` (`MenuId`,`ItemName`,`StockName`,`StockSize`,`Total`) select `MenuId`,`MenuName`,`StockName`,`StockSize`,`Total` from mealprice  where MenuName='" + itemname + "'";
            MySqlCommand addrec = new MySqlCommand(addrecipe, connitem);
            addrec.ExecuteNonQuery();

            
            string queitem = "select * from mealprice where MenuName='"+itemname+"'";
            MySqlCommand cmditem = new MySqlCommand(queitem, connitem);
            MySqlDataAdapter adp = new MySqlDataAdapter(queitem,connitem);
            adp.Fill(dt);
            dataGridView2.DataSource = dt;
            adp.Dispose();

            
            connitem.Close();

            //connitem.Open();
            //MySqlDataReader reader = cmditem.ExecuteReader();
            //while (reader.Read())
            //{

            //    itemcode.Text = dataGridView2.CurrentRow.Cells["MenuId"].Value.ToString();

            //   // itemnamef.Text = dataGridView2.CurrentRow.Cells["itemname"].Value.ToString();

            //    comboBox1.Text = dataGridView2.CurrentRow.Cells["StockName"].Value.ToString();

            //    quantity.Text = dataGridView2.CurrentRow.Cells["StockSize"].Value.ToString();

            //    totalprice.Text = dataGridView2.CurrentRow.Cells["Total"].Value.ToString();
            //}
            //connitem.Close();


            



            //////////////////////////////////suganthy///////////////////////////////////////////////////////}
            string itemcodedgv,statusn;

            //psizef.SelectedItem = null;
            try
            {
                updateItem.Visible = true;
                AddItem.Visible = false;
                updateitem = new Item();

                Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells["itemimage"].Value;

                MemoryStream ms = new MemoryStream(img);

                imagebox.Image = Image.FromStream(ms);

                itemcodedgv = dataGridView1.CurrentRow.Cells["itemcode"].Value.ToString();

                itemnamef.Text = dataGridView1.CurrentRow.Cells["itemname"].Value.ToString();

                desc.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
                
                string portion = dataGridView1.CurrentRow.Cells["portionsize"].Value.ToString();

                itemtagf.SelectedItem = dataGridView1.CurrentRow.Cells["itemtag"].Value.ToString();

                statusn = dataGridView1.CurrentRow.Cells["status"].Value.ToString();

                if (statusn == "Active" )
                {
                    status.SelectedItem = "Active";
                }
                else if (statusn == "Inactive")
                {
                    status.SelectedItem = "Inactive";
                }


                if (portion == "s" || portion == "S")
                {
                    psizef.SelectedItem = "Small";
                }
                else if (portion == "m" || portion == "M")
                {
                    psizef.SelectedItem = "Medium";
                }
                else if (portion == "l" || portion == "L")
                {
                    psizef.SelectedItem = "Large";
                }


                updateitem.setItemCode(Convert.ToInt32(itemcodedgv));
                updateitem.setItemName(itemnamef.Text);
                updateitem.setDescription(desc.Text);
                updateitem.setPSize(psizef.SelectedItem.ToString());
                updateitem.setItemTag(itemtagf.SelectedItem.ToString());

                //MessageBox.Show(updateitem.getItemCode().ToString());
                //MessageBox.Show(updateitem.getDescription());
                //MessageBox.Show(updateitem.getItemName());
                //MessageBox.Show(updateitem.getPSize());
                //MessageBox.Show(updateitem.getItemTag());

            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
            
        }

        private void imagebox_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void updateItem_Click(object sender, EventArgs e)
        {
            bool itmnexists;
            bool checkPSize = false;


            try
            {

                DatabaseConnection dc = new DatabaseConnection();
                MySqlConnection conn = dc.getConnection();

                conn.Open();
                //MessageBox.Show("Database connection established");

                // For convenience the string of Portion size is simplified by
                // taking the first letter of each size category

                updateitem.setItemName(itemnamef.Text);
                updateitem.setDescription(desc.Text);
                updateitem.setItemTag(itemtagf.Text);

                //MessageBox.Show(updateitem.getItemCode().ToString());

                if (psizef.Text == "Small")
                {
                    updateitem.setPSize("s");
                    checkPSize = true;
                }
                else if (psizef.Text == "Medium")
                {
                    updateitem.setPSize("m");
                    checkPSize = true;
                }
                else if (psizef.Text == "Large")
                {
                    updateitem.setPSize("l");
                    checkPSize = true;
                }
                // This makes sure that an incorrect input for the portion size isnt made
                else
                {
                    checkPSize = false;
                }

                // Validates the item name if it already exists in the database

                itmnexists = updateitem.itemnameUpdateCheck(updateitem.getItemCode());

                //MessageBox.Show(itmnexists.ToString());

                // If the itemname and code doesnt exist the insertion takes place
                if (itmnexists != true && checkPSize == true && itemnamef.Text != "" && desc.Text != "" && itemtagf.Text!="" && status.Text != "")
                {
                    MemoryStream ms = new MemoryStream();
                    imagebox.Image.Save(ms, imagebox.Image.RawFormat);
                    byte[] img = ms.ToArray();


                    //MessageBox.Show(updateitem.getItemCode().ToString());
                    //MessageBox.Show(updateitem.getDescription());
                    //MessageBox.Show(updateitem.getItemName());
                    //MessageBox.Show(updateitem.getPSize());

                    MySqlCommand com = new MySqlCommand("UPDATE  items SET itemname=@itemname,Description=@description,itemtag=@itemtag,status=@status, portionsize=@portionsize,itemimage=@image WHERE itemcode='" + updateitem.getItemCode() + "'", conn);

                    com.Parameters.Add("@itemname", MySqlDbType.VarChar).Value = updateitem.getItemName();
                    com.Parameters.Add("@description", MySqlDbType.VarChar).Value = updateitem.getDescription();
                    com.Parameters.Add("@itemtag", MySqlDbType.VarChar).Value = updateitem.getItemTag();
                    com.Parameters.Add("@status", MySqlDbType.VarChar).Value = status.Text;
                    com.Parameters.Add("@portionsize", MySqlDbType.VarChar).Value = updateitem.getPSize();
                    com.Parameters.Add("@image", MySqlDbType.MediumBlob).Value = img;

                    com.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Item Details Updated to database successfully");
                }
                // Else the corresponding error will be displayed
                else if (itemnamef.Text == "")
                {
                    MessageBox.Show("Please enter an item name for the item");
                }
                else if (desc.Text == "")
                {
                    MessageBox.Show("Please enter a description for the item");
                }
                else if (checkPSize != true)
                {
                    MessageBox.Show("Invalid Selection, Please select a value for the Portion size");
                }
                else if (itemtagf.Text == "")
                {
                    MessageBox.Show("Invalid Selection, Please select a value for the Item Tag");
                }
                else if (status.Text == "")
                {
                    MessageBox.Show("Invalid Selection, Please select a value for the status");
                }
                // Else the corresponding error will be displayed
                else if (itmnexists == true)
                {
                    MessageBox.Show("The Itemname already exists");
                }
                else
                {
                    MessageBox.Show("Check this ");
                }

                fillDataGridView();
                AddItem.Visible = true;
            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
            /////////////////////////suganthy//////////////////////////////////////////////////////////////////////
            DatabaseConnection dcupdat = new DatabaseConnection();
            MySqlConnection connupdat = dcupdat.getConnection();
            DatabaseConnection dc2 = new DatabaseConnection();


            MySqlConnection conn2 = dc2.getConnection();
            string itemname = dataGridView1.CurrentRow.Cells["itemname"].Value.ToString();

            string que = "delete from mealprice where MenuName='" + itemname + "'";
            connupdat.Open();
            MySqlCommand cmd =new MySqlCommand(que,connupdat) ;
            cmd.ExecuteNonQuery();
            try
            {
                
                conn2.Open();
                string que1 = "INSERT INTO `mealprice`(`MenuId`,`MenuName`,`StockName`,`StockSize`,`Total`) SELECT `MenuId`,`ItemName`,`StockName`,`StockSize`,`Total` FROM `recipe`";
                MySqlCommand cmd1 = new MySqlCommand(que1, conn2);
                cmd1.ExecuteNonQuery();
                //MySqlDataReader read = cmd1.ExecuteReader();
                //read.Close();

                //



                
                DataTable dt = new DataTable();


                string queitem = "select * from mealprice where MenuName='" + itemname + "'";
                MySqlCommand cmditem = new MySqlCommand(queitem, conn2);
                MySqlDataAdapter adp = new MySqlDataAdapter(queitem, conn2);
                adp.Fill(dt);
                dataGridView2.DataSource = dt;
                adp.Dispose();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                connupdat.Close();
                conn2.Close();
            }
            //itemcode.Text = "";
            //itemnamef.Text = "";
            //comboBox1.SelectedItem = "";
            //quantity.Text = "";
            //totalprice.Text = "";

            //////////////////////////////////suganthy/////////////////////////////////////////////////////////////////////////////
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from recipe where StockName='" + comboBox1.Text  + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
            display_data();
            MessageBox.Show("Record deleted successfully");
            comboBox1.SelectedItem = "";
            quantity.Text = "";
            totalprice.Text = "";

        }

        public void display_data()
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from recipe";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(dt);
            dataGridView2.DataSource = dt;

            conn.Close();

        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //DatabaseConnection dc = new DatabaseConnection();
            //MySqlConnection conn = dc.getConnection();

            //try
            //{
            //    string query = "select * from Stock";
            //    conn.Open();
            //    MySqlCommand cmd = new MySqlCommand(query, conn);

            //    MySqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        comboBox1.Items.Add(reader.GetString("StockName"));
            //    }
            //    reader.Close();

            //    conn.Close();
            //}
            //catch (Exception ie)
            //{
            //    MessageBox.Show(ie.Message);
            //}

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ingredients_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            try
            {
                conn.Open();
                string cmbo1 = comboBox1.SelectedItem.ToString();
                string que = "select UnitPrice from Stock where StockName='" + cmbo1 + "'";

                MySqlCommand cmd = new MySqlCommand(que, conn);
                MySqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    if (quantity.Text == "") { }
                    else
                    {
                        double price = read.GetDouble("UnitPrice");
                        double size = Convert.ToDouble(quantity.Text);
                        double tot = price * size;
                        totalprice.Text = Convert.ToString(tot);
                    }
                    read.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();
            try
            {
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

                if ((itemnamef.Text != "")&&(quantity.Text != "")&&(totalprice.Text != ""))
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO recipe (ItemName,StockName,StockSize,Total) VALUES ('" + itemnamef.Text + "','" + comboBox1.SelectedItem + "','" + Convert.ToDouble(quantity.Text) + "','" + Convert.ToDouble(totalprice.Text) + "')", conn);
                    cmd.ExecuteReader();
                }
                else
                {
                    MessageBox.Show("Enter an itemname or quantity or totalprice to add ingredients");
                }
                conn.Close();

                //reading database
                // LoadData();

                dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();
                dataGridView2.Refresh();
                conn.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter("select * from recipe", conn);
                adp.Fill(dt);
                dataGridView2.DataSource = dt;
                this.dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                adp.Dispose();
                conn.Close();
                MessageBox.Show("Recipe Details are Added");
                //itemnamef.Text = "";
                //comboBox1.SelectedItem = "";
                //quantity.Text = "";
                //totalprice.Text = "";

            }
            catch (MySqlException ee)
            {
                MessageBox.Show("" + ee, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            if (itemnamef.Text != "")
            {
                cmd.CommandText = "update  recipe set ItemName='" + itemnamef.Text + "',StockName='" + comboBox1.SelectedItem + "',StockSize='" + Convert.ToDouble(quantity.Text) + "',Total='" + Convert.ToDouble(totalprice.Text) + "'where MenuId='" + itemcode.Text + "'";
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Enter an itemname to add ingredients");
            }

            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
            display_data();
            
            MessageBox.Show("Record Updated successfully");
            //itemcode.Text = "";
            //itemnamef.Text = "";
            //comboBox1.SelectedItem= "";
            //quantity.Text= "";
            //totalprice.Text = "";
            }

          

        private void button2_Click(object sender, EventArgs e)
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            conn.Open();
            try
            {
                //added price column
                MySqlCommand com = new MySqlCommand("SELECT itemcode,itemname,Description,itemtag,status,portionsize,price,itemimage FROM items where itemname like '%" + itemnamesearch.Text + "%'  ORDER BY itemtag,itemname", conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dataGridView1.RowTemplate.Height = 80;

                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.DataSource = dt;

                DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
                imgcol = (DataGridViewImageColumn)dataGridView1.Columns["itemimage"];

                imgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            try
            {
                //string option = comboBox4.SelectedItem.ToString();
                double price = 0;
                conn.Open();
                string cmbo1 = itemnamef.Text;
                string que = "select sum(Total) as total from recipe where ItemName='" + cmbo1 + "'";


                MySqlCommand cmd = new MySqlCommand(que, conn);
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    price = read.GetDouble("total");
                }
                /*string que1 = "insert into mealprice(MenuName,TotalPrice) values ('" + cmbo1 + "'," + price + ")";
                read.Close();
                MySqlCommand cmd1 = new MySqlCommand(que1, conn);
                MySqlDataReader read1 = cmd1.ExecuteReader();
                */


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
                conn.Close();
            }
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {

            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            //updateItem.Visible = true;
            //AddItem.Visible = false;
            //updateitem = new Item();

           

            string itemname= dataGridView1.CurrentRow.Cells["itemname"].Value.ToString();
            conn.Open();
            string que = "select MenuId, MenuName, StockName, StockSize,Total from mealprice ";
            MySqlCommand cmd = new MySqlCommand(que,conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                itemcode.Text = dataGridView2.CurrentRow.Cells["MenuId"].Value.ToString();

                //itemnamef.Text = dataGridView2.CurrentRow.Cells["itemname"].Value.ToString();

                comboBox1.Text = dataGridView2.CurrentRow.Cells["StockName"].Value.ToString();

                quantity.Text = dataGridView2.CurrentRow.Cells["StockSize"].Value.ToString();

                totalprice.Text = dataGridView2.CurrentRow.Cells["Total"].Value.ToString();
            }
            conn.Close();
            //string que1 = "select * from recipe where ItemName='" + itemnamef.Text + "'";
            //MySqlCommand cmd1 = new MySqlCommand(que1);
            //MySqlDataReader reader1 = cmd1.ExecuteReader();
            //while (reader1.Read())
            //{

            //    itemcode.Text = dataGridView2.CurrentRow.Cells["itemcode"].Value.ToString();

            //    itemnamef.Text = dataGridView2.CurrentRow.Cells["itemname"].Value.ToString();

            //    comboBox1.Text = dataGridView2.CurrentRow.Cells["StockName"].Value.ToString();

            //    quantity.Text = dataGridView2.CurrentRow.Cells["StockSize"].Value.ToString();

            //    totalprice.Text = dataGridView2.CurrentRow.Cells["Total"].Value.ToString();
            //}
            //conn.Close();
        }

        private void quantity_KeyDown(object sender, KeyEventArgs e)
        {
                    
        }

        private void totalprice_TextChanged(object sender, EventArgs e)
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

        public void tableload()
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            conn.Open();
            try
            {
                MySqlCommand com = new MySqlCommand("SELECT ItemCode,ItemName,StockName,Stocksize,total FROM recipe", conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dataGridView2.RowTemplate.Height = 80;

                dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


                dataGridView2.AllowUserToAddRows = false;
                dataGridView2.DataSource = dt;

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
