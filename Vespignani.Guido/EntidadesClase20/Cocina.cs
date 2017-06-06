using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase20
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;

        public int Codigo
        {
            get { return this._codigo; }
        }
        public bool EsIndustrial 
        {
            get { return this._esIndustrial; }
        }
        public double Precio
        {
            get { return this._precio; }
        }

        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = esIndustrial;
        }

        public static bool operator ==(Cocina a, Cocina b)
        {
            if (a.Codigo == b.Codigo)
                return true;
            return false;
        }
        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }
        public override bool Equals(object obj)
        {
            if(obj is Cocina && this == obj)
                return true;
            return false;
        }
        public override string ToString()
        {
            StringBuilder cocina = new StringBuilder();
            cocina.AppendLine("Codigo: " + this._codigo.ToString());
            cocina.AppendLine("Precio: " + this._precio.ToString());
            cocina.AppendLine("¿Es industrial? " + this._esIndustrial.ToString());
            return cocina.ToString();
        }
    }
}
