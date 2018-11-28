using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;
using System.IO;
using System.Xml.Serialization;

namespace Fundamentos
{
    public partial class Form35SerializacionPersonajes : Form
    {
        XmlSerializer serializer;
        String path;
        Personajes personajes;
        ClaseImagen imagen;
        public Form35SerializacionPersonajes()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(Personajes));
            this.personajes = new Personajes();
            this.path = "personajes.txt";
            imagen = new ClaseImagen();
        }

        private void btnAddPersona_Click(object sender, EventArgs e)
        {
            Personaje person = new Personaje();
            person.Nombre = this.txtNombre.Text;
            person.Apellidos = this.txtApellidos.Text;
            person.Edad = int.Parse(this.txtEdad.Text);
            person.imagen = (byte[])imagen.MiImagen.Clone();
            //Array.Copy(imagen.MiImagen, person.imagen,imagen.MiImagen.Length);
            this.personajes.Add(person);
            this.PintarPersonajes();
            Array.Clear(imagen.MiImagen, 0, imagen.MiImagen.Length);
        }
        private void PintarPersonajes()
        {
            this.lstPersonas.Items.Clear();
            foreach (Personaje p in personajes)
            {
                this.lstPersonas.Items.Add(p.ToString());
            }
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            this.personajes.Clear();
            StreamReader reader = new StreamReader(this.path);
            this.personajes = (Personajes)this.serializer.Deserialize(reader);
            reader.Close();
            this.PintarPersonajes();
            this.lblAccion.Text = "Cargado";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(this.path);
            this.serializer.Serialize(writer, this.personajes);
            writer.Flush();
            writer.Close();
            this.lblAccion.Text = "Guardado";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.lstPersonas.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = this.lstPersonas.SelectedIndex;
            this.lblAccion.Text = this.personajes[index].ToString() + " Eliminado";
            this.personajes.Remove(this.personajes[index]);
            this.PintarPersonajes();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int index = this.lstPersonas.SelectedIndex;
            Personaje person = this.personajes[index];
            this.lblAccion.Text = this.personajes[index].ToString() + " Modificado";
            person.Nombre = this.txtNombre.Text;
            person.Apellidos = this.txtApellidos.Text;
            person.Edad = int.Parse(this.txtEdad.Text);
            person.imagen = imagen.MiImagen;
            this.pic1.Image = GetImage(imagen.MiImagen);
            this.PintarPersonajes();
        }

        private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstPersonas.SelectedIndex;
            Personaje person = this.personajes[index];
            this.txtNombre.Text = person.Nombre;
            this.txtApellidos.Text = person.Apellidos;
            this.txtEdad.Text = person.Edad.ToString();

            if(person.imagen != null)
            {
                this.pic1.Image = GetImage(person.imagen);
                imagen.MiImagen = person.imagen;
            } else
            {
                this.pic1.Image = null;
            }
            
        }
        
        private void btnImagen_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = this.openFileDialog1.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                String path = openFileDialog1.FileName;
                imagen.setImagen(path);
            }
        }

        private Image GetImage(byte[] imagen)
        {
            var ms = new MemoryStream(imagen);
            return Image.FromStream(ms);
        }

    }
}
