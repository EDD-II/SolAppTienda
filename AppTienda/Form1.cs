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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnElectroGuardar_Click(object sender, EventArgs e)
        {
            int r;
            elec.ElecSerial = int.Parse(txtElectroSerial.Text);
            //elec.TienNit = int.Parse()
        }

        private void btnTiendaGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
