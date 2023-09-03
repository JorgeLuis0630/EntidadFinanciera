using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public abstract class clsPropietario
    {
        public string Codigo_Cliente{ get; set; }
        public List<clsCuentaBancaria> Cuentas { get; }
        public abstract string Denominacion { get; }




        public clsPropietario()
        {
            this.Cuentas = new List<clsCuentaBancaria>();
        }
    }
}
