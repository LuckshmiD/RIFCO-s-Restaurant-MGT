using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resturant.Properties;


namespace RCTRM
{
    class Expenses
    {

        public void addExpense(String descrI, String typE, String datE, String repno, float amt)
        {
            try
            {


                String descr = descrI;
                String type = typE;
                String date = datE;
                String repNo = repno;
                float amount = amt;
                string query;
                DBconnector db1;
                bool stat;


                //MessageBox.Show(descr);

                if (descr == "Salaries & Wages")
                {

                    db1 = new DBconnector();
                    query = "INSERT INTO expense(Descri,Type,Date,`Invoice/Bill Number`,Amount)Values('" + descr + "','" + type + "','" + date + "','HR" + repno + "','" + amount + "')";
                    stat = db1.executeStatement(query);
                    if (stat == true)
                    {
                        MessageBox.Show("Succesfully Expense Added");
                    }

                }
                else if (descr == "Stock" || descr == "Transportaion")
                {
                    db1 = new DBconnector();
                    query = "INSERT INTO expense(Descri,Type,Date,`Invoice/Bill Number`,Amount)Values('" + descr + "','" + type + "','" + date + "','AD" + repno + "','" + amount + "')";
                    stat = db1.executeStatement(query);
                    if (stat == true)
                    {
                        MessageBox.Show("Succesfully Expense Added");
                    }
                }
                else
                {
                    db1 = new DBconnector();
                    query = "INSERT INTO expense(Descri,Type,Date,`Invoice/Bill Number`,Amount)Values('" + descr + "','" + type + "','" + date + "','UT" + repno + "','" + amount + "')";
                    stat = db1.executeStatement(query);
                    if (stat == true)
                    {
                        MessageBox.Show("Succesfully Expense Added");
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
         }

        
        public void alterExpense(String descrI, String typE, String datE, String repno, float amt)
        {
            try
            {

                String descr = descrI;
                String type = typE;
                String date = datE;
                String repNo = repno;
                float amount = amt;

                DBconnector db1 = new DBconnector();
                string query = "UPDATE expense SET Descri='" + descr + "',Type='" + type + "',Date='" + date + "',`Invoice/Bill Number`='" + repno + "',Amount='" + amount + "' WHERE `Invoice/Bill Number` = '" + repNo + "'";
                bool stat = db1.executeStatement(query);
                if (stat == true)
                {
                    MessageBox.Show("Succesfully Expense Alterd");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void deleteExpense(String repno)
        {
            try
            {
                String repNo = repno;
                DBconnector db1 = new DBconnector();
                string query = "DELETE FROM expense WHERE `Invoice/Bill Number` = '" + repNo + "'";
                bool stat = db1.executeStatement(query);
                if (stat == true)
                {
                    MessageBox.Show("Succesfully Expense Deleted");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public bool Reciptnumberexsist(String repno)
        {

            DBconnector db1 = new DBconnector();
            String repNo = repno;
            MySqlConnection conn = db1.getConnection();

            try
            {
                conn.Open();
                MySqlCommand com = new MySqlCommand("SELECT `Invoice/Bill Number` FROM expense where `Invoice/Bill Number` ='" + repNo +"'" ,conn);
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
            try
            {
                DataGridView dataGridView1 = datagrid;

                string ConnectString = "datasource = 127.0.0.1; username = root;password = ; database = rest; Allow Zero Datetime=True";
                MySqlConnection DBConnect = new MySqlConnection(ConnectString);

                string query = "Select * from expense";
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, DBConnect);
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                MySqlCommand commandDatabase = new MySqlCommand(query, DBConnect);
                commandDatabase.CommandTimeout = 60;
            }
            catch (Exception e)
            {
            }
            
        }
        public void viewGrid(DataGridView datagrid,String query1)
        {
            try
            {
                DataGridView dataGridView1 = datagrid;
                string query = query1;

                string ConnectString = "datasource = 127.0.0.1; username = root;password = ; database = rest; Allow Zero Datetime=True";
                MySqlConnection DBConnect = new MySqlConnection(ConnectString);

                //string query = "Select * from 'type'";
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, DBConnect);
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                MySqlCommand commandDatabase = new MySqlCommand(query, DBConnect);
                commandDatabase.CommandTimeout = 60;
            }
            catch (Exception e)
            {
            }
        }

      
    }
}
