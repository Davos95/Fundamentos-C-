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
    public partial class buscaminasMenu : Form
    {
       public int tam, nMinas;
        public buscaminasMenu()
        {
            InitializeComponent();
            
        }

        private void txtTamanio_KeyPress(object sender, KeyPressEventArgs e)
        {
            char backSpace = (char)Keys.Back;
            if(!char.IsLetter(e.KeyChar) && e.KeyChar != backSpace)
            {
                e.Handled = true;
            }
        }

        private void txtMinas_KeyPress(object sender, KeyPressEventArgs e)
        {
            char backSpace = (char)Keys.Back;
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != backSpace)
            {
                e.Handled = true;
            }
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            tam = int.Parse(this.txtTamanio.Text);
            nMinas = int.Parse(this.txtMinas.Text);
            if(tam > nMinas)
            {
                this.DialogResult = DialogResult.OK;
            } else
            {
                MessageBox.Show("El tamaño debe ser mayor al numero de minas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
