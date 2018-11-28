using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
   public class Personaje
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public byte[] imagen { get; set; }
        public override string ToString()
        {
            return this.Nombre + " " + this.Apellidos;
        }
    }
}
