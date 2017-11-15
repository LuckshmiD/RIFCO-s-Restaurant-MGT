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

        //getname for delivery
        public string getName(string mobile)
        {
            string Name = "";

            string query = "select Name from customer where MobileNumber='" + mobile + "'; ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Name = (reader[0].ToString());
            }
            reader.Close();
            con.Close();

            return Name;

        }
        //get address through CID for delivery
        public string getAddress(string mobile)
        {
            string Address = "";

            string query = "select Address from customer where CID='" + mobile + "'; ";
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
        //total Ecus
        public int getEcust(string type)
        {

            int count = 0;
            string query = "select count(*) from customer where Type= '" + type + "'";

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

        //total mob cus
        public int getMcust(string type)
        {

            int count = 0;
            string query = "select count(*) from customer where Type= '" + type + "'";

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

        //total customers
        public int getcountofcus()
        {

            int count = 0;
            string query = "select count(*) from customer ";

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
        public int getCID2(string email)
        {

            int cid = 0;
          
                string query = "select CID from customer where MobileNumber='" + email + "'; ";
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
        //get number lux
        public string getNumber(int cid)
        {
            string number = "";

            string query = "select MobileNumber from customer where CID='" + cid + "'; ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                number = (reader[0].ToString());
            }
            reader.Close();
            con.Close();

            return number;

        }

    }

}