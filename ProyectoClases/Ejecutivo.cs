using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace ProyectoClases
{
    public class Ejecutivo : Empleado
    {
        #region CONSTRUCTOR
        public Ejecutivo()
        {
            Debug.WriteLine("Constructor Ejecutivo sin parametros");
            this.SalarioMinimo += 1200;
        }

        #endregion
        //Un ejecutivo queremos que tenga 26 dias de vacaciones
        public override int GetDiasVacaciones()
        {
            //Tenemos que averiguar si se lee el metodo de la clase base
            Debug.WriteLine("GetVacaciones() EMPLEADO");
            //Sobrescribimos y no nos importa la implementación del metodo base
            //No nos importal el 22
            //return 26;
            //Segunda opcion
            //Nos importa la implementacion dle metodo base, necesitamos realizar una llamada a dicho codigo
            int vacasempleado = base.GetDiasVacaciones();
            return vacasempleado + 4;
        }
    }
}
