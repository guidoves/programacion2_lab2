using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14
{
    public class Numero
    {
        protected int _numero;

        public int Num
        {
            get { return _numero; }
        }

        public Numero(int numero)
        { this._numero = numero; }

        public static int operator +(Numero a, Numero b)
        {
            return a.Num + b.Num;
        }
        public static int operator -(Numero a, Numero b)
        {
            return a.Num - b.Num;
        }
        public static int operator *(Numero a, Numero b)
        {
            return a.Num * b.Num;
        }
        public static double operator /(Numero a, Numero b)
        {
            try
            {
                return a.Num / b.Num;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir por 0!");
                return 0;
            }
        }
        
    }
}
