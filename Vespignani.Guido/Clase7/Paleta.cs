using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7
{
    public class Paleta
    {
        #region Variables de instancia

        private Tempera[] _temperas;
        private int _cantMaxColores;

        #endregion

        #region Constructores

        private Paleta():this(5)
        {
        }
        public Paleta(int cantidad)
        {
            this._temperas = new Tempera[0];
            this._cantMaxColores = cantidad;
            //for (int i = 0; i < this._temperas.Length; i++ )
            //{ this._temperas[i] = new Tempera(ConsoleColor.Black, "pirilo", 8); }
        }

        #endregion

        #region Indexador

        public Tempera this[int index]
        {
            get
            {
                if (index < 0 || index >= this._temperas.GetLength(0))
                {
                    Console.WriteLine("Indice inválido.");
                    Console.ReadLine();
                    return null;
                }
                else
                    return this._temperas[index];
            }
            set
            {
                if (index > 0 && index < this._temperas.GetLength(0))
                    this._temperas[index] = value;
                else 
                    Console.WriteLine("Indice inválido.");
                Console.ReadLine();
            }
        }

        #endregion

        #region Metodos de instancia

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

        #endregion

        #region Metodos de clase

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
            if ((a.obtenerIndice(b) != -1))
                retValue = true;
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
            }
            else
            {
                int aux = a.obtenerIndice(b);
                if(aux >= 0)
                a._temperas[aux] = b;   
            }
            return a;
        }

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
                    a._temperas[aux] += -(cantidadA-cantidadB);
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

        #endregion
    }
}
