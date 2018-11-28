using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form15ListaProductos : Form
    {
        public Form15ListaProductos()
        {
            InitializeComponent();
            this.btnBajar.Enabled = false;
            this.btnSubir.Enabled = false;
        }
        //Inserta un producto en la lista de Tienda
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (this.txtProducto.Text != "" && checkProduct())
            {
                this.lstTienda.Items.Add(this.txtProducto.Text);
            }            
        }

        //Comprueba si el producto existe
        private bool checkProduct()
        {
            foreach (string p in this.lstTienda.Items)
            {
                if (p == this.txtProducto.Text)
                {
                    return false;
                }
            }
            return true;
        }
        //Comprueba si el producto que está seleccionado existe en el almacen
        private bool checkAlmacen(string product)
        {
            foreach (string p in this.lstAlmacen.Items)
            {
                if (p == product)
                {
                    return false;
                }
            }
            return true;
        }
        //Elimina productos de la lista tienda
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarItemsTienda();
        }
        //Modifica UN producto seleccionado
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(this.lstTienda.SelectedItems.Count == 1 && checkProduct() && this.txtProducto.Text != "")
            {   
                string producto = this.txtProducto.Text;
                int i = this.lstTienda.SelectedIndex;
                this.lstTienda.Items[i] = producto;
            }
        }
        //Limpia la lista tienda
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }
        //Añade items seleccionados en la lista Almacen y despues los elimina 
        private void button5_Click(object sender, EventArgs e)
        {
            foreach (string p in this.lstTienda.SelectedItems)
            {
                if(checkAlmacen(p))
                {
                    this.lstAlmacen.Items.Add(p);
                }
            }
            eliminarItemsTienda();
        }
        //Elimina los items seleccionados de la lista tienda
        private void eliminarItemsTienda()
        {
            for (int i = this.lstTienda.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int j = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(j);
            }
        }
        // Pasa todos los items de la tienda al almacen y comprueba si esos items existe en el almacen o no
        private void btnPasarTodos_Click(object sender, EventArgs e)
        {
            foreach(string p in this.lstTienda.Items)
            {
                if(checkAlmacen(p))
                {
                    this.lstAlmacen.Items.Add(p);
                }
            }
            this.lstTienda.Items.Clear();
        }
        //Sube el item del almacen
        private void btnSubir_Click(object sender, EventArgs e)
        {

            //string product2 = this.lstAlmacen.Items[i - 1].ToString();
            //this.lstAlmacen.Items[i] = product2;
            //this.lstAlmacen.Items[i - 1] = product;

            int i = this.lstAlmacen.SelectedIndex;
            string product = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(i);
            this.lstAlmacen.Items.Insert(i - 1, product);
            this.lstAlmacen.SetSelected(i - 1, true);
        }
        //Activa y desactiva los botones de subir y bajar segun el item seleccionado
        private void lstAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {   
            if(this.lstAlmacen.SelectedIndex > 0) {
                this.btnSubir.Enabled = true;
            } else
            {
                this.btnSubir.Enabled = false;
            }
            if(this.lstAlmacen.SelectedIndex < this.lstAlmacen.Items.Count -1)
            {
                this.btnBajar.Enabled = true;
            } else
            {
                this.btnBajar.Enabled = false;
            }
        }
        //Baja el item seleccionado
        private void btnBajar_Click(object sender, EventArgs e)
        {
            int i = this.lstAlmacen.SelectedIndex;
            string product = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(i);
            this.lstAlmacen.Items.Insert(i + 1, product);
            //string product2 = this.lstAlmacen.Items[i + 1].ToString();
            //this.lstAlmacen.Items[i] = product2;
            //this.lstAlmacen.Items[i+1] = product;
            this.lstAlmacen.SetSelected(i + 1, true);
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char enter = (char)Keys.Enter;
            if(e.KeyChar == enter && checkProduct())
            {
                this.lstTienda.Items.Add(this.txtProducto.Text);
                this.txtProducto.Text = "";
            }
        }
    }
}
