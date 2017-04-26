using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpHerencia
{
    public class Lavadero
    {
        #region Variables de instancia
        private List<Vehiculo> _vehiculos;
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;
        #endregion

        #region Constructores
        public Lavadero(float pAuto, float pCamion,float pMoto):this()
        {
            this._precioAuto = pAuto;
            this._precioCamion = pCamion;
            this._precioMoto = pMoto;
        }
        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
        }
        #endregion

        #region Propiedades
        public String LavaderoInfo
        {
            get 
            {
                StringBuilder informacion = new StringBuilder();
                informacion.AppendLine("***********************************LAVADERO***********************************");
                informacion.AppendLine("Precio p/Camion: " + "$" + this._precioCamion.ToString());
                informacion.AppendLine("Precio p/Auto: " + "$" + this._precioAuto.ToString());
                informacion.AppendLine("Precio p/Moto: " + "$" + this._precioMoto.ToString());
                informacion.AppendLine("Lista de vehiculos:");
                foreach (Vehiculo item in this._vehiculos)
                {
                    if(item is Auto)
                        informacion.AppendLine(((Auto)item).MostrarAuto());
                    else if(item is Camion)
                        informacion.AppendLine(((Camion)item).MostrarCamion());
                    else
                        informacion.AppendLine(((Moto)item).MostrarMoto());
                }
                informacion.AppendLine("***********************************LAVADERO***********************************");
                return informacion.ToString();
            }        
        }
        public List<Vehiculo> Vehiculos
        {
            get { return this._vehiculos; }
        }
#endregion

        #region Sobrecargas
        public static bool operator ==(Lavadero a, Vehiculo b)
        {
            foreach (Vehiculo item in a._vehiculos)
            {
                if (item == b)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Lavadero a, Vehiculo b)
        {
            return !(a == b);
        }
        public static Lavadero operator +(Lavadero a, Vehiculo b)
        {
            if (a != b)
                a._vehiculos.Add(b);
            return a;
        }
        public static Lavadero operator -(Lavadero a, Vehiculo b)
        {
            foreach (Vehiculo item in a._vehiculos)
            {
                if (item == b)
                {
                    a._vehiculos.Remove(item);
                    break;
                }
            }
            return a;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Calcula y retorna el total facturado.
        /// </summary>
        /// <returns>Devuelve el total.</returns>
        /// 
        public double MostrarTotalFacturado()
        {
            double total = 0;
            foreach (Vehiculo item in this._vehiculos)
            {
                    if (item is Auto)
                        total += this._precioAuto;
                    else if (item is Camion)
                        total += this._precioCamion;
                    else
                        total += this._precioMoto;
            }
            return total;
        }
        public double MostrarTotalFacturado(EVehiculos vehiculo)
        {
            double total = 0;
            foreach (Vehiculo item in this._vehiculos)
            {
                if (vehiculo == EVehiculos.AUTO && item is Auto)
                    total += this._precioAuto;
                else if (vehiculo == EVehiculos.CAMION && item is Camion)
                    total += this._precioCamion;
                else if (vehiculo == EVehiculos.MOTO && item is Moto)
                    total += this._precioMoto;
            }
            return total;

        }
        public int OrdenarVehiculosPorMarca(Vehiculo a, Vehiculo b)
        {
            if (string.Compare(a.Marca.ToString(), b.Marca.ToString()) == 0)
                return 0;
            if (string.Compare(a.Marca.ToString(), b.Marca.ToString()) > 0)
                return 1;
            if (string.Compare(a.Marca.ToString(), b.Marca.ToString()) < 0)
                return -1;
            return 0;
        }

        public static int OrdenarVehiculosPorPatente(Vehiculo a, Vehiculo b)
        {
            if (string.Compare(a.Patente,b.Patente) == 0)
                return 0;
            if (string.Compare(a.Patente,b.Patente) > 0)
                return 1;
            if (string.Compare(a.Patente, b.Patente) < 0)
                return -1;
            return 0;
        }
        #endregion
    }
}
