/*
  This is a comment header
  Alan Yang
  Fall 2019
  Notes file for IS 350
 */  
  
//These lines tell the program we want to use the code from these namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesProject //This is the name of our current namespace and project
{
    class Notes2019f //this is the name of our class
    {
        static void Main(string[] args) //this is the main method
        {
            //week 1-----------------------------------------------------------------------

            Console.WriteLine("hello");

            Console.WriteLine("my name is computer");

            Console.WriteLine("hey");
            //divide(4, 2);
            //this is a line of output
            //errors
            //syntax
            //console.readline();

            ////runtime
            //double solution = divide(4, 2);
            //Console.WriteLine(solution);
            //    divide(4, 0);
            //logic
            //console.writeline("calling divide method, 4 divided by 2 is: ");
            //int x = divide(4, 2);
            //console.writeline(x);
            //console.writeline(divide(4, 2));
            //comment shortcut (control + k + c)
            //uncomment shortcut (control + k + u)
            //macs (cmd + /) or (cmd + k + c and cmd + k + u)

            //week 2-----------------------------------------------------------------------
            //Creating a circle area program

            //Problem: given a circle with radius of 20, what is the area?

            ////store information on this circle
            //double radius = 20;
            //double PI;
            //double area;
            //PI = 3.14;

            ////perform the circle area calculation
            ////area = PI * radius * radius
            //area = PI * radius * radius;
            ////display the results to the user
            ////Console.WriteLine(area);
            ////Console.WriteLine("The area of a circle with radius of {0} is {1}", radius, area);
            ////Console.WriteLine("radius");
            ////Console.WriteLine(radius);
            //////end the program
            //Console.WriteLine("Press enter...");
            //Console.Read();




            ////Enhancing the circle program by allowing user to input value for radius and their name
            ////create information for the circle
            ////create variables
            //double radius = 0;
            //double area = 0;
            //double PI = 3.14;
            //string name = "";
            //////know that pi is 3.14
            //////calculate area
            //////radius is going to be supplied by the user

            //////ask the user for input
            //Console.WriteLine("Enter a value for radius");

            //////capture and store user input 
            //radius = Convert.ToDouble(Console.ReadLine());


            ////ask for their name
            //Console.WriteLine("What's your name?");
            //name = Console.ReadLine();
            //////perform the calculation
            //area = PI * radius * radius;
            //////output the result
            //Console.WriteLine("{0}, area of a circle of radius {1} is {2}", name, radius, area);


            ////Textual data
            //char c = '!';
            //char b = '8';
            //char d = 'd';

            //string s = "keep it 100";
            //string textN = "100";
            //int numN = 100;
            //////adding numeric values 
            // int sum = numN + 29;
            //Console.WriteLine(sum);
            ////trying to add numeric values with textual values
            //sum = textN + 29;


            ////Concatanation
            //string s1 = "Star Wars: ";
            //string s2 = "A New Hope";
            //string s3 = s1 + s2;
            //Console.WriteLine(s3);
            //string s4 = s3 + " part " + 2;
            //Console.WriteLine(s4);


            //Console.WriteLine(s1 + "The Phantom Menance");
            //Console.WriteLine("The sum of " + numN + " and 29 is " + sum);
            //Week 3----------------------------------------------------------------------------
            ////declaring bool variables
            //bool trueOrFalse;
            //bool isStudent;
            //bool over21;
            //bool isRegistered;
            //bool isMember;
            //bool isDiamond;

            //trueOrFalse = true;//setting bool directly
            //Console.WriteLine("trueOrFalse is {0}", trueOrFalse);
            //trueOrFalse = (5 < 4);
            //Console.WriteLine("5 is less than 4 is {0}", trueOrFalse);
            //trueOrFalse = (5 == 5);
            //Console.WriteLine("5 equals 5 is {0}", trueOrFalse);
            //trueOrFalse = (5 != 10);
            //Console.WriteLine("5 does not equal 10 is {0}", trueOrFalse);

            ////if statements
            //Console.WriteLine("Enter a whole number");
            //int uNum = Convert.ToInt32(Console.ReadLine());
            //if (uNum < 10)
            //{
            //    Console.WriteLine("Number is less than 10");
            //}
            //if (uNum < 25)
            //    Console.WriteLine("Number is less than 25");

            //if (uNum < 50)
            //    Console.WriteLine("Number is less than 50");
            //////if-else statements
            //if (uNum < 10)
            //    Console.WriteLine("Number is less than 10");
            //else
            //    Console.WriteLine("Number is greater than or equal to 10");

            ////nested if else
            //if (uNum < 10)
            //{
            //    Console.WriteLine("Number is less than 10");
            //}
            //else if (uNum < 100)
            //{
            //    Console.WriteLine("Number is less than 100");
            //}
            //else if (uNum < 1000)
            //{
            //    Console.WriteLine("Number is less than 1000");
            //}
            //else
            //{
            //    Console.WriteLine("Number is greater than or equal to 1000");
            //}

            ////switch-case statements

            //int x = 50;
            //switch (x)
            //{
            //    case 10:
            //        Console.WriteLine("{0} is 10", x);
            //        break;
            //    default:
            //        Console.WriteLine("{0} is not 10", x);
            //        break;
            //}

            //Console.Write("Input a grade:");
            //char letterGrade = Convert.ToChar(Console.ReadLine());

            //switch (letterGrade)
            //{
            //    case 'A':
            //        Console.WriteLine("Good job!");
            //        Console.WriteLine("You got an A!");
            //        break;

            //    case 'B':
            //        Console.WriteLine("You got a B!");
            //        break;
            //    case 'C':
            //        Console.WriteLine("You got a C!");
            //        break;

            //    default:
            //        Console.WriteLine("Keep trying!");
            //        break;
            //}//switch-case

            ////Boolean And-Or, not
            //bool t1 = true;
            //bool t2 = true;
            //bool t3 = true;
            //bool t4 = true;
            //bool f1 = false;
            //bool f2 = false;
            //bool f3 = false;
            //bool f4 = false;
            //Console.WriteLine(t1 && t2 && t3 && t4 && f1);
            //Console.WriteLine(f1 || f2 || f3 || f4 || t1);

            //Console.WriteLine((5 < 10) && (4 == 6));
            //Console.WriteLine(t1);
            //Console.WriteLine(!(5 == 5));

            ////Additional math
            // //Random
            //Random r = new Random();
            //int randInt = r.Next(0, 10);//generates a number between 0 and 9
            //double randDub = r.NextDouble();//generates a random floating point number between 0 and 1
            ////randInt = r.Next(0, 10);
            ////linking random to text output
            //if(randInt<5)
            //{
            //    Console.WriteLine("Random number was less than 5");
            //}
            //else
            //{
            //    Console.WriteLine("Random number was greater than 5");
            //}

            //Console.WriteLine(randInt);
            //Console.WriteLine(randDub);
            //Casting, converting variables
            ////implicit casting
            //int castNum = 10;
            //double typeUp = castNum;
            //Console.WriteLine(typeUp);
            ////////explicit casting
            //double castDown = 45.9999999999;
            //int typeDown = (int)castDown;
            //Console.WriteLine(typeDown);
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();//stop for main
        }//main method
        public static int divide(int numerator, int denominator)
        {
            return numerator / denominator;
        }//divide method
    }//class
}//namespace NotesProject
