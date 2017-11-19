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
using Resturant.Properties;

namespace RCTRM
{
    public partial class ExpensesUI : Form
    {
        public ExpensesUI()
        {
            InitializeComponent();
            Expenses ex1 = new Expenses();
            ex1.viewGrid(dataGridView1);
            btnEdit.Visible = false;
            btnDelete.Visible = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool recnexists;
                String date = Convert.ToString(dateTimePicker1.Text);

                Expenses ex1 = new Expenses();
                recnexists = ex1.Reciptnumberexsist(txtRecNo.Text);

                //amtisnull = ex1.checkNull(txtAmount.Text);
                if (txtAmount.Text.Length != 0 && comboBox2.Text.Length != 0 && txtRecNo.Text.Length != 0 && comboBox1.Text.Length != 0)
                {
                    float amt = float.Parse(txtAmount.Text);

                    if (recnexists != true)
                    {
                        //MessageBox.Show(comboBox2.Text);
                        //MessageBox.Show(comboBox1.Text);
                        //MessageBox.Show(txtRecNo.Text);

                        ex1.addExpense(comboBox1.Text, comboBox2.Text, date, txtRecNo.Text, amt);
                        ex1.viewGrid(dataGridView1);
                        comboBox2.Text = "";
                        comboBox1.Text = "";
                        txtRecNo.Text = "";
                        txtAmount.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Invoice/Bill Number Already Exsist");
                    }

                }
            else
            {
                MessageBox.Show("Fill all fields");
            }
         }
         catch (Exception ex)
        {
                MessageBox.Show(ex.Message);
        }


        }



        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                comboBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtRecNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtAmount.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                bool recnexists;
                if (txtAmount.Text.Length != 0 && comboBox2.Text.Length != 0 && txtRecNo.Text.Length != 0 && comboBox1.Text.Length != 0)
                {
                    String date = Convert.ToString(dateTimePicker1.Text);
                    float amt = float.Parse(txtAmount.Text);
                    Expenses ex1 = new Expenses();
                    recnexists = ex1.Reciptnumberexsist(txtRecNo.Text);
                    if (recnexists != true)
                    {
                        ex1.alterExpense(comboBox2.Text, comboBox1.Text, date, txtRecNo.Text, amt);
                        ex1.viewGrid(dataGridView1);
                        comboBox2.Text = "";
                        comboBox1.Text = "";
                        txtRecNo.Text = "";
                        txtAmount.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Reciept Number Already Exsist");
                    }
                }

                else
                {
                    MessageBox.Show("Fields are empty");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Expenses ex1 = new Expenses();
                ex1.deleteExpense(txtRecNo.Text);
                ex1.viewGrid(dataGridView1);

                comboBox2.Text = "";
                comboBox1.Text = "";
                txtRecNo.Text = "";
                txtAmount.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text.Length != 0)
                {
                    string ConnectString = "datasource = 127.0.0.1; username = root;password = ; database = rmsdatabase";
                    MySqlConnection DBConnect = new MySqlConnection(ConnectString);


                    string query = "SELECT * FROM expense WHERE Recipt_No like '" + txtSearch.Text + "'";
                    // "SELECT * FROM `expense` WHERE `Invoice/Bill Number` = '" + txtSearch.Text + "'";

                    MySqlCommand commandDatabase = new MySqlCommand(query, DBConnect);
                    commandDatabase.CommandTimeout = 60;
                    MySqlDataReader reader;
                    try
                    {
                        DBConnect.Open();
                        reader = commandDatabase.ExecuteReader();
                        if (reader.Read())
                        {
                            txtRecNo.Text = reader.GetString("Invoice/Bill Number");
                            comboBox2.Text = reader.GetString("Descri");
                            comboBox1.Text = reader.GetString("Type");
                            dateTimePicker1.Text = reader.GetString("Date");
                            txtAmount.Text = reader.GetString("Amount");
                            btnEdit.Visible = true;
                            btnDelete.Visible = true;
                            txtRecNo.ReadOnly = true;
                            txtSearch.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Recipt_No Number Not Found!");
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
                    MessageBox.Show("Search Field Is Empty!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard m1 = new Dashboard();
            m1.Show();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Enter Valid Input!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExpensesUI_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
            btnDelete.Visible = true;
            txtRecNo.ReadOnly = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Expenses ex1 = new Expenses();
            DBconnector db1 = new DBconnector();
            MySqlConnection conn = db1.getConnection();


            DateTime day = DateTime.Today;
            String date = Convert.ToString(day);
            string hour = day.ToString("HH");
            string minutes = day.ToString("mm");
            int h = int.Parse(hour);
            int m = int.Parse(minutes);
            if (h == 23 && m >= 0)
            {

                string ConnectString = "datasource = 127.0.0.1; username = root;password = ; database = rmsdatabase";
                MySqlConnection DBConnect = new MySqlConnection(ConnectString);
                MySqlCommand commandDatabase = DBConnect.CreateCommand();
                commandDatabase.CommandText = "SELECT sum(Amount) from salary where date = '" + day + "'";
                int result = ((int)commandDatabase.ExecuteScalar());
                ex1.addExpense(comboBox2.Text, comboBox1.Text, date, txtRecNo.Text, result);
                conn.Close();

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dashboard dB1 = new Dashboard();
            dB1.Show();
            this.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Resources.backspace_dark;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Resources.left_arrow_thin_symbol_in_circular_button;
        }

        private void btnAdd_MouseMove(object sender, MouseEventArgs e)
        {
            btnAdd.BackgroundImage = Resources.plus;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackgroundImage = Resources.plus__1_;
        }

        private void btnEdit_MouseMove(object sender, MouseEventArgs e)
        {
            btnEdit.BackgroundImage = Resources.update_arrows;
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.BackgroundImage = Resources.update_arrows__1_;
        }

        private void btnDelete_MouseMove(object sender, MouseEventArgs e)
        {
            btnDelete.BackgroundImage = Resources.delete__1_;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackgroundImage = Resources.delete;
        }

        private void btnSearch_MouseMove(object sender, MouseEventArgs e)
        {
            btnSearch.BackgroundImage = Resources.search;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackgroundImage = Resources.search__1_;
        }
    }

    }

    