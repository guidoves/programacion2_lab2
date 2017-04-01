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
            Carrera miCarrera = new Carrera();
            miCarrera.MostrarCarrera();
            Console.ReadLine();
            //Rueda rueda1 = new Rueda();
            //Rueda rueda2 = new Rueda();

            //eFabricante mifab = eFabricante.FORD;
            //String x = "honda";
            //mifab = (eFabricante)Enum.Parse(typeof(eFabricante), x, true);
            //Console.WriteLine(mifab);

            //Auto auto1 = new Auto();
            //Auto auto2 = new Auto();
            //Auto auto3 = new Auto();
            //Auto auto4 = new Auto();
            //Auto auto5 = new Auto();
            //Auto auto6 = new Auto();
            //Auto auto7 = new Auto();
            
           
            //Console.WriteLine(auto1.MostrarAuto());
            //Console.WriteLine(auto2.MostrarAuto());
            //Console.WriteLine(auto3.MostrarAuto());
            //Console.WriteLine(auto4.MostrarAuto());
            //Console.WriteLine(auto5.MostrarAuto());
            //Console.WriteLine(auto6.MostrarAuto());
            //Console.WriteLine(auto7.MostrarAuto());
            //Console.ReadLine();
           // foreach (String elementos in Enum.GetNames(typeof(eFabricante)))
           // {
           //     Console.WriteLine(elementos);
           // }
           // foreach(eFabricante valores in Enum.GetValues(typeof(eFabricante)))
           // {
           //     Console.WriteLine((int)valores);
           // }
           // //eFabricante fabri1 = Console.ReadLine();
           //// Console.WriteLine(fabri1);


            
           // /*rueda1.marca = "Firestone";
           // rueda1.tamanio = 165;

           // rueda2.marca = "FateO";
           // rueda2.tamanio = 175;*/

           //// Console.WriteLine(rueda1.Mostrar());
           // //Console.WriteLine(rueda2.Mostrar());
           // Console.ReadLine();

        }
    }
}
