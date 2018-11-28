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
    public partial class Form21SumarBotones : Form
    {
        public Form21SumarBotones()
        {
            InitializeComponent();
            foreach(Control obj in this.Controls)
            {
                if(obj is Button)
                {
                    obj.Click += Sumar;
                }
            }
        }

        private void Sumar(object sender, EventArgs e)
        {
            int suma = int.Parse(this.lblResultado.Text);
            suma += int.Parse(((Button)sender).Text);
            this.lblResultado.Text = suma.ToString();
        }
    }
}
