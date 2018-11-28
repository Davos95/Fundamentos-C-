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
    public partial class Form27FormularioIniciar : Form
    {
        public int xNumeros;
        public int nApuestas;
        public Form27FormularioIniciar()
        {
            InitializeComponent();
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBack = (char)Keys.Back;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != teclaBack)
            {
                e.Handled = true;
            }
        }

        private void txtApuestas_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBack = (char)Keys.Back;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != teclaBack)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeros = int.Parse(this.txtNumeros.Text);
            int apuestas = int.Parse(this.txtApuestas.Text);
            if (apuestas < numeros)
            {
                xNumeros = numeros;
                nApuestas = apuestas;
                this.DialogResult = DialogResult.OK;
            } else
            {
                MessageBox.Show("El numero de apuestas no puede ser igual o superar a la cantidad de numeros por apostar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
