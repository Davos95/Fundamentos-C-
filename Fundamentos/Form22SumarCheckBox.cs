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
    public partial class Form22SumarCheckBox : Form
    {
        public Form22SumarCheckBox()
        {
            InitializeComponent();
            RandomCheckBox();
        }

        public void RandomCheckBox()
        {
            Random number = new Random();
            foreach (Control c in this.Controls)
            {
                if(c is CheckBox)
                {
                    c.Text = number.Next(1, 100).ToString();
                    c.Click += suma;
                }
            }
        }
        public void suma(object sender, EventArgs e)
        {
            int suma = int.Parse(this.lblSuma.Text);
            CheckBox c = (CheckBox)sender;
            if (c.Checked) {
                suma += int.Parse(c.Text);
            } else
            {
                suma -= int.Parse(c.Text);
            }
            this.lblSuma.Text = suma.ToString();
        }
    }
}
