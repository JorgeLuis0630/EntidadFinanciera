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
    public partial class frmDeposito : Form
    {
        clsCuentaBancaria Actual;

        public frmDeposito()
        {
            InitializeComponent();
        }

        private void listarCuentas(string codigo_cliente)
        {
            List<clsCuentaBancaria> cuentas = new List<clsCuentaBancaria>();

            foreach(clsCuentaBancaria cuenta in Program.cuentas)
            {
                if(cuenta.Codigo_cliente == codigo_cliente)
                {
                    cuentas.Add(cuenta);
                }
            }


            if (cuentas.Count > 0)
            {
                this.dgvListado.DataSource = null;
                this.dgvListado.DataSource = Program.cuentas;
                this.dgvListado.AutoGenerateColumns = false;
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
                gbDatosCuenta.Enabled = true;
                listarCuentas(txtCodigoCliente.Text);
            }
            else
            {
                MessageBox.Show("no se encontro cliente con dicho codigo", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Actual = (clsCuentaBancaria)this.dgvListado.CurrentRow.DataBoundItem;
                this.txtCodigo.Text = this.Actual.Numero;
            }
            else
            {
                MessageBox.Show("debe seleccionar una cuenta", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() == true)
            {
                this.AutoValidate = AutoValidate.Disable;
                if (!(this.Actual == null))
                {
                    this.Actual.Saldo += (double)txtSaldo.Value;
                    this.listarCuentas(this.Actual.Codigo_cliente);
                }
            }
            
        }

        private void limpiar()
        {
            this.Actual = null;
            txtCodigoCliente.Text = "";
            txtCliente.Text = "";
            txtCodigo.Text = "";
            txtSaldo.Value = 0;

            this.dgvListado.DataSource = null;
            gbDatosCuenta.Enabled = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
