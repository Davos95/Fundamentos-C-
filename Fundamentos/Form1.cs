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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cajaTexto.Text = "Nuevo texto";
            //cajaTexto.Visible = false;
            cajaTexto.Multiline = true;
            //cambiar el tamaño de la caja
            cajaTexto.Size = new Size(500, 250);
            //Cambiar color de la caja
            cajaTexto.BackColor = Color.Azure;
            //Cambiar la alineación del texto de la caja
            cajaTexto.TextAlign = HorizontalAlignment.Center;
            //Metodo del textbox pegar
            cajaTexto.Paste();
        }

    }
}
