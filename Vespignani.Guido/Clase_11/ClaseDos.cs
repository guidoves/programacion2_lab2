using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_11
{
    public class ClaseDos : ClaseUno
    {
        protected string _atributoClaseDos;

        public override string Nombre
        {
            get
            {
                return "ClaseDos Hereda de " + base.Nombre;
            }
        }

        public ClaseDos(string nombreUno, string nombreDos):base(nombreUno)
        {
            this._atributoClaseDos = nombreDos;
        }
        protected override string Mostrar()
        {
            return base.Mostrar() + this._atributoClaseDos;
        }
        public override string ToString()
        {
            return Mostrar();
        }
        
    }
}
