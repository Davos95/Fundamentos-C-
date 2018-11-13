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
    public partial class Form08PracticaEmail : Form
    {
        public Form08PracticaEmail()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;
            this.lbResultado.ForeColor = Color.Red;
            if (email != "")
            {
                if (email.IndexOf("@") != -1) {
                    if (email.IndexOf("@") != 0 && email.IndexOf("@") != (email.Length-1))
                    {
                        if (email.IndexOf("@") == email.LastIndexOf("@"))
                        {
                            if (email.LastIndexOf("@") < email.LastIndexOf("."))
                            {
                                if (email.Substring(email.LastIndexOf(".")).Length >= 2 && email.Substring(email.LastIndexOf(".")).Length <= 4)
                                {
                                    this.lbResultado.Text = "Email Correcto";
                                    this.lbResultado.ForeColor = Color.Green;
                                } else { this.lbResultado.Text = "El dominio debe de ser de 2 a 4 de longitud."; }
                            } else { this.lbResultado.Text = "Solo debe de tener un << . >> despues del <<@>>.";
                            }
                        }
                        else
                        {
                            this.lbResultado.Text = "Solo debe de tener un << @ >>.";
                        }
                    }
                    else
                    {
                        this.lbResultado.Text = "No debe de tener << @ >> ni al principio ni al final.";
                    }
                } else
                {
                    this.lbResultado.Text = "Debe de haber un << @ >>.";
                }
            } else
            {
                this.lbResultado.Text = "Tiene que insertar un email.";
            }
        }
    }
}
