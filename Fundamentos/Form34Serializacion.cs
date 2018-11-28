using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ProyectoClases;
using System.IO;

namespace Fundamentos
{
    public partial class Form34Serializacion : Form
    {
        //Vamos a usar un objeto serializacion en los metodos (guardar y listar), por eso lo declaramos a nivel de clase
        //En la instancia del objeto debemos indicar al serializador que clase vamos a utiliar

        XmlSerializer serializer;
        String ruta = "persona.txt";
        public Form34Serializacion()
        {
            InitializeComponent();
            //Instanciamos el objeto indicando la clase a utilizar
            this.serializer = new XmlSerializer(typeof(Personaje));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //El objeto serializer utiliza ficheros para almacenar objetos
            //Podemos instanciarlas con una Ruta
            //Creamos un escritor
            StreamWriter writer = new StreamWriter(ruta);
            Personaje person = new Personaje();
            person.Nombre = this.txtNombre.Text;
            person.Apellidos = this.txtApellidos.Text;
            person.Edad = int.Parse(this.txtEdad.Text);
            //Utilizamos el objeto Serial indicando el archivo donde escribimos (writer) y el objeto a escribir (personaje)

            this.serializer.Serialize(writer, person);
            writer.Flush();
            writer.Close();
            this.lblAccion.Text = "Guardado";
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(ruta);
            //Aquí no instanciamos una persona, recuperamos la persona con su forma desde el fichero de serialización
            Personaje person = (Personaje)this.serializer.Deserialize(reader);
            reader.Close();
            this.lblAccion.Text = "Fichero leido";
            this.txtApellidos.Text = person.Apellidos;
            this.txtNombre.Text = person.Nombre;
            this.txtEdad.Text = person.Edad.ToString();
        }

    }
}
