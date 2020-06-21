using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Serilog;
using System;

namespace PatternDecorator
{
    class Program
    {
        // https://blog.rsuter.com/logging-with-ilogger-recommendations-and-best-practices/
        // https://csharp.christiannagel.com/2018/11/13/iloggertofile/

        static void Main(string[] args)
        {
            var loggerFactory = new LoggerFactory()
                .AddSerilog(new LoggerConfiguration().WriteTo.File(@"c:\LogFiles\Greetings.txt").CreateLogger());
            var logger = loggerFactory.CreateLogger<Program>();

            var greeter = new Greeter();
            var decoratedGreeter = new DecoratedGreeter(greeter, logger);

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            decoratedGreeter.Greet(name);       
        }
    }
}
