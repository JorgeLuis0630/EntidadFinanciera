using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class clsEmpresa : clsPropietario
    {
        public string RazonSocial { get; set; }
        public string RUC { get; set; }


        public override string Denominacion
        {
            get
            {
                return this.RUC;
            }
        }
    }
}
