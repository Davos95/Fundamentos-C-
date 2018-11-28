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
    public partial class Form24TablaMultiplicacionConBotones : Form
    {
        List<TextBox> lista;
        public Form24TablaMultiplicacionConBotones()
        {
            InitializeComponent();
            lista = new List<TextBox>();
            Random random = new Random();
            foreach (Control c in this.Controls)
            {
                if(c is Button)
                {
                    c.Text = (random.Next(1, 100)).ToString();
                    c.Click += multiplicacion;
                }
                if(c is TextBox)
                {
                    lista.Add((TextBox)c);
                }
            }
            lista.Reverse();
        }
        /// <summary>
        /// Obtiene el texto del boton y multiplica por X textbox que haya en incremento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void multiplicacion(object sender, EventArgs e)
        {
            int num = int.Parse(((Button)sender).Text);
            int cont = 0;
            foreach (TextBox t in lista)
            {
                cont++;
                t.Text = (num * cont ).ToString(); 
            }
        }
    }
}
