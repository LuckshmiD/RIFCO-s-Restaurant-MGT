using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resturant.Properties;
using System.Runtime.InteropServices;

namespace Cashier
{
    public partial class Cash_Validation : Form
    {

        private float price;
        public bool status;

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Cash_Validation(float Price)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


            price = Price;
            priceLabel.Text = "Amount : " + price;
            status = false;

            one.BackgroundImage = Resources.number_one_in_a_circle;
            one.BackgroundImageLayout = ImageLayout.Zoom;

            two.BackgroundImage = Resources.number_two_in_a_circle;
            two.BackgroundImageLayout = ImageLayout.Zoom;

            three.BackgroundImage = Resources.number_three_in_a_circle;
            three.BackgroundImageLayout = ImageLayout.Zoom;

            four.BackgroundImage = Resources.number_four_in_circular_button;
            four.BackgroundImageLayout = ImageLayout.Zoom;

            five.BackgroundImage = Resources.number_five_in_circular_button__1_;
            five.BackgroundImageLayout = ImageLayout.Zoom;

            six.BackgroundImage = Resources.number_six_in_a_circle;
            six.BackgroundImageLayout = ImageLayout.Zoom;

            seven.BackgroundImage = Resources.number_seven_in_a_circle;
            seven.BackgroundImageLayout = ImageLayout.Zoom;

            eight.BackgroundImage = Resources.number_eight_in_a_circle;
            eight.BackgroundImageLayout = ImageLayout.Zoom;

            nine.BackgroundImage = Resources.number_nine_in_a_circle;
            nine.BackgroundImageLayout = ImageLayout.Zoom;

            zero.BackgroundImage = Resources.number_zero_in_a_circle;
            zero.BackgroundImageLayout = ImageLayout.Zoom;

            dot.BackgroundImage = Resources.record_circular_button;
            dot.BackgroundImageLayout = ImageLayout.Zoom;

            backspace.BackgroundImage = Resources.left_arrow_thin_symbol_in_circular_button;
            backspace.BackgroundImageLayout = ImageLayout.Zoom;

            pay.BackgroundImage = Resources.success__1_;
            pay.BackgroundImageLayout = ImageLayout.Zoom;

            Cancel.BackgroundImage = Resources.error__1_;
            Cancel.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void one_Click(object sender, EventArgs e)
        {
            amount.Text = amount.Text + "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            amount.Text = amount.Text + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            amount.Text = amount.Text + "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            amount.Text = amount.Text + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            amount.Text = amount.Text + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            amount.Text = amount.Text + "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            amount.Text = amount.Text + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            amount.Text = amount.Text + "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            amount.Text = amount.Text + "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            amount.Text = amount.Text + "0";
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            try
            {
                String s = amount.Text;
                int lastIndex = s.Length - 1;

                amount.Text = s.Remove(lastIndex);
            }
            catch (ArgumentOutOfRangeException )
            {}
        }

