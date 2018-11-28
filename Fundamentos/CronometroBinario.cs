using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Fundamentos
{
    public partial class CronometroBinario : Form
    {
        bool i = false;
        int cont = 0;
        public CronometroBinario()
        {
            InitializeComponent();
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            
            Stopwatch krono = new Stopwatch();
            i = false;
            krono.Start();
            goKrono(krono);
            krono.Stop();
        }
        public void goKrono(Stopwatch k)
        {
            while(i == false) {
                cont++;
                this.lblKrono.Text = cont.ToString();
            }
            
            
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            i = true;
        }
    }
}
