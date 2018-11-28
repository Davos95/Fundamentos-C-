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
    public partial class buscaminas : Form
    {
        int tam;
        int minas;
        Label[,] celdas;
        public buscaminas()
        {
            InitializeComponent();
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            buscaminasMenu f = new buscaminasMenu();
            DialogResult result = ShowDialog();

            //Form27FormularioIniciar f = new Form27FormularioIniciar();
            //DialogResult respuesta = f.ShowDialog();

            if (result == DialogResult.OK)
            {
                tam = f.tam;
                minas = f.nMinas;
            }
        }
        public void crearTablero(int tam, int minas)
        {
            Random num = new Random();
            Panel pBuscaminas = new Panel();
            
            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {
                    Label lbl = new Label();
                    lbl.Click += checkMine;
                    celdas[i, j] = lbl;
                    pBuscaminas.Controls.Add(lbl);
                }
            }
            this.Controls.Add(pBuscaminas);
        }

        private void checkMine(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            Console.WriteLine(celdas[0, 1]);
            if(lbl.Tag == "0")
            {
                lbl.BackColor = Color.Green;
            } else
            {
                lbl.BackColor = Color.Red;
            }
        }
    }
}
