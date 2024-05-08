using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperationsUsingDelegates
{
    internal class Operations
    {
        
        // calculates addition of two numbers and returns the value
        public int add(int firstNumber,int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        // calculates subtraction of two numbers and returns the value
        public int subtract(int firstNumber,int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        // performs multiplication operation on two numbers and returns the value
        public int multiply(int firstNumber,int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        // performs division operation on two numbers and returns the value
        public int divide(int firstNumber,int secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
