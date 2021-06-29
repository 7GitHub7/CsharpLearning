using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDotNetWithAngular.Exceptions
{
    public class NotFoundException : Exception
    {
        //call constructor from Excepion with message parameter
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
