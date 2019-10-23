/* Andrew Burk
 Program that asks the user for their name; the length and width of a rectangle;
 and the length of a square. The program will then output the input name;the area and perimeter 
 of a rectangle with the dimensions they input; and the area and perimeter of a square with 
 the length they input */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double lengthRectangle;
            double widthRectangle;
            int lengthSquare;
            double areaRectangle;
            double perimeterRectangle;
            int area;
            int perimeter;


            Console.WriteLine("What's your name?");
            name = Console.ReadLine();

            Console.WriteLine("Enter value for Length of rectangle as a double. ");
            lengthRectangle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for Width of rectangle as a double.");
            widthRectangle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for Length of square as an integer.");
            lengthSquare = Convert.ToInt32(Console.ReadLine());

            areaRectangle = lengthRectangle * widthRectangle;
            perimeterRectangle = (2 * lengthRectangle) + (2 * widthRectangle);
            area = lengthSquare * lengthSquare;
            perimeter = 4 * lengthSquare;

            Console.WriteLine("{0}, the area of the rectangle is {1} and the perimeter of the rectangle is {2}, {0} the area of the square is {3} " +
                "and the perimeter of the square is {4}", name, areaRectangle, perimeterRectangle, area, perimeter);

            Console.WriteLine("Press enter to continue...");
            Console.Read();
        }
    }
}
