using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vrunda_Patel_Lab10
{
    //Section D:
    //1. Create a abstract class name Fruit
    //2. Create two method one abstract and non abstract
    //3. Create Apple class and inherit the Fruit class
    //4. Provide definition of Abstract method.
    public abstract class Fruit
    {
        public void DiaplayType()
        {
            Console.WriteLine("This is a Fruit");
            Console.WriteLine();
        }

        public abstract void DisplayName();
    }
}
