﻿using System;
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
            int r;
            elec.ElecSerial = int.Parse(txtElectroSerial.Text);
            elec.TienNit = int.Parse(txtElectroTiendNit.Text);
            elec.ElectTipo = cmbTipoElectrodomestico.SelectedItem.ToString();
            elec.ElectAnioFabricacion = txtElectroFechaFabricacion.Text;
            elec.ElectMarca = txtElectroMarca.Text;
            elec.ElectPaisOrigen = txtElectroPaisOrigen.Text;
            r = elec.insertarElectrodomestico();
            if (r>0)
            {
                MessageBox.Show("Electrodomestico registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
                MessageBox.Show("Electrodomestico no registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnTiendaGuardar_Click(object sender, EventArgs e)
        {
            int r;
            tien.TienNit = int.Parse(txtTiendaNit.Text);
            tien.TienNombre = txtTiendaNombre.Text;
            tien.TienFechaCreacion = txtTiendaFechaCreacion.Text;
            r=tien.insertarTienda();
            if (r > 0)
            {
                MessageBox.Show("Tienda registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Tienda no registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
