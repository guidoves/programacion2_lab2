using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vespignani.Guido.ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            Comparadora.MostrarEldelMedio(44,84,55);
            Sello.mensaje = "HOLA MUNDO";
            System.Console.WriteLine(Sello.Imprimir());
            System.Console.ReadLine();
            System.Console.WriteLine(Sello.Imprimir()); 
            System.Console.ReadLine();
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();
            System.Console.ReadLine();
     
        }
    }

}
