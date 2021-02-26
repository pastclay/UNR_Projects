using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Food
    {

       //Auto properties for get set for seeMenu,menuOrder method and employeeAction,employeeAction2 method
        public string[] employeeNames { get; set; }
        public string[] sandwiches { get; set; }

        public string[] drinks { get; set; }

        public double[] priceForDrinks { get; set; }

        public double[] priceForFood { get; set; }
        public string[] Menu { get; set; }

        public bool inStock { get; set; }

        //variables for foodInventory method
        public string[] drinkStock;
        public string[] foodStock;
        public string stockRoom;
        public string thermostat;
        public string terminal;
        
        


        //default constructor for methods
        public Food()
        {
            
            employeeNames = new string[] { "Fred", "Wilma", "Barney", "Betty" };
            sandwiches = new string[] { "1. Grilled Cheese", "2. Tuna Melt", "3. Italian Sub"};
            drinks = new string[] { "4. Coke", "5. Sprite", "6. Iced Tea" };
            priceForDrinks = new double[3] { .99, .99, .99 };
            priceForFood = new double[3] { 2.99, 2.99, 2.99 };
            inStock = true;
            Menu = new string[2];
            stockRoom = "Stock Room";
            foodStock = new string[] { "Sandwich Supplies\n", "Lettuce:  2 tubs", "Tomatoes: 3 tubs", "Meat:     10 packages", "Cheese:   8 packages", "Tuna:     12 packages", "Bread:    15 bags"};
            drinkStock = new string[] { "Soda syrups\n", "Coke syrup packages:   5","Sprite syrup packages: 4","Ice Tea mix packages:  8"};
            terminal = "Cooler is cooling properly!";
            thermostat = "Cooler is set at: 34";
        
        }


        //public Food(int a, int b, int c, int d, int e, int f)
        //{
        //    this.Menu = new string[a];
        //    this.employeeNames = new string[b];
        //    this.sandwiches = new string[c];
        //    this.drinks = new string[d];
        //    this.priceForFood = new double[e];
        //    this.priceForDrinks = new double[f];
            
        //}

        //parameterized constructor for foodInventory method to display food prep items.
        public Food(string a, string b, string[] c, string[] d, string e)
        {
            terminal = a;
            thermostat = b;
            drinkStock = c;
            foodStock = d;
            stockRoom = e;
      
        }

        //employeeAction method to list employees that customer might be served by.
        public void employeeActionTwo()
        {
            Restaurant r2 = new Restaurant();
            Console.WriteLine("You may be served by one of these fine individuals today: ");
            //Food f1 = new Food();
            foreach (string i in employeeNames)
            {

                Console.WriteLine(i);

            }
                //if statement to return to main menu or to exit program.
                Console.Write("Return to main menu?\n(1 for yes)\n (2 to exit)");
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
        
        // employeeAction2 method to welcome customer to restaurant, and to ask customer if they want to see menu.
        public void employeeAction()
        {
            //Food f1 = new Food();
            Food f2 = new Food();
            Restaurant r2 = new Restaurant();
            //instantiates Random object
            Random r = new Random();
            //sets employee variable to random name from employeeNames[] array.
            int employee = r.Next(f2.employeeNames.Length);
            Console.WriteLine();
            //prints out random employee name to help customer.
            Console.WriteLine($"Hi my name is {employeeNames[employee]} thanks for stopping by I will be right with you!");
            
            //if statement to return to see menu or return to main menu.
            Console.Write("Do you want to see a menu?\n(1 for yes)\n (2 for main menu.)");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                f2.menuOrder();
            }
            else
            {
                r2.mainMenu();
            }
        }
        //foodInventory method which instantiates Food and Restaurant object. Display degree symbol through unicode.
        //prints out foodInventory menu from f2 objects.
        public void foodInventory()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n");
            Food f2 = new Food(terminal, thermostat, drinkStock, foodStock, stockRoom);
            Restaurant r2 = new Restaurant();
           
            int unicode = 176;
            char character = (char)unicode;
            string text = character.ToString();
            
            Console.WriteLine("{0}", f2.stockRoom);
            Console.WriteLine();
            Console.WriteLine("{0}", f2.terminal);
            Console.WriteLine("{0}{1}", f2.thermostat,text);
            Console.WriteLine();
            //for loops to print out the foodStock[] and drinkStock[] array contents.
            for (int i = 0; i < f2.foodStock.Length; i++)
            {
                Console.WriteLine(foodStock[i]);
            }
            Console.WriteLine();
            for (int i = 0; i< f2.drinkStock.Length; i++)
            {
                Console.WriteLine(drinkStock[i]);
            }
            Console.WriteLine();
            //if statements to return to main menu or exit the program.
            Console.Write("Return to main menu? (1 for yes, 2 to exit)");
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
        //seeMenu method to clear screen and instantiates Restaurant object. 
        //prints out menu of food items for sale with formatting.
        public void seeMenu()
        {
            //Food f2 = new Food(0,0,3,3,3,3);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n");
            //display the variables of an object
            Restaurant r2 = new Restaurant();
            Console.WriteLine("By the way we have these food items for sale: ");
            Console.WriteLine();
            Console.WriteLine("{0,-20}  {1,9} {2,11}\n", "Delicious Sandwiches!", "Prices", "In Stock");
            for (int ctr = 0; ctr < sandwiches.Length; ctr++)
            {
                Console.WriteLine("{0,-20} {1,10:C2} {2,10}", sandwiches[ctr], priceForFood[ctr], inStock);
            }

            Console.WriteLine();
            Console.WriteLine("We have these beverages available: ");
            Console.WriteLine();
            Console.WriteLine("{0,-20} {1,11} {2,11}\n", "Thirsty try these!", "Prices", "In Stock");
            for (int ctr = 0; ctr < drinks.Length; ctr++)
                Console.WriteLine("{0,-20} {1,10:C2} {2,10}", drinks[ctr], priceForDrinks[ctr], inStock);
            //if statement to return to main menu or exit the program
            Console.Write("Return to main menu?\n(1 for yes)\n (2 to exit)");
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

        //menuOrder method clears screen
        //instantiates Restaurant object and prints out the menu again 
        //along with asking customer if they are ready to order
        public void menuOrder()
        {
            //Food f2 = new Food(0,0,3,3,3,3);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n");
            Restaurant r2 = new Restaurant();
           
            //formats menu
            Console.WriteLine("By the way we have these food items for sale: ");
            Console.WriteLine();
            Console.WriteLine("{0,-20}  {1,9} {2,11}\n", "Delicious Sandwiches!", "Prices", "In Stock");


            //for loop formats and prints out the sandwiches from sandwiches[] array.
            for (int ctr = 0; ctr < sandwiches.Length; ctr++)
            {
                Console.WriteLine("{0,-20} {1,10:C2} {2,10}", sandwiches[ctr], priceForFood[ctr], inStock);
            }
           
            Console.WriteLine();

            //for loop formats and prints out the drinks from drinks[] array.
            Console.WriteLine("We have these beverages available: ");
            Console.WriteLine();
            Console.WriteLine("{0,-20} {1,11}\n", "Thirsty try these!", "Prices", "In Stock");
            for (int ctr = 0; ctr < drinks.Length; ctr++)
                Console.WriteLine("{0,-20} {1,10:C2} {2,10}", drinks[ctr], priceForDrinks[ctr], inStock);

            //if statement to ask customer if they are ready to order or return to main menu 
            Console.WriteLine();
            Console.Write("Ready to order?\n(1 for yes)\n (2 to return to main menu.)");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                r2.orderMeal();
            }
            else
            {
                r2.mainMenu();
            }



        }
    }
}