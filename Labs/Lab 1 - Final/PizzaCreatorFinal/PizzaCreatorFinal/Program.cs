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
            ShowMenu();
        }
        public static void ShowMenu()
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
                case "2":
                    {
                        if (PizzaCost <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("ERROR: There is no order");
                            ShowMenu();
                        }
                        else
                        {
                            Console.Clear();
                            ModifyMenu();
                        }
                    }
                    break;
                case "3":
                    {
                        if (PizzaCost <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("ERROR: There is no order.");
                            ShowMenu();
                        }
                        else
                        {
                            Console.Clear();
                            ShowPizza();
                        }
                    }
                    break;
                case "4":
                    {
                        Environment.Exit(0); 
                    }
                    break;
                default:
                    {
                        Console.Clear();
                        ErrorReport();
                        ShowMenu();
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
                        if (SizeMedium == true || SizeLarge == true)
                        {
                            SizeMedium = false;
                            SizeLarge = false;
                        }
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
                        if (SizeSmall == true || SizeLarge == true)
                        {
                            SizeSmall = false;
                            SizeLarge = false;
                        }
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
                        if (SizeSmall == true || SizeMedium == true)
                        {
                            SizeSmall = false;
                            SizeMedium = false;
                        }
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
                            Console.Clear();
                            MeatMenu();
                        }
                    }
                    break;

                case "5":
                    {
                        Console.Clear();
                        ShowMenu();
                    }
                    break;
                default:
                    {
                        Console.Clear();
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
                        Console.Clear();
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
                        SauceMenu();
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
                        Console.Clear();
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
                            SauceMenu();
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
                            SauceMenu();
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
                            Console.Clear();
                            CostReport();
                            CheeseMenu();
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
                        Console.Clear();
                        ErrorReport();
                        SauceMenu();
                    }
                    break;
            }
        }

        public static void CheeseMenu()
        {
            Console.WriteLine("How much cheese would you like?");
            Console.WriteLine("");
            Console.WriteLine("1.) Regular: $0 " + RegularCheese);
            Console.WriteLine("2.) Extra: $1.25 " + ExtraCheese);
            Console.WriteLine("3.) Next");
            Console.WriteLine("4.) Cancel");
            string CheeseMenuChoice = Console.ReadLine();
            switch (CheeseMenuChoice)
            {
                case "1":
                    {
                        if (ExtraCheese == true)
                        {
                            ExtraCheese = false;
                        }
                        if (RegularCheese == false)
                        {
                            RegularCheese = true;
                            Console.Clear();
                            CostReport();
                            DeliveryMenu();
                        }
                        else
                        {
                            RegularCheese = false;
                            Console.Clear();
                            CostReport();
                            CheeseMenu();
                        }
                    }
                    break;
                case "2":
                    {
                        if (RegularCheese == true)
                        {
                            RegularCheese = false;
                        }
                        if (ExtraCheese == false)
                        {
                            ExtraCheese = true;
                            PizzaCost += 1.25m;
                            Console.Clear();
                            CostReport();
                            DeliveryMenu();
                        }
                        else
                        {
                            ExtraCheese = false;
                            PizzaCost -= 1.25m;
                            Console.Clear();
                            CostReport();
                            CheeseMenu();
                        }
                    }
                    break;
                case "3":
                    {
                        if (RegularCheese == false && ExtraCheese == false)
                        {
                            Console.Clear();
                            Console.WriteLine("ERROR: You must choose at least one option.");
                            CheeseMenu();
                        }
                        else
                        {
                            Console.Clear();
                            CostReport();
                            DeliveryMenu();
                        }
                    }
                    break;
                case "4":
                    {
                        Console.Clear();
                        SauceMenu();
                    }
                    break;
                default:
                    {
                        Console.Clear();
                        ErrorReport();
                        CheeseMenu();
                    }
                    break;
            }
        }

        public static void DeliveryMenu()
        {
            Console.WriteLine("How would you like to recieve your pizza?");
            Console.WriteLine("");
            Console.WriteLine("1.) Take Out: $0 " + TakeOut);
            Console.WriteLine("2.) Delivery: $2.50 " + Delivery);
            Console.WriteLine("3.) To Receipt");
            Console.WriteLine("4.) Cancel");
            string DeliveryMenuChoice = Console.ReadLine();
            switch (DeliveryMenuChoice)
            {
                case "1":
                    {
                        if (Delivery == true)
                        {
                            Delivery = false;
                        }
                        if (TakeOut == false)
                        {
                            TakeOut = true;
                            Console.Clear();
                            ShowPizza();
                        }
                        else
                        {
                            TakeOut = false;
                            Console.Clear();
                            DeliveryMenu();
                        }
                    }
                    break;
                case "2":
                    {
                        if (TakeOut == true)
                        {
                            TakeOut = false;
                        }
                        if (Delivery == false)
                        {
                            Delivery = true;
                            Console.Clear();
                            ShowPizza();
                        } 
                        else
                        {
                            Delivery = false;
                            Console.Clear();
                            DeliveryMenu();
                        }
                    }
                    break;
                case "3":
                    {
                        if (TakeOut == false && Delivery == false)
                        {
                            Console.Clear();
                            Console.WriteLine("You must choose one option");
                            DeliveryMenu();
                        }
                        else
                        {
                            Console.Clear();
                            ShowPizza();
                        }
                    }
                    break;
                case "4":
                    {
                        Console.Clear();
                        CheeseMenu();
                    }
                    break;
                default:
                    {
                        Console.Clear();
                        ErrorReport();
                        DeliveryMenu();
                    }
                    break;
            }
        }

        public static void ShowPizza()
        {
            ShowSize();
            ShowDelivery();
            Console.WriteLine("");
            Console.WriteLine("Meats");
            ShowMeats();
            Console.WriteLine("");
            Console.WriteLine("Vegetables");
            ShowVegetables();
            Console.WriteLine("");
            Console.WriteLine("Cheese");
            ShowCheese();
            Console.WriteLine("");
            Console.WriteLine("Sauce");
            ShowSauce();
            Console.WriteLine("------------------");
            Console.WriteLine("Total       " + PizzaCost);
            Console.WriteLine("");
            Console.WriteLine("1.) Back to menu");
            string RecieptChoice = Console.ReadLine();
            switch (RecieptChoice)
            {
                case "1":
                    {
                        Console.Clear();
                        ShowMenu();
                    }
                    break;
                default:
                    {
                        Console.Clear();
                        ErrorReport();
                        ShowPizza();
                    }
                    break;
            }
        }

        public static void ModifyMenu()
        {
            Console.WriteLine("What part of your order would you like to modify?");
            Console.WriteLine("");
            Console.WriteLine("1.) Size");
            Console.WriteLine("2.) Meats");
            Console.WriteLine("3.) Vegetables");
            Console.WriteLine("4.) Sauce");
            Console.WriteLine("5.) Cheese");
            Console.WriteLine("6.) Delivery options");
            Console.WriteLine("7.) Cancel");
            string ModifyMenuChoice = Console.ReadLine();
            switch (ModifyMenuChoice)
            {
                case "1":
                    {
                        Console.Clear();
                        SizeMenu();
                    }
                    break;
                case "2":
                    {
                        Console.Clear();
                        MeatMenu();
                    }
                    break;
                case "3":
                    {
                        Console.Clear();
                        VegetableMenu();
                    }
                    break;
                case "4":
                    {
                        Console.Clear();
                        SauceMenu();
                    }
                    break;
                case "5":
                    {
                        Console.Clear();
                        CheeseMenu();
                    }
                    break;
                case "6":
                    {
                        Console.Clear();
                        DeliveryMenu();
                    }
                    break;
                case "7":
                    {
                        Console.Clear();
                        ShowMenu();
                    }
                    break;
                default:
                    {
                        Console.Clear();
                        ErrorReport();
                        ModifyMenu();
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

        //Cheese
        public static bool RegularCheese;
        public static bool ExtraCheese;

        //Delivery
        public static bool TakeOut;
        public static bool Delivery;

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

        private static void ShowSize()
        {
            if (SizeSmall == true)
            {
                Console.WriteLine("Small Pizza-----$5");
            }

            if (SizeMedium == true)
            {
                Console.WriteLine("Medium Pizza-----$6.25");
            }

            if (SizeLarge == true)
            {
                Console.WriteLine("Large Pizza-----$8.75");
            }
        }

        private static void ShowDelivery()
        {
            if (TakeOut == true)
            {
                Console.WriteLine("Takeout-----$0");
            }
            if (Delivery == true)
            {
                Console.WriteLine("Delivery-----$2.50");
            }
        }

        private static void ShowMeats()
        {
            if (Bacon == true)
            {
                Console.WriteLine("Bacon-----$0.75");
            }
            if (Ham == true)
            {
                Console.WriteLine("Ham-----$0.75");
            }
            if (Pepperoni == true)
            {
                Console.WriteLine("Pepperoni-----$0.75");
            }
            if (Suasage == true)
            {
                Console.WriteLine("Suasage-----$0.75");
            }
        }

        private static void ShowVegetables()
        {
            if (BlackOlives == true)
            {
                Console.WriteLine("Black Olives-----$0.50");
            }
            if (Mushrooms == true)
            {
                Console.WriteLine("Mushrooms-----$0.50");
            }
            if (Onions == true)
            {
                Console.WriteLine("Onions-----$0.50");
            }
            if (Peppers == true)
            {
                Console.WriteLine("Peppers-----$0.50");
            }
        }

        private static void ShowSauce()
        {
            if (Traditional == true)
            {
                Console.WriteLine("Traditional-----$0");
            }
            if (Garlic == true)
            {
                Console.WriteLine("Garlic-----$1");
            }
            if (Oregano == true)
            {
                Console.WriteLine("Oregano-----$1");
            }
        }

        private static void ShowCheese()
        {
            if (RegularCheese == true)
            {
                Console.WriteLine("Regular-----$0");
            }
            if (ExtraCheese == true)
            {
                Console.WriteLine("Extra-----$1.25");
            }
        }
    }
}
