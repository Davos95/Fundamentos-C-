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
    public partial class Form07ClaseChar : Form
    {
        public Form07ClaseChar()
        {
            InitializeComponent();
        }

        private void btnAscii_Click(object sender, EventArgs e)
        {
            //Bucle de 0 a 255 con todos los caracteres ASCII
            for (int i = 0; i < 255; i++)
            {
                //Tenemos que convertir i que es una variable de tipo <<int>> a tipo de variable <<char>>
                char letra = (char)i;
                if(char.IsLetter(letra))
                {
                    this.txtLetras.Text += letra + " ";
                } else if(char.IsNumber(letra)){
                    this.txtNumeros.Text += letra + " ";
                } else if(char.IsPunctuation(letra))
                {
                    this.txtPuntuacion.Text += letra + " ";
                } else if(char.IsSymbol(letra))
                {
                    this.txtSimbolo.Text += letra + " ";
                }
            }
        }

    }
}
