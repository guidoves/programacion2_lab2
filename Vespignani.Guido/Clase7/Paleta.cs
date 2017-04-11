using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7
{
    public class Paleta
    {
        private Tempera[] _temperas;
        private int _cantMaxColores;

        private Paleta():this(5)
        {
        }
        public Paleta(int cantidad):this()
        {
            this._temperas = new Tempera[cantidad];
            this._cantMaxColores = cantidad;

        }

        private String mostrar()
        {
            String paleta = this._cantMaxColores.ToString();

            foreach(Tempera i in this._temperas)
            {
                paleta = paleta + " " + Tempera.Mostrar(i);
            }
            return paleta;
        }

        public static implicit operator Paleta(int a)
        {
            Paleta p = new Paleta(a);
            return p;
        }
        public static explicit operator String(Paleta a)
        {
            return a.mostrar();
        }
        public static Boolean operator ==(Paleta a, Tempera b)
        {
            foreach (Tempera i in a._temperas)
            {
                if (b == i)
                    return true;
            }
            return false;
        }
        public static Boolean operator !=(Paleta a, Tempera b)
        {
            return !(a == b);
        }
        public static Paleta operator +(Paleta a, Tempera b)
        {
            foreach (Tempera i in a._temperas)
            {
                if (b == i)
                    a._
                return a;
            }
            foreach (Tempera i in a._temperas)
            {
                if (i == null)
                {
                    a._temperas[i] = b;
                    break;
                }
            }
            return a;
        }
        public static Paleta operator -(Paleta a, Tempera b)
        {
            foreach (Tempera i in a._temperas)
            {
                if (b == i && a._cantMaxColores <= 0)
                {
                    a._temperas[i] = null;
                    break;
                }
            }
            return a;
        }
    }
}
