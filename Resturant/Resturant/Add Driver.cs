using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using OrderManagement;
using System.Windows.Forms;

namespace Transport
{
    class Add_Driver
    {
        public Add_Driver()
        {

        }

        public void addDriver(int cont, String n, String driverID, String lNo, String plate,String ad)
        {
            int contact = cont;
            String name = n ;   
            String dID = driverID ;
            String licNo = lNo ;
            String address = ad;
            String assignedVehicle = plate ;

            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            conn.Open();
            MessageBox.Show("Database connection established");

            MySqlCommand com = new MySqlCommand ("INSERT INTO drivers(Driver ID,Name,License Number,Address, Contact Number, Assigned Vehicle) VALUES("+ dID + "," + name + ","+licNo+","+address+","+contact+","+ assignedVehicle+")");
            com.ExecuteNonQuery();
            conn.Close();
        }
    }
}
