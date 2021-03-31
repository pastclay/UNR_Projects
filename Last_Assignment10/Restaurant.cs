/* Andrew Burk
 * A restaurant class to help manage multiple restaurants and their menus.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    class Restaurant
    {
        public static void Main(string[] args)
        {
            Restaurant r1 = new Restaurant();
            Restaurant r2 = new Restaurant(4, true);
            Restaurant r3 = new Restaurant(3, false);

            r1.setMenuEasy();
            r3.setMenuEasy();

            r2.setMenu();

            r1.restaurantDetails();
            Console.WriteLine();
            r2.restaurantDetails();
            Console.WriteLine();
            r3.restaurantDetails();
            Console.WriteLine();

            Console.WriteLine("press enter to continue...");
            Console.ReadKey();

        }

        static int storeCounter = 1;
        string[] Menu;
        int storeID;
        bool isOpen;


        Restaurant()
        {
            storeID = storeCounter;
            storeCounter++;
            isOpen = true;
            Menu = new string[3];
        }

        Restaurant(int a, bool b)
        {
            storeID = storeCounter;
            storeCounter++;
            isOpen = b;
            Menu = new string[a];
        }

        public void setMenu()
        {
            Console.WriteLine("Restaurant 1 and 3 have a default menu. Please enter 4 items you would like on Restaurant 2's menu.");
            for (int i = 0; i < Menu.Length; i++)
            {
                Menu[i] = Console.ReadLine();
            }
            
        }

        public void setMenuEasy()
        {
            Menu[0] = "Hamburger";
            Menu[1] = "Hot dog";
            Menu[2] = "Pizza";
            
        }
        public void restaurantDetails()
        {
            Console.WriteLine($"Store ID is: {storeID}");
            Console.WriteLine($"Menu items are:");
            for (int i = 0; i < Menu.Length; i++)
            {
                Console.WriteLine($"{Menu[i]}");
            }
            Console.WriteLine();
            if (isOpen == true)
            {
                Console.WriteLine("Restaurant is open");
            } else
            {
                Console.WriteLine("Restaurant is closed");
            }
        }


    }

}
