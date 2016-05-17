using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciGenerator.Exceptions
{
    public class InputTooLongException : Exception
    {
        public InputTooLongException() { }

        public InputTooLongException(string message) : base(message)
        {
        }
    }
}
