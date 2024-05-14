
// Write a Program to Demonstrate Single Inheritance

namespace SingleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();            // created a instance of Dog class
                         
            dog.nameOfAnimal();             // calling method of Dog class
            dog.eat();                      // calling method of Dog class which is inherited from Animal class               
            dog.bark();                     // calling a method of Dog class
            
        }
    }
}
