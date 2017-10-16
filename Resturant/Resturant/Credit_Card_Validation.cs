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
    public partial class Credit_Card_Validation : Form
    {
        public bool status;
        TextBox[] temp = new TextBox[8];
        bool[] tbindex = new bool[8];

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

        public Credit_Card_Validation(float price)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            priceLabel.Text = "Amount : Rs." + price;


            temp[0] = cardNumber1;
            temp[1] = cardNumber2;
            temp[2] = cardNumber3;
            temp[3] = cardNumber4;
            temp[4] = dateTB;
            temp[5] = monthTB;
            temp[6] = yearTB;
            temp[7] = ccv;

            tbindex[0] = true;
            for(int i = 1; i < 8; i++)
            {
                tbindex[i] = false;
            }
        }

        private void Credit_Card_Validation_Load(object sender, EventArgs e)
        {

        }

        private void pay_Click(object sender, EventArgs e)
        {
            bool cardNumberLength = true;
            bool cardNumberValue = true;

            status = false;
       
            // start of credit card number validation

            if(cardNumber1.Text.Length == 4)
            {
                try
                {
                    int first_number_set = int.Parse(cardNumber1.Text);
                }
                catch (FormatException)
                {
                    cardNumberValue = false;
                }
            }
            else
            {
                cardNumberLength = false;
            }

            if (cardNumber2.Text.Length == 4)
            {
                try
                {
                    int second_number_set = int.Parse(cardNumber2.Text);
                }
                catch (FormatException)
                {
                    cardNumberValue = false;
                }
            }
            else
            {
                cardNumberLength = false;
            }

            if (cardNumber3.Text.Length == 4)
            {
                try
                {
                    int third_number_set = int.Parse(cardNumber3.Text);
                }
                catch (FormatException)
                {
                    cardNumberValue = false;
                }
            }
            else
            {
                cardNumberLength = false;
            }

            if (cardNumber4.Text.Length == 4)
            {
                try
                {
                    int fourth_number_set = int.Parse(cardNumber4.Text);
                }
                catch (FormatException)
                {
                    cardNumberValue = false;
                }
            }
            else
            {
                cardNumberLength = false;
            }

            // end of credit card number validation

            // start of expiry date validation

            bool dateValue = true;
            bool monthValue = true;
            bool yearValue = true;
            bool notExpired = true;
            int date;
            int month;
            int year;

            // expiry date integer and size validation

            try
            {
                date = int.Parse(dateTB.Text);
                if((date>0) && (date < 31)) { }
                else
                {
                    dateValue = false;
                }
            }
            catch (FormatException)
            {
                dateValue = false;
            }

            try
            {
                month = int.Parse(monthTB.Text);
                if((month>0) && (month < 13)) { }
                else
                {
                    monthValue = false;
                }
            }
            catch (FormatException)
            {
                monthValue = false;
            }

            if(yearTB.Text.Length == 4)
            {
                try
                {
                    year = int.Parse(yearTB.Text);
                }
                catch (FormatException)
                {
                    yearValue = false;
                }
            }
            else
            {
                yearValue = false;
            }

            // assigning again to minimize the error of unassigned local variable
            month = 0;
            date = 0;
            year = 0;
            try
            {
                month = int.Parse(monthTB.Text);
                date = int.Parse(dateTB.Text);
                year = int.Parse(yearTB.Text);
            }
            catch (Exception)
            {

            }

            // Expiry date, month and date validation
            // January
            if ((month == 1) && (date < 32)) { }

            // February
            else if ((month == 2) && (date < 29) && ((year % 4) == 0)) { }
            else if ((month == 2) && (date < 30) && ((year % 4) != 0)) { }

            // March
            else if ((month == 3) && (date < 32)) { }

            // April
            else if ((month == 4) && (date < 31)) { }

            // May
            else if ((month == 5) && (date < 32)) { }

            // June
            else if ((month == 6) && (date < 31)) { }

            // July
            else if ((month == 7) && (date < 32)) { }

            // August
            else if ((month == 8) && (date < 32)) { }

            // September
            else if ((month == 9) && (date < 31)) { }

            // October
            else if ((month == 10) && (date < 32)) { }

            // November
            else if ((month == 11) && (date < 31)) { }

            // December
            else if ((month == 12) && (date < 32)) { }
            else
            {
                dateValue = false;
            }

            // checking with present date

            int currentDate = int.Parse(DateTime.Now.ToString("dd"));
            int currentMonth = int.Parse( DateTime.Now.ToString("MM"));
            int currentYear = int.Parse( DateTime.Now.ToString("yyyy"));

            DateTime current = new DateTime(currentYear, currentMonth, currentDate);
            DateTime expiry;

            try
            {
                expiry = new DateTime(year, month, date);
                if (DateTime.Compare(expiry, current) <= 0)
                {
                    notExpired = false;
                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }
            // End of expiry date validation

            // start of ccv validation 

            bool ccvValue = true;
            bool ccvLength = true;
            int ccvNumber;

            if (ccv.Text.Length == 3)
            {
                try
                {
                    ccvNumber = int.Parse(ccv.Text);
                }
                catch (FormatException)
                {
                    ccvValue = false;
                }
            }
            else
            {
                ccvLength = false;
            }

            // End of ccv validation
            string cardNumberLengthError;
            string cardNumberValueError;
            string dateValueError;
            string notExpiredError;
            string ccvValueError;
            string ccvLengthError;

            if (cardNumberLength)
            {
                cardNumberLengthError = "";
            }
            else
            {
                cardNumberLengthError = "Invalid Card Number Length !!!\n";
            }

            if (cardNumberValue)
            {
                 cardNumberValueError = "";
            }
            else
            {
                 cardNumberValueError = "Invalid Card Number Value !!!\n";
            }

            if (dateValue && monthValue && yearValue)
            {
                 dateValueError = "";
            }
            else
            {
                 dateValueError = "Invalid Expiry Date !!!\n";
            }

            if (notExpired)
            {
                 notExpiredError = "";
            }
            else
            {
                 notExpiredError = "Credit Card is Expired !!!\n";
            }

            if (ccvValue)
            {
                 ccvValueError = "";
            }
            else
            {
                 ccvValueError = "Invalid CCV Value !!!\n";
            }
            if (ccvLength)
            {
                 ccvLengthError = "";
            }
            else
            {
                 ccvLengthError = "Invalid CCV Length !!!\n";
            }

            if(cardNumberLength && cardNumberValue && dateValue && monthValue && yearValue && notExpired && ccvValue && ccvLength)
            {
                MessageBox.Show("Transaction Successful !!!");
                status = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Errors Detected!\n\n" + cardNumberLengthError + cardNumberValueError + dateValueError + notExpiredError + ccvValueError + ccvLengthError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pay_MouseHover(object sender, EventArgs e)
        {
            pay.BackgroundImage = Resources.success;
            pay.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pay_MouseLeave(object sender, EventArgs e)
        {
            pay.BackgroundImage = Resources.success__1_;
            pay.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pay_MouseDown(object sender, MouseEventArgs e)
        {
            pay.BackgroundImage = Resources.success;
            pay.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pay_MouseUp(object sender, MouseEventArgs e)
        {
            pay.BackgroundImage = Resources.success__1_;
            pay.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Cancel_MouseHover(object sender, EventArgs e)
        {
            Cancel.BackgroundImage = Resources.error;
            Cancel.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Cancel_MouseLeave(object sender, EventArgs e)
        {
            Cancel.BackgroundImage = Resources.error__1_;
            Cancel.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Cancel_MouseDown(object sender, MouseEventArgs e)
        {
            Cancel.BackgroundImage = Resources.error;
            Cancel.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Cancel_MouseUp(object sender, MouseEventArgs e)
        {
            Cancel.BackgroundImage = Resources.error__1_;
            Cancel.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void backspace_Click(object sender, EventArgs e)
        {
           if((temp[7].Text.Length > 0) && (tbindex[7]))
            {
                try
                {
                    String s = temp[7].Text;
                    int lastIndex = s.Length - 1;

                    temp[7].Text = s.Remove(lastIndex);
                }
                catch (ArgumentOutOfRangeException)
                { }
            }
           else if((temp[6].Text.Length > 0)&&(tbindex[6]))
            {
                try
                {
                    String s = temp[6].Text;
                    int lastIndex = s.Length - 1;

                    temp[6].Text = s.Remove(lastIndex);
                }
                catch (ArgumentOutOfRangeException)
                { }
            }
            else if ((temp[5].Text.Length > 0)&&(tbindex[5]))
            {
                try
                {
                    String s = temp[5].Text;
                    int lastIndex = s.Length - 1;

                    temp[5].Text = s.Remove(lastIndex);
                }
                catch (ArgumentOutOfRangeException)
                { }
            }
            else if ((temp[4].Text.Length > 0)&&(tbindex[4]))
            {
                try
                {
                    String s = temp[4].Text;
                    int lastIndex = s.Length - 1;

                    temp[4].Text = s.Remove(lastIndex);
                }
                catch (ArgumentOutOfRangeException)
                { }
            }
            else if ((temp[3].Text.Length > 0)&&(tbindex[3]))
            {
                try
                {
                    String s = temp[3].Text;
                    int lastIndex = s.Length - 1;

                    temp[3].Text = s.Remove(lastIndex);
                }
                catch (ArgumentOutOfRangeException)
                { }
            }
            else if ((temp[2].Text.Length > 0)&&(tbindex[2]))
            {
                try
                {
                    String s = temp[2].Text;
                    int lastIndex = s.Length - 1;

                    temp[2].Text = s.Remove(lastIndex);
                }
                catch (ArgumentOutOfRangeException)
                { }
            }
            else if ((temp[1].Text.Length > 0)&&(tbindex[1]))
            {
                try
                {
                    String s = temp[1].Text;
                    int lastIndex = s.Length - 1;

                    temp[1].Text = s.Remove(lastIndex);
                }
                catch (ArgumentOutOfRangeException)
                { }
            }
            else if ((temp[0].Text.Length > 0)&&(tbindex[0]))
            {
                try
                {
                    String s = temp[0].Text;
                    int lastIndex = s.Length - 1;

                    temp[0].Text = s.Remove(lastIndex);
                }
                catch (ArgumentOutOfRangeException)
                { }
            }


        }

        private void one_Click(object sender, EventArgs e)
        {
            if((temp[0].Text.Length < 4)&&(tbindex[0]))
            {
                temp[0].Text = temp[0].Text + "1";
            }
            if((temp[1].Text.Length < 4) && (tbindex[1]))
            {
                temp[1].Text = temp[1].Text + "1";
            }
            if ((temp[2].Text.Length < 4) && (tbindex[2]))
            {
                temp[2].Text = temp[2].Text + "1";
            }
            if ((temp[3].Text.Length < 4) && (tbindex[3]))
            {
                temp[3].Text = temp[3].Text + "1";
            }
            if ((temp[4].Text.Length < 2) && (tbindex[4]))
            {
                temp[4].Text = temp[4].Text + "1";
            }
            if ((temp[5].Text.Length < 2) && (tbindex[5]))
            {
                temp[5].Text = temp[5].Text + "1";
            }
            if ((temp[6].Text.Length < 4) && (tbindex[6]))
            {
                temp[6].Text = temp[6].Text + "1";
            }
            if ((temp[7].Text.Length < 3) && (tbindex[7]))
            {
                temp[7].Text = temp[7].Text + "1";
            }
            
        }

        private void two_Click(object sender, EventArgs e)
        {
            if ((temp[0].Text.Length < 4) && (tbindex[0]))
            {
                temp[0].Text = temp[0].Text + "2";
            }
            if ((temp[1].Text.Length < 4) && (tbindex[1]))
            {
                temp[1].Text = temp[1].Text + "2";
            }
            if ((temp[2].Text.Length < 4) && (tbindex[2]))
            {
                temp[2].Text = temp[2].Text + "2";
            }
            if ((temp[3].Text.Length < 4) && (tbindex[3]))
            {
                temp[3].Text = temp[3].Text + "2";
            }
            if ((temp[4].Text.Length < 2) && (tbindex[4]))
            {
                temp[4].Text = temp[4].Text + "2";
            }
            if ((temp[5].Text.Length < 2) && (tbindex[5]))
            {
                temp[5].Text = temp[5].Text + "2";
            }
            if ((temp[6].Text.Length < 4) && (tbindex[6]))
            {
                temp[6].Text = temp[6].Text + "2";
            }
            if ((temp[7].Text.Length < 3) && (tbindex[7]))
            {
                temp[7].Text = temp[7].Text + "2";
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if ((temp[0].Text.Length < 4) && (tbindex[0]))
            {
                temp[0].Text = temp[0].Text + "3";
            }
            if ((temp[1].Text.Length < 4) && (tbindex[1]))
            {
                temp[1].Text = temp[1].Text + "3";
            }
            if ((temp[2].Text.Length < 4) && (tbindex[2]))
            {
                temp[2].Text = temp[2].Text + "3";
            }
            if ((temp[3].Text.Length < 4) && (tbindex[3]))
            {
                temp[3].Text = temp[3].Text + "3";
            }
            if ((temp[4].Text.Length < 2) && (tbindex[4]))
            {
                temp[4].Text = temp[4].Text + "3";
            }
            if ((temp[5].Text.Length < 2) && (tbindex[5]))
            {
                temp[5].Text = temp[5].Text + "3";
            }
            if ((temp[6].Text.Length < 4) && (tbindex[6]))
            {
                temp[6].Text = temp[6].Text + "3";
            }
            if ((temp[7].Text.Length < 3) && (tbindex[7]))
            {
                temp[7].Text = temp[7].Text + "3";
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if ((temp[0].Text.Length < 4) && (tbindex[0]))
            {
                temp[0].Text = temp[0].Text + "4";
            }
            if ((temp[1].Text.Length < 4) && (tbindex[1]))
            {
                temp[1].Text = temp[1].Text + "4";
            }
            if ((temp[2].Text.Length < 4) && (tbindex[2]))
            {
                temp[2].Text = temp[2].Text + "4";
            }
            if ((temp[3].Text.Length < 4) && (tbindex[3]))
            {
                temp[3].Text = temp[3].Text + "4";
            }
            if ((temp[4].Text.Length < 2) && (tbindex[4]))
            {
                temp[4].Text = temp[4].Text + "4";
            }
            if ((temp[5].Text.Length < 2) && (tbindex[5]))
            {
                temp[5].Text = temp[5].Text + "4";
            }
            if ((temp[6].Text.Length < 4) && (tbindex[6]))
            {
                temp[6].Text = temp[6].Text + "4";
            }
            if ((temp[7].Text.Length < 3) && (tbindex[7]))
            {
                temp[7].Text = temp[7].Text + "4";
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if ((temp[0].Text.Length < 4) && (tbindex[0]))
            {
                temp[0].Text = temp[0].Text + "5";
            }
            if ((temp[1].Text.Length < 4) && (tbindex[1]))
            {
                temp[1].Text = temp[1].Text + "5";
            }
            if ((temp[2].Text.Length < 4) && (tbindex[2]))
            {
                temp[2].Text = temp[2].Text + "5";
            }
            if ((temp[3].Text.Length < 4) && (tbindex[3]))
            {
                temp[3].Text = temp[3].Text + "5";
            }
            if ((temp[4].Text.Length < 2) && (tbindex[4]))
            {
                temp[4].Text = temp[4].Text + "5";
            }
            if ((temp[5].Text.Length < 2) && (tbindex[5]))
            {
                temp[5].Text = temp[5].Text + "5";
            }
            if ((temp[6].Text.Length < 4) && (tbindex[6]))
            {
                temp[6].Text = temp[6].Text + "5";
            }
            if ((temp[7].Text.Length < 3) && (tbindex[7]))
            {
                temp[7].Text = temp[7].Text + "5";
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if ((temp[0].Text.Length < 4) && (tbindex[0]))
            {
                temp[0].Text = temp[0].Text + "6";
            }
            if ((temp[1].Text.Length < 4) && (tbindex[1]))
            {
                temp[1].Text = temp[1].Text + "6";
            }
            if ((temp[2].Text.Length < 4) && (tbindex[2]))
            {
                temp[2].Text = temp[2].Text + "6";
            }
            if ((temp[3].Text.Length < 4) && (tbindex[3]))
            {
                temp[3].Text = temp[3].Text + "6";
            }
            if ((temp[4].Text.Length < 2) && (tbindex[4]))
            {
                temp[4].Text = temp[4].Text + "6";
            }
            if ((temp[5].Text.Length < 2) && (tbindex[5]))
            {
                temp[5].Text = temp[5].Text + "6";
            }
            if ((temp[6].Text.Length < 4) && (tbindex[6]))
            {
                temp[6].Text = temp[6].Text + "6";
            }
            if ((temp[7].Text.Length < 3) && (tbindex[7]))
            {
                temp[7].Text = temp[7].Text + "6";
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if ((temp[0].Text.Length < 4) && (tbindex[0]))
            {
                temp[0].Text = temp[0].Text + "7";
            }
            if ((temp[1].Text.Length < 4) && (tbindex[1]))
            {
                temp[1].Text = temp[1].Text + "7";
            }
            if ((temp[2].Text.Length < 4) && (tbindex[2]))
            {
                temp[2].Text = temp[2].Text + "7";
            }
            if ((temp[3].Text.Length < 4) && (tbindex[3]))
            {
                temp[3].Text = temp[3].Text + "7";
            }
            if ((temp[4].Text.Length < 2) && (tbindex[4]))
            {
                temp[4].Text = temp[4].Text + "7";
            }
            if ((temp[5].Text.Length < 2) && (tbindex[5]))
            {
                temp[5].Text = temp[5].Text + "7";
            }
            if ((temp[6].Text.Length < 4) && (tbindex[6]))
            {
                temp[6].Text = temp[6].Text + "7";
            }
            if ((temp[7].Text.Length < 3) && (tbindex[7]))
            {
                temp[7].Text = temp[7].Text + "7";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if ((temp[0].Text.Length < 4) && (tbindex[0]))
            {
                temp[0].Text = temp[0].Text + "8";
            }
            if ((temp[1].Text.Length < 4) && (tbindex[1]))
            {
                temp[1].Text = temp[1].Text + "8";
            }
            if ((temp[2].Text.Length < 4) && (tbindex[2]))
            {
                temp[2].Text = temp[2].Text + "8";
            }
            if ((temp[3].Text.Length < 4) && (tbindex[3]))
            {
                temp[3].Text = temp[3].Text + "8";
            }
            if ((temp[4].Text.Length < 2) && (tbindex[4]))
            {
                temp[4].Text = temp[4].Text + "8";
            }
            if ((temp[5].Text.Length < 2) && (tbindex[5]))
            {
                temp[5].Text = temp[5].Text + "8";
            }
            if ((temp[6].Text.Length < 4) && (tbindex[6]))
            {
                temp[6].Text = temp[6].Text + "8";
            }
            if ((temp[7].Text.Length < 3) && (tbindex[7]))
            {
                temp[7].Text = temp[7].Text + "8";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if ((temp[0].Text.Length < 4) && (tbindex[0]))
            {
                temp[0].Text = temp[0].Text + "9";
            }
            if ((temp[1].Text.Length < 4) && (tbindex[1]))
            {
                temp[1].Text = temp[1].Text + "9";
            }
            if ((temp[2].Text.Length < 4) && (tbindex[2]))
            {
                temp[2].Text = temp[2].Text + "9";
            }
            if ((temp[3].Text.Length < 4) && (tbindex[3]))
            {
                temp[3].Text = temp[3].Text + "9";
            }
            if ((temp[4].Text.Length < 2) && (tbindex[4]))
            {
                temp[4].Text = temp[4].Text + "9";
            }
            if ((temp[5].Text.Length < 2) && (tbindex[5]))
            {
                temp[5].Text = temp[5].Text + "9";
            }
            if ((temp[6].Text.Length < 4) && (tbindex[6]))
            {
                temp[6].Text = temp[6].Text + "9";
            }
            if ((temp[7].Text.Length < 3) && (tbindex[7]))
            {
                temp[7].Text = temp[7].Text + "9";
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if ((temp[0].Text.Length < 4) && (tbindex[0]))
            {
                temp[0].Text = temp[0].Text + "0";
            }
            if ((temp[1].Text.Length < 4) && (tbindex[1]))
            {
                temp[1].Text = temp[1].Text + "0";
            }
            if ((temp[2].Text.Length < 4) && (tbindex[2]))
            {
                temp[2].Text = temp[2].Text + "0";
            }
            if ((temp[3].Text.Length < 4) && (tbindex[3]))
            {
                temp[3].Text = temp[3].Text + "0";
            }
            if ((temp[4].Text.Length < 2) && (tbindex[4]))
            {
                temp[4].Text = temp[4].Text + "0";
            }
            if ((temp[5].Text.Length < 2) && (tbindex[5]))
            {
                temp[5].Text = temp[5].Text + "0";
            }
            if ((temp[6].Text.Length < 4) && (tbindex[6]))
            {
                temp[6].Text = temp[6].Text + "0";
            }
            if ((temp[7].Text.Length < 3) && (tbindex[7]))
            {
                temp[7].Text = temp[7].Text + "0";
            }
        }

        private void cardNumber1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 8; i++)
            {
                tbindex[i] = false;
            }

            tbindex[0] = true;
        }

        private void cardNumber2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                tbindex[i] = false;
            }

            tbindex[1] = true;
        }

        private void cardNumber3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                tbindex[i] = false;
            }

            tbindex[2] = true;
        }

        private void cardNumber4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                tbindex[i] = false;
            }

            tbindex[3] = true;
        }

        private void dateTB_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                tbindex[i] = false;
            }

            tbindex[4] = true;
        }

        private void monthTB_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                tbindex[i] = false;
            }

            tbindex[5] = true;
        }

        private void yearTB_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                tbindex[i] = false;
            }

            tbindex[6] = true;
        }

        private void ccv_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                tbindex[i] = false;
            }

            tbindex[7] = true;
        }
        //private void one_MouseDown(object sender, MouseEventArgs e)
        //{
        //    
        //}

        //private void two_MouseDown(object sender, MouseEventArgs e)
        //{
        //    
        //}

        //private void three_MouseDown(object sender, MouseEventArgs e)
        //{
        //    
        //}

        //private void four_MouseDown(object sender, MouseEventArgs e)
        //{
        //    
        //}

        //private void five_MouseDown(object sender, MouseEventArgs e)
        //{
        //    
        //}

        //private void six_MouseDown(object sender, MouseEventArgs e)
        //{
        //    
        //}

        //private void seven_MouseDown(object sender, MouseEventArgs e)
        //{
        //    
        //}

        //private void eight_MouseDown(object sender, MouseEventArgs e)
        //{
        //    
        //}

        //private void nine_MouseDown(object sender, MouseEventArgs e)
        //{
        //    
        //}

        //private void zero_MouseDown(object sender, MouseEventArgs e)
        //{
        //    
        //}

        //private void backspace_MouseDown(object sender, MouseEventArgs e)
        //{
        //    
        //}
        
        

        









        //unwanted code

        private void cardNumber2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cardNumber3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cardNumber4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void yearTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ccv_TextChanged(object sender, EventArgs e)
        {

        }






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

        private void backspace_MouseLeave(object sender, EventArgs e)
        {
            backspace.BackgroundImage = Resources.left_arrow_thin_symbol_in_circular_button;
            backspace.BackgroundImageLayout = ImageLayout.Zoom;
        }



        private void one_MouseHover(object sender, EventArgs e)
        {
            one.BackgroundImage = Resources.one_dark;
            one.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void two_MouseHover(object sender, EventArgs e)
        {
            two.BackgroundImage = Resources.two_dark;
            two.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void three_MouseHover(object sender, EventArgs e)
        {
            three.BackgroundImage = Resources.three_dark;
            three.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void four_MouseHover(object sender, EventArgs e)
        {
            four.BackgroundImage = Resources.four_dark;
            four.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void five_MouseHover(object sender, EventArgs e)
        {
            five.BackgroundImage = Resources.five_dark;
            five.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void six_MouseHover(object sender, EventArgs e)
        {
            six.BackgroundImage = Resources.six_dark;
            six.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void seven_MouseHover(object sender, EventArgs e)
        {
            seven.BackgroundImage = Resources.seven_dark;
            seven.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void eight_MouseHover(object sender, EventArgs e)
        {
            eight.BackgroundImage = Resources.eight_dark;
            eight.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void nine_MouseHover(object sender, EventArgs e)
        {
            nine.BackgroundImage = Resources.nine_dark;
            nine.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void zero_MouseHover(object sender, EventArgs e)
        {
            zero.BackgroundImage = Resources.zero_dark;
            zero.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void backspace_MouseHover(object sender, EventArgs e)
        {
            backspace.BackgroundImage = Resources.backspace_dark;
            backspace.BackgroundImageLayout = ImageLayout.Zoom;
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

        private void backspace_MouseUp(object sender, MouseEventArgs e)
        {
            backspace.BackgroundImage = Resources.left_arrow_thin_symbol_in_circular_button;
            backspace.BackgroundImageLayout = ImageLayout.Zoom;
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

        private void backspace_MouseDown(object sender, MouseEventArgs e)
        {
            backspace.BackgroundImage = Resources.backspace_dark;
            backspace.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
