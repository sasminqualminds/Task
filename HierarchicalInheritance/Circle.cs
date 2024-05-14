using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    // inheriting the properties and methods of Shape class
    internal class Circle:Shape
    {
        // overriding the virtual method of Shape class
        public override void shape()
        {
            Console.WriteLine("Shape is Circle");
        }

        // method of Circle class
        public void circumferenceOfCircle()
        {
            Console.WriteLine($"Circumference of circle is {2*Math.PI*radius}" );
        }
    }
}
