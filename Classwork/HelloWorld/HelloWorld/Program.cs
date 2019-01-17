using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main( string[] args )
        {
            string name;

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            
            //Never Do!!!
            //int a, b;

            //string message = "Hello " + name;
            string message = "Hello ";
            message += name;
            Console.WriteLine(message);
            //Console.Write("Hello ");
            //Console.WriteLine(name);
        }
    }
}
