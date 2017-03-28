using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vespignani.Guido.ej3
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;
        
        public static string Imprimir()
        {
            return ArmarMensaje();
        }
        public static void Borrar()
        {
            Sello.mensaje = null;
        }
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        private static String ArmarMensaje()
        {
            String retorno;
            if(TryParse(Sello.mensaje, out retorno))
            {
                retorno = "";
                int aux = Sello.mensaje.Length, i;
                for (i = 0; i < aux + 2; i++)
                {
                    retorno = retorno + "*";
                }
                retorno = retorno + "\n*" + Sello.mensaje + "*\n";
                for (i = 0; i < aux + 2; i++)
                {
                    retorno = retorno + "*";
                }
            }
            return retorno;
        }
        public static Boolean TryParse(String x, out String y)
        {     
            if (x != null)
            {
                y = x;
                return true;
            }
            y = "No existe el mensaje o ha sido eliminado.";
            return false;         
        }
    }
}
