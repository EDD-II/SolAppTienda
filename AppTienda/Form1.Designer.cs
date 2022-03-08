
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtElectroPaisOrigen = new System.Windows.Forms.TextBox();
            this.txtElectroMarca = new System.Windows.Forms.TextBox();
            this.txtElectroFechaFabricacion = new System.Windows.Forms.TextBox();
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
            this.tbcGestion.SuspendLayout();
            this.tbpinsertarTienda.SuspendLayout();
            this.tbpinsertarElectrodomestico.SuspendLayout();
            this.tbpconsultarElectrodomesticos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcGestion
            // 
            this.tbcGestion.Controls.Add(this.tbpinsertarTienda);
            this.tbcGestion.Controls.Add(this.tbpinsertarElectrodomestico);
            this.tbcGestion.Controls.Add(this.tbpconsultarElectrodomesticos);
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
            this.btnTiendaGuardar.Location = new System.Drawing.Point(374, 241);
            this.btnTiendaGuardar.Name = "btnTiendaGuardar";
            this.btnTiendaGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnTiendaGuardar.TabIndex = 14;
            this.btnTiendaGuardar.Text = "Guardar";
            this.btnTiendaGuardar.UseVisualStyleBackColor = true;
            // 
            // txtTiendaFechaCreacion
            // 
            this.txtTiendaFechaCreacion.Location = new System.Drawing.Point(162, 152);
            this.txtTiendaFechaCreacion.Name = "txtTiendaFechaCreacion";
            this.txtTiendaFechaCreacion.Size = new System.Drawing.Size(100, 20);
            this.txtTiendaFechaCreacion.TabIndex = 5;
            // 
            // txtTiendaNombre
            // 
            this.txtTiendaNombre.Location = new System.Drawing.Point(162, 102);
            this.txtTiendaNombre.Name = "txtTiendaNombre";
            this.txtTiendaNombre.Size = new System.Drawing.Size(100, 20);
            this.txtTiendaNombre.TabIndex = 4;
            // 
            // txtTiendaNit
            // 
            this.txtTiendaNit.Location = new System.Drawing.Point(162, 52);
            this.txtTiendaNit.Name = "txtTiendaNit";
            this.txtTiendaNit.Size = new System.Drawing.Size(100, 20);
            this.txtTiendaNit.TabIndex = 3;
            // 
            // lbFechaCreacion
            // 
            this.lbFechaCreacion.AutoSize = true;
            this.lbFechaCreacion.Location = new System.Drawing.Point(42, 160);
            this.lbFechaCreacion.Name = "lbFechaCreacion";
            this.lbFechaCreacion.Size = new System.Drawing.Size(100, 13);
            this.lbFechaCreacion.TabIndex = 2;
            this.lbFechaCreacion.Text = "Fecha de Creación ";
            // 
            // lbNombreTienda
            // 
            this.lbNombreTienda.AutoSize = true;
            this.lbNombreTienda.Location = new System.Drawing.Point(42, 110);
            this.lbNombreTienda.Name = "lbNombreTienda";
            this.lbNombreTienda.Size = new System.Drawing.Size(44, 13);
            this.lbNombreTienda.TabIndex = 1;
            this.lbNombreTienda.Text = "Nombre";
            // 
            // lbNit
            // 
            this.lbNit.AutoSize = true;
            this.lbNit.Location = new System.Drawing.Point(42, 60);
            this.lbNit.Name = "lbNit";
            this.lbNit.Size = new System.Drawing.Size(25, 13);
            this.lbNit.TabIndex = 0;
            this.lbNit.Text = "NIT";
            // 
            // tbpinsertarElectrodomestico
            // 
            this.tbpinsertarElectrodomestico.Controls.Add(this.btnElectroGuardar);
            this.tbpinsertarElectrodomestico.Controls.Add(this.comboBox1);
            this.tbpinsertarElectrodomestico.Controls.Add(this.textBox6);
            this.tbpinsertarElectrodomestico.Controls.Add(this.txtElectroPaisOrigen);
            this.tbpinsertarElectrodomestico.Controls.Add(this.txtElectroMarca);
            this.tbpinsertarElectrodomestico.Controls.Add(this.txtElectroFechaFabricacion);
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
            this.btnElectroGuardar.Location = new System.Drawing.Point(374, 241);
            this.btnElectroGuardar.Name = "btnElectroGuardar";
            this.btnElectroGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnElectroGuardar.TabIndex = 13;
            this.btnElectroGuardar.Text = "Guardar";
            this.btnElectroGuardar.UseVisualStyleBackColor = true;
            this.btnElectroGuardar.Click += new System.EventHandler(this.btnElectroGuardar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "televisor",
            "lavadora",
            "nevera"});
            this.comboBox1.Location = new System.Drawing.Point(202, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(202, 212);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 20);
            this.textBox6.TabIndex = 11;
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
            // txtElectroFechaFabricacion
            // 
            this.txtElectroFechaFabricacion.Location = new System.Drawing.Point(202, 106);
            this.txtElectroFechaFabricacion.Name = "txtElectroFechaFabricacion";
            this.txtElectroFechaFabricacion.Size = new System.Drawing.Size(121, 20);
            this.txtElectroFechaFabricacion.TabIndex = 8;
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
            this.lbElectroNitTienda.Size = new System.Drawing.Size(132, 13);
            this.lbElectroNitTienda.TabIndex = 5;
            this.lbElectroNitTienda.Text = "Tienda a la que pertenece";
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
            this.lbElectroFechaFabricacion.Size = new System.Drawing.Size(110, 13);
            this.lbElectroFechaFabricacion.TabIndex = 2;
            this.lbElectroFechaFabricacion.Text = "Fecha de Fabricación";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcGestion);
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
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtElectroPaisOrigen;
        private System.Windows.Forms.TextBox txtElectroMarca;
        private System.Windows.Forms.TextBox txtElectroFechaFabricacion;
        private System.Windows.Forms.TextBox txtElectroSerial;
        private System.Windows.Forms.Label lbElectroNitTienda;
        private System.Windows.Forms.Label lbelectroPaisOrigen;
        private System.Windows.Forms.Label lbElectroMarca;
        private System.Windows.Forms.Label lbElectroFechaFabricacion;
        private System.Windows.Forms.Label lbElectroTipo;
        private System.Windows.Forms.Label lbElectroSerial;
        private System.Windows.Forms.DataGridView dgConsulta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnTiendaGuardar;
        private System.Windows.Forms.Button btnElectroGuardar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtConsultaNit;
        private System.Windows.Forms.Label lbConsultaNit;
    }
}

