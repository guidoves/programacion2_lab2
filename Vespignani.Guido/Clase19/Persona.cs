using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase19
{
    [Serializable]
    public class Persona
    {
        public string _nombre;
        public int _edad;
        public bool _esMayor;

        public Persona(string nombre, int edad, bool esMayor)
        {
            this._esMayor = esMayor;
            this._nombre = nombre;
            this._edad = edad;
        }
        public Persona()
        {

        }

        public override string ToString()
        {
            StringBuilder persona = new StringBuilder();
            persona.AppendLine("Nombre: " + this._nombre);
            persona.AppendLine("Edad: " + this._edad);
            persona.AppendLine("Es mayor de edad: " + this._esMayor.ToString());
            return persona.ToString();
        }
    }
}
