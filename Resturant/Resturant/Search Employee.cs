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
    public partial class Search_Employee : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;userid=root;password=;database=rmsdatabase ");

        public Search_Employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
               
                    cmd.CommandText = "Select * from AddEmp where Department like '" + comboBox1.Text + "'";
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    dataGridView1.DataSource = dt;
                    con.Close();
                    comboBox1.Text = "";
                


            }
            catch (MySqlException mse)
            {
                MessageBox.Show(mse.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Employee_Home().Show();
            this.Hide();
        }
    }
}
