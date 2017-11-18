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
    public partial class UpdateEmployee : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;userid=root;password=;database=rmsdatabase ");
        public UpdateEmployee()
        {
            InitializeComponent();
            comboBox2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Employee_Home().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();


                if (comboBox1.Text == "Employee Name")
                {
                    cmd.CommandText = "Update AddEmp set EmpName ='" + textBox2.Text + "' where EmpID = '" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    textBox2.Text = "";
                    textBox3.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";

                    MessageBox.Show("Record Updated successfully");

                }

                if (comboBox1.Text == "SalaryPerDay")
                {
                    cmd.CommandText = "Update AddEmp set SalaryPerDay ='" + textBox2.Text + "' where EmpID = '" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    textBox2.Text = "";
                    textBox3.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";

                    MessageBox.Show("Record Updated successfully");

                }
                else if (comboBox1.Text == "Department")
                {
                    cmd.CommandText = "Update AddEmp set Department ='" + comboBox2.Text + "' where EmpID = '" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    textBox2.Text = "";
                    textBox3.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";

                    MessageBox.Show("Record Updated successfully");

                }
                else if (comboBox1.Text == "Phone No")
                {
                    try
                    {
                        int x = int.Parse(textBox2.Text);
                        if (textBox2.TextLength != 10)
                        {
                            MessageBox.Show("Wrong Phone no Please check it again",
                                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cmd.CommandText = "Update AddEmp set PhoneNo ='" + textBox2.Text + "' where EmpID = '" + textBox1.Text + "'";
                            cmd.ExecuteNonQuery();
                            textBox2.Text = "";
                            textBox3.Text = "";
                            comboBox1.Text = "";
                            comboBox2.Text = "";

                            MessageBox.Show("Record Updated successfully");

                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Enter a valid phone number!!!");
                    }

                }
                else if (comboBox1.Text == "Email")
                {
                    cmd.CommandText = "Update AddEmp set e-mail ='" + textBox2.Text + "' where EmpID = '" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    textBox2.Text = "";
                    textBox3.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";

                    MessageBox.Show("Record Updated successfully");

                }
                else if (comboBox1.Text == "Joined Date")
                {
                    cmd.CommandText = "Update AddEmp set Joined date ='" + textBox3.Text + "' where EmpID = '" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    textBox2.Text = "";
                    textBox3.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";

                    MessageBox.Show("Record Updated successfully");

                }
                else if (comboBox1.Text == "DOB")
                {
                    cmd.CommandText = "Update AddEmp set DOB ='" + textBox3.Text + "' where EmpID = '" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    textBox2.Text = "";
                    textBox3.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";

                    MessageBox.Show("Record Updated successfully");

                }
                else {
                }
                

               


                //textBox1.Text = "";
                //if (i > 0)
                //{
                //    MessageBox.Show("Record deleted successfully");
                //}
                //else
                //{
                //    MessageBox.Show("Not available Record");
                //}
            }
            catch (MySqlException mse)
            {
                MessageBox.Show(mse.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void disp_data()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from AddEmp where EmpID like '" + textBox1.Text + "'";// ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";

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

        private void button3_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox3.Text = monthCalendar1.SelectionStart.Day.ToString() + "/" +
            monthCalendar1.SelectionStart.Month.ToString() + "/" +
            monthCalendar1.SelectionStart.Year.ToString();
            monthCalendar1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Department")
            {
                comboBox2.Enabled = true;
            }
            else {
                comboBox2.Enabled = false;
            }
            if (comboBox1.Text == "Joined Date" || comboBox1.Text == "DOB")
            {
                textBox3.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
            }
        }
    }
}
