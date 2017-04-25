using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpHerencia
{
    public class Auto : Vehiculo
    {
        protected int _cantidadAsientos;

        public Auto(string patente, byte ruedas, EMarcas marca, int asientos): base(patente,ruedas,marca)
        {
            this._cantidadAsientos = asientos;
        }

    }
}
