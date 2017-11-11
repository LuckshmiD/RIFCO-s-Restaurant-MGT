using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCTRM
{
    class Income
    {
        public void addIncome(String descrI, String typE, String datE, String vouNo, float amt)
        {
            String descr = descrI;
            String type = typE;
            String date = datE;
            String vouno = vouNo;
            float amount = amt;

            DBconnector db1 = new DBconnector();
            string query = "INSERT INTO INCOME(EntryNumber,Descri,Type,Date,Voucher_No,Amount)Values(Null,'" + descr + "','" + type + "','" + date + "','" + vouno + "','" + amount + "')";
            bool stat=db1.executeStatement(query);
            if(stat == true)
            {
                MessageBox.Show("Succesfully Income Added");
            }
            // MessageBox.Show("Succesfully Income Added");

        }

        public void alterIncome(int iD, String descrI, String typE, String datE, String vouNo, float amt)
        {
            int id = iD;
            String descr = descrI;
            String type = typE;
            String date = datE;
            String vouno = vouNo;
            float amount = amt;

            DBconnector db1 = new DBconnector();
            string query = "UPDATE income SET Descri='" + descr + "',Type='" + type + "',Date='" + date + "',Voucher_No='" + vouno + "',Amount='" + amount + "' WHERE EntryNumber = '" + id + "'";
            bool stat = db1.executeStatement(query);
            if (stat == true)
            {
                MessageBox.Show("Succesfully Income Updated");
            }

        }

        public void deleteIncome(int iD)
        {
            int id = iD;
            DBconnector db1 = new DBconnector();
            string query = "DELETE FROM income WHERE EntryNumber = '" + id + "'";
            bool stat = db1.executeStatement(query);
            if (stat == true)
            {
                MessageBox.Show("Succesfully Income Deleted");
            }

        }

        public bool Vouchernumberexsist(String vouNo)
        {

            DBconnector db1 = new DBconnector();
            String vouno = vouNo;
            MySqlConnection conn = db1.getConnection();

            try
            {
                conn.Open();
                MySqlCommand com = new MySqlCommand("SELECT Voucher_No FROM income where Voucher_No ='" + vouno + "'", conn);
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

        public void viewGrid(DataGridView datagrid)
        {
            DataGridView dataGridView1 = datagrid;
            string ConnectString = "datasource = 127.0.0.1; username = root;password = ; database = rmsdatabase";
            MySqlConnection DBConnect = new MySqlConnection(ConnectString);

            string query = "Select * from income";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, DBConnect);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            MySqlCommand commandDatabase = new MySqlCommand(query, DBConnect);
            commandDatabase.CommandTimeout = 60;


        }

        public void viewGrid1(DataGridView datagrid,string query)
        {
            DataGridView dataGridView1 = datagrid;
            string ConnectString = "datasource = 127.0.0.1; username = root;password = ; database = rmsdatabase";
            MySqlConnection DBConnect = new MySqlConnection(ConnectString);

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, DBConnect);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            MySqlCommand commandDatabase = new MySqlCommand(query, DBConnect);
            commandDatabase.CommandTimeout = 60;


        }


    }   
}
