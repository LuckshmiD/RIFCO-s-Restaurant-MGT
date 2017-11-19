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
using Transport;
using OrderManagement;

namespace Transport
{
    public partial class Add_Driver_UI : Form
    {
        MySqlConnection conUI;

        public Add_Driver_UI()
        {
            InitializeComponent();
            conUI = new MySqlConnection(@"server=localhost;userid=root;password=;database=rmsdatabase ");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                if ((idIn.Text == "") || (licNo.Text == "") || (nameIn.Text == "") || (addressIn.Text == "") || (numbIn.Text == "") || (plateIn.Text == ""))
                {
                    MessageBox.Show("Field(s) cannnot be blank");

                }

                else if (numbIn.Text.Length > 10)

                {
                    MessageBox.Show("Enter only 10 numbers");

                }

                else if (numbIn.Text.Length < 10)

                {
                    MessageBox.Show("Enter atleast 10 numbers");

                }

                else if (!numbIn.Text.All(c => Char.IsNumber(c)))
                {
                    MessageBox.Show("Enter Numeric values only");
                }

                else if (!nameIn.Text.All(c => Char.IsLetter(c)))
                {
                    MessageBox.Show("Enter letters only");
                }

                else {

                    //MessageBox.Show("check");
                    conUI.Open();

                    MySqlCommand cmd = conUI.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO drivers values('" + idIn.Text + "','" + nameIn.Text + "','" + licNo.Text + "','" + addressIn.Text + "'," + Convert.ToInt64(numbIn.Text) + ",'" + plateIn.Text + "')";
                    cmd.ExecuteNonQuery();

                    //MessageBox.Show("check2");


                    idIn.Text = "";
                    nameIn.Text = "";
                    licNo.Text = "";
                    addressIn.Text = "";
                    numbIn.Text = "";
                    plateIn.Text = "";
                    MessageBox.Show("Record inserted successfully");

                    Filldgv_delete();
                }
            }

            catch (Exception ei)
            {
                MessageBox.Show(ei.Message);

            }
            finally {
                conUI.Close();
            }
            

        }
        string query;
        MySqlCommand cmd;

        public void Filldgv_delete()
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection connfill = dc.getConnection();

