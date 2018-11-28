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
    public partial class Form27Primitiva : Form
    {
        int cont = 0;
        int nApuestas;
        int nLabels;
        bool s = false;
        public Form27Primitiva()
        {
            InitializeComponent();
            this.btnSortear.Enabled = false;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Form27FormularioIniciar f = new Form27FormularioIniciar();
            DialogResult respuesta = f.ShowDialog();

            if(respuesta == DialogResult.OK)
            {
                nLabels = f.xNumeros;
                nApuestas = f.nApuestas;
                this.pNumeros.Controls.Clear();
                crearNumeros(nLabels);
                this.btnSortear.Enabled = true;
            }
        }
        public void crearNumeros(int numeros)
        {
            int n = 1;
            for (int i = 0; i < numeros; i++)
            {
                Label lbl = new Label();
                lbl.Text = (n).ToString();
                lbl.BackColor = Color.White;
                lbl.Size = new Size(40, 30);
                lbl.Margin = new Padding(0, 30,20,0);
                lbl.Click += SelectNumber;
                lbl.Font = new Font("Microsoft Sans Serif", 14);
                n++;
                this.pNumeros.Controls.Add(lbl);
            }
        }
        public void SelectNumber(Object sender, EventArgs e)
        {
            if(s)
            {
                MessageBox.Show("El sorteo ya se ha realizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Label lbl = (Label)sender;
            
            if (lbl.BackColor == Color.White && cont < nApuestas)
            {
                lbl.BackColor = Color.Yellow;
                this.lstPremiados.Items.Add(lbl.Text);
                cont++;
            }
            else if(lbl.BackColor == Color.Yellow && cont <= nApuestas)
            {
                lbl.BackColor = Color.White;
                this.lstPremiados.Items.Remove(lbl.Text);
                cont--;
            }
            
            
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            if(s)
            {
                MessageBox.Show("El sorteo ya se ha realizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int[] arrayPremiados = (int[])NumerosAleatorios(0, nLabels+1);
            int n;
            for (int i = 0; i < arrayPremiados.Length; i++)
            {
                n = arrayPremiados[i];
                for (int j = 0; j < this.pNumeros.Controls.Count; j++)
                {
                    if(n == int.Parse(this.pNumeros.Controls[j].Text))
                    {
                        if (this.pNumeros.Controls[j].BackColor == Color.Yellow)
                        {
                            this.pNumeros.Controls[j].BackColor = Color.Green;
                            int index = this.lstPremiados.Items.IndexOf(n.ToString());
                            this.lstPremiados.SetSelected(index, true);
                        }
                        else
                        {
                            this.pNumeros.Controls[j].BackColor = Color.Red;
                        }
                        j = this.pNumeros.Controls.Count;
                    }
                }
            }
            s = true;
        }
        public Array NumerosAleatorios(int min, int max)
        {
            int[] arrayNumeros = new int[nApuestas];
            Random numero = new Random();
            int n;
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                do {
                    n = numero.Next(min, max);
                }while (arrayNumeros.Contains(n));
                arrayNumeros[i] = n;
            }
            return arrayNumeros;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            this.lstPremiados.Items.Clear();
            foreach (Label l in this.pNumeros.Controls)
            {
                l.BackColor = Color.White;
            }
            cont = 0;
            s = false;
        }
        
    }
}
