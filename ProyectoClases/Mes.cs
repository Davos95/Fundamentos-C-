using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public enum NombreMes
    {
        Enero = 0, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Nombiembre, Diciembre
    }
    public class Mes
    {
        #region ATRIBUTOS

        private String _nombre;
        private int _tMax;
        private int _tMin;
        public String nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public int tMax
        {
            get { return this._tMax; }
            set { this._tMax = value; }
        }

        public int tMin
        {
            get { return this._tMin; }
            set { this._tMin = value; }
        }

        #endregion


        #region CONSTRUCTOR
        public Mes()
        {
            this._nombre = "Enero";
            this._tMax = 18;
            this._tMin = -2;
        }

        public Mes(NombreMes i, int TMax, int TMin)
        {
            //this._nombre = i;
            this._tMax = TMax;
            this._tMin = TMin;
        }

        #endregion

        #region METODOS
        public int getMedia()
        {
            ///Devuelve un int con la media de la temperatura
            return (this.tMax + this.tMin) / 2;
        }
        #endregion

    }
}