        private void pay_Click(object sender, EventArgs e)
        {
            try
            {
                float cash = float.Parse(amount.Text);

                if (cash < price)
                {
                    MessageBox.Show("The amount you entered is not enough to complete the payment!!!");
                }
                else if (cash > price)
                {
                    MessageBox.Show("Payment Successful!!!\nYour balance is Rs." + (cash - price));
                    status = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Payment Successful!!!");
                    status = true;
                    this.Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter A Valid Amount!!!");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            status = false;
            this.Close();
        }

        private void dot_Click(object sender, EventArgs e)
        {
            String s = amount.Text;
            if ((s.IndexOf('.') < 0)&&(s.Length == 0))
            {
                amount.Text = "0.";
            }
            else if (s.IndexOf('.') >= 0)
            {

            }
            else
            {
                amount.Text = amount.Text + '.';
            }
        }

        private void one_MouseDown(object sender, MouseEventArgs e)
        {
            one.BackgroundImage = Resources.one_dark;
            one.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void two_MouseDown(object sender, MouseEventArgs e)
        {
            two.BackgroundImage = Resources.two_dark;
            two.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void three_MouseDown(object sender, MouseEventArgs e)
        {
            three.BackgroundImage = Resources.three_dark;
            three.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void four_MouseDown(object sender, MouseEventArgs e)
        {
            four.BackgroundImage = Resources.four_dark;
            four.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void five_MouseDown(object sender, MouseEventArgs e)
        {
            five.BackgroundImage = Resources.five_dark;
            five.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void six_MouseDown(object sender, MouseEventArgs e)
        {
            six.BackgroundImage = Resources.six_dark;
            six.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void seven_MouseDown(object sender, MouseEventArgs e)
        {
            seven.BackgroundImage = Resources.seven_dark;
            seven.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void eight_MouseDown(object sender, MouseEventArgs e)
        {
            eight.BackgroundImage = Resources.eight_dark;
            eight.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void nine_MouseDown(object sender, MouseEventArgs e)
        {
            nine.BackgroundImage = Resources.nine_dark;
            nine.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void zero_MouseDown(object sender, MouseEventArgs e)
        {
            zero.BackgroundImage = Resources.zero_dark;
            zero.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void dot_MouseDown(object sender, MouseEventArgs e)
        {
            dot.BackgroundImage = Resources.dot_dark;
            dot.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void backspace_MouseDown(object sender, MouseEventArgs e)
        {
            backspace.BackgroundImage = Resources.backspace_dark;
            backspace.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pay_MouseDown(object sender, MouseEventArgs e)
        {
            pay.BackgroundImage = Resources.success;
            pay.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Cancel_MouseDown(object sender, MouseEventArgs e)
        {
            Cancel.BackgroundImage = Resources.error;
            Cancel.BackgroundImageLayout = ImageLayout.Zoom;
        }



        private void one_MouseUp(object sender, MouseEventArgs e)
        {
            one.BackgroundImage = Resources.number_one_in_a_circle;
            one.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void two_MouseUp(object sender, MouseEventArgs e)
        {
            two.BackgroundImage = Resources.number_two_in_a_circle;
            two.BackgroundImageLayout = ImageLayout.Zoom;     
        }

        private void three_MouseUp(object sender, MouseEventArgs e)
        {
            three.BackgroundImage = Resources.number_three_in_a_circle;
            three.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void four_MouseUp(object sender, MouseEventArgs e)
        {
            four.BackgroundImage = Resources.number_four_in_circular_button;
            four.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void five_MouseUp(object sender, MouseEventArgs e)
        {
            five.BackgroundImage = Resources.number_five_in_circular_button__1_;
            five.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void six_MouseUp(object sender, MouseEventArgs e)
        {
            six.BackgroundImage = Resources.number_six_in_a_circle;
            six.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void seven_MouseUp(object sender, MouseEventArgs e)
        {
            seven.BackgroundImage = Resources.number_seven_in_a_circle;
            seven.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void eight_MouseUp(object sender, MouseEventArgs e)
        {
            eight.BackgroundImage = Resources.number_eight_in_a_circle;
            eight.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void nine_MouseUp(object sender, MouseEventArgs e)
        {
            nine.BackgroundImage = Resources.number_nine_in_a_circle;
            nine.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void zero_MouseUp(object sender, MouseEventArgs e)
        {
            zero.BackgroundImage = Resources.number_zero_in_a_circle;
            zero.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void dot_MouseUp(object sender, MouseEventArgs e)
        {
            dot.BackgroundImage = Resources.record_circular_button;
            dot.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void backspace_MouseUp(object sender, MouseEventArgs e)
        {
            backspace.BackgroundImage = Resources.left_arrow_thin_symbol_in_circular_button;
            backspace.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pay_MouseUp(object sender, MouseEventArgs e)
        {
            pay.BackgroundImage = Resources.success__1_;
            pay.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Cancel_MouseUp(object sender, MouseEventArgs e)
        {
            Cancel.BackgroundImage = Resources.error__1_;
            Cancel.BackgroundImageLayout = ImageLayout.Zoom;
        }



        private void one_MouseHover(object sender, EventArgs e)
        {}

        private void three_MouseHover(object sender, EventArgs e)
        {}

        private void two_MouseHover(object sender, EventArgs e)
        {}

        private void four_MouseHover(object sender, EventArgs e)
        {}

        private void five_MouseHover(object sender, EventArgs e)
        {}

        private void six_MouseHover(object sender, EventArgs e)
        {}

        private void seven_MouseHover(object sender, EventArgs e)
        {}

        private void eight_MouseHover(object sender, EventArgs e)
        {}

        private void nine_MouseHover(object sender, EventArgs e)
        {}

        private void zero_MouseHover(object sender, EventArgs e)
        {}

        private void dot_MouseHover(object sender, EventArgs e)
        {}

        private void backspace_MouseHover(object sender, EventArgs e)
        {}

        private void pay_MouseHover(object sender, EventArgs e)
        {}

        private void Cancel_MouseHover(object sender, EventArgs e)
        {}




        private void one_MouseLeave(object sender, EventArgs e)
        {
            one.BackgroundImage = Resources.number_one_in_a_circle;
            one.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void two_MouseLeave(object sender, EventArgs e)
        {
            two.BackgroundImage = Resources.number_two_in_a_circle;
            two.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void three_MouseLeave(object sender, EventArgs e)
        {
            three.BackgroundImage = Resources.number_three_in_a_circle;
            three.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void four_MouseLeave(object sender, EventArgs e)
        {
            four.BackgroundImage = Resources.number_four_in_circular_button;
            four.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void five_MouseLeave(object sender, EventArgs e)
        {
            five.BackgroundImage = Resources.number_five_in_circular_button__1_;
            five.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void six_MouseLeave(object sender, EventArgs e)
        {
            six.BackgroundImage = Resources.number_six_in_a_circle;
            six.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void seven_MouseLeave(object sender, EventArgs e)
        {
            seven.BackgroundImage = Resources.number_seven_in_a_circle;
            seven.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void eight_MouseLeave(object sender, EventArgs e)
        {
            eight.BackgroundImage = Resources.number_eight_in_a_circle;
            eight.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void nine_MouseLeave(object sender, EventArgs e)
        {
            nine.BackgroundImage = Resources.number_nine_in_a_circle;
            nine.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void zero_MouseLeave(object sender, EventArgs e)
        {
            zero.BackgroundImage = Resources.number_zero_in_a_circle;
            zero.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void dot_MouseLeave(object sender, EventArgs e)
        {
            dot.BackgroundImage = Resources.record_circular_button;
            dot.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void backspace_MouseLeave(object sender, EventArgs e)
        {
            backspace.BackgroundImage = Resources.left_arrow_thin_symbol_in_circular_button;
            backspace.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pay_MouseLeave(object sender, EventArgs e)
        {
            pay.BackgroundImage = Resources.success__1_;
            pay.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Cancel_MouseLeave(object sender, EventArgs e)
        {
            Cancel.BackgroundImage = Resources.error__1_;
            Cancel.BackgroundImageLayout = ImageLayout.Zoom;
        }






        // Unwanted code



        private void Cancel_MouseClick(object sender, MouseEventArgs e)
        {}

        private void one_MouseMove(object sender, MouseEventArgs e)
        {
            one.BackgroundImage = Resources.one_dark;
            one.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void two_MouseMove(object sender, MouseEventArgs e)
        {
            two.BackgroundImage = Resources.two_dark;
            two.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void three_MouseMove(object sender, MouseEventArgs e)
        {
            three.BackgroundImage = Resources.three_dark;
            three.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void four_MouseMove(object sender, MouseEventArgs e)
        {
            four.BackgroundImage = Resources.four_dark;
            four.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void five_MouseMove(object sender, MouseEventArgs e)
        {
            five.BackgroundImage = Resources.five_dark;
            five.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void six_MouseMove(object sender, MouseEventArgs e)
        {
            six.BackgroundImage = Resources.six_dark;
            six.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void seven_MouseMove(object sender, MouseEventArgs e)
        {
            seven.BackgroundImage = Resources.seven_dark;
            seven.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void eight_MouseMove(object sender, MouseEventArgs e)
        {
            eight.BackgroundImage = Resources.eight_dark;
            eight.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void nine_MouseMove(object sender, MouseEventArgs e)
        {
            nine.BackgroundImage = Resources.nine_dark;
            nine.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void dot_MouseMove(object sender, MouseEventArgs e)
        {
            dot.BackgroundImage = Resources.dot_dark;
            dot.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void zero_MouseMove(object sender, MouseEventArgs e)
        {
            zero.BackgroundImage = Resources.zero_dark;
            zero.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void backspace_MouseMove(object sender, MouseEventArgs e)
        {
            backspace.BackgroundImage = Resources.backspace_dark;
            backspace.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pay_MouseMove(object sender, MouseEventArgs e)
        {
            pay.BackgroundImage = Resources.success;
            pay.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Cancel_MouseMove(object sender, MouseEventArgs e)
        {
            Cancel.BackgroundImage = Resources.error;
            Cancel.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
