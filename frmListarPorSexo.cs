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
    public partial class frmListarPorSexo : Form
    {
        public frmListarPorSexo()
        {
            InitializeComponent();
        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboSexo.SelectedIndex > -1)
            {
                this.dgvListado.DataSource = Program.Propietarios;
            }
        }

        private void frmListarPorSexo_Load(object sender, EventArgs e)
        {
            CargarSexo();
        }
        private void CargarSexo()
        {
            this.cboSexo.DataSource = null;
            if (Program.Propietarios.Count > 0)
            {
                this.cboSexo.DisplayMember = "Sexo";
                this.cboSexo.DataSource = Program.Propietarios;
            }
        }
    }
}
