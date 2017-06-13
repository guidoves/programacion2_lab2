using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase22
{
     public interface ISerializable
     {
        bool SerializarXML(string dato);
         bool SerializarBin(string dato);
         bool DeserializarXml(string dato);
         bool DeserializarBin(string dato);
      }
}
