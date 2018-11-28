using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace Fundamentos
{
    public partial class Form30TemperaturasAnio : Form
    {
        ManejadorAnio tool;
        Stopwatch stopWatch;
        public Form30TemperaturasAnio()
        {
            InitializeComponent();
            tool = new ManejadorAnio();
            stopWatch = new Stopwatch();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            int numAnios;
            if (this.txtNumAnios.Text == "")
            {
                numAnios = 1;
            } else
            {
                numAnios = int.Parse(this.txtNumAnios.Text);
            }
            
            tool.GenerarAnios(numAnios);

            this.lstAnio.Items.Clear();
            foreach (Anio a in this.tool.anios)
            {
                this.lstAnio.Items.Add(a.anio.ToString());
            }
            this.lstAnio.SelectedItem = "2000";

            stopWatch.Stop();
            lblMilisegundos.Text = stopWatch.Elapsed.Milliseconds.ToString();
            stopWatch.Restart();
        }

        private void lstAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstAnio.SelectedIndex;

            this.txtMaxAnual.Text = tool.anios[index].tMax.ToString();
            this.txtMinAnual.Text = tool.anios[index].tMin.ToString();
            this.txtMediaAnual.Text = tool.anios[index].Media.ToString();

            this.lstAnioTemp.Items.Clear();
            foreach (Mes m in tool.anios[index].meses)
            {
                this.lstAnioTemp.Items.Add(m.nombre);
            }
            this.lstAnioTemp.SetSelected(0, true);
        }

        private void lstAnioTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexYear = this.lstAnio.SelectedIndex;
            int indexMonth = this.lstAnioTemp.SelectedIndex;
            this.txtTempMax.Text = tool.anios[indexYear].meses[indexMonth].tMax.ToString();
            this.txtTempMin.Text = tool.anios[indexYear].meses[indexMonth].tMin.ToString();
            this.txtMediaMen.Text = tool.anios[indexYear].meses[indexMonth].getMedia().ToString();
        }
    }
}
