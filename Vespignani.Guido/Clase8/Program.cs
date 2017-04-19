using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Clase8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tempera> arrayTemperas = new List<Tempera>();
            
            Tempera temp1 = new Tempera(ConsoleColor.Blue,"dsa",5);
            Tempera temp2 = new Tempera(ConsoleColor.Cyan, "dsa", 8);
            Tempera temp3 = new Tempera(ConsoleColor.DarkBlue,"asd",32);
            arrayTemperas.Add(temp1);

            //Stack a = new Stack();
            //Queue b = new Queue();
            //ArrayList c = new ArrayList();
            //Hashtable d = new Hashtable();

            

            //d.Add(108,"hola");
            //d.Add(-99,"chau");
            //d.Add(33, "hola");


            //foreach (int i in d.Keys)
            //{
            //    Console.WriteLine(d[i]);
            //}


            ////a.Push(temp1);
            ////a.Push(temp2);
            ////a.Push(temp3);


            ////int _cantidadA = a.Count;
            ////for(int i = 0 ; i < _cantidadA ; i++)
            ////{
            ////    Console.WriteLine();
            ////}

            


            //c.Add(temp1);
            //c.Add(temp2);
            //c.Add(temp3);
            ////c.Sort();
            
            ////foreach (Tempera i in c)
            ////{

            ////    Console.WriteLine(Tempera.mostrar(i));
            ////}
            
            

            ////a.Push(1);
            ////a.Push(2);
            ////a.Push(3);
            ////a.Push(4);
            ////a.Push(5);

            ////b.Enqueue(1);
            ////b.Enqueue(2);
            ////b.Enqueue(3);
            ////b.Enqueue(4);
            ////b.Enqueue(5);

            ////int _cantidad = a.Count, _cantidadB = b.Count;


            ////for (int i = 0; i < _cantidad; i++)
            ////{
            ////    int aux = (int)a.Pop();
            ////    Console.WriteLine(aux);
            ////    if (aux == 3)
            ////        break;
            ////}
            Console.ReadLine();


        }
    }
}
