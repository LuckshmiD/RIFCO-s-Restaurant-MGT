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

namespace HRManagement
{
    public partial class DeleteEmployee : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;userid=root;password=;database=rmsdatabase ");

        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from AddEmp where EmpID ='" + textBox1.Text + "'";
                int i = cmd.ExecuteNonQuery();
                
                textBox1.Text = "";
                if (i > 0)
                {
                    MessageBox.Show("Record deleted successfully");
                }
                else
                {
                    MessageBox.Show("Not available Record");
                }
            }
            catch (MySqlException mse)
            {
                MessageBox.Show(mse.Message);
            }
            finally {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            disp_data();

        }
        public void disp_data()
        {
            try
            {
               
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                if (textBox2.Text == "")
                {
                    cmd.CommandText = "Select * from AddEmp where EmpID like '" + textBox1.Text + "'";
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    dataGridView1.DataSource = dt;
                }
                else if (textBox1.Text == "")
                {

                    cmd.CommandText = "Select * from AddEmp where EmpName like '" + textBox2.Text + "'";

                    DataTable ct = new DataTable();
                    ct.Load(cmd.ExecuteReader());

                    dataGridView1.DataSource = ct;
                }
                else 
                {
                    

                }
                
                    //disp_data();
                con.Close();
                textBox1.Text = "";
                textBox2.Text = "";


            }
            catch (MySqlException mse)
            {
                MessageBox.Show(mse.Message);
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            disp_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Employee_Home().Show();
            this.Hide();
        }
    }
}
