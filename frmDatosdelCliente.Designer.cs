namespace Banco
{
    partial class frmDatosdelCliente
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.dgvPropietario = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbCuenta = new System.Windows.Forms.GroupBox();
            this.dgvCuenta = new System.Windows.Forms.DataGridView();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropietario)).BeginInit();
            this.gbCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuenta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(156, 32);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(182, 20);
            this.txtNumero.TabIndex = 24;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(101, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "Numero:";
            // 
            // gbListado
            // 
            this.gbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListado.Controls.Add(this.dgvPropietario);
            this.gbListado.Location = new System.Drawing.Point(56, 58);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(412, 192);
            this.gbListado.TabIndex = 25;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado";
            // 
            // dgvPropietario
            // 
            this.dgvPropietario.AllowUserToAddRows = false;
            this.dgvPropietario.AllowUserToDeleteRows = false;
            this.dgvPropietario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPropietario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPropietario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropietario.Location = new System.Drawing.Point(6, 19);
            this.dgvPropietario.MultiSelect = false;
            this.dgvPropietario.Name = "dgvPropietario";
            this.dgvPropietario.ReadOnly = true;
            this.dgvPropietario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPropietario.Size = new System.Drawing.Size(400, 134);
            this.dgvPropietario.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(393, 517);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 26;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(374, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbCuenta
            // 
            this.gbCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCuenta.Controls.Add(this.dgvCuenta);
            this.gbCuenta.Location = new System.Drawing.Point(56, 256);
            this.gbCuenta.Name = "gbCuenta";
            this.gbCuenta.Size = new System.Drawing.Size(412, 197);
            this.gbCuenta.TabIndex = 28;
            this.gbCuenta.TabStop = false;
            this.gbCuenta.Text = "Listado";
            // 
            // dgvCuenta
            // 
            this.dgvCuenta.AllowUserToAddRows = false;
            this.dgvCuenta.AllowUserToDeleteRows = false;
            this.dgvCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCuenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuenta.Location = new System.Drawing.Point(6, 19);
            this.dgvCuenta.MultiSelect = false;
            this.dgvCuenta.Name = "dgvCuenta";
            this.dgvCuenta.ReadOnly = true;
            this.dgvCuenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuenta.Size = new System.Drawing.Size(400, 139);
            this.dgvCuenta.TabIndex = 0;
            // 
            // frmDatosdelCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 552);
            this.Controls.Add(this.gbCuenta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmDatosdelCliente";
            this.Text = "frmDatosdelCliente";
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropietario)).EndInit();
            this.gbCuenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.DataGridView dgvPropietario;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbCuenta;
        private System.Windows.Forms.DataGridView dgvCuenta;
    }
}