using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSoft
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Estas 3 líneas son para que al cerrar el login no finalice el programa
            Login login = new Login();
            login.Show();
            Application.Run();
            // Application.Run(new Login());
        }
    }
}
