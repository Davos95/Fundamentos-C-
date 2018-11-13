using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Fundamentos
{
    public partial class Form12StringBuilder : Form
    {
        public Form12StringBuilder()
        {
            InitializeComponent();
            //Existe una coleccion de la clase contro que contiene todos 
            //los controles del formulario .crontrols, 
            //quieres cambiar el color de cada control

            //int[] numero = new int[] {22, 33, 44 };
            ////Quiero sumar uno a cada numero
            //foreach (int num in numero)
            //{
            //    MessageBox.Show((num + 1).ToString());
            //}

            //foreach (Control c in this.Controls)
            //{
            //    c.BackColor = Color.Yellow;
            //}
            //foreach (Form f in this.MdiChildren)
            //{

            //}
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            //Mi forma
            /*
            string cadena = this.txtTexto.Text;
            string cadenaInvertida = "";
            for (int i = cadena.Length - 1; i >= 0 ; i--)
            {
                cadenaInvertida += cadena.Insert(i, cadena);
            }
            
            this.txtTexto.Text = cadenaInvertida;
            */

            string cadena = this.txtTexto.Text;
            Stopwatch krono = new Stopwatch();
            krono.Start();
            for (int i = 0; i < cadena.Length; i++)
            {
                //Recuperamos la ultima letra del texto
                char letra = cadena[cadena.Length - 1];
                //eliminamos la ultima letra
                cadena = cadena.Remove(cadena.Length - 1);
                //Insertamos la letra en la posición del contador 1
                cadena = cadena.Insert(i, letra.ToString());

            }
            krono.Stop();
            this.lblTiempo.Text = "Segundos: " + krono.Elapsed.Seconds + "\n Milisegundos: " + krono.Elapsed.Milliseconds;
            this.txtTexto.Text = cadena;


        }

        private void btnStringBuilder_Click(object sender, EventArgs e)
        {
            StringBuilder cadena = new StringBuilder();
            cadena.Append(this.txtTexto.Text);
            Stopwatch krono = new Stopwatch();
            krono.Start();
            for (int i = 0; i < cadena.Length; i++)
            {
                char letra = cadena[cadena.Length - 1];
                cadena = cadena.Remove(cadena.Length - 1, 1);
                cadena = cadena.Insert(i, letra);
            }
            krono.Stop();
            this.lblTiempo.Text = "Segundos: " + krono.Elapsed.Seconds + "\n Milisegundos: " + krono.Elapsed.Milliseconds;
            this.txtTexto.Text = cadena.ToString();
        }
    }
}
