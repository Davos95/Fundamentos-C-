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
    public partial class Form16Funciones : Form
    {
        public Form16Funciones()
        {
            InitializeComponent();
        }

        private void btnLlamarMetodo_Click(object sender, EventArgs e)
        {
            //this.lblRestultado.Text = SumarNumeros(1, 2).ToString();
            int num = 5;
            DobleNumero(ref num);
            this.lblRestultado.Text = num.ToString();
            CambarColorBoton(this.btnLlamarMetodo);
        }
        //Metodo sumar numeros
        public int SumarNumeros(int n1, int n2)
        {
            int suma = n1 + n2;
            return suma;
        }
        //Metodo de duplicar un numero con referencia
        public void DobleNumero(ref int numero)
        {
            numero = numero * 2;
        }
        //Metodo que cambia el boton de color
        public void CambarColorBoton(Button boton)
        {
            boton.BackColor = Color.Yellow;
        }
    }
}
