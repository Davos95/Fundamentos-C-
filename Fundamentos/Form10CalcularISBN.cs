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
    public partial class Form10CalcularISBN : Form
    {
        public Form10CalcularISBN()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string cadena = this.txtISBN.Text;
            
            
            if(NaN(cadena))
            {
                int suma = 0;
                for (int i = 0; i < cadena.Length; i++)
                {
                    int numero = int.Parse(cadena[i].ToString());
                    suma += (numero * (i + 1));
                }
                if ((suma % 11) == 0)
                {
                    this.lblResultado.Text = "ISBN Correcto";
                    this.lblResultado.ForeColor = Color.Green;
                }
                else
                {
                    this.lblResultado.Text = "ISBN Erroneo";
                    this.lblResultado.ForeColor = Color.Red;
                }
            }
        }
        public Boolean NaN(string variable)
        {
            try
            {
                int.Parse(variable);  
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
