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
    public partial class meeting : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;userid=root;password=;database=rmsdatabase ");
        public meeting()
        {
            InitializeComponent();
            button2.Visible = false;
            button4.Visible = false;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Max(meetingID) from meeting";
            MySqlDataReader rd = cmd.ExecuteReader();
            //rd.Read();
            if (rd.Read())
            {
                string val = rd[0].ToString();
                if (val == "")
                {
                    textBox1.Text = "1";
                }
                else
                {
                    int a = Convert.ToInt32(rd[0].ToString());
                    a = a + 1;
                    textBox1.Text = a.ToString();
                }
            }
            con.Close();
        }

        private void meeting_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Employee_Home().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteLeave();
            disp1_data();
        }
        public void disp1_data()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from meeting";

                DataTable ct1 = new DataTable();
                ct1.Load(cmd.ExecuteReader());
                //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                //da.Fill(dt);
                dataGridView1.DataSource = ct1;
                //disp_data();
                con.Close();


            }
            catch (MySqlException mse)
            {
                MessageBox.Show(mse.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePicker1.Text == "" || comboBox1.Text == "")
                {
                    MessageBox.Show("Enter All Details",
                                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into meeting values('" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + comboBox1.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    comboBox1.Text = "";
                    dateTimePicker1.Text = "";

                    MessageBox.Show("meeting saved successfully");
                }
                con.Open();
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "Select Max(meetingID) from meeting";
                MySqlDataReader rd = cmd1.ExecuteReader();
                //rd.Read();
                if (rd.Read())
                {
                    string val = rd[0].ToString();
                    if (val == "")
                    {
                        textBox1.Text = "1";
                    }
                    else
                    {
                        int a = Convert.ToInt32(rd[0].ToString());
                        a = a + 1;
                        textBox1.Text = a.ToString();
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

        private void button5_Click(object sender, EventArgs e)
        {
            disp1_data();
        }

        public void deleteLeave()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from meeting where meetingID = '" + textBox1.Text + "'";

                DataTable ct1 = new DataTable();
                ct1.Load(cmd.ExecuteReader());
                //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                //da.Fill(dt);
                dataGridView1.DataSource = ct1;
                //disp_data();
                con.Close();

                con.Open();
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "Select Max(meetingID) from meeting";
                MySqlDataReader rd = cmd1.ExecuteReader();
                //rd.Read();
                if (rd.Read())
                {
                    string val = rd[0].ToString();
                    if (val == "")
                    {
                        textBox1.Text = "1";
                    }
                    else
                    {
                        int a = Convert.ToInt32(rd[0].ToString());
                        a = a + 1;
                        textBox1.Text = a.ToString();
                    }
                }
                con.Close();


            }
            catch (MySqlException mse)
            {
                MessageBox.Show(mse.Message);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button4.Visible = true;
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update meeting set meetingID = '" + textBox1.Text + "', meetingDate = '" + dateTimePicker1.Text + "', department = '" + comboBox1.Text + "' where meetingID = '" + textBox1.Text + "' ";

                DataTable ct1 = new DataTable();
                ct1.Load(cmd.ExecuteReader());
                //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                //da.Fill(dt);
                dataGridView1.DataSource = ct1;
                //disp_data();
                con.Close();
                disp1_data();

                con.Open();
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "Select Max(meetingID) from meeting";
                MySqlDataReader rd = cmd1.ExecuteReader();
                //rd.Read();
                if (rd.Read())
                {
                    string val = rd[0].ToString();
                    if (val == "")
                    {
                        textBox1.Text = "1";
                    }
                    else
                    {
                        int a = Convert.ToInt32(rd[0].ToString());
                        a = a + 1;
                        textBox1.Text = a.ToString();
                    }
                }
                con.Close();
                comboBox1.Text = "";
                dateTimePicker1.Text = "";


            }
            catch (MySqlException mse)
            {
                MessageBox.Show(mse.Message);
            }
        }
    }
}
