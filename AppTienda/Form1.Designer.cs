
namespace AppTienda
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbcGestion = new System.Windows.Forms.TabControl();
            this.tbpinsertarTienda = new System.Windows.Forms.TabPage();
            this.btnTiendaGuardar = new System.Windows.Forms.Button();
            this.txtTiendaFechaCreacion = new System.Windows.Forms.TextBox();
            this.txtTiendaNombre = new System.Windows.Forms.TextBox();
            this.txtTiendaNit = new System.Windows.Forms.TextBox();
            this.lbFechaCreacion = new System.Windows.Forms.Label();
            this.lbNombreTienda = new System.Windows.Forms.Label();
            this.lbNit = new System.Windows.Forms.Label();
            this.tbpinsertarElectrodomestico = new System.Windows.Forms.TabPage();
            this.btnElectroGuardar = new System.Windows.Forms.Button();
            this.cmbTipoElectrodomestico = new System.Windows.Forms.ComboBox();
            this.txtElectroTiendNit = new System.Windows.Forms.TextBox();
            this.txtElectroPaisOrigen = new System.Windows.Forms.TextBox();
            this.txtElectroMarca = new System.Windows.Forms.TextBox();
            this.txtElectroAnioFabricacion = new System.Windows.Forms.TextBox();
            this.txtElectroSerial = new System.Windows.Forms.TextBox();
            this.lbElectroNitTienda = new System.Windows.Forms.Label();
            this.lbelectroPaisOrigen = new System.Windows.Forms.Label();
            this.lbElectroMarca = new System.Windows.Forms.Label();
            this.lbElectroFechaFabricacion = new System.Windows.Forms.Label();
            this.lbElectroTipo = new System.Windows.Forms.Label();
            this.lbElectroSerial = new System.Windows.Forms.Label();
            this.tbpconsultarElectrodomesticos = new System.Windows.Forms.TabPage();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtConsultaNit = new System.Windows.Forms.TextBox();
            this.lbConsultaNit = new System.Windows.Forms.Label();
            this.dgConsulta = new System.Windows.Forms.DataGridView();
            this.tbpActializarDatosTienda = new System.Windows.Forms.TabPage();
            this.btnActualizarTienda = new System.Windows.Forms.Button();
            this.btnBuscarTienda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtActFechaTienda = new System.Windows.Forms.TextBox();
            this.txtActNombreTienda = new System.Windows.Forms.TextBox();
            this.txtActNitTienda = new System.Windows.Forms.TextBox();
            this.tbcActualizarElectrodomestico = new System.Windows.Forms.TabPage();
            this.tbcGestion.SuspendLayout();
            this.tbpinsertarTienda.SuspendLayout();
            this.tbpinsertarElectrodomestico.SuspendLayout();
            this.tbpconsultarElectrodomesticos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsulta)).BeginInit();
            this.tbpActializarDatosTienda.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcGestion
            // 
            this.tbcGestion.Controls.Add(this.tbpinsertarTienda);
            this.tbcGestion.Controls.Add(this.tbpinsertarElectrodomestico);
            this.tbcGestion.Controls.Add(this.tbpconsultarElectrodomesticos);
            this.tbcGestion.Controls.Add(this.tbpActializarDatosTienda);
            this.tbcGestion.Controls.Add(this.tbcActualizarElectrodomestico);
            this.tbcGestion.Location = new System.Drawing.Point(36, 92);
            this.tbcGestion.Name = "tbcGestion";
            this.tbcGestion.SelectedIndex = 0;
            this.tbcGestion.Size = new System.Drawing.Size(730, 346);
            this.tbcGestion.TabIndex = 0;
            // 
            // tbpinsertarTienda
            // 
            this.tbpinsertarTienda.Controls.Add(this.btnTiendaGuardar);
            this.tbpinsertarTienda.Controls.Add(this.txtTiendaFechaCreacion);
            this.tbpinsertarTienda.Controls.Add(this.txtTiendaNombre);
            this.tbpinsertarTienda.Controls.Add(this.txtTiendaNit);
            this.tbpinsertarTienda.Controls.Add(this.lbFechaCreacion);
            this.tbpinsertarTienda.Controls.Add(this.lbNombreTienda);
            this.tbpinsertarTienda.Controls.Add(this.lbNit);
            this.tbpinsertarTienda.Location = new System.Drawing.Point(4, 22);
            this.tbpinsertarTienda.Name = "tbpinsertarTienda";
            this.tbpinsertarTienda.Padding = new System.Windows.Forms.Padding(3);
            this.tbpinsertarTienda.Size = new System.Drawing.Size(722, 320);
            this.tbpinsertarTienda.TabIndex = 0;
            this.tbpinsertarTienda.Text = "Registrar Tienda";
            this.tbpinsertarTienda.UseVisualStyleBackColor = true;
            // 
            // btnTiendaGuardar
            // 
            this.btnTiendaGuardar.Location = new System.Drawing.Point(426, 257);
            this.btnTiendaGuardar.Name = "btnTiendaGuardar";
            this.btnTiendaGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnTiendaGuardar.TabIndex = 1;
            this.btnTiendaGuardar.Text = "Guardar";
            this.btnTiendaGuardar.UseVisualStyleBackColor = true;
            this.btnTiendaGuardar.Click += new System.EventHandler(this.btnTiendaGuardar_Click);
            // 
            // txtTiendaFechaCreacion
            // 
            this.txtTiendaFechaCreacion.Location = new System.Drawing.Point(157, 169);
            this.txtTiendaFechaCreacion.Name = "txtTiendaFechaCreacion";
            this.txtTiendaFechaCreacion.Size = new System.Drawing.Size(100, 20);
            this.txtTiendaFechaCreacion.TabIndex = 1;
            // 
            // txtTiendaNombre
            // 
            this.txtTiendaNombre.Location = new System.Drawing.Point(157, 116);
            this.txtTiendaNombre.Name = "txtTiendaNombre";
            this.txtTiendaNombre.Size = new System.Drawing.Size(100, 20);
            this.txtTiendaNombre.TabIndex = 2;
            // 
            // txtTiendaNit
            // 
            this.txtTiendaNit.Location = new System.Drawing.Point(157, 62);
            this.txtTiendaNit.Name = "txtTiendaNit";
            this.txtTiendaNit.Size = new System.Drawing.Size(100, 20);
            this.txtTiendaNit.TabIndex = 3;
            // 
            // lbFechaCreacion
            // 
            this.lbFechaCreacion.AutoSize = true;
            this.lbFechaCreacion.Location = new System.Drawing.Point(44, 172);
            this.lbFechaCreacion.Name = "lbFechaCreacion";
            this.lbFechaCreacion.Size = new System.Drawing.Size(97, 13);
            this.lbFechaCreacion.TabIndex = 4;
            this.lbFechaCreacion.Text = "Fecha de Creación";
            // 
            // lbNombreTienda
            // 
            this.lbNombreTienda.AutoSize = true;
            this.lbNombreTienda.Location = new System.Drawing.Point(44, 119);
            this.lbNombreTienda.Name = "lbNombreTienda";
            this.lbNombreTienda.Size = new System.Drawing.Size(44, 13);
            this.lbNombreTienda.TabIndex = 1;
            this.lbNombreTienda.Text = "Nombre";
            // 
            // lbNit
            // 
            this.lbNit.AutoSize = true;
            this.lbNit.Location = new System.Drawing.Point(44, 65);
            this.lbNit.Name = "lbNit";
            this.lbNit.Size = new System.Drawing.Size(25, 13);
            this.lbNit.TabIndex = 5;
            this.lbNit.Text = "NIT";
            // 
            // tbpinsertarElectrodomestico
            // 
            this.tbpinsertarElectrodomestico.Controls.Add(this.btnElectroGuardar);
            this.tbpinsertarElectrodomestico.Controls.Add(this.cmbTipoElectrodomestico);
            this.tbpinsertarElectrodomestico.Controls.Add(this.txtElectroTiendNit);
            this.tbpinsertarElectrodomestico.Controls.Add(this.txtElectroPaisOrigen);
            this.tbpinsertarElectrodomestico.Controls.Add(this.txtElectroMarca);
            this.tbpinsertarElectrodomestico.Controls.Add(this.txtElectroAnioFabricacion);
            this.tbpinsertarElectrodomestico.Controls.Add(this.txtElectroSerial);
            this.tbpinsertarElectrodomestico.Controls.Add(this.lbElectroNitTienda);
            this.tbpinsertarElectrodomestico.Controls.Add(this.lbelectroPaisOrigen);
            this.tbpinsertarElectrodomestico.Controls.Add(this.lbElectroMarca);
            this.tbpinsertarElectrodomestico.Controls.Add(this.lbElectroFechaFabricacion);
            this.tbpinsertarElectrodomestico.Controls.Add(this.lbElectroTipo);
            this.tbpinsertarElectrodomestico.Controls.Add(this.lbElectroSerial);
            this.tbpinsertarElectrodomestico.Location = new System.Drawing.Point(4, 22);
            this.tbpinsertarElectrodomestico.Name = "tbpinsertarElectrodomestico";
            this.tbpinsertarElectrodomestico.Padding = new System.Windows.Forms.Padding(3);
            this.tbpinsertarElectrodomestico.Size = new System.Drawing.Size(722, 320);
            this.tbpinsertarElectrodomestico.TabIndex = 1;
            this.tbpinsertarElectrodomestico.Text = "Registrar Electrodoméstico";
            this.tbpinsertarElectrodomestico.UseVisualStyleBackColor = true;
            // 
            // btnElectroGuardar
            // 
            this.btnElectroGuardar.Location = new System.Drawing.Point(354, 255);
            this.btnElectroGuardar.Name = "btnElectroGuardar";
            this.btnElectroGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnElectroGuardar.TabIndex = 2;
            this.btnElectroGuardar.Text = "Guardar";
            this.btnElectroGuardar.UseVisualStyleBackColor = true;
            this.btnElectroGuardar.Click += new System.EventHandler(this.btnElectroGuardar_Click);
            // 
            // cmbTipoElectrodomestico
            // 
            this.cmbTipoElectrodomestico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoElectrodomestico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoElectrodomestico.FormattingEnabled = true;
            this.cmbTipoElectrodomestico.Items.AddRange(new object[] {
            "televisor",
            "lavadora",
            "nevera"});
            this.cmbTipoElectrodomestico.Location = new System.Drawing.Point(202, 73);
            this.cmbTipoElectrodomestico.Name = "cmbTipoElectrodomestico";
            this.cmbTipoElectrodomestico.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoElectrodomestico.TabIndex = 12;
            // 
            // txtElectroTiendNit
            // 
            this.txtElectroTiendNit.Location = new System.Drawing.Point(202, 217);
            this.txtElectroTiendNit.Name = "txtElectroTiendNit";
            this.txtElectroTiendNit.Size = new System.Drawing.Size(121, 20);
            this.txtElectroTiendNit.TabIndex = 13;
            // 
            // txtElectroPaisOrigen
            // 
            this.txtElectroPaisOrigen.Location = new System.Drawing.Point(202, 177);
            this.txtElectroPaisOrigen.Name = "txtElectroPaisOrigen";
            this.txtElectroPaisOrigen.Size = new System.Drawing.Size(121, 20);
            this.txtElectroPaisOrigen.TabIndex = 10;
            // 
            // txtElectroMarca
            // 
            this.txtElectroMarca.Location = new System.Drawing.Point(202, 140);
            this.txtElectroMarca.Name = "txtElectroMarca";
            this.txtElectroMarca.Size = new System.Drawing.Size(121, 20);
            this.txtElectroMarca.TabIndex = 9;
            // 
            // txtElectroAnioFabricacion
            // 
            this.txtElectroAnioFabricacion.Location = new System.Drawing.Point(202, 106);
            this.txtElectroAnioFabricacion.Name = "txtElectroAnioFabricacion";
            this.txtElectroAnioFabricacion.Size = new System.Drawing.Size(121, 20);
            this.txtElectroAnioFabricacion.TabIndex = 8;
            // 
            // txtElectroSerial
            // 
            this.txtElectroSerial.Location = new System.Drawing.Point(202, 40);
            this.txtElectroSerial.Name = "txtElectroSerial";
            this.txtElectroSerial.Size = new System.Drawing.Size(121, 20);
            this.txtElectroSerial.TabIndex = 6;
            // 
            // lbElectroNitTienda
            // 
            this.lbElectroNitTienda.AutoSize = true;
            this.lbElectroNitTienda.Location = new System.Drawing.Point(42, 220);
            this.lbElectroNitTienda.Name = "lbElectroNitTienda";
            this.lbElectroNitTienda.Size = new System.Drawing.Size(159, 13);
            this.lbElectroNitTienda.TabIndex = 5;
            this.lbElectroNitTienda.Text = "Tienda a la que pertenece (NIT)";
            // 
            // lbelectroPaisOrigen
            // 
            this.lbelectroPaisOrigen.AutoSize = true;
            this.lbelectroPaisOrigen.Location = new System.Drawing.Point(42, 185);
            this.lbelectroPaisOrigen.Name = "lbelectroPaisOrigen";
            this.lbelectroPaisOrigen.Size = new System.Drawing.Size(78, 13);
            this.lbelectroPaisOrigen.TabIndex = 4;
            this.lbelectroPaisOrigen.Text = "País de Origen";
            // 
            // lbElectroMarca
            // 
            this.lbElectroMarca.AutoSize = true;
            this.lbElectroMarca.Location = new System.Drawing.Point(42, 147);
            this.lbElectroMarca.Name = "lbElectroMarca";
            this.lbElectroMarca.Size = new System.Drawing.Size(37, 13);
            this.lbElectroMarca.TabIndex = 3;
            this.lbElectroMarca.Text = "Marca";
            // 
            // lbElectroFechaFabricacion
            // 
            this.lbElectroFechaFabricacion.AutoSize = true;
            this.lbElectroFechaFabricacion.Location = new System.Drawing.Point(42, 109);
            this.lbElectroFechaFabricacion.Name = "lbElectroFechaFabricacion";
            this.lbElectroFechaFabricacion.Size = new System.Drawing.Size(99, 13);
            this.lbElectroFechaFabricacion.TabIndex = 2;
            this.lbElectroFechaFabricacion.Text = "Año de Fabricación";
            // 
            // lbElectroTipo
            // 
            this.lbElectroTipo.AutoSize = true;
            this.lbElectroTipo.Location = new System.Drawing.Point(42, 73);
            this.lbElectroTipo.Name = "lbElectroTipo";
            this.lbElectroTipo.Size = new System.Drawing.Size(28, 13);
            this.lbElectroTipo.TabIndex = 1;
            this.lbElectroTipo.Text = "Tipo";
            // 
            // lbElectroSerial
            // 
            this.lbElectroSerial.AutoSize = true;
            this.lbElectroSerial.Location = new System.Drawing.Point(42, 40);
            this.lbElectroSerial.Name = "lbElectroSerial";
            this.lbElectroSerial.Size = new System.Drawing.Size(33, 13);
            this.lbElectroSerial.TabIndex = 0;
            this.lbElectroSerial.Text = "Serial";
            // 
            // tbpconsultarElectrodomesticos
            // 
            this.tbpconsultarElectrodomesticos.Controls.Add(this.btnConsultar);
            this.tbpconsultarElectrodomesticos.Controls.Add(this.txtConsultaNit);
            this.tbpconsultarElectrodomesticos.Controls.Add(this.lbConsultaNit);
            this.tbpconsultarElectrodomesticos.Controls.Add(this.dgConsulta);
            this.tbpconsultarElectrodomesticos.Location = new System.Drawing.Point(4, 22);
            this.tbpconsultarElectrodomesticos.Name = "tbpconsultarElectrodomesticos";
            this.tbpconsultarElectrodomesticos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpconsultarElectrodomesticos.Size = new System.Drawing.Size(722, 320);
            this.tbpconsultarElectrodomesticos.TabIndex = 2;
            this.tbpconsultarElectrodomesticos.Text = "Consultar Electrodomésticos";
            this.tbpconsultarElectrodomesticos.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(336, 282);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtConsultaNit
            // 
            this.txtConsultaNit.Location = new System.Drawing.Point(176, 18);
            this.txtConsultaNit.Name = "txtConsultaNit";
            this.txtConsultaNit.Size = new System.Drawing.Size(100, 20);
            this.txtConsultaNit.TabIndex = 2;
            // 
            // lbConsultaNit
            // 
            this.lbConsultaNit.AutoSize = true;
            this.lbConsultaNit.Location = new System.Drawing.Point(24, 21);
            this.lbConsultaNit.Name = "lbConsultaNit";
            this.lbConsultaNit.Size = new System.Drawing.Size(145, 13);
            this.lbConsultaNit.TabIndex = 1;
            this.lbConsultaNit.Text = "NIT de la Tienda a consultar:\r\n";
            // 
            // dgConsulta
            // 
            this.dgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsulta.Location = new System.Drawing.Point(24, 59);
            this.dgConsulta.Name = "dgConsulta";
            this.dgConsulta.Size = new System.Drawing.Size(664, 208);
            this.dgConsulta.TabIndex = 0;
            // 
            // tbpActializarDatosTienda
            // 
            this.tbpActializarDatosTienda.Controls.Add(this.btnActualizarTienda);
            this.tbpActializarDatosTienda.Controls.Add(this.btnBuscarTienda);
            this.tbpActializarDatosTienda.Controls.Add(this.label3);
            this.tbpActializarDatosTienda.Controls.Add(this.label2);
            this.tbpActializarDatosTienda.Controls.Add(this.label1);
            this.tbpActializarDatosTienda.Controls.Add(this.txtActFechaTienda);
            this.tbpActializarDatosTienda.Controls.Add(this.txtActNombreTienda);
            this.tbpActializarDatosTienda.Controls.Add(this.txtActNitTienda);
            this.tbpActializarDatosTienda.Location = new System.Drawing.Point(4, 22);
            this.tbpActializarDatosTienda.Name = "tbpActializarDatosTienda";
            this.tbpActializarDatosTienda.Padding = new System.Windows.Forms.Padding(3);
            this.tbpActializarDatosTienda.Size = new System.Drawing.Size(722, 320);
            this.tbpActializarDatosTienda.TabIndex = 3;
            this.tbpActializarDatosTienda.Text = "Actualizar Tienda";
            this.tbpActializarDatosTienda.UseVisualStyleBackColor = true;
            // 
            // btnActualizarTienda
            // 
            this.btnActualizarTienda.Enabled = false;
            this.btnActualizarTienda.Location = new System.Drawing.Point(319, 273);
            this.btnActualizarTienda.Name = "btnActualizarTienda";
            this.btnActualizarTienda.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarTienda.TabIndex = 7;
            this.btnActualizarTienda.Text = "Actualizar";
            this.btnActualizarTienda.UseVisualStyleBackColor = true;
            this.btnActualizarTienda.Click += new System.EventHandler(this.btnActualizarTienda_Click);
            // 
            // btnBuscarTienda
            // 
            this.btnBuscarTienda.Location = new System.Drawing.Point(319, 92);
            this.btnBuscarTienda.Name = "btnBuscarTienda";
            this.btnBuscarTienda.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarTienda.TabIndex = 6;
            this.btnBuscarTienda.Text = "Buscar";
            this.btnBuscarTienda.UseVisualStyleBackColor = true;
            this.btnBuscarTienda.Click += new System.EventHandler(this.btnBuscarTienda_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Creación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NIT";
            // 
            // txtActFechaTienda
            // 
            this.txtActFechaTienda.Enabled = false;
            this.txtActFechaTienda.Location = new System.Drawing.Point(305, 227);
            this.txtActFechaTienda.Name = "txtActFechaTienda";
            this.txtActFechaTienda.Size = new System.Drawing.Size(100, 20);
            this.txtActFechaTienda.TabIndex = 2;
            // 
            // txtActNombreTienda
            // 
            this.txtActNombreTienda.Enabled = false;
            this.txtActNombreTienda.Location = new System.Drawing.Point(305, 161);
            this.txtActNombreTienda.Name = "txtActNombreTienda";
            this.txtActNombreTienda.Size = new System.Drawing.Size(100, 20);
            this.txtActNombreTienda.TabIndex = 1;
            // 
            // txtActNitTienda
            // 
            this.txtActNitTienda.Location = new System.Drawing.Point(305, 36);
            this.txtActNitTienda.Name = "txtActNitTienda";
            this.txtActNitTienda.Size = new System.Drawing.Size(100, 20);
            this.txtActNitTienda.TabIndex = 0;
            // 
            // tbcActualizarElectrodomestico
            // 
            this.tbcActualizarElectrodomestico.Location = new System.Drawing.Point(4, 22);
            this.tbcActualizarElectrodomestico.Name = "tbcActualizarElectrodomestico";
            this.tbcActualizarElectrodomestico.Padding = new System.Windows.Forms.Padding(3);
            this.tbcActualizarElectrodomestico.Size = new System.Drawing.Size(722, 320);
            this.tbcActualizarElectrodomestico.TabIndex = 4;
            this.tbcActualizarElectrodomestico.Text = "Actualizar Electrodoméstico";
            this.tbcActualizarElectrodomestico.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcGestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tienda de Electrodomésticos";
            this.tbcGestion.ResumeLayout(false);
            this.tbpinsertarTienda.ResumeLayout(false);
            this.tbpinsertarTienda.PerformLayout();
            this.tbpinsertarElectrodomestico.ResumeLayout(false);
            this.tbpinsertarElectrodomestico.PerformLayout();
            this.tbpconsultarElectrodomesticos.ResumeLayout(false);
            this.tbpconsultarElectrodomesticos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsulta)).EndInit();
            this.tbpActializarDatosTienda.ResumeLayout(false);
            this.tbpActializarDatosTienda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcGestion;
        private System.Windows.Forms.TabPage tbpinsertarTienda;
        private System.Windows.Forms.TabPage tbpinsertarElectrodomestico;
        private System.Windows.Forms.TabPage tbpconsultarElectrodomesticos;
        private System.Windows.Forms.TextBox txtTiendaFechaCreacion;
        private System.Windows.Forms.TextBox txtTiendaNombre;
        private System.Windows.Forms.TextBox txtTiendaNit;
        private System.Windows.Forms.Label lbFechaCreacion;
        private System.Windows.Forms.Label lbNombreTienda;
        private System.Windows.Forms.Label lbNit;
        private System.Windows.Forms.TextBox txtElectroTiendNit;
        private System.Windows.Forms.TextBox txtElectroPaisOrigen;
        private System.Windows.Forms.TextBox txtElectroMarca;
        private System.Windows.Forms.TextBox txtElectroAnioFabricacion;
        private System.Windows.Forms.TextBox txtElectroSerial;
        private System.Windows.Forms.Label lbElectroNitTienda;
        private System.Windows.Forms.Label lbelectroPaisOrigen;
        private System.Windows.Forms.Label lbElectroMarca;
        private System.Windows.Forms.Label lbElectroFechaFabricacion;
        private System.Windows.Forms.Label lbElectroTipo;
        private System.Windows.Forms.Label lbElectroSerial;
        private System.Windows.Forms.DataGridView dgConsulta;
        private System.Windows.Forms.ComboBox cmbTipoElectrodomestico;
        private System.Windows.Forms.Button btnTiendaGuardar;
        private System.Windows.Forms.Button btnElectroGuardar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtConsultaNit;
        private System.Windows.Forms.Label lbConsultaNit;
        private System.Windows.Forms.TabPage tbpActializarDatosTienda;
        private System.Windows.Forms.Button btnActualizarTienda;
        private System.Windows.Forms.Button btnBuscarTienda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtActFechaTienda;
        private System.Windows.Forms.TextBox txtActNombreTienda;
        private System.Windows.Forms.TextBox txtActNitTienda;
        private System.Windows.Forms.TabPage tbcActualizarElectrodomestico;
    }
}

