namespace Banco
{
    partial class Aplicacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarSaldoDeUnClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeCuentasPorSexoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDePropietarioPorNumeroDeCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.cuentasToolStripMenuItem});
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.datosToolStripMenuItem.Text = "Datos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            this.cuentasToolStripMenuItem.Click += new System.EventHandler(this.cuentasToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositoToolStripMenuItem,
            this.retiroToolStripMenuItem,
            this.mostrarSaldoDeUnClienteToolStripMenuItem,
            this.listadoDeCuentasPorSexoToolStripMenuItem,
            this.datosDePropietarioPorNumeroDeCuentaToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.reportesToolStripMenuItem.Text = "Operaciones";
            // 
            // depositoToolStripMenuItem
            // 
            this.depositoToolStripMenuItem.Name = "depositoToolStripMenuItem";
            this.depositoToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.depositoToolStripMenuItem.Text = "Deposito";
            this.depositoToolStripMenuItem.Click += new System.EventHandler(this.depositoToolStripMenuItem_Click);
            // 
            // retiroToolStripMenuItem
            // 
            this.retiroToolStripMenuItem.Name = "retiroToolStripMenuItem";
            this.retiroToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.retiroToolStripMenuItem.Text = "Retiro";
            this.retiroToolStripMenuItem.Click += new System.EventHandler(this.retiroToolStripMenuItem_Click);
            // 
            // mostrarSaldoDeUnClienteToolStripMenuItem
            // 
            this.mostrarSaldoDeUnClienteToolStripMenuItem.Name = "mostrarSaldoDeUnClienteToolStripMenuItem";
            this.mostrarSaldoDeUnClienteToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.mostrarSaldoDeUnClienteToolStripMenuItem.Text = "Mostrar Saldo de un cliente";
            this.mostrarSaldoDeUnClienteToolStripMenuItem.Click += new System.EventHandler(this.mostrarSaldoDeUnClienteToolStripMenuItem_Click);
            // 
            // listadoDeCuentasPorSexoToolStripMenuItem
            // 
            this.listadoDeCuentasPorSexoToolStripMenuItem.Name = "listadoDeCuentasPorSexoToolStripMenuItem";
            this.listadoDeCuentasPorSexoToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.listadoDeCuentasPorSexoToolStripMenuItem.Text = "Listado de Cuentas por Sexo";
            this.listadoDeCuentasPorSexoToolStripMenuItem.Click += new System.EventHandler(this.listadoDeCuentasPorSexoToolStripMenuItem_Click);
            // 
            // datosDePropietarioPorNumeroDeCuentaToolStripMenuItem
            // 
            this.datosDePropietarioPorNumeroDeCuentaToolStripMenuItem.Name = "datosDePropietarioPorNumeroDeCuentaToolStripMenuItem";
            this.datosDePropietarioPorNumeroDeCuentaToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.datosDePropietarioPorNumeroDeCuentaToolStripMenuItem.Text = "Datos de Propietario por Numero de cuenta";
            this.datosDePropietarioPorNumeroDeCuentaToolStripMenuItem.Click += new System.EventHandler(this.datosDePropietarioPorNumeroDeCuentaToolStripMenuItem_Click);
            // 
            // Aplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Aplicacion";
            this.Text = "Entidad Financiera";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarSaldoDeUnClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeCuentasPorSexoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDePropietarioPorNumeroDeCuentaToolStripMenuItem;
    }
}

