using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    // Derived class inheriting from Animal
    internal class Dog:Animal
    {
        public override void MakesSound()
        {
            Console.WriteLine("Dog barks");
        }

        public override void Move()
        {
            Console.WriteLine("Dog runs");
        }

        public override void Eat()
        {
            Console.WriteLine("Dog eat bones");
        }
    }
}
