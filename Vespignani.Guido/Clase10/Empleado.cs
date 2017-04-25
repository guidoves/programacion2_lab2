using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    public class Empleado : Persona
    {
        private int _legajo;
        private float _sueldo;

        public Empleado(string nombre, string apellido, int dni):base(nombre , apellido , dni)
        {
        }
        public Empleado(string nombre, string apellido, int dni, int legajo): this(nombre, apellido, dni)
        {
            this._legajo = legajo;
        }
        public Empleado():this(null,null,0)
        {
 
        }
        #region Propiedades
        
        public int Legajo
        { 
            get { return this._legajo; }
            set { this._legajo = value; }
        }
        public float Sueldo 
        { 
            get { return this._sueldo; } 
            set { this._sueldo = value; } 
        }
#endregion

        public string MostrarEmpleado()
        {
            string empleado = base.MostrarPersona() + 
                "Nº Legajo: " + this._legajo.ToString() + "\n" +
                "Sueldo: " + this._sueldo.ToString() + "\n";
            return empleado;
        }
    }
}
