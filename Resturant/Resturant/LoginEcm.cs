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

namespace EventCaterMgt
{
    public partial class LoginEcm : Form
    {
        MySqlConnection con;
        public LoginEcm()
        {
            InitializeComponent();
            con = new MySqlConnection(@"server=localhost;userid=root;password=;database=rmsdatabase");
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (usercombo.SelectedIndex < 0)
            {
                MessageBox.Show("Invalid User", "Error");
            }
            else
            {

                string uname = usercombo.SelectedItem.ToString();
                string password = pwd.Text;

                string query = "SELECT password from loginecm where user ='" + uname + "'";
                //string query1 = "select * from loginecm";

                try
                {
                    con.Open();
                   // MySqlCommand command1 = new MySqlCommand(query1, con);

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    var reader = cmd.ExecuteReader();

                   


                   

                    if (reader.Read())
                    {
                        if (reader.GetString("password") == password)
                        {
                           // MessageBox.Show(uname + " logged in successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // MainECM me = new MainECM();
                            createMenu main = new createMenu();

                            main.Show();
                            this.Hide();
                            

                            
                        }
                        else
                        {
                            MessageBox.Show("Incorrect User/Password");
                        }
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }





        private void quit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoginEcm_Load(object sender, EventArgs e)
        {
            try
            {
                string selectquery = "Select * from loginecm";

                con.Open();
                MySqlCommand command = new MySqlCommand(selectquery, con);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    usercombo.Items.Add(reader.GetString("user"));


                }
                reader.Close();



                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
