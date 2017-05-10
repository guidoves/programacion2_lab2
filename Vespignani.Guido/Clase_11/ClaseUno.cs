using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_11
{
    public class ClaseUno
    {
        protected string _atributoClaseUno;

        public virtual string Nombre { get { return "ClaseUno"; } }

        public ClaseUno(string nombre)
        {
            this._atributoClaseUno = nombre;
        }

        protected virtual string Mostrar()
        {
            return _atributoClaseUno;
        }
        public override string ToString()
        {
            return Mostrar();
        }
 
    }
}
