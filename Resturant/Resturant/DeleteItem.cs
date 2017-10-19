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
    public partial class DeleteItem : Form
    {
        public DeleteItem()
        {
            InitializeComponent();
        }

        private void DeleteItemCode_Click(object sender, EventArgs e)
        {
            bool itmcexists;

            

            try
            {
                DatabaseConnection dc = new DatabaseConnection();
                MySqlConnection conn = dc.getConnection();

                Item item = new Item();
                conn.Open();
                MessageBox.Show("Database connection established");


                // If the itemname exists then the deletion will take place else the deletion would not occur
                //if (itmcexists == true)
                //{
                //    MySqlCommand com = new MySqlCommand("DELETE FROM items WHERE itemcode='" + item.getItemCode() + "'", conn);
                //    com.ExecuteNonQuery();
                //    conn.Close();

                //    MessageBox.Show("Item deleted from database successfully");
                //}
                //// Else the corresponding error will be displayed
                //else if (itmcexists != true)
                //{
                //    MessageBox.Show("The item with the item code " + item.getItemCode() + " doesnt exist");
                //}


            }

            // The folowing code snippet validates of the itemcode(to be an integer) 
            // and rate(to be a float) will take place
            catch (FormatException fe)
            {
                MessageBox.Show("The input was not in a correct format");
            }
            // Any errors regarding the MySql connection will be handled here
            catch (MySqlException mse)
            {
                MessageBox.Show(mse.Message);
            }
        }

        private void load_Click(object sender, EventArgs e)
        {

            
            try
            {
                Item item = new Item();
                Display.DataSource = item.displayDetails();

            }
            catch (FormatException fe) {
                MessageBox.Show("The input was not in a correct format");
            }
        }

        private void Display_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void itemcodef_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
