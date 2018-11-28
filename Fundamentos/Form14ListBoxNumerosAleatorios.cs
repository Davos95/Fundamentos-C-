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
    public partial class Form14ListBoxNumerosAleatorios : Form
    {
        public Form14ListBoxNumerosAleatorios()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.lstNumeros.Items.Clear();
            Random random = new Random();
            int numeroRandom = random.Next(1, 20);
            for (int i = 0; i < numeroRandom; i++)
            {
                int numeroRandom2 = random.Next(1, 50);
                this.lstNumeros.Items.Add(numeroRandom2);
            }
        }

        private void btnVerDatos_Click(object sender, EventArgs e)
        {
            int sum = 0, imp = 0, par = 0;
            foreach(int num in this.lstNumeros.Items)
            {
                sum += num;
                if(num % 2 == 0)
                {
                    par += num;
                } else
                {
                    imp += num;
                }
            }
            lblSuma.Text = sum.ToString();
            lblPares.Text = par.ToString();
            lblImpares.Text = imp.ToString();
        }
    }
}
