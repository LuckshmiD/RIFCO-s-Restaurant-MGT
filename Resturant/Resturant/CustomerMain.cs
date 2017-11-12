using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Color MenuHighLight { get; private set; }

    

    private void rectangleShape2_MouseHover(object sender, EventArgs e)
    {
        registration.BackColor = MenuHighLight;

    }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

           
    }

        private void rectangleShape5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Notification n1 = new Notification();
            n1.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bookings t1 = new Bookings();
            t1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registratio r1 = new Registratio();
            r1.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Notification n1 = new Notification();
            n1.ShowDialog();
        }

        private void registration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registratio r1 = new Registratio();
            r1.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Notification n2 = new Notification();
            n2.ShowDialog();

        }

        private void rectangleShape3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bookings t2 = new Bookings();
            t2.ShowDialog();

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
          this.Hide();
            FeedbkAdmin r2= new FeedbkAdmin();
            r2.ShowDialog();
        

    }

        private void rectangleShape4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FeedbkAdmin r2 = new FeedbkAdmin();
            r2.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rating m1 = new Rating();
            m1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegUser ro = new RegUser();
            ro.ShowDialog();
        }

        private void notification_Click(object sender, EventArgs e)
        {
            this.Hide();
            Notification n2 = new Notification();
            n2.ShowDialog();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nonuser non = new Nonuser();
            non.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            this.Hide();
            Registratio r1 = new Registratio();
            r1.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bookings t2 = new Bookings();
            t2.ShowDialog();

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FeedbkAdmin r2 = new FeedbkAdmin();
            r2.ShowDialog();


        }

        private void rectangleShape6_Click(object sender, EventArgs e)
        {
            this.Hide();
            chartinterface c1 = new chartinterface();
            c1.ShowDialog();
        }
    }
    }
    
