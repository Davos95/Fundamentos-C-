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
    public partial class Form19MetodosDelegados : Form
    {
        public Form19MetodosDelegados()
        {
            InitializeComponent();
            //Aquí asociamos el evento a un control
            //Queremos que un boton lea el metodo mostrarMensaje()
            this.button1.Click += MostrarMensaje;
            //Podemos delegar varias veces la misma funcion
            this.button1.Click += MostrarMensaje;
            this.button1.Click += MostrarMensaje;

            //Podemos delegar cualquier tipo de accion
            this.button2.MouseEnter += MostrarMensaje;

            //La caja leera mensaje al hacer click
            this.textBox1.Click += MostrarMensaje;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tambien podemos quitar delegaciones
            this.button1.Click -= MostrarMensaje;
        }
        public void MostrarMensaje (object sender, EventArgs e)
        {
            //Sender identifica el objeto que ha realizado la llamada

            //Queremos cambiar el colo al boton pulsado
            MessageBox.Show("Botón pulsado " + sender );

            //sender viene como object y tenemos que hacer un casting a su clase (button)
            //((Button)sender).BackColor = Color.Yellow;
            Control boton = (Control)sender;
            boton.BackColor = Color.Yellow;
        }
    }
}
