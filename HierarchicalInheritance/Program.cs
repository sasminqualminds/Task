
// Write a Program to Demonstrate Hierarchical Inheritance

namespace HierarchicalInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating a instance of square class
            Square square = new Square();
            square.shape();
            square.areaOfSquare();
            square.perimeterOfSquare();

            // creating a instance of Circle class
            Circle circle = new Circle();
            circle.shape();
            circle.circumferenceOfCircle();
        }
    }
}
