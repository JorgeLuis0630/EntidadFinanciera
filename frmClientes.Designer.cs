namespace Banco
{
    partial class frmClientes
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
            this.dgvListadoEmpresa = new System.Windows.Forms.DataGridView();
            this.dgvListadoNatural = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.errProducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.gbEmpresa = new System.Windows.Forms.GroupBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbnatural = new System.Windows.Forms.GroupBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEmpresa = new System.Windows.Forms.RadioButton();
            this.rbNatural = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoNatural)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProducto)).BeginInit();
            this.gbProducto.SuspendLayout();
            this.gbEmpresa.SuspendLayout();
            this.gbnatural.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(72, 514);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(168, 514);
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
            this.btnNuevo.Location = new System.Drawing.Point(6, 538);
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
            this.btnModificar.Location = new System.Drawing.Point(87, 538);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // gbListado
            // 
            this.gbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListado.Controls.Add(this.dgvListadoEmpresa);
            this.gbListado.Controls.Add(this.btnNuevo);
            this.gbListado.Controls.Add(this.dgvListadoNatural);
            this.gbListado.Controls.Add(this.btnModificar);
            this.gbListado.Location = new System.Drawing.Point(352, 20);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(412, 567);
            this.gbListado.TabIndex = 8;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado";
            // 
            // dgvListadoEmpresa
            // 
            this.dgvListadoEmpresa.AllowUserToAddRows = false;
            this.dgvListadoEmpresa.AllowUserToDeleteRows = false;
            this.dgvListadoEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListadoEmpresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoEmpresa.Location = new System.Drawing.Point(6, 289);
            this.dgvListadoEmpresa.MultiSelect = false;
            this.dgvListadoEmpresa.Name = "dgvListadoEmpresa";
            this.dgvListadoEmpresa.ReadOnly = true;
            this.dgvListadoEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoEmpresa.Size = new System.Drawing.Size(400, 230);
            this.dgvListadoEmpresa.TabIndex = 1;
            // 
            // dgvListadoNatural
            // 
            this.dgvListadoNatural.AllowUserToAddRows = false;
            this.dgvListadoNatural.AllowUserToDeleteRows = false;
            this.dgvListadoNatural.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListadoNatural.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoNatural.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoNatural.Location = new System.Drawing.Point(6, 19);
            this.dgvListadoNatural.MultiSelect = false;
            this.dgvListadoNatural.Name = "dgvListadoNatural";
            this.dgvListadoNatural.ReadOnly = true;
            this.dgvListadoNatural.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoNatural.Size = new System.Drawing.Size(400, 239);
            this.dgvListadoNatural.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(56, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(187, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // errProducto
            // 
            this.errProducto.ContainerControl = this;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(43, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Codigo:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(689, 599);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "C&errar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.gbEmpresa);
            this.gbProducto.Controls.Add(this.gbnatural);
            this.gbProducto.Controls.Add(this.groupBox1);
            this.gbProducto.Controls.Add(this.btnAceptar);
            this.gbProducto.Controls.Add(this.btnCancelar);
            this.gbProducto.Controls.Add(this.txtCodigo);
            this.gbProducto.Controls.Add(this.lblNombre);
            this.gbProducto.Enabled = false;
            this.gbProducto.Location = new System.Drawing.Point(36, 44);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(294, 543);
            this.gbProducto.TabIndex = 7;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Propietario";
            // 
            // gbEmpresa
            // 
            this.gbEmpresa.Controls.Add(this.txtRUC);
            this.gbEmpresa.Controls.Add(this.label7);
            this.gbEmpresa.Controls.Add(this.txtRazonSocial);
            this.gbEmpresa.Controls.Add(this.label8);
            this.gbEmpresa.Enabled = false;
            this.gbEmpresa.Location = new System.Drawing.Point(9, 380);
            this.gbEmpresa.Name = "gbEmpresa";
            this.gbEmpresa.Size = new System.Drawing.Size(234, 96);
            this.gbEmpresa.TabIndex = 26;
            this.gbEmpresa.TabStop = false;
            this.gbEmpresa.Text = "Empresa";
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(63, 58);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(163, 20);
            this.txtRUC.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "RUC:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(63, 22);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(163, 20);
            this.txtRazonSocial.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "R. Social:";
            // 
            // gbnatural
            // 
            this.gbnatural.Controls.Add(this.cbSexo);
            this.gbnatural.Controls.Add(this.label4);
            this.gbnatural.Controls.Add(this.txtDNI);
            this.gbnatural.Controls.Add(this.label3);
            this.gbnatural.Controls.Add(this.txtApellidoM);
            this.gbnatural.Controls.Add(this.label5);
            this.gbnatural.Controls.Add(this.txtApellidoP);
            this.gbnatural.Controls.Add(this.label2);
            this.gbnatural.Controls.Add(this.txtNombres);
            this.gbnatural.Controls.Add(this.label1);
            this.gbnatural.Enabled = false;
            this.gbnatural.Location = new System.Drawing.Point(9, 156);
            this.gbnatural.Name = "gbnatural";
            this.gbnatural.Size = new System.Drawing.Size(234, 218);
            this.gbnatural.TabIndex = 17;
            this.gbnatural.TabStop = false;
            this.gbnatural.Text = "Cliente Natural";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino",
            "Programador"});
            this.cbSexo.Location = new System.Drawing.Point(63, 178);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(163, 21);
            this.cbSexo.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Sexo:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(63, 139);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(163, 20);
            this.txtDNI.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "DNI:";
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(63, 58);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(163, 20);
            this.txtApellidoP.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "A.Paterno:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(63, 22);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(163, 20);
            this.txtNombres.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombres:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEmpresa);
            this.groupBox1.Controls.Add(this.rbNatural);
            this.groupBox1.Location = new System.Drawing.Point(9, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 71);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar";
            // 
            // rbEmpresa
            // 
            this.rbEmpresa.AutoSize = true;
            this.rbEmpresa.Location = new System.Drawing.Point(7, 45);
            this.rbEmpresa.Name = "rbEmpresa";
            this.rbEmpresa.Size = new System.Drawing.Size(66, 17);
            this.rbEmpresa.TabIndex = 1;
            this.rbEmpresa.TabStop = true;
            this.rbEmpresa.Text = "Empresa";
            this.rbEmpresa.UseVisualStyleBackColor = true;
            this.rbEmpresa.CheckedChanged += new System.EventHandler(this.rbEmpresa_CheckedChanged);
            // 
            // rbNatural
            // 
            this.rbNatural.AutoSize = true;
            this.rbNatural.Location = new System.Drawing.Point(7, 20);
            this.rbNatural.Name = "rbNatural";
            this.rbNatural.Size = new System.Drawing.Size(94, 17);
            this.rbNatural.TabIndex = 0;
            this.rbNatural.TabStop = true;
            this.rbNatural.Text = "Cliente Natural";
            this.rbNatural.UseVisualStyleBackColor = true;
            this.rbNatural.CheckedChanged += new System.EventHandler(this.rbNatural_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "A.Materno:";
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(63, 95);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(163, 20);
            this.txtApellidoM.TabIndex = 21;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 634);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbProducto);
            this.Name = "frmClientes";
            this.Text = "Gestionar Clientes";
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoNatural)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProducto)).EndInit();
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            this.gbEmpresa.ResumeLayout(false);
            this.gbEmpresa.PerformLayout();
            this.gbnatural.ResumeLayout(false);
            this.gbnatural.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.DataGridView dgvListadoNatural;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ErrorProvider errProducto;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEmpresa;
        private System.Windows.Forms.RadioButton rbNatural;
        private System.Windows.Forms.GroupBox gbEmpresa;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbnatural;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListadoEmpresa;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.Label label5;
    }
}