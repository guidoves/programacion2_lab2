using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej04
{
    class Program
    {
        static void Main(string[] args)
        {
            Rueda rueda1 = new Rueda();
            Rueda rueda2 = new Rueda();

            rueda1.marca = "Firestone";
            rueda1.tamanio = 165;

            rueda2.marca = "FateO";
            rueda2.tamanio = 175;

            Console.WriteLine(rueda1.Mostrar());
            Console.WriteLine(rueda2.Mostrar());
            Console.ReadLine();

        }
    }
}
