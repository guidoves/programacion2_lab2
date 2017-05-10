using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpHerencia
{
    public class Camion : Vehiculo
    {
        protected float _tara;

        public Camion(string patente, byte ruedas, EMarca marca, float tara): base(patente,ruedas,marca)
        {
            this._tara = tara;
        }
        protected override string Mostrar()
        {
            StringBuilder camion = new StringBuilder();
            camion.AppendLine("___________________________________");
            camion.AppendLine("Tipo de vehiculo: Camion");
            camion.AppendLine(base.Mostrar());
            camion.AppendLine("Peso Kg tara: " + this._tara.ToString());
            camion.AppendLine("___________________________________");

            return camion.ToString();
        }
    }
}
