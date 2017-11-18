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
    public partial class leaveManagement : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;userid=root;password=;database=rmsdatabase ");
        public leaveManagement()
        {
            InitializeComponent();
            //button7.Visible = false;
            //button5.Visible = false;
            //con.Open();
            //MySqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "Select * from leaveTable ORDER BY leaveID DESC LIMIT 1";
            //MySqlDataReader rd = cmd.ExecuteReader();
            //rd.Read();
            //int id = rd.GetInt32("leaveID");
            //id++;
            //textBox4.Text = id.ToString();
            //con.Close();
            button7.Visible = false;
            button5.Visible = false;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Max(LeaveId) from leaveTable";
            MySqlDataReader rd = cmd.ExecuteReader();
            //rd.Read();
            if (rd.Read())
            {
                string val = rd[0].ToString();
                if (val == "")
                {
                    textBox4.Text = "1";
                }
                else
                {
                    int a = Convert.ToInt32(rd[0].ToString());
                    a = a + 1;
                    textBox4.Text = a.ToString();
                }
            }
            con.Close();

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.Day.ToString()+"/"+
            monthCalendar1.SelectionStart.Month.ToString() + "/" +
            monthCalendar1.SelectionStart.Year.ToString();
            monthCalendar1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            
        }

        public void disp_data()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from AddEmp where EmpID like '" + textBox2.Text + "'";

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

        private void button2_Click(object sender, EventArgs e)
        {
           disp_data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Employee_Home().Show();
            this.Hide();

        }

        private void leaveManagement_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "" || textBox4.Text =="" || textBox1.Text == "" || comboBox1.Text == "")
                {
                    MessageBox.Show("Enter All Details",
                                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                else
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into leaveTable values('" + textBox4.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox1.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    textBox1.Text = "";
                    textBox2.Text = "";

                    MessageBox.Show("Leave Added successfully");
                }
                con.Open();
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "Select Max(LeaveId) from leaveTable";
                MySqlDataReader rd = cmd1.ExecuteReader();
                //rd.Read();
                if (rd.Read())
                {
                    string val = rd[0].ToString();
                    if (val == "")
                    {
                        textBox4.Text = "1";
                    }
                    else
                    {
                        int a = Convert.ToInt32(rd[0].ToString());
                        a = a + 1;
                        textBox4.Text = a.ToString();
                    }
                }
                con.Close();
            }
            catch (MySqlException mse)
            {
                MessageBox.Show(mse.Message);
            }
            disp1_data();
        }
        public void disp1_data()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from leaveTable";

                DataTable ct1 = new DataTable();
                ct1.Load(cmd.ExecuteReader());
                //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                //da.Fill(dt);
                dataGridView2.DataSource = ct1;
                //disp_data();
                con.Close();


            }
            catch (MySqlException mse)
            {
                MessageBox.Show(mse.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            deleteLeave();
            disp2_data();
        }
        public void deleteLeave() {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from leavetable where leaveID = '"+textBox4.Text+"'";

                DataTable ct1 = new DataTable();
                ct1.Load(cmd.ExecuteReader());
                //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                //da.Fill(dt);
                dataGridView2.DataSource = ct1;
                //disp_data();
                con.Close();

                con.Open();
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "Select Max(LeaveId) from leaveTable";
                MySqlDataReader rd = cmd1.ExecuteReader();
                //rd.Read();
                if (rd.Read())
                {
                    string val = rd[0].ToString();
                    if (val == "")
                    {
                        textBox4.Text = "1";
                    }
                    else
                    {
                        int a = Convert.ToInt32(rd[0].ToString());
                        a = a + 1;
                        textBox4.Text = a.ToString();
                    }
                }
                con.Close();


            }
            catch (MySqlException mse)
            {
                MessageBox.Show(mse.Message);
            }


        }
        public void disp2_data()
        {

            try
            {

                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from leavetable";// ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                //da.Fill(dt);
                dataGridView2.DataSource = dt;
                //disp_data();
                con.Close();



            }
            catch (MySqlException mse)
            {
                MessageBox.Show(mse.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            disp2_data();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update leavetable set leaveID = '" + textBox4.Text + "', leaveType = '"+comboBox1.Text+"', stLeaveDate = '"+textBox1.Text+ "' where leaveID = '" + textBox4.Text + "' ";

                DataTable ct1 = new DataTable();
                ct1.Load(cmd.ExecuteReader());
                //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                //da.Fill(dt);
                dataGridView2.DataSource = ct1;
                //disp_data();
                con.Close();
                disp2_data();

                con.Open();
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "Select Max(LeaveId) from leaveTable";
                MySqlDataReader rd = cmd1.ExecuteReader();
                //rd.Read();
                if (rd.Read())
                {
                    string val = rd[0].ToString();
                    if (val == "")
                    {
                        textBox4.Text = "1";
                    }
                    else
                    {
                        int a = Convert.ToInt32(rd[0].ToString());
                        a = a + 1;
                        textBox4.Text = a.ToString();
                    }
                }
                con.Close();

            }
            catch (MySqlException mse)
            {
                MessageBox.Show(mse.Message);
            }
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            button7.Visible = true;
            button5.Visible = true;
            textBox4.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            //textBox5.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox1.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
