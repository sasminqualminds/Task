using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    // inheriting all the properties and methods from "AdditionOfThreeNumbers" class
    internal class AdditionOfThreeNumbers: AdditionOfTwoNumbers  
    {
        // created a method that performs addition operation of 3 numbers
        public void addingThreeNumbers()                         
        {
            Console.WriteLine($"Addition of {firstNumber}, {secondNumber} and {thirdNumber} number is {firstNumber + secondNumber + thirdNumber}");
        }
    }
}
