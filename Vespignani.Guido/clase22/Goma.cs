using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase22
{
    public class Goma : Utiles
    {
        protected bool _soloLapiz;

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

        public Goma(string marca, double precio, bool soloLapiz)
            : base(marca, precio)
        {
            this._soloLapiz = soloLapiz;
        }
        protected override string UtilesToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine(base.UtilesToString());
            s.AppendLine("Solo lapiz: " + this._soloLapiz);
            return s.ToString();
        }

        public override string ToString()
        {
            return this.UtilesToString();
        }
    }
}
