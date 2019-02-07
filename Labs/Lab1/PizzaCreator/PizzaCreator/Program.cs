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
            Showmenu();
        }
        private static void Showmenu()
        {
            Console.WriteLine("Welcome to Papa Ceaser's Pizza");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1.) Start new order");
            Console.WriteLine("2.) Modify order");
            Console.WriteLine("3.) Display order");
            Console.WriteLine("4.) Exit");
            Console.WriteLine("Please make a selection. ");
            string MainMenuChoice = Console.ReadLine();
            switch (MainMenuChoice)
            {
                case "1":
                    {
                            decimal NewPizzaSize = 0;
                            Console.WriteLine("Please pick a size.");
                            Console.WriteLine("1.) Small $5");
                            Console.WriteLine("2.) Medium $6.25");
                            Console.WriteLine("3.) Large $8.75");
                            string SizeChoice = Console.ReadLine();
                        switch (SizeChoice)
                        {
                            case "1":
                                {
                                    NewPizzaSize = 5;
                                    var SizeSm = String.Format("Your Price is: {0:C}", NewPizzaSize);
                                    Console.WriteLine(SizeSm);
                                    break;
                                }

                            case "2":
                                {
                                    NewPizzaSize = 6.25m;
                                    var SizeM = String.Format("Your Price is: {0:C}", NewPizzaSize);
                                    Console.WriteLine(SizeM);
                                    break;
                                }
                            case "3":
                                {
                                    NewPizzaSize = 8.75m;
                                    var SizeM = String.Format("Your Price is: {0:C}", NewPizzaSize);
                                    Console.WriteLine(SizeM);
                                    break;
                                }
                        }
                        Console.WriteLine("Please select a meat.");
                        Console.WriteLine("1.) Bacon");
                        Console.WriteLine("2.) Ham");
                        Console.WriteLine("3.) Pepperoni");
                        Console.WriteLine("4.) Sausage");
                        Console.WriteLine("5.) None");
                        Console.ReadLine();
                        break;
                    }


                case "2":
                    {
                            Console.WriteLine("incomplete");
                            break;
                    }
                case "3":
                    {
                        break;
                    }
                case "4":
                    {
                        break;
                    }
            }
        }
    }
}
