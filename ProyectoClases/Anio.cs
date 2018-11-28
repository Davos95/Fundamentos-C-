using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Anio
    {
        #region ATRIBUTOS

        public int anio { get; set; }
        public double tMax { get; set; }
        public double tMin { get; set; }

        public double Media { get; set; }

        public List<Mes> meses;

        private ManejadorMeses tool;
        #endregion

        #region CONSTRUCTOR
        public Anio ()
        {
            this.anio = 2000;
            this.meses = new List<Mes>();

            this.tool = new ManejadorMeses();
            this.tool.GenerarMeses();
            this.meses = this.tool.Meses;
        }
        public Anio(int a)
        {
            this.anio = a;
        }

        #endregion


    }
}
