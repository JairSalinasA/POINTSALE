using Presentation.Views.Configuration._01_ConfigEmpresa;
using Presentation.Views.Configuration._02_ConfigDB;
using Presentation.Views.Configuration._03_ConfigBD;
using Presentation.Views.Configuration._04_configTicket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
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
            //Application.Run(new Desktop());
            //Application.Run(new configEmpresa());
            Application.Run(new configTicket());

        }
    }
}
