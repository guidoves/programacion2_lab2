using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14
{
    public enum ETipoNumero
    {
        Par,
        Impar,
        Positivo,
        Negativo,
        Cero
    }
    public class ColectoraDeNumeros
    {
        protected List<Numero> _numeros;

        public ETipoNumero TipoNumero
        {
             
            set;
            //{
            //    //ETipoNumero tipo = value;
            //}
            get;
            //{
            //    //return TipoNumero;
            //}
        }

        private ColectoraDeNumeros()
        {
            this._numeros = new List<Numero>();
        }
        public ColectoraDeNumeros(ETipoNumero tipo):this()
        {
            this.TipoNumero = tipo;
        }

        public static bool operator ==(ColectoraDeNumeros a, Numero b)
        {
            foreach (Numero item in a._numeros)
            {
                if (item.Num == b.Num)
                    return true;
                
            }
            return false;
        }
        public static bool operator !=(ColectoraDeNumeros a, Numero b)
        {
            return !(a == b);
        }
        public static ColectoraDeNumeros operator +(ColectoraDeNumeros a, Numero b)
        {
           switch(a.TipoNumero)
           {
               case ETipoNumero.Cero:
                   if (b.Num == 0)
                       a._numeros.Add(b);
                   else
                       throw new Exception("El numero es distinto de 0!");//Console.WriteLine("El numero es distinto de 0");
                   break;
               case ETipoNumero.Impar:
                   if(b.Num%2 != 0)
                       a._numeros.Add(b);
                   else
                       throw new Exception("El numero no es impar!");//Console.WriteLine("El numero no es impar");
                   break;
               case ETipoNumero.Par:
                   if(b.Num%2 == 0)
                       a._numeros.Add(b);
                   else
                       throw new Exception("El numero no es par!");//Console.WriteLine("El numero no es par");
                   break;
               case ETipoNumero.Positivo:
                   if(b.Num > 0)
                       a._numeros.Add(b);
                   else
                       throw new Exception("El numero no es positivo!");//Console.WriteLine("El numero no es positivo");
                   break;
               case ETipoNumero.Negativo:
                   if(b.Num < 0)
                       a._numeros.Add(b);
                   else
                   throw new Exception("El numero no es negativo!");//Console.WriteLine("El numero no es negativo");
                   break;
           }
            return a;
        }
        public static ColectoraDeNumeros operator -(ColectoraDeNumeros a, Numero b)
        {
            foreach (Numero item in a._numeros)
            {
                if (item.Num == b.Num)
                {
                    a._numeros.Remove(item);
                    break;
                }
            }
            
            return a;
        }
        public override string ToString()
        {
            StringBuilder a = new StringBuilder();
            a.AppendLine("Listado de numeros: ");
            foreach (Numero item in this._numeros)
            {
                a.AppendLine(item.Num.ToString());
            }
            return a.ToString();
        }
    }
    
   
}
