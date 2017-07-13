using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicafinal
{
    public class Deposito
    {
        public List<Producto> listaProductos;

        public Deposito()
        {
            listaProductos = new List<Producto>();
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            foreach (Producto item in listaProductos)
            {
                s.AppendLine(item.nombre + " " + item.stock);
            }
            return s.ToString();
        }

        public static List<Producto> operator +(Deposito d1, Deposito d2)
        {
            List<Producto> aux = new List<Producto>();
            int flag = 0;
            foreach (Producto item in d1.listaProductos)
            {
                Producto p = new Producto(item.nombre, item.stock);
                aux.Add(p);
            }
            foreach (Producto i in d2.listaProductos)
            {
                foreach (Producto j in aux)
                {
                    if (i == j)
                    {
                        j.stock += i.stock;
                        flag = 1;
                        break;
                    }
                }
                if(flag == 0)
                    aux.Add(i);
                flag = 0;
            }
            return aux;

        }
    }

}