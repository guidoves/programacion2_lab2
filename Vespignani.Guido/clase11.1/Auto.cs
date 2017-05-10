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

        public Auto(string patente, byte ruedas, EMarca marca, int asientos): base(patente,ruedas,marca)
        {
            this._cantidadAsientos = asientos;
        }

        protected override string Mostrar()
        {
            StringBuilder auto = new StringBuilder();
            auto.AppendLine("___________________________________");
            auto.AppendLine("Tipo de vehiculo: Auto");
            auto.AppendLine(base.Mostrar());
            auto.AppendLine("Cantidad de asientos: " + this._cantidadAsientos.ToString());
            auto.AppendLine("___________________________________");

            return auto.ToString();
        }
    }
}
