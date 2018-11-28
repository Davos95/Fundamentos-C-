using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProyectoClases; //Nuestro proyecto
namespace Fundamentos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        private void btnPersona_Click(object sender, EventArgs e)
        {
            this.lstPersona.Items.Clear();
            Persona person = new Persona();
            person.Nombre = "Lucas";
            person.Apellidos = "Perez Robles";
            person.Sexo = Persona.Genero.Femenino;
            person.Sexo = (Persona.Genero)0;
            person.Nacionalidad = Paises.España;
            this.lstPersona.Items.Add(person.Nombre);
            this.lstPersona.Items.Add(person.Apellidos);
            //Para nosotros, un negativo no es una edad valida, debemos dar un toque a quien utiliza la clase
           
            try
            {
                person.Edad = 22;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            this.lstPersona.Items.Add("Edad: " + person.Edad);

            this.lstPersona.Items.Add("Sexo: " + person.Sexo);
            this.lstPersona.Items.Add("Pais: " + person.Nacionalidad);

            //Primero creamos el objeto
            person.DomicilioVacaciones = new Direccion();
            person.DomicilioVacaciones.Calle = "Paseo del mar";
            person.DomicilioVacaciones.Ciudad = "Cadiz";


            #region Propiedades objetos

            //Tenemos psibilidad en el momento de crear objetos en su contruccion
            //new objeto {prop = valor, Prop = valor}
            person.Domicilio = new Direccion
            {
                Calle = "Calle pez, 14",
                Ciudad = "Madrid",
                CodigoPostal = 28003
            };
            this.lstPersona.Items.Add("Calle: " + person.DomicilioVacaciones.GetDescipcion());
            #endregion

            person[0] = "Rubio";
            person[1] = "Metro noventa";
            this.lstPersona.Items.Add("Descripcion[0]: " + person[0]);
            person.ConvertirMayusculas();
            this.lstPersona.Items.Add("Nombre completo: " + person.getNombreCompleto());

            Persona p2 = new Persona("Canales", 24);
            this.lstPersona.Items.Clear();
            this.lstPersona.Items.Add(p2.ToString());

        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            this.lstPersona.Items.Clear();
            Empleado emp = new Empleado();
            this.lstPersona.Items.Add(emp.getNombreCompleto());
            this.lstPersona.Items.Add("Edad: "+emp.Edad);
            this.lstPersona.Items.Add(emp.ToString(2));
            this.lstPersona.Items.Add("Vacaciones: " + emp.GetDiasVacaciones());        }

        private void btnEjecutivo_Click(object sender, EventArgs e)
        {
            this.lstPersona.Items.Clear();
            Ejecutivo ej = new Ejecutivo();
            this.lstPersona.Items.Add(ej.getNombreCompleto());
            this.lstPersona.Items.Add(ej.Nacionalidad);
            this.lstPersona.Items.Add(ej.GetSalarioMinimo());
            this.lstPersona.Items.Add("Vacaciones: " + ej.GetDiasVacaciones());

        }
    }
}
