
// Write a Program to Demonstrate the Overriding

namespace Overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Calling MakeSound, Move, and Eat methods of base class
            animal.MakesSound();
            animal.Move();
            animal.Eat();
            Console.WriteLine();

            // Calling MakeSound, Move, and Eat methods of derived classes
            dog.MakesSound();
            dog.Eat();
            dog.Move();
            Console.WriteLine();

            cat.MakesSound();
            cat.Eat();
            cat.Move();
            Console.WriteLine();
        }
    }
}
