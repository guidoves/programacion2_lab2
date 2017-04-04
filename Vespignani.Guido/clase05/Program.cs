using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase05
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa miCosa = new Cosa();
            
            //miCosa.EstablecerValor("Hola");
            //miCosa.EstablecerValor(33);
            //miCosa.EstablecerValor(DateTime.Now);
            Console.WriteLine(miCosa.Mostrar());
            Console.ReadLine();
        }
    }
}
