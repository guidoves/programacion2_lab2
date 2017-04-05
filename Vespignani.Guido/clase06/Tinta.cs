using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase06
{
    public class Tinta
    {
        private ConsoleColor _color;
        private ETipo _tipo;

        public Tinta(ConsoleColor color, ETipo tipo)
        {
            this._color = color;
            this._tipo = tipo;
        }
        public Tinta(ConsoleColor color)
            
        {
            this._color = color;
            this._tipo = ETipo.COMUN;
        }
        public Tinta(ETipo tipo)
        {
            this._tipo = tipo;
            this._color = ConsoleColor.Black;
        }
        public Tinta()
        {
            this._tipo = ETipo.COMUN;
            this._color = ConsoleColor.Black;
        }

        private String Mostrar()
        {
            return this._color.ToString() + this._tipo.ToString();
        }

        public static String Mostrar(Tinta miTinta)
        {
            return miTinta.Mostrar();
        }

        public static Boolean operator ==(Tinta a, Tinta b)
        {
            return (a._color == b._color && a._tipo == b._tipo) ? true : false;
        }

        public static Boolean operator !=(Tinta a, Tinta b)
        {
            return !(a == b);
        }

        public static explicit operator String(Tinta a)
        {
            return a.ToString();
        }
    }

    public enum ETipo {COMUN,CHINA,CONBRILLITO }
}
