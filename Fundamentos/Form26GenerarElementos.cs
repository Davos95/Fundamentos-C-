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
    public partial class Form26GenerarElementos : Form
    {
        public Form26GenerarElementos()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Form26NumeroBorones f = new Form26NumeroBorones();
            DialogResult respuesta = f.ShowDialog();
            int numero = 1;
            if (respuesta == DialogResult.OK)
            {
                //Em este cuadro de dialogo nos devuelve .NumeroBotones
                 numero = f.NumeroBotones;
            }
            
            int posY = 10;
            for (int i = 0; i < numero; i++)
            {
                Button boton = new Button();
                boton.Text = i.ToString();
                //Indicamos la posición y tamaño
                boton.AutoSize = true;
                boton.Location = new Point(50, posY);
                boton.BackColor = Color.Yellow;
                this.panel1.Controls.Add(boton);
                posY += 30;
                boton.Click += botonClick;
            }
            
        }

        private void botonClick(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.BackColor = Color.Blue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Vamos a usar un cuadro de dialogo
            DialogResult respuesta = MessageBox.Show("Desea continuar?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(respuesta == DialogResult.OK)
            {

            }
            //Al igual que  tenemos dialogos que son mensajes (alert) tambien tenemos para abrir ficheros, colores...
            //por ejemplo: 
            //.showDialog() --> Mostrar el cuadro
            //.Propiedad Devolucion
            ColorDialog cld = new ColorDialog();
            DialogResult resp = cld.ShowDialog();
            if(resp == DialogResult.OK)
            {

                //Aqui tenemos el color .Color
                foreach (Control c in this.panel1.Controls)
                {
                    c.BackColor = cld.Color;
                }
                //this.panel1.Controls[0].BackColor = cld.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult respuesta = ofd.ShowDialog();
            if(respuesta == DialogResult.OK)
            {
                // .FileName
                string archivo = ofd.FileName;
                //Para dibujar imagenes se utiliza un crontol llamado pictureBox
                PictureBox pct = new PictureBox();
                //Para cargar una imagen se utiliza la clase image y un metodo Image.FromFile(Path)
                pct.Image = Image.FromFile(archivo);
                pct.Size = new Size(200, 200);
                //Indicamos que la imagen se adapte a las medidas del control
                pct.SizeMode = PictureBoxSizeMode.StretchImage;
                this.panel2.Controls.Add(pct);
                
            }
        }
    }
}
