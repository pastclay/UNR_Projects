/* Andrew Burk
A program that will have a user guess whether a person is a musician or a writer.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //stores the musicians and writers names

            string musician1 = "Katie Perry";
            string musician2 = "Bruno Mars";
            string writer1 = "Mark Twain";
            string writer2 = "Tom Clancy";

            //stores users answer to questions, when user enters 1 or else statement happens
            double a;
            double b;
            double c;
            double d;

            //builds random constructor to randomly select a musician or writer
            Random r = new Random();
            int randInt = r.Next(0, 4);

            //switch that takes a random variable to randomly select a musician or writer
            switch (randInt)
            {
                case 0:
                    Console.WriteLine("Is Katie Perry a musician (1) or a writer (2)?");
                    a = Convert.ToDouble(Console.ReadLine());
                    if (a == 1)
                    {
                        Console.WriteLine("Good job! {0} is a musician!", musician1);
                    }
                    else                     {
                        Console.WriteLine("Incorrect! {0} is a musician!", musician1);
                    }
                    break;
                case 1:
                    Console.WriteLine("Is Bruno Mars a musician (1) or a writer (2)?");
                    b = Convert.ToDouble(Console.ReadLine());
                    if (b == 1)
                        Console.WriteLine("Good job! {0} is a musician!", musician2);
                    else
                        Console.WriteLine("Incorrect! {0} is a musician!", musician2);
                    break;
                case 2:
                    Console.WriteLine("Is Mark Twain a musican (1) or a writer (2)?");
                    c = Convert.ToDouble(Console.ReadLine());
                    if (c == 2)
                        Console.WriteLine("Good job! {0} is a writer!", writer1);
                    else
                        Console.WriteLine("Incorrect! {0} is a writer!", writer1);
                    break;
                case 3:
                    Console.Write("Is Tom Clancy a musician (1) or a writer (2)?");
                    d = Convert.ToDouble(Console.ReadLine());
                    if (d == 2)
                        Console.WriteLine("Good job! {0} is a writer!", writer2);
                    else
                        Console.WriteLine("Incorrect! {0} is a writer!", writer2);
                    break;
               default:
                    Console.WriteLine("Please restart!");
                    break;

            }
            //keeps the program from closing after user enters a choice for switch
            Console.WriteLine("Press enter to continue...");
            Console.Read();


        }
    }
}
