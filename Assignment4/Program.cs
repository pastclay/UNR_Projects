/*Andrew Burk
 * Write a program that will ask the user for their name. 
 * If the user does not input anything, display a warning before continuing. 
 * The program will then ask the user whether they want to have an addition, subtraction, multiplication, or division problem. 
 * Once the user indicates their choice, the program will display 2 randomly generated numbers from 1 to 9 in a math problem matching the user’s choice. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Generates random whole number for output to user
            Random r = new Random();
            int randInt = r.Next(1, 10);
            int randInt2 = r.Next(1, 10);
            
            randInt2 = r.Next(1, 10);

            Console.WriteLine("Input a name");
            //string "name" to capture user's name
            string name = Console.ReadLine();
            
            //validates user input to determine if they entered an empty string
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("You did not enter anything!");
            }
            else
            {
                Console.WriteLine("Hello, {0}!", name);
            }

            //prompts user for what type of quiz the user wants
            Console.WriteLine("Do you want an a) addition, b) subtraction, c) multiplication, " +
                "or d) division problem?");
            try
            {
                char choice = Convert.ToChar(Console.ReadLine());
                //displays a quiz matching the type the user requested
                switch (choice)
                {
                    case 'a':
                        Console.WriteLine("{0} + {1}", randInt, randInt2);
                        //prompts the user to enter their answer in the form of a whole number
                        Console.WriteLine("Please enter an answer in the form of a whole number!");
                        int answerAdd = Convert.ToInt32(Console.ReadLine());
                        if (answerAdd == randInt + randInt2)
                        {
                            Console.Write("Congratulations {0}, that is correct!, ", name);
                        }
                        else
                        {
                            Console.WriteLine("That is incorrect, {0}! The correct answer is {1}.", name, randInt + randInt2);
                        }
                        break;
                    case 'b':
                        Console.WriteLine("{0} - {1}", randInt, randInt2);
                        Console.WriteLine("Please enter an answer in the form of a whole number!");
                        int answerSub = Convert.ToInt32(Console.ReadLine());
                        if (answerSub == randInt - randInt2)
                        {
                            Console.Write("Congratulations {0}, that is correct!, ", name);
                        }
                        else
                        {
                            Console.WriteLine("That is incorrect, {0}! The correct answer is {1}.", name, randInt - randInt2);
                        }
                        break;
                    case 'c':
                        Console.WriteLine("{0} * {1}", randInt, randInt2);
                        Console.WriteLine("Please enter an answer in the form of a whole number!");
                        int answerMult = Convert.ToInt32(Console.ReadLine());
                        if (answerMult == randInt * randInt2)
                        {
                            Console.Write("Congratulations {0}, that is correct!, ", name);
                        }
                        else
                        {
                            Console.WriteLine("That is incorrect, {0}! The correct answer is {1}.", name, randInt * randInt2);
                        }
                        break;
                    case 'd':
                        Console.WriteLine("{0} / {1}", randInt, randInt2);
                        Console.WriteLine("Please enter an answer in the form of a whole number!");
                        int answerDiv = Convert.ToInt32(Console.ReadLine());
                        if (answerDiv == randInt / randInt2)
                        {
                            Console.Write("Congratulations {0}, that is correct!, ", name);
                        }
                        else
                        {
                            Console.WriteLine("That is incorrect, {0}! The correct answer is {1}.", name, randInt / randInt2);
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter a-d!");
                        break;
                }
            }
            /* catch statement's to notify user that they need to enter a whole number if they don't enter 
            a whole number */
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number!");
            }
            catch
            {
                Console.WriteLine("Please enter a whole number!");
            }
        
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
