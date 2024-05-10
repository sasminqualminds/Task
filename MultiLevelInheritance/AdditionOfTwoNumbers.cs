using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    internal class AdditionOfTwoNumbers:Number             // inheriting all the properties and methods of class "Number"
    {
        // declared public variable and assigned the value to it
        public int thirdNumber=40;    
        
        // overriding the method of Number class
        public override void operation()
        {
            Console.WriteLine("Addition of numbers");
        }
        
        // created a method which performs addition operation of 2 numbers 
        public void addingTwoNumbers()
        {
            Console.WriteLine($"Addition of {firstNumber} and {secondNumber} is {firstNumber+secondNumber}");
        }

    }
}
