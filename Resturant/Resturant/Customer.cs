using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Customer_Management
{
    class Customer
    {
        private String CID;
       // private
        private DateTime date;
        private char MobileNumber;
        private String Name;

        public DateTime Date { get => date; set => date = value; }
        
        public string Name1 { get => Name; set => Name = value; }
        public string CID1 { get => CID; set => CID = value; }
        public char MobileNumber1 { get => MobileNumber; set => MobileNumber = value; }

        public int GetNewCusId(string connectionString)
        {
            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                databaseConnection.Open();
                string query = "select Max(CID) from customer";
                using (MySqlCommand command = new MySqlCommand(query, databaseConnection))
                {
                    var cmd = command.ExecuteScalar();
                    if (cmd != DBNull.Value)
                        return Convert.ToInt32(cmd);
                    return 1;
                }
            }
        }
       
    }
}
