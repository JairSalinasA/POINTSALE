using Presentation.Views.Configuration._01_ConfigEmpresa;
using Presentation.Views.Configuration._02_ConfigDB;
using Presentation.Views.Configuration._03_ConfigBD;
using Presentation.Views.Configuration._04_configTicket;
using Presentation.Views.Login;
using Presentation.Views.Usuarios;
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
            //Application.Run(new Login());
            //Application.Run(new Desktop());
            //Application.Run(new configEmpresa());
            //Application.Run(new configImpresora());
            //Application.Run(new configBaseDatos());
            //Application.Run(new configTicket());
            //Application.Run(new configUser()); 
            //Application.Run(new CreateUser());
            Application.Run(new Usuarios());

        }
    }
}
