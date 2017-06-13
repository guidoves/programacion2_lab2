using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase22
{
    public class Lapicera : Utiles
    {
        protected ConsoleColor _color;
        protected string _trazo;

        public Lapicera(string marca, double precio, ConsoleColor color, string trazo)
            : base(marca, precio)
        {
            this._color = color;
            this._trazo = trazo;
        }

        public override string Marca
        {
            get
            {
                return base._marca;
            }
            set
            {
                base._marca = value;
            }
        }
        public override double Precio
        {
            get
            {
                return base._precio;
            }
            set
            {
                base._precio = value;
            }
        }
        protected override string UtilesToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine(base.UtilesToString());
            s.AppendLine("Color: "+ this._color);
            s.AppendLine("Trazo: " + this._trazo);
            return s.ToString();
        }
        public override string ToString()
        {
            return this.UtilesToString();
        }
    }
}
