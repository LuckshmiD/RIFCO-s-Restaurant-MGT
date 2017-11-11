using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCTRM
{
    class DBconnector
    {
        MySqlConnection connection;
        MySqlCommand command;
        private MySqlConnection DBConnect;
        string connection1;

        public DBconnector()
        {
            
            connection1 = @"server=localhost;userid=root;password=;database=rest";
            connection = new MySqlConnection(connection1);
            connection.Open();   
        }

        public bool executeStatement(String statement)
        {
            try
            {
                command = new MySqlCommand();
                string SQL = statement;
                command.CommandText = SQL;

                command.Connection = connection;
                int x = command.ExecuteNonQuery();
                //MessageBox.Show("Succesfully Executed");
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            
        }
        public MySqlConnection getConnection()
        {

            DBConnect = new MySqlConnection(connection1);


            return DBConnect;
        }
    }
}