using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiTechWindowsFormsApp.GUI;

namespace HiTechWindowsFormsApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogInForm());
            //Application.Run(new UserForm());
            // Application.Run(new MainMenuForm());
            //Application.Run(new BookForm());
            //Application.Run(new OrdersForm());
            // Application.Run(new EmployeeForm());
        }
    }
}
