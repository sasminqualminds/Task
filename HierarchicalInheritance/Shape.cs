using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    internal class Shape
    {
        // fields
        public int side=4;
        public double radius = 2;

        // virtual method
        public virtual void shape()
        {
            Console.WriteLine("I am a shape");
        }
    }
}
