using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicafinal
{
    public class Producto
    {
        public string nombre;
        public int stock;

        public Producto()
        { }

        public Producto(string nombre, int stock)
        {
            this.nombre = nombre;
            this.stock = stock;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if (p1.nombre == p2.nombre)
                return true;
            else
                return false;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
    }

    
}
