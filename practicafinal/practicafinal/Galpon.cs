using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace practicafinal
{
    delegate void Delegado(Object o , EventArgs e);
    
    public class Galpon<T> : IGuardarXml
    {
        List<T> lista;
        int _cantidad;
        event Delegado esImpar;

        public int Cantidad 
        { 
             set
             {
                 if (value == 0)
                 {
                     throw new ArgumentException("El valor debe ser distinto de 0");
                 }

                 if (value.EsPar())
                 {
                     this._cantidad = value;
                 }
                 else
                 {
                     esImpar.Invoke(value,new EventArgs());
                     this._cantidad = value;
                 }

             }
        }

        public List<T> Lista
        {
            get { return this.lista; }
            set { this.lista = value; }
        }

        public Galpon()
        {
            this.lista = new List<T>();
        }

        public Galpon(int cantidad):this()
        {
           // this.lista = new List<T>();
            this.esImpar = this.Manejador;
            this.Cantidad = cantidad;
        }
        public static Galpon<T> operator +(Galpon<T> g1 , T item)
        {
            g1.lista.Add(item);
            return g1;
        }

        private void Manejador(Object o, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "\\log.txt");
                sw.WriteLine(DateTime.Now.ToString() + " " + o.ToString());
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        public bool SerializarXml()
        {
            try
            {
                XmlSerializer xmlser = new XmlSerializer(typeof(Galpon<T>));
                XmlTextWriter xmlwri = new XmlTextWriter(Environment.CurrentDirectory + "\\archivo.xml", Encoding.UTF8);
                xmlser.Serialize(xmlwri, this);
                xmlwri.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
