using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneBookApp.View;
namespace PhoneBookApp.Controller
{
    using PhoneBookApp.Model;
    static class MyApp
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PhoneBookForm(new PhoneBookManager()));
            //Application.Run(new TestForm());

        }
    }
}
