using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Exceptions
{
    public class ObjectDoesNotExistException : Exception
    {
        public ObjectDoesNotExistException(string nombre) : base($"El objeto {nombre} no existe")
        {

        }
    }
}
