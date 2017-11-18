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
using System.Text.RegularExpressions;

namespace HRManagement
{
    public partial class Form1 : Form
    {

        MySqlConnection con = new MySqlConnection(@"server=localhost;userid=root;password=;database=rmsdatabase ");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (textBox1.Text == "")
                {
                    MessageBox.Show("EmployeeID cant be empty");
                }


                else if (textBox2.Text == "")
                {
                    MessageBox.Show("EmployeeName cant be empty");
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show("Email cant be empty");
                }
                else if (textBox4.Text == "")
                {
                    MessageBox.Show("Phone no cant be empty");

                }
               
                else if (textBox5.Text == "")
                {
                    MessageBox.Show("joined date cant be empty");
                }
                else if (textBox7.Text == "")
                {
                    MessageBox.Show("SalaryPerDay cant be empty");
                }
                else if (textBox6.Text == "")
                {
                    MessageBox.Show("DOB cant be empty");
                }
                else if (comboBox1.Text == "")
                {
                    MessageBox.Show("Gender cant be empty");
                }
                else if (comboBox2.Text == "")
                {
                    MessageBox.Show("Please mention the department");
                }

                 else if (textBox4.TextLength != 10)
                {
                    MessageBox.Show("Wrong Phone no Please check it again",
                                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (textBox1.TextLength != 3)
                {
                    MessageBox.Show("type 3 digit number ",
                                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //else if (!string.IsNullOrWhiteSpace(textBox3.Text))
                //{
                //    Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                //    if (!reg.IsMatch(textBox3.Text))
                //    {
                //        MessageBox.Show("Invalid Email address ",
                //                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //    }
                //}


                else
                {



                    new System.Net.Mail.MailAddress(this.textBox3.Text);




                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into AddEmp values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox6.Text + "','" + textBox5.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox7.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";

                    MessageBox.Show("Record inserted successfully");
                }
            }
            catch (ArgumentException ae)
            {
               MessageBox.Show(ae.Message);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            catch (MySqlException mse)
            {
                MessageBox.Show(mse.Message);
            }
            disp_data();
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            textBox5.Text = monthCalendar1.SelectionStart.Day.ToString() + "/" +
            monthCalendar1.SelectionStart.Month.ToString() + "/" +
            monthCalendar1.SelectionStart.Year.ToString();
            monthCalendar1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void disp_data()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from AddEmp";// ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                //da.Fill(dt);
                dataGridView1.DataSource = dt;
                //disp_data();
                con.Close();


            }
            catch (MySqlException mse)
            {
                MessageBox.Show(mse.Message);
            }
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox6.Text = monthCalendar2.SelectionStart.Day.ToString() + "/" +
            monthCalendar2.SelectionStart.Month.ToString() + "/" +
            monthCalendar2.SelectionStart.Year.ToString();
            monthCalendar2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            monthCalendar2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Employee_Home().Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

