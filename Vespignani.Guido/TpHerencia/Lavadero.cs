using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpHerencia
{
    public class Lavadero
    {
        private List<Vehiculo> _vehiculos;
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;

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

        #region Propiedades
        public String LavaderoInfo
        {
            get 
            {
                string informacion = "Precio por Auto: " + "$" + this._precioAuto.ToString() + "\n" +
                    "Precio por Camion: " + "$" + this._precioCamion.ToString() + "\n" +
                    "Precio por Moto: " + "$" + this._precioMoto.ToString() + "\n" +
                    "Lista de vehiculos:" + "\n";
                foreach (Vehiculo item in this._vehiculos)
                {
                    if (item is Auto)
                        informacion += ((Auto)item).MostrarAuto();
                    else if (item is Camion)
                        informacion += ((Camion)item).MostrarCamion();
                    else
                        informacion += ((Moto)item).MostrarMoto();
                }
                return informacion;

            }        
        }
        public List<Vehiculo> Vehiculos
        {
            get { return this._vehiculos; }
        }
#endregion

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

            if (vehiculo == EVehiculos.AUTO)
            {
                foreach (Vehiculo item in this._vehiculos)
                {
                    if (item is Auto)
                        total += this._precioAuto;
                }
            }
            else if (vehiculo == EVehiculos.CAMION)
            {
                foreach (Vehiculo item in this._vehiculos)
                {
                    if (item is Camion)
                        total += this._precioCamion;
                }
            }
            else
            {
                foreach (Vehiculo item in this._vehiculos)
                {
                    if (item is Moto)
                        total += this._precioMoto;
                }
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
    }
}
