using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autos;
using AutoPartes;


namespace Ej04
{
    class Program
    {
        static void Main(string[] args)
        {
            Rueda rueda1 = new Rueda();
            Rueda rueda2 = new Rueda();

            

            Auto auto1 = new Auto();
            Auto auto2 = new Auto();
            Auto auto3 = new Auto();
            Auto auto4 = new Auto();
            
            Console.WriteLine(auto1.MostrarAuto());
            Console.ReadLine();
            Console.WriteLine("Ingrese:");
            eFabricante fabri1 = Console.ReadLine();
            Console.WriteLine(fabri1);


            
            /*rueda1.marca = "Firestone";
            rueda1.tamanio = 165;

            rueda2.marca = "FateO";
            rueda2.tamanio = 175;*/

           // Console.WriteLine(rueda1.Mostrar());
            //Console.WriteLine(rueda2.Mostrar());
            Console.ReadLine();

        }
    }
}
