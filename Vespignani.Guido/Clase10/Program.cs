using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            Alumno alumno = new Alumno("juan", "perez", 35337649);
            alumno.Notas.Add(8);
            alumno.Notas.Add(9);
            Empleado empleado = new Empleado("jose", "lopez", 24334667);
            Profesor profesor = new Profesor();
            profesor.Nombre = "Pedro";
            profesor.Apellido = "gonalez";
            profesor.Materia = "Programacion";
            personas.Add(alumno);
            personas.Add(empleado);
            personas.Add(profesor);
            foreach (Persona i in personas)
            {
                if (i is Alumno)
                    Console.WriteLine(((Alumno)i).MostrarAlumno());
                else
                {
                    if(i is Profesor)
                    Console.WriteLine(((Profesor)i).MostrarEmpleado() + ((Profesor)i).Materia);
                    else
                    Console.WriteLine(((Empleado)i).MostrarEmpleado());
                }
                    
                
                    
            }
            
            Console.ReadLine();

        }
    }
}
