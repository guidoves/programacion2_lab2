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
        public eFabricante fabricante;
        private int kilometrosRecorridos;

        public static int contadorDeObjetos;
        public static Random numeroRandom;


        public Auto()
        {
            this.delanteraIzq = new Rueda();
            this.delanteraDer = new Rueda();
            this.traseraDer = new Rueda();
            this.traseraIzq = new Rueda();
            this.fabricante = (eFabricante)Auto.numeroRandom.Next(3);
            Auto.contadorDeObjetos++;

        }

        static Auto()
        {
            Auto.contadorDeObjetos = 0;
            Auto.numeroRandom = new Random();
        }


        public String MostrarAuto()
        {
            String infoAuto = "Rueda delantera derecha: " + delanteraDer.Mostrar() + "\n" +
                "Rueda delantera izquierda: " + delanteraIzq.Mostrar() + "\n" +
                "Rueda trasera derecha: " + traseraDer.Mostrar() + "\n" +
                "Rueda trasera izquierda: " + traseraIzq.Mostrar() + "\n" +
                "Fabricante: " + this.fabricante + "\n";
            
            return infoAuto;
        }
        public void AgregarKilometros(int kilometros)
        {
            this.kilometrosRecorridos = this.kilometrosRecorridos + kilometros;
        }
        public void VolverACero()
        {
            this.kilometrosRecorridos = 0;
        }
        public int GetKms()
        {
            return this.kilometrosRecorridos;
        }
    }
}
