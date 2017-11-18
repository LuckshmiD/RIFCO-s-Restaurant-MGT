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
    public partial class empSal : Form
    {
        float s = 0;
        float salaryPerday =0;
        MySqlConnection con = new MySqlConnection(@"server=localhost;userid=root;password=;database=rmsdatabase ");
        public empSal()
        {
            InitializeComponent();
            

            //con.Open();
            //MySqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "Select * from salary ORDER BY SalaryID DESC LIMIT 1";
            //MySqlDataReader rd1 = cmd.ExecuteReader();
            //rd1.Read();
            
            //int sid = rd1.GetInt32("SalaryID");
            //sid++;
            //textBox4.Text = sid.ToString();
            //con.Close();

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void disp_data()
        {
            
                try
                {
                    
                        con.Open();
                        MySqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "Select * from leavetable where EmpID like '" + textBox3.Text + "'";// ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";

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

        private void button4_Click(object sender, EventArgs e)
        {
            new Employee_Home().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int thismonth = Convert.ToInt32(DateTime.Today.ToString("MM"));
            int thisyear = Convert.ToInt32(DateTime.Today.ToString("yyyy"));
            float halfleave = 0;
            float fullleave = 0;
            float totalleave = 0;
            disp_data();
            con.Open();
            

            MySqlCommand cmd = con.CreateCommand();
            MySqlDataReader rd1;

            for (int i = 1; i <= thismonth; i++)
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(*) as half FROM leavetable WHERE EmpID like '" + textBox3.Text + "' AND leaveType like '% half day' AND stLeaveDate like '%"+i+"/" + thisyear + "'";
                rd1 = cmd.ExecuteReader();
                rd1.Read();
                halfleave = halfleave + rd1.GetInt32("half");
                label9.Text = halfleave.ToString();
                rd1.Close();
            }
            con.Close();

            con.Open();

            MySqlCommand cmd1 = con.CreateCommand();
            MySqlDataReader rd2;
            for (int i = 1; i <= thismonth; i++)
            {
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "SELECT COUNT(*) as full FROM leavetable WHERE EmpID like '" + textBox3.Text + "' AND leaveType = 'Full day' AND stLeaveDate like '%" + i + "/" + thisyear + "'";
                rd2 = cmd1.ExecuteReader();
                rd2.Read();
                fullleave =fullleave + rd2.GetInt32("full");
                label10.Text = fullleave.ToString();
                rd2.Close();
            }
            con.Close();

            string month = DateTime.Today.ToString("MM");
            string year = DateTime.Today.ToString("yyyy");
            string leaveDate = month + "/" + year;

            float leaveCount = float.Parse(label9.Text) / 2 + float.Parse(label10.Text);

            label16.Text = leaveCount.ToString();

            //con.Open();

            //MySqlCommand cmd3 = con.CreateCommand();
            //cmd3.CommandType = CommandType.Text;
            //cmd3.CommandText = "SELECT count(*) as mhfull FROM leavetable WHERE stLeaveDate = '" + leaveDate + "' AND EmpID = '" + textBox3.Text + "' and leaveType like '% half day' ";
            //MySqlDataReader rd3 = cmd3.ExecuteReader();
            //rd3.Read();
            //int f1 = rd3.GetInt32("mhfull");
            //label12.Text = f1.ToString();
            //con.Close();
            //con.Open();

            //MySqlCommand cmd11 = con.CreateCommand();
            //cmd11.CommandType = CommandType.Text;
            //cmd11.CommandText = "SELECT count(*) as mffull FROM leavetable WHERE stLeaveDate = '" + leaveDate + "' AND EmpID = '" + textBox3.Text + "' and leaveType like 'Full day' ";
            //MySqlDataReader rd12 = cmd11.ExecuteReader();
            //rd12.Read();
            //int f11 = rd12.GetInt32("mffull");
            //label13.Text = f11.ToString();
            //con.Close();

            con.Open();


            MySqlCommand cmd31 = con.CreateCommand();
            cmd31.CommandType = CommandType.Text;
            cmd31.CommandText = "SELECT SalaryPerDay as sp FROM addemp WHERE EmpID = '" + textBox3.Text + "' ";
            MySqlDataReader rd32 = cmd31.ExecuteReader();
            rd32.Read();
            int f31 = rd32.GetInt32("sp");
            label19.Text = f31.ToString();
            con.Close();
            salaryPerday = float.Parse(label19.Text);





        }

        private void button2_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string year2 = DateTime.Today.ToString("yyyy");
            string month = DateTime.Today.ToString("MM");
            if (comboBox1.Text == "Jan")
            {
                con.Open();
                MySqlCommand cmd5 = con.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "SELECT count(*) as mffull FROM leavetable WHERE stLeaveDate like '%1/2017' AND EmpID = '" + textBox3.Text + "' and leaveType like 'Full day' ";
                MySqlDataReader rd5 = cmd5.ExecuteReader();
                rd5.Read();
                int f5 = rd5.GetInt32("mffull");
                label13.Text = f5.ToString();
                con.Close();

                con.Open();
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "SELECT count(*) as mhhalf FROM leavetable WHERE stLeaveDate like '%1/2017' AND EmpID = '" + textBox3.Text + "' and leaveType like '% half day' ";
                MySqlDataReader rd3 = cmd2.ExecuteReader();
                rd3.Read();
                int f3 = rd3.GetInt32("mhhalf");
                label12.Text = f3.ToString();
                con.Close();

                s = salaryPerday * 31;
            }
            else if (comboBox1.Text == "Feb")
            {
                con.Open();
                MySqlCommand cmd6 = con.CreateCommand();
                cmd6.CommandType = CommandType.Text;
                cmd6.CommandText = "SELECT count(*) as mffull FROM leavetable WHERE stLeaveDate like '%2/2017' AND EmpID = '" + textBox3.Text + "' and leaveType like 'Full day' ";
                MySqlDataReader rd6 = cmd6.ExecuteReader();
                rd6.Read();
                int f6 = rd6.GetInt32("mffull");
                label13.Text = f6.ToString();
                con.Close();

                con.Open();
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "SELECT count(*) as mhhalf FROM leavetable WHERE stLeaveDate like '%2/2017' AND EmpID = '" + textBox3.Text + "' and leaveType like '% half day' ";
                MySqlDataReader rd3 = cmd2.ExecuteReader();
                rd3.Read();
                int f3 = rd3.GetInt32("mhhalf");
                label12.Text = f3.ToString();
                con.Close();

                int year =Convert.ToInt32( DateTime.Today.ToString("yyyy"));


                if (year % 4 == 0)
                {
                    s = salaryPerday * 29;
                }
                else
                {
                    s = salaryPerday * 28;
                }
                

                
            }
            else if (comboBox1.Text == "Mar")
            {
                con.Open();
                MySqlCommand cmd7= con.CreateCommand();
                cmd7.CommandType = CommandType.Text;
                cmd7.CommandText = "SELECT count(*) as mffull FROM leavetable WHERE stLeaveDate like '%3/2017' AND EmpID = '" + textBox3.Text + "' and leaveType like 'Full day' ";
                MySqlDataReader rd7 = cmd7.ExecuteReader();
                rd7.Read();
                int f7 = rd7.GetInt32("mffull");
                label13.Text = f7.ToString();
                con.Close();

                con.Open();
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "SELECT count(*) as mhhalf FROM leavetable WHERE stLeaveDate like '%3/2017' AND EmpID = '" + textBox3.Text + "' and leaveType like '% half day' ";
                MySqlDataReader rd3 = cmd2.ExecuteReader();
                rd3.Read();
                int f3 = rd3.GetInt32("mhhalf");
                label12.Text = f3.ToString();
                con.Close();
                s = salaryPerday * 31;
            }
            else if (comboBox1.Text == "April")
            {
                con.Open();
                MySqlCommand cmd8 = con.CreateCommand();
                cmd8.CommandType = CommandType.Text;
                cmd8.CommandText = "SELECT count(*) as mffull FROM leavetable WHERE stLeaveDate like '%4/2017' AND EmpID = '" + textBox3.Text + "' and leaveType like 'Full day' ";
                MySqlDataReader rd8 = cmd8.ExecuteReader();
                rd8.Read();
                int f8 = rd8.GetInt32("mffull");
                label13.Text = f8.ToString();
                con.Close();

                con.Open();
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "SELECT count(*) as mhhalf FROM leavetable WHERE stLeaveDate like '%4/2017' AND EmpID = '" + textBox3.Text + "' and leaveType like '% half day' ";
                MySqlDataReader rd3 = cmd2.ExecuteReader();
                rd3.Read();
                int f3 = rd3.GetInt32("mhhalf");
                label12.Text = f3.ToString();
                con.Close();
                s = salaryPerday * 30;
            }
            else if (comboBox1.Text == "May")
            {
                con.Open();
                MySqlCommand cmd9 = con.CreateCommand();
                cmd9.CommandType = CommandType.Text;
                cmd9.CommandText = "SELECT count(*) as mffull FROM leavetable WHERE stLeaveDate like '%5/2017' AND EmpID = '" + textBox3.Text + "' and leaveType like 'Full day' ";
                MySqlDataReader rd9 = cmd9.ExecuteReader();
                rd9.Read();
                int f9 = rd9.GetInt32("mffull");
                label13.Text = f9.ToString();
                con.Close();

                con.Open();
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "SELECT count(*) as mhhalf FROM leavetable WHERE stLeaveDate like '%5/2017' AND EmpID = '" + textBox3.Text + "' and leaveType like '% half day' ";
                MySqlDataReader rd3 = cmd2.ExecuteReader();
                rd3.Read();
                int f3 = rd3.GetInt32("mhhalf");
                label12.Text = f3.ToString();
                con.Close();
                s = salaryPerday * 31;
            }
            else if (comboBox1.Text == "June")
            {
                con.Open();
                MySqlCommand cmd10 = con.CreateCommand();
                cmd10.CommandType = CommandType.Text;
                cmd10.CommandText = "SELECT count(*) as mffull FROM leavetable WHERE stLeaveDate like '%6/2017' AND EmpID = '" + textBox3.Text + "' and leaveType like 'Full day' ";
                MySqlDataReader rd10 = cmd10.ExecuteReader();
                rd10.Read();
                int f10 = rd10.GetInt32("mffull");
                label13.Text = f10.ToString();
                con.Close();

                con.Open();
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "SELECT count(*) as mhhalf FROM leavetable WHERE stLeaveDate like '%6/2017' AND EmpID = '" + textBox3.Text + "' and leaveType like '% half day' ";
                MySqlDataReader rd3 = cmd2.ExecuteReader();
                rd3.Read();
                int f3 = rd3.GetInt32("mhhalf");
                label12.Text = f3.ToString();
                con.Close();
                s = salaryPerday * 30;
            }
            else if (comboBox1.Text == "July")
            {
                con.Open();
                MySqlCommand cmd111 = con.CreateCommand();
                cmd111.CommandType = CommandType.Text;
                cmd111.CommandText = "SELECT count(*) as mffull FROM leavetable WHERE stLeaveDate like '%7/2017' AND EmpID = '" + textBox3.Text + "' and leaveType like 'Full day' ";
                MySqlDataReader rd111 = cmd111.ExecuteReader();
                rd111.Read();
                int f111 = rd111.GetInt32("mffull");
                label13.Text = f111.ToString();
                con.Close();

                con.Open();
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "SELECT count(*) as mhhalf FROM leavetable WHERE stLeaveDate like '%7/2017' AND EmpID = '" + textBox3.Text + "' and leaveType like '% half day' ";
                MySqlDataReader rd3 = cmd2.ExecuteReader();
                rd3.Read();
                int f3 = rd3.GetInt32("mhhalf");
                label12.Text = f3.ToString();
                con.Close();
                s = salaryPerday * 31;
            }
            else if (comboBox1.Text == "Aug")
            {
                con.Open();
                MySqlCommand cmd112 = con.CreateCommand();
                cmd112.CommandType = CommandType.Text;
                cmd112.CommandText = "SELECT count(*) as mffull FROM leavetable WHERE stLeaveDate like '%8/2017' AND EmpID = '" + textBox3.Text + "' and leaveType like 'Full day' ";
                MySqlDataReader rd112 = cmd112.ExecuteReader();
                rd112.Read();
                int f112 = rd112.GetInt32("mffull");
                label13.Text = f112.ToString();
                con.Close();

                con.Open();
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "SELECT count(*) as mhhalf FROM leavetable WHERE stLeaveDate like '%8/2017' AND EmpID = '" + textBox3.Text + "' and leaveType like '% half day' ";
                MySqlDataReader rd3 = cmd2.ExecuteReader();
                rd3.Read();
                int f3 = rd3.GetInt32("mhhalf");
                label12.Text = f3.ToString();
                con.Close();
                s = salaryPerday * 31;
            }
            else if (comboBox1.Text == "Sept")
            {
                con.Open();
                MySqlCommand cmd113 = con.CreateCommand();
                cmd113.CommandType = CommandType.Text;
                cmd113.CommandText = "SELECT count(*) as mffull FROM leavetable WHERE stLeaveDate like '%9/2017' AND EmpID = '" + textBox3.Text + "' and leaveType like 'Full day' ";
                MySqlDataReader rd113 = cmd113.ExecuteReader();
                rd113.Read();
                int f113 = rd113.GetInt32("mffull");
                label13.Text = f113.ToString();
                con.Close();

                con.Open();
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "SELECT count(*) as mhhalf FROM leavetable WHERE stLeaveDate like '%9/2017' AND EmpID = '" + textBox3.Text + "' and leaveType like '% half day' ";
                MySqlDataReader rd3 = cmd2.ExecuteReader();
                rd3.Read();
                int f3 = rd3.GetInt32("mhhalf");
                label12.Text = f3.ToString();
                con.Close();
                s = salaryPerday * 30;
            }
            else if (comboBox1.Text == "Oct")
            {
                con.Open();
                MySqlCommand cmd114 = con.CreateCommand();
                cmd114.CommandType = CommandType.Text;
                cmd114.CommandText = "SELECT count(*) as mffull FROM leavetable WHERE stLeaveDate like '%10/2017' AND EmpID = '" + textBox3.Text + "' and leaveType like 'Full day' ";
                MySqlDataReader rd114 = cmd114.ExecuteReader();
                rd114.Read();
                int f114 = rd114.GetInt32("mffull");
                label13.Text = f114.ToString();
                con.Close();

                con.Open();
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "SELECT count(*) as mhhalf FROM leavetable WHERE stLeaveDate like '%10/2017' AND EmpID = '" + textBox3.Text + "' and leaveType like '% half day' ";
                MySqlDataReader rd3 = cmd2.ExecuteReader();
                rd3.Read();
                int f3 = rd3.GetInt32("mhhalf");
                label12.Text = f3.ToString();
                con.Close();
                s = salaryPerday * 31;
            }
            else if (comboBox1.Text == "Nov")
            {
                con.Open();
                MySqlCommand cmd115 = con.CreateCommand();
                cmd115.CommandType = CommandType.Text;
                cmd115.CommandText = "SELECT count(*) as mffull FROM leavetable WHERE stLeaveDate like '%11/2017' AND EmpID = '" + textBox3.Text + "' and leaveType like 'Full day' ";
                MySqlDataReader rd115 = cmd115.ExecuteReader();
                rd115.Read();
                int f115 = rd115.GetInt32("mffull");
                label13.Text = f115.ToString();
                con.Close();

                con.Open();
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "SELECT count(*) as mhhalf FROM leavetable WHERE stLeaveDate like '%11/2017' AND EmpID = '" + textBox3.Text + "' and leaveType like '% half day' ";
                MySqlDataReader rd3 = cmd2.ExecuteReader();
                rd3.Read();
                int f3 = rd3.GetInt32("mhhalf");
                label12.Text = f3.ToString();
                con.Close();
                s = salaryPerday * 30;
            }
            else if (comboBox1.Text == "Dec")
            {
                con.Open();
                MySqlCommand cmd116 = con.CreateCommand();
                cmd116.CommandType = CommandType.Text;
                cmd116.CommandText = "SELECT count(*) as mffull FROM leavetable WHERE stLeaveDate like '%12/2017' AND EmpID = '" + textBox3.Text + "' and leaveType like 'Full day' ";
                MySqlDataReader rd116 = cmd116.ExecuteReader();
                rd116.Read();
                int f116 = rd116.GetInt32("mffull");
                label13.Text = f116.ToString();
                con.Close();

                con.Open();
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "SELECT count(*) as mhhalf FROM leavetable WHERE stLeaveDate like '%12/2017' AND EmpID = '" + textBox3.Text + "' and leaveType like '% half day' ";
                MySqlDataReader rd3 = cmd2.ExecuteReader();
                rd3.Read();
                int f3 = rd3.GetInt32("mhhalf");
                label12.Text = f3.ToString();
                con.Close();
                s = salaryPerday * 31;
            }
            else
            {
                MessageBox.Show("!!!Type the month!!!");
            }
            //int empid = int.Parse(textBox5.Text);
            string month1 = DateTime.Today.ToString("MM");
            string year1 = DateTime.Today.ToString("yyyy");
            string leaveDate1 = month1 + "/" + year1;

            float leaveCount1 = float.Parse(label12.Text) / 2 + float.Parse(label13.Text);

            label18.Text=leaveCount1.ToString();
            con.Open();

            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT count(*) as mhhalf FROM leavetable WHERE stLeaveDate = '"+leaveDate1+"' AND EmpID = '"+textBox3.Text+"' and leaveType like '% half day' ";
            MySqlDataReader rd2 = cmd1.ExecuteReader();
            rd2.Read();
            int f1 = rd2.GetInt32("mhhalf");
            label12.Text= f1.ToString();
            con.Close();
            con.Open();

            MySqlCommand cmd11 = con.CreateCommand();
            cmd11.CommandType = CommandType.Text;
            cmd11.CommandText = "SELECT count(*) as mffull FROM leavetable WHERE stLeaveDate = '" + leaveDate1 + "' AND EmpID = '" + textBox3.Text + "' and leaveType like 'Full day' ";
            MySqlDataReader rd12 = cmd11.ExecuteReader();
            rd12.Read();
            int f11 = rd12.GetInt32("mffull");
            label13.Text = f11.ToString();
            con.Close();

            

            //salary = unitSalary * Days
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           
        }

        private void empSal_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string month1 = DateTime.Today.ToString("MM");
            string year1 = DateTime.Today.ToString("yyyy");
            string leaveDate1 = month1 + "/" + year1;
            
            

            
            
            if (float.Parse(label16.Text) >19)
            {
                
                    if (float.Parse(label16.Text) - float.Parse(label18.Text) >= 19)
                    {
                        s = s - (float.Parse(label18.Text) * float.Parse(label19.Text));
                    }
                    else
                    {
                        
                         if (float.Parse(label16.Text) - 19 < float.Parse(label18.Text))
                        {
                            float i = float.Parse(label18.Text) - (float.Parse(label16.Text) - 19);
                            if (i>0)
                            {
                                s = s - i * 2000;
                            }
                        }
                    }
                
                 
                
            }
            
            label14.Text = s.ToString();


        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("EmployeeID cant be empty");
            }


            else if (label14.Text == "")
            {
                MessageBox.Show("Salary cant be empty");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Paid Date cant be empty");
            }
            else
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into salary values('" + textBox3.Text + "','" + label14.Text + "','" + textBox1.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                textBox3.Text = "";
                label14.Text = "";
                textBox1.Text = "";



                MessageBox.Show("Salary inserted successfully");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.Day.ToString() + "/" +
            monthCalendar1.SelectionStart.Month.ToString() + "/" +
            monthCalendar1.SelectionStart.Year.ToString();
            monthCalendar1.Visible = true;
        }
    }
}
