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
namespace Fundamentos
{
    public partial class Form33PersonasFile : Form
    {
        List<Persona> personas;
        public Form33PersonasFile()
        {
            InitializeComponent();
            personas = new List<Persona>();
        }

        private void AddPersonas()
        {
            String nombre = this.txtNombre.Text;
            String apellidos = this.txtApellidos.Text;
            int edad = int.Parse(this.txtEdad.Text);
            Persona persona = new Persona(nombre,apellidos,edad);
            personas.Add(persona);
            this.lstPersonas.Items.Add(persona.Nombre);
        }

        private void CargarPersonas(String path)
        {
            this.personas.Clear();
            this.lstPersonas.Items.Clear();

            FileInfo f = new FileInfo(path);
            TextReader r = f.OpenText();
            String contenido = r.ReadToEnd();
            r.Close();

            String[] arrayDatos = contenido.Split('|');
            foreach (String datos in arrayDatos)
            {
                String[] d = datos.Split(';');
                Persona persona = new Persona(d[0], d[1],int.Parse(d[2]));
                personas.Add(persona);
                this.lstPersonas.Items.Add(d[0]);
            }
            String[] fichero = path.Split('\\');
            this.lblFichero.Text = "Fichero cargado: " + fichero[fichero.Length-1];
            this.Text = fichero[fichero.Length - 1];
        }
        private void GuardarPersonas(String path)
        {
            String datos = "";
            foreach (Persona p in this.personas )
            {
                datos += p.Nombre + ";" + p.Apellidos + ";" + p.Edad + "|";
            }
            datos = datos.TrimEnd('|');
            FileInfo f = new FileInfo(path);
            TextWriter w = f.CreateText();
            w.Write(datos);
            w.Flush();
            w.Close();
        }

        private void btnAddPersona_Click_1(object sender, EventArgs e)
        {
            AddPersonas();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Persona(*.per)|*.per";
            DialogResult respuesta = this.openFileDialog1.ShowDialog();
            if(respuesta == DialogResult.OK)
            {
                String path = this.openFileDialog1.FileName;
                CargarPersonas(path);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.Filter = "Persona(*.per)|*.per";
            DialogResult respuesta = this.saveFileDialog1.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                String path = this.saveFileDialog1.FileName;
                GuardarPersonas(path);
            }
        }

        private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstPersonas.SelectedIndex != -1)
            {
                int index = this.lstPersonas.SelectedIndex;
                this.txtNombre.Text = personas[index].Nombre;
                this.txtApellidos.Text = personas[index].Apellidos;
                this.txtEdad.Text = personas[index].Edad.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.lstPersonas.Items.Clear();
            personas.Clear();
        }
    }
}
