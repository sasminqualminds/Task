using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    // Base class
    internal class Animal
    {
        // Method to make a sound
        public virtual void MakesSound()
        {
            Console.WriteLine("Animal makes sound");
        }

        // Method to move
        public virtual void Move()
        {
            Console.WriteLine("Animal moves");
        }

        // Method to eat
        public virtual void Eat()
        {
            Console.WriteLine("Animal eats");
        }
    }
}
