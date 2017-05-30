using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;
using Entidades.Externa.Sellada;
using Clase19;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Xml;
namespace TestLibreria
{
    class Program 
    {
        
        static void Main(string[] args)
        {
            try
            {
                Persona miPersona = new Persona("juan", 23, true);
                Persona miPersona2 = new Persona("Pedro", 11, false);
                Persona miPersona3 = new Persona("lucas", 24, true);
                Persona miPersona4 = new Persona("malena", 30, true);
                string path = AppDomain.CurrentDomain.BaseDirectory+"archivo.txt";
                string path2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"archivo.txt";
                string path3 = @"C:\Users\alumno\Desktop\archivo.dat";
                string path4 = @"D:\arch.xml";

                List<Persona> personas = new List<Persona>();

                personas.Add(miPersona);
                personas.Add(miPersona2);
                personas.Add(miPersona3);
                personas.Add(miPersona4);



                XmlSerializer xmlSer = new XmlSerializer(typeof(List<Persona>));
                XmlTextWriter xmlWri = new XmlTextWriter(path4, Encoding.UTF8);

                xmlSer.Serialize(xmlWri, personas);
                xmlWri.Close();

                List<Persona> personas2 = new List<Persona>();

                

                //FileStream fileStream = new FileStream(path3, FileMode.Create);
                //BinaryFormatter binary = new BinaryFormatter();
                
                

                
            
           

                //using (StreamWriter stream = new StreamWriter(path, true))
                //{
                //    stream.Write("El primer objeto es: ");
                //    stream.WriteLine(miPersona.ToString());
                //    stream.Write("El segundo objeto es: ");
                //    stream.WriteLine(miPersona2.ToString());
                //}
                //using (StreamReader streamin = new StreamReader(path
                //    ))
                //{
                //    Console.WriteLine(streamin.ReadToEnd());
                //    //string a = streamin.ReadLine();
                //    //while (a != null)
                //    //{
                //    //    Console.WriteLine(a);
                //    //    a = streamin.ReadLine();
                //    //    Console.ReadLine();
                //    //}

                //}

                //binary.Serialize(fileStream, miPersona);
                //fileStream.Close();
                //Persona persona3 = (Persona)binary.Deserialize(new FileStream(path3,FileMode.Open));
                //Console.WriteLine(persona3.ToString());
                ////xmlSerializer.Serialize(xmlWriter, miPersona3);
                ////xmlWriter.Close();
                ////Persona persona4 = (Persona)xmlSerializer.Deserialize(new XmlTextReader(path4));
                ////Console.WriteLine(persona4.ToString());  
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
             Console.ReadLine();
            
           
        }
    }
}
