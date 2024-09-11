using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals
{
    public class HelloWorld
    {
        public void HelloWorldFunction()
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Type something and press Enter: ");

            var read = Console.ReadLine();
            Console.WriteLine($"You typed: {read}");
        
        }

    }
}
