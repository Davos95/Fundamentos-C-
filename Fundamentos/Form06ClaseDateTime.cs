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
    public partial class Form06ClaseDateTime : Form
    {
        public Form06ClaseDateTime()
        {
            InitializeComponent();
            this.txtFechaActual.Text = DateTime.Now.ToString();
        }


        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            int incremento;
            if(int.TryParse(this.txtIncremento.Text, out incremento))
            {
                DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);
                
                if(this.rdbDia.Checked)
                {
                    fecha = fecha.AddDays(incremento);
                } else if(this.rdbMes.Checked)
                {
                    fecha = fecha.AddMonths(incremento);
                } else
                {
                    fecha = fecha.AddYears(incremento);
                }
                this.txtFechaResultado.Text = fecha.ToString();
            } else
            {
                MessageBox.Show("Deben ser valores numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form06Fechas_Load(object sender, EventArgs e)
        {

        }

        private void chbCambiarFormato_CheckedChanged(object sender, EventArgs e)
        {
            //Se cambiara la fecha en largo o corto según si está checkeado
            //Primero obtendremos el valor de la caja
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);
            if(this.chbCambiarFormato.Checked == true)
            {
                this.txtFechaActual.Text = fecha.ToLongDateString(); //Da información con numeros y palabras
            } else
            {
                this.txtFechaActual.Text = fecha.ToShortDateString(); // lo deja en formato dd/mm/yyyy
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);
            DateTime fechaFutura;
            if(DateTime.TryParse(this.txtFechaResultado.Text,out fechaFutura))
            {
                TimeSpan intervalo = fechaFutura.Subtract(fecha); //Variable que recoge un intervalo entre fechas
                txtDia.Text = intervalo.TotalDays.ToString();
                txtHora.Text = intervalo.TotalHours.ToString();
            } else
            {
                MessageBox.Show("No hay resultado de la fecha, debe de crear una fecha resultado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
