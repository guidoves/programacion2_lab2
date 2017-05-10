using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_11
{
    public class ClaseTres : ClaseDos
    {
        protected string _atributoClaseTres;

        public override string Nombre
        {
            get
            {
                return "ClaseTres hereda de " + base.Nombre;
            }
        }

        public ClaseTres(string nombreUno, string nombreDos, string nombreTres):base(nombreUno,nombreDos)
        {
            this._atributoClaseTres = nombreTres;
        }

        protected override string Mostrar()
        {
            return base.Mostrar() + this._atributoClaseTres;
        }
        public override string ToString()
        {
            return Mostrar();
        }
        
    }
}
