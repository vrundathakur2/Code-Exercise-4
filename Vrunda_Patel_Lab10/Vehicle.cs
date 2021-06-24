using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vrunda_Patel_Lab10
{
    //Section A:
    //1. Create a new class named Vehicle
    //2. Create data member named Name,Model
    //3. Create method to display vehicle name and method
    //4. Mark this display method as virtual.
    public class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public Vehicle()
        {
            this.Name = "Vehicle Name Not Assigned";
            this.Model= "Vehicle Model Not Assigned";
        }

        public Vehicle(string name,string model)
        {
            this.Name = name;
            this.Model = model;
        }

        public virtual void Display()
        {
            Console.WriteLine("Printing from Vehicle Class");
            Console.WriteLine();
            Console.WriteLine("Tha Name of the Vehicle is: {0}",this.Name);
            Console.WriteLine("Tha Model of the Vehicle is: {0}", this.Model);
        }
    }
}
