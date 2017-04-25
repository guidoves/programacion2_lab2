using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    public class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected int _dni;

        public Persona(string nombre, string apellido, int dni)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;
        }
        #region Propiedades
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }

        public int Dni
        {
            get { return this._dni; }
            set { this._dni = value; }
        }
        #endregion

        public string MostrarPersona()
        {
            string persona = "Nombre: " + this._nombre + "\n" +
                "Apellido: " + this._apellido + "\n" +
                "Dni: " + this._dni.ToString() + "\n";
            return persona;
        }
    }

}
