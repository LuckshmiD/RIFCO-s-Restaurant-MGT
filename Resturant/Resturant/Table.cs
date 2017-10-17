using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier
{
    class Table
    {
        private int table_no;
        private databaseConnector db;
        MySqlDataReader reader;

        public Table(int table_number)
        {
            db = new databaseConnector();
            table_no = table_number;
        }

        public void create_table()
        {

        }

        public void delete_table()
        {

        }

        public int get_table_no()
        {
            return table_no;
        }

        public int get_number_of_items()
        {
            reader = db.getData("Select count(*) as count from table"+table_no);
            reader.Read();
            int x = reader.GetInt32("count");
            reader.Close();

            return x;
        }

        public DataTable get_table()
        {
            DataTable tbl = new DataTable();
            reader = db.getData("select * from table" + table_no);
            tbl.Load(reader);

            return tbl;
        }

        public DataTable get_OrderlistTable()
        {
            DataTable tbl = new DataTable();
            reader = db.getData("SELECT * FROM `orderlist" + table_no+"`");
            tbl.Load(reader);

            return tbl;
        }

        public float get_total_price()
        {
            reader = db.getData("Select SUM(quantity * price) as price from table" + table_no);
            reader.Read();
            float price = reader.GetFloat("price");

            reader.Close();

            return price;
        }

        public MySqlDataReader get_table_data()
        {
            DataTable tbl = new DataTable();
            reader = db.getData("select * from table" + table_no);

            return reader;
        }

       public void clear_table()
        {
            reader.Close();
            db.executeStatement("delete from table"+table_no);
        }
    }
}
