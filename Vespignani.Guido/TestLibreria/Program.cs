using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestLibreria
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa miCosa = new Cosa();
            Console.WriteLine(miCosa.Mostrar());
            Console.ReadLine();
        }
    }
}
