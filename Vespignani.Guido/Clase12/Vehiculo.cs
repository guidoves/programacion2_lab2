using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12
{
    public abstract class Vehiculo
    {
        protected int _cantPasajeros;
        protected EVelocidad _velocidadMaxima;

        public abstract string Detalle {get;}

        public Vehiculo(int pasajeros, EVelocidad velocidad)
        {
            this._cantPasajeros = pasajeros;
            this._velocidadMaxima = velocidad;
        }

        public override string ToString()
        {
            StringBuilder a = new StringBuilder();
            a.AppendLine("Cantidad de pasajeros: " + this._cantPasajeros.ToString());
            a.AppendLine("Velocidad maxima: " + this._velocidadMaxima.ToString());
            return a.ToString();
        }
        public virtual string Acelerar()
        {
            return "Aceleracion maxima: " + (int)this._velocidadMaxima ;
        }
        public abstract string Frenar();
        

    }
}
