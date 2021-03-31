/* Andrew Burk
 * A program to help some local coffee shops manage their menus
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment9
{
    class Program
    {
        static void Main(string[] args)
        {
            //defaultMenu(); assigned to string list menu
            List<string> menu = defaultMenu();
            printMenu(menu);
            menu.RemoveAt(1);
            Console.WriteLine("");
            Console.WriteLine("defaultMenu method passed to printMenu method with Americano removed");
            Console.WriteLine("--------------------------------------------------------------------");
            printMenu(menu);
            Console.WriteLine("");


            //customMenu(4); assigned to string list custom
            List<string> custom = customMenu(4);
            custom.Add("slime");
            Console.WriteLine("customMenu method passed to printMenu method");
            Console.WriteLine("slime added to menu with custom.Add");
            Console.WriteLine("--------------------------------------------");

            printMenu(custom);
            



            Console.WriteLine("Press enter to exit ...");
            Console.Read();
        }




        //prints default list 
        static List<string> defaultMenu()
        {
            Console.WriteLine("defaultMenu method passed to printMenu method");
            Console.WriteLine("---------------------------------------------");
            List<string> cList = new List<string>();
            cList.Add("Coffee");
            cList.Add("Americano");
            cList.Add("Cappuccino");
            return cList;
            
        }
        //prints customMenu list
        static List<string> customMenu(int x)
        {
            Console.WriteLine("customMenu method");
            Console.WriteLine("");
            List<string> menuList = new List<string>();

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Place items on menu?\n");
                string input = Console.ReadLine();
                menuList.Add(input);
                Console.WriteLine("");
            }

            return menuList;

            //returns created string list
        }


        // prints lists from defaultMenu and customMenu
        static void printMenu(List<string> x)
        {
            
            Console.WriteLine($"Number of items: {x.Count} ");
            Console.WriteLine($"Menu items are: ");
            foreach(string item in x)
            {
                Console.WriteLine($"{item}");
            }
           
        }
    }
}

