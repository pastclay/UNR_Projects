/*Andrew Burk 
 * A program that can help a group of social media influencers keep track of their followers.
 * The program will determine the number of influencers as user input.
 * It will then ask for the names of each influencer before displaying the names of each influencer
 * and the number of followers they have.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //User enters number of influencers
                Console.WriteLine("Number of influencers?");
                Console.WriteLine("");
                int number = Convert.ToInt32(Console.ReadLine());

                //Creates a string array of size equal to the number.
                
                string[] numbers = new string[number];


                //Asks user to enter influencer. 
                for (int i = 0; i < numbers.Length; i++)
                {
                    //generates random number for number of followers
                    Random r = new Random();
                    int rInt = r.Next(10000, 100001);
                    Console.WriteLine("Please enter next influencer.");
                    Console.WriteLine("");
                    
                    //Reads user input for array index.
                     numbers[i] = Console.ReadLine();
                    Console.WriteLine("");
                    
                    //Prints out influencer name and random number of followers.
                    Console.WriteLine($"Name: {numbers[i]} followers: {rInt}");
                    Console.WriteLine("");
                    
                    //validates user input to determine if they entered an empty string
                    if (string.IsNullOrEmpty(numbers[i]))
                    {
                        Console.WriteLine("You did not enter anything!");
                    }
                    else
                    {
                        Console.WriteLine("Hello, {0}!", numbers[i]);
                    }

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number!");
            }
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

        }
    }
}
