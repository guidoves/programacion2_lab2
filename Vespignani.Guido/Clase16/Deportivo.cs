using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16
{
    public class Deportivo : Auto , IAFIP
    {
        protected int _caballoFuerza;

        public Deportivo(double precio, string patente, int cf)
            : base(patente, precio)
        {
            this._caballoFuerza = cf;
        }

        public double CalcularImpuesto()
        {
            return (base._precio * 28) / 100;
        }

        public override void MostrarPatente()
        {
            Console.WriteLine("Patente: " + base._patente);
        }

        
    }
}
