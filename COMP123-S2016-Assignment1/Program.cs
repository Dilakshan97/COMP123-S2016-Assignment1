using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorldToConsole();
        }

        /*
         * Dilakshan Packiyanathan
         * This is my Hello World Assignment
         * @return {string} HelloWorldString
         * @method HelloWorldToConsole
        */
        public static string HelloWorldToConsole()
        {
            string HelloWorldString = "Hello, World!";
            Console.WriteLine(HelloWorldString);
            Console.ReadLine();
            return HelloWorldString;
        }
    }
}
