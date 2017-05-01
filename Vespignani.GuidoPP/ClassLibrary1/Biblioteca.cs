using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Biblioteca
    {
        private int _capacidad;
        private List<Libro> _libros;

        public double PrecioDeManuales
        {
            get { return ObtenerPrecio(ELibro.Manual); }
        }
        public double PrecioDeNovelas
        {
            get { return ObtenerPrecio(ELibro.Novela); }
        }
        public double PrecioTotal
        {
            get { return ObtenerPrecio(ELibro.Ambos); }
        }

        private Biblioteca()
        {
            this._libros = new List<Libro>();
        }
        private Biblioteca(int capacidad):this()
        {
            this._capacidad = capacidad;
        }
        public static string Mostrar(Biblioteca e)
        {
            StringBuilder biblioteca = new StringBuilder();
            biblioteca.AppendLine("Capacidad de la biblioteca:" + e._capacidad.ToString());
            biblioteca.AppendLine("Total por Manuales: " + e.PrecioDeManuales.ToString("c"));
            biblioteca.AppendLine("Total por Novelas: " + e.PrecioDeNovelas.ToString("c"));
            biblioteca.AppendLine("Total: " + e.PrecioTotal.ToString("c"));
            biblioteca.AppendLine("****************************************");
            biblioteca.AppendLine("Listado de Libros");
            biblioteca.AppendLine("****************************************");
            foreach (Libro item in e._libros)
            {
                if(item is Novela)
                    biblioteca.AppendLine(((Novela)item).Mostrar());
                else
                    biblioteca.AppendLine(((Manual)item).Mostrar());
            }
            return biblioteca.ToString();

        }
        public static implicit operator Biblioteca(int capacidad)
        {
            Biblioteca b = new Biblioteca(capacidad);
            return b;
        }
        public static bool operator ==(Biblioteca e, Libro l)
        {
            foreach (Libro item in e._libros)
            {
                if (item == l)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Biblioteca e, Libro l)
        {
            return !(e == l);
        }
        public static Biblioteca operator +(Biblioteca e, Libro l)
        {
            if (e._capacidad > e._libros.Count)
            {
                if (e != l)
                {
                    e._libros.Add(l);
                }
                else
                {
                    Console.WriteLine("El libro ya está en la biblioteca!!!");
                }
            }
            else
            {
                Console.WriteLine("No hay más lugar en la biblioteca!!!");
            }
            return e;
        }
        private double ObtenerPrecio(ELibro tipoLibro)
        {
            double precio = 0;
            foreach (Libro item in this._libros)
            {
                if (tipoLibro == ELibro.Ambos)
                {
                    if (item is Manual)
                        precio += (Manual)item;
                    else
                        precio += (Novela)item;
                }
                else if (tipoLibro == ELibro.Manual)
                {
                    if (item is Manual)
                        precio += (Manual)item;
                }
                else
                {
                    if (item is Novela)
                        precio += (Novela)item;
                }
            }
            return precio;
        }

    }

    public enum ELibro
    {Manual,Novela,Ambos}
}
