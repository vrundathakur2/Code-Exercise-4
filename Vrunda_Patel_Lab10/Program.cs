using System;

namespace Vrunda_Patel_Lab10
{
    class Program
    {
        //Section E:
        //1. In Main method:
        //a.Create all the objects from all of the classes and use the display method to render the message.
        static void Main(string[] args)
        {
            Vehicle veh = new Vehicle();

            veh.Display();

            Console.WriteLine();

            Honda honda = new Honda("Honda");

            honda.Display();

            //Passing the model name to parameterized constructor and creating an object of Civic class
            Civic cv = new Civic("Civic");

            //Calling the Display method in Civic class by using new keyword to hide Display method in the base class: Honda
            cv.Display();

            Console.WriteLine();

            Console.WriteLine("Calling the DisplayType Method in Fruit Class (Abstract Class - Non_Abstarct Method)");
            Console.WriteLine("Using Base class reference variable to create derived class object and then access the abstract class DisplayType() Method");

            Fruit frt = new Apple();

            frt.DiaplayType();
            Console.WriteLine();


            Apple apple = new Apple();

            Console.WriteLine("Overriding the abstract method DisplayName() by DiaplayName() in derived class Apple");
            Console.WriteLine();
            apple.DisplayName();

        }
    }
}
