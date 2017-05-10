using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_11
{
    public class ClaseCuatro : ClaseTres
    {
        protected string _atributoClaseCuatro;

        public ClaseCuatro(string nombreuno, string nombredos, string nombretres, string nombrecuatro)
            : base(nombreuno, nombredos, nombretres)
        {
            this._atributoClaseCuatro = nombrecuatro;
        }
    }
    
    
}
