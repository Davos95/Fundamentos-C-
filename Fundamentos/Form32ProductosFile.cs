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
    public partial class Form32ProductosFile : Form
    {
        List<Producto> productos;
        public Form32ProductosFile()
        {
            InitializeComponent();
            this.productos = new List<Producto>();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            String nom = this.txtNuevoProducto.Text;
            double prec = double.Parse(this.txtPrecio.Text);
            Producto p = new Producto();
            p.Nombre = nom;
            p.Precio = prec;
            this.productos.Add(p);
            this.lstProductos.Items.Add(p.Nombre);

        }
        private void RecuperarProductos(String path)
        {
            //Necesitamos leer todo el contenido del fichero y pasar a objeto producto y a colección
            this.lstProductos.Items.Clear();
            this.productos.Clear();
            FileInfo f = new FileInfo(path);
            TextReader r = f.OpenText();
            String contenido = r.ReadToEnd();
            r.Close();

            String[] strProductos = contenido.Split('&');
            foreach (String p in strProductos)
            {
                String[] propiedades = p.Split('@');
                Producto prod = new Producto();
                prod.Nombre = propiedades[0];
                prod.Precio = double.Parse(propiedades[1]);
                this.productos.Add(prod);
            }

        }
        private void PintarProductos()
        {
            this.lstProductos.Items.Clear();
            foreach (Producto p in this.productos)
            {
                this.lstProductos.Items.Add(p.Nombre);
            }

        }
        private void GuardarProductos(String path)
        {
            String datos = "";
            foreach (Producto p in productos)
            {
                //Separamos sus propiedades con @
                String textoproducto = p.Nombre + "@" + p.Precio;
                //Cada producto lo separamos con &
                datos += textoproducto + "&";

            }
            datos = datos.TrimEnd('&');
            FileInfo f = new FileInfo(path);
            TextWriter w = f.CreateText();
            w.Write(datos);
            w.Flush();
            w.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Productos(*.pro)|*.pro";
            DialogResult respuesta = this.openFileDialog1.ShowDialog();
            if(respuesta == DialogResult.OK)
            {
                String path = this.openFileDialog1.FileName;
                this.RecuperarProductos(path);
                this.PintarProductos();
                /*
                FileInfo f = new FileInfo(path);
                TextReader reader = f.OpenText();
                String textProducto = reader.ReadToEnd();
                reader.Close();

                //Debemos transformar el texto a producto
                Producto pro = new Producto();
                //NOMBRE@PRECIO
                //Vamos a Crearnos un array donde utilizando el metodo split de string nos devuelve objetos en cada indice por un separador

                String[] datosProducto = textProducto.Split('@');
                pro.Nombre = datosProducto[0];
                pro.Precio = double.Parse(datosProducto[1]);
                //Ya hemos transformado los datos del fichero a objeto
                this.txtNuevoProducto.Text = pro.Nombre;
                this.txtPrecio.Text = pro.Precio.ToString();
                */
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.Filter = "Producto(*.pro)|*.pro";
            DialogResult respuesta = this.saveFileDialog1.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                String path = this.saveFileDialog1.FileName;
                GuardarProductos(path);
            }
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstProductos.SelectedIndex != -1)
            {
                
            }
        }
    }
}
