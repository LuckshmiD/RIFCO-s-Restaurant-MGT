using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace OrderManagement
{
    class Item
    {
        private int itemcode;
        private string itemname;
        private string itemtag;
        private string description;
        //private float rate;
        private string porsize;
        bool availabilityStatus;
        bool seasonalStatus;
        

        //Constructor for the class Item
        public Item(int itemcode, string itemname, string itemtag, string description, string porsize)  {
            this.itemcode = itemcode;
            this.itemname = itemname;
            this.description = description;
            this.itemtag = itemtag;
            this.porsize = porsize;
            this.availabilityStatus = true;
            this.seasonalStatus = true;
        }

        public Item(string itemname, string itemtag, string description ,string porsize)
        {
            this.itemname = itemname;
            this.description = description;
            this.porsize = porsize;
            this.itemtag = itemtag;
            this.availabilityStatus = true;
            this.seasonalStatus = true;
        }

        public Item(string itemname)
        {
            this.itemname = itemname;

        }

        public Item(int itemcode)
        {
            this.itemcode = itemcode;
        }

        public Item()
        {

        }


        // Getter for the class Item(Itemcode)
        public int getItemCode()
        {

            return itemcode;

        }

        public string getDescription()
        {

            //return description;
            return description;
        }

        // Getter for the class Item(Itemname)
        public string getItemName() {
            return itemname;
        }

        public string getItemTag()
        {
            return itemtag;
        }

        // Getter for the class Item(Portion Size)
        public string getPSize()
        {
            return porsize;
        }

        // Getter for the class Item(Rate)
        public float getRate()
        {
            //return rate;
            return 0;
        }

        //Setters
        public void setItemCode(int itemcode)
        {
            this.itemcode = itemcode;

        }

        public void setDescription(string desc)
        {
            this.description = desc;
            //return description;

        }

        // Setter for the class Item(Itemname)
        public void setItemName(string itemname)
        {
            this.itemname = itemname;
        }

        public void setItemTag(string itemtag)
        {
            this.itemtag = itemtag;
        }

        // Setter for the class Item(Portion Size)
        public void setPSize(string portionsize)
        {
            this.porsize = portionsize;
        }

        // Setter for the class Item(Rate)
        public void setRate(float rate)
        {
            //this.rate = rate;

        }
        // This method ensures that the new item being added to the database doesnt have the 
        // same itemcode as an item already in the database
        //public bool itemcodePreexistingInput() {

        //    DatabaseConnection dc = new DatabaseConnection();
        //    MySqlConnection conn = dc.getConnection();

        //    try
        //    {
        //        conn.Open();
        //        MySqlCommand com = new MySqlCommand("SELECT itemcode FROM items where itemcode='" + itemcode + "' ", conn);
        //        MySqlDataReader reader = com.ExecuteReader();

        //        return reader.Read();

        //    }
        //    catch (MySqlException mse)
        //    {
        //        MessageBox.Show(mse.Message);
        //    }
        //    finally {
        //        conn.Close();
        //    }
        //    return false;
        //}


        // This method ensures that the new item being added to the database doesnt have the 
        // same itemname as an item already in the database
        public bool itemnamePreexistingInput()
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            try
            {
                conn.Open();
                MySqlCommand com = new MySqlCommand("SELECT itemcode FROM items where itemname='" + itemname + "' ", conn);
                MySqlDataReader reader = com.ExecuteReader();

                return reader.Read();

            }
            catch (MySqlException mse)
            {
                MessageBox.Show(mse.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool itemnameUpdateCheck(int itemc)
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            try
            {
                conn.Open();

                //MessageBox.Show(itemc.ToString());
                MySqlCommand com = new MySqlCommand("SELECT itemname FROM items where itemname='" + itemname + "' and itemcode !='"+ itemc + "'", conn);
                
                MySqlDataReader reader = com.ExecuteReader();


                return reader.Read();

            }
            catch (MySqlException mse)
            {
                MessageBox.Show(mse.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public DataTable displayDetails()
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();
            try
            {
                conn.Open();
                //MessageBox.Show(itemcode.ToString());
                MySqlCommand cmd = new MySqlCommand("Select * from items where itemname like '"+itemname+"%'", conn);


                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();

                da.Fill(dt);

                BindingSource bs = new BindingSource();

                bs.DataSource = dt;


                return dt;

            }
            catch (MySqlException mse)
            {
                MessageBox.Show(mse.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
    }
}
