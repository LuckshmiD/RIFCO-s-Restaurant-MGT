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
    public partial class Signup : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;userid=root;password=;database=rmsdatabase ");

        public Signup()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = "", password = "";

                if (textBox1.Text == "")
                {
                    MessageBox.Show("Fullname cant be empty");
                }


                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Username cant be empty");
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show("E-mail cant be empty");
                }
                else if (textBox4.Text == "")
                {
                    MessageBox.Show("Password cant be empty");
                }
                else if (textBox5.Text == "")
                {
                    MessageBox.Show("Please type Confirm Password ");
                }
                else if (textBox4.Text != textBox5.Text)
                {
                    MessageBox.Show("Not match Password ");
                }


                else if (textBox6.Text == "" && textBox7.Text == "")
                {
                    MessageBox.Show("Please Type Current Manager's Username and Password");

                }
                else 
                {

                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select Username,Password from Login where Username='"+textBox6.Text+"' ";
                    MySqlDataReader r = cmd.ExecuteReader();
                    if (r.Read())
                    {

                        username = r.GetString("Username");
                        password = r.GetString("Password");
                    }

                    r.Close();

                    //MessageBox.Show(username);
                    //MessageBox.Show(password);

                    if (username != "" && password != "" ) {

                        new System.Net.Mail.MailAddress(this.textBox3.Text);

                        //con.Open();
                        MySqlCommand cmd1 = con.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = "insert into Signup values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                        cmd1.ExecuteNonQuery();
                        //con.Close();
                        MySqlCommand cmd2 = con.CreateCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "insert into Login values('" + textBox2.Text + "','" + textBox4.Text + "')";
                        cmd2.ExecuteNonQuery();
                        textBox1.Text = "";

                        MySqlCommand cmd12 = con.CreateCommand();
                        cmd12.CommandType = CommandType.Text;
                        cmd12.CommandText = "Select user";
                        cmd12.ExecuteNonQuery();
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";

                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";

                        MessageBox.Show("Now you can login!!!!");
                    }
                    else
                    {
                        label8.Text = "Invalid Username or Password";
                    }
                    //DataTable ct1 = new DataTable();
                    //ct1.Load(cmd.ExecuteReader());
                    //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    //da.Fill(ct1);
                    //int i = Convert.ToInt32(ct1.Rows.Count.ToString());




                    //disp_data();
                    con.Close();
                

              



                    




                   
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
        }
        }
    }

