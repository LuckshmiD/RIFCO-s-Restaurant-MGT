using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Cashier
{

    class Payment
    {
        

        public bool card(float price)
        {
            Credit_Card_Validation card = new Credit_Card_Validation(price);
            card.ShowDialog();
            return card.status;
        }



        public bool cash(float price)
        {
            Cash_Validation cash = new Cash_Validation(price);
            cash.ShowDialog();
            return cash.status;
        }


        public void printReceipt(string receipt, string name)
        {
            try
            {
                Document doc = new Document();
                string s = "E:/"+name+".pdf";
                PdfWriter.GetInstance(doc, new FileStream(s, FileMode.Create));
                doc.Open();
                Paragraph p = new Paragraph(receipt);
                doc.Add(p);
                doc.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void insertRecord(int custID,int orderID, string dateTime, float amount)
        {
            databaseConnector db = new databaseConnector();
            db.executeStatement("INSERT INTO `payment` ( `customerID`, `orderID`, `dateTime`, `amount`) VALUES("+custID+", "+orderID+", '"+dateTime+"', "+amount+")");
            db.closeConnection();
        }

    }
}
