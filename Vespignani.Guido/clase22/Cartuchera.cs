using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase22
{
    public class Cartuchera<T>
    {
        public string marca;
        private int _capacidad;
        protected List<T> _elementos;

        public T Elementos
        {
            set
            {
                if (this._elementos.Count < this._capacidad)
                {
                    this._elementos.Add(value);
                }
                else
                {
                    throw new CartucheraLlenaException("Cartuchera llena");
                }
            } 
        }

        public Cartuchera(string marca, int capacidad)
        {
            this.marca = marca;
            this._capacidad = capacidad;
            this._elementos = new List<T>();
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine("Marca: " + this.marca);
            s.AppendLine("Capacidad: " + this._capacidad);
            s.AppendLine("Utiles:");
            foreach (T item in this._elementos)
            {
                s.AppendLine(item.ToString());
            }
            return s.ToString();
        }
    }
}
