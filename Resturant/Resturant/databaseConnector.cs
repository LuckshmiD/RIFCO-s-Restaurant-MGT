using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Cashier
{
    
    public class databaseConnector
    {
        public MySqlConnection connection;
        public MySqlCommand command;

        public databaseConnector()
        {
            string cs = @"server=localhost;userid=root;password=;database=RMSDatabase";
            //string cs = @"server=us-cdbr-iron-east-05.cleardb.net;userid=b86e9de17eea11;password=71591d98;database=heroku_42b0089c8c9f140";
            connection = new MySqlConnection(cs); 
            command = new MySqlCommand();
            connection.Open();
        }

        public void closeConnection()
        {
            connection.Close();
        }

        public bool executeStatement(String statement)
        {
            try
            {
                
                string SQL = statement;
                command.CommandText = SQL;

                command.Connection = connection;
                int x = command.ExecuteNonQuery();

                
                return true;
                
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
                return false;
            }

            
        }

        public MySqlDataReader getData(string statement)
        {
            try
            {
                

                string SQL = statement;
                command.CommandText = SQL;
                command.Connection = connection;

                MySqlDataReader reader = command.ExecuteReader();
                return reader;
            }

            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return null;
            }
        }
    }
}
