using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej04
{
    class Rueda
    {
        public String marca;
        public int tamanio;

        public String Mostrar()
        {
            String retorno = this.marca + " " + this.tamanio;
            return retorno;
        }
    }
}
