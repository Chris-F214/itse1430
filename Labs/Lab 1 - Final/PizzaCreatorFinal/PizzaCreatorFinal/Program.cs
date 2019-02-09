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
                        Console.Clear();
                        SetToDefault();
                        SizeMenu();
                    }
                    break;
                default:
                    {
                        ErrorReport();
                        Showmenu();
                    }
                    break;
            }


        }

        public static void SizeMenu()
        {
            //Size menu options
            Console.WriteLine("Please pick a size.");
            Console.WriteLine("1.) Small: $5 " + SizeSmall);
            Console.WriteLine("2.) Medium: $6.25 " + SizeMedium);
            Console.WriteLine("3.) Large: $8.75 " + SizeLarge);
            Console.WriteLine("4.) Next");
            Console.WriteLine("5.) Cancel");
            string SizeMenuChoice = Console.ReadLine();
            switch (SizeMenuChoice)
            {
                case "1":
                    {
                        if (SizeSmall == false)
                        {
                            SizeSmall = true;
                            PizzaCost += 5m;
                            Console.Clear();
                            CostReport();
                            MeatMenu();
                        }
                        else
                        {
                            SizeSmall = false;
                            PizzaCost -= 5m;
                            Console.Clear();
                            SizeMenu();
                        }
                    }
                    break;

                case "2":
                    {
                        if (SizeMedium == false)
                        {
                            SizeMedium = true;
                            PizzaCost += 6.25m;
                            Console.Clear();
                            CostReport();
                            MeatMenu();
                        }
                        else
                        {
                            SizeMedium = false;
                            PizzaCost -= 6.26m;
                            Console.Clear();
                            SizeMenu();
                        }
                    }
                    break;

                case "3":
                    {
                        if (SizeLarge == false)
                        {
                            SizeLarge = true;
                            PizzaCost += 8.75m;
                            Console.Clear();
                            CostReport();
                            MeatMenu();
                        }
                        else
                        {
                            SizeLarge = false;
                            PizzaCost -= 8.75m;
                            Console.Clear();
                            CostReport();
                            SizeMenu();
                        }
                    }
                    break;
                case "4":
                    {
                        if (SizeSmall == false && SizeMedium == false && SizeLarge == false)
                        {
                            Console.Clear();
                            Console.WriteLine("ERROR: You must select a size");
                            SizeMenu();
                        }
                        else
                        {
                            MeatMenu();
                        }
                    }
                    break;

                case "5":
                    {
                        Console.Clear();
                        Showmenu();
                    }
                    break;
                default:
                    {
                        ErrorReport();
                        SizeMenu();
                    }
                    break;
            }
        }

        public static void MeatMenu()
        {
            //Meat Options
            Console.WriteLine("Would you like to add meat to your order?");
            Console.WriteLine("Each option is $0.75 extra.");
            Console.WriteLine("1.) Bacon: " + Bacon);
            Console.WriteLine("2.) Ham: " + Ham);
            Console.WriteLine("3.) Pepperoni: " + Pepperoni);
            Console.WriteLine("4.) Sausage: " + Suasage);
            Console.WriteLine("5.) Next");
            Console.WriteLine("6.) Cancel");
            string MeatMenuChoice = Console.ReadLine();
            switch (MeatMenuChoice)
            {
                case "1":
                    {
                       if (Bacon == false)
                        {
                            Bacon = true;
                            PizzaCost += 0.75m;
                            Console.Clear();
                            CostReport();
                            MeatMenu();
                        }
                       else
                        {
                            Bacon = false;
                            PizzaCost -= 0.75m;
                            Console.Clear();
                            CostReport();
                            MeatMenu();
                        }

                    }
                    break;
                case "2":
                    {
                        if (Ham == false)
                        {
                            Ham = true;
                            PizzaCost += 0.75m;
                            Console.Clear();
                            CostReport();
                            MeatMenu();
                        } else
                        {
                            Ham = false;
                            PizzaCost -= 0.75m;
                            Console.Clear();
                            CostReport();
                            MeatMenu();
                        }
                    }
                    break;
                case "3":
                    {
                        if (Pepperoni == false)
                        {
                            Pepperoni = true;
                            PizzaCost += 0.75m;
                            Console.Clear();
                            CostReport();
                            MeatMenu();
                        }
                        else
                        {
                            Pepperoni = false;
                            PizzaCost -= 0.75m;
                            Console.Clear();
                            CostReport();
                            MeatMenu();
                        }
                    }
                    break;
                case "4":
                    {
                        if (Suasage == false)
                        {
                            Suasage = true;
                            PizzaCost += 0.75m;
                            Console.Clear();
                            CostReport();
                            MeatMenu();
                        }
                        else
                        {
                            Suasage = false;
                            PizzaCost -= 0.75m;
                            Console.Clear();
                            CostReport();
                            MeatMenu();
                        }
                        break;
                    }
                case "5":
                    {
                        Console.Clear();
                        CostReport();
                        VegetableMenu();
                    }
                    break;
                case "6":
                    {
                        Console.Clear();
                        SizeMenu();
                    }
                    break;
                default:
                    {
                        ErrorReport();
                        MeatMenu();
                    }
                    break;
            }
        }

        public static void VegetableMenu()
        {
            Console.WriteLine("Would you like to add vegetables to your order?");
            Console.WriteLine("");
            Console.WriteLine("Each choice is 0.50 extra.");
            Console.WriteLine("1.) Black Olives: " + BlackOlives);
            Console.WriteLine("2.) Mushrooms: " + Mushrooms);
            Console.WriteLine("3.) Onions: " + Onions);
            Console.WriteLine("4.) Peppers: " + Peppers);
            Console.WriteLine("5.) Next");
            Console.WriteLine("6.) Cancel");
            string VegetableMenuChoice = Console.ReadLine();
            switch (VegetableMenuChoice)
            {
                case "1":
                    {
                        if (BlackOlives == false)
                        {
                            BlackOlives = true;
                            PizzaCost += 0.50m;
                            Console.Clear();
                            CostReport();
                            VegetableMenu();
                        }
                        else
                        {
                            BlackOlives = false;
                            PizzaCost -= 0.50m;
                            Console.Clear();
                            CostReport();
                            VegetableMenu();
                        }
                    }
                    break;
                case "2":
                    {
                        if (Mushrooms == false)
                        {
                            Mushrooms = true;
                            PizzaCost += 0.50m;
                            Console.Clear();
                            CostReport();
                            VegetableMenu();
                        }
                        else
                        {
                            Mushrooms = false;
                            PizzaCost -= 0.50m;
                            Console.Clear();
                            CostReport();
                            VegetableMenu();
                        }
                    }
                    break;
                case "3":
                    {
                        if (Onions == false)
                        {
                            Onions = true;
                            PizzaCost += 0.50m;
                            Console.Clear();
                            CostReport();
                            VegetableMenu();
                        }
                        else
                        {
                            Onions = false;
                            PizzaCost -= 0.50m;
                            Console.Clear();
                            CostReport();
                            VegetableMenu();
                        }
                    }
                    break;
                case "4":
                    {
                        if (Peppers == false)
                        {
                            Peppers = true;
                            PizzaCost += 0.50m;
                            Console.Clear();
                            CostReport();
                            VegetableMenu();
                        }
                        else
                        {
                            Peppers = false;
                            PizzaCost -= 0.50m;
                            Console.Clear();
                            CostReport();
                            VegetableMenu();
                        }
                    }
                    break;
                case "5":
                    {
                        Console.Clear();
                        CostReport();

                    }
                    break;
                case "6":
                    {
                        Console.Clear();
                        MeatMenu();
                    }
                    break;
                default:
                    {
                        ErrorReport();
                        VegetableMenu();
                    }
                    break;
            }

        }

        public static void SauceMenu()
        {
            Console.WriteLine("Please choose a sauce");
            Console.WriteLine("");
            Console.WriteLine("1.) Traditional: $0 " + Traditional);
            Console.WriteLine("2.) Garlic: $1 " + Garlic);
            Console.WriteLine("3.) Oregano: $1 " + Oregano);
            Console.WriteLine("4.) Next");
            Console.WriteLine("5.) Cancel");
            string SauceMenuChoice = Console.ReadLine();
            switch (SauceMenuChoice)
            {
                case "1":
                    {
                        if (Traditional == false)
                        {
                            Traditional = true;
                            Console.Clear();
                        }
                        else
                        {
                            Traditional = false;
                            Console.Clear();
                            SauceMenu();
                        }
                    }
                    break;
                case "2":
                    {
                        if (Garlic == false)
                        {
                            Garlic = true;
                            PizzaCost += 1m;
                            Console.Clear();
                            CostReport();
                        }
                        else
                        {
                            Garlic = false;
                            PizzaCost -= 1m;
                            Console.Clear();
                            CostReport();
                            SauceMenu();
                        }
                    }
                    break;
                case "3":
                    {
                        if (Oregano == false)
                        {
                            Oregano = true;
                            PizzaCost += 1m;
                            Console.Clear();
                            CostReport();
                            SauceMenu();
                        }
                        else
                        {
                            Oregano = false;
                            PizzaCost -= 1m;
                            Console.Clear();
                            CostReport();
                            SauceMenu();
                        }
                    }
                    break;
                case "4":
                    {
                        if (Traditional == false && Garlic == false && Oregano == false)
                        {
                            Console.Clear();
                            Console.WriteLine("ERROR: Must choose at least one sauce option");
                            SauceMenu();
                        }
                        else
                        {

                        }
                    }
                break;
                case "5":
                    {
                        Console.Clear();
                        VegetableMenu();
                    }
                    break;
                default:
                    {
                        ErrorReport();
                    }
                    break;
            }
        }

        public static decimal PizzaCost;

        private static void SetToDefault()
        {
            SizeSmall = false;
            SizeMedium = false;
            SizeLarge = false;
            Bacon = false;
            Ham = false;
            Pepperoni = false;
            Suasage = false;
            BlackOlives = false;
            Mushrooms = false;
            Onions = false;
            Peppers = false;
            PizzaCost = 0m;
        }
        
        //Pizza sizes
        public static bool SizeSmall;
        public static bool SizeMedium;
        public static bool SizeLarge;
        
        //Meats
        public static bool Bacon;
        public static bool Ham;
        public static bool Pepperoni;
        public static bool Suasage;

        //Vegetables
        public static bool BlackOlives;
        public static bool Mushrooms;
        public static bool Onions;
        public static bool Peppers;

        //Sauces
        public static bool Traditional;
        public static bool Garlic;
        public static bool Oregano;

        private static void ErrorReport()
        {
            Console.Clear();
            Console.WriteLine("ERROR: Selection must be a valid number");
        }
        private static void CostReport()
        {
            Console.WriteLine("Your current price is: {0:C}", PizzaCost);
            Console.WriteLine("");
        }
    }
}
