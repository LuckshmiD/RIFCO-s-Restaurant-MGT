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
using OrderManagement;

namespace Transport
{
    public partial class Change_Availability : Form
    {



        public Change_Availability()
        {
            InitializeComponent();

            Filldgv_Av();
        }




        private void button1_Click(object sender, EventArgs e)
        {

            int status=-1;

            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection connupd = dc.getConnection();

            try
            {
                connupd.Open();
                MySqlCommand com = new MySqlCommand("SELECT status FROM drivers WHERE  DriverID= '" + didtext.Text + "'", connupd);
                MySqlDataReader r = com.ExecuteReader();
                r.Read();
                status = r.GetInt32("status");
                r.Close();

                if(status == 1)
                {
                    com.CommandText = "UPDATE `drivers` SET `status`=0 WHERE `DriverID`=" + didtext.Text;
                    com.ExecuteNonQuery();
                    Filldgv_Av();
                    fillTextBox();
                }
                else if(status == 0)
                {
                    com.CommandText = "UPDATE `drivers` SET `status`=1 WHERE `DriverID`=" + didtext.Text;
                    com.ExecuteNonQuery();
                    Filldgv_Av();
                    fillTextBox();
                }
                else
                {
                    MessageBox.Show("Cannot identify availability!!!");
                }

                
               
                connupd.Close();


            }



            catch (Exception te)
            {
                MessageBox.Show(te.Message);
            }



                

            
        }



        private void Filldgv_Av()
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection connfill = dc.getConnection();

            try
            {

                connfill.Open();
                MySqlCommand com = new MySqlCommand("SELECT DriverID , name , status FROM drivers  ", connfill);

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.DataSource = dt;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                connfill.Close();
            }



            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            fillTextBox();
        }

        private void fillTextBox()
        {
            didtext.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value) == 1)
            {
                availStatus.Text = "Available";
            }
            else if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value) == 0)
            {
                availStatus.Text = "Not Available";
            }
            else
            {
                availStatus.Text = "Cannot specify availability";
            }
        }
    }
}
