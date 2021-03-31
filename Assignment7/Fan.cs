/* Andrew Burk 
 * A class called Fan to represent a typical house fan, with two objects from the class.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Fan
    {
        //variables for fan class
        public int speed;
        public bool onOff;
        public double radius;
        public string color;

        //default constructor
        Fan()
        {
            speed = 1;
            radius = 5;
            color = "blue";
            onOff = false;
        }
        //parametrized constructor
        Fan(int a, double b, string c, bool d)
        {
            speed = a;
            radius = b;
            color = c;
            onOff = d;
        }

        //void method to call if fan is on or off
        public void displayFan()
        {
            if (onOff == true)
            {
                Console.WriteLine($"Fan color is : {color}, radius is: {radius}, speed is: {speed}");
            }
            else 
            {
                Console.WriteLine($"Fan color is: {color}, radius is: {radius} and fan is off");
            }//if statement
            
        }//displayFan method 
            


        static void Main(string[] args)
        {
            Fan f1 = new Fan();
            Fan f2 = new Fan(3, 10, "green", true);

            f1.displayFan();
            f2.displayFan();

            Console.ReadKey();
        }
    }
}
