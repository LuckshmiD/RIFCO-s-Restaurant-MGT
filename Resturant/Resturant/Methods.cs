using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Customer_Management

{
    class Methods
    {
        private string connectionString;
        private MySqlConnection con;
        public Methods()
        {
            this.connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";
            con = new MySqlConnection(connectionString);
        }

        //get address through CID for delivery
        public string getAddress(int Cid)
        {
            string Address = "";

            string query = "select Address from customer where CID='" + Cid + "'; ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Address = (reader[0].ToString());
            }
            reader.Close();
            con.Close();

            return Address;

        }

        //gt cid reg customer
        public int getCID(string mobile)
        {

            int cid = 0;

            string query = "select CID from customer where MobileNumber='" + mobile + "'; ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cid = Convert.ToInt32(reader[0].ToString());
            }
            reader.Close();
            con.Close();

            return cid;


        }

        public int getcountofRating(string rate)
        {

            int count = 0;
            string query = "select count(*) from feedback where Rate= '" + rate + "'";

            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                count = Convert.ToInt32(reader[0].ToString());
            }
            reader.Close();
            con.Close();
            return count;
        }
        public int getmaxofRating()
        {

            int count = 0;
            string query = "select count(*) from feedback";

            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                count = Convert.ToInt32(reader[0].ToString());
            }
            reader.Close();
            con.Close();
            return count;
        }

        //get cid non reg customer and luckshmi
        public int getmaxcid()
        {

            int max = 0;
            string query = "select MAX(CID) from customer ";

            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                max = Convert.ToInt32(reader[0].ToString());
            }
            reader.Close();
            con.Close();
            return max;
        }

           }

}