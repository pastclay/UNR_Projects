using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Restaurant
    {
        public static void Main(string[] args)
        {
          //Creates mainMenu object and calls r2.mainMenu() method.
            Restaurant r2 = new Restaurant();
            r2.mainMenu();
        }


        //fields of class to store various information of class
        public int storeID;
        public string[] Menu;
        public bool isOpen;
        public string name;
        public string[] Inventory;
        public string[] foodForSale;
        public string time;
        public string address;
        public string phone;
        public string website;

        //default constructor
        public Restaurant()
        {
            storeID = 1;
            name = " Blue Bird Diner";
            address = "241 S Moreno Dr. Beverly Hills, CA 90210";
            phone = "(310) 285-1000";
            website = "www.BlueBirdDiner.com";
            isOpen = true;
            Menu = new string[2];
            Inventory = new string[3];
            foodForSale = new string[3];
            time = DateTime.Now.ToString();
        }
        //parameterized constructor
        public Restaurant(string a, int b, bool c, string name, string address, string phone, string website)
        {
            time = a;
            storeID = b;
            isOpen = c;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.website = website;
        }

        public void mainMenu()
        {
            //clears the screen, 
            //formats main menu
            //
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n");
            //creates new food objects for while loop
            Food f1 = new Food();
            Food f2 = new Food();
            //variable creates bool for while loop
            bool menuOne = true;
            //creates new restaurant object for while loop
            Restaurant r2 = new Restaurant();
            
            //while loop to display main menu
            while (menuOne)
            {
                Console.WriteLine("Welcome to Restaurant Simulator!");
                Console.WriteLine("1) Restaurant Information. ");
                Console.WriteLine("2) See Menu. ");
                Console.WriteLine("3) Order Meal. ");
                Console.WriteLine("4) Employee Information. ");
                Console.WriteLine("5) Food Inventory. ");
                Console.WriteLine("6) Exit. ");
                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        //sets menuOne to false in each of the cases to stop showing the main menu on a per case basis.
                        //calls restaurantInfo method to display restaurant information
                        r2.restaurantInfo();
                        menuOne = false;
                        break;

                    case "2":
                       //calls seeMenu method to display menu of restaurant
                        f1.seeMenu();
                        menuOne = false;
                        break;

                    case "3":
                        //calls employeeAction2 method to display employee name and thanks customer for stopping by.
                        f2.employeeAction();
                        menuOne = false;
                        break;

                    case "4":
                        //calls employeeAction method to display information about employees.
                        f1.employeeActionTwo();
                        menuOne = false;
                        break;

                    case "5":
                        //calls foodInventory method to display an inventory of food in stock.
                        f2.foodInventory();
                        menuOne = false;
                        break;

                    case "6":
                        //exits the program
                        System.Environment.Exit(0);
                        menuOne = false;
                        break;

                    case "7":
                    default:
                        menuOne = false;
                        break;
                }
            }
        }
       

        //restaurantInfo method to display objects in the restaurantInfo method from the parameterized constructor
        
        public void restaurantInfo()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n");
            
            //creates parameterized constructor Restaurant object
            Restaurant r2 = new Restaurant(time,1,true,name,address,phone,website);
            //prints out formatted parameterized constructor object's variables.
            string s = "     Welcome to the:{0}\n     Date and Time is: {1}\n     The store ID is: {2}\n     The store is open: {3}\n" +
                "     The store address is: {4}\n     Phone number: {5}\n     Website: {6}";
            string msg = string.Format(s, r2.name, r2.time, r2.storeID, r2.isOpen, r2.address, r2.phone, r2.website);
            Console.WriteLine("{0}", msg);
        
            //if statement to return to main menu or exit
            Console.WriteLine();
            Console.Write("     Return to main menu? (1 for yes, 2 to exit)");
            int choice2 = Convert.ToInt32(Console.ReadLine());
            if (choice2 == 1)
            {
                r2.mainMenu();
            }
            else
            {
                System.Environment.Exit(0);
            }
        }


         // orderMeal method to order food.     
        public void orderMeal()
        {

            //instantiates new Restaurant object.
            Restaurant r2 = new Restaurant();
            Console.WriteLine();
            Console.WriteLine($"What would you like to order?\n Please pick a number for sandwich and number for a drink.");
            
            //for loop to read info from customer to  store in r2.Menu array.
            for (int i = 0; i < 2; i++)
            {
                r2.Menu[i] = Console.ReadLine();
            }

            //if statement to ask if finished ordering or to return to main menu or exit
            Console.WriteLine();
            Console.Write("Finished ordering? (1 for yes, 2 to return to main menu.)");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                r2.showOrder();
            }
            else
            {
                r2.mainMenu();
            }
        }

        //showOrder method to show order back to customer with total of items chosen.
        public void showOrder()
        
        {
            //instantiates food object and restaurant object.
            Food f2 = new Food();
            Restaurant r2 = new Restaurant();

            //for loop to print customer order back to them.
            Console.WriteLine($"Ok here is your order:");
            
            for (int i = 0; i < Menu.Length; i++)
            {
                Console.WriteLine(Menu[i]);
            }
           // adds items chosen together and prints price subtotal.
            double x = f2.priceForDrinks[0] + f2.priceForFood[0];
            Console.WriteLine();
            Console.WriteLine($"Your total today will be: {x:C2}.\n " +
                $"Thanks for stopping by I hope you have a wonderful day!");
            Console.WriteLine();
            //if statement to return to main menu or exit
            Console.Write("(1 for main menu)\n (2 to exit.)");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                r2.mainMenu();
            }
            else
            {
                System.Environment.Exit(0);
            }
        }
    }
}

