using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagement;
using Cashier;
using Customer_Management;
using HRManagement;
using EventCaterMgt;
using RCTRM;
using Customer_Management;

namespace Resturant
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Dashboard());
            //Application.Run(new BillReportViewer());
            Application.Run(new Starting_Page());
        }
    }
}
