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

namespace Customer_Management
{
    public partial class Nonuser : Form
    {
        public Nonuser()
        {
            InitializeComponent();
        }
        //cid generate and assign
        int cid;
        public int Cid { get => cid; set => cid = value; }

        private void button4_Click(object sender, EventArgs e)
        { 
             string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";
        
            string query = "INSERT INTO CUSTOMER(Type) values ('NonRegistered');";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                //MessageBox.Show("Customer has been successfully Registererd");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //CID for nonreg customer
            //Methods m1 = new Methods();
            //cid = m1.getmaxcid();
            this.Hide();
            //sample s1 = new sample();
            //s1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
