using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp71
{
    internal class ErrorExceptions:Exception
    {
        public ErrorExceptions(string message) : base(message)
        {
        }
    }
}
