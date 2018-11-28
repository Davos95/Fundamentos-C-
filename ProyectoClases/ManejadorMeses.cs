using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class ManejadorMeses
    {
        //Mecesitamos manejar un conjunto de meses
        //Quien utilice esta clase, necesita los meses?
        public List<Mes> Meses { get; set; }
        private Random rand;
        public ManejadorMeses()
        {
            this.Meses = new List<Mes>();
            this.rand = new Random();
        }

        //Podriamos tene un metodo que nos devuelva el nombre del mes, segun su posicion 
        //este método es para mi clase o para quien la utiliza?
        private String GetNombreMes(int posicion)
        {
            DateTime fecha = DateTime.Parse("01/" + posicion + "/2018");
            String nombreMes = fecha.ToString("MMMM");
            return nombreMes;
        }



        //Necesitamos un metodo para generar 12 Meses
        //Quien utiliza este metodo?
        public void GenerarMeses()
        {
            this.Meses.Clear();
            for (int i = 1; i <= 12; i++)
            {
                Mes month = new Mes();
                month.nombre = this.GetNombreMes(i);
                month.tMax = rand.Next(10, 42);
                month.tMin = rand.Next(-10, 9);
                this.Meses.Add(month);
            }
        }


    }
}
