using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16bis
{
    public class Deportivo : Auto,IARBA,IAFIP
    {
        protected int _caballosFuerza;

        public Deportivo(double precio, string patente, int caballos)
            : base(precio, patente)
        {
            this._caballosFuerza = caballos;
        }

        double IARBA.CalcularImpuesto()
        {
            return(base._precio*23)/100;
        }

        double IAFIP.CalcularImpuesto()
        {
            return(base._precio*28)/100;
        }
    }
}
