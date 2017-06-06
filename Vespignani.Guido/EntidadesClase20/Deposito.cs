using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase20
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;
        public T atr;

        public Deposito(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>();
            this.atr = default(T);
        }

        public bool Agregar(T a)
        {
            return this + a;
        }
        public bool Remover(T a)
        {
            return this - a;
        }

        private int GetIndice(T a)
        {
            return this._lista.IndexOf(a);
        }

        public static bool operator +(Deposito<T> d, T a)
        {
            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(a);
                return true;
            }
            return false;
        }
        public static bool operator -(Deposito<T> d, T a)
        {
            int index = d.GetIndice(a);
            if (index != -1)
            {
                d._lista.RemoveAt(index);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder deposito = new StringBuilder();
            deposito.AppendLine("Capacidad máxima: " + this._capacidadMaxima);
            deposito.AppendLine("Listado de "+typeof(T).Name);
            foreach (T item in this._lista)
            {
                deposito.AppendLine(item.ToString());
            }
            return deposito.ToString();
        }

    }
}
