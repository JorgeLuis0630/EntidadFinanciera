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
    public partial class frmClientes : Form
    {
        clsPersona actualPersona;
        clsEmpresa actualEmpresa;

        List<clsPersona> personas = new List<clsPersona>();
        List<clsEmpresa> empresas = new List<clsEmpresa>();

        public frmClientes()
        {
            InitializeComponent();
            listarclientes();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() == true)
            {
                this.AutoValidate = AutoValidate.Disable;
                if (this.actualPersona == null && this.actualEmpresa==null)
                {
                    string codigo_cliente = txtCodigo.Text;
                    bool ya_registrado = verificarCliente(codigo_cliente);
                    if (!ya_registrado)
                    {
                        if (rbNatural.Checked)
                        {
                            string dni = txtDNI.Text;
                            bool repetido = verificarDNI(dni);

                            if (!repetido)
                            {
                                clsPersona persona = this.crearClienteNatural();
                                Program.Propietarios.Add(persona);
                            }
                            else
                            {
                                MessageBox.Show("este dni ya esta registrado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        if (rbEmpresa.Checked)
                        {
                            string ruc = txtRUC.Text;
                            bool repetido = verificarRUC(ruc);

                            if (!repetido)
                            {
                                clsEmpresa empresa = this.crearClienteEmpresa();
                                Program.Propietarios.Add(empresa);
                            }
                            else
                            {
                                MessageBox.Show("este ruc ya esta registrado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("este codigo de cliente ya esta registrado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            else
            {

                if (rbNatural.Checked)
                {

                }
                else
                {

                }
            }
            this.listarclientes();
            this.ActivarControles(false);
        }

        private void rbNatural_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNatural.Checked)
            {
                gbEmpresa.Enabled = false;
                gbnatural.Enabled = true;
            }
        }

        private void rbEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmpresa.Checked)
            {
                gbnatural.Enabled = false;
                gbEmpresa.Enabled = true;
            }
                
        }

        private void ActivarControles(bool estado)
        {
            this.gbProducto.Enabled = estado;
            this.gbListado.Enabled = !estado;

            if (estado == true)
            {
                this.txtCodigo.Focus();
            }
            this.limpiarPersona();
            this.limpiarEmpresa();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ActivarControles(true);
        }

        private Boolean verificarCliente(string codigo_cliente) //recibe el codigo que quiero guardar del cliente y verifica si esta repetido o no
        {
            bool repetido = false;
            foreach (clsPropietario cliente in Program.Propietarios)
            {
                if(cliente.Codigo_Cliente == codigo_cliente)
                {
                    repetido = true;
                    break;
                }
            }
            return repetido;
        }


        private void limpiarPersona()
        {
            txtCodigo.Text = "";
            txtNombres.Text = "";
            txtApellidoP.Text = "";
            txtDNI.Text = "";
            cbSexo.SelectedIndex = 0;

        }

        private void limpiarEmpresa()
        {
            txtCodigo.Text = "";
            txtRazonSocial.Text = "";
            txtRUC.Text = "";

        }

        private Boolean verificarDNI(string dni)
        {
            bool repetido = false;
            foreach (clsPropietario cliente in Program.Propietarios)
            {
                if (cliente.GetType() == typeof(clsPersona))
                {
                    clsPersona c = cliente as clsPersona;
                    if(c.DNI == dni)
                    {
                        repetido = true;
                        break;
                    }
                }
            }
            return repetido;
        }

        private clsPersona crearClienteNatural()
        {
            clsPersona natural = new clsPersona();
            natural.Codigo_Cliente = this.txtCodigo.Text;
            natural.Nombres = this.txtNombres.Text;
            natural.ApellidoPaterno = this.txtApellidoP.Text;
            natural.ApellidoMaterno = this.txtApellidoM.Text;
            natural.DNI = this.txtDNI.Text;
            natural.Sexo = this.cbSexo.Text;
            return natural;
        }

        private Boolean verificarRUC(string ruc)
        {
            bool repetido = false;
            foreach (clsPropietario cliente in Program.Propietarios)
            {
                if (cliente.GetType() == typeof(clsEmpresa))
                {
                    clsEmpresa c = cliente as clsEmpresa;
                    if (c.RUC == ruc)
                    {
                        repetido = true;
                        break;
                    }
                }
            }
            return repetido;
        }

        private clsEmpresa crearClienteEmpresa()
        {
            clsEmpresa empresa = new clsEmpresa();
            empresa.Codigo_Cliente = this.txtCodigo.Text;
            empresa.RazonSocial= this.txtRazonSocial.Text;
            empresa.RUC = this.txtRUC.Text;
            return empresa;
        }

        private void listarclientes()
        {
            this.dgvListadoNatural.DataSource = null;
            this.dgvListadoEmpresa.DataSource = null;

            this.empresas.Clear();
            this.personas.Clear();

            foreach(clsPropietario cliente in Program.Propietarios)
            {
                if(cliente.GetType() == typeof(clsPersona))
                {
                    this.personas.Add(cliente as clsPersona);
                }

                if (cliente.GetType() == typeof(clsEmpresa))
                {
                    this.empresas.Add(cliente as clsEmpresa);
                }
            }

            this.dgvListadoNatural.DataSource = this.personas;
            this.dgvListadoNatural.AutoGenerateColumns = false;

            this.dgvListadoEmpresa.DataSource = this.empresas;
            this.dgvListadoEmpresa.AutoGenerateColumns = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
