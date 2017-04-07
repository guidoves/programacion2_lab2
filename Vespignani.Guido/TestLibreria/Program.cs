using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Clase7;

namespace TestLibreria
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = {2.543,5.2123,76.8,20.9,9};

            foreach (double i in array)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            
        }
    }
}
