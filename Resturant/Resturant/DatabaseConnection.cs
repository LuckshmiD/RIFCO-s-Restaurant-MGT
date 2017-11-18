using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OrderManagement
{
    class DatabaseConnection
    {
        private string Connection;
        private MySqlConnection DBConnect;

        public DatabaseConnection() {
            Connection = " datasource =localhost ; username= root; password= ; database = rmsdatabase ";
            
        }

        public MySqlConnection getConnection(){

            DBConnect = new MySqlConnection(Connection);
            

            return DBConnect;
        }


    }
}
