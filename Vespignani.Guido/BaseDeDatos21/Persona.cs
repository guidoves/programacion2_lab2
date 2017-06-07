using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos21
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;
        private int edad;
        
        public Persona(int id)
        {
            this.id = id;
        }
        public Persona()
        { 
        }
        
        

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        

        public int ID
        {
            get { return id; }
        }
        
    }
}
