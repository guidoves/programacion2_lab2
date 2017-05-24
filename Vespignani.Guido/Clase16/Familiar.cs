using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16
{
    public class Familiar : Auto
    {
        protected int _cantAsientos;

        public Familiar(double precio, string patente, int asientos):base(patente,precio)
        {
            this._cantAsientos = asientos;
        }

        public override void MostrarPatente()
        {
            Console.WriteLine("Patente: " + base._patente);
        }
    }
}
