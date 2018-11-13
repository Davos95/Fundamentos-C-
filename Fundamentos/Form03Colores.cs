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
    public partial class Form03Colores : Form
    {
        public Form03Colores()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if(this.txtRojo.Text == "" || this.txtVerde.Text == "" || this.txtAzul.Text == "" )
            {
                MessageBox.Show("Inserta valores", "Error de colores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                int rojo, verde, azul;
                if (int.TryParse(this.txtRojo.Text, out rojo) && int.TryParse(this.txtVerde.Text, out verde) && int.TryParse(this.txtAzul.Text, out azul))
                {
                    if ((rojo >= 0 && rojo <= 255) && (verde >= 0 && verde <= 255) && (azul >= 0 && azul <= 255))
                    {
                        this.BackColor = Color.FromArgb(rojo, verde, azul);
                        this.txtRojo.BackColor = Color.FromArgb(rojo, 0, 0);
                        this.txtVerde.BackColor = Color.FromArgb(0, verde, 0);
                        this.txtAzul.BackColor = Color.FromArgb(0, 0, azul);
                    }
                    else
                    {
                        MessageBox.Show("Los valores tienen que estar entre el 0 y 255", "Error de colores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    MessageBox.Show("Los valores tienen que ser numéricos", "Error de colores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}
