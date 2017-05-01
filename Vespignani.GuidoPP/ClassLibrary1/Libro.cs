using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Libro
    {
        protected Autor _autor;
        protected int _cantidadDePaginas;
        protected float _precio;
        protected string _titulo;

        protected static Random _generadorDePaginas;

        public int CantidadDePaginas
        {
            get 
            {
                if (this._cantidadDePaginas == 0)
                    this._cantidadDePaginas = Libro._generadorDePaginas.Next(10, 580);
                return this._cantidadDePaginas;
            }
        }

        public Libro(float precio, string titulo, string nombre, string apellido)
        {
            this._precio = precio;
            this._titulo = titulo;
            Autor b = new Autor(nombre, apellido);
            this._autor = b;

        }
        public Libro(string titulo, Autor autor, float precio)
        {
            this._autor = autor;
            this._titulo = titulo;
            this._precio = precio;
        }
        static Libro()
        {
            Libro._generadorDePaginas = new Random();
        }
        private static string Mostrar(Libro l)
        {
            StringBuilder libro = new StringBuilder();
            libro.AppendLine("TITULO: " + l._titulo);
            libro.AppendLine("CANTIDAD DE PAGINAS: " + l.CantidadDePaginas);
            libro.AppendLine("AUTOR: " + l._autor);
            libro.AppendLine("PRECIO: " + l._precio);
            return libro.ToString();
        }
        public static bool operator ==(Libro a, Libro b)
        {
            if (a._titulo == b._titulo && a._autor == b._autor)
                return true;
            return false;
        }
        public static bool operator !=(Libro a, Libro b)
        {
            return !(a == b);
        }
        public static explicit operator string(Libro l)
        {
            return Libro.Mostrar(l);
        }

    }
}
