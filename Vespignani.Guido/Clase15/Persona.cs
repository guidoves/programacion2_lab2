using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase15
{
    public enum ESexo
    {
        Masculino,
        Femenino,
        Indefinido
    }
    public class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected int _edad;
        protected ESexo _sexo;

        public Persona(string nombre, string apellido, int edad, ESexo sexo)
        {
            this._apellido = apellido;
            this._edad = edad;
            this._nombre = nombre;
            this._sexo = sexo;
        }

        public string GetNombre()
        {
            return this._nombre;
        }
        public string GetApellido()
        {
            return this._apellido;
        }
        public int GetEdad()
        {
            return this._edad;
        }
        public ESexo GetSexo()
        {
            return this._sexo;
        }
        public string ObtenerInfo()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Nombre:" + this._nombre);
            info.AppendLine("Apellido: " + this._apellido);
            info.AppendLine("Edad: " + this._edad.ToString());
            info.AppendLine("Sexo: " + this._sexo.ToString());
            return info.ToString();
        }
    }
}
