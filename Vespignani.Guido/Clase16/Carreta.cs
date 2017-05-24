using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16
{
    class Carreta : Vehiculo
    {
        public Carreta(double precio)
            : base(precio)
        {
 
        }

        public override double Precio
        {
            get { return base._precio; }
        }
       

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio" + base._precio);
        }
    }
}
