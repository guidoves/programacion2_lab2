using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vespignani.Guido.ej3
{
    class Comparadora
    {
        public static int RetornarMayor(int num1, int num2)
        {
            int retorno;
            if (num1 > num2 )
                retorno = num1;
            else
                retorno = num2;
            return retorno;
        }
        public static void MostrarEldelMedio(int num1, int num2, int num3)
        {
            if (num1 > num2 && num2 > num3 || num3 > num2 && num2 > num1) 
                System.Console.WriteLine("Valor del medio: {0}", num2);
            else if (num2 > num1 && num1 > num3 || num3 > num1 && num1 > num2)
                System.Console.WriteLine("Valor del medio: {0}", num1);
            else if (num1 > num3 && num3 > num2 || num2 > num3 && num3 > num1)
                System.Console.WriteLine("Valor del medio: {0}", num3);
            else
                System.Console.WriteLine("No hay valor medio");        
        }
    }
}
