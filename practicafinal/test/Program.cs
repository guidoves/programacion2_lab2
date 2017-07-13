using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practicafinal;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
         /*   #region Punto 1
            Int32 a = 4;
            Int32 b = 9;

            Console.WriteLine(a.ToString() + " es par: " + a.EsPar());
            Console.WriteLine(a.ToString() + " es impar: " + a.EsImpar());
            Console.WriteLine(b.ToString() + " es par: " + b.EsPar());
            Console.WriteLine(b.ToString() + " es par: " + b.EsImpar());
            Console.ReadLine();
            #endregion
            */
          
            //#region Punto 2
            //Stack<double> pila = new Stack<double>();
            //Queue<double> cola = new Queue<double>();

            //pila.Push(1);
            //pila.Push(2);
            //pila.Push(3);

            //cola.Enqueue(pila.Pop());
            //cola.Enqueue(pila.Pop());
            //cola.Enqueue(pila.Pop());

            //pila.Push(cola.Dequeue());
            //pila.Push(cola.Dequeue());
            //pila.Push(cola.Dequeue());

            //while (pila.Count != 0)
            //{
            //    Console.WriteLine(pila.Pop());
            //}
            //Console.ReadLine();


            //#endregion

            //#region Punto 3

            Producto p1 = new Producto("atun", 2);
            Producto p2 = new Producto("tomate", 3);
            Producto p3 = new Producto("lechuga", 1);

            //Producto p5 = new Producto("atun", 2);
            //Producto p6 = new Producto("lentejas", 2);
            //Producto p7 = new Producto("tomate", 4);

            Deposito deposito1 = new Deposito();
            //Deposito deposito2 = new Deposito();
            //Deposito deposito3 = new Deposito();

            deposito1.listaProductos.Add(p1);
            deposito1.listaProductos.Add(p2);
            deposito1.listaProductos.Add(p3);

            //deposito2.listaProductos.Add(p5);
            //deposito2.listaProductos.Add(p6);
            //deposito2.listaProductos.Add(p7);

            //deposito3.listaProductos = deposito1 + deposito2; 

            //Console.WriteLine(deposito1.ToString());
            //Console.WriteLine(deposito2.ToString());
            //Console.WriteLine(deposito3.ToString());


            //Console.ReadLine();
            //#endregion

            //#region punto4

            //Galpon<int> a = new Galpon<int>(5);

            //#endregion

            #region punto 7

            Galpon<Deposito> listadepositos = new Galpon<Deposito>();
            listadepositos += deposito1;
            listadepositos.SerializarXml();


            #endregion


        }
    }
}
