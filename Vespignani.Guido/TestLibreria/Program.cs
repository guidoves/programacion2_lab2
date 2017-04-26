using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpHerencia;

namespace TestLibreria
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Lavadero lavadero = new Lavadero(250,500,100);
            Auto auto1 = new Auto("AAC4", 4, EMarca.FORD, 4);
            Auto auto2 = new Auto("ZAC8", 4, EMarca.HONDA, 4);
            Camion camion1 = new Camion("CC45", 6, EMarca.IVECO,2330f);
            Camion camion2 = new Camion("7C45", 6, EMarca.SCANIA, 850f);
            Moto moto1 = new Moto("X4C3", 2, EMarca.HONDA, 125);
            Moto moto2 = new Moto("BB3A", 2, EMarca.FORD, 250);
            lavadero.Vehiculos.Add(auto1);
            lavadero.Vehiculos.Add(auto2);
            lavadero.Vehiculos.Add(camion1);
            lavadero.Vehiculos.Add(camion2);
            lavadero.Vehiculos.Add(moto1);
            //lavadero.Vehiculos.Add(moto2);
            lavadero += moto2;
            //lavadero -= moto2;
            lavadero.Vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);
            Console.WriteLine(lavadero.LavaderoInfo);
            Console.WriteLine();
            Console.WriteLine(lavadero.MostrarTotalFacturado();
            Console.ReadLine();
           
        }
    }
}
