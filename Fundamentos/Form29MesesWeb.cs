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
    
    public partial class Form29MesesWeb : Form
    {
        ManejadorMeses tool;
        public Form29MesesWeb()
        {
            InitializeComponent();
            this.tool = new ManejadorMeses();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            tool.GenerarMeses();
            foreach (Mes mes in tool.Meses)
            {
                this.lstMeses.Items.Add(mes.nombre);
            }
        }

        private void lstMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.lstMeses.SelectedIndex;
            //Recuperamos el mes con dicho indice
            Mes mes = this.tool.Meses[indice];
            this.txtMaxima.Text = mes.tMax.ToString();
            this.txtMinima.Text = mes.tMin.ToString();
            this.txtMedia.Text = mes.getMedia().ToString();
        }
    }

}
