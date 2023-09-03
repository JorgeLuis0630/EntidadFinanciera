using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class clsMovimiento
    {
        public clsCuentaBancaria Cuenta { get; set; }
        public string Tipo { get; set; }  //Retiro o Deposito
        public double Fecha { get; set; }
        public double Monto { get; set; }
    }
}
