using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_PRG152
{
    class Program
    {
        enum Mainmenu
        {
            Breakfast = 1,
            Chips,
            Burgers,
            Sandwich,
            Pizza,
            Baverages,
            Checkout
        }
        enum Breakfastmenu
        {
            Breakfastspeial = 1,
            Hasbrownnegg,
            Sundayspecial,
            Baconneggs,
            Pancake,
            Waffles,
        }
        enum Chips
        {
            Smallchips = 1,
            Mediumchips,
            Largechips
        }
        enum Burgers
        {
            chickenburger = 1,
            beefburger,
            ribburger,
            Vegiburger
        }
        enum Sandwiches
        {
            Chickensandwich = 1,
            Chickenmayo,
            PBsandwich,
            vegisandwich,
        }
        enum Pizza
        {
            Largepeperoni = 1,
            smallpeperoni,
            Meatylarge,
            Meatysmall,
            chillychickensmall,
            chillychickenlarge
        }
        enum Baverages
        {
            Water = 1,
            OrangeJuice,
            Breakfast,
            Apricot,
            Tea,
            Coffee,
            colddrink
        }
        static void Displayingmain()//What will be shown to user when the application is started up and after they entered the correct username and password
        {
            Console.Clear();
            Console.WriteLine("Welcome to Yolo's delights");
            Console.WriteLine("Please choose one of the options of the menu:");
            Console.WriteLine("");
            Console.WriteLine("1. Breakfast");
            Console.WriteLine("2. Chips");
            Console.WriteLine("3. Burgers");
            Console.WriteLine("4. Sandwich");
            Console.WriteLine("5. Pizza");
            Console.WriteLine("6. Beverages");
            Console.WriteLine("7. Checkout");
            Console.WriteLine("");
        }
        static void Displayingchips()//What will be shown to user when the user chooses chips
        {
            Console.Clear();
            Console.WriteLine("Please choose one of the options of the chips:");
            Console.WriteLine("");
            Console.WriteLine("1. Small chips R13");
            Console.WriteLine("2. Medium chips R22");
            Console.WriteLine("3. Large chips R34");
            
            Console.WriteLine("");
        }
        static void Displayingbreakfast()//What will be shown to user when the user chooses breakfast
        {
            Console.Clear();
            Console.WriteLine("Please choose one of the options for Breakfast:");
            Console.WriteLine("");
            Console.WriteLine("1. Breakfast special R25");
            Console.WriteLine("2. Hasbrownegg R20");
            Console.WriteLine("3. Sunday special R25");
            Console.WriteLine("4. Bacon and eggs R35");
            Console.WriteLine("5. Pancake R47");
            Console.WriteLine("6. Waffles R50");
            
            Console.WriteLine("");
        }
        static void Displayingburgers()//What will be shown to user when the user chooses burger
        {
            Console.Clear();
            Console.WriteLine("Please choose one of the options for Burgers:");
            Console.WriteLine("");
            Console.WriteLine("1. Chicken Burger R40");
            Console.WriteLine("2. Beef Burger R40");
            Console.WriteLine("3. Rib Burger R55");
            Console.WriteLine("4. Vegi Burger R43");

            Console.WriteLine("");
        }
        static void Displayingsandwiches()//What will be shown to user when the user chooses sandwiches 
        {
            Console.Clear();
            Console.WriteLine("Please choose one of the options for sandwiches:");
            Console.WriteLine("");
            Console.WriteLine("1. Chicken Sandwich R21");
            Console.WriteLine("2. Chickenmayo R25");
            Console.WriteLine("3. 2 X Peanutbutter and jelly sandwich  R17");
            Console.WriteLine("4. Vegi and salad dresing sandwich R20");

            Console.WriteLine("");
        }
        static void Displayingpizza()//What will be shown to user when the user chooses pizza
        {
            Console.Clear();
            Console.WriteLine("Please choose one of the options for Burgers:");
            Console.WriteLine("");
            Console.WriteLine("1. Large pepperoni pizza R58");
            Console.WriteLine("2. Small pepperoni pizza R30");
            Console.WriteLine("3. Meaty large pizza R58");
            Console.WriteLine("4. Meaty small pizza R30");
            Console.WriteLine("5. Small sweet chilly chicken pizza R30");
            Console.WriteLine("6. Large sweet chilly chicken pizza R58");
            Console.WriteLine("");
        }
        static void Displayingbaverages()//What will be shown to user when the user chooses Baverages
        {
            Console.Clear();
            Console.WriteLine("Please choose one of the options for Baverages:");
            Console.WriteLine("");
            Console.WriteLine("1. Water R5");
            Console.WriteLine("2. Orange juice R13");
            Console.WriteLine("3. Breakfast punch juice R13");
            Console.WriteLine("4. Apricot juice R13");
            Console.WriteLine("5. Tea R15");
            Console.WriteLine("6. Coffee R15");
            Console.WriteLine("7. Cold drink R12(Coke, Fanta etc.) Ask which you want to purchase ");

            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            bool Continue = true, end = false, stop = false;
            string actualpassword = "45tyr", actualusername = "Yolo09",
            attemptpassword = "", attemptusername = "";

            while (end == false)//loop for the entire application
            {
                while (Continue == true)//Login section
                {
                    Console.Clear();
                    Console.WriteLine("Please enter your username");
                    attemptusername = Console.ReadLine();

                    Console.WriteLine("Please enter your password");
                    attemptpassword = Console.ReadLine();

                    if (attemptpassword != actualpassword || attemptusername != actualusername)
                    {
                        Console.WriteLine("The username or password is incorrect. Please enter the correct credentials");
                        Console.WriteLine("Press the enter button to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You have entered the correct credentials. Welcome!");
                        Console.WriteLine("Press the enter button to continue");
                        Console.ReadLine();
                        Console.Clear();
                        Continue = false;

                    }
                }//loop for asking and ensuring the correct credentials from user

                Dictionary<string, int> Tray = new Dictionary<string, int>();//collection which is a "tray" for the user

                double Total = 0, price = 0;

                while (stop == false)//loop for ordering the food from menu and checking out
                {
                    int mainchoice = 0, breakchoice = 0, chipschoice = 0, burgerchoice = 0, sandwichchoice = 0, pizzachoice = 0, baveragechoice = 0, times = 0;
                    string exiting = "";

                    Displayingmain();

                    mainchoice = int.Parse(Console.ReadLine());
                    Mainmenu Decisionmain = (Mainmenu)mainchoice;

                    switch (Decisionmain)//Switch for main menu
                    {
                        case Mainmenu.Breakfast:
                            Displayingbreakfast();

                            breakchoice = int.Parse(Console.ReadLine());
                            Breakfastmenu Decisionbreak = (Breakfastmenu)breakchoice;

                            Console.Clear();
                            switch (Decisionbreak)//switch for breakfast options
                            {
                                case Breakfastmenu.Breakfastspeial:

                                    price =25;
                                    Console.WriteLine();
                                    Console.WriteLine("How many of th Breakfast specials do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Breakfast special", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                case Breakfastmenu.Hasbrownnegg:

                                    price = 20;
                                    Console.WriteLine();
                                    Console.WriteLine("How many of Hasbrowneggs do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Hasbrowneggs", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                case Breakfastmenu.Sundayspecial:

                                    price = 25;
                                    Console.WriteLine();
                                    Console.WriteLine("How many of Sunday Specials do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Sunday Special", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                case Breakfastmenu.Baconneggs:

                                    price = 35;
                                    Console.WriteLine();
                                    Console.WriteLine("How many of Bacon and eggs do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Bacon and eggs", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                case Breakfastmenu.Pancake:

                                    price = 47;
                                    Console.WriteLine();
                                    Console.WriteLine("How many of Pancakes offers do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Pancakes", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                case Breakfastmenu.Waffles:

                                    price = 50;
                                    Console.WriteLine();
                                    Console.WriteLine("How many of Waffles offer do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Waffles", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                default:

                                    Console.WriteLine("Please only choose one of the options provided please");
                                    Console.WriteLine("Press enter to go to the previous page");
                                    Console.ReadLine();

                                    break;
                            }
                            break;

                        case Mainmenu.Chips:
                            Displayingchips();

                            chipschoice = int.Parse(Console.ReadLine());
                            Chips Decisionchips = (Chips)chipschoice;

                            Console.Clear();
                            switch (Decisionchips)
                            {
                                case Chips.Smallchips:

                                    price = 13;
                                    Console.WriteLine();
                                    Console.WriteLine("How many Small chips do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Small chips", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                case Chips.Mediumchips:

                                    price = 22;
                                    Console.WriteLine();
                                    Console.WriteLine("How many Medium chips do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Medium chips", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                case Chips.Largechips:

                                    price = 34;
                                    Console.WriteLine();
                                    Console.WriteLine("How many Large chips do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Large chips", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                default:

                                    Console.WriteLine();
                                    Console.WriteLine("Please only choose one of the options provided please");
                                    Console.WriteLine("Press enter to go to the previous page");
                                    Console.ReadLine();

                                    break;
                            }
                            break;

                        case Mainmenu.Burgers:
                            Displayingburgers();

                            burgerchoice = int.Parse(Console.ReadLine());
                            Burgers Decisionburger = (Burgers)burgerchoice;

                            Console.Clear();
                            switch (Decisionburger)
                            {
                                case Burgers.chickenburger:

                                    price = 40;
                                    Console.WriteLine();
                                    Console.WriteLine("How many Chicken Burgers do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Chicken Burger", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                case Burgers.beefburger:

                                    price = 40;
                                    Console.WriteLine();
                                    Console.WriteLine("How many Beef Burgers do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Beef Burger", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                case Burgers.ribburger:

                                    price = 55;
                                    Console.WriteLine();
                                    Console.WriteLine("How many Rib Burgers do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Rib Burger", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                case Burgers.Vegiburger:

                                    price = 43;
                                    Console.WriteLine();
                                    Console.WriteLine("How many Vegi Burgers do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Vegi Burger", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                default:

                                    Console.WriteLine();
                                    Console.WriteLine("Please only choose one of the options provided please");
                                    Console.WriteLine("Press enter to go to the previous page");
                                    Console.ReadLine();

                                    break;
                            }
                            break;

                        case Mainmenu.Sandwich:
                            Displayingsandwiches();

                            sandwichchoice = int.Parse(Console.ReadLine());
                            Sandwiches Decisionsandwich = (Sandwiches)sandwichchoice;

                            Console.Clear();
                            switch (Decisionsandwich)
                            {
                                case Sandwiches.Chickensandwich:

                                    price = 21;
                                    Console.WriteLine();
                                    Console.WriteLine("How many Chicken Sandwiches do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Chicken Sandwich", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                case Sandwiches.Chickenmayo:

                                    price = 25;
                                    Console.WriteLine();
                                    Console.WriteLine("How many Chickenmayo Sandwiches do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Chickenmayo Sandwich", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                case Sandwiches.PBsandwich:

                                    price = 17;
                                    Console.WriteLine();
                                    Console.WriteLine("How many Peanutbutter and Jelly Sandwiche offer do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("PB and J Sandwich", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                case Sandwiches.vegisandwich:

                                    price = 20;
                                    Console.WriteLine();
                                    Console.WriteLine("How many Vegi Sandwiches do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Vegi Sandwich", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                default:

                                    Console.WriteLine("Please only choose one of the options provided please");
                                    Console.WriteLine("Press enter to go to the previous page");
                                    Console.ReadLine();

                                    break;
                            }
                            break;

                        case Mainmenu.Pizza:
                            Displayingpizza();

                            pizzachoice = int.Parse(Console.ReadLine());
                            Pizza Decisionpizza = (Pizza)pizzachoice;

                            Console.Clear();
                            switch (Decisionpizza)
                            {
                                case Pizza.Largepeperoni:

                                    price = 58;
                                    Console.WriteLine();
                                    Console.WriteLine("How many Large Peperoni pizzas do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Large Peperoni Pizza", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                case Pizza.smallpeperoni:

                                    price = 30;
                                    Console.WriteLine();
                                    Console.WriteLine("How many Small Peperoni pizzas do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Small Peperoni Pizza", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                case Pizza.Meatylarge:

                                    price = 58;
                                    Console.WriteLine();
                                    Console.WriteLine("How many Large Meaty pizzas do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Large Meaty Pizza", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                case Pizza.Meatysmall:

                                    price = 30;
                                    Console.WriteLine();
                                    Console.WriteLine("How many Small Meaty pizzas do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Small Meaty Pizza", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                case Pizza.chillychickensmall:

                                    price = 30;
                                    Console.WriteLine();
                                    Console.WriteLine("How many Small sweet chilli chicken pizzas do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Small Peperoni Pizza", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                case Pizza.chillychickenlarge:

                                    price = 58;
                                    Console.WriteLine();
                                    Console.WriteLine("How many Large Chillichicken pizzas do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Large Chillichicken Pizza", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                default:

                                    Console.WriteLine("Please only choose one of the options provided please");
                                    Console.WriteLine("Press enter to go to the previous page");
                                    Console.ReadLine();

                                    break;
                            }
                            break;

                        case Mainmenu.Baverages:
                            Displayingbaverages();

                            baveragechoice = int.Parse(Console.ReadLine());
                            Baverages Decisionbaverage = (Baverages)baveragechoice;

                            Console.Clear();
                            switch (Decisionbaverage)
                            {
                                case Baverages.Water:

                                    price = 5;
                                    Console.WriteLine();
                                    Console.WriteLine("How many 330ml bottles of water do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("330ml water", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                case Baverages.OrangeJuice:

                                    price = 13;
                                    Console.WriteLine();
                                    Console.WriteLine("How many 330ml bottles of orange juice do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Orange juice", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                case Baverages.Breakfast:

                                    price = 13;
                                    Console.WriteLine();
                                    Console.WriteLine("How many 330ml bottles of Breakfast punch juice do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Breakfast punch juice", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                case Baverages.Apricot:

                                    price = 13;
                                    Console.WriteLine();
                                    Console.WriteLine("How many 330ml bottles of Apricot juice do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Apricot juice", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                case Baverages.Tea:

                                    price = 15;
                                    Console.WriteLine();
                                    Console.WriteLine("How many 330ml mugs of tea do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("tea", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                case Baverages.Coffee:

                                    price = 15;
                                    Console.WriteLine();
                                    Console.WriteLine("How many 330ml mugs of coffee do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("coffee", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                case Baverages.colddrink:

                                    price = 12;
                                    Console.WriteLine();
                                    Console.WriteLine("How many 330ml cans of cold drink do you want?");
                                    times = int.Parse(Console.ReadLine());
                                    Tray.Add("Cold drink", times);

                                    for (int i = 0; i < times; i++)
                                    {
                                        Total += price;
                                    }

                                    break;

                                default:


                                    Console.WriteLine("Please only choose one of the options provided please");
                                    Console.WriteLine("Press enter to go to the previous page");
                                    Console.ReadLine();

                                    break;
                            }
                            break;

                        case Mainmenu.Checkout://displaying the food items ,how many each and total price

                            Console.Clear();
                            Console.WriteLine("These are food items you have ordered:");
                            Console.WriteLine("");

                            foreach (KeyValuePair<string, int> item in Tray)//displaying each item in the collection
                            {
                                Console.WriteLine(item.Key + "  X" + item.Value);
                            }

                            Console.WriteLine("The total amount for your order is: R"+Total);
                            Console.WriteLine("");
                            Console.WriteLine("Please press the enter button to continue");
                            Console.ReadLine();

                            Console.WriteLine("Do you want to exit the application y/n");
                            exiting = Console.ReadLine();

                            Tray.Clear();

                            if (exiting == "y")
                            {
                                stop = true;
                            }
                            else
                            {
                                Total = 0;
                                times = 0;
                            }

                            break;

                        default:
                            break;
                    }
                }
                end = true;
            }
        }
    }
}
