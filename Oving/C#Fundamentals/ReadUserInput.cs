using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals
{
    public class ReadUserInput
    {
        public void ReadUserInputFunction()
        {
            Console.WriteLine("What is your favorite color? ");
            string color = Console.ReadLine();
            Console.WriteLine("Mine Too!");
        }
    }
}
