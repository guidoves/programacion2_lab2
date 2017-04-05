using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace clase06
{
    public class Pluma
    {
        private String _marca;
        private Tinta _tinta;
        private int _cantidad;

        public Pluma(String marca, Tinta tinta, int cantidad)
        {
            this._marca = marca;
            this._tinta = tinta;
            this._cantidad = cantidad;
        }
        public Pluma(String marca, Tinta tinta):this()
        {
            this._marca = marca;
            this._tinta = tinta; 
        }
        public Pluma()
        {
            this._marca = "Sin marca";
            this._tinta = null;
            this._cantidad = 1;
        }

        private String Mostrar()
        {
            return (String)this._tinta;
        }

        public static implicit operator String(Pluma a)
        {
            return a;
        }

        public static Boolean operator ==(Pluma a, Tinta b)
        {
            return a._tinta == b ? true : false;
        }

        public static Boolean operator !=(Pluma a, Tinta b)
        {
            return !(a == b);
        }

        public static Pluma operator +(Pluma a, Tinta b)
        {
            if (a == b)
                a._cantidad++;
            return a;
        }
        public static Pluma operator -(Pluma a, Tinta b)
        {
            if (a == b)
                if (a._cantidad != 0)
                    a._cantidad--;
                else
                    a._tinta = null;
            return a;
        }
    }
}