            try
            {
                
                connfill.Open();
                MySqlCommand com = new MySqlCommand("SELECT * FROM drivers  ", connfill);

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dgv_delete.AllowUserToAddRows = false;
                dgv_delete.DataSource = dt;

                dgv_delete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                
                connfill.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        string itemcodedelete = "";

        private void button_Tdelete_Click(object sender, EventArgs e)
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection conn = dc.getConnection();

            //orderlist.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            try
            {
                MessageBox.Show(itemcodedelete.ToString());

                dgv_delete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_delete.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                if (itemcodedelete != "")
                {
                    conn.Open();
                    //MySqlCommand com = new MySqlCommand("INSERT INTO orderlist(itemcode,itemname,portionsize,quantity) VALUES ('" + itemcode.Text + "','" + itemname.Text + "','" + psize.Text + "','" + qty.Value + "')", conn);
                    MySqlCommand com = new MySqlCommand("DELETE FROM drivers WHERE DriverID = '" + itemcodedelete + "'", conn);

                    com.ExecuteNonQuery();


                    MySqlCommand comretrieve = new MySqlCommand("SELECT * FROM drivers ORDER BY Name", conn);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(comretrieve);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    dgv_delete.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


                    dgv_delete.AllowUserToAddRows = false;
                    dgv_delete.DataSource = dt;

                    //dataGridView1.Width = dataGridView1.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) + (dataGridView1.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0) + 3;


                    dgv_delete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }


                //dataGridView1.Rows.Add(itemcode.Text, itemname.Text, psize.Text, qty.Value);
            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
            //DatabaseConnection dc = new DatabaseConnection();
            //MySqlConnection conndel = dc.getConnection();



            //DialogResult confirm = MessageBox.Show("Do you want to Delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (confirm == DialogResult.Yes)
            //{
            //    try
            //    {
            //        query = "delete from drivers where DriverID='" + idIn.Text + "';";
            //        MySqlCommand cmd = new MySqlCommand(query, conndel);
            //        MySqlDataReader reader;
            //        conndel.Open();
            //        reader = cmd.ExecuteReader();
            //        conndel.Close();


            //        Filldgv_delete();
            //        MessageBox.Show("Row Deleted");  //query will be executed and data deleted
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //        //conn.Close();
            //    }

            //}
        }

        private void Add_Driver_UI_Load(object sender, EventArgs e)
        {
            Filldgv_delete();
        }

        private void dgv_delete_MouseClick(object sender, DataGridViewCellEventArgs e)
        {
          //idIn.Text = dgv_delete.CurrentRow.Cells[0].Value.ToString();
          //  nameIn.Text = dgv_delete.CurrentRow.Cells[1].Value.ToString();
          //  licNo.Text = dgv_delete.CurrentRow.Cells[2].Value.ToString();
          // addressIn.Text = dgv_delete.CurrentRow.Cells[3].Value.ToString();
          //  numbIn.Text = dgv_delete.CurrentRow.Cells[4].Value.ToString();
          //  plateIn.Text = dgv_delete.CurrentRow.Cells[5].Value.ToString();

        }
        private int rowIndex;
        private void dgv_delete_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgv_delete.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dgv_delete.CurrentCell = this.dgv_delete.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.dgv_delete, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            if (!this.dgv_delete.Rows[this.rowIndex].IsNewRow){
                this.dgv_delete.Rows.RemoveAt (this.rowIndex);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            DatabaseConnection dc = new DatabaseConnection();
            MySqlConnection connupd = dc.getConnection();

            try
            {
                connupd.Open();

               

                if ((idIn.Text == "") || (licNo.Text == "") || (nameIn.Text == "") || (addressIn.Text == "") || (numbIn.Text == "") || (plateIn.Text == ""))
                {
                    MessageBox.Show("Field(s) cannnot be blank");

                }

                else if (numbIn.Text.Length > 10)

                {
                    MessageBox.Show("Enter only 10 numbers");

                }

                else if (numbIn.Text.Length < 10)

                {
                    MessageBox.Show("Enter atleast 10 numbers");

                }

                else if (!numbIn.Text.All(c => Char.IsNumber(c)))
                {
                    MessageBox.Show("Enter Numeric values only");
                }

                else if (!nameIn.Text.All(c => Char.IsLetter(c)))
                {
                    MessageBox.Show("Enter letters only");
                }

                else
                {
                    //string upd = "UPDATE drivers SET Name = " + nameIn.Text + "', License_Number ='" + licNo.Text + "', Address ='" + addressIn.Text + "', Contact_Number = " + Convert.ToInt32(numbIn.Text) + "', Assigned_Vehicle = ' " + plateIn.Text + "WHERE `drivers`.`DriverID = `" + idIn.Text;
                    MySqlCommand com = new MySqlCommand("UPDATE  drivers SET Name=@Name,License_Number=@License_Number,Address=@Address,Contact_Number=@Contact_Number, Assigned_Vehicle=@Assigned_Vehicle WHERE DriverID='" + idIn.Text + "'", connupd);

                    com.Parameters.Add("@Name", MySqlDbType.VarChar).Value = nameIn.Text;
                    com.Parameters.Add("@License_Number", MySqlDbType.VarChar).Value = licNo.Text;
                    com.Parameters.Add("@Address", MySqlDbType.VarChar).Value = addressIn.Text;
                    com.Parameters.Add("@Contact_Number", MySqlDbType.Int64).Value = Convert.ToInt64(numbIn.Text);
                    com.Parameters.Add("@Assigned_Vehicle", MySqlDbType.VarChar).Value = plateIn.Text;


                    //MySqlCommand cmd = new MySqlCommand(upd, connupd);


                    com.ExecuteNonQuery();


                    idIn.Text = "";
                    nameIn.Text = "";
                    licNo.Text = "";
                    addressIn.Text = "";
                    numbIn.Text = "";
                    plateIn.Text = "";
                    MessageBox.Show("Record Updated successfully");


                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(""+ ex ,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);


            }

            finally {

                connupd.Close();
            }



        }

        private void dgv_delete_Click(object sender, EventArgs e)
        {
            itemcodedelete = dgv_delete.CurrentRow.Cells["DriverID"].Value.ToString();
            string itemnamedelete = dgv_delete.CurrentRow.Cells["Name"].Value.ToString();
            idIn.Text = dgv_delete.CurrentRow.Cells[0].Value.ToString();
            nameIn.Text = dgv_delete.CurrentRow.Cells[1].Value.ToString();
            licNo.Text = dgv_delete.CurrentRow.Cells[2].Value.ToString();
            addressIn.Text = dgv_delete.CurrentRow.Cells[3].Value.ToString();
            numbIn.Text = dgv_delete.CurrentRow.Cells[4].Value.ToString();
            plateIn.Text = dgv_delete.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
