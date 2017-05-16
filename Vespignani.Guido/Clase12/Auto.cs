using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12
{
    public enum EVelocidad
    {
        Minima = 40,
        Media = 60,
        Alta = 110,
        Super = 180,
        Hiper = 720
    }

    public class Auto : Vehiculo
    {
        private int _cantRuedas;

        public override string Detalle
        {
            get { return this.ToString(); }
        }

        public Auto(int pasajeros, EVelocidad velocidad, int ruedas):base(pasajeros,velocidad)
        {
            this._cantRuedas = ruedas;
        }
        public override string ToString()
        {
            StringBuilder a = new StringBuilder();
            a.Append(base.ToString());
            a.AppendLine("Cantidad de ruedas: " + this._cantRuedas.ToString());
            return a.ToString();
        }
        public override string Acelerar()
        {
            return "Aceleracion maxima hasta: " + (int)this._velocidadMaxima;
        }
        public override string Frenar()
        {
            return "El auto esta frenando.";
        }
    }
}
