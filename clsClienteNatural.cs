using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class clsPersona : clsPropietario
    {
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string DNI { get; set; }
        public string Sexo { get; set; }

        public override string Denominacion
        {
            get
            {
                return this.DNI;
            }
        }
    }
}
