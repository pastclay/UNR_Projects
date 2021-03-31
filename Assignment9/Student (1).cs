//Alan Yang
//Student class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p0
{
    class Student
    {
        //delcare variables of students
        //name, gpa, major, age, isFulltime
        String name;
        double gpa;
        String major;
        int age;
        bool isFullTime;
        int studentID;
        static int nextID = 1;
        //static variable
        static string School = "TMCC";
        //default constructor for the student class
        Student()//notice how there are no parameters
        {
            //define starting values/characteristics of newly created objects
            name = "Default name";
            gpa = 1.5;
            major = "General Business";
            age = 18;
            isFullTime = true;
            studentID = nextID;
            nextID++;
        }//default or no-parameter constructor

        //create a constructor with 2 parameters: name and age
        Student(String n, int a)
        {
            name = n;
            age = a;
            studentID = nextID;
            nextID++;
        }

        //Display method
        //Show student statistics, Name, GPA, major, and whether they are fulltime
        public void showStudentDetails()
        {
            Console.WriteLine("Student's name is {0}", name);
            Console.WriteLine("Student's gpa is {0}", gpa);
            Console.WriteLine("Student's major is {0}", major);
            Console.WriteLine("School is: {0}", School);
            Console.WriteLine("Student ID is {0}", studentID);
            if (isFullTime)
            {
                Console.WriteLine("{0} is fulltime", name);
            }
            else
            {
                Console.WriteLine("{0} is not fulltime", name);
            }
            Console.WriteLine();
        }

        //static method
        public static void changeUniversity(string s)
        {
            School = s;
        }

        //write methods to show details of all students elements inside of data structures
        //write one for Lists of students
        public static void showRoster(List<Student> pList)
        {
            for (int i = 0; i < pList.Count; i++)
                pList[i].showStudentDetails();
        }//showRoster, lists

        //Create a method that returns 3 student objects from harry potter
        public static List<Student> Hogwarts()
        {
            //create student objects
            Student s5 = new Student("Harry Potter", 10);
            Student s6 = new Student("Ron Weasly", 10);
            Student s7 = new Student("Hermione Granger", 10);
            //create list and populate
            List<Student> rList = new List<Student> { s5, s6, s7 };
            //return list
            return rList;
        }//hogwarts student list return
        
        //let's create a method together that returns 3 students from another fictional school universe
        public static Student[] GothamHigh()
        {
            //Create student objects
            Student s1 = new Student("Bruce Wayne", 15);
            Student s2 = new Student("Ivy, Poison", 16);
            Student s3 = new Student("Damien Wade", 6);
            //Create array and populate
            Student[] rArr = { s1, s2, s3 };
            //return array
            return rArr;
        }//gotham student array return

        //create a method that returns an array of student objects
        public static Student[] ArkhamAsylum()
        {
            //Create student objects
            Student s1 = new Student("Scarecrow", 16);
            Student s2 = new Student("Two face", 18);
            Student s3 = new Student("Joker", 17);
            //Create and populate a student array
            Student[] rArr = { s1, s2, s3 };
            //return the student array
            return rArr;
        }//aa method

        public static void showRoster(Student[] pArr)
        {
            foreach (Student s in pArr)
                s.showStudentDetails();
        }//showRoster, arrays

        public static void Main(String[]args)
        {
            ////declare a new student object to represent alan
            //Student s1 = new Student();
            ////s1.showStudentDetails();
            //Student s2 = new Student("Bill Gates", 22);
            //s2.showStudentDetails();
            //Console.WriteLine(s1.name);
            //Console.WriteLine(s1.gpa);
            //Console.WriteLine(s1.isFullTime);
            //s1.showStats();
            //Console.WriteLine("Enter a name for the student:");
            //string uInput = Console.ReadLine();
            //Console.WriteLine("Enter an age for the student:");
            //int uNum = Convert.ToInt32(Console.ReadLine());

            //Student s2 = new Student(uInput, uNum);
            //Student s2 = new Student("Bill Gates", 22);
            //s2.showStats();
            //Console.WriteLine("The name of s2 is: {0}", s2.name);
            //Console.WriteLine(s2.gpa);
            //Console.WriteLine(s2.major);
            //Console.WriteLine(s2.age);
            //Console.WriteLine(s2.isFullTime);

            //s1.name = "Alan";


            //Console.WriteLine("The name of s1 is: {0}", s1.name);
            //Console.WriteLine(s1.gpa);
            //Console.WriteLine(s1.major);
            //Console.WriteLine(s1.age);
            //Console.WriteLine(s1.isFullTime);

            //static variables and methods
            //Student s0 = new Student("Doug", 16);
            //Student s10 = new Student();

            //s0.showStudentDetails();
            //s10.showStudentDetails();

            ////s10.name = "alan";
            ////s10.School = "LSU";
            //Student.changeUniversity("UNR");

            //s0.showStudentDetails();
            //s10.showStudentDetails();

            //creating data structures of objects
            //int[] iArr = new int[3];
            //iArr[0] = 1;
            //Console.WriteLine(iArr[0]);
            //List<double> dList = new List<double>();
            ////Console.WriteLine(dList.Count);
            //dList.Add(555.5512);
            //Console.WriteLine(dList[0]);


            Student s1 = new Student("Alan", 28);
            Student s2 = new Student();
            Student s3 = new Student("Mary", 18);
            Student s4 = new Student("Kyle", 22);

            s1.showStudentDetails();
            s2.showStudentDetails();
            s3.showStudentDetails();
            s4.showStudentDetails();

            //Student[] sArr = new Student[2];
            //sArr[0] = s1;
            //sArr[1] = s2;

            //sArr[0].showStudentDetails();
            //sArr[1].showStudentDetails();

            //sArr[0].name = "Justin Bieber";
            //sArr[1].name = "Kim Kardashian";

            //s1.showStudentDetails();
            //s2.showStudentDetails();

            //List<Student> sList = new List<Student> { s1, s2, s3, s4, s5, s6, s7 };
            //showRoster(Hogwarts());
            //for (int i = 0; i < sList.Count; i++)
            //    sList[i].showStudentDetails();

            //foreach (Student s in sList)
            //    s.showStudentDetails();
            //showRoster(sList);
            //Student[] sArr = { s1, s2, s3, s4, s5, s6, s7 };
            //method is called showRoster
            //I want to display sArr using a method call to displayroster
            //showRoster(sArr);
            //showRoster(sList);


            //Student.showRoster(sArr);


            //for (int i = 0; i < sArr.Length; i++)
            //    sArr[i].showStudentDetails();

            //sList.Add(s1);
            //sList.Add(s2);
            //sList now contains the object references of s1 and s2 in indicies of 0 and 1

            //sList[0].showStudentDetails();
            //sList[0].name = "Justin Bieber";
            //s1.showStudentDetails();

            //sList[1].showStudentDetails();
            //s2.gpa = 3.5;
            //sList[1].showStudentDetails();

            //Student s1 = new Student();
            //Student s2 = new Student();
            //Student[] sArr = new Student[2];
            //sArr[0] = s1;
            //sArr[1] = s2;

            //showRoster(sArr);

            //List<Student> sList = new List <Student>{ s1, s2};
            //showRoster(sList);


            //s1.showStudentDetails();
            //s2.showStudentDetails();

            ////s1.name = "The fonz";
            ////s2.name = "Malcom";

            ////Student.School = "UNR";

            ////calling a static method
            //Student.changeUniversity("UNR");


            //s1.showStudentDetails();
            //s2.showStudentDetails();



            //studentList.Add(s1);
            //studentList.Add(s2);
            //studentList.Add(s3);
            //referencing index of object data structure
            // Console.WriteLine(studentList[0]);
            //modifying an object through data struct reference
            //studentList[0].name = "Bill";
            //calling a method through a data structure reference
            //studentList[0].displayDetails();
            //Looping through data structures

            //returning object data structures from methods
            //List<Student> mList = Student.Hogwarts();
            ////method to display is called showRoster
            //showRoster(mList);

            //Student s1 = new Student();
            //Student s2 = new Student();
            //s1.showStudentDetails();
            //s2.showStudentDetails();
            //List<Student> sList = new List<Student> { s1, s2 };
            //showRoster(sList);

            //List<Student> magicalList = Hogwarts();
            //foreach (Student s in magicalList)
            //    s.showStudentDetails();
            //showRoster(GothamHigh());

            //Student[] villansList = ArkhamAsylum();
            //showRoster(villansList);

            Console.WriteLine("Any key to continue..");
            Console.ReadKey();
        }//main

    }//student
}//p0 namespace
