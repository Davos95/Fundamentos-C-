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
    public partial class Form13ColeccionListBox : Form
    {
        public Form13ColeccionListBox()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string elemento = this.txtElemento.Text;
            this.lstElementos.Items.Add(elemento);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //La forma mas eficente normalmente es trabajar con indices en posiciones de colecciones/arays. Recuperamos el indice del elemento seleccionado de la lista

            //int indice = this.lstElementos.SelectedIndex;
            // this.lstElementos.Items.RemoveAt(indice);

            //Eliminamos los seleccionados con ferach indices seleccionados y removeAT de cada indice
            //Recorremos del último al primero
            for (int i = this.lstElementos.SelectedIndices.Count -1; i >=0 ; i--)
            {
                int j = this.lstElementos.SelectedIndices[i];
                this.lstElementos.Items.RemoveAt(j);
            }
            

        }

        private void btnLimipiar_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Lo primero que tenemos que averiguar es el tipo de objetos a reccorrer coleccion[0], esto nos dirá el tipo a recorrer
            foreach (object obj in this.lstElementos.Items)
            {
                this.lblMostrarTodos.Text += obj + "\n ";
            }
        }


        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            foreach (object obj in this.lstElementos.SelectedItems)
            {
                this.lblSeleccionados.Text += obj + " ";
            }
        }
    }
    
}
