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
    public partial class frmCuentas : Form
    {
        clsCuentaBancaria Actual;

        public frmCuentas()
        {
            InitializeComponent();
            listarCuentas();
        }

        private void ActivarControles(bool estado)
        {
            this.gbCuenta.Enabled = estado;
            this.gbCliente.Enabled = estado;

            if (estado == true)
            {
                this.txtCodigoCliente.Focus();
            }
            limpiarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.ActivarControles(true);
        }

        private void button1_Click(object sender, EventArgs e)
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
            }
            else
            {
                MessageBox.Show("no se encontro cliente con dicho codigo", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private clsCuentaBancaria crearCuenta()
        {
            clsCuentaBancaria cuenta = new clsCuentaBancaria();
            cuenta.Codigo_cliente = txtCodigoCliente.Text;
            cuenta.Numero = txtNumero.Text;
            cuenta.Tipo = cbTipo.Text;
            cuenta.TipoMoneda = cbMoneda.Text;
            cuenta.MontoApertura = (Double)txtApertura.Value;
            cuenta.Saldo = (Double)txtSaldo.Value;
            cuenta.Estado = cbEstado.Checked;

            return cuenta;

        }

        private bool verificarCuenta(string numero)
        {
            bool repetido = false;

            foreach(clsCuentaBancaria cuenta in Program.cuentas)
            {
                if(cuenta.Numero == numero)
                {
                    repetido = true;
                    break;
                }
            }

            return repetido;
        }

        private void listarCuentas()
        {
            this.dgvListado.DataSource = null;
            if (Program.cuentas.Count > 0)
            {
                this.dgvListado.DataSource = Program.cuentas;
                this.dgvListado.AutoGenerateColumns = false;
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            clsCuentaBancaria cuenta;

            if (this.ValidateChildren() == true)
            {
                this.AutoValidate = AutoValidate.Disable;
                if (this.Actual == null)
                {
                    string numero = txtNumero.Text;
                    bool repetido = verificarCuenta(numero);
                    if (!repetido)
                    {
                        cuenta = this.crearCuenta();
                        Program.cuentas.Add(cuenta);
                    }
                    else
                    {
                        MessageBox.Show("codigo de cuenta ya registrada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                this.Actual.Codigo_cliente = txtCodigoCliente.Text;
                this.Actual.Numero = txtNumero.Text;
                this.Actual.Tipo = cbTipo.Text;
                this.Actual.TipoMoneda = cbMoneda.Text;
                this.Actual.MontoApertura = (double)txtApertura.Value;
                this.Actual.Saldo= (double)txtSaldo.Value;
                this.Actual.Estado = cbEstado.Checked;
            }
            this.listarCuentas();
            this.ActivarControles(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Actual = (clsCuentaBancaria)this.dgvListado.CurrentRow.DataBoundItem;
                this.Presentardatos();

            }
            else
            {
                MessageBox.Show("debe seleccionar un producto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Presentardatos()
        {
            this.txtNumero.Text = this.Actual.Numero;
            this.cbTipo.Text = this.Actual.Tipo;
            this.cbMoneda.Text = this.Actual.TipoMoneda;
            this.txtApertura.Value = (Decimal) this.Actual.MontoApertura;
            this.txtSaldo.Value = (Decimal) this.Actual.Saldo;
            this.cbEstado.Checked = this.Actual.Estado;
            this.ActivarControles(true);

        }

        private void limpiarDatos()
        {
            this.txtCodigoCliente.Text = "";
            this.txtCliente.Text = "";
            this.txtNumero.Text = "";
            this.cbTipo.SelectedIndex = 0;
            this.cbMoneda.SelectedIndex = 0;
            this.txtApertura.Value = 0;
            this.txtSaldo.Value = 0;
            this.cbEstado.Checked = true;

        }
    }


}
