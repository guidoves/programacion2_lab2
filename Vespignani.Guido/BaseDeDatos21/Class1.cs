using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BaseDeDatos21
{
    public class Class1
    {
        
        
        private SqlConnection _conexion;
        private SqlCommand _command;

        public Class1()
        {
            this._conexion = new SqlConnection(Properties.Settings.Default.Setting);
            this._command = new SqlCommand();

        }
        public bool TestConexion()
        {
            try
            {
                this._conexion.Open();
                this._conexion.Close();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public string TraerInfo()
        {
            try
            {
                this._command.Connection = this._conexion;
                this._command.CommandType = CommandType.Text;
                this._command.CommandText = "SELECT * FROM Personas";
                this._conexion.Open();
                SqlDataReader data = this._command.ExecuteReader();
                StringBuilder info = new StringBuilder();
                while (data.Read())
                {
                    
                    info.AppendLine(data[0].ToString());
                    info.AppendLine(data[1].ToString());
                    info.AppendLine(data[2].ToString());
                    info.AppendLine(data[3].ToString());
                    
                }
                data.Close();
                this._conexion.Close();
                return info.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "";
            }
        }
        public List<Persona> TraerPersonas()
        {
            try
            {
                List<Persona> lista = new List<Persona>();
                Persona aux;

                this._command.Connection = this._conexion;
                this._command.CommandType = CommandType.Text;
                this._command.CommandText = "SELECT * FROM Personas";
                this._conexion.Open();
                SqlDataReader data = this._command.ExecuteReader();
                while (data.Read())
                {
                    aux = new Persona((int)data[0]);
                    aux.Nombre = (string)data[1];
                    aux.Apellido = (string)data[2];
                    aux.Edad = (int)data[3];
                    lista.Add(aux);
                }
                data.Close();
                this._conexion.Close();
                return lista;

            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool AgregarPersona(Persona p)
        {
            try
            {
                this._command.Connection = this._conexion;
                this._command.CommandType = CommandType.Text;
                this._command.CommandText = "INSERT into Personas(nombre,apellido,edad) VALUES(" +"'" + p.Nombre+ "'," + "'"+ p.Apellido + "',"  + p.Edad + ")";
                this._conexion.Open();
                this._command.ExecuteNonQuery();
                this._conexion.Close();
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool ModificarPersona(Persona p)
        {
            try
            {
                this._command.Connection = this._conexion;
                this._command.CommandType = CommandType.Text;
                this._command.CommandText = "UPDATE Personas set nombre='" + p.Nombre + "',apellido='" + p.Apellido + "',edad=" + p.Edad+" WHERE ID=" + p.ID;
                this._conexion.Open();
                this._command.ExecuteNonQuery();
                this._conexion.Close();
                return true;

            }
            catch(Exception e)
            {
                return false;
            }
        }
        public bool EliminarPersona(int id)
           

    }
}
