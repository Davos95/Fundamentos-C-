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
    public partial class Form11NumerosNarcisistas : Form
    {
        public Form11NumerosNarcisistas()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if(NaN(this.txtNumero.Text))
            {
                string narcisista = this.txtNumero.Text;
                int total = 0;
                for (int i = 0; i < narcisista.Length; i++)
                {
                    double numero = double.Parse(narcisista[i].ToString());
                    total += (int)Math.Pow(numero, narcisista.Length);
                }
                if(total == int.Parse(narcisista))
                {
                    this.lblResultado.Text = "Es narcisista";
                } else
                {
                    this.lblResultado.Text = "No es narcisista";
                }
            }   
        }
        public Boolean NaN(string variable)
        {
            try
            {
                int.Parse(variable);
            }
            catch(System.FormatException e)
            {
                return false;
            }
            return true;
        }
    }
}
