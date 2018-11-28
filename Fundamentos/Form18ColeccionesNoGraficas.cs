using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Fundamentos
{
    public partial class Form18ColeccionesNoGraficas : Form
    {
        public Form18ColeccionesNoGraficas()
        {
            InitializeComponent();
            //Declaramos una coleccion convencional
            ArrayList antigua =  new ArrayList();
            //Dento de dicha coleccion podemos guardar cualquier clase, ya que es de tipo object
            //Vamos a almacenar botones

            antigua.Add(this.button1);
            antigua.Add(this.button2);
            antigua.Add(this.button3);
            //Añadimos una caja dentro de una colección
            antigua.Add(this.textBox1);
            //Queremos recorrer todos los elementos de la coleccion
            //Un bucle each permite el casting dentro de la declaración
            //Añadimos un string a la colección

            antigua.Add("hola");
            /*
            foreach (Object btn in antigua)
            {
                //Tenemos objetos dentro de una clase abstracta (object), para manejar cada objeto ahora habrá que hacer casting
                //Tenemos que preguntar por el tipo 
                if (btn is Button)
                {
                    //Aquí tenemos botones pero vienen como OBJECT
                    ((Button)btn).BackColor = Color.Yellow;
                }
            }
            */

            //Vamos a realizar la misma acción pero con colecciones genericas o tipadas.
            //un generic es un tipo de clase dinamica, es decir, podemos declararlo como un comodin.
            //Al declarar una colección con tipo ahorramos Memoria y, además, evita errores de programación ahorrando el casting.
            //El compilador detecta el <T>
            //La abstracción la realizamos en <T>

            //Colección de botones <T>
            // ---> List<Button> botones = new List<Button>();
            List<Control> botones = new List<Control>();
            //El compilador detecta <T>
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);
            //Si añadimos un textbox...
            botones.Add(this.textBox1);
            foreach (Control obj in botones)
            {
                if(obj is TextBox)
                {
                    ((TextBox)obj).Paste();
                } else if(obj is Button)
                {
                    ((Button)obj).BackColor = Color.Green;
                }
            }
        }


    }
}
