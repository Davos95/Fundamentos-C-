using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
namespace ProyectoClases
{
    public class ClaseImagen
    {
        public byte[] MiImagen { get; set; }
        //Hay que leer un fichero img de una ruta y convertirlo a byte[]
        //Para comprobar que funciona, mostrarlo en el picturebox

        public void setImagen(String ruta)
        {
            this.MiImagen = File.ReadAllBytes(ruta);
        }

        
    }
}
