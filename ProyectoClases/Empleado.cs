using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace ProyectoClases
{
    //Indicamos que un empleado hereda de una persona
    public class Empleado: Persona
    {
        //Vamos a crear una propiedad para que un empleado tengo un salario minimo 
        //Dicha propiedad solamente deben utilizar los que hereden de empleado
        protected int SalarioMinimo { get; set; }

        //Metodo Public para ver en el formulario el salario minimo
        public String GetSalarioMinimo()
        {
            return "Salario Minimo:" + this.SalarioMinimo;
        }

        #region CONSTRUCTOR
        //Creamos un constructor para empleados
        //Con los mismos parametros que tiene persona
        //y si la clase base no tiene constructor por defecto? 
        // constructor de la clase base, podemos hacelor de forma explicita 
        //Para hacer referencia en una clase derivada ala clase de BASE --> base

        public Empleado()
            :base()
        {
            
            Debug.WriteLine("Constructor EMPLEADO sin parametros");
        } 

        public Empleado(String apellidos, int edad, int salario)
        {
            Debug.WriteLine("Constructor EMPLEADO con parametros");
            this.Apellidos = apellidos;
            this.Edad = edad;
            this.SalarioMinimo = salario;
        }
        #endregion

        public override string ToString()
        {
            return this.getNombreCompleto();
        }
        public String ToString(int n)
        {
            return this.getNombreCompleto() + " " + this.Nacionalidad;
        }

        public virtual int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() EMPLEADO");
            return 22;
        }
    }
}
