using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpHerencia
{
    public class Moto : Vehiculo
    {
        protected float _cilindrada;

        public Moto(string patente, byte ruedas, EMarca marca, float cilindrada):base(patente,ruedas,marca)
        {
            this._cilindrada = cilindrada;
        }

        public string MostrarMoto()
        {
            StringBuilder moto = new StringBuilder();
            moto.AppendLine("___________________________________");
            moto.AppendLine("Tipo de vehiculo: Moto");
            moto.AppendLine(Mostrar());
            moto.AppendLine("Cilindrada cc: " + this._cilindrada.ToString());
            moto.AppendLine("___________________________________");

            return moto.ToString();
        }
    }
}
