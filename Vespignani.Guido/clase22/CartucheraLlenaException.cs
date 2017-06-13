using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase22
{
    public class CartucheraLlenaException : Exception
    {
        public CartucheraLlenaException(string menssage):base(menssage)
        {
        }
    }
}
