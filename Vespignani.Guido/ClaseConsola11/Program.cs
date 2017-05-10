using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_11;

namespace ClaseConsola11
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClaseUno a = new ClaseUno("ClaseUno");
            ClaseDos b = new ClaseDos("ClaseUno", "ClaseDos");
            ClaseTres c = new ClaseTres("ClaseUno", "ClaseDos", "ClaseTres");
            ClaseCuatro d = new ClaseCuatro("ClaseUno", "ClaseDos", "ClaseTres", "ClaseCuatro");
            
            List<ClaseUno> _lista = new List<ClaseUno>();
            _lista.Add(a);
            _lista.Add(b);
            _lista.Add(c);
            _lista.Add(d);

            foreach (ClaseUno item in _lista)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine(item.Nombre);
            }
            Console.ReadLine(); 
        }
    }
}
