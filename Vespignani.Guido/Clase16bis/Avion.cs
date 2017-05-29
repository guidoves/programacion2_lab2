using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16bis
{
    public class Avion : Vehiculo,IAFIP,IARBA
    {
        protected double _velocidadMaxima;

        public Avion(double precio, double velMax)
            : base(precio)
        {
            this._velocidadMaxima = velMax;
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio: " + base._precio.ToString());
        }

        double IAFIP.CalcularImpuesto()
        {
            return (base._precio*33)/100;
        }

        double IARBA.CalcularImpuesto()
        {
            return (base._precio*27)/100;
        }
    }
}
