using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9
{
    public class Paleta
    {
        #region Variables de instancia

        private List<Tempera> _temperas;
        private int _cantMaxColores;

        #endregion

        #region Constructores

        private Paleta():this(5)
        {
        }
        public Paleta(int cantidad)
        {
            this._temperas = new List<Tempera>();
            this._cantMaxColores = cantidad;       
        }

        #endregion

        #region Indexador

        public Tempera this[int index]
        {
            get
            {
                if (index < 0 || index >= this._temperas.Count)
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
                if (index > 0 && index < this._temperas.Count)
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

        #endregion

        #region Metodos sobrecargados

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
            foreach (Tempera item in a._temperas)
            {
                if (item == b)
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
                int index = a._temperas.IndexOf(b);
                a._temperas[index] += b;
            }
            else
            {
                if (a._cantMaxColores > a._temperas.Count)
                    a._temperas.Add(b);   
            }
            return a;
        }

        public static Paleta operator -(Paleta a, Tempera b)
        {
            if (a == b)
            {
                int index = a._temperas.IndexOf(b);
                int cantidadA = a._temperas[index];
                int cantidadB = b;
                if ((cantidadA - cantidadB) <= 0)
                    a._temperas[index] = null;
                else
                {
                    a._temperas[index] += -(cantidadA-cantidadB);
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
