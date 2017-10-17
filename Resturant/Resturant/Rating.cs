using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Customer_Management
{
    public partial class Rating : Form
    {
        public Rating()
        {
            InitializeComponent();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";

            Customer c1 = new Customer();
            int value = c1.GetNewCusId(connectionString);
            label2.Text = value.ToString();



        }

        private void Rating_Load(object sender, EventArgs e)
        {

        }

        //  MOUSE CLICK EVENTS -DESIGN

        private void panel1_MouseEnter(object sender, EventArgs e)
        {

        }




        private void mclick(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label8.Text = "Very Poor";
            label7.Text = 1.ToString();
            //pictureBox2.BackColor = Color.LightGreen;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label8.Text = "Poor";
            label7.Text = 2.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label8.Text = "Satisfactory";
            label7.Text = 3.ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label8.Text = "Good";
            label7.Text = 4.ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label8.Text = "Excellent";
            label7.Text = 5.ToString();
            pictureBox6.BackColor = Color.Red;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Confirm Rating?", "Customer Rating", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";

                string query = "INSERT INTO feedback (Rating,Rate) VALUES ('" + this.label7.Text + "','"+this.label8.Text+"');";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();

                    MessageBox.Show("Thank You for Rating us!!!", "Customer Rating", MessageBoxButtons.OK, MessageBoxIcon.None);
                    databaseConnection.Close();
                    this.Hide();
                    //Lastpage h1 = new Lastpage();
                    //h1.ShowDialog();
                }

                //label3.Text = "You have rated us with      " + label7.Text +"     STARS";

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Rating r1 = new Rating(); 

            }
        }

        private void menter1(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Red;

        }

        private void menter2(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Red;
            pictureBox3.BackColor = Color.Red;


        }

        private void menter3(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Red;
            pictureBox3.BackColor = Color.Red;
            pictureBox4.BackColor = Color.Red;
        }

        private void menter4(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Red;
            pictureBox3.BackColor = Color.Red;
            pictureBox4.BackColor = Color.Red;
            pictureBox5.BackColor = Color.Red;

        }

        private void menter5(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Red;
            pictureBox3.BackColor = Color.Red;
            pictureBox4.BackColor = Color.Red;
            pictureBox5.BackColor = Color.Red;
            pictureBox6.BackColor = Color.Red;
        }

        private void mousecl1(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.Red;
            pictureBox3.BackColor = Color.Red;
            pictureBox4.BackColor = Color.Red;
            pictureBox5.BackColor = Color.Red;
          pictureBox6.BackColor = Color.Red;
        }

        private void mouse2(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.Red;
            pictureBox3.BackColor = Color.Red;
            pictureBox4.BackColor = Color.Red;
            pictureBox5.BackColor = Color.Red;
          
        }

        private void mouse3(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.Red;
            pictureBox3.BackColor = Color.Red;
            pictureBox4.BackColor = Color.Red;
           // pictureBox5.BackColor = Color.Ivory;
           // pictureBox6.BackColor = Color.Ivory;
        }

        private void mouse4(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.Red;
            pictureBox3.BackColor = Color.Red;
          
        }

        private void mouse5(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.Red;
        }
        //mouse leave
        private void mleave(object sender, EventArgs e)
        {

            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
             pictureBox4.BackColor = Color.Transparent;
             pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;




        }

        private void mleave2(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
        }

        private void mleave3(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
        }

        private void mleave4(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
        }

        private void mleave5(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}   
    
