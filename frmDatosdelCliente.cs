using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class frmDatosdelCliente : Form
    {
        public frmDatosdelCliente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Boolean encontrado = false;

            foreach (clsCuentaBancaria cuenta in Program.cuentas)
            {
                if (cuenta.Numero == txtNumero.Text)
                {
                    encontrado = true;
                    this.dgvPropietario.DataSource = Program.Propietarios;
                    this.dgvCuenta.DataSource = Program.cuentas;
                }
            }

            if (encontrado)
            {
                dgvPropietario.Enabled = true;
                dgvCuenta.Enabled = true;
            }
            else
            {
                MessageBox.Show("no se encontro cuenta con dicho numero", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
