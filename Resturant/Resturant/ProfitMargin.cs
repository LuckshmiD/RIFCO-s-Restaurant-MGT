using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCTRM
{
    public partial class ProfitMargin : Form
    {
        public ProfitMargin()
        {
            InitializeComponent();
            viewGrid();
        }

       
        private void updatePercentage()
        {
            string ConnectString = "datasource = 127.0.0.1; username = root;password = ; database = rmsdatabase";
            MySqlConnection DBConnect = new MySqlConnection(ConnectString);

            string query = "UPDATE ProfitMar SET Percentage ='" + txtPercent.Text + "' WHERE Portion = '" + comboBoxPor.Text + "'";

            MySqlCommand commandDatabase = new MySqlCommand(query, DBConnect);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                DBConnect.Open();
                reader = commandDatabase.ExecuteReader();
                MessageBox.Show("Succesfully Percentage  Updated");
                DBConnect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void btnprice_Click(object sender, EventArgs e)
        {
            updatePercentage();
            viewGrid();
        }

        public void viewGrid()
        {
            string ConnectString = "datasource = 127.0.0.1; username = root;password = ; database = rmsdatabase";
            MySqlConnection DBConnect = new MySqlConnection(ConnectString);
            DBConnect.Open();
            string query = "Select * from ProfitMar";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, DBConnect);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            MySqlCommand commandDatabase = new MySqlCommand(query, DBConnect);
            commandDatabase.CommandTimeout = 60;
            DBConnect.Close();

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                comboBoxPor.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfitMargin p1 = new ProfitMargin();
            p1.Show();

        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
           
        //        string ConnectString = "datasource = 127.0.0.1; username = root;password = ; database = rest";
        //        MySqlConnection DBConnect = new MySqlConnection(ConnectString);

        //        string query = "SELECT ID,Name,Cost FROM price WHERE ID = '" + int.Parse(txtSearch.Text) + "'";

        //        MySqlCommand commandDatabase = new MySqlCommand(query, DBConnect);
        //        commandDatabase.CommandTimeout = 60;
        //        MySqlDataReader reader;
        //        try
        //        {
        //            DBConnect.Open();
        //            reader = commandDatabase.ExecuteReader();
        //            if (reader.Read())
        //            {
        //                txtPricId.Text = reader.GetString("ID");
        //                txtName.Text = reader.GetString("Name");
        //                txtCost.Text = reader.GetString("Cost");
        //                viewGrid();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Item Not Found!");
        //            }
        //            //MessageBox.Show("Succesfully Deleted");
        //            DBConnect.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
           
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            comboBoxPor.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dB1 = new Dashboard();
            dB1.Show();
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
                  }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
            string ConnectString = "datasource = 127.0.0.1; username = root;password = ; database = rmsdatabase";
            MySqlConnection DBConnect = new MySqlConnection(ConnectString);
            DBConnect.Open();
            string query = "Select Percentage from ProfitMar where Portion = '" + comboBoxPor.Text + "'";
            MySqlCommand commandDatabase = new MySqlCommand(query, DBConnect);
            
            MySqlDataReader reader = commandDatabase.ExecuteReader();
            reader.Read();
            txtName.Text = reader.GetString("Percentage");
            reader.Close();
            DBConnect.Close();

        }
    }
}
