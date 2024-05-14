using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    // Derived class inheriting from Animal
    internal class Cat:Animal
    {
        // Overriding the MakeSound method
        public override void MakesSound()
        {
            Console.WriteLine("Cat makes sound meow");
        }

        // Overriding the Move method
        public override void Move()
        {
            Console.WriteLine("cat jumps");
        }

        // Overriding the Eat method
        public override void Eat()
        {
            Console.WriteLine("cat eats fish");
        }
    }
}
