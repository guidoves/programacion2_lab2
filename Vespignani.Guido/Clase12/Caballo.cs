using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12
{
    public class Caballo : Vehiculo
    {
        private string _raza;
        private string _color;

        public override string Detalle
        {
            get { return this.ToString(); }
        }

        public Caballo(int pasajeros, EVelocidad velocidad, string raza, string color):base(pasajeros,velocidad)
        {
            this._raza = raza;
            this._color = color;
        }

        public override string ToString()
        {
            StringBuilder a = new StringBuilder();
            a.Append(base.ToString());
            a.AppendLine("Raza: " + this._raza);
            a.AppendLine("Color: " + this._color);
            return a.ToString();
        }
        public override string Acelerar()
        {
            return "Aceleracion maxima hasta: " + (int)this._velocidadMaxima;
        }
        public override string Frenar()
        {
            return "El caballo esta frenando.";
        }
    }

    

    
}
