using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cosa
    {
        public int entero;
        public String cadena;
        public DateTime fecha;

        public Cosa(int entero, String cadena, DateTime fecha)
        {
            this.entero = entero;
            this.cadena = cadena;
            this.fecha = fecha;
        }
        public Cosa(String cadena, DateTime fecha)
        {
            this.cadena = cadena;
            this.fecha = fecha;
            this.entero = 10;
        }
        public Cosa(String cadena)
        {
            this.cadena = cadena;
            this.fecha = DateTime.Now;
            this.entero = 10;
        }
        public Cosa()
        {
            this.cadena = "Sin valor.";
            this.fecha = DateTime.Now;
            this.entero = 10;
        }

        public String Mostrar()
        {
            String a = this.entero + " " + this.cadena + " " + this.fecha;
            return a;
        }

        public void EstablecerValor(String valor)
        {
            this.cadena = valor;
        }
        public void EstablecerValor(int valor)
        {
            this.entero = valor;
        }
        public void EstablecerValor(DateTime valor)
        {
            this.fecha = valor;
        }

    }
}
