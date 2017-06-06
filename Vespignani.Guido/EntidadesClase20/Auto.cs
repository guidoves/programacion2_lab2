using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase20
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Color
        {
            get { return this._color; }
        }

        public string Marca
        { 
            get { return this._marca; } 
        }

        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }

        public static bool operator ==(Auto a, Auto b)
        {
            if (a._marca == b._marca && b._color == a._color)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }
        public override bool Equals(object obj)
        {
            if (obj is Auto && this == obj)
                return true;
            return false;
        }
        public override string ToString()
        {
            StringBuilder auto = new StringBuilder();
            auto.AppendLine("Color: " + this._color);
            auto.AppendLine("Marca: " + this._marca);
            return auto.ToString();
        } 
    }
}
