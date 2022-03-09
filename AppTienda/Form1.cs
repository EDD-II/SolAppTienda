using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppTienda.logica;

namespace AppTienda
{
    public partial class Form1 : Form
    {
        Electrodomestico elec = new Electrodomestico();
        Tienda tien = new Tienda();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnElectroGuardar_Click(object sender, EventArgs e)
        {
            switch (validarDatosElectro())
            {
                case 1:
                    {
                        MessageBox.Show("Debe llenar todos los campos requeridos para el registro", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Datos ingresados erroneos, por favor verifique", "Datos Erroneos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                default:
                    {
                        int r;
                        elec.ElecSerial = int.Parse(txtElectroSerial.Text);
                        elec.TienNit = int.Parse(txtElectroTiendNit.Text);
                        elec.ElectTipo = cmbTipoElectrodomestico.SelectedItem.ToString();
                        elec.ElectAnioFabricacion = txtElectroAnioFabricacion.Text;
                        elec.ElectMarca = txtElectroMarca.Text;
                        elec.ElectPaisOrigen = txtElectroPaisOrigen.Text;
                        r = elec.insertarElectrodomestico();
                        if (r>0)
                        {
                            MessageBox.Show("Electrodomestico registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtElectroSerial.Clear();
                            cmbTipoElectrodomestico.ResetText();
                            txtElectroMarca.Clear();
                            txtElectroPaisOrigen.Clear();
                            txtElectroAnioFabricacion.Clear();
                            txtElectroTiendNit.Clear();
                        }else
                            MessageBox.Show("Electrodomestico no registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }

        }

        private void btnTiendaGuardar_Click(object sender, EventArgs e)
        {
            switch (validarDatosTienda())
            {
                case 1:
                    {
                        MessageBox.Show("Debe llenar todos los campos requeridos para el registro", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Datos ingresados erroneos, por favor verifique", "Datos Erroneos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                default:
                    {
                        int r;
                        tien.TienNit = int.Parse(txtTiendaNit.Text);
                        tien.TienNombre = txtTiendaNombre.Text;
                        tien.TienFechaCreacion = txtTiendaFechaCreacion.Text;
                        r=tien.insertarTienda();
                        if (r > 0)
                        {
                            MessageBox.Show("Tienda registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtTiendaNit.Clear();
                            txtTiendaNombre.Clear();
                            txtTiendaFechaCreacion.Clear();
                        }
                        else
                            MessageBox.Show("Tienda no registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);                    }
                    break;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = elec.consultarElectrodomestico(int.Parse(txtElectroTiendNit.Text));
            if(ds.Tables[0].Rows.Count > 0)
            {
                dgConsulta.DataSource = ds;
                dgConsulta.DataMember = "ResultadoDatos";
            }
            else
            {
                MessageBox.Show("El electrodoméstico no se encuentra registrado", "Mensaje", MessageBoxButtons.OK);
            }
        }

        int validarDatosTienda()
        {
            if (txtTiendaNit.Text.Trim() == "" || txtTiendaNombre.Text.Trim() == "" || txtTiendaFechaCreacion.Text.Trim() == "")
            {
                return 1;
            }
            if (!(txtTiendaNit.Text.All(char.IsDigit)) || !(txtTiendaNombre.Text.All(char.IsLetter)))
            {
                return 2;
            }
            //if (atrGestor.esValido(textRegistroCivil.Text, atrTabla))//pregunta si esta repetido
            //{
            //    return 3;
            //}
            //btnTiendaGuardar.Enabled = true;
            return 0;
        }
        int validarDatosElectro()
        {
            if (txtElectroSerial.Text.Trim() == "" || cmbTipoElectrodomestico.Text == string.Empty || txtElectroAnioFabricacion.Text.Trim() == "" || txtElectroMarca.Text.Trim() == "" || txtElectroPaisOrigen.Text.Trim() == "" || txtElectroTiendNit.Text.Trim() == "")
            {
                return 1;
            }
            if (!(txtElectroSerial.Text.All(char.IsDigit)) || !(txtElectroAnioFabricacion.Text.All(char.IsDigit)) || !(txtElectroMarca.Text.All(char.IsLetter)) || !(txtElectroPaisOrigen.Text.All(char.IsLetter)) || !(txtElectroTiendNit.Text.All(char.IsDigit)))
            {
                return 2;
            }
            //if (atrGestor.esValido(textRegistroCivil.Text, atrTabla))//pregunta si esta repetido
            //{
            //    return 3;
            //}
            //btnElectroGuardar.Enabled = true;
            return 0;
        }
    }
}
