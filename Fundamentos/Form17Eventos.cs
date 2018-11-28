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
    public partial class Form17Eventos : Form
    {
        public Form17Eventos()
        {
            InitializeComponent();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnResultado.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            char teclaBack = (char) Keys.Back;
            if(char.IsDigit(e.KeyChar) == false && e.KeyChar != teclaBack )
            {
                e.Handled = true;
            }
        }
    }
}
