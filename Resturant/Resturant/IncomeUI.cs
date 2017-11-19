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

namespace RCTRM
{
    public partial class IncomeUI : Form
    {
        public IncomeUI()
        {
            InitializeComponent();
            Income in1 = new Income();
            in1.viewGrid(dataGridView1);
            btnEdit.Visible = false;
           
        }
 
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            bool vounexists;
            if (txtAmount.Text.Length != 0 && comboBox2.Text.Length != 0 && txtVouNo.Text.Length != 0 && comboBox1.Text.Length != 0)
            {
                try
                {

                    String date = Convert.ToString(dateTimePicker1.Text);

                    Income in1 = new Income();
                    vounexists = in1.Vouchernumberexsist(txtVouNo.Text);



                    float amt = float.Parse(txtAmount.Text);
                    if (vounexists != true)
                    {
                        in1.addIncome(comboBox2.Text, comboBox1.Text, date, txtVouNo.Text, amt);
                        in1.viewGrid(dataGridView1);
                        comboBox2.Text = "";
                        txtVouNo.Text = "";
                        txtAmount.Text = "";
                        comboBox1.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("VoucherNumber Already Exsist");
                    }

                }
                catch (Exception mse)
                {
                    MessageBox.Show(mse.Message);
                }

            }
            else
            {
                MessageBox.Show("Fill  all fields");
            }

        }

        
        

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (txtAmount.Text.Length != 0 && comboBox2.Text.Length != 0 && txtVouNo.Text.Length != 0 && comboBox1.Text.Length != 0)
            {   
                bool vounexists;
                {
                    String date = Convert.ToString(dateTimePicker1.Text);
                    float amt = float.Parse(txtAmount.Text);
                    int id = Convert.ToInt32(txtIncId.Text);

                    Income in1 = new Income();
                    vounexists = in1.Vouchernumberexsist(txtVouNo.Text);
                    if (vounexists != true)
                    {
                        in1.alterIncome(id, comboBox2.Text, comboBox1.Text, date, txtVouNo.Text, amt);
                        in1.viewGrid(dataGridView1);
                        txtIncId.Text = "";
                        comboBox2.Text = "";
                        txtVouNo.Text = "";
                        txtAmount.Text = "";
                        comboBox1.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("VoucherNumber already exsist");
                    }
                }
            }
            else
            {
                MessageBox.Show("Fields are empty");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length != 0)
            {

                int id = Convert.ToInt32(txtIncId.Text);
                Income in1 = new Income();
                in1.deleteIncome(id);
                in1.viewGrid(dataGridView1);
                txtIncId.Text = "";
                comboBox2.Text = "";
                txtVouNo.Text = "";
                txtAmount.Text = "";
                comboBox1.Text = "";
                txtSearch.Text = "";
            }
            else
            {
                MessageBox.Show("Search Entry Number and Delete ");
            }

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {

            if (txtSearch.Text.Length != 0)
            {

                string ConnectString = "datasource = 127.0.0.1; username = root;password = ; database = rest";
                MySqlConnection DBConnect = new MySqlConnection(ConnectString);
                //int search1 = Convert.ToInt32(txtSearch.Text);
                Income in1 = new Income();
                string query = "SELECT * FROM income WHERE Voucher_No like '"+txtSearch.Text+"'";

                MySqlCommand commandDatabase = new MySqlCommand(query, DBConnect);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                try
                {
                    DBConnect.Open();
                    reader = commandDatabase.ExecuteReader();
                    if (reader.Read())
                    {
                        //txtIncId.Text = reader.GetString("EntryNumber");
                        //comboBox2.Text = reader.GetString("Descri");
                        //comboBox1.Text = reader.GetString("Type");
                        //dateTimePicker1.Text = reader.GetString("Date");
                        //txtVouNo.Text = reader.GetString("Voucher_No");
                        //txtAmount.Text = reader.GetString("Amount");
                        in1.viewGrid1(dataGridView1, query);
                        
                    }
                    else
                    {
                        MessageBox.Show("Voucher Number Not Found!");
                    }
                    //MessageBox.Show("Succesfully Deleted");
                    DBConnect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Search Field is Empty ");
            }

        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Enter Valid Input!");
            }
            else if(txtAmount.Text == null)
            {
                MessageBox.Show("Enter a value!");
            }
        }

        private void dataGridView1_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtIncId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtVouNo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAmount.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void txtVouNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dB1 = new Dashboard();
            dB1.Show();
            this.Hide();
        }

        

        private void txtDescr_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtIncId.Text = "";
            comboBox2.Text = "";
            txtVouNo.Text = "";
            txtAmount.Text = "";
            comboBox1.Text = "";
            txtSearch.Text = "";
        }
    }
}
