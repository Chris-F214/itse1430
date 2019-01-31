using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class Program
    {
        static void Main( string[] args )
        {
            string selection;
            Console.WriteLine("Welcome to Papa Ceaser's Pizza");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1.) Start new order");
            Console.WriteLine("2.) Modify order");
            Console.WriteLine("3.) Display order");
            Console.WriteLine("4.) Exit");
            Console.WriteLine("Please make a selection: ");
            selection = Console.ReadLine();
            string descision = "Very well. " + selection;

            Console.WriteLine(descision);
        }
    }
}
