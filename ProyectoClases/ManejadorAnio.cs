using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class ManejadorAnio
    {
        public List<Anio> anios;
        private ManejadorMeses tool;
        public ManejadorAnio()
        {
            anios = new List<Anio>();
        }

        #region METODOS

        public void GenerarAnios(int n)
        {
            anios.Clear();
            this.tool = new ManejadorMeses();
            for (int i = 0; i < n; i++)
            {
                Anio anio = new Anio(2000 + i);
                tool.GenerarMeses();
                anio.meses = new List<Mes>(tool.Meses);
                aniadirCaracteristicas(anio);
                anios.Add(anio);
                tool.Meses.Clear();
            }
        }

        private int getMaxTemp(Anio a)
        {
            int temp = 0;
            foreach (Mes m in a.meses)
            {
                if (temp < m.tMax)
                {
                    temp = m.tMax;
                }
            }
            return temp;
        }
        private int getMinTemp(Anio a)
        {
            int temp = 0;
            foreach (Mes m in a.meses)
            {
                if (temp > m.tMin)
                {
                    temp = m.tMin;
                }
            }
            return temp;
        }

        private void aniadirCaracteristicas(Anio a)
        {
            a.tMax = getMaxTemp(a);
            a.tMin = getMinTemp(a);
            a.Media = (a.tMax + a.tMin) / 2;
        }
        #endregion
        
    }
}
