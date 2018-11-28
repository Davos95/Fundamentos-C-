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
using ProyectoClases;
using System.Diagnostics;

namespace Fundamentos
{
    public partial class Form36SerializarImagen : Form
    {
        ClaseImagen imagen;
        public Form36SerializarImagen()
        {
            InitializeComponent();
            imagen = new ClaseImagen();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                String path = this.openFileDialog1.FileName;
                imagen.MiImagen = File.ReadAllBytes(path);

                var ms = new MemoryStream(imagen.MiImagen);
                this.pbImagen.Image = Image.FromStream(ms);

            }
        }
    }
}
