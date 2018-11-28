using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace Fundamentos
{
    public partial class Form28TemperaturasMeses : Form
    {
        List<Mes> listaMeses;
        public Form28TemperaturasMeses()
        {
            InitializeComponent();
            listaMeses = new List<Mes>();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.lstMeses.Items.Clear();
            listaMeses.Clear();
            Random numRandom = new Random();
            int num1;
            int num2;
            int aux;
            for (int i = 0; i < 12; i++)
            {
                num1 = numRandom.Next(-3, 30);
                num2= numRandom.Next(-3, 30);
                if(num1 < num2)
                {
                    aux = num1;
                    num1 = num2;
                    num2 = aux;
                }
                Mes m = new Mes((NombreMes)i, num1, num2);
                listaMeses.Add(m);
                lstMeses.Items.Add(m.nombre);
            }
        }

        private void lstMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstMeses.SelectedIndex;
            this.txtMaxima.Text = listaMeses[index].tMax.ToString();
            this.txtMinima.Text = listaMeses[index].tMin.ToString();
            this.txtMedia.Text = listaMeses[index].getMedia().ToString();
        }
    }
}
