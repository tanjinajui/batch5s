using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AarryFormPractice
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
            //Application.Run(new ArrayvalueDeclartForm());
            //Application.Run(new UserInputForm());
            //Application.Run(new ListForm());
            //Application.Run(new CustomerForm());
            //Application.Run(new CustomerAssignmentForm());
            //Application.Run(new TicketPurchas());
            Application.Run(new BookShopcs());
            //Application.Run(new BookShop());
        }
    }
}
