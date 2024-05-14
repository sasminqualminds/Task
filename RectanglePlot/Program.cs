
// Write a Program to Display Cost of a Rectangle Plot Using Inheritance

namespace RectanglePlot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plot plot = new Plot();
            
            // Asking the user to enter the length of the rectangle
            Console.WriteLine("Enter length of rectangle");
            plot.length =double.Parse(Console.ReadLine());

            // Asking the user to enter the width of the rectangle
            Console.WriteLine("Enter breadth of rectangle");
            plot.breadth = double.Parse(Console.ReadLine());

            // Asking the user to enter the cost per square unit
            Console.WriteLine("Enter cost per sqaure unit");
            plot.cost = double.Parse(Console.ReadLine());
            
            // Printing the cost of the plot
            Console.WriteLine("Cost of the plot: $"+plot.costOfRectanglePlot());
        }
    }
}
