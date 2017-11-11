using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCTRM
{
    public partial class TrackRevExp : Form
    {
        public TrackRevExp()
        {
            InitializeComponent();
        }

        private void TrackRevExp_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text.Length != 0)
                {
                    if (comboBox1.Text == "Revenue")
                    {

                        Expenses ex1 = new Expenses();
                        string query = "SELECT* FROM `income` WHERE Date BETWEEN '" + dateTimePicker1.Text + "'AND '" + dateTimePicker2.Text + "'";
                        ex1.viewGrid(dataGridView1, query);
                    }
                    else if (comboBox1.Text == "Expenditure")
                    {
                        Expenses ex1 = new Expenses();
                        string query = "SELECT* FROM `expense` WHERE Date BETWEEN '" + dateTimePicker1.Text + "'AND '" + dateTimePicker2.Text + "'";
                        ex1.viewGrid(dataGridView1, query);


                    }
                }
                else
                {
                    MessageBox.Show("Select Type!");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dB1 = new Dashboard();
            dB1.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MaxDate = DateTime.Today;
        }
    }
}