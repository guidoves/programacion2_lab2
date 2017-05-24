using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16
{
    public class Avion : Vehiculo, IAFIP
    {
        protected double _velocidadMaxima;

        public override double Precio
        {
            get { return base._precio; }
        }
        public virtual double VelocidadMaxima { get { return this._velocidadMaxima; } }

        public Avion(double precio, double velMax)
            : base(precio)
        {
            this._velocidadMaxima = velMax;
        }

        public double CalcularImpuesto()
        {
            return (base._precio * 33) / 100;
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio: " + base._precio);
        }

        
        
    }
}
