using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciGenerator.Exceptions
{
    public class InputTooShortException : Exception
    {
        public InputTooShortException() { }

        public InputTooShortException(string message): base(message)
        {
        }
    }
}
