using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
using GsmComm.GsmCommunication;
using GsmComm.PduConverter;
using GsmComm.Server;

namespace Cashier
{
    class Send_Message
    {
        private GsmCommMain comm = new GsmCommMain("COM9");

        private string from = "rifcoschickentikka@gmail.com";
        string subject = "Order Reciept";

        public void email(string to , string message)
        {
            try
            {
                MailMessage mail = new MailMessage(from, to, subject, message);

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential(from,"itpproject1234567");
                client.Send(mail);

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void sms(string message, string number)
        {
            try
            {
                
                comm.Open();

                SmsSubmitPdu pdu;
                byte dsc = (byte)DataCodingScheme.GeneralCoding.Alpha7BitDefault;
                pdu = new SmsSubmitPdu(message, number, dsc);

                comm.SendMessage(pdu);
               
                comm.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}

