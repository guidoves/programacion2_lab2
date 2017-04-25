using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    public class Alumno : Persona
    {
        //private string _nombre;
        //private string _apellido;
        //private int _dni;
        private string _curso;
        private List<float> _notas;

        public Alumno(string nombre, string apellido, int dni):base(nombre, apellido, dni)
        {
            _notas = new List<float>();
        }


        #region Propiedades
        

        public string Curso
        {
            get { return this._curso; }
            set { this._curso = value; }
        }

        public List<float> Notas
        {
            get { return this._notas; }
            set { this._notas = value; }
        }
        #endregion

        public string MostrarAlumno()
        {
            string alumno = base.MostrarPersona() + 
                "Curso: " + this._curso + "\n" +
                "Notas:\n";
            foreach(float i in this._notas)
            {
                alumno += i.ToString() + "\n";
            }

            return alumno;
        }
        

        
        
        
        
    }
}
