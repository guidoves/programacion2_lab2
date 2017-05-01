using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Autor
    {
        private string apellido;
        private string nombre;

        public Autor(string nombre, string apellido)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public static bool operator ==(Autor a, Autor b)
        {
            if (a.nombre == b.nombre && a.apellido == b.apellido)
                return true;
            return false;
        }
        public static bool operator !=(Autor a, Autor b)
        {
            return !(a == b);
        }
        public static implicit operator string(Autor a)
        {
            return a.nombre + " - " + a.apellido; 
        }
    }
}
