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
            string moto = Mostrar() +
                this._cilindrada.ToString() + "\n";
            return moto;
        }
    }
}
