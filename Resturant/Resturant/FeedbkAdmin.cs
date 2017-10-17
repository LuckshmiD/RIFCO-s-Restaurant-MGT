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
    public partial class FeedbkAdmin : Form
    {
        public object Me { get; private set; }

        public FeedbkAdmin()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            string strSQL = "select * from feedback";
            try
            {


                databaseConnection.Open();
                MySqlDataAdapter mydata = new MySqlDataAdapter(strSQL, databaseConnection);
                MySqlCommandBuilder cBuilder = new MySqlCommandBuilder(mydata);
                DataSet ds = new DataSet();
                mydata.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                { }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rmsdatabase;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            string strSQL = "select * from feedback where Rate= '" + comboBox1.Text.ToString() + "'";
           

            try
            {


                databaseConnection.Open();
                MySqlDataAdapter mydata = new MySqlDataAdapter(strSQL, databaseConnection);
                MySqlCommandBuilder cBuilder = new MySqlCommandBuilder(mydata);
                DataSet ds = new DataSet();
                mydata.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                databaseConnection.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                { }


            }
            int count;
            Methods m2 = new Methods();
            count=m2.getcountofRating(comboBox1.Text.ToString());
            textBox1.Text = count.ToString();

            int total;
            Methods m3 = new Methods();
            total = m3.getmaxofRating();
            textBox3.Text = total.ToString();

           
            double cnew = Convert.ToDouble(textBox1.Text);
            double totnew = Convert.ToDouble(textBox3.Text);
            double percent = Convert.ToDouble((cnew/totnew ) * 100);
            textBox2.Text = percent.ToString();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FeedbkAdmin_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void rectangleShape4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.SelectedIndex = 0;
        }
    }
    }

