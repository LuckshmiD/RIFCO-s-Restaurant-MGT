using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using supplier;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace EventCaterMgt
{
    public partial class createMenu : Form
    {
        MySqlConnection con;
        double meal123=0, dsrt123=0, dsrt1234=0;





        public createMenu()
        {
            InitializeComponent();
            con = new MySqlConnection(@"server=localhost;userid=root;password=;database=rmsdatabase");
        }

        public void addPackComboItems()
        {
            dsrtcombo.Items.Clear();
            drnkcombo.Items.Clear();
            mealcombo.Items.Clear();
            string selectquery = "Select * from lunchdinner";
            string selectquery1 = "Select * from bevdessert";
            con.Open();
            MySqlCommand command = new MySqlCommand(selectquery, con);
            MySqlCommand command1 = new MySqlCommand(selectquery1, con);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                //mealcombo.Items.Add(reader.GetString("lunchdinner")+" "+reader.GetString("price")+"Rs");
                mealcombo.Items.Add(reader.GetString("lunchdinner"));


            }
            reader.Close();
            reader = command1.ExecuteReader();
            while (reader.Read())
            {
                dsrtcombo.Items.Add(reader.GetString("bevdessert"));
                drnkcombo.Items.Add(reader.GetString("bevdessert"));
            }
            reader.Close();
        }

        public void fillMainMealDataGrid()
        {
           string add = "select lunchdinner as MainMenu,price as Price from lunchdinner";
            MySqlCommand cmd1 = new MySqlCommand(add, con);

            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd1;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bsource = new BindingSource();

            bsource.DataSource = dbdataset;
            dataGridView2.DataSource = bsource;
            sda.Update(dbdataset);
        }

        public void fillDessertDataGrid()
        {
            string add = "select bevdessert as BeveragesDesserts,price as Price from bevdessert";
            MySqlCommand cmd1 = new MySqlCommand(add, con);

            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd1;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bsource = new BindingSource();

            bsource.DataSource = dbdataset;
            dataGridView5.DataSource = bsource;
            sda.Update(dbdataset);
        }


        public void fillPackageDataGrid()
        {
           string add = "select pname as MainMenu,mainmeal as MainMeal,dessert as Dessert,drink as Drink,price as Price from package";
            MySqlCommand cmd1 = new MySqlCommand(add, con);

            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd1;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bsource = new BindingSource();

            bsource.DataSource = dbdataset;
            dataGridView1.DataSource = bsource;
            sda.Update(dbdataset);
        }

        public void resetCombo()
        {
            dsrtcombo.SelectedIndex = -1;
            drnkcombo.SelectedIndex = -1;
            mealcombo.SelectedIndex = -1;
            dsrtcombo.Enabled = true;
            drnkcombo.Enabled = true;
            mealcombo.Enabled = true;
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void mprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void mname_TextChanged(object sender, EventArgs e)
        {
          
            name.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                // mname.Text = row.Cells[0].Value.ToString();
                name.Text = row.Cells[0].Value.ToString();
                mprice.Text = row.Cells[1].Value.ToString();
                chooseType.SelectedIndex = 1;
               // mname.ReadOnly=true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string upd = "delete from lunchdinner where lunchdinner='" + mname.Text + "'";
              
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(upd, con);

                    cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("Successfully deleted");
                    mname.Text = "";
                    mprice.Text = "";


                
                upd = "select lunchdinner as MainMenu,price as Price from lunchdinner";
                MySqlCommand cmd1 = new MySqlCommand(upd, con);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd1;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                dataGridView2.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  con.Open();
            //  string cmd = "update lunchdinner set price='" + Convert.ToDouble(mprice.Text) + "' where lunchdinner='"+mname.Text+"'";
            try
            {
                string upd = "update lunchdinner set price='" + Convert.ToDouble(mprice.Text) + "' where lunchdinner='" + mname.Text + "'";
                if (mprice.Text == "")
                {
                    MessageBox.Show("Please fill in the price field.!!!");
                }
                else
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(upd, con);

                    cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("Successfully updated");
                    mname.Text = "";
                    mprice.Text = "";


                }
                upd = "select lunchdinner as MainMenu,price as Price from lunchdinner";
                MySqlCommand cmd1 = new MySqlCommand(upd, con);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd1;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                dataGridView2.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }

        private void msearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string add = "insert into lunchdinner values('" + mname.Text + "','" + Convert.ToDouble(mprice.Text) + "')";
                if (mname.Text == "" && mprice.Text == "")
                {
                    MessageBox.Show("Please fill in all the fields.!!!");
                }
                else
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(add, con);

                    cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("Successfully added");
                    mname.Text = "";
                    mprice.Text = "";


                }
                add = "select lunchdinner as MainMenu,price as Price from lunchdinner";
                MySqlCommand cmd1 = new MySqlCommand(add, con);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd1;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                dataGridView2.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

     

        private void addBevdessert_Click(object sender, EventArgs e)
        {
         
        }
        private void createMenu_Load(object sender, EventArgs e)
        {
            try
            {
                
                string selectquery = "Select * from lunchdinner";
                string selectquery1 = "Select * from bevdessert";
                con.Open();
                MySqlCommand command = new MySqlCommand(selectquery, con);
                MySqlCommand command1 = new MySqlCommand(selectquery1, con);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //mealcombo.Items.Add(reader.GetString("lunchdinner")+" "+reader.GetString("price")+"Rs");
                    mealcombo.Items.Add(reader.GetString("lunchdinner"));


                }
                reader.Close();
                reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    dsrtcombo.Items.Add(reader.GetString("bevdessert"));
                    drnkcombo.Items.Add(reader.GetString("bevdessert"));
                }
                reader.Close();

                string add = "select pname as Package,mainmeal as MainMeal,dessert as Dessert,drink as Drink,price as Price from package";
                string add1 = "select bevdessert as BeveragesDesserts,price as Price from bevdessert";
                string add2 = "select lunchdinner as MainMenu,price as Price from lunchdinner";

                MySqlDataAdapter sda = new MySqlDataAdapter(add, con);
                MySqlDataAdapter sda1 = new MySqlDataAdapter(add1, con);
                MySqlDataAdapter sda2 = new MySqlDataAdapter(add2, con);

                DataTable dbdataset = new DataTable();
                DataTable dbdataset1 = new DataTable();
                DataTable dbdataset2 = new DataTable();

                sda.Fill(dbdataset);
                sda1.Fill(dbdataset1);
                sda2.Fill(dbdataset2);

                dataGridView1.DataSource = dbdataset;
                dataGridView5.DataSource = dbdataset1;
                dataGridView2.DataSource = dbdataset2;


                con.Close();


                
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void addPackage_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                name.Text = row.Cells[0].Value.ToString();
                mealcombo.SelectedItem = row.Cells[1].Value.ToString();
                dsrtcombo.SelectedItem = row.Cells[2].Value.ToString();
                drnkcombo.SelectedItem = row.Cells[3].Value.ToString();
                mprice.Text = row.Cells[4].Value.ToString();
                dsrtcombo.Enabled = true;
                drnkcombo.Enabled = true;
                mealcombo.Enabled = true;
                chooseType.SelectedIndex = 2;
            }
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {



        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            //MainECM mv = new MainECM();
            //mv.Show();
        }

        private void updatePackage_Click(object sender, EventArgs e)
        {
            try
            {
                string upd = "update package set price='" + Convert.ToDouble(mprice.Text) + "', mainmeal='" + mealcombo.SelectedItem + "',dessert='" + dsrtcombo.SelectedItem + "', drink='" + drnkcombo.SelectedItem + "' where mname ='" + name.Text + "'";
                if (mprice.Text == ""|| mealcombo.SelectedIndex < 0)
                {
                    MessageBox.Show("Make Sure you filled all the fields..!");
                }
                else
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(upd, con);

                    cmd.ExecuteReader();
                    con.Close();
                   
                    mname.Text = "";
                    name.Text = "";
                    mprice.Text = "";
                    dsrtcombo.SelectedIndex = -1;
                    drnkcombo.SelectedIndex = -1;
                    mealcombo.SelectedIndex = -1;



                }
                upd = "select pname as MainMenu,mainmeal as MainMeal,dessert as Dessert,drink as Drink,price as Price from package";
                MySqlCommand cmd1 = new MySqlCommand(upd, con);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd1;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);

                MessageBox.Show("Successfully updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }

        private void updateBevdessert_Click(object sender, EventArgs e)
        {
          

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView5.Rows[e.RowIndex];
                //  mname.Text = row.Cells[0].Value.ToString();
                name.Text = row.Cells[0].Value.ToString();
                mprice.Text = row.Cells[1].Value.ToString();
                chooseType.SelectedIndex = 0;
             //   mname.ReadOnly = true;
            }
        }

        private void deletePackage_Click(object sender, EventArgs e)
        {
            try
            {
                string upd = "delete from package  where pname ='" + name.Text + "'";

                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(upd, con);

                    cmd.ExecuteReader();
                    con.Close();
                    
                    mname.Text = "";
                    name.Text = "";
                    mprice.Text = "";
                chooseType.SelectedIndex = -1;
                    dsrtcombo.SelectedIndex = -1;
                    drnkcombo.SelectedIndex = -1;
                    mealcombo.SelectedIndex = -1;

                fillPackageDataGrid();
                MessageBox.Show("Successfully deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }

        private void deleteBevdessert_Click(object sender, EventArgs e)
        {
            

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void mealcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string pack = mealcombo.SelectedItem.ToString();
                //  double price;

                string que = "select price from lunchdinner where lunchdinner = '" + pack + "'";
                MySqlCommand cmd = new MySqlCommand(que, con);
                MySqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    meal123 = read.GetDouble("price");                   
                    read.Close();

                }

                int x = Convert.ToInt32((meal123 + dsrt1234 + dsrt123));
                mprice.Text = Convert.ToString(x * 0.75);
                
                

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void chooseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chooseType.SelectedIndex == 0 || chooseType.SelectedIndex ==1)
            {
                dsrtcombo.Enabled = false;
                drnkcombo.Enabled = false;
                mealcombo.Enabled = false;
            }
            else if(chooseType.SelectedIndex==2 || chooseType.SelectedIndex ==-1)
            {
                dsrtcombo.Enabled = true;
                drnkcombo.Enabled = true;
                mealcombo.Enabled = true;
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try

            {


                if (chooseType.SelectedIndex != -1)
                    {
                        if (chooseType.SelectedIndex==1)
                        {
                            string add = "insert into lunchdinner values('" + mname.Text + "','" + Convert.ToDouble(mprice.Text) + "')";
                            if (mname.Text == "" && mprice.Text == "")
                            {
                                MessageBox.Show("Please fill in all the fields.!!!");
                            }
                            else
                            {
                                con.Open();
                                MySqlCommand cmd = new MySqlCommand(add, con);

                                cmd.ExecuteReader();
                                con.Close();

                                mname.Text = "";
                                mprice.Text = "";
                                chooseType.SelectedIndex = -1;


                            }

                            fillMainMealDataGrid();

                            MessageBox.Show("Successfully added");
                            
                        }
                        else if(chooseType.SelectedIndex==0)
                        {
                            string add = "insert into bevdessert values('" + mname.Text + "','" + Convert.ToDouble(mprice.Text) + "')";
                            if (mname.Text == "" && mprice.Text == "")
                            {
                                MessageBox.Show("Please fill in all the fields.!!!");
                            }
                            else
                            {
                                con.Open();
                                MySqlCommand cmd = new MySqlCommand(add, con);

                                cmd.ExecuteReader();
                                con.Close();

                                mname.Text = "";
                                mprice.Text = "";
                                chooseType.SelectedIndex = -1;


                            }

                            fillDessertDataGrid();
                            MessageBox.Show("Successfully added");
                        }

                    else if (chooseType.SelectedIndex == 2)

                    {
                        string add = "insert into package values('" + mname.Text + "','" + mealcombo.SelectedItem + "','" + dsrtcombo.SelectedItem + "','" + drnkcombo.SelectedItem + "','" + Convert.ToDouble(mprice.Text) + "')";
                        if (mname.Text == "" || mprice.Text == "" || drnkcombo.SelectedIndex < 0 || dsrtcombo.SelectedIndex < 0 || mealcombo.SelectedIndex < 0)
                        {
                            MessageBox.Show("Please fill in all the fields.!!!");
                        }
                        else
                        {
                            con.Open();
                            MySqlCommand cmd = new MySqlCommand(add, con);

                            cmd.ExecuteReader();
                            con.Close();

                            mname.Text = "";
                            name.Text = "";
                            mprice.Text = "";
                            chooseType.SelectedIndex = -1;
                            //dsrtcombo.SelectedIndex = -1;
                            //drnkcombo.SelectedIndex = -1;
                            //mealcombo.SelectedIndex = -1;
                        }
                        fillPackageDataGrid();

                        MessageBox.Show("Successfully added");//package adding
                    }
                            addPackComboItems();
                }
                    else
                    {
                        MessageBox.Show("Please Select a Type..!");
                    }
                
                

            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (chooseType.SelectedIndex == 1)
                {
                    // string upd = "update lunchdinner set price='" + Convert.ToDouble(mprice.Text) + "' where lunchdinner='" + mname.Text + "'";
                    string upd = "update lunchdinner set price='" + Convert.ToDouble(mprice.Text) + "' where lunchdinner='" + name.Text + "'";
                    if (mprice.Text == "")
                    {
                        MessageBox.Show("Please fill in the price field.!!!");
                    }
                    else
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand(upd, con);

                        cmd.ExecuteReader();
                        con.Close();

                        mname.Text = "";
                        name.Text = "";
                        mprice.Text = "";
                        chooseType.SelectedIndex = -1;


                    }
                    fillMainMealDataGrid();
                    MessageBox.Show("Successfully updated");
                }
                else if (chooseType.SelectedIndex == 0)
                {
                    // string upd = "update bevdessert set price='" + Convert.ToDouble(mprice.Text) + "' where bevdessert='" + mname.Text + "'";
                    string upd = "update bevdessert set price='" + Convert.ToDouble(mprice.Text) + "' where bevdessert='" + name.Text + "'";

                    if (mprice.Text == "")
                    {
                        MessageBox.Show("Please fill in the price field.!!!");
                    }
                    else
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand(upd, con);

                        cmd.ExecuteReader();
                        con.Close();

                        mname.Text = "";
                        name.Text = "";
                        mprice.Text = "";
                        chooseType.SelectedIndex = -1;

                    }
                    fillDessertDataGrid();
                    MessageBox.Show("Successfully updated");
                }

                else if (chooseType.SelectedIndex == 2)
                {
                    string upd = "update package set price='" + Convert.ToDouble(mprice.Text) + "', mainmeal='" + mealcombo.SelectedItem + "',dessert='" + dsrtcombo.SelectedItem + "', drink='" + drnkcombo.SelectedItem + "' where pname ='" + name.Text + "'";
                    if (mprice.Text == "" )
                    {
                        MessageBox.Show("Make Sure you filled all the fields..!");
                    }
                    else
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand(upd, con);

                        cmd.ExecuteReader();
                        con.Close();

                        mname.Text = "";
                        name.Text = "";
                        mprice.Text = "";
                        chooseType.SelectedIndex = -1;
                        //dsrtcombo.SelectedIndex = -1;
                        //drnkcombo.SelectedIndex = -1;
                        //mealcombo.SelectedIndex = -1;
                    }
                    fillPackageDataGrid(); 
                    MessageBox.Show("Successfully updated");

                }
                addPackComboItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }

        private void dsrtcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string pack = dsrtcombo.SelectedItem.ToString();
                //  double price;

                string que = "select price from bevdessert where bevdessert = '" + pack + "'";
                MySqlCommand cmd = new MySqlCommand(que, con);
                MySqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    dsrt123 = read.GetDouble("price");
                    read.Close();

                }

                int x = Convert.ToInt32((meal123 + dsrt1234 + dsrt123));
                mprice.Text = Convert.ToString(x * 0.75);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void drnkcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string pack = drnkcombo.SelectedItem.ToString();
                //  double price;

                string que = "select price from bevdessert where bevdessert = '" + pack + "'";
                MySqlCommand cmd = new MySqlCommand(que, con);
                MySqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    dsrt1234 = read.GetDouble("price");
                    read.Close();

                }

                int x = Convert.ToInt32((meal123 + dsrt1234 + dsrt123));
                mprice.Text = Convert.ToString(x * 0.75);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LargeCE li = new LargeCE();
            li.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            RegularCE ri = new RegularCE();
                ri.Show();
        }

        private void button2Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (chooseType.SelectedIndex == 1)
                {
                    // string upd = "delete from lunchdinner where lunchdinner='" + mname.Text + "'";
                    string upd = "delete from lunchdinner where lunchdinner='" + name.Text + "'";

                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(upd, con);

                    cmd.ExecuteReader();
                    con.Close();
                   
                    mname.Text = "";
                    name.Text = "";
                    mprice.Text = "";
                    chooseType.SelectedIndex = -1;




                    fillMainMealDataGrid();
                    MessageBox.Show("Successfully deleted");
                }
                else if(chooseType.SelectedIndex==0)
                {
                    //string upd = "delete from bevdessert where bevdessert='" + mname.Text + "'";
                    string upd = "delete from bevdessert where bevdessert='" + name.Text + "'";

                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(upd, con);

                    cmd.ExecuteReader();
                    con.Close();
                    
                    mname.Text = "";
                    name.Text = "";
                    mprice.Text = "";
                    chooseType.SelectedIndex = -1;


                    fillDessertDataGrid();
                    MessageBox.Show("Successfully deleted");


                }
                else if (chooseType.SelectedIndex == 2)
                {

                    string upd = "delete from package  where pname ='" + name.Text + "'";

                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(upd, con);

                    cmd.ExecuteReader();
                    con.Close();

                    mname.Text = "";
                    name.Text = "";
                    mprice.Text = "";
                    chooseType.SelectedIndex = -1;
                    //dsrtcombo.SelectedIndex = -1;
                    //drnkcombo.SelectedIndex = -1;
                    //mealcombo.SelectedIndex = -1;

                    fillPackageDataGrid();
                    MessageBox.Show("Successfully deleted");

                }
                addPackComboItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void pname_TextChanged(object sender, EventArgs e)
        {
            name.Text = "";
        }
    }
    
}

