using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using MySql.Data.MySqlClient;


namespace Customer_Management
{
    public partial class Notification : Form
    {



        public Notification()
        {
            InitializeComponent();

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rectangleShape4_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 f2 = new Form1();
            f2.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Notification_Load(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage message = new MailMessage();

                //message.To.Add(new MailAddress(textto.Text.ToString()));
                //message.To.Add(new MailAddress(textto.Text.Trim()));
                // message.Subject = "Promotional Offers";
                message.Subject = textsubject.Text.Trim(); ;
                message.Body = textbody.Text.Trim();
               
                message.From = new MailAddress("myprojectmail001@gmail.com");




                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(textattach.Text.ToString());
     
                message.Attachments.Add(attachment);


                // Email Address from where you send the mail
                var fromAddress = "myprojectmail001@gmail.com";

                //Password of your mail address
                const string fromPassword = "myproject001";

                // smtp settings
                var smtp = new System.Net.Mail.SmtpClient();
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(fromAddress, fromPassword);
                    smtp.Timeout = 20000;
                }


                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";
                MySqlCommand cmd = null;
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                string type = "RegisteredE";
                string queryString = "SELECT Email FROM customer where Type='"+type+"'and Email is not null";
                // "SELECT Email FROM new where Email IS NOT NULL"
                // string queryString = "SELECT Email FROM table WHERE NOT(Email <=> NULL)";

                // using (SqlConnection connection =
                // new SqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(queryString, databaseConnection);
                    databaseConnection.Open();
                    cmd = new MySqlCommand(queryString);
                    cmd.Connection = databaseConnection;

                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Call Read before accessing data.




                    while (reader.Read())
                    {
                        //if (reader["Email"] != DBNull.Value)
                        //{
                           
                            var to = new MailAddress(reader["EMAIL"].ToString());
                            message.To.Add(to);
                            smtp.Send(message);
                            
                       // }
                     
                       // break;
                        
                        



                    }
                    // Passing values to smtp object        
                   // smtp.Send(message);
                    

                    reader.Close();  // Call Close when done reading.
                             MessageBox.Show("Emails have been sent successfully !!");
                }
                       
                    
                   
                    
                
                // Passing values to smtp object        
                //smtp.Send(message);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                {
                }



                //STORE IN DATABASE
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;"; 


                string query = "INSERT INTO NOTIFICATION (Message) VALUES ('" + this.textbody.Text+"');";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();

                    //MessageBox.Show("");
                    databaseConnection.Close();
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                }



            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            
        }
    }
}