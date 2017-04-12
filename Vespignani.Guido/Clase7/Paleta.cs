using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7
{
    public class Paleta
    {
        #region Variables

        private Tempera[] _temperas;
        private int _cantMaxColores;

        #endregion

        #region Constructores

        private Paleta():this(5)
        {
        }
        public Paleta(int cantidad)
        {
            this._temperas = new Tempera[cantidad];
            this._cantMaxColores = cantidad;
        }

        #endregion



        private String mostrar()
        {
            String paleta = this._cantMaxColores.ToString();

            foreach(Tempera i in this._temperas)
            {
                paleta += " " + Tempera.mostrar(i);
            }
            return paleta;
        }

        private int obtenerIndice()
        {
            int retValue = -1;
            for (int i = 0; i < this._temperas.Length; i++)
            {
                if (this._temperas[i] == null)
                {
                    retValue = i;
                    break;
                }
            }
            return retValue;
        }
        private int obtenerIndice(Tempera a)
        {
            int retValue = -1;
            for (int i = 0; i < this._temperas.Length; i++)
            {
                if (this._temperas[i] == a)
                {
                    retValue = i;
                    break;
                }
            }
            return retValue;
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
            Boolean retValue = false;
            foreach (Tempera i in a._temperas)
            {
                if (b == i)
                    retValue = true;
            }
            return retValue;
        }
        public static Boolean operator !=(Paleta a, Tempera b)
        {
            return !(a == b);
        }
        public static Paleta operator +(Paleta a, Tempera b)
        {
            if (a == b)
            {
                int aux = a.obtenerIndice(b);
                if(aux >= 0)
                a._temperas[aux] += b;
                //Tempera aux = Paleta.buscarTempera(a, b);
                //aux += b;
            }
            else
            {
                int aux = a.obtenerIndice(b);
                if(aux >= 0)
                a._temperas[aux] = b;   
                //Tempera aux = Paleta.buscarTempera(a, null);
                //aux = b;
            }
            return a;
        }

        //private static Tempera buscarTempera(Paleta a, Tempera b)
        //{
        //    Tempera ret = null;
        //    foreach (Tempera i in a._temperas)
        //    {
        //        if (b == i)
        //            ret = a._temperas[i];
        //    }
        //    return ret;
        //}
        
        public static Paleta operator -(Paleta a, Tempera b)
        {
            if (a == b)
            {
                int aux = a.obtenerIndice(b);
                int cantidadA = a._temperas[aux];
                int cantidadB = b;
                if ((cantidadA - cantidadB) <= 0)
                    a._temperas[aux] = null;
                else
                {
                }
            }
            return a;
        }

        public static Paleta operator +(Paleta a, Paleta b)
        {
            Paleta c = new Paleta(a._cantMaxColores + b._cantMaxColores);
            c._temperas = a._temperas;
            foreach (Tempera i in b._temperas)
            {
                c += i;
            }
            return c;
        }
    }
}
