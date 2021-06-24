using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vrunda_Patel_Lab10
{
    public class Honda:Vehicle
    {
        //Section B:
        //1. Create a new class named Honda
        //2. Inherit from Vehicle
        //3. Override the virtual method
        //4. Sealed display method of Honda class

        
        public Honda(string name):base()
        {
            this.Name = name;
            this.Model = base.Model;
        }

        public sealed override void Display()
        {
            Console.WriteLine("Printing from Honda Class");
            Console.WriteLine();
            Console.WriteLine("Tha Name of the Vehicle is: {0}", this.Name);
            Console.WriteLine("Tha Model of the Vehicle is: {0}", this.Model);
            Console.WriteLine();
        }
    }
}
