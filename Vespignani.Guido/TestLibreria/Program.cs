using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase12;

namespace TestLibreria
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo caballo1 = new Caballo(2, EVelocidad.Media, "raza", "blanco");
            Auto auto1 = new Auto(4, EVelocidad.Hiper, 4);
            Cohete cohete1 = new Cohete(2, EVelocidad.Super, "A8");
            List<Vehiculo> lista = new List<Vehiculo>();
            lista.Add(caballo1);
            lista.Add(auto1);
            lista.Add(cohete1);

            foreach (Vehiculo item in lista)
            {
                Console.WriteLine(item.Detalle);
                Console.WriteLine(item.Acelerar());
            }
            
            Console.ReadLine();
           
           
        }
    }
}
