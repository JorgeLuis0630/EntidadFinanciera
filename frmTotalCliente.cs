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
    public partial class frmTotalCliente : Form
    {
        public frmTotalCliente()
        {
            InitializeComponent();
            this.dgvListado.AutoGenerateColumns = false;
        }

        private void listarCuentas(string codigo_cliente)
        {
            List<clsCuentaBancaria> cuentas = new List<clsCuentaBancaria>();
            decimal saldoTotal = 0;

            foreach (clsCuentaBancaria cuenta in Program.cuentas)
            {
                if (cuenta.Codigo_cliente == codigo_cliente)
                {
                    cuentas.Add(cuenta);
                    saldoTotal += (Decimal)cuenta.Saldo;
                }
            }


            if (cuentas.Count > 0)
            {
                this.dgvListado.DataSource = null;
                this.dgvListado.DataSource = Program.cuentas;
                txtSaldo.Text = saldoTotal+"";
            }
            else
            {
                MessageBox.Show("no se encontraron cuenta de dicho cliente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Boolean encontrado = false;

            foreach (clsPropietario cliente in Program.Propietarios)
            {
                if (cliente.Codigo_Cliente == txtCodigoCliente.Text)
                {
                    encontrado = true;
                    if (cliente.GetType() == typeof(clsPersona))
                    {
                        clsPersona c = cliente as clsPersona;
                        txtCliente.Text = c.Nombres + " " + c.ApellidoPaterno;
                    }
                    if (cliente.GetType() == typeof(clsEmpresa))
                    {
                        clsEmpresa c = cliente as clsEmpresa;
                        txtCliente.Text = c.RazonSocial;
                    }
                }
            }

            if (encontrado)
            {
                listarCuentas(txtCodigoCliente.Text);
            }
            else
            {
                MessageBox.Show("no se encontro cliente con dicho codigo", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
