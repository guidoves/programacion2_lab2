using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7
{
    public class Tempera
    {
        #region Variables de instancia

        private ConsoleColor _color;
        private String _marca;
        private int _cantidad;

        #endregion

        #region Constructor

        public Tempera(ConsoleColor color, String marca, int cantidad)
        {
            this._color = color;
            this._marca = marca;
            this._cantidad = cantidad;
        }

        #endregion


        public static String Mostrar(Tempera a)
        {
            return a.Mostrar();
        }

        private String Mostrar()
        {
            return this._marca + " " + this._color + " " + this._cantidad;
        }

        public static Boolean operator ==(Tempera a, Tempera b)
        {
            if (a._color == b._color && a._marca == b._marca)
                return true;
            return false;
        }
        public static Boolean operator !=(Tempera a, Tempera b)
        {
            return !(a == b);
        }
        public static implicit operator int(Tempera a)
        {
            return a._cantidad;
        }
        public static explicit operator String(Tempera a)
        {
            return a.Mostrar();
        }
        public static Tempera operator +(Tempera a, Tempera b)
        {
            if (a == b)
                a._cantidad++;
            return a;
        }
        public static Tempera operator +(Tempera a, int cantidad)
        {
            a._cantidad = a._cantidad + cantidad;
            return a;
        }

        
    }
}
