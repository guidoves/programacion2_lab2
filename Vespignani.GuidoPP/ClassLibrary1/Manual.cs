using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Manual : Libro
    {
        public ETipo tipo;

        public Manual(string titulo,float precio,string nombre,string apellido,ETipo tipo):base(precio,titulo,nombre,apellido)
        {
            this.tipo = tipo;
        }
        public string Mostrar()
        {
            StringBuilder manual = new StringBuilder();
            manual.AppendLine((string)this);
            manual.AppendLine("Tipo: " + this.tipo.ToString());
            return manual.ToString();
        }
        public static bool operator ==(Manual a, Manual b)
        {
            if (a == b && a.tipo == b.tipo)
                return true;
            return false;
        }
        public static bool operator !=(Manual a, Manual b)
        {
            return !(a == b);
        }
        public static implicit operator double(Manual m)
        {
            return m._precio;
        }
    }
    

    public enum ETipo
    {Tecnico,Escolar,Finanzas}
}
