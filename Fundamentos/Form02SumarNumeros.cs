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
    public partial class Form02SumarNumeros : Form
    {
        public Form02SumarNumeros()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            
            if(this.txtNumero1.Text == "" || this.txtNumero2.Text == "")
            {
                //Mostramos un "Alert"
                //LA CLASE MessageBox TIENE UN METODO CON 21 SOBRECARGAS PARA MOSTRAR MENSAJES .Show()
                MessageBox.Show("Debes de rellenar los datos", "Error de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            else
            {
                //Obtenemos las variables
                int num1, num2, suma;

                //This representa el objeto donde estamos trabajando (la clase)
                //En este caso queremos guardar el text de la caja en las variables INT
                //Tenemos que utilizar un .Parse(String)
                num1 = int.Parse(this.txtNumero1.Text);
                num2 = int.Parse(this.txtNumero2.Text);

                //Se hace la suma
                suma = num1 + num2;

                //Dibujamos en el label el resultado de la suma
                //Al ser un label, solo admite cadenas de texto, por lo que es un String. Usaremos la función ToString()
                this.Resultado.Text = suma.ToString();

                this.Resultado.Font = new Font("ComicSans", 12);
            }
        }
    }
}
