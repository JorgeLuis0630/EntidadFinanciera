namespace Banco
{
    partial class frmCuentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.errProducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbCuenta = new System.Windows.Forms.GroupBox();
            this.gbDatosCuenta = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMoneda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.txtApertura = new System.Windows.Forms.NumericUpDown();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtlabelCliente = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProducto)).BeginInit();
            this.gbCuenta.SuspendLayout();
            this.gbDatosCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApertura)).BeginInit();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(87, 434);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(168, 434);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Location = new System.Drawing.Point(6, 401);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(87, 401);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // gbListado
            // 
            this.gbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListado.Controls.Add(this.dgvListado);
            this.gbListado.Controls.Add(this.btnNuevo);
            this.gbListado.Controls.Add(this.btnModificar);
            this.gbListado.Location = new System.Drawing.Point(352, 20);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(412, 434);
            this.gbListado.TabIndex = 8;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado";
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(6, 19);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(400, 376);
            this.dgvListado.TabIndex = 0;
            // 
            // errProducto
            // 
            this.errProducto.ContainerControl = this;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(689, 460);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "C&errar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbCuenta
            // 
            this.gbCuenta.Controls.Add(this.gbDatosCuenta);
            this.gbCuenta.Controls.Add(this.gbCliente);
            this.gbCuenta.Controls.Add(this.btnAceptar);
            this.gbCuenta.Controls.Add(this.btnCancelar);
            this.gbCuenta.Enabled = false;
            this.gbCuenta.Location = new System.Drawing.Point(31, 20);
            this.gbCuenta.Name = "gbCuenta";
            this.gbCuenta.Size = new System.Drawing.Size(294, 463);
            this.gbCuenta.TabIndex = 7;
            this.gbCuenta.TabStop = false;
            this.gbCuenta.Text = "Cuentas Bancarias";
            // 
            // gbDatosCuenta
            // 
            this.gbDatosCuenta.Controls.Add(this.txtSaldo);
            this.gbDatosCuenta.Controls.Add(this.label3);
            this.gbDatosCuenta.Controls.Add(this.cbMoneda);
            this.gbDatosCuenta.Controls.Add(this.label2);
            this.gbDatosCuenta.Controls.Add(this.cbTipo);
            this.gbDatosCuenta.Controls.Add(this.label1);
            this.gbDatosCuenta.Controls.Add(this.cbEstado);
            this.gbDatosCuenta.Controls.Add(this.txtApertura);
            this.gbDatosCuenta.Controls.Add(this.txtNumero);
            this.gbDatosCuenta.Controls.Add(this.lblPrecio);
            this.gbDatosCuenta.Controls.Add(this.lblNombre);
            this.gbDatosCuenta.Enabled = false;
            this.gbDatosCuenta.Location = new System.Drawing.Point(7, 150);
            this.gbDatosCuenta.Name = "gbDatosCuenta";
            this.gbDatosCuenta.Size = new System.Drawing.Size(281, 274);
            this.gbDatosCuenta.TabIndex = 22;
            this.gbDatosCuenta.TabStop = false;
            this.gbDatosCuenta.Text = "Datos de la cuenta";
            // 
            // txtSaldo
            // 
            this.txtSaldo.DecimalPlaces = 2;
            this.txtSaldo.Location = new System.Drawing.Point(61, 204);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(182, 20);
            this.txtSaldo.TabIndex = 31;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Saldo:";
            // 
            // cbMoneda
            // 
            this.cbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.Items.AddRange(new object[] {
            "Soles",
            "Dolares"});
            this.cbMoneda.Location = new System.Drawing.Point(61, 115);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(182, 21);
            this.cbMoneda.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Moneda:";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Ahorro",
            "Corriente"});
            this.cbTipo.Location = new System.Drawing.Point(61, 68);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(182, 21);
            this.cbTipo.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tipo:";
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Checked = true;
            this.cbEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEstado.Location = new System.Drawing.Point(61, 241);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(93, 17);
            this.cbEstado.TabIndex = 25;
            this.cbEstado.Text = "Cuenta Activa";
            this.cbEstado.UseVisualStyleBackColor = true;
            // 
            // txtApertura
            // 
            this.txtApertura.DecimalPlaces = 2;
            this.txtApertura.Location = new System.Drawing.Point(61, 161);
            this.txtApertura.Name = "txtApertura";
            this.txtApertura.Size = new System.Drawing.Size(182, 20);
            this.txtApertura.TabIndex = 24;
            this.txtApertura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(61, 22);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(182, 20);
            this.txtNumero.TabIndex = 22;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(6, 163);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(50, 13);
            this.lblPrecio.TabIndex = 23;
            this.lblPrecio.Text = "Apertura:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "Numero:";
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.button1);
            this.gbCliente.Controls.Add(this.txtCliente);
            this.gbCliente.Controls.Add(this.txtlabelCliente);
            this.gbCliente.Controls.Add(this.txtCodigoCliente);
            this.gbCliente.Controls.Add(this.label4);
            this.gbCliente.Enabled = false;
            this.gbCliente.Location = new System.Drawing.Point(7, 20);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(281, 112);
            this.gbCliente.TabIndex = 21;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Buscar Cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(61, 68);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(182, 20);
            this.txtCliente.TabIndex = 23;
            // 
            // txtlabelCliente
            // 
            this.txtlabelCliente.AutoSize = true;
            this.txtlabelCliente.Location = new System.Drawing.Point(6, 71);
            this.txtlabelCliente.Name = "txtlabelCliente";
            this.txtlabelCliente.Size = new System.Drawing.Size(42, 13);
            this.txtlabelCliente.TabIndex = 22;
            this.txtlabelCliente.Text = "Cliente:";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(61, 24);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(127, 20);
            this.txtCodigoCliente.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Codigo:";
            // 
            // frmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbCuenta);
            this.Name = "frmCuentas";
            this.Text = "Gestionar Cuentas Bancarias";
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProducto)).EndInit();
            this.gbCuenta.ResumeLayout(false);
            this.gbDatosCuenta.ResumeLayout(false);
            this.gbDatosCuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApertura)).EndInit();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.ErrorProvider errProducto;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gbCuenta;
        private System.Windows.Forms.GroupBox gbDatosCuenta;
        private System.Windows.Forms.NumericUpDown txtSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMoneda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.NumericUpDown txtApertura;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label txtlabelCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label label4;
    }
}