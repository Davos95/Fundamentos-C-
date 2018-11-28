using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Fundamentos
{
    public partial class Form31LeerFicheros : Form
    {
        public Form31LeerFicheros()
        {
            InitializeComponent();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = this.saveFileDialog1.ShowDialog();
            if(respuesta == DialogResult.OK)
            {
                String path = this.saveFileDialog1.FileName;
                FileInfo fileInfo = new FileInfo(path);
                TextWriter writer = fileInfo.CreateText();
                String contenido = this.txtFichero.Text;
                //Podemos indicar que escriba de forma asincrona
                //En determinadas clases, existen los metodos Async()

                await writer.WriteAsync(contenido);
                    
                //Cuando escribimos en ficheros debemos liberar la memoria para indicar al sistema que hemos finalizado
                writer.Flush();
                //Cerramos el fichero
                writer.Close();
                this.label2.Text = "Fichero almacenado";
                this.txtFichero.Clear();
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Primero necesitamos el archivo que vamos a leer

            
            //StringReader lector = new StringReader();

            //TextReader lector = new FileStream("path",)
            DialogResult respuesta = this.openFileDialog1.ShowDialog();
            if(respuesta == DialogResult.OK)
            {
                //Capturamos la ruta del fichero seleccionado
                String path = this.openFileDialog1.FileName;
                this.label2.Text = path;
                //Necesitamos un lector
                FileInfo file = new FileInfo(path);
                using(TextReader reader = file.OpenText())
                {
                    //reader.Dispose(); elimina el objeto
                    String contenido = reader.ReadToEnd();
                    this.txtFichero.Text = contenido;
                }
                
                
                this.label2.Text = "Archivo cargado";
            }

        }
    }
}
