using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    static class Program
    {
        public static List<clsCuentaBancaria> cuentas = new List<clsCuentaBancaria>();
        public static List<clsPropietario> Propietarios = new List<clsPropietario>();
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Aplicacion());
        }
    }
}
