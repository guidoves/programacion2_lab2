using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase20
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public DepositoDeAutos(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Auto>();
        }

        private int GetIndice(Auto a)
        {
            return this._lista.IndexOf(a);
        }

        public bool Agregar(Auto a)
        {
            return this + a;
        }
        public bool Remover(Auto a)
        {
            return this - a;
        }

        public override string ToString()
        {
            StringBuilder deposito = new StringBuilder();
            deposito.AppendLine("Capacidad máxima: " + this._capacidadMaxima.ToString());
            deposito.AppendLine("Listado de Autos:");
            foreach (Auto item in this._lista)
            {
                deposito.AppendLine(item.ToString());
            }
            return deposito.ToString();
        }

        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(a);
                return true;
            }
            return false;
        }
        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            int index = d.GetIndice(a);
            if (index != -1)
            {
                d._lista.RemoveAt(index);
                return true;
            }
            return false;
        }
    }
}
