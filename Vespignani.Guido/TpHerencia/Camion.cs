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
            string camion = Mostrar() +
                this._tara.ToString() + "\n";
            return camion;
        }
    }
}
