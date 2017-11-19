using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using OrderManagement;

namespace Transport
{
    class DeliveryOrders
    {
        public DeliveryOrders()
        {

        }

        public void AssignDriver()
        {
            try
            {
                DatabaseConnection db = new DatabaseConnection();
                MySqlConnection con = db.getConnection();
                con.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = con;

                // getting driver ids

                command.CommandText = "SELECT COUNT(*) FROM `drivers` WHERE status = 1";
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                int driversCount = reader.GetInt32(0);
                reader.Close();

                string[] driverid = new string[driversCount];
                command.CommandText = "SELECT * FROM `drivers` WHERE status = 1";
                reader = command.ExecuteReader();

                for (int j = 0; j < driversCount; j++)
                {
                    reader.Read();
                    driverid[j] = reader.GetString(0);
                }
                reader.Close();

                int maximumOrders = driversCount * 5;
                
                // getting order ids

                command.CommandText = "SELECT COUNT(*) FROM `CurrentDeliveryOrders`";
                reader = command.ExecuteReader();
                reader.Read();

                int ordersCount = reader.GetInt32(0);
                string[] orderid = new string[ordersCount];
                string[] address = new string[ordersCount];
                reader.Close();

                if(ordersCount > maximumOrders)
                {
                    command.CommandText = "SELECT * FROM `CurrentDeliveryOrders` LIMIT "+maximumOrders;
                    reader = command.ExecuteReader();


                    for (int i = 0; i < maximumOrders; i++)
                    {
                        reader.Read();
                        orderid[i] = reader.GetString(0);
                        address[i] = reader.GetString(1);
                    }
                    reader.Close();

                    ordersCount = maximumOrders;
                }
                else
                {
                    command.CommandText = "SELECT * FROM `CurrentDeliveryOrders`";
                    reader = command.ExecuteReader();


                    for (int i = 0; i < ordersCount; i++)
                    {
                        reader.Read();
                        orderid[i] = reader.GetString(0);
                        address[i] = reader.GetString(1);
                    }
                    reader.Close();
                }

                //assigning orders

                int di = 0;
                int count = 1;
                for (int oi = 0; oi < ordersCount; oi++)
                {
                    
                    if (count < 6)
                    {
                        command.CommandText = "INSERT INTO `O_assigned_D` (`orderid`, `driverid`, `address`) VALUES ('" + orderid[oi] + "', '" + driverid[di] + "', '" + address[oi] + "');";
                        command.ExecuteNonQuery();

                        command.CommandText = "UPDATE `drivers` SET `status`=0 WHERE `DriverID`=" + driverid[di];
                        command.ExecuteNonQuery();

                        command.CommandText = "DELETE FROM `currentdeliveryorders` WHERE `orderid` = '" + orderid[oi] + "'";
                        command.ExecuteNonQuery();
                        count++;
                    }
                    else
                    {
                        ++di;
                        command.CommandText = "INSERT INTO `O_assigned_D` (`orderid`, `driverid`, `address`) VALUES ('" + orderid[oi] + "', '" + driverid[di] + "', '" + address[oi] + "');";
                        command.ExecuteNonQuery();

                        command.CommandText = "UPDATE `drivers` SET `status`=0 WHERE `DriverID`=" + driverid[di];
                        command.ExecuteNonQuery();

                        command.CommandText = "DELETE FROM `currentdeliveryorders` WHERE `orderid` = '" + orderid[oi] + "'";
                        command.ExecuteNonQuery();
                        count = 2;
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public float calculateDistance(string origin, string destination)
        {
            System.Threading.Thread.Sleep(1000);
            float distance = 0;
            //string from = origin.Text;
            //string to = destination.Text;
            string url = "http://maps.googleapis.com/maps/api/directions/json?origin=" + origin + "&destination=" + destination + "&sensor=false";
            string requesturl = url;
            //string requesturl = @"http://maps.googleapis.com/maps/api/directions/json?origin=" + from + "&alternatives=false&units=imperial&destination=" + to + "&sensor=false";
            string content = fileGetContents(requesturl);
            JObject o = JObject.Parse(content);
            try
            {
                distance = (float)o.SelectToken("routes[0].legs[0].distance.value");
                return distance;
            }
            catch
            {
                return distance;
            }
            return distance;
            //ResultingDistance.Text = distance;
        }

        protected string fileGetContents(string fileName)
        {
            string sContents = string.Empty;
            string me = string.Empty;
            try
            {
                if (fileName.ToLower().IndexOf("http:") > -1)
                {
                    System.Net.WebClient wc = new System.Net.WebClient();
                    byte[] response = wc.DownloadData(fileName);
                    sContents = System.Text.Encoding.ASCII.GetString(response);

                }
                else
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(fileName);
                    sContents = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch { sContents = "unable to connect to server "; }
            return sContents;
        }
    }
}
