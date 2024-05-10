using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritance
{
    internal class Dog:Animal      // inheriting all the properties and methods of parent class "Animal"
    {
        public void nameOfAnimal()
        {
            Console.WriteLine($"{name} is Dog");  // "name" - inherited from Animal class
        }
        public void bark()                        // created a method
        {
            Console.WriteLine("I am barking");
        }


    }
}
