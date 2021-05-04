using System;
using System.Collections.Generic;
using System.Text;

namespace RETP.Utilities.exception
{
    public class RETPException : Exception
    {
        public RETPException()
        {

        }
        public RETPException(string message):base(message)
        {

        }
        public RETPException(string message, Exception inner):base(message, inner)
        {

        }
    }
}
