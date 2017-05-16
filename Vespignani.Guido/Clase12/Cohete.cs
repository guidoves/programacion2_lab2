using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12
{
    public class Cohete : Vehiculo
    {
        private string _modelo;

        public override string Detalle
        {
            get { return this.ToString(); }
        }

        public Cohete(int pasajeros, EVelocidad velocidad, string modelo):base(pasajeros,velocidad)
        {
            this._modelo = modelo;
        }
        
        public override string ToString()
        {
            StringBuilder a = new StringBuilder();
            a.Append(base.ToString());
            a.AppendLine("Modelo: " + this._modelo);
            return a.ToString();
        }
        public override string Acelerar()
        {
            return "Aceleracion maxima hasta:" + (int)this._velocidadMaxima;
        }
        public override string Frenar()
        {
            return "El cohete está frenando";
        }
    }
}
