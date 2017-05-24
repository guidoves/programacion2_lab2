using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16
{
    public abstract class Auto : Vehiculo
    {
        protected string _patente;

        public override double Precio
        {
            get { return base._precio; }
        }

        public abstract string Patente { get; }

        public Auto(string patente, double precio)
            : base(precio)
        {
            this._patente = patente;
        }

        public abstract void MostrarPatente();

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio: " + base._precio.ToString());
        }


    }
}
