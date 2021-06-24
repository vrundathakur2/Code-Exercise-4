using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vrunda_Patel_Lab10
{
    public class Civic:Honda
    {
        //Section C:
        //1. Create a new class named Civic
        //2. Inherit from Honda
        //3. Try to override display method
        //4. Resolve the compiler error.

        public Civic(string model) : base("Honda")
        {
            this.Name = Name;
            this.Model = model;
        }

        public new void Display()
        {
            Console.WriteLine("Printing from Civic Class");
            Console.WriteLine();
            Console.WriteLine("Tha Name of the Vehicle is: {0}", this.Name);
            Console.WriteLine("Tha Model of the Vehicle is: {0}", this.Model);
        }
    }
}
