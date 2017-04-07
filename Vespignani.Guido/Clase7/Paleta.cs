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
        public Paleta(int cantidad)
        {
            this._temperas = new Tempera[cantidad];
            this._cantMaxColores = cantidad;
        }

        private String mostrar()
        {
            String paleta = this._cantMaxColores.ToString();

            foreach(Tempera i in this._temperas)
            {
                paleta += " " + Tempera.mostrar(i);
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
            if (a == b)
            {
                Tempera aux = Paleta.buscarTempera(a, b);
                aux += b;
            }
            else
            {
                Tempera aux = Paleta.buscarTempera(a, null);
                aux = b;
            }
            return a;
        }           
        
        private static Tempera buscarTempera(Paleta a, Tempera b)
        {
            Tempera ret = null;
            foreach (Tempera i in a._temperas)
            {
                if (b == i)
                    ret = a._temperas[i];
            }
            return ret;
        }
        
        public static Paleta operator -(Paleta a, Tempera b)
        {
            if(a == b)
        }

        public static Paleta operator +(Paleta a, Paleta b)
        {

        }
    }
}
