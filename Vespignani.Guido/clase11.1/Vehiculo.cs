using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpHerencia
{
    public class Vehiculo
    {
        protected string _patente;
        protected byte _cantRuedas;
        protected EMarca _marca;
        
        #region Constructores
        public Vehiculo(string patente, byte ruedas, EMarca marca)
        {
            this._patente = patente;
            this._cantRuedas = ruedas;
            this._marca = marca;
        }
        #endregion

        #region Propiedades
        public string Patente
        {
            get { return this._patente; }
        }
        public EMarca Marca
        {
            get { return this._marca; }
        }
        #endregion

        #region Metodos Instancia
        protected virtual string Mostrar()
        {
            string vehiculo = "Patente: " + this._patente + "\n" +
                "Cantidad de ruedas: " + this._cantRuedas.ToString() + "\n" +
                "Marca: " + this._marca;
            return vehiculo;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
#endregion
        
        #region Sobrecargas
        public override bool Equals(object obj)
        {
            if (obj is Vehiculo)
            {
                return (this == ((Vehiculo)obj));
            }
            return false;
            //return base.Equals(obj);
        }
        public static bool operator ==(Vehiculo a, Vehiculo b)
        {
            if (a._patente == b._patente && a._patente == b._patente)
                return true;
            return false;    
        }
        public static bool operator !=(Vehiculo a, Vehiculo b)
        {
            return !(a == b);
        }
        #endregion

    }

    
}
