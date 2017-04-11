using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7
{
    class Program
    {
        public static void main(String[] args)
        {
            Tempera _tempera1 = new Tempera(ConsoleColor.Black, "a", 4);
            Tempera _tempera2 = new Tempera(ConsoleColor.Black, "a", 8);


            Console.WriteLine(_tempera1 == _tempera2);
            Console.ReadLine();

        }
    }
}
