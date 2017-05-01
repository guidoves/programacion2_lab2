using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Novela : Libro
    {
        public EGenero genero;

        public Novela(string titulo, float precio, Autor autor, EGenero genero):base(titulo,autor,precio)
        {
            this.genero = genero;
        }
        public string Mostrar()
        {
            StringBuilder novela = new StringBuilder();
            novela.AppendLine(((string)this));
            novela.AppendLine("Tipo: " + this.genero.ToString());
            return novela.ToString();
        }
        public static bool operator ==(Novela a, Novela b)
        {
            if (a == b && a.genero == b.genero)
                return true;
            return false;
        }
        public static bool operator !=(Novela a, Novela b)
        {
            return !(a == b);
        }
        public static implicit operator double(Novela n)
        {
            return n._precio;
        }
    }

    public enum EGenero
    {Accion,Romantica,CienciaFiccion}

}
