/* Andrew Burk
 * Math quiz part 2
 * A program that can administer 
 * the math quiz written in assignment 4 to a series of students. 
 * he program will ask for the number of students, 
 * then administer each student 4 randomized math quizzes. 
 * After a student takes the quizzes, 
 * the program will display the number of quizzes that student answered correctly and the number of quizzes answered incorrectly. 
 * Validate all user insput.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {




            //4 math quizes
            //# of students entered as variable
            //Quizzes can be addition,subtraction, multiplication, or division. Chosen  randomly.
            //Each quiz contains 2 whole  numbers and a randomly chosen operation. Answer should be whole number.
            //At end of 4 quizzes, output how many times the student answered correctly 
            //and how many times the student answered incorrectly

            //Validate all user input.

            



            //Asks how many students will be taking the quiz.
            try
            {
                Console.WriteLine("Welcome to your math quiz, how many students will be " +
                    "taking this math quiz?");

                int students = Convert.ToInt32(Console.ReadLine());
                //# of students as outer loop
                for (int student = 0; student < students; student++)
                {
                    Random r = new Random();
                    int randInt = r.Next(1, 10);
                    int randInt2 = r.Next(1, 10);

                    Console.WriteLine("These are the quizzes for student {0}", student + 1);

                    int correct = 0;
                    int incorrect = 0;
                    //for loop for picking random quizzes
                    for (int quiz = 0; quiz < 4; quiz++)
                    {

                        //Picks random quiz
                        int nextquiz = r.Next(0, 4);

                        if (nextquiz == 0)
                        {
                            Console.WriteLine("You randomly get an addition quiz");
                            Console.WriteLine("{0} + {1}", randInt, randInt2);
                            Console.WriteLine("Enter a whole number please!");
                            int answerAdd = Convert.ToInt32(Console.ReadLine());
                            if (answerAdd == randInt + randInt2)
                            {

                                correct += 1;

                            }
                            else
                            {

                                incorrect += 1;

                            }
                        }
                        else if (nextquiz == 1)
                        {
                            Console.WriteLine("You randomly get a subtraction quiz");
                            Console.WriteLine("{0} - {1}", randInt, randInt2);
                            Console.Write("Enter a whole number please!");
                            int answerSub = Convert.ToInt32(Console.ReadLine());
                            if (answerSub == randInt - randInt2)
                            {

                                correct += 1;

                            }
                            else
                            {

                                incorrect += 1;

                            }
                        }
                        else if (nextquiz == 2)
                        {
                            Console.WriteLine("You randomly get a multiplication quiz");
                            Console.WriteLine("{0} * {1}", randInt, randInt2);
                            Console.WriteLine("Enter a whole number please!");
                            int answerMult = Convert.ToInt32(Console.ReadLine());
                            if (answerMult == randInt * randInt2)
                            {

                                correct += 1;

                            }
                            else
                            {

                                incorrect += 1;

                            }

                        }
                        else if (nextquiz == 3)

                        {
                            Console.WriteLine("You randomly get a division quiz");
                            Console.WriteLine("{0} / {1}", randInt, randInt2);
                            Console.WriteLine("Enter a whole number please!");
                            int answerDiv = Convert.ToInt32(Console.ReadLine());
                            if (answerDiv == randInt / randInt2)
                            {

                                correct += 1;

                            }
                            else
                            {

                                incorrect += 1;

                            }//else

                        }//else

                    }//inner
                    Console.WriteLine("Results of quiz are: Student {0} had {1} correct answers and {2} incorrect answers.", student + 1, correct, incorrect);
                }//outer
            }

            catch (FormatException)
            {
                Console.WriteLine("Please enter an integer! Or a whole number integer!");
            }
            //"Press enter to continue" and Console.ReadLine(); at the end of code.
            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
        }
    }
}


           