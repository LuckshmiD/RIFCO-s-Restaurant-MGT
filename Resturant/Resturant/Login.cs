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
using Resturant;

namespace HRManagement
{
    public partial class Login : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;userid=root;password=;database=rmsdatabase");
        int i;
        public Login()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Login where Username = '"+ textBox1.Text + "' and Password = '"+textBox2.Text+"'" ;

                DataTable ct1 = new DataTable();
                ct1.Load(cmd.ExecuteReader());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(ct1);
                i = Convert.ToInt32(ct1.Rows.Count.ToString());

                if (i == 0)
                {
                    label6.Text = "Invalid Username or Password";
                }
                else {
                   
                    this.Hide();
                    new AdminModuleInterface().Show();
                }
                
                //disp_data();
                con.Close();


            }
            catch (MySqlException mse)
            {
                MessageBox.Show(mse.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Signup().Show();
            this.Hide();
        }
    }
    }

