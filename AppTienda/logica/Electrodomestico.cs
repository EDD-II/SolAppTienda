using AppTienda.accesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.logica
{
    public class Electrodomestico
    {
        private int elecSerial;
        private int tienNit;
        private string elecTipo;
        private string elecAnioFabricacion;
        private string elecMarca;
        private string elecPaisOrigen;
        private Datos dt = new Datos();
        public Electrodomestico()
        {

        }
        public Electrodomestico(int elecSerial, int tienNit, string electTipo, string electAnioFabricacion, string electMarca, string electPaisOrigen)
        {
            this.ElecSerial = elecSerial;
            this.TienNit = tienNit;
            this.ElectTipo = electTipo;
            this.ElectAnioFabricacion = electAnioFabricacion;
            this.ElectMarca = electMarca;
            this.ElectPaisOrigen = electPaisOrigen;
        }
        #region getters and setters
        public int ElecSerial { get => elecSerial; set => elecSerial = value; }
        public int TienNit { get => tienNit; set => tienNit = value; }
        public string ElectTipo { get => elecTipo; set => elecTipo = value; }
        public string ElectAnioFabricacion { get => elecAnioFabricacion; set => elecAnioFabricacion = value; }
        public string ElectMarca { get => elecMarca; set => elecMarca = value; }
        public string ElectPaisOrigen { get => elecPaisOrigen; set => elecPaisOrigen = value; }
        #endregion
        public int insertarElectrodomestico()
        {
            int resultado;
            string consulta = "insert into Electrodomestico(elecSerial,tienNit,elecTipo,elecAnioFabricacion,electPaisOrigen) value("+
                elecSerial+","+tienNit+",'"+elecAnioFabricacion+"','"+elecMarca+"','"+elecPaisOrigen+"'";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
        public DataSet consultarElectrodomestico(int prmtinNit)
        {
            DataSet miDS = new DataSet();
            string consulta;
            consulta = "select elecSerial serial,tienNit Nit,elecTipo Tipo ,elecAnioFabricacion año,elecMarca marca,elecPaisOrigen pais " + "" +
                      "from Electrodomestico " +
                      "where tienNit = " + prmtinNit;

            miDS = dt.ejecutarSELECT(consulta);
            return miDS; 
        }
    }
}
