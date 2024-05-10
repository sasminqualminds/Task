using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    // inheriting the properties and methods of Shape class
    internal class Square:Shape
    {
        // overriding the virtual method of Shape class
        public override void shape()
        {
            Console.WriteLine("Shape is Square");
        }

        // methods of square class
        public void areaOfSquare()
        {
            Console.WriteLine("Area of square is " + side*side);
        }
        public void perimeterOfSquare()
        {
            Console.WriteLine("Perimeter of square is " + 4*side);
        }
    }
}
