using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class clsCuentaBancaria
    {
        public clsPropietario Propietario { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }  // Ahorro o Corriente
        public string TipoMoneda { get; set; } //Soles o Dólares
        public double MontoApertura { get; set; }
        public double Saldo { get; set; }
        public bool Estado { get; set; }


        public string Codigo_cliente { get; set; }


        public List<clsMovimiento> Movimientos { get; set; }
    }
}
