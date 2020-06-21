using System;
using System.Collections.Generic;
using System.Text;

namespace PatternDecorator
{
    public class Greeter : IGreeter
    {
        public void Greet(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }
    }
}
