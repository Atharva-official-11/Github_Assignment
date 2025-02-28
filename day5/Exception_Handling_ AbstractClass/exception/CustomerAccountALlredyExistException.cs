using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling__AbstractClass.exception
{
    internal class CustomerAccountALlredyExistException:ApplicationException
    {

        public CustomerAccountALlredyExistException() { }

        public CustomerAccountALlredyExistException(string msg):base(msg) { 

        }
    }
}
