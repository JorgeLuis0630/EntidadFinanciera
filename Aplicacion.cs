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
    public partial class Aplicacion : Form
    {
        public Aplicacion()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.ShowDialog();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuentas frm = new frmCuentas();
            frm.ShowDialog();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void depositoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeposito frm = new frmDeposito();
            frm.ShowDialog();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void mostrarSaldoDeUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTotalCliente frm = new frmTotalCliente();
            frm.ShowDialog();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void retiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRetiro frm = new frmRetiro();
            frm.ShowDialog();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void listadoDeCuentasPorSexoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarPorSexo frm = new frmListarPorSexo();
            frm.ShowDialog();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void datosDePropietarioPorNumeroDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosdelCliente frm = new frmDatosdelCliente();
            frm.ShowDialog();
            frm.WindowState = FormWindowState.Maximized;
        }
    }
}
