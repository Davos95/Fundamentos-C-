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
    public partial class Form25Calculadora : Form
    {
        double num;
        string op = "";
        bool flagDO = false;

        public Form25Calculadora()
        {
            InitializeComponent();
            foreach (Button c in this.pNumerico.Controls)
            {
                if(c.Name != "btnIgual")
                {
                    c.Click += mostrarNumero;
                } else
                {
                    c.Click += resultado;
                }
            }
            foreach (Button c in this.pOperador.Controls)
            {
                c.Click += operador;
            }
        }

        public void mostrarNumero(object sender, EventArgs e)
        {
            if(flagDO)
            {
                this.txtDisplay.Text = "";
                flagDO = false;
            }
            this.txtDisplay.Text += ((Button)sender).Text;

            
        }
        public void operador(object sender, EventArgs e)
        {
            num = double.Parse(this.txtDisplay.Text);
            op = ((Button)sender).Text;
            this.txtDisplay.Text = "";
        }
        public void resultado(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Write(num);
            System.Diagnostics.Debug.Write(op);
            System.Diagnostics.Debug.Write(this.txtDisplay.Text);
            if (this.txtDisplay.Text != "" && op != "")
            {
                switch (op)
                {
                    case "/": num = num / double.Parse(this.txtDisplay.Text); break;
                    case "*": num = num * double.Parse(this.txtDisplay.Text); break;
                    case "-": num = num - double.Parse(this.txtDisplay.Text); break;
                    case "+": num = num + double.Parse(this.txtDisplay.Text); break;
                }
                this.txtDisplay.Text = num.ToString();
                flagDO = true;
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = "";
            op = "";
            num = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(this.txtDisplay.Text != "")
            {
                this.txtDisplay.Text = this.txtDisplay.Text.Substring(0, this.txtDisplay.Text.Length - 1);
            }
        }
    }
}
