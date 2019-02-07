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
            //Menu Options
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
                            //Size Selection
                            decimal PizzaCost = 0;
                            Console.WriteLine("Please pick a size.");
                            Console.WriteLine("1.) Small $5");
                            Console.WriteLine("2.) Medium $6.25");
                            Console.WriteLine("3.) Large $8.75");
                            string SizeChoice = Console.ReadLine();
                        switch (SizeChoice)
                        {
                            case "1":
                                {
                                    PizzaCost = 5;
                                    var SizeSm = String.Format("Your Price is: {0:C}", PizzaCost);
                                    Console.WriteLine(SizeSm);
                                    break;
                                }

                            case "2":
                                {
                                    PizzaCost = 6.25m;
                                    var SizeM = String.Format("Your Price is: {0:C}", PizzaCost);
                                    Console.WriteLine(SizeM);
                                    break;
                                }
                            case "3":
                                {
                                    PizzaCost = 8.75m;
                                    var SizeM = String.Format("Your Price is: {0:C}", PizzaCost);
                                    Console.WriteLine(SizeM);
                                    break;
                                }
                        }
                        //Meat Selection
                        bool MeatMenuFinished = false;
                        Console.WriteLine("Please select a meat. Each selection is $0.75 extra.");
                        Console.WriteLine("Your current price: {0:C}", PizzaCost);
                        bool bacon = false;
                        Console.WriteLine("1.) Bacon: " + bacon);
                        bool ham = false;
                        Console.WriteLine("2.) Ham: " + ham);
                        bool pepperoni = false;
                        Console.WriteLine("3.) Pepperoni: " + pepperoni);
                        bool sausage = false;
                        Console.WriteLine("4.) Sausage: " + sausage);
                        Console.WriteLine("5.) Next");
                        string MeatChoice = Console.ReadLine();
                        switch (MeatChoice)
                        {
                            case "1":
                            {
                                    
                                    if (bacon == false)
                                        {
                                        bacon = true;
                                        PizzaCost += 0.75m;
                                        }
                                    else
                                    {
                                        bacon = false;
                                        PizzaCost -= 0.75m;
                                    }
                                    break;
                            }
                            case "2":
                            {
                                    if (ham == false)
                                    {
                                        ham = true;
                                        PizzaCost += 0.75m;
                                    }
                                    else
                                    {
                                        ham = false;
                                        PizzaCost += 0.75m;
                                    }
                                    return MeatMenu;
                                }
                            
                            case "3":
                            {
                                    if (pepperoni == false)
                                    {
                                        pepperoni = true;
                                        PizzaCost += 0.75m;
                                    } else
                                    {
                                        pepperoni = false;
                                        PizzaCost += 0.75m;
                                    }
                                    return MeatMenu;
                                }
                            case "4":
                            {
                                    if (sausage == false)
                                    {
                                        sausage = true;
                                        PizzaCost += 0.75m;
                                    }
                                    else
                                    {
                                        sausage = false;
                                        PizzaCost -= 0.75m;
                                    }
                                    return MeatMenu;
                                }
                            case "5":
                            {
                                    Console.WriteLine("Please select a vegetable.");
                                    Console.WriteLine("Your current price is: {0:C}", PizzaCost);
                            }
                                break;
                        }
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
