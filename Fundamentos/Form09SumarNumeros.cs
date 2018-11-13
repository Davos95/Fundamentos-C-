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
    public partial class Form09SumarNumeros : Form
    {
        public Form09SumarNumeros()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            string texto = this.txtNumeros.Text;
            int suma = 0;
            //Recorremos todos los caracteres del texto
            for (int i = 0; i < texto.Length; i++)
            {
                //Capturamos cada caracter del texto
                char caracter = texto[i];
                //Convertimos cada caracter en numero
                int numero = int.Parse(caracter.ToString());
                suma += numero;
            }
            lblSuma.Text = suma.ToString();
        }
    }
}
