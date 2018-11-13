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
    public partial class Form05DiaDeSemana : Form
    {
        public Form05DiaDeSemana()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int dia, mes, anio;
            if(int.TryParse(this.txtDia.Text, out dia) && int.TryParse(this.txtMes.Text, out mes) && int.TryParse(this.txtAnio.Text, out anio))
            {
                string[] diaSemanas = new string[] {"Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado"};
                DateTime fecha = new DateTime(anio, mes, dia);
                System.Diagnostics.Debug.Write((int)fecha.DayOfWeek);
                this.resultado.Text = "El dia de su nacimiento es: " + diaSemanas[(int)fecha.DayOfWeek];
            } else {
                MessageBox.Show("Los valores deben de ser numéricos", "Error fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

/*
int op1, op2;
if (mes == 1 || mes == 2) { mes += 12; }
op1 = dia + (mes * 2) + anio + (((mes + 1) * 3) / 5) + (anio / 4) - (anio / 100) + (anio / 400) + 2;
op2 = op1 / 7;
op1 = op1 - (op2 * 7);
this.resultado.Text = "El dia de su nacimiento es: "+ diaSemanas[op1];
*/
