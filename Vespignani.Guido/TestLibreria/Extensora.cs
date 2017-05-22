using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa.Sellada;

namespace TestLibreria
{
    public static class Extensora
    {
        public static string ObtenerInfo(this PersonaExternaSellada persona )
        {
            StringBuilder a = new StringBuilder();
            a.AppendLine(persona.Apellido);
            a.AppendLine(persona.Edad.ToString());
            a.AppendLine(persona.Sexo.ToString());
            a.AppendLine(persona.Nombre);
            return a.ToString();
        }
        public static int ObtenerCantidadDeLetras(this string str)
        {
            return str.Length;
        }
    }
}
