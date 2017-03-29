using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos
{
    using AutoPartes;

    class Auto
    {
        
        public Rueda delanteraDer;
        public Rueda delanteraIzq;
        public Rueda traseraDer;
        public Rueda traseraIzq;
        public String fabricante;

        public static int contadorDeObjetos;


        public Auto()
        {
           this.delanteraIzq = new Rueda();
           this.delanteraDer = new Rueda();

           this.traseraDer = new Rueda();
           this.traseraIzq = new Rueda();
           Auto.contadorDeObjetos++;
        }

        static Auto()
        {
            Auto.contadorDeObjetos = 0; 
        }


        public String MostrarAuto()
        {
            String retorno = delanteraDer.Mostrar() + "\n" + delanteraIzq.Mostrar() + "\n" + traseraDer.Mostrar() + "\n" + traseraIzq.Mostrar() + "\n"+this.fabricante+"\n"+Auto.contadorDeObjetos;
            return retorno;
        }
    }
}
