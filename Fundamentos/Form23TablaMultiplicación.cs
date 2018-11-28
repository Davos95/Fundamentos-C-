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
    public partial class Form23TablaMultiplicación : Form
    {
        List<TextBox> lista;
        public Form23TablaMultiplicación()
        {
            InitializeComponent();

            lista = new List<TextBox>();
            foreach (Control t in this.Controls)
            {
                if (t is TextBox && t.Name != "txtNumero")
                {
                    lista.Add((TextBox)t);
                }
            }
            lista.Reverse();
        }

        private void btnTabla_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            int nTextBoxes = 0;
            
            foreach (TextBox t in lista)
            {
                nTextBoxes++;
                t.Text = (num * nTextBoxes).ToString();
            }
        }
    }
}
