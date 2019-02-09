using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreatorFinal
{
    class Program
    {
        static void Main( string[] args )
        {
            Showmenu();
        }
        public static void Showmenu()
        {
            //Main menu options
            Console.WriteLine("Welcome to Papa Ceaser's Pizza");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1.) Start new order");
            Console.WriteLine("2.) Modify order");
            Console.WriteLine("3.) Display order");
            Console.WriteLine("4.) Exit");
            Console.WriteLine("");
            Console.WriteLine("Please make a selection.");
            string MainMenuChoice = Console.ReadLine();
            switch (MainMenuChoice)
            {
                case "1":
                {
                        SizeMenu();
                }
                break;
            }

        }
        /*private static decimal ReadChoice( string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string Choice = Console.ReadLine();

                if (Decimal.TryParse(Choice, out decimal result))
                    return result;
                Console.WriteLine("Selection must be a number");
            };
        }

        private static decimal s_mainMenuSelection;*/
        public static void SizeMenu()
        {
            //Size menu options
            Console.WriteLine("Please pick a size.");
            Console.WriteLine("1.) Small: $5");
            Console.WriteLine("2.) Medium: $6.25");
            Console.WriteLine("3.) Large: $8.75");
            Console.WriteLine("4.) Cancel");
            string SizeMenuChoice = Console.ReadLine();
            switch (SizeMenuChoice)
            {
                case "1":
                {
                    PizzaCost = 5m;
                    var SizeSm = String.Format("Small selected, your current price is: {0:C}", PizzaCost);
                    Console.WriteLine(SizeSm);

                }
                break;

                case "2":
                {
                    PizzaCost = 6.25m;
                    var SizeM = String.Format("Medium selected, your current price is: {0:C}", PizzaCost);
                    Console.WriteLine(SizeM);

                }
                break;

                case "3":
                {
                     PizzaCost = 8.75m;
                     var SizeLg = String.Format("Large selected, your current price is: {0:C}", PizzaCost);
                     Console.WriteLine(SizeLg);

                }
                break;

                case "4":
                {
                        Showmenu();
                }
                break;

            }
        }

        public static decimal PizzaCost;
    }
}
