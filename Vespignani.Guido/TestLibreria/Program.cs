using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;
using Entidades.Externa.Sellada;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Xml;

using BaseDeDatos21;
namespace TestLibreria
{
    class Program 
    {
        
        static void Main(string[] args)
        {
             Class1 baseDatos = new Class1();
             Persona miPersona = new Persona(5);
             Persona miPersona2 = new Persona(5);
           
            miPersona.Nombre = "juans";
            miPersona.Apellido = "perez";
            miPersona.Edad = 18;
            miPersona2.Nombre = "carlos";
            miPersona2.Apellido = "gonale";
            miPersona2.Edad = 20;
            //baseDatos.AgregarPersona(miPersona);
            baseDatos.ModificarPersona(miPersona);
            List<Persona> lista = baseDatos.TraerPersonas();
            foreach (Persona item in lista)
            {
                Console.WriteLine(item.ID);
                Console.WriteLine(item.Nombre);
                Console.WriteLine(item.Apellido);
                Console.WriteLine(item.Edad);
            }
            
             Console.ReadLine();
        }
    }
}
