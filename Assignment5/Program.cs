/* Andrew Burk
 * A pirate needs to do some accounting and has asked for your help. Write a program that will accept a pirate’s starting amount of treasure in number of gold pieces. The program will then run one of two simulations, indicated by the user:
1)	The first simulation runs indefinitely, until one of two conditions is met: the pirate’s treasure falls to 0 or below, or the pirate’s treasure grows to 1000 or above.
2)	The second simulation runs for a number of years set by the user.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {  //prompt for starting treasure amount
                int gold = 0;
                Console.WriteLine("How much starting treasure do you want in gold pieces, Pirate?");
                gold = Convert.ToInt32(Console.ReadLine());

              


                //prompt to choose a simulation
                Console.WriteLine("Please choose a simulation 1) First simulation. or 2) Second simulation.");
                int choice = Convert.ToInt32(Console.ReadLine());
                

                if (choice < 2)

                {
                    Console.WriteLine("Simulation 1. ");  

                    int year = 0;
                    Random r = new Random();
                    //while loop for treasure amount to become a 1000 or more or 0 or less
                    while (gold >= 0 && gold <= 1000)
                    {
                        int x = r.Next(0, 2);
                        if (x == 0)
                        {
                            gold = gold + 50;
                            year = year + 1;
                            Console.WriteLine("The year is {0}. Gold went up by 50! Total gold is {1}", year, gold);
                        }
                        else
                        {
                            gold = gold - 50;
                            year = year + 1;
                            Console.WriteLine("The year is {0}. Gold went down by 50! Total gold is {1}", year, gold);
                        }
                        gold++;
                    }//while
                }//if

                else
                {
                   //second simulation prompting user for number of years, then simulating that many years
                    Console.WriteLine("Simulation 2. How many years?");
                    int years = Convert.ToInt32(Console.ReadLine());
                    Random r = new Random();

                    for (int year = 0; year < years; year++)
                    {
                        int x = r.Next(0, 2);
                        if (x == 0)
                        {
                            gold = gold + 50;
                            Console.WriteLine("The year is {0}. Gold went up by 50! Total gold is {1}", year, gold);
                        }
                        else
                        {
                            gold = gold - 50;
                            Console.WriteLine("The year is {0}. Gold went down by 50! Total gold is {1}", year, gold);
                        }//else
                    }//for
                }//else
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter an integer!");
            }


            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();


        }
    }
}
