using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartes
{
    class Rueda
    {
        public String marca;
        public int tamanio;

        public Rueda()
        {
            this.marca = "Sin marca.";
            this.tamanio = 165;
        }

        public String Mostrar()
        {
            String retorno = this.marca + " " + this.tamanio;
            return retorno;
        }
    }
}
