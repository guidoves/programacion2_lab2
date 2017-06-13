using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase22
{
    public abstract class Utiles
    {
        protected string _marca;
        protected double _precio;

        public abstract double Precio { get; set; }
        public abstract string Marca { get; set; }

        public Utiles(string marca, double precio)
        {
            this.Marca = marca;
            this.Precio = precio;
        }

        protected virtual string UtilesToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine("Marca: " + this._marca);
            s.AppendLine("Precio: " + this._precio);
            return s.ToString();
        }

    }
}
