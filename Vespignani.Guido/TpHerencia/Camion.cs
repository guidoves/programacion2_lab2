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

        public string MostrarCamion()
        {
            StringBuilder camion = new StringBuilder();
            camion.AppendLine("___________________________________");
            camion.AppendLine("Tipo de vehiculo: Camion");
            camion.AppendLine(Mostrar());
            camion.AppendLine("Peso Kg tara: " + this._tara.ToString());
            camion.AppendLine("___________________________________");

            return camion.ToString();
        }
    }
}
