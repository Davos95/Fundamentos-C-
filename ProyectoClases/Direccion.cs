using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Direccion
    {
        //Calle, ciudad, codigo postal
        //No queremos comprobar nada, solamente crear propiedades.
        //Propiedades autoimplementadas
        //Una autoimplementada no utiliza campo
        //Nosotros no declaramos un campo
        //Dentro del lenguaje se crea un campo (ni lo veo)
        #region PROPIEDADES

        public String Calle { get; set; }
        public String Ciudad { get; set; }
        public int CodigoPostal { get; set; }
        #endregion

        //Propiedad autoImplementada
        public Direccion Domicilio { get; set; }

        //Metodo que devuelva la descripcion de la direccion

        public String GetDescipcion()
        {
            return this.Calle + ", " + this.Ciudad + ", " + this.CodigoPostal;
        }
    }
}
