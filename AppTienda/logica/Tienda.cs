using AppTienda.accesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.logica
{
    public class Tienda
    {
        private int tienNit;
        private string tienNombre;
        private string tienFechaCreacion;
        private Datos dt = new Datos();
        public Tienda()
        {

        }

        public Tienda(int tienNit, string tienNombre, string tienFechaCreacion)
        {
            this.TienNit = tienNit;
            this.TienNombre = tienNombre;
            this.TienFechaCreacion = tienFechaCreacion;
        }
        #region getters and setters
        public int TienNit { get => tienNit; set => tienNit = value; }
        public string TienNombre { get => tienNombre; set => tienNombre = value; }
        public string TienFechaCreacion { get => tienFechaCreacion; set => tienFechaCreacion = value; }
        #endregion
        public int insertarTienda()
        {
            int resultado;
            string consulta = "insert into Tienda(tienNit,tienNombre,tienFechaCreacion) values("+
                                tienNit+",'"+tienNombre+ "',to_date('" + tienFechaCreacion+ "','dd/mm/yyyy'))";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
    }
}
