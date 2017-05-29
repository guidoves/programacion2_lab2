using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16bis
{
    public class Carreta : Vehiculo,IARBA
    {
        public Carreta(double precio)
            : base(precio)
        { }

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio: " + base._precio.ToString());
        }

        public double CalcularImpuesto()
        {
            return (base._precio*18)/100;
        }
    }
}
