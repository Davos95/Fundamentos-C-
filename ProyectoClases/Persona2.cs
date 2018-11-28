using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    class Persona2
    {
        //Aqui nunca escribimos nada
        //Dentro de un NameSpace se declaran las enumeraciones

        public enum Paises
        {
            España = 0, Alemania = 1, Holanda = 2, Francia = 3
        }

        public class Persona
        {
            #region Constructor
            //Un constructor es un metodo.
            //Es el primer metodo en el momento de instanciar un objeto.
            //En este metodo se decide como queremos un objeto oinicialmente.
            //Tenemos sobrecarga
            //Un constructor se llama como la clase, si una clase no tiene constructor utiliza el constructor por defecto de la clase base

            public Persona()
            {
                //Este metodo se ejecuta cuando se instancia el objeto (new)
                //Sirve para iniciar todos los elementos de la clase
                this.Nombre = "Ana";
                this.Nacionalidad = Paises.Francia;
                this.Sexo = Genero.Femenino;
            }
            public Persona(String apellidos, int edad)
            {
                this.IniciarObjeto();
                this.Apellidos = apellidos;
                this.Edad = edad;
            }

            //Un constructor puede tener sobrecarga, podemos utilizar el constructor para obligar a crear el objeto de una forma

            private void IniciarObjeto()
            {

            }
            #endregion

            //Nada qu ever con POO, herramienta del lenguaje para estricturar el codigo

            #region Propiedades
            //Sintaxis de propiedades
            //Propiedades extendidas
            //Preguntas o acciones
            //Cuando hablamos de propiedades extendidas necesitamos un campo para manejar la propiedad

            //Campo de propiedad (private)
            private String _Nombre;
            private string _Apellidos;
            private int _Edad;
            private Genero _Sexo;
            private Paises _Nacionalidad;


            //Propiedad (public)
            public String Nombre
            {
                get
                {
                    //Se ejecuta cuando alguien recupera el valor de la propiedad
                    return this._Nombre;
                }
                set
                {
                    //Se ejecuta cuando alguien cambia el valor de la propiedad VALUE es una palabra clave dendo viene el valor de la propiedad solo que se utiliza en el SET. 
                    //Aquí cambiamos el valor del campo
                    this._Nombre = value;
                }
            }


            public string Apellidos
            {
                get { return this._Apellidos; }
                set { this._Apellidos = value; }
            }

            public int Edad
            {
                get { return this._Edad; }
                set
                {
                    //Tenemos dos posibilidades para indicar que algo no nos gusta en la utilización de nuestra clase
                    if (value < 0)
                    {
                        //Este valor no es valido para nosotros.

                        //Error silecionso, cambiamos el valor por alguno valido.
                        //this._Edad = 1;

                        //Lanzar Excepciones
                        //Throw new Exception("Mensaje);
                        throw new Exception("La edad no puede ser negativa");

                    }
                    else
                    {
                        this._Edad = value;
                    }
                }
            }

            //Enumeraciones
            //Una enumeracion es una herramienta de lenguaje donde se nos permite seleccionar entre la varias posibilidades
            //Cada elemento de la enumeracion contiene un numero interno, esto es una ayuda para el programador que va a utilizar mi clase
            //Las enumeraciones (normalmente) se declaran en NameSpace

            public enum Genero
            {
                Masculino = 0, Femenino
            }
            //Lo que tenemos que hacer es declarar una propiedad con el tipo de enum


            public Genero Sexo
            {
                get { return this._Sexo; }
                set
                {
                    //Como las enumeraciones son numeros, al final del todo
                    //Debemos comprobar los valores que nos estan enviando
                    if (value == Genero.Femenino || value == Genero.Masculino)
                    {
                        this._Sexo = value;
                    }
                    else
                    {
                        throw new Exception("Valor no valido");
                    }

                }
            }

            //Propiedad para la Nacionalidad

            public Paises Nacionalidad
            {
                get { return this._Nacionalidad; }
                set { this._Nacionalidad = value; }
            }


            //Propiedades extendidas
            private Direccion _Domicilio;
            public Direccion Domicilio
            {
                get; set;
            }

            private Direccion _DomicilioVacaciones;
            public Direccion DomicilioVacaciones
            {
                get { return this._DomicilioVacaciones; }
                set { this._DomicilioVacaciones = value; }
            }
            #endregion



            //Propiedades indizada
            //Una propiedad indizada no tiene nombre, se accede directamente desde el objeto [].
            //Este tipo de propiedades suelen ser arrays o colecciones.
            //Permiten tener multiples valores por un indice
            //String texto = "NET";
            //texto[0]
            //texto.Chars[0]
            //List <int> coleccion;
            //coleccion[0]

            //Solamente tendremos una por objeto
            //Una persona puede tener varias descripciones
            //5 como maximo

            //Necesitamos una variable para manejar los objetos por su indice (array, list<>)

            private String[] _Descripciones = new string[5];

            public String this[int indice]
            {
                get { return this._Descripciones[indice]; }
                set { this._Descripciones[indice] = value; }
            }

            #region Metodos

            public String getNombreCompleto()
            {
                return this.Nombre + " " + this.Apellidos;
            }

            public void ConvertirMayusculas()
            {
                this.Nombre = this.Nombre.ToUpper();
                this.Apellidos = this.Apellidos.ToUpper();
            }

            //La sobrecarga de unu metodo
            //Para sobrecargar un metodo debemos mantener la misma firma (nombre del metodo) pero distinta forma (parametros)
            //Queremos un metodo que devuelva el nombre completo, pero el apellido - nombre

            public String getNombreCompleto(bool orden)
            {
                return this.Apellidos + " " + this.Nombre;
            }
            public String getNombreCompleto(String titulo)
            {
                return titulo + this.getNombreCompleto();
            }


            #endregion


        }
        }
    }
